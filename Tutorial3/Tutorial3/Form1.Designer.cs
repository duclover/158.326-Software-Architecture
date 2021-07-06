namespace Tutorial3
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.lstInspections = new System.Windows.Forms.ListBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(263, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 13);
            this.lblHeader.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.LightSalmon;
            this.lblMessage.Location = new System.Drawing.Point(56, 69);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 1;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(59, 145);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(126, 23);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Request Inspection";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lstInspections
            // 
            this.lstInspections.FormattingEnabled = true;
            this.lstInspections.Location = new System.Drawing.Point(323, 69);
            this.lstInspections.Name = "lstInspections";
            this.lstInspections.Size = new System.Drawing.Size(387, 95);
            this.lstInspections.TabIndex = 3;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(56, 197);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(158, 13);
            this.lblDetail.TabIndex = 4;
            this.lblDetail.Text = "Details of Inspection Requested";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(560, 196);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(195, 13);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "Total Number of Inspections Requested";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.LightSalmon;
            this.lblDetails.Location = new System.Drawing.Point(59, 230);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(0, 13);
            this.lblDetails.TabIndex = 6;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.LightSalmon;
            this.lblCount.Location = new System.Drawing.Point(633, 230);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(323, 229);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(198, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Total Price for all Inspections Requested";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.LightSalmon;
            this.lblTotalPrice.Location = new System.Drawing.Point(336, 259);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPrice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lstInspections);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.ListBox lstInspections;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}

