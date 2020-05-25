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
    public partial class FormEmploye : Form
    {
        public FormEmploye()
        {
            InitializeComponent();
        }

        private void UnloginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuth n = new FormAuth();
            n.ShowDialog();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanT();
            Application.Exit();
        }

        private void InfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, КИБЭВС, Сорокина Мария Сергеевна, группа 717-1, 2020", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void базаАгентстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseNedw n = new BaseNedw();
            n.Show();
        }

        private void недвижимостьИДокументыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NedwBase n = new NedwBase();
            n.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmploeyClient n = new EmploeyClient();
            n.Show();
        }

        private void FormEmploye_Load(object sender, EventArgs e)
        {
            try
            {
                this.сотрудникTableAdapter.EmployeForm(this.dataSet1.Сотрудник);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void документыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocEmp n = new DocEmp();
            n.Show();
        }

        private void FormEmploye_FormClosed(object sender, FormClosedEventArgs e)
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
