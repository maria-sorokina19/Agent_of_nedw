using Agentstvo.Properties;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanT();
           Application.Exit();
        }
 
        private void InformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, КИБЭВС, Сорокина Мария Сергеевна, группа 717-1, 2020", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UnLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuth n = new FormAuth();
            n.ShowDialog();
        }

        private void клиентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClientBase n = new ClientBase();
            n.Show();
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ServiceBase n = new ServiceBase();
            n.Show();
        }

        private void недвижимостьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Doc n = new Doc();
            n.Show();
        }

        private void NedwBaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NedwBase n = new NedwBase();
            n.Show();
        }

        private void базаНедвижимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseNedw n = new BaseNedw();
            n.Show();
        }

        private void сотрудникиИИхДокументыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeBase n = new EmployeBase();
            n.Show();
        }

        private void настройкаПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceUser n = new ServiceUser();
            n.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            CleanT();
            Application.Exit();
        }
        public void CleanT()
        {
            String ConnStr = @"Data Source=WIN-NI9N3CBIQ6D\SQLEXPRESS;Initial Catalog=Agentstvo_nedwizmost;Integrated Security=True";
            String SqlQuest = "TRUNCATE TABLE [Temp] ";
            SqlConnection cn;
            SqlCommand cmd;
            cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = SqlQuest;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
