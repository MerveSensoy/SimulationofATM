namespace SimulationofATMBANK
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            button15 = new System.Windows.Forms.Button();
            button16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yatırdığınız Para Hesaba Yatmıştır.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Makbuz İstemiyorum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Makbuz İstiyorum";
            // 
            // button15
            // 
            button15.ForeColor = System.Drawing.SystemColors.ControlText;
            button15.Location = new System.Drawing.Point(52, 234);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(30, 30);
            button15.TabIndex = 43;
            button15.Text = ">";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.ForeColor = System.Drawing.SystemColors.ControlText;
            button16.Location = new System.Drawing.Point(466, 234);
            button16.Name = "button16";
            button16.Size = new System.Drawing.Size(30, 30);
            button16.TabIndex = 42;
            button16.Text = "<";
            button16.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(button15);
            this.Controls.Add(button16);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Yatırdığınız Para Hesaba Yatmıştır.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}