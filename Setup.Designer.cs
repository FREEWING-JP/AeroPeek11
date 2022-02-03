namespace AeroPeek11
{
    partial class Setup
    {
        private System.ComponentModel.IContainer Components = null;

        protected override void Dispose(bool Disposing)
        {
            if(Disposing && (Components != null))
            {
                Components.Dispose();
            }

            base.Dispose(Disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.TipManager = new System.Windows.Forms.ToolTip(this.components);
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.ClientTitle = new System.Windows.Forms.Label();
            this.InstructionBox = new System.Windows.Forms.GroupBox();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.HowToText = new System.Windows.Forms.Label();
            this.PositionButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.TitleBarPanel.SuspendLayout();
            this.InstructionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TipManager
            // 
            this.TipManager.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TipManager.ToolTipTitle = "Need Help?";
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TitleBarPanel.Controls.Add(this.ClientTitle);
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(325, 41);
            this.TitleBarPanel.TabIndex = 0;
            // 
            // ClientTitle
            // 
            this.ClientTitle.AutoSize = true;
            this.ClientTitle.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientTitle.Location = new System.Drawing.Point(85, 8);
            this.ClientTitle.Name = "ClientTitle";
            this.ClientTitle.Size = new System.Drawing.Size(163, 25);
            this.ClientTitle.TabIndex = 1;
            this.ClientTitle.Text = "AeroPeek11 Setup";
            // 
            // InstructionBox
            // 
            this.InstructionBox.Controls.Add(this.HowToText);
            this.InstructionBox.Controls.Add(this.WelcomeText);
            this.InstructionBox.Location = new System.Drawing.Point(12, 47);
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.Size = new System.Drawing.Size(301, 92);
            this.InstructionBox.TabIndex = 1;
            this.InstructionBox.TabStop = false;
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.Location = new System.Drawing.Point(83, 14);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(139, 16);
            this.WelcomeText.TabIndex = 2;
            this.WelcomeText.Text = "Welcome to AeroPeek11.";
            // 
            // HowToText
            // 
            this.HowToText.AutoSize = true;
            this.HowToText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToText.Location = new System.Drawing.Point(26, 35);
            this.HowToText.Name = "HowToText";
            this.HowToText.Size = new System.Drawing.Size(254, 48);
            this.HowToText.TabIndex = 3;
            this.HowToText.Text = "To get started on configuring your AeroPeek11\r\nsettings, click the \'Position Peek" +
    "\' button and\r\nposition where you want the peeking window.";
            this.HowToText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PositionButton
            // 
            this.PositionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionButton.Location = new System.Drawing.Point(12, 155);
            this.PositionButton.Name = "PositionButton";
            this.PositionButton.Size = new System.Drawing.Size(147, 23);
            this.PositionButton.TabIndex = 2;
            this.PositionButton.Text = "Position Peek";
            this.TipManager.SetToolTip(this.PositionButton, "Allows you to position your peek area. A normal peek area would be the end of the" +
        " task-bar.");
            this.PositionButton.UseVisualStyleBackColor = true;
            this.PositionButton.Click += new System.EventHandler(this.PositionButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HelpButton.Location = new System.Drawing.Point(12, 184);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(301, 23);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "I Need More Help";
            this.TipManager.SetToolTip(this.HelpButton, "Need more help? Click this button to display helpful information.");
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Enabled = false;
            this.SaveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsButton.Location = new System.Drawing.Point(166, 155);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(147, 23);
            this.SaveSettingsButton.TabIndex = 4;
            this.SaveSettingsButton.Text = "Save Position Settings";
            this.TipManager.SetToolTip(this.SaveSettingsButton, "This will save your settings. Only click this when you have positioned the peek.");
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 224);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.PositionButton);
            this.Controls.Add(this.InstructionBox);
            this.Controls.Add(this.TitleBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Setup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AeroPeek11 Setup Dialog";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.InstructionBox.ResumeLayout(false);
            this.InstructionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ToolTip TipManager;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Label ClientTitle;
        private System.Windows.Forms.GroupBox InstructionBox;
        private System.Windows.Forms.Label HowToText;
        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.Button PositionButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button SaveSettingsButton;
    }
}