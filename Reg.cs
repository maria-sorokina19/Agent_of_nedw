using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agentstvo
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass2.UseSystemPasswordChar = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            FormAuth H = new FormAuth();
            H.Show();
            this.Close();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            if (!((textBoxLogin.Text == "") && (textBoxPass.Text == "")))
            {
                if (new User(textBoxLogin.Text, textBoxPass.Text).IsUserExist() == false)
                {
                    MessageBox.Show("Пользователь уже существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPass.Text != textBoxPass2.Text)
                {
                    MessageBox.Show("Пароли не совпадают!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    new User(textBoxLogin.Text, textBoxPass.Text).SaveToDb();
                    MessageBox.Show("Регистрация прошла успешно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                    FormAuth H = new FormAuth();
                    H.Show();
                }
            }
            else
            {
                MessageBox.Show("Ничего не введено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
