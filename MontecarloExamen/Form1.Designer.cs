namespace MontecarloExamen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            textBox8 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(459, 46);
            label1.Name = "label1";
            label1.Size = new Size(454, 41);
            label1.TabIndex = 0;
            label1.Text = "f(x) = a1*sen(b1*x)+a2*cos(b2*x)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 176);
            label2.Name = "label2";
            label2.Size = new Size(49, 41);
            label2.TabIndex = 1;
            label2.Text = "a1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 231);
            label3.Name = "label3";
            label3.Size = new Size(49, 41);
            label3.TabIndex = 2;
            label3.Text = "a2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 288);
            label4.Name = "label4";
            label4.Size = new Size(52, 41);
            label4.TabIndex = 3;
            label4.Text = "b1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 349);
            label5.Name = "label5";
            label5.Size = new Size(52, 41);
            label5.TabIndex = 4;
            label5.Text = "b2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 47);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(191, 349);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 47);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(543, 179);
            label6.Name = "label6";
            label6.Size = new Size(309, 41);
            label6.TabIndex = 9;
            label6.Text = "Tamaño de la muestra";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(858, 179);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 47);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(543, 237);
            label7.Name = "label7";
            label7.Size = new Size(200, 41);
            label7.TabIndex = 11;
            label7.Text = "Límite inferior";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(858, 234);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 47);
            textBox6.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(543, 294);
            label8.Name = "label8";
            label8.Size = new Size(215, 41);
            label8.TabIndex = 13;
            label8.Text = "Límite superior";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(858, 294);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(250, 47);
            textBox7.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(503, 365);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 49;
            dataGridView1.Size = new Size(936, 506);
            dataGridView1.TabIndex = 15;

            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(107, 536);
            label9.Name = "label9";
            label9.Size = new Size(340, 41);
            label9.TabIndex = 16;
            label9.Text = "Estimación de la integral";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(112, 600);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(250, 47);
            textBox8.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(1204, 237);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 18;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 924);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private DataGridView dataGridView1;
        private Label label9;
        private TextBox textBox8;
        private Button button1;
    }
}