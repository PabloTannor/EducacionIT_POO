﻿namespace Banco
{
    partial class Clientes
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
            btnAlta = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(196, 209);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(77, 23);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Alta Cliente";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(198, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnAlta);
            Name = "Clientes";
            Text = "Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlta;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}