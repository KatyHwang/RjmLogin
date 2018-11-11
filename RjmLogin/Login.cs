using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RjmLogin
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void loginIn_Click(object sender, EventArgs e)
        {
            CheckUser();
        }

        public void CheckUser()
        {
            User u = new User();
            if (u.UserName != txt_user.Text || u.PassWrod != txt_password.Text)
            {
                lbl_rro.Text = "使用者/密碼 輸入錯誤";
            }
            else
            {
                Form1 f = new Form1();

                this.Visible = false;
                f.Visible = true;
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
