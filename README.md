# Password Generator

A modern, secure, and feature-rich Windows Forms application for generating and managing strong passwords. Includes a built-in password vault with encrypted storage, customizable password generation, and a user-friendly interface.

## Features

- **Customizable Password Generation**
  - Choose character sets: lower case, upper case, numbers, special characters
  - Select special character set: Minimal (`!@#$%`), Moderate (`!@#$%^&*_-+=`), or Full (all allowed)
  - Exclude specific characters from generated passwords
  - Exclude dictionary words (with built-in and custom dictionary support)
  - Adjustable password length (5–25 characters)
  - One-click password generation and copy to clipboard

- **Password Vault**
  - Securely store generated passwords with labels, usernames, and notes
  - All vault data is encrypted on disk using Windows DPAPI (user-specific)
  - Search, view, edit notes, copy, and delete vault entries
  - Mask/unmask passwords in the vault for privacy

- **Export & Save**
  - Save passwords and labels to encrypted `.pwd` files (only readable on your Windows account)
  - Optionally save as plaintext `.txt` files (not secure)

- **Modern UI**
  - Tabbed interface: Generator, Vault, and Options
  - Responsive layout and modern color scheme
  - Tooltips and error messages for user guidance

- **Security Best Practices**
  - Clipboard warning: passwords copied to clipboard are not secure
  - Encrypted vault and file storage
  - Encourages use of long, random, unique passwords

## Getting Started

### Prerequisites

- Windows 10 or later
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or newer

### Build & Run

1. **Clone the repository:**
   ```sh
   git clone <repo-url>
   cd Password-Generator
   ```

2. **Build the project:**
   ```sh
   dotnet build
   ```

3. **Run the application:**
   ```sh
   dotnet run --project Password.Generator.csproj
   ```

Or open the solution in Visual Studio and press `F5` to run.

## Usage

1. **Generate a Password:**
   - Select desired options (character sets, length, exclusions)
   - Click **Generate Password**
   - Copy or save the password as needed

2. **Save to Vault:**
   - Click **Save to Vault** to store the password securely
   - Add a label, username, and notes as needed

3. **Manage Vault:**
   - Switch to the **Vault** tab to view, search, copy, reveal, edit, or delete entries

4. **Export Passwords:**
   - Use **Save to Notepad** to export to `.pwd` (encrypted) or `.txt` (plaintext) files

## File Formats

- **Vault:** Encrypted JSON (`vault.json`) using Windows DPAPI, only accessible to the current user
- **.pwd:** Encrypted password file (label + password), user-specific
- **.txt:** Plaintext export (label + password), not secure

## Settings

- Remembers last used folder for saving passwords

## Security Notes

- Vault and `.pwd` files are encrypted and can only be opened on the same Windows user account
- Plaintext exports are not secure—use only if necessary
- Clipboard is not secure; clear it after use

---

**Developed for secure, flexible password creation and management.** 
