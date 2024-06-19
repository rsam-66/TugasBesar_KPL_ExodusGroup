using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace SeedMe_ReimarkSamuel
{
    public partial class EntryPoint : Form
    {
        // Simulate a user database with a dictionary
        private readonly Dictionary<string, User> _userDatabase = new();

        public EntryPoint()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            signUpBtn.Click += SignUpBtn_Click;
            signInBtn.Click += SignInBtn_Click;
            hideBtn1.Click += HideBtn1_Click;
            hideBtn2.Click += HideBtn2_Click;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string username = userBox.Text.Trim();
            string email = emailBox.Text.Trim();
            string password = passBox.Text.Trim();

            if (ValidateSignUp(username, email, password))
            {
                _userDatabase[username] = new User(email, password);
                ShowMessage("Sign Up successful!");
            }
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string username = userLogBox.Text.Trim();
            string password = passLogBox.Text.Trim();

            if (ValidateSignIn(username, password))
            {
                ShowMessage("Sign In successful!");
            }
        }

        private void HideBtn1_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(passBox, hideBtn1);
        }

        private void HideBtn2_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(passLogBox, hideBtn2);
        }

        private bool ValidateSignUp(string username, string email, string password)
        {
            return ValidateUsername(username) && ValidateEmail(email) && ValidatePassword(password) && CheckUsernameAvailability(username);
        }

        private bool ValidateSignIn(string username, string password)
        {
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && CheckUserCredentials(username, password);
        }

        private bool ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 5 || username.Length > 15 || username.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                ShowMessage("Invalid username. Username must be 5-15 characters long and contain only letters and digits.");
                return false;
            }
            return true;
        }

        private bool ValidateEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                ShowMessage("Invalid email address.");
                return false;
            }
        }

        private bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8 || password.Length > 20)
            {
                ShowMessage("Invalid password. Password must be 8-20 characters long.");
                return false;
            }
            return true;
        }

        private bool CheckUsernameAvailability(string username)
        {
            if (_userDatabase.ContainsKey(username))
            {
                ShowMessage("Username is already taken.");
                return false;
            }
            return true;
        }

        private bool CheckUserCredentials(string username, string password)
        {
            if (!_userDatabase.TryGetValue(username, out var user) || user.Password != password)
            {
                ShowMessage("Invalid username or password.");
                return false;
            }
            return true;
        }

        private void TogglePasswordVisibility(TextBox passwordBox, Button toggleButton)
        {
            passwordBox.UseSystemPasswordChar = !passwordBox.UseSystemPasswordChar;
            toggleButton.Text = passwordBox.UseSystemPasswordChar ? "Hide" : "Show";
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private class User
        {
            public string Email { get; }
            public string Password { get; }

            public User(string email, string password)
            {
                Email = email;
                Password = password;
            }
        }
    }
}
