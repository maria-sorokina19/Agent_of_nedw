namespace Agentstvo
{
    partial class NedwBase
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
            System.Windows.Forms.Label код_недвижимостиLabel;
            System.Windows.Forms.Label тип_недвижимостиLabel;
            System.Windows.Forms.Label районLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NedwBase));
            this.dataSet1 = new Agentstvo.DataSet1();
            this.недвижимостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.недвижимостьTableAdapter = new Agentstvo.DataSet1TableAdapters.НедвижимостьTableAdapter();
            this.tableAdapterManager = new Agentstvo.DataSet1TableAdapters.TableAdapterManager();
            this.документыTableAdapter = new Agentstvo.DataSet1TableAdapters.ДокументыTableAdapter();
            this.систематизированная_база_агентстваTableAdapter = new Agentstvo.DataSet1TableAdapters.Систематизированная_база_агентстваTableAdapter();
            this.недвижимостьBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.недвижимостьBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_недвижимостиTextBox = new System.Windows.Forms.TextBox();
            this.тип_недвижимостиTextBox = new System.Windows.Forms.TextBox();
            this.районTextBox = new System.Windows.Forms.TextBox();
            this.документыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.систематизированная_база_агентстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.систематизированная_база_агентстваDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            код_недвижимостиLabel = new System.Windows.Forms.Label();
            тип_недвижимостиLabel = new System.Windows.Forms.Label();
            районLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingNavigator)).BeginInit();
            this.недвижимостьBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.документыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.систематизированная_база_агентстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.систематизированная_база_агентстваDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_недвижимостиLabel
            // 
            код_недвижимостиLabel.AutoSize = true;
            код_недвижимостиLabel.Location = new System.Drawing.Point(12, 44);
            код_недвижимостиLabel.Name = "код_недвижимостиLabel";
            код_недвижимостиLabel.Size = new System.Drawing.Size(107, 13);
            код_недвижимостиLabel.TabIndex = 1;
            код_недвижимостиLabel.Text = "Код недвижимости:";
            // 
            // тип_недвижимостиLabel
            // 
            тип_недвижимостиLabel.AutoSize = true;
            тип_недвижимостиLabel.Location = new System.Drawing.Point(12, 70);
            тип_недвижимостиLabel.Name = "тип_недвижимостиLabel";
            тип_недвижимостиLabel.Size = new System.Drawing.Size(107, 13);
            тип_недвижимостиLabel.TabIndex = 3;
            тип_недвижимостиLabel.Text = "Тип недвижимости:";
            // 
            // районLabel
            // 
            районLabel.AutoSize = true;
            районLabel.Location = new System.Drawing.Point(12, 96);
            районLabel.Name = "районLabel";
            районLabel.Size = new System.Drawing.Size(41, 13);
            районLabel.TabIndex = 5;
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
            this.tableAdapterManager.Вид_услугиTableAdapter = null;
            this.tableAdapterManager.ДокументыTableAdapter = this.документыTableAdapter;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.НедвижимостьTableAdapter = this.недвижимостьTableAdapter;
            this.tableAdapterManager.Систематизированная_база_агентстваTableAdapter = this.систематизированная_база_агентстваTableAdapter;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            // 
            // документыTableAdapter
            // 
            this.документыTableAdapter.ClearBeforeFill = true;
            // 
            // систематизированная_база_агентстваTableAdapter
            // 
            this.систематизированная_база_агентстваTableAdapter.ClearBeforeFill = true;
            // 
            // недвижимостьBindingNavigator
            // 
            this.недвижимостьBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.недвижимостьBindingNavigator.BindingSource = this.недвижимостьBindingSource;
            this.недвижимостьBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.недвижимостьBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.недвижимостьBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.недвижимостьBindingNavigatorSaveItem});
            this.недвижимостьBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.недвижимостьBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.недвижимостьBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.недвижимостьBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.недвижимостьBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.недвижимостьBindingNavigator.Name = "недвижимостьBindingNavigator";
            this.недвижимостьBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.недвижимостьBindingNavigator.Size = new System.Drawing.Size(622, 25);
            this.недвижимостьBindingNavigator.TabIndex = 0;
            this.недвижимостьBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // недвижимостьBindingNavigatorSaveItem
            // 
            this.недвижимостьBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.недвижимостьBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("недвижимостьBindingNavigatorSaveItem.Image")));
            this.недвижимостьBindingNavigatorSaveItem.Name = "недвижимостьBindingNavigatorSaveItem";
            this.недвижимостьBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.недвижимостьBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.недвижимостьBindingNavigatorSaveItem.Click += new System.EventHandler(this.недвижимостьBindingNavigatorSaveItem_Click);
            // 
            // код_недвижимостиTextBox
            // 
            this.код_недвижимостиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Код_недвижимости", true));
            this.код_недвижимостиTextBox.Location = new System.Drawing.Point(125, 41);
            this.код_недвижимостиTextBox.Name = "код_недвижимостиTextBox";
            this.код_недвижимостиTextBox.Size = new System.Drawing.Size(127, 20);
            this.код_недвижимостиTextBox.TabIndex = 2;
            // 
            // тип_недвижимостиTextBox
            // 
            this.тип_недвижимостиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Тип_недвижимости", true));
            this.тип_недвижимостиTextBox.Location = new System.Drawing.Point(125, 67);
            this.тип_недвижимостиTextBox.Name = "тип_недвижимостиTextBox";
            this.тип_недвижимостиTextBox.Size = new System.Drawing.Size(127, 20);
            this.тип_недвижимостиTextBox.TabIndex = 4;
            // 
            // районTextBox
            // 
            this.районTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Район", true));
            this.районTextBox.Location = new System.Drawing.Point(125, 93);
            this.районTextBox.Name = "районTextBox";
            this.районTextBox.Size = new System.Drawing.Size(127, 20);
            this.районTextBox.TabIndex = 6;
            // 
            // документыBindingSource
            // 
            this.документыBindingSource.DataMember = "FK_Документы_Недвижимость";
            this.документыBindingSource.DataSource = this.недвижимостьBindingSource;
            // 
            // документыDataGridView
            // 
            this.документыDataGridView.AllowUserToDeleteRows = false;
            this.документыDataGridView.AutoGenerateColumns = false;
            this.документыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.документыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.документыDataGridView.DataSource = this.документыBindingSource;
            this.документыDataGridView.Location = new System.Drawing.Point(0, 192);
            this.документыDataGridView.Name = "документыDataGridView";
            this.документыDataGridView.Size = new System.Drawing.Size(622, 138);
            this.документыDataGridView.TabIndex = 7;
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код_клиента";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код клиента";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код_сотрудника";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код сотрудника";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // систематизированная_база_агентстваBindingSource
            // 
            this.систематизированная_база_агентстваBindingSource.DataMember = "FK_Систематизированная_база_агентства_Недвижимость";
            this.систематизированная_база_агентстваBindingSource.DataSource = this.недвижимостьBindingSource;
            // 
            // систематизированная_база_агентстваDataGridView
            // 
            this.систематизированная_база_агентстваDataGridView.AllowUserToDeleteRows = false;
            this.систематизированная_база_агентстваDataGridView.AutoGenerateColumns = false;
            this.систематизированная_база_агентстваDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.систематизированная_база_агентстваDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.систематизированная_база_агентстваDataGridView.DataSource = this.систематизированная_база_агентстваBindingSource;
            this.систематизированная_база_агентстваDataGridView.Location = new System.Drawing.Point(267, 41);
            this.систематизированная_база_агентстваDataGridView.Name = "систематизированная_база_агентстваDataGridView";
            this.систематизированная_база_агентстваDataGridView.Size = new System.Drawing.Size(355, 145);
            this.систематизированная_база_агентстваDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Код_услуги";
            this.dataGridViewTextBoxColumn8.HeaderText = "Код услуги";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Код_клиента";
            this.dataGridViewTextBoxColumn9.HeaderText = "Код клиента";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn10.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "(с) Сорокина М.С., КИБЭВС, ТУСУР, 2020 год";
            // 
            // NedwBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.систематизированная_база_агентстваDataGridView);
            this.Controls.Add(this.документыDataGridView);
            this.Controls.Add(код_недвижимостиLabel);
            this.Controls.Add(this.код_недвижимостиTextBox);
            this.Controls.Add(тип_недвижимостиLabel);
            this.Controls.Add(this.тип_недвижимостиTextBox);
            this.Controls.Add(районLabel);
            this.Controls.Add(this.районTextBox);
            this.Controls.Add(this.недвижимостьBindingNavigator);
            this.Name = "NedwBase";
            this.Text = "Недвижимость и документы";
            this.Load += new System.EventHandler(this.NedwBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingNavigator)).EndInit();
            this.недвижимостьBindingNavigator.ResumeLayout(false);
            this.недвижимостьBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.документыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.систематизированная_база_агентстваBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton недвижимостьBindingNavigatorSaveItem;
        private DataSet1TableAdapters.ДокументыTableAdapter документыTableAdapter;
        private System.Windows.Forms.TextBox код_недвижимостиTextBox;
        private System.Windows.Forms.TextBox тип_недвижимостиTextBox;
        private System.Windows.Forms.TextBox районTextBox;
        private System.Windows.Forms.BindingSource документыBindingSource;
        private DataSet1TableAdapters.Систематизированная_база_агентстваTableAdapter систематизированная_база_агентстваTableAdapter;
        private System.Windows.Forms.DataGridView документыDataGridView;
        private System.Windows.Forms.BindingSource систематизированная_база_агентстваBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView систематизированная_база_агентстваDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label2;
    }
}