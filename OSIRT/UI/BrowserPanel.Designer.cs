﻿namespace OSIRT.UI
{
    partial class BrowserPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserPanel));
            this.uiBrowserPanel = new System.Windows.Forms.Panel();
            this.uiBrowserToolStrip = new System.Windows.Forms.ToolStrip();
            this.uiURLComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.uiBrowserMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTabbedBrowserControl = new OSIRT.Browser.TabbedBrowserControl();
            this.uiHomeButton = new System.Windows.Forms.ToolStripButton();
            this.uiLBackButton = new System.Windows.Forms.ToolStripButton();
            this.uiForwardButton = new System.Windows.Forms.ToolStripButton();
            this.uiRefreshButton = new System.Windows.Forms.ToolStripButton();
            this.uiVideoCaptureButton = new System.Windows.Forms.ToolStripButton();
            this.uiCaseNotesButton = new System.Windows.Forms.ToolStripButton();
            this.uiAddTabButton = new System.Windows.Forms.ToolStripButton();
            this.uiScreenshotButton = new System.Windows.Forms.ToolStripButton();
            this.uiBrowserPanel.SuspendLayout();
            this.uiBrowserToolStrip.SuspendLayout();
            this.uiBrowserMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiBrowserPanel
            // 
            this.uiBrowserPanel.Controls.Add(this.uiTabbedBrowserControl);
            this.uiBrowserPanel.Controls.Add(this.uiBrowserToolStrip);
            this.uiBrowserPanel.Controls.Add(this.uiBrowserMenuStrip);
            this.uiBrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBrowserPanel.Location = new System.Drawing.Point(0, 0);
            this.uiBrowserPanel.Name = "uiBrowserPanel";
            this.uiBrowserPanel.Size = new System.Drawing.Size(838, 525);
            this.uiBrowserPanel.TabIndex = 0;
            // 
            // uiBrowserToolStrip
            // 
            this.uiBrowserToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiHomeButton,
            this.uiLBackButton,
            this.uiForwardButton,
            this.uiRefreshButton,
            this.uiScreenshotButton,
            this.uiVideoCaptureButton,
            this.uiURLComboBox,
            this.uiCaseNotesButton,
            this.uiAddTabButton});
            this.uiBrowserToolStrip.Location = new System.Drawing.Point(0, 24);
            this.uiBrowserToolStrip.Name = "uiBrowserToolStrip";
            this.uiBrowserToolStrip.Size = new System.Drawing.Size(838, 25);
            this.uiBrowserToolStrip.TabIndex = 1;
            this.uiBrowserToolStrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiBrowserToolStrip_KeyDown);
            // 
            // uiURLComboBox
            // 
            this.uiURLComboBox.Name = "uiURLComboBox";
            this.uiURLComboBox.Size = new System.Drawing.Size(350, 25);
            // 
            // uiBrowserMenuStrip
            // 
            this.uiBrowserMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.uiBrowserMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uiBrowserMenuStrip.Name = "uiBrowserMenuStrip";
            this.uiBrowserMenuStrip.Size = new System.Drawing.Size(838, 24);
            this.uiBrowserMenuStrip.TabIndex = 0;
            this.uiBrowserMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.uiBrowserMenuStrip_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // uiTabbedBrowserControl
            // 
            this.uiTabbedBrowserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabbedBrowserControl.Location = new System.Drawing.Point(0, 49);
            this.uiTabbedBrowserControl.Name = "uiTabbedBrowserControl";
            this.uiTabbedBrowserControl.Size = new System.Drawing.Size(838, 476);
            this.uiTabbedBrowserControl.TabIndex = 2;
            // 
            // uiHomeButton
            // 
            this.uiHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("uiHomeButton.Image")));
            this.uiHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiHomeButton.Name = "uiHomeButton";
            this.uiHomeButton.Size = new System.Drawing.Size(23, 22);
            this.uiHomeButton.ToolTipText = "Home";
            // 
            // uiLBackButton
            // 
            this.uiLBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiLBackButton.Image = global::OSIRT.Properties.Resources.arrow_left;
            this.uiLBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiLBackButton.Name = "uiLBackButton";
            this.uiLBackButton.Size = new System.Drawing.Size(23, 22);
            this.uiLBackButton.ToolTipText = "Go Back";
            // 
            // uiForwardButton
            // 
            this.uiForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiForwardButton.Image = global::OSIRT.Properties.Resources.arrow_right;
            this.uiForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiForwardButton.Name = "uiForwardButton";
            this.uiForwardButton.Size = new System.Drawing.Size(23, 22);
            this.uiForwardButton.Text = "uiRightButton";
            this.uiForwardButton.ToolTipText = "Go Forward";
            // 
            // uiRefreshButton
            // 
            this.uiRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiRefreshButton.Image = global::OSIRT.Properties.Resources.arrow_rotate_clockwise;
            this.uiRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiRefreshButton.Name = "uiRefreshButton";
            this.uiRefreshButton.Size = new System.Drawing.Size(23, 22);
            this.uiRefreshButton.Text = "toolStripButton4";
            this.uiRefreshButton.ToolTipText = "Refresh Page";
            // 
            // uiVideoCaptureButton
            // 
            this.uiVideoCaptureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiVideoCaptureButton.Image = global::OSIRT.Properties.Resources.film;
            this.uiVideoCaptureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiVideoCaptureButton.Name = "uiVideoCaptureButton";
            this.uiVideoCaptureButton.Size = new System.Drawing.Size(23, 22);
            this.uiVideoCaptureButton.ToolTipText = "Start Video Capture";
            // 
            // uiCaseNotesButton
            // 
            this.uiCaseNotesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiCaseNotesButton.Image = ((System.Drawing.Image)(resources.GetObject("uiCaseNotesButton.Image")));
            this.uiCaseNotesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiCaseNotesButton.Name = "uiCaseNotesButton";
            this.uiCaseNotesButton.Size = new System.Drawing.Size(23, 22);
            this.uiCaseNotesButton.Click += new System.EventHandler(this.uiCaseNotesButton_Click);
            // 
            // uiAddTabButton
            // 
            this.uiAddTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiAddTabButton.Image = ((System.Drawing.Image)(resources.GetObject("uiAddTabButton.Image")));
            this.uiAddTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiAddTabButton.Name = "uiAddTabButton";
            this.uiAddTabButton.Size = new System.Drawing.Size(23, 22);
            this.uiAddTabButton.Text = "toolStripButton1";
            this.uiAddTabButton.ToolTipText = "Add a new tab";
            this.uiAddTabButton.Click += new System.EventHandler(this.uiAddTabButton_Click);
            // 
            // uiScreenshotButton
            // 
            this.uiScreenshotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uiScreenshotButton.Image = global::OSIRT.Properties.Resources.camera;
            this.uiScreenshotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uiScreenshotButton.Name = "uiScreenshotButton";
            this.uiScreenshotButton.Size = new System.Drawing.Size(23, 22);
            this.uiScreenshotButton.Text = "toolStripButton1";
            this.uiScreenshotButton.ToolTipText = "Capture Screenshot";
            this.uiScreenshotButton.Click += new System.EventHandler(this.uiScreenshotButton_Click);
            // 
            // BrowserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiBrowserPanel);
            this.Name = "BrowserPanel";
            this.Size = new System.Drawing.Size(838, 525);
            this.Load += new System.EventHandler(this.BrowserPanel_Load);
            this.uiBrowserPanel.ResumeLayout(false);
            this.uiBrowserPanel.PerformLayout();
            this.uiBrowserToolStrip.ResumeLayout(false);
            this.uiBrowserToolStrip.PerformLayout();
            this.uiBrowserMenuStrip.ResumeLayout(false);
            this.uiBrowserMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uiBrowserPanel;
        private System.Windows.Forms.MenuStrip uiBrowserMenuStrip;
        private Browser.TabbedBrowserControl uiTabbedBrowserControl;
        private System.Windows.Forms.ToolStrip uiBrowserToolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox uiURLComboBox;
        private System.Windows.Forms.ToolStripButton uiHomeButton;
        private System.Windows.Forms.ToolStripButton uiLBackButton;
        private System.Windows.Forms.ToolStripButton uiForwardButton;
        private System.Windows.Forms.ToolStripButton uiVideoCaptureButton;
        private System.Windows.Forms.ToolStripButton uiCaseNotesButton;
        private System.Windows.Forms.ToolStripButton uiRefreshButton;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton uiAddTabButton;
        private System.Windows.Forms.ToolStripButton uiScreenshotButton;
    }
}
