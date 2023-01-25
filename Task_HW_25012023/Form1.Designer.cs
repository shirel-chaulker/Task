namespace Task_HW_25012023
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
            this.ex01 = new System.Windows.Forms.Button();
            this.ex02 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ex05 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ex06 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ex01
            // 
            this.ex01.Location = new System.Drawing.Point(67, 56);
            this.ex01.Name = "ex01";
            this.ex01.Size = new System.Drawing.Size(178, 66);
            this.ex01.TabIndex = 0;
            this.ex01.Text = "שאלה 1 ";
            this.ex01.UseVisualStyleBackColor = true;
            this.ex01.Click += new System.EventHandler(this.ex01_Click);
            // 
            // ex02
            // 
            this.ex02.Location = new System.Drawing.Point(392, 56);
            this.ex02.Name = "ex02";
            this.ex02.Size = new System.Drawing.Size(154, 66);
            this.ex02.TabIndex = 1;
            this.ex02.Text = "שאלה 2";
            this.ex02.UseVisualStyleBackColor = true;
            this.ex02.Click += new System.EventHandler(this.ex02_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ex05
            // 
            this.ex05.Location = new System.Drawing.Point(91, 262);
            this.ex05.Name = "ex05";
            this.ex05.Size = new System.Drawing.Size(164, 60);
            this.ex05.TabIndex = 3;
            this.ex05.Text = "שאלה 5";
            this.ex05.UseVisualStyleBackColor = true;
            this.ex05.Click += new System.EventHandler(this.ex05_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // ex06
            // 
            this.ex06.Location = new System.Drawing.Point(544, 205);
            this.ex06.Name = "ex06";
            this.ex06.Size = new System.Drawing.Size(154, 65);
            this.ex06.TabIndex = 5;
            this.ex06.Text = "שאלה 6";
            this.ex06.UseVisualStyleBackColor = true;
            this.ex06.Click += new System.EventHandler(this.ex06_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(548, 294);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(150, 144);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ex06);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ex05);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ex02);
            this.Controls.Add(this.ex01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ex01;
        private Button ex02;
        private Label label1;
        private Button ex05;
        private Label label2;
        private Button ex06;
        private RichTextBox richTextBox1;
    }
}