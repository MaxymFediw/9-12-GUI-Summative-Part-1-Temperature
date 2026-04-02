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
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radF = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(136, 12);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(138, 20);
            this.txtFahrenheit.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(82, 309);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(138, 49);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Enter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(79, 56);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(141, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Input A Temperature (F or C)";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(82, 88);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(138, 20);
            this.txtCelsius.TabIndex = 3;
            // 
            // imgBox
            // 
            this.imgBox.Image = global::_9_12_GUI_Summative.Properties.Resources.twentyFiveTo40;
            this.imgBox.Location = new System.Drawing.Point(31, 140);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(243, 147);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 4;
            this.imgBox.TabStop = false;
            this.imgBox.Visible = false;
            this.imgBox.Click += new System.EventHandler(this.imgBox_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(280, 19);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(17, 13);
            this.lblFahrenheit.TabIndex = 5;
            this.lblFahrenheit.Text = "°F";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(226, 91);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(18, 13);
            this.lblCelsius.TabIndex = 6;
            this.lblCelsius.Text = "°C";
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(119, 117);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(36, 17);
            this.radC.TabIndex = 7;
            this.radC.TabStop = true;
            this.radC.Text = "°C";
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radF
            // 
            this.radF.AutoSize = true;
            this.radF.Location = new System.Drawing.Point(161, 117);
            this.radF.Name = "radF";
            this.radF.Size = new System.Drawing.Size(35, 17);
            this.radF.TabIndex = 8;
            this.radF.TabStop = true;
            this.radF.Text = "°F";
            this.radF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 368);
            this.Controls.Add(this.radF);
            this.Controls.Add(this.radC);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFahrenheit);
            this.Name = "Form1";
            this.Text = "Temperature Genie";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radF;
    }
}

