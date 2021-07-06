namespace Tutorial5
{
    partial class WeatherStatistics
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
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDeRegister = new System.Windows.Forms.Button();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHead.Location = new System.Drawing.Point(35, 29);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(252, 31);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Weather Statistics";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAverage.Location = new System.Drawing.Point(35, 92);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(113, 17);
            this.lblAverage.TabIndex = 1;
            this.lblAverage.Text = "Average Temp";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMax.Location = new System.Drawing.Point(35, 153);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(81, 17);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Max Temp";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMin.Location = new System.Drawing.Point(38, 211);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(78, 17);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "Min Temp";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(84, 261);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(178, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register As Observer";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDeRegister
            // 
            this.btnDeRegister.Location = new System.Drawing.Point(84, 310);
            this.btnDeRegister.Name = "btnDeRegister";
            this.btnDeRegister.Size = new System.Drawing.Size(178, 23);
            this.btnDeRegister.TabIndex = 7;
            this.btnDeRegister.Text = "De-Register As Observer";
            this.btnDeRegister.UseVisualStyleBackColor = true;
            this.btnDeRegister.Click += new System.EventHandler(this.btnDeRegister_Click);
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(220, 92);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(100, 20);
            this.txtAverage.TabIndex = 8;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(220, 153);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 9;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(220, 211);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 10;
            // 
            // WeatherStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.btnDeRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblHead);
            this.Name = "WeatherStatistics";
            this.Text = "WeatherStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDeRegister;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
    }
}