﻿namespace SimulationofATMBANK
{
    partial class Form6
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
            System.Windows.Forms.Button button15;
            System.Windows.Forms.Button button16;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            button15 = new System.Windows.Forms.Button();
            button16 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Kart İade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Anasayfa";
            // 
            // button15
            // 
            button15.ForeColor = System.Drawing.SystemColors.ControlText;
            button15.Location = new System.Drawing.Point(55, 252);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(30, 30);
            button15.TabIndex = 39;
            button15.Text = ">";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.ForeColor = System.Drawing.SystemColors.ControlText;
            button16.Location = new System.Drawing.Point(432, 252);
            button16.Name = "button16";
            button16.Size = new System.Drawing.Size(30, 30);
            button16.TabIndex = 38;
            button16.Text = "<";
            button16.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(55, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 42;
            this.radioButton1.Text = "Diğer Hesap";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(55, 123);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 43;
            this.radioButton2.Text = "Diğer Hesap";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = System.Drawing.SystemColors.ControlText;
            button1.Location = new System.Drawing.Point(12, 116);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(30, 30);
            button1.TabIndex = 44;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = System.Drawing.SystemColors.ControlText;
            button2.Location = new System.Drawing.Point(12, 57);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(30, 30);
            button2.TabIndex = 45;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 329);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(button15);
            this.Controls.Add(button16);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}