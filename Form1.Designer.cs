namespace Password.Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxpw = new TextBox();
            lbltitle = new Label();
            Btngen = new Button();
            Btncopy = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            trackBarlength = new TrackBar();
            lbllength = new Label();
            label1 = new Label();
            lblnumlength = new Label();
            lbloptions = new Label();
            lblError = new Label();
            BtnSave = new Button();
            textBoxLabel = new TextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openLastUsedFolderToolStripMenuItem = new ToolStripMenuItem();
            comboBoxSpecialChars = new ComboBox();
            lblSpecialChars = new Label();
            textBoxExcludeChars = new TextBox();
            lblExcludeChars = new Label();
            checkBoxExcludeDictionary = new CheckBox();
            btnLoadDictionary = new Button();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            checkBoxShowPassword = new CheckBox();
            mainTabControl = new TabControl();
            tabGenerator = new TabPage("Generator");
            tabVault = new TabPage("Vault");
            ((System.ComponentModel.ISupportInitialize)trackBarlength).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxpw
            // 
            textBoxpw.Location = new Point(265, 201);
            textBoxpw.Margin = new Padding(4, 5, 4, 5);
            textBoxpw.Name = "textBoxpw";
            textBoxpw.Size = new Size(644, 31);
            textBoxpw.TabIndex = 0;
            textBoxpw.TextChanged += textBox1_TextChanged;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.White;
            lbltitle.Location = new Point(237, 15);
            lbltitle.Margin = new Padding(4, 0, 4, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(722, 96);
            lbltitle.TabIndex = 1;
            lbltitle.Text = "Password Generator";
            // 
            // Btngen
            // 
            Btngen.BackColor = Color.DarkKhaki;
            Btngen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btngen.ForeColor = Color.Black;
            Btngen.Location = new Point(95, 613);
            Btngen.Margin = new Padding(4, 5, 4, 5);
            Btngen.Name = "Btngen";
            Btngen.Size = new Size(234, 95);
            Btngen.TabIndex = 2;
            Btngen.Text = "Generate Password";
            Btngen.UseVisualStyleBackColor = false;
            Btngen.Click += Btngen_Click;
            // 
            // Btncopy
            // 
            Btncopy.BackColor = Color.DarkKhaki;
            Btncopy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btncopy.Location = new Point(431, 613);
            Btncopy.Margin = new Padding(4, 5, 4, 5);
            Btncopy.Name = "Btncopy";
            Btncopy.Size = new Size(234, 95);
            Btncopy.TabIndex = 3;
            Btncopy.Text = "Copy Password";
            Btncopy.UseVisualStyleBackColor = false;
            Btncopy.Click += Btncopy_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(220, 385);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Lower Case";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(431, 385);
            checkBox2.Margin = new Padding(4, 5, 4, 5);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(134, 29);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Upper Case";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(656, 385);
            checkBox3.Margin = new Padding(4, 5, 4, 5);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(115, 29);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Numbers";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.ForeColor = Color.White;
            checkBox4.Location = new Point(851, 385);
            checkBox4.Margin = new Padding(4, 5, 4, 5);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(193, 29);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Special Characters";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // trackBarlength
            // 
            trackBarlength.BackColor = Color.Gray;
            trackBarlength.Location = new Point(237, 513);
            trackBarlength.Margin = new Padding(4, 5, 4, 5);
            trackBarlength.Name = "trackBarlength";
            trackBarlength.Size = new Size(659, 69);
            trackBarlength.TabIndex = 8;
            trackBarlength.Scroll += trackBar1_Scroll;
            // 
            // lbllength
            // 
            lbllength.AutoSize = true;
            lbllength.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbllength.ForeColor = Color.White;
            lbllength.Location = new Point(343, 443);
            lbllength.Margin = new Padding(4, 0, 4, 0);
            lbllength.Name = "lbllength";
            lbllength.Size = new Size(361, 55);
            lbllength.TabIndex = 9;
            lbllength.Text = "Password Length:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Khaki;
            label1.Location = new Point(141, 201);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 10;
            label1.Text = "Password:";
            // 
            // lblnumlength
            // 
            lblnumlength.AutoSize = true;
            lblnumlength.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblnumlength.ForeColor = Color.White;
            lblnumlength.Location = new Point(694, 443);
            lblnumlength.Margin = new Padding(4, 0, 4, 0);
            lblnumlength.Name = "lblnumlength";
            lblnumlength.Size = new Size(48, 55);
            lblnumlength.TabIndex = 11;
            lblnumlength.Text = "1";
            // 
            // lbloptions
            // 
            lbloptions.AutoSize = true;
            lbloptions.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbloptions.ForeColor = Color.White;
            lbloptions.Location = new Point(68, 374);
            lbloptions.Margin = new Padding(4, 0, 4, 0);
            lbloptions.Name = "lbloptions";
            lbloptions.Size = new Size(118, 40);
            lbloptions.TabIndex = 12;
            lbloptions.Text = "Options";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(288, 298);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 54);
            lblError.TabIndex = 13;
            lblError.Click += lblError_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.DarkKhaki;
            BtnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSave.Location = new Point(767, 613);
            BtnSave.Margin = new Padding(4, 5, 4, 5);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(234, 95);
            BtnSave.TabIndex = 14;
            BtnSave.Text = "Save to Notepad";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click_1;
            // 
            // textBoxLabel
            // 
            textBoxLabel.Location = new Point(400, 243);
            textBoxLabel.Name = "textBoxLabel";
            textBoxLabel.Size = new Size(357, 31);
            textBoxLabel.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(170, 246);
            label2.Name = "label2";
            label2.Size = new Size(190, 25);
            label2.TabIndex = 16;
            label2.Text = "Label Your Password:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1143, 33);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openLastUsedFolderToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openLastUsedFolderToolStripMenuItem
            // 
            openLastUsedFolderToolStripMenuItem.Name = "openLastUsedFolderToolStripMenuItem";
            openLastUsedFolderToolStripMenuItem.Size = new Size(294, 34);
            openLastUsedFolderToolStripMenuItem.Text = "Open Last Used Folder";
            openLastUsedFolderToolStripMenuItem.Click += openLastUsedFolderToolStripMenuItem_Click;
            // 
            // comboBoxSpecialChars
            // 
            comboBoxSpecialChars.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecialChars.Items.AddRange(new object[] { "Minimal (!@#$%)", "Moderate (!@#$%^&*_-+=)", "Full (All Allowed)" });
            comboBoxSpecialChars.SelectedIndex = 2;
            comboBoxSpecialChars.Location = new Point(480, 430);
            comboBoxSpecialChars.Name = "comboBoxSpecialChars";
            comboBoxSpecialChars.Size = new Size(250, 33);
            comboBoxSpecialChars.TabIndex = 19;
            // 
            // lblSpecialChars
            // 
            lblSpecialChars.AutoSize = true;
            lblSpecialChars.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpecialChars.ForeColor = Color.Khaki;
            lblSpecialChars.Location = new Point(220, 430);
            lblSpecialChars.Name = "lblSpecialChars";
            lblSpecialChars.Size = new Size(250, 25);
            lblSpecialChars.TabIndex = 18;
            lblSpecialChars.Text = "Special Characters Set:";
            // 
            // textBoxExcludeChars
            // 
            textBoxExcludeChars.Location = new Point(480, 470);
            textBoxExcludeChars.Name = "textBoxExcludeChars";
            textBoxExcludeChars.Size = new Size(250, 31);
            textBoxExcludeChars.TabIndex = 21;
            // 
            // lblExcludeChars
            // 
            lblExcludeChars.AutoSize = true;
            lblExcludeChars.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblExcludeChars.ForeColor = Color.Khaki;
            lblExcludeChars.Location = new Point(220, 470);
            lblExcludeChars.Name = "lblExcludeChars";
            lblExcludeChars.Size = new Size(250, 25);
            lblExcludeChars.TabIndex = 20;
            lblExcludeChars.Text = "Exclude Characters:";
            // 
            // checkBoxExcludeDictionary
            // 
            checkBoxExcludeDictionary.AutoSize = true;
            checkBoxExcludeDictionary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxExcludeDictionary.ForeColor = Color.White;
            checkBoxExcludeDictionary.Location = new Point(220, 510);
            checkBoxExcludeDictionary.Name = "checkBoxExcludeDictionary";
            checkBoxExcludeDictionary.Size = new Size(350, 29);
            checkBoxExcludeDictionary.TabIndex = 22;
            checkBoxExcludeDictionary.Text = "Exclude Dictionary Words";
            // 
            // btnLoadDictionary
            // 
            btnLoadDictionary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadDictionary.Location = new Point(580, 510);
            btnLoadDictionary.Name = "btnLoadDictionary";
            btnLoadDictionary.Size = new Size(150, 29);
            btnLoadDictionary.TabIndex = 23;
            btnLoadDictionary.Text = "Load Dictionary";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(150, 34);
            aboutToolStripMenuItem.Text = "About / Help";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxShowPassword.ForeColor = Color.Khaki;
            checkBoxShowPassword.Location = new Point(920, 201);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(180, 29);
            checkBoxShowPassword.TabIndex = 24;
            checkBoxShowPassword.Text = "Show Password";
            // 
            // mainTabControl
            // 
            mainTabControl.Location = new Point(0, 33);
            mainTabControl.Size = new Size(1143, 717);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.TabIndex = 100;

            tabGenerator = new TabPage("Generator");
            tabGenerator.Name = "tabGenerator";
            tabGenerator.Size = new Size(1135, 680);
            tabGenerator.BackColor = this.BackColor;

            tabVault = new TabPage("Vault");
            tabVault.Name = "tabVault";
            tabVault.Size = new Size(1135, 680);
            tabVault.BackColor = this.BackColor;

            // Move all existing controls (except menuStrip1 and mainTabControl) to tabGenerator
            var controlsToMove = new Control[] {
                label2, textBoxLabel, BtnSave, lblError, lbloptions, lblnumlength, label1, lbllength, trackBarlength,
                checkBox4, checkBox3, checkBox2, checkBox1, Btncopy, Btngen, lbltitle, textBoxpw, btnLoadDictionary,
                checkBoxExcludeDictionary, textBoxExcludeChars, lblExcludeChars, comboBoxSpecialChars, lblSpecialChars,
                checkBoxShowPassword, lblSecurityWarning
            };
            foreach (var ctrl in controlsToMove) tabGenerator.Controls.Add(ctrl);

            mainTabControl.Controls.Add(tabGenerator);
            mainTabControl.Controls.Add(tabVault);
            Controls.Add(mainTabControl);
            // Controls.SetChildIndex(menuStrip1, 0); // Removed to fix exception
            // Grouping and spacing improvements
            // Move special char controls below checkboxes, then exclude chars, then dictionary options
            lblSpecialChars.Location = new Point(220, 420);
            comboBoxSpecialChars.Location = new Point(480, 420);
            lblExcludeChars.Location = new Point(220, 460);
            textBoxExcludeChars.Location = new Point(480, 460);
            checkBoxExcludeDictionary.Location = new Point(220, 500);
            btnLoadDictionary.Location = new Point(480, 500);
            checkBoxShowPassword.Location = new Point(920, 201);

            // Tooltips
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(comboBoxSpecialChars, "Choose the set of special characters allowed in your password.");
            toolTip.SetToolTip(textBoxExcludeChars, "Enter any characters you want to exclude from the password.");
            toolTip.SetToolTip(checkBoxExcludeDictionary, "Avoid passwords containing common dictionary words.");
            toolTip.SetToolTip(btnLoadDictionary, "Load a custom dictionary file (one word per line).");
            toolTip.SetToolTip(checkBoxShowPassword, "Toggle to show or hide the generated password.");

            // Modern security color scheme
            this.BackColor = Color.FromArgb(20, 22, 30); // darker blue-gray
            lbltitle.ForeColor = Color.FromArgb(0, 120, 215); // security blue
            Btngen.BackColor = Color.FromArgb(0, 120, 215);
            Btngen.ForeColor = Color.White;
            Btncopy.BackColor = Color.FromArgb(0, 120, 215);
            Btncopy.ForeColor = Color.White;
            BtnSave.BackColor = Color.FromArgb(0, 120, 215);
            BtnSave.ForeColor = Color.White;
            menuStrip1.BackColor = Color.FromArgb(24, 28, 38);
            menuStrip1.ForeColor = Color.White;
            // Option labels
            lbloptions.ForeColor = Color.FromArgb(0, 120, 215);
            lbllength.ForeColor = Color.FromArgb(0, 120, 215);
            lblnumlength.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            checkBoxShowPassword.ForeColor = Color.FromArgb(0, 120, 215);
            // Set all checkboxes to the same blue as the labels
            checkBox1.ForeColor = Color.FromArgb(0, 120, 215);
            checkBox2.ForeColor = Color.FromArgb(0, 120, 215);
            checkBox3.ForeColor = Color.FromArgb(0, 120, 215);
            checkBox4.ForeColor = Color.FromArgb(0, 120, 215);
            checkBoxExcludeDictionary.ForeColor = Color.FromArgb(0, 120, 215);
            // Vault DataGridView
            vaultGrid = new DataGridView();
            vaultGrid.Location = new Point(30, 30);
            vaultGrid.Size = new Size(900, 500);
            vaultGrid.Name = "vaultGrid";
            vaultGrid.ReadOnly = true;
            vaultGrid.AllowUserToAddRows = false;
            vaultGrid.AllowUserToDeleteRows = false;
            vaultGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vaultGrid.MultiSelect = false;
            vaultGrid.AutoGenerateColumns = false;
            vaultGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Label", DataPropertyName = "Label", Width = 200 });
            vaultGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Username", DataPropertyName = "Username", Width = 200 });
            vaultGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Password", DataPropertyName = "Password", Width = 200 });
            tabVault.Controls.Add(vaultGrid);

            // Vault Search Box
            lblVaultSearch = new Label();
            lblVaultSearch.Text = "Search:";
            lblVaultSearch.Location = new Point(30, 5);
            lblVaultSearch.Size = new Size(60, 25);
            lblVaultSearch.ForeColor = Color.White;
            tabVault.Controls.Add(lblVaultSearch);

            txtVaultSearch = new TextBox();
            txtVaultSearch.Location = new Point(90, 5);
            txtVaultSearch.Size = new Size(300, 30);
            txtVaultSearch.Name = "txtVaultSearch";
            tabVault.Controls.Add(txtVaultSearch);

            // Vault action buttons
            btnVaultCopy = new Button();
            btnVaultCopy.Text = "Copy";
            btnVaultCopy.Location = new Point(950, 30);
            btnVaultCopy.Size = new Size(120, 40);
            tabVault.Controls.Add(btnVaultCopy);

            btnVaultReveal = new Button();
            btnVaultReveal.Text = "Reveal";
            btnVaultReveal.Location = new Point(950, 80);
            btnVaultReveal.Size = new Size(120, 40);
            tabVault.Controls.Add(btnVaultReveal);

            btnVaultDelete = new Button();
            btnVaultDelete.Text = "Delete";
            btnVaultDelete.Location = new Point(950, 130);
            btnVaultDelete.Size = new Size(120, 40);
            tabVault.Controls.Add(btnVaultDelete);

            btnVaultDetails = new Button();
            btnVaultDetails.Text = "Details";
            btnVaultDetails.Location = new Point(950, 180);
            btnVaultDetails.Size = new Size(120, 40);
            tabVault.Controls.Add(btnVaultDetails);
            // Vault Details Panel
            vaultDetailsPanel = new Panel();
            vaultDetailsPanel.Location = new Point(30, 540);
            vaultDetailsPanel.Size = new Size(900, 120);
            vaultDetailsPanel.BackColor = Color.FromArgb(40, 44, 55);
            vaultDetailsPanel.Visible = false;
            tabVault.Controls.Add(vaultDetailsPanel);

            lblVaultNotes = new Label();
            lblVaultNotes.Text = "Notes:";
            lblVaultNotes.Location = new Point(10, 10);
            lblVaultNotes.Size = new Size(60, 25);
            lblVaultNotes.ForeColor = Color.White;
            vaultDetailsPanel.Controls.Add(lblVaultNotes);

            txtVaultNotes = new TextBox();
            txtVaultNotes.Location = new Point(80, 10);
            txtVaultNotes.Size = new Size(700, 80);
            txtVaultNotes.Multiline = true;
            txtVaultNotes.ReadOnly = true;
            txtVaultNotes.BackColor = Color.FromArgb(60, 64, 75);
            txtVaultNotes.ForeColor = Color.White;
            vaultDetailsPanel.Controls.Add(txtVaultNotes);

            lblVaultDate = new Label();
            lblVaultDate.Text = "Created:";
            lblVaultDate.Location = new Point(10, 100);
            lblVaultDate.Size = new Size(70, 20);
            lblVaultDate.ForeColor = Color.White;
            vaultDetailsPanel.Controls.Add(lblVaultDate);

            lblVaultDateValue = new Label();
            lblVaultDateValue.Location = new Point(80, 100);
            lblVaultDateValue.Size = new Size(300, 20);
            lblVaultDateValue.ForeColor = Color.White;
            vaultDetailsPanel.Controls.Add(lblVaultDateValue);

            // Save to Vault Button
            btnSaveToVault = new Button();
            btnSaveToVault.Text = "Save to Vault";
            btnSaveToVault.Location = new Point(95, 670);
            btnSaveToVault.Size = new Size(234, 40);
            tabGenerator.Controls.Add(btnSaveToVault);

            // Save to Vault Dialog
            saveToVaultDialog = new Form();
            saveToVaultDialog.Text = "Save Password to Vault";
            saveToVaultDialog.Size = new Size(400, 250);
            saveToVaultDialog.StartPosition = FormStartPosition.CenterParent;
            saveToVaultDialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            saveToVaultDialog.ControlBox = false;
            saveToVaultDialog.MaximizeBox = false;
            saveToVaultDialog.MinimizeBox = false;

            txtVaultDialogUsername = new TextBox();
            txtVaultDialogUsername.Location = new Point(10, 10);
            txtVaultDialogUsername.Size = new Size(380, 30);
            txtVaultDialogUsername.Name = "txtVaultDialogUsername";
            saveToVaultDialog.Controls.Add(txtVaultDialogUsername);

            txtVaultDialogNotes = new TextBox();
            txtVaultDialogNotes.Location = new Point(10, 50);
            txtVaultDialogNotes.Size = new Size(380, 100);
            txtVaultDialogNotes.Name = "txtVaultDialogNotes";
            txtVaultDialogNotes.Multiline = true;
            txtVaultDialogNotes.ScrollBars = ScrollBars.Vertical;
            saveToVaultDialog.Controls.Add(txtVaultDialogNotes);

            btnVaultDialogOK = new Button();
            btnVaultDialogOK.Text = "OK";
            btnVaultDialogOK.DialogResult = DialogResult.OK;
            btnVaultDialogOK.Location = new Point(200, 160);
            saveToVaultDialog.Controls.Add(btnVaultDialogOK);

            btnVaultDialogCancel = new Button();
            btnVaultDialogCancel.Text = "Cancel";
            btnVaultDialogCancel.DialogResult = DialogResult.Cancel;
            btnVaultDialogCancel.Location = new Point(300, 160);
            saveToVaultDialog.Controls.Add(btnVaultDialogCancel);

            // Tooltips
            toolTip.SetToolTip(btnSaveToVault, "Save the generated password to the vault.");
            toolTip.SetToolTip(saveToVaultDialog, "Enter a label and optional notes for the password.");
            toolTip.SetToolTip(txtVaultDialogUsername, "Enter the username for this password.");
            toolTip.SetToolTip(txtVaultDialogNotes, "Enter any notes or comments for this password.");

            // Set all labels and checkboxes to the same blue as the title
            Color labelBlue = Color.FromArgb(0, 120, 215);
            lbltitle.ForeColor = labelBlue;
            label1.ForeColor = labelBlue;
            label2.ForeColor = labelBlue;
            lbllength.ForeColor = labelBlue;
            lblnumlength.ForeColor = labelBlue;
            lblSpecialChars.ForeColor = labelBlue;
            lblExcludeChars.ForeColor = labelBlue;
            lblVaultSearch.ForeColor = labelBlue;
            lblVaultNotes.ForeColor = labelBlue;
            lblVaultDate.ForeColor = labelBlue;
            checkBox1.ForeColor = labelBlue;
            checkBox2.ForeColor = labelBlue;
            checkBox3.ForeColor = labelBlue;
            checkBox4.ForeColor = labelBlue;
            checkBoxExcludeDictionary.ForeColor = labelBlue;
            // Remove lbloptions from Generator tab and Controls
            if (tabGenerator.Controls.Contains(lbloptions)) tabGenerator.Controls.Remove(lbloptions);
            if (this.Controls.Contains(lbloptions)) this.Controls.Remove(lbloptions);
            // Add Options tab
            if (tabOptions == null) {
                tabOptions = new TabPage("Options");
                tabOptions.Name = "tabOptions";
                tabOptions.Size = new Size(1135, 680);
                tabOptions.BackColor = this.BackColor;
                mainTabControl.Controls.Add(tabOptions);
            }
            // Larger window and more spread out layout
            this.ClientSize = new Size(1600, 1100);
            this.MinimumSize = new Size(1200, 900);
            // Improved layout for Generator tab (spread out vertically and horizontally)
            int y = 80;
            int xLabel = 120;
            int xInput = 600;
            int spacingY = 80;
            int groupSpacingY = 60;
            int buttonSpacingX = 320;
            int buttonY = 0;

            lbltitle.Location = new Point(400, y);
            lbltitle.Font = new Font("Segoe UI", 38F, FontStyle.Bold);
            y += 120 + groupSpacingY;

            label2.Location = new Point(xLabel, y);
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxLabel.Location = new Point(xInput, y);
            textBoxLabel.Size = new Size(500, 35);
            y += spacingY;

            label1.Location = new Point(xLabel, y);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBoxpw.Location = new Point(xInput, y);
            textBoxpw.Size = new Size(500, 35);
            checkBoxShowPassword.Location = new Point(xInput + 520, y);
            checkBoxShowPassword.Size = new Size(200, 35);
            y += spacingY;

            checkBox1.Location = new Point(xLabel, y);
            checkBox2.Location = new Point(xLabel + 220, y);
            checkBox3.Location = new Point(xLabel + 440, y);
            checkBox4.Location = new Point(xLabel + 660, y);
            y += spacingY;

            lblSpecialChars.Location = new Point(xLabel, y);
            comboBoxSpecialChars.Location = new Point(xInput, y);
            comboBoxSpecialChars.Size = new Size(350, 35);
            y += spacingY;

            lblExcludeChars.Location = new Point(xLabel, y);
            textBoxExcludeChars.Location = new Point(xInput, y);
            textBoxExcludeChars.Size = new Size(350, 35);
            y += spacingY;

            checkBoxExcludeDictionary.Location = new Point(xLabel, y);
            btnLoadDictionary.Location = new Point(xInput, y);
            y += spacingY + groupSpacingY;

            // Password Length label and value together, then slider
            lbllength.Location = new Point(xLabel, y + 10);
            lbllength.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblnumlength.Location = new Point(lbllength.Location.X + lbllength.Width + 20, lbllength.Location.Y);
            trackBarlength.Location = new Point(xInput, y);
            trackBarlength.Size = new Size(500, 50);
            y += spacingY + 30;

            // Spread out buttons horizontally
            buttonY = y;
            Btngen.Location = new Point(xLabel, buttonY);
            Btngen.Size = new Size(250, 70);
            Btncopy.Location = new Point(xLabel + buttonSpacingX, buttonY);
            Btncopy.Size = new Size(250, 70);
            BtnSave.Location = new Point(xLabel + 2 * buttonSpacingX, buttonY);
            BtnSave.Size = new Size(250, 70);
            btnSaveToVault.Location = new Point(xLabel + 3 * buttonSpacingX, buttonY);
            btnSaveToVault.Size = new Size(250, 70);
            y += 120;

            lblError.Location = new Point(xLabel, y);
            lblError.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblError.ForeColor = Color.OrangeRed;
            y += spacingY;
            lbloptions.Location = new Point(xLabel, y);
            lbloptions.Font = new Font("Segoe UI", 14F, FontStyle.Bold);

            // Make mainTabControl fill the form
            mainTabControl.Dock = DockStyle.Fill;

            // Generator tab: make main controls responsive
            lbltitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            textBoxLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxpw.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxShowPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            checkBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            checkBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            checkBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblSpecialChars.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            comboBoxSpecialChars.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblExcludeChars.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            textBoxExcludeChars.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxExcludeDictionary.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnLoadDictionary.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lbllength.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            trackBarlength.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblnumlength.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Btngen.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Btncopy.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnSaveToVault.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Vault tab: make grid and details panel responsive
            vaultGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            vaultGrid.Width = tabVault.ClientSize.Width - 60;
            vaultGrid.Height = tabVault.ClientSize.Height - 300;
            vaultDetailsPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            vaultDetailsPanel.Width = tabVault.ClientSize.Width - 60;
            vaultDetailsPanel.Location = new Point(30, tabVault.ClientSize.Height - 160);
            txtVaultSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnVaultCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVaultReveal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVaultDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVaultDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Set minimum and default size
            this.MinimumSize = new Size(1400, 900);
            this.ClientSize = new Size(1800, 1100);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxpw;
        private Label lbltitle;
        private Button Btngen;
        private Button Btncopy;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private TrackBar trackBarlength;
        private Label lbllength;
        private Label label1;
        private Label lblnumlength;
        private Label lbloptions;
        private Label lblError;
        private Button BtnSave;
        private TextBox textBoxLabel;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openLastUsedFolderToolStripMenuItem;
        private ComboBox comboBoxSpecialChars;
        private Label lblSpecialChars;
        private TextBox textBoxExcludeChars;
        private Label lblExcludeChars;
        private CheckBox checkBoxExcludeDictionary;
        private Button btnLoadDictionary;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private CheckBox checkBoxShowPassword;
        private TabControl mainTabControl;
        private TabPage tabGenerator;
        private TabPage tabVault;
        private DataGridView vaultGrid;
        private Button btnVaultCopy;
        private Button btnVaultReveal;
        private Button btnVaultDelete;
        private Button btnVaultDetails;
        private Panel vaultDetailsPanel;
        private Label lblVaultNotes;
        private TextBox txtVaultNotes;
        private Label lblVaultDate;
        private Label lblVaultDateValue;
        private Button btnSaveToVault;
        private Form saveToVaultDialog;
        private TextBox txtVaultDialogUsername;
        private TextBox txtVaultDialogNotes;
        private Button btnVaultDialogOK;
        private Button btnVaultDialogCancel;
        private TextBox txtVaultSearch;
        private Label lblVaultSearch;
        private TabPage tabOptions;
    }
}