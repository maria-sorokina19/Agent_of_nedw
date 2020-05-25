namespace Agentstvo
{
    partial class EmployeBase
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
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label серия_и_номер_паспортаLabel;
            System.Windows.Forms.Label занятостьLabel;
            System.Windows.Forms.Label код_услугиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeBase));
            this.dataSet1 = new Agentstvo.DataSet1();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new Agentstvo.DataSet1TableAdapters.СотрудникTableAdapter();
            this.tableAdapterManager = new Agentstvo.DataSet1TableAdapters.TableAdapterManager();
            this.документыTableAdapter = new Agentstvo.DataSet1TableAdapters.ДокументыTableAdapter();
            this.сотрудникBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.сотрудникBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.серия_и_номер_паспортаTextBox = new System.Windows.Forms.TextBox();
            this.занятостьComboBox = new System.Windows.Forms.ComboBox();
            this.код_услугиTextBox = new System.Windows.Forms.TextBox();
            this.документыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            серия_и_номер_паспортаLabel = new System.Windows.Forms.Label();
            занятостьLabel = new System.Windows.Forms.Label();
            код_услугиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingNavigator)).BeginInit();
            this.сотрудникBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.документыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(23, 39);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(90, 13);
            код_сотрудникаLabel.TabIndex = 1;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(23, 65);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // серия_и_номер_паспортаLabel
            // 
            серия_и_номер_паспортаLabel.AutoSize = true;
            серия_и_номер_паспортаLabel.Location = new System.Drawing.Point(23, 91);
            серия_и_номер_паспортаLabel.Name = "серия_и_номер_паспортаLabel";
            серия_и_номер_паспортаLabel.Size = new System.Drawing.Size(135, 13);
            серия_и_номер_паспортаLabel.TabIndex = 5;
            серия_и_номер_паспортаLabel.Text = "Серия и номер паспорта:";
            // 
            // занятостьLabel
            // 
            занятостьLabel.AutoSize = true;
            занятостьLabel.Location = new System.Drawing.Point(23, 117);
            занятостьLabel.Name = "занятостьLabel";
            занятостьLabel.Size = new System.Drawing.Size(63, 13);
            занятостьLabel.TabIndex = 7;
            занятостьLabel.Text = "Занятость:";
            // 
            // код_услугиLabel
            // 
            код_услугиLabel.AutoSize = true;
            код_услугиLabel.Location = new System.Drawing.Point(23, 144);
            код_услугиLabel.Name = "код_услугиLabel";
            код_услугиLabel.Size = new System.Drawing.Size(65, 13);
            код_услугиLabel.TabIndex = 9;
            код_услугиLabel.Text = "Код услуги:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.dataSet1;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Agentstvo.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.Вид_услугиTableAdapter = null;
            this.tableAdapterManager.ДокументыTableAdapter = this.документыTableAdapter;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.НедвижимостьTableAdapter = null;
            this.tableAdapterManager.Систематизированная_база_агентстваTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = this.сотрудникTableAdapter;
            // 
            // документыTableAdapter
            // 
            this.документыTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникBindingNavigator
            // 
            this.сотрудникBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сотрудникBindingNavigator.BindingSource = this.сотрудникBindingSource;
            this.сотрудникBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сотрудникBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сотрудникBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.сотрудникBindingNavigatorSaveItem});
            this.сотрудникBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.сотрудникBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сотрудникBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сотрудникBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сотрудникBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сотрудникBindingNavigator.Name = "сотрудникBindingNavigator";
            this.сотрудникBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сотрудникBindingNavigator.Size = new System.Drawing.Size(548, 25);
            this.сотрудникBindingNavigator.TabIndex = 0;
            this.сотрудникBindingNavigator.Text = "bindingNavigator1";
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
            // сотрудникBindingNavigatorSaveItem
            // 
            this.сотрудникBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сотрудникBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сотрудникBindingNavigatorSaveItem.Image")));
            this.сотрудникBindingNavigatorSaveItem.Name = "сотрудникBindingNavigatorSaveItem";
            this.сотрудникBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.сотрудникBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сотрудникBindingNavigatorSaveItem.Click += new System.EventHandler(this.сотрудникBindingNavigatorSaveItem_Click);
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource, "Код_сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(164, 36);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(278, 20);
            this.код_сотрудникаTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(164, 62);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(278, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // серия_и_номер_паспортаTextBox
            // 
            this.серия_и_номер_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource, "Серия и номер паспорта", true));
            this.серия_и_номер_паспортаTextBox.Location = new System.Drawing.Point(164, 88);
            this.серия_и_номер_паспортаTextBox.Name = "серия_и_номер_паспортаTextBox";
            this.серия_и_номер_паспортаTextBox.Size = new System.Drawing.Size(278, 20);
            this.серия_и_номер_паспортаTextBox.TabIndex = 6;
            // 
            // занятостьComboBox
            // 
            this.занятостьComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource, "Занятость", true));
            this.занятостьComboBox.FormattingEnabled = true;
            this.занятостьComboBox.Items.AddRange(new object[] {
            "Занят",
            "Свободен"});
            this.занятостьComboBox.Location = new System.Drawing.Point(164, 114);
            this.занятостьComboBox.Name = "занятостьComboBox";
            this.занятостьComboBox.Size = new System.Drawing.Size(278, 21);
            this.занятостьComboBox.TabIndex = 8;
            // 
            // код_услугиTextBox
            // 
            this.код_услугиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource, "Код_услуги", true));
            this.код_услугиTextBox.Location = new System.Drawing.Point(164, 141);
            this.код_услугиTextBox.Name = "код_услугиTextBox";
            this.код_услугиTextBox.Size = new System.Drawing.Size(278, 20);
            this.код_услугиTextBox.TabIndex = 10;
            // 
            // документыBindingSource
            // 
            this.документыBindingSource.DataMember = "FK_Документы_Сотрудник";
            this.документыBindingSource.DataSource = this.сотрудникBindingSource;
            // 
            // документыDataGridView
            // 
            this.документыDataGridView.AutoGenerateColumns = false;
            this.документыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.документыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.документыDataGridView.DataSource = this.документыBindingSource;
            this.документыDataGridView.Location = new System.Drawing.Point(0, 179);
            this.документыDataGridView.Name = "документыDataGridView";
            this.документыDataGridView.Size = new System.Drawing.Size(547, 240);
            this.документыDataGridView.TabIndex = 11;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код_недвижимости";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код недвижимости";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код_клиента";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код клиента";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "(с) Сорокина М.С., КИБЭВС, ТУСУР, 2020 год";
            // 
            // EmployeBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.документыDataGridView);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(серия_и_номер_паспортаLabel);
            this.Controls.Add(this.серия_и_номер_паспортаTextBox);
            this.Controls.Add(занятостьLabel);
            this.Controls.Add(this.занятостьComboBox);
            this.Controls.Add(код_услугиLabel);
            this.Controls.Add(this.код_услугиTextBox);
            this.Controls.Add(this.сотрудникBindingNavigator);
            this.Name = "EmployeBase";
            this.Text = "Сотрудники и их документы";
            this.Load += new System.EventHandler(this.EmployeBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingNavigator)).EndInit();
            this.сотрудникBindingNavigator.ResumeLayout(false);
            this.сотрудникBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.документыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private DataSet1TableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сотрудникBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton сотрудникBindingNavigatorSaveItem;
        private DataSet1TableAdapters.ДокументыTableAdapter документыTableAdapter;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox серия_и_номер_паспортаTextBox;
        private System.Windows.Forms.ComboBox занятостьComboBox;
        private System.Windows.Forms.TextBox код_услугиTextBox;
        private System.Windows.Forms.BindingSource документыBindingSource;
        private System.Windows.Forms.DataGridView документыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.Label label2;
    }
}