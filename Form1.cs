using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;

namespace Password.Generator
{
    public partial class Form1 : Form
    {
        private string folderPath = "";
        private Label? lblSecurityWarning;
        private bool vaultPasswordsRevealed = false;
        private List<VaultEntry> vaultEntries = new List<VaultEntry>();
        private Button? btnVaultEdit;

        public Form1()
        {
            InitializeComponent();
            trackBarlength.Minimum = 5;
            trackBarlength.Maximum = 25;

            lblError.Font = new Font(lblError.Font, FontStyle.Bold);
            lblError.Text = "";

            folderPath = Properties.Settings.Default.FolderPath;

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            // Wire up new controls
            comboBoxSpecialChars.SelectedIndex = 2;
            btnLoadDictionary.Click += btnLoadDictionary_Click;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            textBoxpw.UseSystemPasswordChar = true;
            btnSaveToVault.Click += BtnSaveToVault_Click;
            btnVaultDialogOK.Click += BtnVaultDialogOK_Click;
            txtVaultSearch.TextChanged += TxtVaultSearch_TextChanged;
            btnVaultEdit = new Button();
            btnVaultEdit.Text = "Edit";
            btnVaultEdit.Location = new Point(800, 100);
            btnVaultEdit.Size = new Size(80, 30);
            btnVaultEdit.Visible = false;
            vaultDetailsPanel.Controls.Add(btnVaultEdit);
            btnVaultEdit.Click += BtnVaultEdit_Click;
            txtVaultNotes.ReadOnly = true;
            txtVaultDialogUsername.ReadOnly = true;
        }

        const string LowerCharacters = "abcdefghijklmnopqrstuvwxyz";
        const string UpperCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string DigitsCharacters = "1234567890";
        const string SpecialCharacters = "~!@#$%^&*_-+=(){}[]:;<>,.?/";

        // Refactored: Modular password generation logic
        public enum SpecialCharSetOption
        {
            Minimal, // e.g. !@#$%
            Moderate, // e.g. !@#$%^&*_-+=
            Full // all allowed
        }

        private static readonly string MinimalSpecialCharacters = "!@#$%";
        private static readonly string ModerateSpecialCharacters = "!@#$%^&*_-+=";
        private static readonly string FullSpecialCharacters = "~!@#$%^&*_-+=(){}[]:;<>,.?/";

        // Built-in dictionary for exclusion (can be expanded or loaded from file)
        private static readonly HashSet<string> BuiltInDictionary = new HashSet<string>(
            new[] { "password", "admin", "welcome", "letmein", "qwerty", "abc123", "iloveyou", "monkey", "dragon", "sunshine", "princess", "football", "charlie", "donald", "whatever", "baseball", "superman", "michael", "shadow", "master", "killer", "hannah", "jessica", "jordan", "jennifer", "hunter", "buster", "soccer", "harley", "batman", "andrew", "tigger", "sunset", "ashley", "thomas", "robert", "matthew", "daniel", "joshua", "maggie", "cheese", "ginger", "pepper", "snoopy", "cookie", "bailey", "shadow", "lucky", "sophie", "tiger", "princess", "rocky", "molly", "buddy", "daisy", "bella", "max", "lucy", "charlie", "jack", "sadie", "oliver", "toby", "chloe", "zoey", "lola", "sasha", "simon", "sammy", "baxter", "coco", "missy", "angel", "bandit", "duke", "bear", "zeus", "jake", "abby", "sugar", "rusty", "shadow", "gizmo", "bruno", "spike", "scooter", "sandy", "roxy", "peanut", "milo", "socks", "oreo", "peaches", "misty", "princess", "sassy", "simon", "sasha", "sable", "scooby", "scrappy", "shelby", "shiloh", "shiloh", "shiloh" },
            StringComparer.OrdinalIgnoreCase);

        private HashSet<string>? customDictionary = null;

