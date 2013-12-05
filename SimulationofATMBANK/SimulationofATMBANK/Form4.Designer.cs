namespace SimulationofATMBANK
{
    partial class Form4
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
            System.Windows.Forms.Button sec_1;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button7;
            System.Windows.Forms.Button button2;
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            sec_1 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sec_1
            // 
            sec_1.ForeColor = System.Drawing.SystemColors.ControlText;
            sec_1.Location = new System.Drawing.Point(12, 59);
            sec_1.Name = "sec_1";
            sec_1.Size = new System.Drawing.Size(30, 30);
            sec_1.TabIndex = 8;
            sec_1.Text = ">";
            sec_1.UseVisualStyleBackColor = true;
            sec_1.Click += new System.EventHandler(this.sec_1_Click);
            // 
            // button1
            // 
            button1.ForeColor = System.Drawing.SystemColors.ControlText;
            button1.Location = new System.Drawing.Point(389, 59);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(30, 30);
            button1.TabIndex = 9;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kartın Hesabına Para Yatırma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Diğer Hesaplarıma Para Yatırma";
            // 
            // button7
            // 
            button7.ForeColor = System.Drawing.SystemColors.ControlText;
            button7.Location = new System.Drawing.Point(389, 199);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(30, 30);
            button7.TabIndex = 22;
            button7.Text = "<";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(308, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Kart İade";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = System.Drawing.SystemColors.ControlText;
            button2.Location = new System.Drawing.Point(12, 199);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(30, 30);
            button2.TabIndex = 24;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Anasayfa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 262);
            this.Controls.Add(button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(button1);
            this.Controls.Add(sec_1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;

    }
}