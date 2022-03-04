namespace CPU_Memory_Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.progressBarMem = new System.Windows.Forms.ProgressBar();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCpuUsage = new System.Windows.Forms.Label();
            this.labelMemUsage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonStart.Location = new System.Drawing.Point(18, 231);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(122, 38);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start Process";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // progressBarMem
            // 
            this.progressBarMem.Location = new System.Drawing.Point(18, 161);
            this.progressBarMem.Name = "progressBarMem";
            this.progressBarMem.Size = new System.Drawing.Size(770, 25);
            this.progressBarMem.TabIndex = 8;
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(18, 63);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(770, 26);
            this.progressBarCPU.Step = 1;
            this.progressBarCPU.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(17, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Memory Usage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPU Usage:";
            // 
            // labelCpuUsage
            // 
            this.labelCpuUsage.AutoSize = true;
            this.labelCpuUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelCpuUsage.Location = new System.Drawing.Point(741, 35);
            this.labelCpuUsage.Name = "labelCpuUsage";
            this.labelCpuUsage.Size = new System.Drawing.Size(28, 17);
            this.labelCpuUsage.TabIndex = 10;
            this.labelCpuUsage.Text = "0%";
            // 
            // labelMemUsage
            // 
            this.labelMemUsage.AutoSize = true;
            this.labelMemUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.labelMemUsage.Location = new System.Drawing.Point(741, 137);
            this.labelMemUsage.Name = "labelMemUsage";
            this.labelMemUsage.Size = new System.Drawing.Size(28, 17);
            this.labelMemUsage.TabIndex = 11;
            this.labelMemUsage.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(18, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Developed By : Hiran Roy |  Co-Partner: Sameer Pathak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMemUsage);
            this.Controls.Add(this.labelCpuUsage);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBarMem);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU & Memory Usage Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar progressBarMem;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCpuUsage;
        private System.Windows.Forms.Label labelMemUsage;
        private System.Windows.Forms.Label label3;
    }
}

