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
    public partial class Doc : Form
    {
        public Doc()
        {
            InitializeComponent();
        }

        private void документыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.документыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
           catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        string GetSelectedFieldName()
        {
            return
           документыDataGridView.Columns[документыDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }

        private void Doc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Документы". При необходимости она может быть перемещена или удалена.
            this.документыTableAdapter.Fill(this.dataSet1.Документы);
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               документыBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                документыBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких документов нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                документыBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        документыBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                документыBindingSource.Filter = "";
            if (документыBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                документыBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
    }
}