        // Main password generation method
        public string GeneratePassword(bool lowerCase, bool upperCase, bool numbers, bool specials, int length, SpecialCharSetOption specialCharSet, string excludeChars = "", bool excludeDictionaryWords = false, HashSet<string>? customDictionary = null)
        {
            StringBuilder pwBuilder = new StringBuilder();
            List<string> requiredSets = new List<string>();
            if (lowerCase) { pwBuilder.Append(LowerCharacters); requiredSets.Add(new string(LowerCharacters.Except(excludeChars).ToArray())); }
            if (upperCase) { pwBuilder.Append(UpperCharacters); requiredSets.Add(new string(UpperCharacters.Except(excludeChars).ToArray())); }
            if (numbers)   { pwBuilder.Append(DigitsCharacters); requiredSets.Add(new string(DigitsCharacters.Except(excludeChars).ToArray())); }
            if (specials)
            {
                string specialSet = specialCharSet switch
                {
                    SpecialCharSetOption.Minimal => MinimalSpecialCharacters,
                    SpecialCharSetOption.Moderate => ModerateSpecialCharacters,
                    _ => FullSpecialCharacters
                };
                pwBuilder.Append(specialSet);
                requiredSets.Add(new string(specialSet.Except(excludeChars).ToArray()));
            }

            // Remove excluded characters
            string pwChars = string.Join("", pwBuilder.ToString().Except(excludeChars));
            if (string.IsNullOrEmpty(pwChars))
                throw new InvalidOperationException("No characters available for password generation.");

            char[] password = new char[length];
            int maxAttempts = 1000;
            int attempt = 0;
            HashSet<string> dictionary = customDictionary ?? BuiltInDictionary;

            using (var rng = RandomNumberGenerator.Create())
            {
                while (attempt < maxAttempts)
                {
                    // Fill with random chars
                    for (int i = 0; i < length; i++)
                    {
                        int idx = GetRandomInt(rng, pwChars.Length);
                        password[i] = pwChars[idx];
                    }
                    // Ensure at least one from each required set
                    bool allSetsPresent = requiredSets.All(set => set.Length == 0 || password.Any(c => set.Contains(c)));
                    if (!allSetsPresent)
                    {
                        attempt++;
                        continue;
                    }
                    string candidate = new string(password);
                    if (excludeDictionaryWords && ContainsDictionaryWord(candidate, dictionary))
                    {
                        attempt++;
                        continue;
                    }
                    return candidate;
                }
            }
            throw new Exception("Unable to generate password with all required character types after many attempts.");
        }

        private int GetRandomInt(RandomNumberGenerator rng, int maxExclusive)
        {
            // Returns a random integer in [0, maxExclusive)
            byte[] bytes = new byte[4];
            int value;
            do
            {
                rng.GetBytes(bytes);
                value = BitConverter.ToInt32(bytes, 0) & int.MaxValue;
            } while (value >= maxExclusive * (int.MaxValue / maxExclusive));
            return value % maxExclusive;
        }

        private bool ContainsDictionaryWord(string password, HashSet<string> dictionary)
        {
            string lower = password.ToLower();
            foreach (var word in dictionary)
            {
                if (word.Length < 3) continue; // skip very short words
                if (lower.Contains(word))
                    return true;
            }
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblnumlength.Text = trackBarlength.Value.ToString();
        }

        private void Btngen_Click(object sender, EventArgs e)
        {
            if (trackBarlength.Value == trackBarlength.Minimum)
            {
                lblError.Text = "You must select a valid length!";
                return;
            }

            try
            {
                var specialCharSet = (SpecialCharSetOption)comboBoxSpecialChars.SelectedIndex;
                string excludeChars = textBoxExcludeChars.Text ?? string.Empty;
                bool excludeDict = checkBoxExcludeDictionary.Checked;
                var dict = excludeDict ? (customDictionary ?? BuiltInDictionary) : null;
                textBoxpw.Text = GeneratePassword(
                    checkBox1.Checked,
                    checkBox2.Checked,
                    checkBox3.Checked,
                    checkBox4.Checked,
                    trackBarlength.Value,
                    specialCharSet,
                    excludeChars,
                    excludeDict,
                    dict
                );
                lblError.Text = "";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                return;
            }
        }

