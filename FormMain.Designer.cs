namespace Agentstvo
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.недвижимостьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.базаНедвижимостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиИИхДокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПриложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзУчетнойЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.недвижимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ClientToolStripMenuItem,
            this.настройкаПользователейToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformToolStripMenuItem,
            this.CloseToolStripMenuItem,
            this.UnLoginToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // InformToolStripMenuItem
            // 
            this.InformToolStripMenuItem.Image = global::Agentstvo.Properties.Resources.Информация_1;
            this.InformToolStripMenuItem.Name = "InformToolStripMenuItem";
            this.InformToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.InformToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.InformToolStripMenuItem.Text = "О программе";
            this.InformToolStripMenuItem.Click += new System.EventHandler(this.InformToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Image = global::Agentstvo.Properties.Resources.закрыть;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.CloseToolStripMenuItem.Text = "Выход из приложения";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // UnLoginToolStripMenuItem
            // 
            this.UnLoginToolStripMenuItem.Image = global::Agentstvo.Properties.Resources.Без_названия;
            this.UnLoginToolStripMenuItem.Name = "UnLoginToolStripMenuItem";
            this.UnLoginToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.UnLoginToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.UnLoginToolStripMenuItem.Text = "Выход из учетной записи";
            this.UnLoginToolStripMenuItem.Click += new System.EventHandler(this.UnLoginToolStripMenuItem_Click);
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem1,
            this.сотрудникиToolStripMenuItem1,
            this.недвижимостьToolStripMenuItem1,
            this.услугиToolStripMenuItem1,
            this.базаНедвижимостиToolStripMenuItem,
            this.сотрудникиИИхДокументыToolStripMenuItem});
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.ClientToolStripMenuItem.Text = "База агентства";
            // 
            // клиентыToolStripMenuItem1
            // 
            this.клиентыToolStripMenuItem1.Name = "клиентыToolStripMenuItem1";
            this.клиентыToolStripMenuItem1.Size = new System.Drawing.Size(283, 22);
            this.клиентыToolStripMenuItem1.Text = "Клиенты, недвижимость и документы";
            this.клиентыToolStripMenuItem1.Click += new System.EventHandler(this.клиентыToolStripMenuItem1_Click);
            // 
            // сотрудникиToolStripMenuItem1
            // 
            this.сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            this.сотрудникиToolStripMenuItem1.Size = new System.Drawing.Size(283, 22);
            this.сотрудникиToolStripMenuItem1.Text = "Услуги и сотрудники";
            this.сотрудникиToolStripMenuItem1.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem1_Click);
            // 
            // недвижимостьToolStripMenuItem1
            // 
            this.недвижимостьToolStripMenuItem1.Name = "недвижимостьToolStripMenuItem1";
            this.недвижимостьToolStripMenuItem1.Size = new System.Drawing.Size(283, 22);
            this.недвижимостьToolStripMenuItem1.Text = "Документы";
            this.недвижимостьToolStripMenuItem1.Click += new System.EventHandler(this.недвижимостьToolStripMenuItem1_Click);
            // 
            // услугиToolStripMenuItem1
            // 
            this.услугиToolStripMenuItem1.Name = "услугиToolStripMenuItem1";
            this.услугиToolStripMenuItem1.Size = new System.Drawing.Size(283, 22);
            this.услугиToolStripMenuItem1.Text = "Недвижимость и документы";
            this.услугиToolStripMenuItem1.Click += new System.EventHandler(this.NedwBaseToolStripMenuItem1_Click);
            // 
            // базаНедвижимостиToolStripMenuItem
            // 
            this.базаНедвижимостиToolStripMenuItem.Name = "базаНедвижимостиToolStripMenuItem";
            this.базаНедвижимостиToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.базаНедвижимостиToolStripMenuItem.Text = "База недвижимости";
            this.базаНедвижимостиToolStripMenuItem.Click += new System.EventHandler(this.базаНедвижимостиToolStripMenuItem_Click);
            // 
            // сотрудникиИИхДокументыToolStripMenuItem
            // 
            this.сотрудникиИИхДокументыToolStripMenuItem.Name = "сотрудникиИИхДокументыToolStripMenuItem";
            this.сотрудникиИИхДокументыToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.сотрудникиИИхДокументыToolStripMenuItem.Text = "Сотрудники и их документы";
            this.сотрудникиИИхДокументыToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиИИхДокументыToolStripMenuItem_Click);
            // 
            // настройкаПользователейToolStripMenuItem
            // 
            this.настройкаПользователейToolStripMenuItem.Name = "настройкаПользователейToolStripMenuItem";
            this.настройкаПользователейToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.настройкаПользователейToolStripMenuItem.Text = "Настройка пользователей";
            this.настройкаПользователейToolStripMenuItem.Click += new System.EventHandler(this.настройкаПользователейToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.клиентыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.недвижимостьToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.документыToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 136);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходИзПриложенияToolStripMenuItem,
            this.выходИзУчетнойЗаписиToolStripMenuItem});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.InformToolStripMenuItem_Click);
            // 
            // выходИзПриложенияToolStripMenuItem
            // 
            this.выходИзПриложенияToolStripMenuItem.Name = "выходИзПриложенияToolStripMenuItem";
            this.выходИзПриложенияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходИзПриложенияToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.выходИзПриложенияToolStripMenuItem.Text = "Выход из приложения";
            this.выходИзПриложенияToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // выходИзУчетнойЗаписиToolStripMenuItem
            // 
            this.выходИзУчетнойЗаписиToolStripMenuItem.Name = "выходИзУчетнойЗаписиToolStripMenuItem";
            this.выходИзУчетнойЗаписиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.выходИзУчетнойЗаписиToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.выходИзУчетнойЗаписиToolStripMenuItem.Text = "Выход из учетной записи";
            this.выходИзУчетнойЗаписиToolStripMenuItem.Click += new System.EventHandler(this.UnLoginToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // недвижимостьToolStripMenuItem
            // 
            this.недвижимостьToolStripMenuItem.Name = "недвижимостьToolStripMenuItem";
            this.недвижимостьToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.недвижимостьToolStripMenuItem.Text = "Недвижимость";
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(397, 25);
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
            this.toolStripButton1.Text = "Выйти из программы";
            this.toolStripButton1.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Agentstvo.Properties.Resources.Без_названия;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Выйти из учетной записи";
            this.toolStripButton2.Click += new System.EventHandler(this.UnLoginToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Agentstvo.Properties.Resources.Информация_1;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "О программе";
            this.toolStripButton3.Click += new System.EventHandler(this.InformToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Доброго времени суток, Администратор!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "(с) Сорокина М.С., КИБЭВС, ТУСУР, 2020 год";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 119);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Агентство недвижимости Администратор ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПриложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзУчетнойЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem недвижимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem недвижимостьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem базаНедвижимостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиИИхДокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПользователейToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

