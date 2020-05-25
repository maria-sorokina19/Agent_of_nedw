namespace Agentstvo
{
    partial class FormClient
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
            System.Windows.Forms.Label код_клиентаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label серия_и_номер_паспортаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПриложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзУчетнойЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.недвижимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПриложенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзУчетнойЗаписиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.клиентBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.клиентBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.серия_и_номер_паспортаTextBox = new System.Windows.Forms.TextBox();
            this.документыDataGridView = new System.Windows.Forms.DataGridView();
            this.документыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Agentstvo.DataSet1();
            this.вид_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new Agentstvo.DataSet1TableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new Agentstvo.DataSet1TableAdapters.TableAdapterManager();
            this.документыTableAdapter = new Agentstvo.DataSet1TableAdapters.ДокументыTableAdapter();
            this.вид_услугиTableAdapter = new Agentstvo.DataSet1TableAdapters.Вид_услугиTableAdapter();
            код_клиентаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            серия_и_номер_паспортаLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingNavigator)).BeginInit();
            this.клиентBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.документыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вид_услугиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_клиентаLabel
            // 
            код_клиентаLabel.AutoSize = true;
            код_клиентаLabel.Location = new System.Drawing.Point(22, 90);
            код_клиентаLabel.Name = "код_клиентаLabel";
            код_клиентаLabel.Size = new System.Drawing.Size(73, 13);
            код_клиентаLabel.TabIndex = 4;
            код_клиентаLabel.Text = "Код клиента:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(22, 116);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 6;
            фИОLabel.Text = "ФИО:";
            // 
            // серия_и_номер_паспортаLabel
            // 
            серия_и_номер_паспортаLabel.AutoSize = true;
            серия_и_номер_паспортаLabel.Location = new System.Drawing.Point(22, 142);
            серия_и_номер_паспортаLabel.Name = "серия_и_номер_паспортаLabel";
            серия_и_номер_паспортаLabel.Size = new System.Drawing.Size(135, 13);
            серия_и_номер_паспортаLabel.TabIndex = 8;
            серия_и_номер_паспортаLabel.Text = "Серия и номер паспорта:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.предложенияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходИзПриложенияToolStripMenuItem,
            this.выходИзУчетнойЗаписиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::Agentstvo.Properties.Resources.Информация_1;
            this.оПрограммеToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // выходИзПриложенияToolStripMenuItem
            // 
            this.выходИзПриложенияToolStripMenuItem.Image = global::Agentstvo.Properties.Resources.закрыть;
            this.выходИзПриложенияToolStripMenuItem.Name = "выходИзПриложенияToolStripMenuItem";
            this.выходИзПриложенияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходИзПриложенияToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.выходИзПриложенияToolStripMenuItem.Text = "Выход из приложения";
            this.выходИзПриложенияToolStripMenuItem.Click += new System.EventHandler(this.выходИзПриложенияToolStripMenuItem_Click);
            // 
            // выходИзУчетнойЗаписиToolStripMenuItem
            // 
            this.выходИзУчетнойЗаписиToolStripMenuItem.Image = global::Agentstvo.Properties.Resources.Без_названия;
            this.выходИзУчетнойЗаписиToolStripMenuItem.Name = "выходИзУчетнойЗаписиToolStripMenuItem";
            this.выходИзУчетнойЗаписиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.выходИзУчетнойЗаписиToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.выходИзУчетнойЗаписиToolStripMenuItem.Text = "Выход из учетной записи";
            this.выходИзУчетнойЗаписиToolStripMenuItem.Click += new System.EventHandler(this.выходИзУчетнойЗаписиToolStripMenuItem_Click);
            // 
            // предложенияToolStripMenuItem
            // 
            this.предложенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.недвижимостьToolStripMenuItem});
            this.предложенияToolStripMenuItem.Name = "предложенияToolStripMenuItem";
            this.предложенияToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.предложенияToolStripMenuItem.Text = "Предложения";
            // 
            // недвижимостьToolStripMenuItem
            // 
            this.недвижимостьToolStripMenuItem.Image = global::Agentstvo.Properties.Resources.дом;
            this.недвижимостьToolStripMenuItem.Name = "недвижимостьToolStripMenuItem";
            this.недвижимостьToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.недвижимостьToolStripMenuItem.Text = "Недвижимость";
            this.недвижимостьToolStripMenuItem.Click += new System.EventHandler(this.недвижимостьToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1,
            this.выходИзПриложенияToolStripMenuItem1,
            this.выходИзУчетнойЗаписиToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(254, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // выходИзПриложенияToolStripMenuItem1
            // 
            this.выходИзПриложенияToolStripMenuItem1.Name = "выходИзПриложенияToolStripMenuItem1";
            this.выходИзПриложенияToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходИзПриложенияToolStripMenuItem1.Size = new System.Drawing.Size(254, 22);
            this.выходИзПриложенияToolStripMenuItem1.Text = "Выход из приложения";
            this.выходИзПриложенияToolStripMenuItem1.Click += new System.EventHandler(this.выходИзПриложенияToolStripMenuItem_Click);
            // 
            // выходИзУчетнойЗаписиToolStripMenuItem1
            // 
            this.выходИзУчетнойЗаписиToolStripMenuItem1.Name = "выходИзУчетнойЗаписиToolStripMenuItem1";
            this.выходИзУчетнойЗаписиToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.выходИзУчетнойЗаписиToolStripMenuItem1.Size = new System.Drawing.Size(254, 22);
            this.выходИзУчетнойЗаписиToolStripMenuItem1.Text = "Выход из учетной записи";
            this.выходИзУчетнойЗаписиToolStripMenuItem1.Click += new System.EventHandler(this.выходИзУчетнойЗаписиToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Agentstvo.Properties.Resources.закрыть;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Выйти из приложения";
            this.toolStripButton1.Click += new System.EventHandler(this.выходИзПриложенияToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Agentstvo.Properties.Resources.Без_названия;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Выйти из учетной записи";
            this.toolStripButton2.Click += new System.EventHandler(this.выходИзУчетнойЗаписиToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Agentstvo.Properties.Resources.Информация_1;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "О программе";
            this.toolStripButton3.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // клиентBindingNavigator
            // 
            this.клиентBindingNavigator.AddNewItem = null;
            this.клиентBindingNavigator.BindingSource = this.клиентBindingSource;
            this.клиентBindingNavigator.CountItem = null;
            this.клиентBindingNavigator.DeleteItem = null;
            this.клиентBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентBindingNavigatorSaveItem});
            this.клиентBindingNavigator.Location = new System.Drawing.Point(0, 49);
            this.клиентBindingNavigator.MoveFirstItem = null;
            this.клиентBindingNavigator.MoveLastItem = null;
            this.клиентBindingNavigator.MoveNextItem = null;
            this.клиентBindingNavigator.MovePreviousItem = null;
            this.клиентBindingNavigator.Name = "клиентBindingNavigator";
            this.клиентBindingNavigator.PositionItem = null;
            this.клиентBindingNavigator.Size = new System.Drawing.Size(573, 25);
            this.клиентBindingNavigator.TabIndex = 3;
            this.клиентBindingNavigator.Text = "bindingNavigator1";
            // 
            // клиентBindingNavigatorSaveItem
            // 
            this.клиентBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клиентBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клиентBindingNavigatorSaveItem.Image")));
            this.клиентBindingNavigatorSaveItem.Name = "клиентBindingNavigatorSaveItem";
            this.клиентBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.клиентBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клиентBindingNavigatorSaveItem.Click += new System.EventHandler(this.клиентBindingNavigatorSaveItem_Click);
            // 
            // код_клиентаTextBox
            // 
            this.код_клиентаTextBox.BackColor = System.Drawing.Color.White;
            this.код_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Код_клиента", true));
            this.код_клиентаTextBox.Enabled = false;
            this.код_клиентаTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.код_клиентаTextBox.Location = new System.Drawing.Point(163, 87);
            this.код_клиентаTextBox.Name = "код_клиентаTextBox";
            this.код_клиентаTextBox.Size = new System.Drawing.Size(378, 20);
            this.код_клиентаTextBox.TabIndex = 5;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(163, 113);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(378, 20);
            this.фИОTextBox.TabIndex = 7;
            // 
            // серия_и_номер_паспортаTextBox
            // 
            this.серия_и_номер_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Серия и номер паспорта", true));
            this.серия_и_номер_паспортаTextBox.Location = new System.Drawing.Point(163, 139);
            this.серия_и_номер_паспортаTextBox.Name = "серия_и_номер_паспортаTextBox";
            this.серия_и_номер_паспортаTextBox.Size = new System.Drawing.Size(378, 20);
            this.серия_и_номер_паспортаTextBox.TabIndex = 9;
            // 
            // документыDataGridView
            // 
            this.документыDataGridView.AllowUserToAddRows = false;
            this.документыDataGridView.AllowUserToDeleteRows = false;
            this.документыDataGridView.AutoGenerateColumns = false;
            this.документыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.документыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.документыDataGridView.DataSource = this.документыBindingSource;
            this.документыDataGridView.Location = new System.Drawing.Point(0, 172);
            this.документыDataGridView.Name = "документыDataGridView";
            this.документыDataGridView.ReadOnly = true;
            this.документыDataGridView.Size = new System.Drawing.Size(553, 236);
            this.документыDataGridView.TabIndex = 10;
            // 
            // документыBindingSource
            // 
            this.документыBindingSource.DataMember = "FK_Документы_Клиент";
            this.документыBindingSource.DataSource = this.клиентBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "(с) Сорокина М.С., КИБЭВС, ТУСУР, 2020 год";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_документа";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код документа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Вид";
            this.dataGridViewTextBoxColumn2.HeaderText = "Вид";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код_недвижимости";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код недвижимости";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код_сотрудника";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код сотрудника";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вид_услугиBindingSource
            // 
            this.вид_услугиBindingSource.DataMember = "Вид_услуги";
            this.вид_услугиBindingSource.DataSource = this.dataSet1;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TempTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Agentstvo.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.Вид_услугиTableAdapter = null;
            this.tableAdapterManager.ДокументыTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.НедвижимостьTableAdapter = null;
            this.tableAdapterManager.Систематизированная_база_агентстваTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            // 
            // документыTableAdapter
            // 
            this.документыTableAdapter.ClearBeforeFill = true;
            // 
            // вид_услугиTableAdapter
            // 
            this.вид_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 444);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.документыDataGridView);
            this.Controls.Add(код_клиентаLabel);
            this.Controls.Add(this.код_клиентаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(серия_и_номер_паспортаLabel);
            this.Controls.Add(this.серия_и_номер_паспортаTextBox);
            this.Controls.Add(this.клиентBindingNavigator);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormClient";
            this.Text = "Агентство недвижимости Клиент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClient_FormClosed);
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingNavigator)).EndInit();
            this.клиентBindingNavigator.ResumeLayout(false);
            this.клиентBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.документыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вид_услугиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПриложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзУчетнойЗаписиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходИзПриложенияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходИзУчетнойЗаписиToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem предложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem недвижимостьToolStripMenuItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private DataSet1TableAdapters.КлиентTableAdapter клиентTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клиентBindingNavigator;
        private System.Windows.Forms.ToolStripButton клиентBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_клиентаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox серия_и_номер_паспортаTextBox;
        private System.Windows.Forms.BindingSource документыBindingSource;
        private DataSet1TableAdapters.ДокументыTableAdapter документыTableAdapter;
        private System.Windows.Forms.DataGridView документыDataGridView;
        private System.Windows.Forms.BindingSource вид_услугиBindingSource;
        private DataSet1TableAdapters.Вид_услугиTableAdapter вид_услугиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
    }
}