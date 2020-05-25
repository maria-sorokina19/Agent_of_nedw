namespace Agentstvo
{
    partial class NedClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label код_недвижимостиLabel;
            System.Windows.Forms.Label тип_недвижимостиLabel;
            System.Windows.Forms.Label районLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NedClient));
            this.dataSet1 = new Agentstvo.DataSet1();
            this.недвижимостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.недвижимостьTableAdapter = new Agentstvo.DataSet1TableAdapters.НедвижимостьTableAdapter();
            this.tableAdapterManager = new Agentstvo.DataSet1TableAdapters.TableAdapterManager();
            this.вид_услугиTableAdapter = new Agentstvo.DataSet1TableAdapters.Вид_услугиTableAdapter();
            this.систематизированная_база_агентстваTableAdapter = new Agentstvo.DataSet1TableAdapters.Систематизированная_база_агентстваTableAdapter();
            this.недвижимостьBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.систематизированная_база_агентстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вид_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKСистематизированнаябазаагентстваВидуслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKСистематизированнаябазаагентстваВидуслугиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.видуслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new Agentstvo.DataSet1();
            this.fKСистематизированнаябазаагентстваНедвижимостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKСистематизированнаябазаагентстваВидуслугиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.код_недвижимостиTextBox = new System.Windows.Forms.TextBox();
            this.тип_недвижимостиTextBox = new System.Windows.Forms.TextBox();
            this.районTextBox = new System.Windows.Forms.TextBox();
            this.систематизированная_база_агентстваDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            код_недвижимостиLabel = new System.Windows.Forms.Label();
            тип_недвижимостиLabel = new System.Windows.Forms.Label();
            районLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingNavigator)).BeginInit();
            this.недвижимостьBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.систематизированная_база_агентстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вид_услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСистематизированнаябазаагентстваВидуслугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСистематизированнаябазаагентстваВидуслугиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видуслугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСистематизированнаябазаагентстваНедвижимостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСистематизированнаябазаагентстваВидуслугиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.систематизированная_база_агентстваDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(12, 118);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(96, 13);
            названиеLabel.TabIndex = 12;
            названиеLabel.Text = "Название услуги:";
            // 
            // код_недвижимостиLabel
            // 
            код_недвижимостиLabel.AutoSize = true;
            код_недвижимостиLabel.Location = new System.Drawing.Point(12, 40);
            код_недвижимостиLabel.Name = "код_недвижимостиLabel";
            код_недвижимостиLabel.Size = new System.Drawing.Size(107, 13);
            код_недвижимостиLabel.TabIndex = 14;
            код_недвижимостиLabel.Text = "Код недвижимости:";
            // 
            // тип_недвижимостиLabel
            // 
            тип_недвижимостиLabel.AutoSize = true;
            тип_недвижимостиLabel.Location = new System.Drawing.Point(12, 66);
            тип_недвижимостиLabel.Name = "тип_недвижимостиLabel";
            тип_недвижимостиLabel.Size = new System.Drawing.Size(107, 13);
            тип_недвижимостиLabel.TabIndex = 16;
            тип_недвижимостиLabel.Text = "Тип недвижимости:";
            // 
            // районLabel
            // 
            районLabel.AutoSize = true;
            районLabel.Location = new System.Drawing.Point(12, 92);
            районLabel.Name = "районLabel";
            районLabel.Size = new System.Drawing.Size(41, 13);
            районLabel.TabIndex = 18;
            районLabel.Text = "Район:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // недвижимостьBindingSource
            // 
            this.недвижимостьBindingSource.DataMember = "Недвижимость";
            this.недвижимостьBindingSource.DataSource = this.dataSet1;
            // 
            // недвижимостьTableAdapter
            // 
            this.недвижимостьTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Agentstvo.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.Вид_услугиTableAdapter = this.вид_услугиTableAdapter;
            this.tableAdapterManager.ДокументыTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.НедвижимостьTableAdapter = this.недвижимостьTableAdapter;
            this.tableAdapterManager.Систематизированная_база_агентстваTableAdapter = this.систематизированная_база_агентстваTableAdapter;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            // 
            // вид_услугиTableAdapter
            // 
            this.вид_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // систематизированная_база_агентстваTableAdapter
            // 
            this.систематизированная_база_агентстваTableAdapter.ClearBeforeFill = true;
            // 
            // недвижимостьBindingNavigator
            // 
            this.недвижимостьBindingNavigator.AddNewItem = null;
            this.недвижимостьBindingNavigator.BindingSource = this.недвижимостьBindingSource;
            this.недвижимостьBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.недвижимостьBindingNavigator.DeleteItem = null;
            this.недвижимостьBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.недвижимостьBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.недвижимостьBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.недвижимостьBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.недвижимостьBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.недвижимостьBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.недвижимостьBindingNavigator.Name = "недвижимостьBindingNavigator";
            this.недвижимостьBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.недвижимостьBindingNavigator.Size = new System.Drawing.Size(354, 25);
            this.недвижимостьBindingNavigator.TabIndex = 0;
            this.недвижимостьBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // систематизированная_база_агентстваBindingSource
            // 
            this.систематизированная_база_агентстваBindingSource.DataMember = "FK_Систематизированная_база_агентства_Недвижимость";
            this.систематизированная_база_агентстваBindingSource.DataSource = this.недвижимостьBindingSource;
            // 
            // вид_услугиBindingSource
            // 
            this.вид_услугиBindingSource.DataMember = "Вид_услуги";
            this.вид_услугиBindingSource.DataSource = this.dataSet1;
            // 
            // fKСистематизированнаябазаагентстваВидуслугиBindingSource
            // 
            this.fKСистематизированнаябазаагентстваВидуслугиBindingSource.DataMember = "FK_Систематизированная_база_агентства_Вид_услуги";
            this.fKСистематизированнаябазаагентстваВидуслугиBindingSource.DataSource = this.вид_услугиBindingSource;
            // 
            // fKСистематизированнаябазаагентстваВидуслугиBindingSource1
            // 
            this.fKСистематизированнаябазаагентстваВидуслугиBindingSource1.DataMember = "FK_Систематизированная_база_агентства_Вид_услуги";
            this.fKСистематизированнаябазаагентстваВидуслугиBindingSource1.DataSource = this.вид_услугиBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.систематизированная_база_агентстваBindingSource, "Код_услуги", true));
            this.comboBox1.DataSource = this.видуслугиBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.Enabled = false;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Код_услуги";
            // 
            // видуслугиBindingSource
            // 
            this.видуслугиBindingSource.DataMember = "Вид_услуги";
            this.видуслугиBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKСистематизированнаябазаагентстваНедвижимостьBindingSource
            // 
            this.fKСистематизированнаябазаагентстваНедвижимостьBindingSource.DataMember = "FK_Систематизированная_база_агентства_Недвижимость";
            this.fKСистематизированнаябазаагентстваНедвижимостьBindingSource.DataSource = this.недвижимостьBindingSource;
            // 
            // fKСистематизированнаябазаагентстваВидуслугиBindingSource2
            // 
            this.fKСистематизированнаябазаагентстваВидуслугиBindingSource2.DataMember = "FK_Систематизированная_база_агентства_Вид_услуги";
            this.fKСистематизированнаябазаагентстваВидуслугиBindingSource2.DataSource = this.вид_услугиBindingSource;
            // 
            // код_недвижимостиTextBox
            // 
            this.код_недвижимостиTextBox.BackColor = System.Drawing.Color.White;
            this.код_недвижимостиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Код_недвижимости", true));
            this.код_недвижимостиTextBox.Enabled = false;
            this.код_недвижимостиTextBox.ForeColor = System.Drawing.Color.Black;
            this.код_недвижимостиTextBox.Location = new System.Drawing.Point(125, 37);
            this.код_недвижимостиTextBox.Name = "код_недвижимостиTextBox";
            this.код_недвижимостиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_недвижимостиTextBox.TabIndex = 15;
            // 
            // тип_недвижимостиTextBox
            // 
            this.тип_недвижимостиTextBox.BackColor = System.Drawing.Color.White;
            this.тип_недвижимостиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Тип_недвижимости", true));
            this.тип_недвижимостиTextBox.Enabled = false;
            this.тип_недвижимостиTextBox.ForeColor = System.Drawing.Color.Black;
            this.тип_недвижимостиTextBox.Location = new System.Drawing.Point(125, 63);
            this.тип_недвижимостиTextBox.Name = "тип_недвижимостиTextBox";
            this.тип_недвижимостиTextBox.Size = new System.Drawing.Size(100, 20);
            this.тип_недвижимостиTextBox.TabIndex = 17;
            // 
            // районTextBox
            // 
            this.районTextBox.BackColor = System.Drawing.Color.White;
            this.районTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Район", true));
            this.районTextBox.Enabled = false;
            this.районTextBox.ForeColor = System.Drawing.Color.Black;
            this.районTextBox.Location = new System.Drawing.Point(125, 89);
            this.районTextBox.Name = "районTextBox";
            this.районTextBox.Size = new System.Drawing.Size(100, 20);
            this.районTextBox.TabIndex = 19;
            // 
            // систематизированная_база_агентстваDataGridView
            // 
            this.систематизированная_база_агентстваDataGridView.AllowUserToAddRows = false;
            this.систематизированная_база_агентстваDataGridView.AllowUserToDeleteRows = false;
            this.систематизированная_база_агентстваDataGridView.AutoGenerateColumns = false;
            this.систематизированная_база_агентстваDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.систематизированная_база_агентстваDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.систематизированная_база_агентстваDataGridView.DataSource = this.fKСистематизированнаябазаагентстваНедвижимостьBindingSource;
            this.систематизированная_база_агентстваDataGridView.Location = new System.Drawing.Point(0, 162);
            this.систематизированная_база_агентстваDataGridView.Name = "систематизированная_база_агентстваDataGridView";
            this.систематизированная_база_агентстваDataGridView.ReadOnly = true;
            this.систематизированная_база_агентстваDataGridView.Size = new System.Drawing.Size(349, 235);
            this.систематизированная_база_агентстваDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_услуги";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код услуги";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код_клиента";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код клиента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "(с) Сорокина М.С., КИБЭВС, ТУСУР, 2020 год";
            // 
            // NedClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.систематизированная_база_агентстваDataGridView);
            this.Controls.Add(код_недвижимостиLabel);
            this.Controls.Add(this.код_недвижимостиTextBox);
            this.Controls.Add(тип_недвижимостиLabel);
            this.Controls.Add(this.тип_недвижимостиTextBox);
            this.Controls.Add(районLabel);
            this.Controls.Add(this.районTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.недвижимостьBindingNavigator);
            this.Name = "NedClient";
            this.Text = "Недвижимость (клиент)";
            this.Load += new System.EventHandler(this.NedClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingNavigator)).EndInit();
            this.недвижимостьBindingNavigator.ResumeLayout(false);
            this.недвижимостьBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.систематизированная_база_агентстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вид_услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСистематизированнаябазаагентстваВидуслугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСистематизированнаябазаагентстваВидуслугиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видуслугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСистематизированнаябазаагентстваНедвижимостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKСистематизированнаябазаагентстваВидуслугиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.систематизированная_база_агентстваDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource недвижимостьBindingSource;
        private DataSet1TableAdapters.НедвижимостьTableAdapter недвижимостьTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator недвижимостьBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DataSet1TableAdapters.Систематизированная_база_агентстваTableAdapter систематизированная_база_агентстваTableAdapter;
        private System.Windows.Forms.BindingSource систематизированная_база_агентстваBindingSource;
        private DataSet1TableAdapters.Вид_услугиTableAdapter вид_услугиTableAdapter;
        private System.Windows.Forms.BindingSource вид_услугиBindingSource;
        private System.Windows.Forms.BindingSource fKСистематизированнаябазаагентстваВидуслугиBindingSource;
        private System.Windows.Forms.BindingSource fKСистематизированнаябазаагентстваВидуслугиBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource fKСистематизированнаябазаагентстваНедвижимостьBindingSource;
        private System.Windows.Forms.BindingSource fKСистематизированнаябазаагентстваВидуслугиBindingSource2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource видуслугиBindingSource;
        private System.Windows.Forms.TextBox код_недвижимостиTextBox;
        private System.Windows.Forms.TextBox тип_недвижимостиTextBox;
        private System.Windows.Forms.TextBox районTextBox;
        private System.Windows.Forms.DataGridView систематизированная_база_агентстваDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
    }
}