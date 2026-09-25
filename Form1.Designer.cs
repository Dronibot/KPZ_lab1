namespace lab1
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
            this.cmbShapeType = new System.Windows.Forms.ComboBox();
            this.numX = new System.Windows.Forms.TextBox();
            this.numY = new System.Windows.Forms.TextBox();
            this.numRadius = new System.Windows.Forms.TextBox();
            this.numWidth = new System.Windows.Forms.TextBox();
            this.numHeight = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbShapeType
            // 
            this.cmbShapeType.FormattingEnabled = true;
            this.cmbShapeType.Items.AddRange(new object[] {
            "Коло",
            "Прямокутник",
            "Трикутник"});
            this.cmbShapeType.Location = new System.Drawing.Point(627, 38);
            this.cmbShapeType.Name = "cmbShapeType";
            this.cmbShapeType.Size = new System.Drawing.Size(121, 21);
            this.cmbShapeType.TabIndex = 0;
            this.cmbShapeType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(12, 38);
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(100, 20);
            this.numX.TabIndex = 1;
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(118, 38);
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(100, 20);
            this.numY.TabIndex = 2;
            // 
            // numRadius
            // 
            this.numRadius.Location = new System.Drawing.Point(224, 38);
            this.numRadius.Name = "numRadius";
            this.numRadius.Size = new System.Drawing.Size(100, 20);
            this.numRadius.TabIndex = 3;
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(330, 38);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(100, 20);
            this.numWidth.TabIndex = 4;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(436, 38);
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(100, 20);
            this.numHeight.TabIndex = 5;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(12, 101);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 6;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(436, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 264);
            this.listBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введіть Х";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введіть У";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Радіус";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(107, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 264);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ширина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Довжина";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.create);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.numRadius);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.cmbShapeType);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbShapeType;
        private System.Windows.Forms.TextBox numX;
        private System.Windows.Forms.TextBox numY;
        private System.Windows.Forms.TextBox numRadius;
        private System.Windows.Forms.TextBox numWidth;
        private System.Windows.Forms.TextBox numHeight;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

