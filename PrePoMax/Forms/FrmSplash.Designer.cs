namespace PrePoMax.Forms
{
    partial class FrmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.labProgramName = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labHomePage = new System.Windows.Forms.LinkLabel();
            this.labClose = new System.Windows.Forms.LinkLabel();
            this.labHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labProgramName
            // 
            this.labProgramName.BackColor = System.Drawing.Color.Transparent;
            this.labProgramName.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labProgramName.ForeColor = System.Drawing.Color.Black;
            this.labProgramName.Location = new System.Drawing.Point(55, 2);
            this.labProgramName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labProgramName.Name = "labProgramName";
            this.labProgramName.Size = new System.Drawing.Size(729, 54);
            this.labProgramName.TabIndex = 0;
            this.labProgramName.Text = "TA-FLOW v0.0.0.0";
            this.labProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 326);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.MarqueeAnimationSpeed = 20;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(800, 18);
            this.progressBar.Step = 5;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 39);
            this.panel1.TabIndex = 2;
            // 
            // labHomePage
            // 
            this.labHomePage.AutoSize = true;
            this.labHomePage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHomePage.Location = new System.Drawing.Point(4, 298);
            this.labHomePage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labHomePage.Name = "labHomePage";
            this.labHomePage.Size = new System.Drawing.Size(109, 25);
            this.labHomePage.TabIndex = 4;
            this.labHomePage.TabStop = true;
            this.labHomePage.Text = "Home page";
            this.labHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labHomePage_LinkClicked);
            // 
            // labClose
            // 
            this.labClose.AutoSize = true;
            this.labClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labClose.Location = new System.Drawing.Point(740, 298);
            this.labClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labClose.Name = "labClose";
            this.labClose.Size = new System.Drawing.Size(58, 25);
            this.labClose.TabIndex = 5;
            this.labClose.TabStop = true;
            this.labClose.Text = "Close";
            this.labClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labClose_LinkClicked);
            // 
            // labHelp
            // 
            this.labHelp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHelp.Location = new System.Drawing.Point(4, 224);
            this.labHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labHelp.Name = "labHelp";
            this.labHelp.Size = new System.Drawing.Size(247, 74);
            this.labHelp.TabIndex = 6;
            this.labHelp.Text = "TA-FLOW is a CFD solver made by Turkish Aerospace";
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.labClose;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labHelp);
            this.Controls.Add(this.labClose);
            this.Controls.Add(this.labHomePage);
            this.Controls.Add(this.labProgramName);
            this.Controls.Add(this.progressBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 345);
            this.MinimumSize = new System.Drawing.Size(800, 345);
            this.Name = "FrmSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labProgramName;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel labHomePage;
        private System.Windows.Forms.LinkLabel labClose;
        private System.Windows.Forms.Label labHelp;
    }
}