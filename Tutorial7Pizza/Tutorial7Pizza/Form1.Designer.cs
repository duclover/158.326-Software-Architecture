namespace Tutorial7Pizza
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHead = new System.Windows.Forms.Label();
            this.lblSubHead = new System.Windows.Forms.Label();
            this.lstPizza = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnHomeOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHead.Location = new System.Drawing.Point(56, 34);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(204, 31);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "PIZZA STORE";
            // 
            // lblSubHead
            // 
            this.lblSubHead.AutoSize = true;
            this.lblSubHead.Location = new System.Drawing.Point(48, 102);
            this.lblSubHead.Name = "lblSubHead";
            this.lblSubHead.Size = new System.Drawing.Size(156, 13);
            this.lblSubHead.TabIndex = 1;
            this.lblSubHead.Text = "What type of pizza do you want";
            // 
            // lstPizza
            // 
            this.lstPizza.FormattingEnabled = true;
            this.lstPizza.Location = new System.Drawing.Point(417, 64);
            this.lstPizza.Name = "lstPizza";
            this.lstPizza.Size = new System.Drawing.Size(120, 95);
            this.lstPizza.TabIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(92, 211);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order Here";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOrders.Location = new System.Drawing.Point(379, 195);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(36, 13);
            this.lblOrders.TabIndex = 4;
            this.lblOrders.Text = "orders";
            // 
            // btnHomeOrder
            // 
            this.btnHomeOrder.Location = new System.Drawing.Point(440, 323);
            this.btnHomeOrder.Name = "btnHomeOrder";
            this.btnHomeOrder.Size = new System.Drawing.Size(246, 23);
            this.btnHomeOrder.TabIndex = 5;
            this.btnHomeOrder.Text = "For Home Delivery Click Here";
            this.btnHomeOrder.UseVisualStyleBackColor = true;
            this.btnHomeOrder.Click += new System.EventHandler(this.btnHomeOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHomeOrder);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lstPizza);
            this.Controls.Add(this.lblSubHead);
            this.Controls.Add(this.lblHead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblSubHead;
        private System.Windows.Forms.ListBox lstPizza;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Button btnHomeOrder;
    }
}

