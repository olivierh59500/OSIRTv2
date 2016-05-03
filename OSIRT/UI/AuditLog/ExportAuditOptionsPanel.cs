﻿using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using OSIRT.Database;
using OSIRT.Helpers;
using OSIRT.Extensions;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace OSIRT.UI.AuditLog
{
    public partial class ExportAuditOptionsPanel : UserControl
    {

        public string ExportPath { get; private set; }


        public ExportAuditOptionsPanel()
        {
            InitializeComponent();
        }

        private void ExportAuditOptions_Load(object sender, EventArgs e)
        {
            ToggleExportFileButtons(false);
        }

        private void uiExportAsHtmlButton_Click(object sender, EventArgs e)
        {
            foreach (var value in GetHtml())
            {
                string savePath = Path.Combine(ExportPath, $"report_{Constants.CaseContainerName}", $"{value.Item1}.html");
                File.WriteAllText(savePath, value.Item2);
            }
        }


        private IEnumerable<Tuple<string, string>> GetHtml()
        {
            DatabaseHandler db = new DatabaseHandler();
            string auditHtml = OsirtHelper.GetResource("auditlog.html");
            string save = "";
            var checkboxes = uiReportSelectionGroupBox.GetChildControls<CheckBox>();

            foreach (CheckBox cb in checkboxes)
            {
                if (!cb.Checked) continue;

                string table = cb.Tag.ToString();
                string columns = DatabaseTableHelper.GetTableColumns(table);
                string page = DatatableToHtml.ConvertToHtml(db.GetRowsFromColumns(table: table, columns: columns), ExportPath);
                save = auditHtml.Replace("<%%AUDIT_LOG%%>", page);
                yield return Tuple.Create(table, save);
            }
        }

        private void uiToggleCheckedButton_Click(object sender, EventArgs e)
        {

        }

        private void uiExportAsPdfButton_Click(object sender, EventArgs e)
        {


            foreach (var value in GetHtml())
            {
                string savePath = Path.Combine(ExportPath, $"report_{Constants.CaseContainerName}", $"{value.Item1}.pdf");
                HtmLtoPdf.SaveHtmltoPdf(value.Item2, value.Item1, savePath);
            }

            //TODO: not hardcoded path and LOG report export


        }

        private void uiBrowseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;

                ExportPath = folderDialog.SelectedPath;
                uiPathTextBox.Text = ExportPath;
            }
        }

        private void ToggleExportFileButtons(bool enabled)
        {
            uiExportAsPdfButton.Enabled = enabled;
            uiExportAsHtmlButton.Enabled = enabled;
            uiExportAsCaseFileButton.Enabled = enabled;
    
        }

        private void uiPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(ExportPath))
                ToggleExportFileButtons(true);
        }

        private void uiExportAsHtmlButton_MouseHover(object sender, EventArgs e)
        {
            uiReportExportHelpLabel.Text = "Export report as HTML";
        }

        private void uiExportAsPdfButton_MouseHover(object sender, EventArgs e)
        {
            uiReportExportHelpLabel.Text = "Export report as PDF";
        }

        private void uiExportAsCaseFileButton_MouseHover(object sender, EventArgs e)
        {
            uiReportExportHelpLabel.Text = "Export report as OSRR file";
        }

        private void uiDisplayImagesCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            UserSettings settings = UserSettings.Load();
            settings.PrintImagesInReport = uiDisplayImagesCheckBox.Checked;
            settings.Save();
        }

        private void uiPrintNotesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserSettings settings = UserSettings.Load();
            settings.PrintAuditNotes = uiPrintNotesCheckBox.Checked;
            settings.Save();
        }

        private void uiDisplayVideosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserSettings settings = UserSettings.Load();
            settings.ShowVideosInReport = uiDisplayVideosCheckBox.Checked;
            settings.Save();
        }
    }
}