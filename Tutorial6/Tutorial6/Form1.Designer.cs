namespace Tutorial6
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
            this.gpxDuck = new System.Windows.Forms.GroupBox();
            this.rdoDecoyDuck = new System.Windows.Forms.RadioButton();
            this.rdoRubberDuck = new System.Windows.Forms.RadioButton();
            this.rdoRedHead = new System.Windows.Forms.RadioButton();
            this.rdoMallard = new System.Windows.Forms.RadioButton();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnFly = new System.Windows.Forms.Button();
            this.btnQuack = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.gpxDuck.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHead.Location = new System.Drawing.Point(270, 35);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(212, 31);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Duck Simulator";
            // 
            // gpxDuck
            // 
            this.gpxDuck.Controls.Add(this.rdoDecoyDuck);
            this.gpxDuck.Controls.Add(this.rdoRubberDuck);
            this.gpxDuck.Controls.Add(this.rdoRedHead);
            this.gpxDuck.Controls.Add(this.rdoMallard);
            this.gpxDuck.Location = new System.Drawing.Point(55, 86);
            this.gpxDuck.Name = "gpxDuck";
            this.gpxDuck.Size = new System.Drawing.Size(200, 190);
            this.gpxDuck.TabIndex = 1;
            this.gpxDuck.TabStop = false;
            this.gpxDuck.Text = "Duck Type";
            // 
            // rdoDecoyDuck
            // 
            this.rdoDecoyDuck.AutoSize = true;
            this.rdoDecoyDuck.Location = new System.Drawing.Point(30, 116);
            this.rdoDecoyDuck.Name = "rdoDecoyDuck";
            this.rdoDecoyDuck.Size = new System.Drawing.Size(82, 17);
            this.rdoDecoyDuck.TabIndex = 3;
            this.rdoDecoyDuck.TabStop = true;
            this.rdoDecoyDuck.Text = "DecoyDuck";
            this.rdoDecoyDuck.UseVisualStyleBackColor = true;
            // 
            // rdoRubberDuck
            // 
            this.rdoRubberDuck.AutoSize = true;
            this.rdoRubberDuck.Location = new System.Drawing.Point(30, 157);
            this.rdoRubberDuck.Name = "rdoRubberDuck";
            this.rdoRubberDuck.Size = new System.Drawing.Size(86, 17);
            this.rdoRubberDuck.TabIndex = 2;
            this.rdoRubberDuck.TabStop = true;
            this.rdoRubberDuck.Text = "RubberDuck";
            this.rdoRubberDuck.UseVisualStyleBackColor = true;
            // 
            // rdoRedHead
            // 
            this.rdoRedHead.AutoSize = true;
            this.rdoRedHead.Location = new System.Drawing.Point(30, 77);
            this.rdoRedHead.Name = "rdoRedHead";
            this.rdoRedHead.Size = new System.Drawing.Size(74, 17);
            this.rdoRedHead.TabIndex = 1;
            this.rdoRedHead.TabStop = true;
            this.rdoRedHead.Text = "Red Head";
            this.rdoRedHead.UseVisualStyleBackColor = true;
            // 
            // rdoMallard
            // 
            this.rdoMallard.AutoSize = true;
            this.rdoMallard.Location = new System.Drawing.Point(30, 41);
            this.rdoMallard.Name = "rdoMallard";
            this.rdoMallard.Size = new System.Drawing.Size(59, 17);
            this.rdoMallard.TabIndex = 0;
            this.rdoMallard.TabStop = true;
            this.rdoMallard.Text = "Mallard";
            this.rdoMallard.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(454, 98);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnFly
            // 
            this.btnFly.Location = new System.Drawing.Point(454, 144);
            this.btnFly.Name = "btnFly";
            this.btnFly.Size = new System.Drawing.Size(75, 23);
            this.btnFly.TabIndex = 3;
            this.btnFly.Text = "Fly";
            this.btnFly.UseVisualStyleBackColor = true;
            this.btnFly.Click += new System.EventHandler(this.btnFly_Click);
            // 
            // btnQuack
            // 
            this.btnQuack.Location = new System.Drawing.Point(454, 202);
            this.btnQuack.Name = "btnQuack";
            this.btnQuack.Size = new System.Drawing.Size(75, 23);
            this.btnQuack.TabIndex = 4;
            this.btnQuack.Text = "Quack";
            this.btnQuack.UseVisualStyleBackColor = true;
            this.btnQuack.Click += new System.EventHandler(this.btnQuack_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(312, 263);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnQuack);
            this.Controls.Add(this.btnFly);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.gpxDuck);
            this.Controls.Add(this.lblHead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpxDuck.ResumeLayout(false);
            this.gpxDuck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.GroupBox gpxDuck;
        private System.Windows.Forms.RadioButton rdoDecoyDuck;
        private System.Windows.Forms.RadioButton rdoRubberDuck;
        private System.Windows.Forms.RadioButton rdoRedHead;
        private System.Windows.Forms.RadioButton rdoMallard;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnFly;
        private System.Windows.Forms.Button btnQuack;
        private System.Windows.Forms.Label lblDisplay;
    }
}

