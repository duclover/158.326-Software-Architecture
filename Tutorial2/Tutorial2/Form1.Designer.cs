namespace Tutorial2
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoStaff = new System.Windows.Forms.RadioButton();
            this.rdoGeneral = new System.Windows.Forms.RadioButton();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.Location = new System.Drawing.Point(54, 25);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 0;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.rdoStudent);
            this.grpBox.Controls.Add(this.rdoStaff);
            this.grpBox.Controls.Add(this.rdoGeneral);
            this.grpBox.Location = new System.Drawing.Point(452, 116);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(200, 135);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Parking Type";
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Location = new System.Drawing.Point(21, 97);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(62, 17);
            this.rdoStudent.TabIndex = 2;
            this.rdoStudent.TabStop = true;
            this.rdoStudent.Text = "Student";
            this.rdoStudent.UseVisualStyleBackColor = true;
            // 
            // rdoStaff
            // 
            this.rdoStaff.AutoSize = true;
            this.rdoStaff.Location = new System.Drawing.Point(21, 64);
            this.rdoStaff.Name = "rdoStaff";
            this.rdoStaff.Size = new System.Drawing.Size(47, 17);
            this.rdoStaff.TabIndex = 1;
            this.rdoStaff.TabStop = true;
            this.rdoStaff.Text = "Staff";
            this.rdoStaff.UseVisualStyleBackColor = true;
            // 
            // rdoGeneral
            // 
            this.rdoGeneral.AutoSize = true;
            this.rdoGeneral.Location = new System.Drawing.Point(21, 31);
            this.rdoGeneral.Name = "rdoGeneral";
            this.rdoGeneral.Size = new System.Drawing.Size(94, 17);
            this.rdoGeneral.TabIndex = 0;
            this.rdoGeneral.TabStop = true;
            this.rdoGeneral.Text = "General Public";
            this.rdoGeneral.UseVisualStyleBackColor = true;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(116, 180);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(104, 13);
            this.lblChoose.TabIndex = 2;
            this.lblChoose.Text = "Choose parking type";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(57, 272);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(147, 13);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Enter number of hours parked";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(326, 264);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(249, 320);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Charge";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(270, 378);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoStaff;
        private System.Windows.Forms.RadioButton rdoGeneral;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtAmount;
    }
}

