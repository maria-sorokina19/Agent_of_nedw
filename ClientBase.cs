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
    public partial class ClientBase : Form
    {
        public ClientBase()
        {
            InitializeComponent();
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

        private void ClientBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Систематизированная_база_агентства". При необходимости она может быть перемещена или удалена.
            this.систематизированная_база_агентстваTableAdapter.Fill(this.dataSet1.Систематизированная_база_агентства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Документы". При необходимости она может быть перемещена или удалена.
            this.документыTableAdapter.Fill(this.dataSet1.Документы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Документы". При необходимости она может быть перемещена или удалена.
            this.документыTableAdapter.Fill(this.dataSet1.Документы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.dataSet1.Клиент);
        }
    }
}
