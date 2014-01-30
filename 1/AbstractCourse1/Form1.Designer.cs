namespace AbstractCourse1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmenu = new System.Windows.Forms.Panel();
            this.iceButton6 = new IceButton.IceButton();
            this.iceButton5 = new IceButton.IceButton();
            this.iceButton1 = new IceButton.IceButton();
            this.iceButton4 = new IceButton.IceButton();
            this.iceButton2 = new IceButton.IceButton();
            this.iceButton3 = new IceButton.IceButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.t_search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmenu
            // 
            this.tmenu.Controls.Add(this.iceButton6);
            this.tmenu.Controls.Add(this.iceButton5);
            this.tmenu.Controls.Add(this.iceButton1);
            this.tmenu.Controls.Add(this.iceButton4);
            this.tmenu.Controls.Add(this.iceButton2);
            this.tmenu.Controls.Add(this.iceButton3);
            this.tmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tmenu.Location = new System.Drawing.Point(0, 0);
            this.tmenu.Name = "tmenu";
            this.tmenu.Size = new System.Drawing.Size(676, 118);
            this.tmenu.TabIndex = 4;
            // 
            // iceButton6
            // 
            this.iceButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iceButton6.BackgroundImage")));
            this.iceButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iceButton6.Location = new System.Drawing.Point(228, 3);
            this.iceButton6.Name = "iceButton6";
            this.iceButton6.Size = new System.Drawing.Size(100, 100);
            this.iceButton6.TabIndex = 5;
            this.iceButton6.Tag = "Показать дела на сегодня";
            // 
            // iceButton5
            // 
            this.iceButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iceButton5.BackgroundImage")));
            this.iceButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iceButton5.Location = new System.Drawing.Point(334, 3);
            this.iceButton5.Name = "iceButton5";
            this.iceButton5.Size = new System.Drawing.Size(100, 100);
            this.iceButton5.TabIndex = 4;
            this.iceButton5.Tag = "Удалить запись";
            // 
            // iceButton1
            // 
            this.iceButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iceButton1.BackgroundImage")));
            this.iceButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iceButton1.Location = new System.Drawing.Point(16, 3);
            this.iceButton1.Name = "iceButton1";
            this.iceButton1.Size = new System.Drawing.Size(100, 100);
            this.iceButton1.TabIndex = 0;
            this.iceButton1.Tag = "Просмотр всех записей";
            this.iceButton1.Load += new System.EventHandler(this.iceButton1_Load);
            // 
            // iceButton4
            // 
            this.iceButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iceButton4.BackgroundImage")));
            this.iceButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iceButton4.Location = new System.Drawing.Point(546, 3);
            this.iceButton4.Name = "iceButton4";
            this.iceButton4.Size = new System.Drawing.Size(100, 100);
            this.iceButton4.TabIndex = 3;
            this.iceButton4.Tag = "Выход";
            // 
            // iceButton2
            // 
            this.iceButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iceButton2.BackgroundImage")));
            this.iceButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iceButton2.Location = new System.Drawing.Point(122, 3);
            this.iceButton2.Name = "iceButton2";
            this.iceButton2.Size = new System.Drawing.Size(100, 100);
            this.iceButton2.TabIndex = 1;
            this.iceButton2.Tag = "Добавление записи";
            this.iceButton2.Load += new System.EventHandler(this.iceButton2_Load);
            // 
            // iceButton3
            // 
            this.iceButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iceButton3.BackgroundImage")));
            this.iceButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iceButton3.Location = new System.Drawing.Point(440, 3);
            this.iceButton3.Name = "iceButton3";
            this.iceButton3.Size = new System.Drawing.Size(100, 100);
            this.iceButton3.TabIndex = 2;
            this.iceButton3.Tag = "Стереть всё";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(16, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(648, 460);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Заголовок";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Описание";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Исполнитель";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Выполнено";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 46);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::AbstractCourse1.Properties.Resources.Panel;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(451, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 46);
            this.panel4.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Номер",
            "Заголовок",
            "Описание",
            "Дата",
            "Исполнитель"});
            this.comboBox1.Location = new System.Drawing.Point(29, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::AbstractCourse1.Properties.Resources.Panel;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.t_search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 46);
            this.panel3.TabIndex = 1;
            // 
            // t_search
            // 
            this.t_search.BackColor = System.Drawing.Color.DodgerBlue;
            this.t_search.ForeColor = System.Drawing.Color.White;
            this.t_search.Location = new System.Drawing.Point(30, 14);
            this.t_search.Name = "t_search";
            this.t_search.Size = new System.Drawing.Size(159, 20);
            this.t_search.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AbstractCourse1.Properties.Resources.Panel;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 46);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(676, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel1.Text = "Автор";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 655);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tmenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Планировщик задач";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IceButton.IceButton iceButton1;
        private IceButton.IceButton iceButton2;
        private IceButton.IceButton iceButton3;
        private IceButton.IceButton iceButton4;
        private System.Windows.Forms.Panel tmenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private IceButton.IceButton iceButton6;
        private IceButton.IceButton iceButton5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox t_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

