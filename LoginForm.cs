using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TheGoodRecipe
{
    public partial class LoginForm : Form
    {
        UserManager um;
        bool clicked = false;
        public LoginForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(clicked)
            {
                um.signUp(username_txt.Text, name_txt.Text, pass_txt.Text);
                MessageBox.Show("Welcome");
                this.Close();
            }
            else
            {
                name_txt.Visible = true;
                name_l.Visible = true;
                Login_btn.Visible = false;
                clicked = true;
            }
            

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            name_txt.Visible = false;
            name_l.Visible = false;
            um = UserManager.getInstance();
            um.readUsers();
            //username_txt.Text = "Enter username";
            //pass_txt.Text = "Enter password";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                um.login(username_txt.Text, pass_txt.Text);
                MessageBox.Show("Welcome");
                this.Close();
            }
            catch(InvalidLoginException d)
            {
                MessageBox.Show("Invalid username or password");

            }
                   
        }

        private void Onclosing(object sender, FormClosingEventArgs e)
        {
            um.saveUsers();
        }
    }
}
