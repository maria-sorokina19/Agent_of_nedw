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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, КИБЭВС, Сорокина Мария Сергеевна, группа 717-1, 2020", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходИзПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanT();
            Application.Exit();
        }

        private void выходИзУчетнойЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuth n = new FormAuth();
            n.ShowDialog();
        }

        private void недвижимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NedClient n = new NedClient();
            n.Show();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            { 
                this.Validate();
                this.клиентBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            try
            {
                this.клиентTableAdapter.FillBy(this.dataSet1.Клиент);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Вид_услуги". При необходимости она может быть перемещена или удалена.
            this.вид_услугиTableAdapter.Fill(this.dataSet1.Вид_услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Документы". При необходимости она может быть перемещена или удалена.
            this.документыTableAdapter.Fill(this.dataSet1.Документы);
        }

        private void FormClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            CleanT();
            Application.Exit();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.клиентTableAdapter.FillBy(this.dataSet1.Клиент);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
