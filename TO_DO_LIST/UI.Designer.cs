namespace TO_DO_LIST
{
    partial class UI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            banner = new Panel();
            lblAdd = new Label();
            lblTitle = new Label();
            lblExit = new Label();
            paneActivities = new Panel();
            banner.SuspendLayout();
            SuspendLayout();
            // 
            // banner
            // 
            banner.BackColor = Color.FromArgb(27, 27, 27);
            banner.Controls.Add(lblAdd);
            banner.Controls.Add(lblTitle);
            banner.Controls.Add(lblExit);
            banner.Location = new Point(0, -2);
            banner.Name = "banner";
            banner.Size = new Size(364, 103);
            banner.TabIndex = 0;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Font = new Font("Calisto MT", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdd.ForeColor = Color.White;
            lblAdd.Location = new Point(298, 40);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(54, 53);
            lblAdd.TabIndex = 2;
            lblAdd.Text = "+";
            lblAdd.Click += lblAdd_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 50);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "TODO";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExit.ForeColor = Color.FromArgb(234, 4, 79);
            lblExit.Location = new Point(327, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(31, 21);
            lblExit.TabIndex = 0;
            lblExit.Text = "✖";
            lblExit.Click += lblExit_Click;
            // 
            // paneActivities
            // 
            paneActivities.AutoScroll = true;
            paneActivities.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            paneActivities.BackColor = Color.FromArgb(48, 48, 48);
            paneActivities.Location = new Point(0, 101);
            paneActivities.Name = "paneActivities";
            paneActivities.Size = new Size(390, 699);
            paneActivities.TabIndex = 1;
            paneActivities.Scroll += paneActivities_Scroll;
            // 
            // UI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 800);
            Controls.Add(paneActivities);
            Controls.Add(banner);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UI";
            FormClosed += UI_FormClosed;
            Load += UI_Load;
            banner.ResumeLayout(false);
            banner.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel banner;
        private Label lblExit;
        private Label lblTitle;
        private Label lblAdd;
        private Panel paneActivities;
    }
}
