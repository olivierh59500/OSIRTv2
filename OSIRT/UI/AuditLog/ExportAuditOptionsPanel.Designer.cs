﻿namespace OSIRT.UI.AuditLog
{
    partial class ExportAuditOptionsPanel
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
            this.uiReportSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.uiOsirtActionsCheckBox = new System.Windows.Forms.CheckBox();
            this.uiToggleCheckedButton = new System.Windows.Forms.Button();
            this.uiAttachmentCheckBox = new System.Windows.Forms.CheckBox();
            this.uiVideosCheckBox = new System.Windows.Forms.CheckBox();
            this.uiWebActionsCheckBox = new System.Windows.Forms.CheckBox();
            this.uiLoadedCheckBox = new System.Windows.Forms.CheckBox();
            this.uiReportOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.uiMergeCaseNotesCheckBox = new System.Windows.Forms.CheckBox();
            this.uiChronOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.uiDisplayVideosCheckBox = new System.Windows.Forms.CheckBox();
            this.uiGSCPComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOpenReportCheckBox = new System.Windows.Forms.CheckBox();
            this.uiPrintNotesCheckBox = new System.Windows.Forms.CheckBox();
            this.uiDisplayImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.uiExportAsGroupBox = new System.Windows.Forms.GroupBox();
            this.uiExportAsXmlButton = new System.Windows.Forms.Button();
            this.uiBrowseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uiPathTextBox = new System.Windows.Forms.TextBox();
            this.uiExportAsCaseFileButton = new System.Windows.Forms.Button();
            this.uiExportAsPdfButton = new System.Windows.Forms.Button();
            this.uiExportAsHtmlButton = new System.Windows.Forms.Button();
            this.uiReportExportHelpLabel = new System.Windows.Forms.Label();
            this.uiReportExportProgressBar = new System.Windows.Forms.ProgressBar();
            this.uiProgressGroupBox = new System.Windows.Forms.GroupBox();
            this.uiReportExportLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiDateSelectionCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiFirstDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiSecondDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiReportSelectionGroupBox.SuspendLayout();
            this.uiReportOptionsGroupBox.SuspendLayout();
            this.uiExportAsGroupBox.SuspendLayout();
            this.uiProgressGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiReportSelectionGroupBox
            // 
            this.uiReportSelectionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiReportSelectionGroupBox.Controls.Add(this.uiOsirtActionsCheckBox);
            this.uiReportSelectionGroupBox.Controls.Add(this.uiToggleCheckedButton);
            this.uiReportSelectionGroupBox.Controls.Add(this.uiAttachmentCheckBox);
            this.uiReportSelectionGroupBox.Controls.Add(this.uiVideosCheckBox);
            this.uiReportSelectionGroupBox.Controls.Add(this.uiWebActionsCheckBox);
            this.uiReportSelectionGroupBox.Controls.Add(this.uiLoadedCheckBox);
            this.uiReportSelectionGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiReportSelectionGroupBox.Location = new System.Drawing.Point(3, 3);
            this.uiReportSelectionGroupBox.Name = "uiReportSelectionGroupBox";
            this.uiReportSelectionGroupBox.Size = new System.Drawing.Size(310, 140);
            this.uiReportSelectionGroupBox.TabIndex = 0;
            this.uiReportSelectionGroupBox.TabStop = false;
            this.uiReportSelectionGroupBox.Text = "Report Selection";
            // 
            // uiOsirtActionsCheckBox
            // 
            this.uiOsirtActionsCheckBox.AutoSize = true;
            this.uiOsirtActionsCheckBox.Checked = true;
            this.uiOsirtActionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiOsirtActionsCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiOsirtActionsCheckBox.Location = new System.Drawing.Point(6, 92);
            this.uiOsirtActionsCheckBox.Name = "uiOsirtActionsCheckBox";
            this.uiOsirtActionsCheckBox.Size = new System.Drawing.Size(97, 17);
            this.uiOsirtActionsCheckBox.TabIndex = 2;
            this.uiOsirtActionsCheckBox.Tag = "osirt_actions";
            this.uiOsirtActionsCheckBox.Text = "OSIRT Actions";
            this.uiOsirtActionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // uiToggleCheckedButton
            // 
            this.uiToggleCheckedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiToggleCheckedButton.Location = new System.Drawing.Point(204, 111);
            this.uiToggleCheckedButton.Name = "uiToggleCheckedButton";
            this.uiToggleCheckedButton.Size = new System.Drawing.Size(100, 23);
            this.uiToggleCheckedButton.TabIndex = 5;
            this.uiToggleCheckedButton.Text = "Toggle Checked";
            this.uiToggleCheckedButton.UseVisualStyleBackColor = true;
            this.uiToggleCheckedButton.Visible = false;
            this.uiToggleCheckedButton.Click += new System.EventHandler(this.uiToggleCheckedButton_Click);
            // 
            // uiAttachmentCheckBox
            // 
            this.uiAttachmentCheckBox.AutoSize = true;
            this.uiAttachmentCheckBox.Checked = true;
            this.uiAttachmentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiAttachmentCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiAttachmentCheckBox.Location = new System.Drawing.Point(202, 60);
            this.uiAttachmentCheckBox.Name = "uiAttachmentCheckBox";
            this.uiAttachmentCheckBox.Size = new System.Drawing.Size(85, 17);
            this.uiAttachmentCheckBox.TabIndex = 4;
            this.uiAttachmentCheckBox.Tag = "attachments";
            this.uiAttachmentCheckBox.Text = "Attachments";
            this.uiAttachmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // uiVideosCheckBox
            // 
            this.uiVideosCheckBox.AutoSize = true;
            this.uiVideosCheckBox.Checked = true;
            this.uiVideosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiVideosCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiVideosCheckBox.Location = new System.Drawing.Point(202, 28);
            this.uiVideosCheckBox.Name = "uiVideosCheckBox";
            this.uiVideosCheckBox.Size = new System.Drawing.Size(58, 17);
            this.uiVideosCheckBox.TabIndex = 3;
            this.uiVideosCheckBox.Tag = "videos";
            this.uiVideosCheckBox.Text = "Videos";
            this.uiVideosCheckBox.UseVisualStyleBackColor = true;
            // 
            // uiWebActionsCheckBox
            // 
            this.uiWebActionsCheckBox.AutoSize = true;
            this.uiWebActionsCheckBox.Checked = true;
            this.uiWebActionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiWebActionsCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiWebActionsCheckBox.Location = new System.Drawing.Point(6, 60);
            this.uiWebActionsCheckBox.Name = "uiWebActionsCheckBox";
            this.uiWebActionsCheckBox.Size = new System.Drawing.Size(103, 17);
            this.uiWebActionsCheckBox.TabIndex = 1;
            this.uiWebActionsCheckBox.Tag = "webpage_actions";
            this.uiWebActionsCheckBox.Text = "Website Actions";
            this.uiWebActionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // uiLoadedCheckBox
            // 
            this.uiLoadedCheckBox.AutoSize = true;
            this.uiLoadedCheckBox.Checked = true;
            this.uiLoadedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiLoadedCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiLoadedCheckBox.Location = new System.Drawing.Point(6, 28);
            this.uiLoadedCheckBox.Name = "uiLoadedCheckBox";
            this.uiLoadedCheckBox.Size = new System.Drawing.Size(109, 17);
            this.uiLoadedCheckBox.TabIndex = 0;
            this.uiLoadedCheckBox.Tag = "webpage_log";
            this.uiLoadedCheckBox.Text = "Websites Loaded";
            this.uiLoadedCheckBox.UseVisualStyleBackColor = true;
            // 
            // uiReportOptionsGroupBox
            // 
            this.uiReportOptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiReportOptionsGroupBox.Controls.Add(this.uiMergeCaseNotesCheckBox);
            this.uiReportOptionsGroupBox.Controls.Add(this.uiChronOrderCheckBox);
            this.uiReportOptionsGroupBox.Controls.Add(this.uiDisplayVideosCheckBox);
            this.uiReportOptionsGroupBox.Controls.Add(this.uiGSCPComboBox);
            this.uiReportOptionsGroupBox.Controls.Add(this.label1);
            this.uiReportOptionsGroupBox.Controls.Add(this.uiOpenReportCheckBox);
            this.uiReportOptionsGroupBox.Controls.Add(this.uiPrintNotesCheckBox);
            this.uiReportOptionsGroupBox.Controls.Add(this.uiDisplayImagesCheckBox);
            this.uiReportOptionsGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiReportOptionsGroupBox.Location = new System.Drawing.Point(3, 229);
            this.uiReportOptionsGroupBox.Name = "uiReportOptionsGroupBox";
            this.uiReportOptionsGroupBox.Size = new System.Drawing.Size(310, 175);
            this.uiReportOptionsGroupBox.TabIndex = 1;
            this.uiReportOptionsGroupBox.TabStop = false;
            this.uiReportOptionsGroupBox.Text = "Report Options";
            // 
            // uiMergeCaseNotesCheckBox
            // 
            this.uiMergeCaseNotesCheckBox.AutoSize = true;
            this.uiMergeCaseNotesCheckBox.Checked = true;
            this.uiMergeCaseNotesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiMergeCaseNotesCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiMergeCaseNotesCheckBox.Location = new System.Drawing.Point(170, 86);
            this.uiMergeCaseNotesCheckBox.Name = "uiMergeCaseNotesCheckBox";
            this.uiMergeCaseNotesCheckBox.Size = new System.Drawing.Size(114, 17);
            this.uiMergeCaseNotesCheckBox.TabIndex = 7;
            this.uiMergeCaseNotesCheckBox.Text = "Merge case notes ";
            this.uiMergeCaseNotesCheckBox.UseVisualStyleBackColor = true;
            // 
            // uiChronOrderCheckBox
            // 
            this.uiChronOrderCheckBox.AutoSize = true;
            this.uiChronOrderCheckBox.Checked = true;
            this.uiChronOrderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiChronOrderCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiChronOrderCheckBox.Location = new System.Drawing.Point(170, 57);
            this.uiChronOrderCheckBox.Name = "uiChronOrderCheckBox";
            this.uiChronOrderCheckBox.Size = new System.Drawing.Size(117, 17);
            this.uiChronOrderCheckBox.TabIndex = 6;
            this.uiChronOrderCheckBox.Text = "Chronological order";
            this.uiChronOrderCheckBox.UseVisualStyleBackColor = true;
            this.uiChronOrderCheckBox.Visible = false;
            // 
            // uiDisplayVideosCheckBox
            // 
            this.uiDisplayVideosCheckBox.AutoSize = true;
            this.uiDisplayVideosCheckBox.Checked = true;
            this.uiDisplayVideosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiDisplayVideosCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiDisplayVideosCheckBox.Location = new System.Drawing.Point(6, 57);
            this.uiDisplayVideosCheckBox.Name = "uiDisplayVideosCheckBox";
            this.uiDisplayVideosCheckBox.Size = new System.Drawing.Size(121, 17);
            this.uiDisplayVideosCheckBox.TabIndex = 5;
            this.uiDisplayVideosCheckBox.Text = "Link videos in report";
            this.uiDisplayVideosCheckBox.UseVisualStyleBackColor = true;
            this.uiDisplayVideosCheckBox.CheckedChanged += new System.EventHandler(this.uiDisplayVideosCheckBox_CheckedChanged);
            // 
            // uiGSCPComboBox
            // 
            this.uiGSCPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiGSCPComboBox.FormattingEnabled = true;
            this.uiGSCPComboBox.Items.AddRange(new object[] {
            "Not Protectively Marked",
            "TOP SECRET",
            "SECRET",
            "OFFICIAL-SENSITIVE",
            "OFFICIAL"});
            this.uiGSCPComboBox.Location = new System.Drawing.Point(6, 143);
            this.uiGSCPComboBox.Name = "uiGSCPComboBox";
            this.uiGSCPComboBox.Size = new System.Drawing.Size(298, 21);
            this.uiGSCPComboBox.TabIndex = 4;
            this.uiGSCPComboBox.SelectedIndexChanged += new System.EventHandler(this.uiGSCPComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "GSCP Stamp:";
            // 
            // uiOpenReportCheckBox
            // 
            this.uiOpenReportCheckBox.AutoSize = true;
            this.uiOpenReportCheckBox.Checked = true;
            this.uiOpenReportCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiOpenReportCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiOpenReportCheckBox.Location = new System.Drawing.Point(6, 86);
            this.uiOpenReportCheckBox.Name = "uiOpenReportCheckBox";
            this.uiOpenReportCheckBox.Size = new System.Drawing.Size(148, 17);
            this.uiOpenReportCheckBox.TabIndex = 2;
            this.uiOpenReportCheckBox.Text = "Open report once created";
            this.uiOpenReportCheckBox.UseVisualStyleBackColor = true;
            this.uiOpenReportCheckBox.CheckedChanged += new System.EventHandler(this.uiOpenReportCheckBox_CheckedChanged);
            // 
            // uiPrintNotesCheckBox
            // 
            this.uiPrintNotesCheckBox.AutoSize = true;
            this.uiPrintNotesCheckBox.Checked = true;
            this.uiPrintNotesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiPrintNotesCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiPrintNotesCheckBox.Location = new System.Drawing.Point(170, 28);
            this.uiPrintNotesCheckBox.Name = "uiPrintNotesCheckBox";
            this.uiPrintNotesCheckBox.Size = new System.Drawing.Size(102, 17);
            this.uiPrintNotesCheckBox.TabIndex = 1;
            this.uiPrintNotesCheckBox.Text = "Print audit notes";
            this.uiPrintNotesCheckBox.UseVisualStyleBackColor = true;
            this.uiPrintNotesCheckBox.CheckedChanged += new System.EventHandler(this.uiPrintNotesCheckBox_CheckedChanged);
            // 
            // uiDisplayImagesCheckBox
            // 
            this.uiDisplayImagesCheckBox.AutoSize = true;
            this.uiDisplayImagesCheckBox.Checked = true;
            this.uiDisplayImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uiDisplayImagesCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiDisplayImagesCheckBox.Location = new System.Drawing.Point(6, 28);
            this.uiDisplayImagesCheckBox.Name = "uiDisplayImagesCheckBox";
            this.uiDisplayImagesCheckBox.Size = new System.Drawing.Size(123, 17);
            this.uiDisplayImagesCheckBox.TabIndex = 0;
            this.uiDisplayImagesCheckBox.Text = "Link images in report";
            this.uiDisplayImagesCheckBox.UseVisualStyleBackColor = true;
            this.uiDisplayImagesCheckBox.CheckedChanged += new System.EventHandler(this.uiDisplayImagesCheckBox_CheckedChanged);
            // 
            // uiExportAsGroupBox
            // 
            this.uiExportAsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiExportAsGroupBox.Controls.Add(this.uiExportAsXmlButton);
            this.uiExportAsGroupBox.Controls.Add(this.uiBrowseButton);
            this.uiExportAsGroupBox.Controls.Add(this.label2);
            this.uiExportAsGroupBox.Controls.Add(this.uiPathTextBox);
            this.uiExportAsGroupBox.Controls.Add(this.uiExportAsCaseFileButton);
            this.uiExportAsGroupBox.Controls.Add(this.uiExportAsPdfButton);
            this.uiExportAsGroupBox.Controls.Add(this.uiExportAsHtmlButton);
            this.uiExportAsGroupBox.Controls.Add(this.uiReportExportHelpLabel);
            this.uiExportAsGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiExportAsGroupBox.Location = new System.Drawing.Point(3, 410);
            this.uiExportAsGroupBox.Name = "uiExportAsGroupBox";
            this.uiExportAsGroupBox.Size = new System.Drawing.Size(310, 175);
            this.uiExportAsGroupBox.TabIndex = 2;
            this.uiExportAsGroupBox.TabStop = false;
            this.uiExportAsGroupBox.Text = "Export Report";
            // 
            // uiExportAsXmlButton
            // 
            this.uiExportAsXmlButton.Image = global::OSIRT.Properties.Resources.xml_exports;
            this.uiExportAsXmlButton.Location = new System.Drawing.Point(163, 80);
            this.uiExportAsXmlButton.Name = "uiExportAsXmlButton";
            this.uiExportAsXmlButton.Size = new System.Drawing.Size(60, 56);
            this.uiExportAsXmlButton.TabIndex = 7;
            this.uiExportAsXmlButton.UseVisualStyleBackColor = true;
            this.uiExportAsXmlButton.Click += new System.EventHandler(this.uiExportAsXmlButton_Click);
            this.uiExportAsXmlButton.MouseHover += new System.EventHandler(this.uiExportAsXmlButton_MouseHover);
            // 
            // uiBrowseButton
            // 
            this.uiBrowseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uiBrowseButton.Location = new System.Drawing.Point(229, 45);
            this.uiBrowseButton.Name = "uiBrowseButton";
            this.uiBrowseButton.Size = new System.Drawing.Size(75, 20);
            this.uiBrowseButton.TabIndex = 5;
            this.uiBrowseButton.Text = "Browse...";
            this.uiBrowseButton.UseVisualStyleBackColor = true;
            this.uiBrowseButton.Click += new System.EventHandler(this.uiBrowseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Export Location";
            // 
            // uiPathTextBox
            // 
            this.uiPathTextBox.Location = new System.Drawing.Point(6, 45);
            this.uiPathTextBox.Name = "uiPathTextBox";
            this.uiPathTextBox.ReadOnly = true;
            this.uiPathTextBox.Size = new System.Drawing.Size(217, 20);
            this.uiPathTextBox.TabIndex = 3;
            this.uiPathTextBox.TextChanged += new System.EventHandler(this.uiPathTextBox_TextChanged);
            // 
            // uiExportAsCaseFileButton
            // 
            this.uiExportAsCaseFileButton.Image = global::OSIRT.Properties.Resources.table;
            this.uiExportAsCaseFileButton.Location = new System.Drawing.Point(244, 80);
            this.uiExportAsCaseFileButton.Name = "uiExportAsCaseFileButton";
            this.uiExportAsCaseFileButton.Size = new System.Drawing.Size(60, 56);
            this.uiExportAsCaseFileButton.TabIndex = 2;
            this.uiExportAsCaseFileButton.UseVisualStyleBackColor = true;
            this.uiExportAsCaseFileButton.Click += new System.EventHandler(this.uiExportAsCaseFileButton_Click);
            this.uiExportAsCaseFileButton.MouseHover += new System.EventHandler(this.uiExportAsCaseFileButton_MouseHover);
            // 
            // uiExportAsPdfButton
            // 
            this.uiExportAsPdfButton.Image = global::OSIRT.Properties.Resources.pdf_icon;
            this.uiExportAsPdfButton.Location = new System.Drawing.Point(84, 80);
            this.uiExportAsPdfButton.Name = "uiExportAsPdfButton";
            this.uiExportAsPdfButton.Size = new System.Drawing.Size(60, 56);
            this.uiExportAsPdfButton.TabIndex = 1;
            this.uiExportAsPdfButton.UseVisualStyleBackColor = true;
            this.uiExportAsPdfButton.Click += new System.EventHandler(this.uiExportAsPdfButton_Click);
            this.uiExportAsPdfButton.MouseHover += new System.EventHandler(this.uiExportAsPdfButton_MouseHover);
            // 
            // uiExportAsHtmlButton
            // 
            this.uiExportAsHtmlButton.Image = global::OSIRT.Properties.Resources.html;
            this.uiExportAsHtmlButton.Location = new System.Drawing.Point(6, 80);
            this.uiExportAsHtmlButton.Name = "uiExportAsHtmlButton";
            this.uiExportAsHtmlButton.Size = new System.Drawing.Size(62, 56);
            this.uiExportAsHtmlButton.TabIndex = 0;
            this.uiExportAsHtmlButton.UseVisualStyleBackColor = true;
            this.uiExportAsHtmlButton.Click += new System.EventHandler(this.uiExportAsHtmlButton_Click);
            this.uiExportAsHtmlButton.MouseHover += new System.EventHandler(this.uiExportAsHtmlButton_MouseHover);
            // 
            // uiReportExportHelpLabel
            // 
            this.uiReportExportHelpLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiReportExportHelpLabel.Location = new System.Drawing.Point(3, 124);
            this.uiReportExportHelpLabel.Name = "uiReportExportHelpLabel";
            this.uiReportExportHelpLabel.Size = new System.Drawing.Size(304, 48);
            this.uiReportExportHelpLabel.TabIndex = 6;
            this.uiReportExportHelpLabel.Text = "Export report as HTML";
            this.uiReportExportHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiReportExportProgressBar
            // 
            this.uiReportExportProgressBar.Location = new System.Drawing.Point(6, 34);
            this.uiReportExportProgressBar.MarqueeAnimationSpeed = 10;
            this.uiReportExportProgressBar.Name = "uiReportExportProgressBar";
            this.uiReportExportProgressBar.Size = new System.Drawing.Size(298, 23);
            this.uiReportExportProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.uiReportExportProgressBar.TabIndex = 3;
            // 
            // uiProgressGroupBox
            // 
            this.uiProgressGroupBox.Controls.Add(this.uiReportExportLabel);
            this.uiProgressGroupBox.Controls.Add(this.uiReportExportProgressBar);
            this.uiProgressGroupBox.Location = new System.Drawing.Point(3, 591);
            this.uiProgressGroupBox.Name = "uiProgressGroupBox";
            this.uiProgressGroupBox.Size = new System.Drawing.Size(310, 63);
            this.uiProgressGroupBox.TabIndex = 5;
            this.uiProgressGroupBox.TabStop = false;
            this.uiProgressGroupBox.Visible = false;
            // 
            // uiReportExportLabel
            // 
            this.uiReportExportLabel.AutoSize = true;
            this.uiReportExportLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiReportExportLabel.Location = new System.Drawing.Point(6, 16);
            this.uiReportExportLabel.Name = "uiReportExportLabel";
            this.uiReportExportLabel.Size = new System.Drawing.Size(90, 13);
            this.uiReportExportLabel.TabIndex = 4;
            this.uiReportExportLabel.Text = "Exporting report...";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.uiDateSelectionCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.uiFirstDateTimePicker);
            this.groupBox1.Controls.Add(this.uiSecondDateTimePicker);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Dates";
            // 
            // uiDateSelectionCheckBox
            // 
            this.uiDateSelectionCheckBox.AutoSize = true;
            this.uiDateSelectionCheckBox.Location = new System.Drawing.Point(6, 20);
            this.uiDateSelectionCheckBox.Name = "uiDateSelectionCheckBox";
            this.uiDateSelectionCheckBox.Size = new System.Drawing.Size(273, 17);
            this.uiDateSelectionCheckBox.TabIndex = 4;
            this.uiDateSelectionCheckBox.Text = "Print everything between these dates only (inclusive)";
            this.uiDateSelectionCheckBox.UseVisualStyleBackColor = true;
            this.uiDateSelectionCheckBox.CheckedChanged += new System.EventHandler(this.uiDateSelectionCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "and";
            // 
            // uiFirstDateTimePicker
            // 
            this.uiFirstDateTimePicker.Location = new System.Drawing.Point(6, 48);
            this.uiFirstDateTimePicker.Name = "uiFirstDateTimePicker";
            this.uiFirstDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.uiFirstDateTimePicker.TabIndex = 1;
            // 
            // uiSecondDateTimePicker
            // 
            this.uiSecondDateTimePicker.Location = new System.Drawing.Point(186, 48);
            this.uiSecondDateTimePicker.Name = "uiSecondDateTimePicker";
            this.uiSecondDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.uiSecondDateTimePicker.TabIndex = 0;
            // 
            // ExportAuditOptionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiProgressGroupBox);
            this.Controls.Add(this.uiExportAsGroupBox);
            this.Controls.Add(this.uiReportOptionsGroupBox);
            this.Controls.Add(this.uiReportSelectionGroupBox);
            this.Name = "ExportAuditOptionsPanel";
            this.Size = new System.Drawing.Size(316, 660);
            this.Load += new System.EventHandler(this.ExportAuditOptions_Load);
            this.uiReportSelectionGroupBox.ResumeLayout(false);
            this.uiReportSelectionGroupBox.PerformLayout();
            this.uiReportOptionsGroupBox.ResumeLayout(false);
            this.uiReportOptionsGroupBox.PerformLayout();
            this.uiExportAsGroupBox.ResumeLayout(false);
            this.uiExportAsGroupBox.PerformLayout();
            this.uiProgressGroupBox.ResumeLayout(false);
            this.uiProgressGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox uiReportSelectionGroupBox;
        private System.Windows.Forms.Button uiToggleCheckedButton;
        private System.Windows.Forms.CheckBox uiAttachmentCheckBox;
        private System.Windows.Forms.CheckBox uiVideosCheckBox;
        private System.Windows.Forms.CheckBox uiWebActionsCheckBox;
        private System.Windows.Forms.CheckBox uiLoadedCheckBox;
        private System.Windows.Forms.GroupBox uiReportOptionsGroupBox;
        private System.Windows.Forms.ComboBox uiGSCPComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox uiOpenReportCheckBox;
        private System.Windows.Forms.CheckBox uiPrintNotesCheckBox;
        private System.Windows.Forms.CheckBox uiDisplayImagesCheckBox;
        private System.Windows.Forms.GroupBox uiExportAsGroupBox;
        private System.Windows.Forms.CheckBox uiOsirtActionsCheckBox;
        private System.Windows.Forms.Button uiExportAsHtmlButton;
        private System.Windows.Forms.Button uiExportAsPdfButton;
        private System.Windows.Forms.Button uiBrowseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiPathTextBox;
        private System.Windows.Forms.Button uiExportAsCaseFileButton;
        private System.Windows.Forms.Label uiReportExportHelpLabel;
        private System.Windows.Forms.CheckBox uiDisplayVideosCheckBox;
        private System.Windows.Forms.CheckBox uiChronOrderCheckBox;
        private System.Windows.Forms.ProgressBar uiReportExportProgressBar;
        private System.Windows.Forms.GroupBox uiProgressGroupBox;
        private System.Windows.Forms.Label uiReportExportLabel;
        private System.Windows.Forms.CheckBox uiMergeCaseNotesCheckBox;
        private System.Windows.Forms.Button uiExportAsXmlButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker uiFirstDateTimePicker;
        private System.Windows.Forms.DateTimePicker uiSecondDateTimePicker;
        private System.Windows.Forms.CheckBox uiDateSelectionCheckBox;
    }
}
