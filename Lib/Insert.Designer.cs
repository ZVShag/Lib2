﻿namespace Lib
{
    partial class Insert
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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(173, 199);
            button1.Name = "button1";
            button1.Size = new Size(222, 81);
            button1.TabIndex = 9;
            button1.Text = "ДОБАВИТЬ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(155, 99);
            label2.Name = "label2";
            label2.Size = new Size(240, 35);
            label2.TabIndex = 8;
            label2.Text = "ФАМИЛИЯ АВТОРА";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 35);
            label1.TabIndex = 7;
            label1.Text = "ИМЯ АВТОРА";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(416, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 27);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(65, 301);
            button2.Name = "button2";
            button2.Size = new Size(416, 81);
            button2.TabIndex = 10;
            button2.Text = "ВЕРНУТСЯ НА ФОРМУ ВЫБОРА";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Insert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Insert";
            Text = "Insert";
            Load += Insert_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
    }
}