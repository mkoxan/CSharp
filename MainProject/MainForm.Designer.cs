namespace MainProject
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btTask = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenXml = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAsText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAsBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAsXml = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colQuality,
            this.colTime});
            this.dgv.Location = new System.Drawing.Point(12, 27);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersWidth = 60;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(560, 367);
            this.dgv.TabIndex = 0;
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Dgv_RowsAdded);
            this.dgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Dgv_RowsRemoved);
            this.dgv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_MouseDoubleClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Название";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 300;
            // 
            // colQuality
            // 
            this.colQuality.HeaderText = "Качество";
            this.colQuality.Name = "colQuality";
            this.colQuality.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Длительность";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(578, 27);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(129, 75);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(578, 108);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(129, 75);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // btTask
            // 
            this.btTask.Location = new System.Drawing.Point(578, 189);
            this.btTask.Name = "btTask";
            this.btTask.Size = new System.Drawing.Size(129, 75);
            this.btTask.TabIndex = 4;
            this.btTask.Text = "Задание";
            this.btTask.UseVisualStyleBackColor = true;
            this.btTask.Click += new System.EventHandler(this.BtTask_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.правкаToolStripMenuItem,
            this.заданиеToolStripMenuItem,
            this.сброситьФильтрToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(724, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreate,
            this.menuOpen,
            this.menuSave,
            this.menuSaveAs,
            this.menuClear});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuCreate
            // 
            this.menuCreate.Name = "menuCreate";
            this.menuCreate.Size = new System.Drawing.Size(153, 22);
            this.menuCreate.Text = "Создать";
            this.menuCreate.Click += new System.EventHandler(this.MenuCreate_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenText,
            this.menuOpenBinary,
            this.menuOpenXml});
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(153, 22);
            this.menuOpen.Text = "Открыть";
            // 
            // menuOpenText
            // 
            this.menuOpenText.Name = "menuOpenText";
            this.menuOpenText.Size = new System.Drawing.Size(165, 22);
            this.menuOpenText.Text = "Текстовый файл";
            this.menuOpenText.Click += new System.EventHandler(this.MenuOpenText_Click);
            // 
            // menuOpenBinary
            // 
            this.menuOpenBinary.Name = "menuOpenBinary";
            this.menuOpenBinary.Size = new System.Drawing.Size(165, 22);
            this.menuOpenBinary.Text = "Бинарный файл";
            this.menuOpenBinary.Click += new System.EventHandler(this.MenuOpenBinary_Click);
            // 
            // menuOpenXml
            // 
            this.menuOpenXml.Name = "menuOpenXml";
            this.menuOpenXml.Size = new System.Drawing.Size(165, 22);
            this.menuOpenXml.Text = "XML файл";
            this.menuOpenXml.Click += new System.EventHandler(this.MenuOpenXml_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(153, 22);
            this.menuSave.Text = "Сохранить";
            this.menuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveAsText,
            this.menuSaveAsBinary,
            this.menuSaveAsXml});
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(153, 22);
            this.menuSaveAs.Text = "Сохранить как";
            // 
            // menuSaveAsText
            // 
            this.menuSaveAsText.Name = "menuSaveAsText";
            this.menuSaveAsText.Size = new System.Drawing.Size(165, 22);
            this.menuSaveAsText.Text = "Текстовый файл";
            this.menuSaveAsText.Click += new System.EventHandler(this.MenuSaveAsText_Click);
            // 
            // menuSaveAsBinary
            // 
            this.menuSaveAsBinary.Name = "menuSaveAsBinary";
            this.menuSaveAsBinary.Size = new System.Drawing.Size(165, 22);
            this.menuSaveAsBinary.Text = "Бинарный файл";
            this.menuSaveAsBinary.Click += new System.EventHandler(this.MenuSaveAsBinary_Click);
            // 
            // menuSaveAsXml
            // 
            this.menuSaveAsXml.Name = "menuSaveAsXml";
            this.menuSaveAsXml.Size = new System.Drawing.Size(165, 22);
            this.menuSaveAsXml.Text = "XML файл";
            this.menuSaveAsXml.Click += new System.EventHandler(this.MenuSaveAsXml_Click);
            // 
            // menuClear
            // 
            this.menuClear.Name = "menuClear";
            this.menuClear.Size = new System.Drawing.Size(153, 22);
            this.menuClear.Text = "Очистить";
            this.menuClear.Click += new System.EventHandler(this.MenuClear_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 395);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(724, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "Количество элементов: ";
            // 
            // stripLabel
            // 
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(140, 17);
            this.stripLabel.Text = "Количество элементов: ";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // заданиеToolStripMenuItem
            // 
            this.заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            this.заданиеToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.заданиеToolStripMenuItem.Text = "Задание";
            this.заданиеToolStripMenuItem.Click += new System.EventHandler(this.BtTask_Click);
            // 
            // сброситьФильтрToolStripMenuItem
            // 
            this.сброситьФильтрToolStripMenuItem.Name = "сброситьФильтрToolStripMenuItem";
            this.сброситьФильтрToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.сброситьФильтрToolStripMenuItem.Text = "Сбросить фильтр";
            this.сброситьФильтрToolStripMenuItem.Click += new System.EventHandler(this.СброситьФильтрToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 417);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btTask);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Фильмы";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btTask;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuCreate;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuOpenText;
        private System.Windows.Forms.ToolStripMenuItem menuOpenBinary;
        private System.Windows.Forms.ToolStripMenuItem menuOpenXml;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAsText;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAsBinary;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAsXml;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stripLabel;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьФильтрToolStripMenuItem;
    }
}

