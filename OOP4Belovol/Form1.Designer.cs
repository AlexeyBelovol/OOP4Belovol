namespace OOP4Belovol
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            labelTopLeft = new Label();
            labelBottomRight = new Label();
            dataGridViewArray = new DataGridView();
            btnDisplayArray = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            labelResultArray1 = new Label();
            btnCalculateArray1 = new Button();
            label8 = new Label();
            textBoxArray1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 454);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxArray1);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btnCalculateArray1);
            tabPage1.Controls.Add(labelResultArray1);
            tabPage1.Controls.Add(label7);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 426);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Завдання №1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(labelTopLeft);
            tabPage2.Controls.Add(labelBottomRight);
            tabPage2.Controls.Add(dataGridViewArray);
            tabPage2.Controls.Add(btnDisplayArray);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 426);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Завдання №2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 380);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 13;
            label6.Text = "Результат - ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(603, 310);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 12;
            label5.Text = "4 рядок - ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(603, 281);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 11;
            label4.Text = "3 рядок - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(603, 252);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 10;
            label3.Text = "2 рядок - ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(603, 223);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 9;
            label2.Text = "1 рядок - ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 259);
            label1.Name = "label1";
            label1.Size = new Size(388, 15);
            label1.TabIndex = 8;
            label1.Text = "Введіть по 4 числа в кожен рядок двовимірного масиву через пробіл";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(668, 307);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(668, 278);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(668, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // labelTopLeft
            // 
            labelTopLeft.AutoSize = true;
            labelTopLeft.Location = new Point(192, 394);
            labelTopLeft.Name = "labelTopLeft";
            labelTopLeft.Size = new Size(0, 15);
            labelTopLeft.TabIndex = 4;
            // 
            // labelBottomRight
            // 
            labelBottomRight.AutoSize = true;
            labelBottomRight.Location = new Point(192, 365);
            labelBottomRight.Name = "labelBottomRight";
            labelBottomRight.Size = new Size(0, 15);
            labelBottomRight.TabIndex = 3;
            // 
            // dataGridViewArray
            // 
            dataGridViewArray.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArray.Location = new Point(192, 18);
            dataGridViewArray.Name = "dataGridViewArray";
            dataGridViewArray.Size = new Size(417, 162);
            dataGridViewArray.TabIndex = 2;
            // 
            // btnDisplayArray
            // 
            btnDisplayArray.Location = new Point(57, 220);
            btnDisplayArray.Name = "btnDisplayArray";
            btnDisplayArray.Size = new Size(101, 93);
            btnDisplayArray.TabIndex = 1;
            btnDisplayArray.Text = "Провести дії";
            btnDisplayArray.UseVisualStyleBackColor = true;
            btnDisplayArray.Click += btnDisplayArray_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(668, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 244);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 0;
            label7.Text = "Результат - ";
            // 
            // labelResultArray1
            // 
            labelResultArray1.AutoSize = true;
            labelResultArray1.Location = new Point(257, 244);
            labelResultArray1.Name = "labelResultArray1";
            labelResultArray1.Size = new Size(0, 15);
            labelResultArray1.TabIndex = 1;
            // 
            // btnCalculateArray1
            // 
            btnCalculateArray1.Location = new Point(269, 109);
            btnCalculateArray1.Name = "btnCalculateArray1";
            btnCalculateArray1.Size = new Size(296, 94);
            btnCalculateArray1.TabIndex = 2;
            btnCalculateArray1.Text = "Провести дії";
            btnCalculateArray1.UseVisualStyleBackColor = true;
            btnCalculateArray1.Click += btnCalculateArray1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(170, 60);
            label8.Name = "label8";
            label8.Size = new Size(316, 15);
            label8.TabIndex = 3;
            label8.Text = "Введіть елементи одновимірного масиву через пробіл -";
            // 
            // textBoxArray1
            // 
            textBoxArray1.Location = new Point(529, 57);
            textBoxArray1.Name = "textBoxArray1";
            textBoxArray1.Size = new Size(100, 23);
            textBoxArray1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Лабораторна робота №4";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArray).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label labelTopLeft;
        private Label labelBottomRight;
        private DataGridView dataGridViewArray;
        private Button btnDisplayArray;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxArray1;
        private Label label8;
        private Button btnCalculateArray1;
        private Label labelResultArray1;
        private Label label7;
    }
}
