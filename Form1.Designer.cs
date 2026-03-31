namespace _9_12_GUI_Summative
{
    partial class Form1
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
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(329, 130);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(138, 20);
            this.txtTemperature.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(329, 165);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(138, 49);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Enter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(326, 63);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(141, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Input A Temperature (F or C)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTemperature);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox textBox1;
    }
}

