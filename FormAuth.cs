using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agentstvo
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
            textBoxPass.UseSystemPasswordChar = true;
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            
            String loginUser = textBoxLogin.Text;
            String passUser = textBoxPass.Text;
            if (!((loginUser == "") && (passUser == "")))
            {
                if (new User(loginUser, passUser).Check(loginUser, passUser) == true)
                {
                    MessageBox.Show("Авторизация прошла успешно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    textBoxLogin.Clear();
                    textBoxPass.Clear();

                    int flag = new User(loginUser, passUser).Role(loginUser, passUser);
                    int ID = new User(loginUser, passUser).ID(loginUser, passUser);
                    new User(loginUser, passUser).Flag(ID, flag);
                    switch (flag)
                    {
                        case 1:
                            FormMain f = new FormMain();
                            f.ShowDialog();
                            break;
                        case 2:
                            FormEmploye r = new FormEmploye();
                            r.ShowDialog();
                            break;
                        case 3:
                            FormClient c = new FormClient();
                            c.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверно введен логин или пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxLogin.Clear();
                    textBoxPass.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ничего не введено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
      
        private void buttonReg_Click(object sender, EventArgs e)
        {
            Reg r = new Reg();
            r.ShowDialog();
            textBoxLogin.Clear();
            textBoxPass.Clear();
            this.Hide();
        }

        private void FormAuth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
