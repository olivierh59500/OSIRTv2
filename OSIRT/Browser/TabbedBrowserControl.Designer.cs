﻿namespace OSIRT.Browser
{
    partial class TabbedBrowserControl
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
            this.uiBrowserTabControl = new System.Windows.Forms.TabControl();
            this.uiBrowserPanel = new System.Windows.Forms.Panel();
            this.uiBrowserStatusStrip = new System.Windows.Forms.StatusStrip();
            this.uiStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.uiBrowserPanel.SuspendLayout();
            this.uiBrowserStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiBrowserTabControl
            // 
            this.uiBrowserTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBrowserTabControl.Location = new System.Drawing.Point(0, 0);
            this.uiBrowserTabControl.Name = "uiBrowserTabControl";
            this.uiBrowserTabControl.SelectedIndex = 0;
            this.uiBrowserTabControl.Size = new System.Drawing.Size(800, 593);
            this.uiBrowserTabControl.TabIndex = 0;
            this.uiBrowserTabControl.SelectedIndexChanged += new System.EventHandler(this.uiBrowserTabControl_SelectedIndexChanged);
            // 
            // uiBrowserPanel
            // 
            this.uiBrowserPanel.Controls.Add(this.uiBrowserTabControl);
            this.uiBrowserPanel.Controls.Add(this.uiBrowserStatusStrip);
            this.uiBrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiBrowserPanel.Location = new System.Drawing.Point(0, 0);
            this.uiBrowserPanel.Name = "uiBrowserPanel";
            this.uiBrowserPanel.Size = new System.Drawing.Size(800, 615);
            this.uiBrowserPanel.TabIndex = 1;
            // 
            // uiBrowserStatusStrip
            // 
            this.uiBrowserStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiStatusLabel});
            this.uiBrowserStatusStrip.Location = new System.Drawing.Point(0, 593);
            this.uiBrowserStatusStrip.Name = "uiBrowserStatusStrip";
            this.uiBrowserStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.uiBrowserStatusStrip.TabIndex = 0;
            this.uiBrowserStatusStrip.Text = "statusStrip1";
            // 
            // uiStatusLabel
            // 
            this.uiStatusLabel.Name = "uiStatusLabel";
            this.uiStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // TabbedBrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiBrowserPanel);
            this.Name = "TabbedBrowserControl";
            this.Size = new System.Drawing.Size(800, 615);
            this.uiBrowserPanel.ResumeLayout(false);
            this.uiBrowserPanel.PerformLayout();
            this.uiBrowserStatusStrip.ResumeLayout(false);
            this.uiBrowserStatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl uiBrowserTabControl;
        private System.Windows.Forms.Panel uiBrowserPanel;
        private System.Windows.Forms.StatusStrip uiBrowserStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel uiStatusLabel;
    }
}