        private void btnLoadDictionary_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var words = File.ReadAllLines(openFileDialog.FileName)
                            .Select(w => w.Trim().ToLower())
                            .Where(w => w.Length > 2)
                            .ToHashSet();
                        customDictionary = words;
                        lblError.Text = $"Loaded {words.Count} words from dictionary.";
                    }
                    catch (Exception ex)
                    {
                        lblError.Text = $"Failed to load dictionary: {ex.Message}";
                    }
                }
            }
        }

        private void Btncopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxpw.Text);
            }
            catch (Exception)
            {
                lblError.Text = ("You must have a Password!");

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLabel.Text))
            {
                lblError.Text = ("Enter a label before saving!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxpw.Text))
            {
                lblError.Text = "No password to save!";
                return;
            }
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Password Files (*.pwd)|*.pwd|Text Files (*.txt)|*.txt";
                if (!string.IsNullOrWhiteSpace(folderPath))
                {
                    saveFileDialog.InitialDirectory = folderPath;
                }
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string label = textBoxLabel.Text;
                    string password = textBoxpw.Text;
                    folderPath = Path.GetDirectoryName(filePath) ?? "";
                    Properties.Settings.Default.FolderPath = folderPath;
                    Properties.Settings.Default.Save();
                    if (filePath.EndsWith(".pwd"))
                    {
                        // Encrypt password using DPAPI
                        byte[] plainBytes = Encoding.UTF8.GetBytes(password);
                        byte[] encrypted = ProtectedData.Protect(plainBytes, null, DataProtectionScope.CurrentUser);
                        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                        {
                            using (BinaryWriter writer = new BinaryWriter(fs))
                            {
                                writer.Write(label);
                                writer.Write(encrypted.Length);
                                writer.Write(encrypted);
                            }
                        }
                        lblError.Text = "Password and label saved (encrypted)!";
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine("Label: " + label);
                            writer.WriteLine("Password: " + password);
                        }
                        lblError.Text = "Password and label saved! (plaintext)";
                    }
                }
            }
        }

        private void openLastUsedFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(folderPath) && Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("Must save a password first!", "Error");
            }
        }
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FolderPath = folderPath;
            Properties.Settings.Default.Save();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpText =
                "Password Generator Help\n\n" +
                "- Select which character types to include (lower, upper, numbers, special).\n" +
                "- Choose a special character set (minimal, moderate, full) for compatibility.\n" +
                "- Exclude specific characters by entering them in the Exclude Characters box.\n" +
                "- Enable 'Exclude Dictionary Words' to avoid common words. Optionally load your own dictionary.\n" +
                "- Adjust password length with the slider.\n" +
                "- Click 'Generate Password' to create a new password.\n" +
                "- Use 'Copy Password' to copy to clipboard, or 'Save to Notepad' to save.\n\n" +
                "Security Tips:\n" +
                "- Use long, random passwords for best security.\n" +
                "- Avoid reusing passwords across sites.\n" +
                "- Store passwords securely in a password manager.\n" +
                "- Clipboard is not secure: clear it after use.\n" +
                "- Encrypted files (.pwd) can only be opened on this user account. Plaintext files are not secure.\n\n" +
                "App Version: 2.0\n" +
                "Developed for secure, flexible password creation.";
            MessageBox.Show(helpText, "About / Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            textBoxpw.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void LoadVaultToGrid()
        {
            vaultEntries = VaultManager.LoadVault();
            vaultPasswordsRevealed = false;
            vaultGrid.Rows.Clear();
            foreach (var entry in vaultEntries)
            {
                vaultGrid.Rows.Add(entry.Label, entry.Username, MaskPassword(entry.Password));
            }
            vaultDetailsPanel.Visible = false;
        }

        private string MaskPassword(string pw)
        {
            return new string('●', Math.Min(12, pw.Length));
        }

        private int selectedVaultIndex = -1;

        private void VaultGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (vaultGrid.SelectedRows.Count == 1)
            {
                int idx = vaultGrid.SelectedRows[0].Index;
                selectedVaultIndex = idx;
                if (idx >= 0 && idx < vaultEntries.Count)
                {
                    var entry = vaultEntries[idx];
                    txtVaultNotes.Text = entry.Notes;
                    lblVaultDateValue.Text = entry.DateCreated.ToString("g");
                    txtVaultNotes.ReadOnly = true;
                    btnVaultEdit.Visible = true;
                    vaultDetailsPanel.Visible = true;
                }
                else
                {
                    vaultDetailsPanel.Visible = false;
                    btnVaultEdit.Visible = false;
                }
            }
            else
            {
                vaultDetailsPanel.Visible = false;
                btnVaultEdit.Visible = false;
            }
        }

        private void BtnVaultCopy_Click(object sender, EventArgs e)
        {
            if (vaultGrid.SelectedRows.Count == 1)
            {
                int idx = vaultGrid.SelectedRows[0].Index;
                if (idx >= 0 && idx < vaultEntries.Count)
                {
                    Clipboard.SetText(vaultEntries[idx].Password);
                    lblError.Text = "Password copied to clipboard.";
                }
            }
        }

        private void BtnVaultReveal_Click(object sender, EventArgs e)
        {
            if (vaultGrid.Rows.Count == 0) return;
            vaultPasswordsRevealed = !vaultPasswordsRevealed;
            for (int i = 0; i < vaultEntries.Count; i++)
            {
                vaultGrid.Rows[i].Cells[2].Value = vaultPasswordsRevealed ? vaultEntries[i].Password : MaskPassword(vaultEntries[i].Password);
            }
            btnVaultReveal.Text = vaultPasswordsRevealed ? "Hide" : "Reveal";
        }

        private void BtnVaultDelete_Click(object sender, EventArgs e)
        {
            if (vaultGrid.SelectedRows.Count == 1)
            {
                int idx = vaultGrid.SelectedRows[0].Index;
                if (idx >= 0 && idx < vaultEntries.Count)
                {
                    var result = MessageBox.Show($"Delete entry '{vaultEntries[idx].Label}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        vaultEntries.RemoveAt(idx);
                        VaultManager.SaveVault(vaultEntries);
                        LoadVaultToGrid();
                        lblError.Text = "Entry deleted.";
                    }
                }
            }
        }

        private void BtnSaveToVault_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLabel.Text) || string.IsNullOrWhiteSpace(textBoxpw.Text))
            {
                lblError.Text = "Label and password required to save to vault.";
                return;
            }
            txtVaultDialogUsername.Text = "";
            txtVaultDialogNotes.Text = "";
            var result = saveToVaultDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                // Save handled in BtnVaultDialogOK_Click
            }
        }

        private void BtnVaultDialogOK_Click(object? sender, EventArgs e)
        {
            var entry = new VaultEntry
            {
                Label = textBoxLabel.Text,
                Username = txtVaultDialogUsername.Text,
                Password = textBoxpw.Text,
                Notes = txtVaultDialogNotes.Text,
                DateCreated = DateTime.Now
            };
            var entries = VaultManager.LoadVault();
            entries.Add(entry);
            VaultManager.SaveVault(entries);
            LoadVaultToGrid();
            saveToVaultDialog.Hide();
            lblError.Text = "Password saved to vault.";
        }

        private void TxtVaultSearch_TextChanged(object? sender, EventArgs e)
        {
            string query = txtVaultSearch.Text.Trim().ToLower();
            vaultGrid.Rows.Clear();
            foreach (var entry in vaultEntries)
            {
                if (entry.Label.ToLower().Contains(query) || entry.Username.ToLower().Contains(query))
                {
                    vaultGrid.Rows.Add(entry.Label, entry.Username, vaultPasswordsRevealed ? entry.Password : MaskPassword(entry.Password));
                }
            }
            vaultDetailsPanel.Visible = false;
        }

        private void BtnVaultEdit_Click(object? sender, EventArgs e)
        {
            if (selectedVaultIndex >= 0 && selectedVaultIndex < vaultEntries.Count)
            {
                var entry = vaultEntries[selectedVaultIndex];
                if (txtVaultNotes.ReadOnly)
                {
                    // Enable editing
                    txtVaultNotes.ReadOnly = false;
                    btnVaultEdit.Text = "Save";
                }
                else
                {
                    // Save changes
                    entry.Notes = txtVaultNotes.Text;
                    VaultManager.SaveVault(vaultEntries);
                    txtVaultNotes.ReadOnly = true;
                    btnVaultEdit.Text = "Edit";
                    lblError.Text = "Entry updated.";
                }
            }
        }
    }

    // Vault entry model
    [Serializable]
    public class VaultEntry
    {
        public string Label { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }

    // Vault manager for encrypted storage
    public static class VaultManager
    {
        private static readonly string VaultFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vault.json");

        public static List<VaultEntry> LoadVault()
        {
            if (!File.Exists(VaultFilePath)) return new List<VaultEntry>();
            try
            {
                byte[] encrypted = File.ReadAllBytes(VaultFilePath);
                byte[] plain = ProtectedData.Unprotect(encrypted, null, DataProtectionScope.CurrentUser);
                string json = System.Text.Encoding.UTF8.GetString(plain);
                return JsonSerializer.Deserialize<List<VaultEntry>>(json) ?? new List<VaultEntry>();
            }
            catch
            {
                return new List<VaultEntry>();
            }
        }

        public static void SaveVault(List<VaultEntry> entries)
        {
            string json = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
            byte[] plain = System.Text.Encoding.UTF8.GetBytes(json);
            byte[] encrypted = ProtectedData.Protect(plain, null, DataProtectionScope.CurrentUser);
            File.WriteAllBytes(VaultFilePath, encrypted);
        }
    }

    // (Optional, for future) Master password logic
    // public class VaultSecurity
    // {
    //     public static byte[] DeriveKeyFromPassword(string masterPassword, byte[] salt) { /* ... */ }
    //     // Use for AES encryption instead of DPAPI if master password is enabled
    // }
}

