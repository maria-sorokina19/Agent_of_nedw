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
    public partial class BaseNedw : Form
    {
        public BaseNedw()
        {
            InitializeComponent();
        }

        private void систематизированная_база_агентстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try 
            { 
                this.Validate();
                this.систематизированная_база_агентстваBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void BaseNedw_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Систематизированная_база_агентства". При необходимости она может быть перемещена или удалена.
            this.систематизированная_база_агентстваTableAdapter.Fill(this.dataSet1.Систематизированная_база_агентства);
        }
        string GetSelectedFieldName()
        {
            return
           систематизированная_база_агентстваDataGridView.Columns[систематизированная_база_агентстваDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
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
               систематизированная_база_агентстваBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                систематизированная_база_агентстваBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Такой недвижимости нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                систематизированная_база_агентстваBindingSource.Position = 0;
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
                        систематизированная_база_агентстваBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                систематизированная_база_агентстваBindingSource.Filter = "";
            if (систематизированная_база_агентстваBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                систематизированная_база_агентстваBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
    }
}
