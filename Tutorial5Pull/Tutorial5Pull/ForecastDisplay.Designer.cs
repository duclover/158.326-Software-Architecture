namespace Tutorial5
{
    partial class ForecastDisplay
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
            this.lblHead = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDeRegister = new System.Windows.Forms.Button();
            this.lblConditon = new System.Windows.Forms.Label();
            this.txtConditon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHead.Location = new System.Drawing.Point(98, 37);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(129, 31);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Forecast";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(71, 251);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(178, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register As Observer";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDeRegister
            // 
            this.btnDeRegister.Location = new System.Drawing.Point(71, 298);
            this.btnDeRegister.Name = "btnDeRegister";
            this.btnDeRegister.Size = new System.Drawing.Size(178, 23);
            this.btnDeRegister.TabIndex = 6;
            this.btnDeRegister.Text = "De-Register As Observer";
            this.btnDeRegister.UseVisualStyleBackColor = true;
            this.btnDeRegister.Click += new System.EventHandler(this.btnDeRegister_Click);
            // 
            // lblConditon
            // 
            this.lblConditon.AutoSize = true;
            this.lblConditon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblConditon.Location = new System.Drawing.Point(26, 114);
            this.lblConditon.Name = "lblConditon";
            this.lblConditon.Size = new System.Drawing.Size(158, 17);
            this.lblConditon.TabIndex = 7;
            this.lblConditon.Text = "Expected conditions:";
            // 
            // txtConditon
            // 
            this.txtConditon.Location = new System.Drawing.Point(209, 111);
            this.txtConditon.Name = "txtConditon";
            this.txtConditon.ReadOnly = true;
            this.txtConditon.Size = new System.Drawing.Size(100, 20);
            this.txtConditon.TabIndex = 8;
            // 
            // ForecastDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.txtConditon);
            this.Controls.Add(this.lblConditon);
            this.Controls.Add(this.btnDeRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblHead);
            this.Name = "ForecastDisplay";
            this.Text = "ForecastDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDeRegister;
        private System.Windows.Forms.Label lblConditon;
        private System.Windows.Forms.TextBox txtConditon;
    }
}