using OOAD.Controllers;
using OOAD.Data;
using OOAD.Models;
using OOAD.Views;

namespace OOAD
{
    public partial class logInForm : Form
    {
        public LogController logController { get; set; }
        public logInForm()
        {
            InitializeComponent();
            logController = new LogController();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            try
            {

            LoginModel loginModel = new LoginModel
            {
                password = passwordTxtBox.Text,
                username = nameTxtBox.Text,
            };
            User a = logController.LoginCheck(loginModel);
            if (a != null)
            {
                this.Hide();
                MainUI mainUI = new MainUI(a);
                mainUI.ShowDialog();
            }
            else
            {
                MessageBox.Show("INVALID INFO GIVEN, RE-ENTER PLS!!!");
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpForm signUp = new signUpForm();
            signUp.ShowDialog();
        }
    }
}
