namespace Tutorial5
{
    partial class WeatherData
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
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHead.Location = new System.Drawing.Point(44, 27);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(285, 31);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "WeatherData Station";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTemp.Location = new System.Drawing.Point(33, 99);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(48, 17);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Temp";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHumidity.Location = new System.Drawing.Point(36, 149);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(70, 17);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "Humidity";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPressure.Location = new System.Drawing.Point(39, 209);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(73, 17);
            this.lblPressure.TabIndex = 3;
            this.lblPressure.Text = "Pressure";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(209, 99);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 4;
            this.txtTemp.Leave += new System.EventHandler(this.txtTemp_Leave);
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(209, 146);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(100, 20);
            this.txtHumidity.TabIndex = 5;
            this.txtHumidity.Leave += new System.EventHandler(this.txtHumidity_Leave);
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(209, 206);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(100, 20);
            this.txtPressure.TabIndex = 6;
            this.txtPressure.Leave += new System.EventHandler(this.txtPressure_Leave);
            // 
            // WeatherData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblHead);
            this.Name = "WeatherData";
            this.Text = "WeatherData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtPressure;
    }
}