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
    public partial class NedClient : Form
    {
        public NedClient()
        {
            InitializeComponent();
        }
       
        private void NedClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.Вид_услуги". При необходимости она может быть перемещена или удалена.
            this.вид_услугиTableAdapter.Fill(this.dataSet11.Вид_услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Систематизированная_база_агентства". При необходимости она может быть перемещена или удалена.
            this.систематизированная_база_агентстваTableAdapter.Fill(this.dataSet1.Систематизированная_база_агентства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Систематизированная_база_агентства". При необходимости она может быть перемещена или удалена.
            this.систематизированная_база_агентстваTableAdapter.Fill(this.dataSet1.Систематизированная_база_агентства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Систематизированная_база_агентства". При необходимости она может быть перемещена или удалена.
            this.систематизированная_база_агентстваTableAdapter.Fill(this.dataSet1.Систематизированная_база_агентства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Вид_услуги". При необходимости она может быть перемещена или удалена.
            this.вид_услугиTableAdapter.Fill(this.dataSet1.Вид_услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Систематизированная_база_агентства". При необходимости она может быть перемещена или удалена.
            this.систематизированная_база_агентстваTableAdapter.Fill(this.dataSet1.Систематизированная_база_агентства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Недвижимость". При необходимости она может быть перемещена или удалена.
            this.недвижимостьTableAdapter.Fill(this.dataSet1.Недвижимость);
            try
            {
                this.вид_услугиTableAdapter.NedwYsl(this.dataSet1.Вид_услуги);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }   
    }
}
