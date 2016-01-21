namespace WindowsFormsApplication3
{
    partial class calc
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
            this.clear = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.calctxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 203);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(119, 51);
            this.clear.TabIndex = 0;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            this.clear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clear_KeyDown);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(141, 203);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(54, 51);
            this.mul.TabIndex = 1;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            this.mul.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mul_KeyDown);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(201, 370);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(58, 93);
            this.equal.TabIndex = 2;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            this.equal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.equal_KeyDown_1);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(201, 260);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(58, 104);
            this.add.TabIndex = 3;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            this.add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.add_KeyDown_1);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 260);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(54, 49);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            this.seven.KeyDown += new System.Windows.Forms.KeyEventHandler(this.seven_KeyDown);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 425);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(183, 38);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            this.zero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zero_KeyDown_1);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(77, 260);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(54, 49);
            this.eight.TabIndex = 14;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            this.eight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eight_KeyDown);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(141, 260);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(54, 49);
            this.nine.TabIndex = 15;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            this.nine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nine_KeyDown_1);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 315);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(54, 49);
            this.four.TabIndex = 16;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            this.four.KeyDown += new System.Windows.Forms.KeyEventHandler(this.four_KeyDown_1);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(77, 315);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(54, 49);
            this.five.TabIndex = 17;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            this.five.KeyDown += new System.Windows.Forms.KeyEventHandler(this.five_KeyDown_1);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(141, 315);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(54, 49);
            this.six.TabIndex = 18;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            this.six.KeyDown += new System.Windows.Forms.KeyEventHandler(this.six_KeyDown_1);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 370);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(54, 49);
            this.one.TabIndex = 19;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            this.one.KeyDown += new System.Windows.Forms.KeyEventHandler(this.one_KeyDown_1);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(77, 370);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(54, 49);
            this.two.TabIndex = 20;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            this.two.KeyDown += new System.Windows.Forms.KeyEventHandler(this.two_KeyDown_1);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(141, 370);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(54, 49);
            this.three.TabIndex = 21;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            this.three.KeyDown += new System.Windows.Forms.KeyEventHandler(this.three_KeyDown_1);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(201, 203);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(58, 51);
            this.sub.TabIndex = 22;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            this.sub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sub_KeyDown);
            // 
            // calctxt
            // 
            this.calctxt.Location = new System.Drawing.Point(12, 12);
            this.calctxt.Name = "calctxt";
            this.calctxt.Size = new System.Drawing.Size(247, 185);
            this.calctxt.TabIndex = 23;
            this.calctxt.Text = "";
            this.calctxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calctxt_KeyDown);
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 475);
            this.Controls.Add(this.calctxt);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.add);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.clear);
            this.Name = "calc";
            this.Text = "Super Calculator";
            this.Load += new System.EventHandler(this.calc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calc_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.RichTextBox calctxt;
    }
}

