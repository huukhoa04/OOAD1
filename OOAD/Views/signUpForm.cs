using OOAD.Controllers;
using OOAD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD.Views
{
    public partial class signUpForm : Form
    {
        public LogController logController { get; set; }
        public signUpForm()
        {
            InitializeComponent();
            logController = new LogController();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordTxtBox.Text != confirmPasswordTxtBox.Text)
                {
                    passwordLbl.Show();
                }
                else
                {
                    RegisterModel registerModel = new RegisterModel
                    {
                        logUsername = logNameTxtBox.Text,
                        Username = userNameTxtBox.Text,
                        logPassword = passwordTxtBox.Text,
                    };
                    bool check = logController.Register(registerModel);
                    if (check)
                    {
                        MessageBox.Show("Successfully registered!");
                        logInForm logInForm = new logInForm();
                        logInForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username has existed!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void confirmPasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
            passwordLbl.Hide();
        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {
            passwordLbl.Hide();
        }
    }
}
