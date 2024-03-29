﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CCS.Forms;

namespace CCS
{
    public partial class auth : Form
    {

        public auth()
        {
            InitializeComponent();
        }

        private void auth_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#0396A6");
            buttonAuth.BackColor = ColorTranslator.FromHtml("#026873");
            wrongLabel.ForeColor = ColorTranslator.FromHtml("#0D0D0D");
            wrongLabel.Visible = false;
        }

        private void forgotLabel_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://t.me/hxnchar"));
        }

        private void forgotLabel_MouseHover(object sender, EventArgs e)
        {
            forgotLabel.Font = new Font(forgotLabel.Font, FontStyle.Underline);
        }

        private void forgotLabel_MouseLeave(object sender, EventArgs e)
        {
            forgotLabel.Font = new Font(forgotLabel.Font, FontStyle.Regular);
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {

            if (CCSMicrocontroller.CheckAutorization(loginTextBox, passwordTextBox, wrongLabel))
            {
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
        }

        private void loginTextBox_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "prettyEmail@gmail.com")
                loginTextBox.Text = "";
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "prettyStrongPassword")
                passwordTextBox.Text = "";
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            loginTextBox.ForeColor = ColorTranslator.FromHtml("#0D0D0D");
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.ForeColor = ColorTranslator.FromHtml("#0D0D0D");
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void CheckTextBox(TextBox textbox)
        {
            if (textbox.Text.Length == 0)
            {
                if (textbox.Name == "loginTextBox")
                    textbox.Text = "prettyEmail@gmail.com";
                if (textbox.Name == "passwordTextBox")
                    textbox.Text = "prettyStrongPassword";
            }
            if (textbox.Text == "prettyEmail@gmail.com")
                textbox.ForeColor = Color.DimGray;
            if (textbox.Text == "prettyStrongPassword")
            {
                textbox.ForeColor = Color.DimGray;
                passwordTextBox.UseSystemPasswordChar = false;
            }
                
        }

        private void loginTextBox_Leave(object sender, EventArgs e)
        {
            CheckTextBox(loginTextBox);
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            CheckTextBox(passwordTextBox);
            
        }
    }
}
