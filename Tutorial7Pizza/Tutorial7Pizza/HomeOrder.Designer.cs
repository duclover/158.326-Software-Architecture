namespace Tutorial7Pizza
{
    partial class HomeOrder
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
            this.lblSubHead = new System.Windows.Forms.Label();
            this.lstPizza = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHead.Location = new System.Drawing.Point(64, 42);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(205, 31);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Home Delivery";
            // 
            // lblSubHead
            // 
            this.lblSubHead.AutoSize = true;
            this.lblSubHead.Location = new System.Drawing.Point(36, 117);
            this.lblSubHead.Name = "lblSubHead";
            this.lblSubHead.Size = new System.Drawing.Size(156, 13);
            this.lblSubHead.TabIndex = 2;
            this.lblSubHead.Text = "What type of pizza do you want";
            // 
            // lstPizza
            // 
            this.lstPizza.FormattingEnabled = true;
            this.lstPizza.Location = new System.Drawing.Point(431, 92);
            this.lstPizza.Name = "lstPizza";
            this.lstPizza.Size = new System.Drawing.Size(120, 95);
            this.lstPizza.TabIndex = 3;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(53, 237);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order Here";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOrders.Location = new System.Drawing.Point(358, 237);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(36, 13);
            this.lblOrders.TabIndex = 5;
            this.lblOrders.Text = "orders";
            // 
            // HomeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lstPizza);
            this.Controls.Add(this.lblSubHead);
            this.Controls.Add(this.lblHead);
            this.Name = "HomeOrder";
            this.Text = "HomeOrder";
            this.Load += new System.EventHandler(this.HomeOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblSubHead;
        private System.Windows.Forms.ListBox lstPizza;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblOrders;
    }
}