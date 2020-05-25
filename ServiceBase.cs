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
    public partial class ServiceBase : Form
    {
        public ServiceBase()
        {
            InitializeComponent();
        }

        private void вид_услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.вид_услугиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void ServiceBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.dataSet1.Сотрудник);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Вид_услуги". При необходимости она может быть перемещена или удалена.
            this.вид_услугиTableAdapter.Fill(this.dataSet1.Вид_услуги);
        }
    }
}
