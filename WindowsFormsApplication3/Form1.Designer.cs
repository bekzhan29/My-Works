namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.btn_start = new System.Windows.Forms.Button();
            this.rows = new System.Windows.Forms.NumericUpDown();
            this.columns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columns)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(97, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // rows
            // 
            this.rows.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rows.Location = new System.Drawing.Point(182, 15);
            this.rows.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(55, 20);
            this.rows.TabIndex = 1;
            this.rows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rows.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rows_KeyDown);
            // 
            // columns
            // 
            this.columns.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columns.Location = new System.Drawing.Point(308, 15);
            this.columns.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.columns.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(55, 20);
            this.columns.TabIndex = 2;
            this.columns.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columns.ValueChanged += new System.EventHandler(this.columns_ValueChanged);
            this.columns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.columns_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Columns:";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 46);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(407, 407);
            this.panel.TabIndex = 5;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 465);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.btn_start);
            this.MinimumSize = new System.Drawing.Size(451, 504);
            this.Name = "Form1";
            this.Text = "Black and White";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.NumericUpDown rows;
        private System.Windows.Forms.NumericUpDown columns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel;
    }
}

