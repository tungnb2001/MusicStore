using MusicStore.Logics;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStore
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                Users u = AccountManager.LoginUserFromDB(name, password);
                if(u.userName.Equals(name) && u.password.Equals(password))
                {
                    Account.UserName = name;
                    Account.Role = u.role;
                    
                  
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("That member does not exist!");
            }
           
            
        }
    }
}
