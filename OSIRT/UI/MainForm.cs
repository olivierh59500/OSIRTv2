﻿using ImageMagick;
using Ionic.Zip;
using Jacksonsoft;
using mshtml;
using OSIRT.Browser;
using OSIRT.Helpers;
using OSIRT.UI;
using OSIRT.UI.CaseClosing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSIRT
{
    public partial class MainForm : Form
    {

        private bool caseOpened = false;
   
        public MainForm()
        {
            InitializeComponent();
            FormClosing += MainForm_FormClosing;
            

        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CloseOSIRT();
        }

        private void CloseOSIRT(string password)
        {
            if (caseOpened)
            {
                WaitWindow.Show(ClosingOperations, "Running OSIRT closing operations... Please wait", password);
            }
        }

        private void ClosingOperations(object sender, WaitWindowEventArgs e)
        {
            //TODO: clear IE cache if required

            Thread.Sleep(500); //just to see the window
            //zip container
            e.Window.Message = "Archiving container.";
            using (ZipFile zip = new ZipFile())
            {
                zip.Password = e.Arguments[0].ToString(); 
                zip.Encryption = EncryptionAlgorithm.WinZipAes256;
                zip.AddDirectory(Constants.ContainerLocation, Constants.CaseContainerName);
                zip.Save(Path.Combine(Constants.CasePath, Constants.CaseContainerName + Constants.ContainerExtension));
            }
            Directory.Delete(Path.Combine(Constants.CasePath, Constants.CaseContainerName), true);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FirstLoadPanel firstLoadPanel = new FirstLoadPanel();
            firstLoadPanel.NewCase_Click += firstLoadPanel_NewCase_Click;
            firstLoadPanel.LoadOldCase_Click += FirstLoadPanel_LoadOldCase_Click;
            Controls.Add(firstLoadPanel);
        }

        private void FirstLoadPanel_LoadOldCase_Click(object sender, EventArgs e)
        {
            string filenameWithPath = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "OSR Files|*.osr";
                DialogResult result = openFileDialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;

                filenameWithPath = openFileDialog.FileName;
            }

            Controls.Clear();
            LoadExistingCasePanel exisitingCasePanel = new LoadExistingCasePanel(new FileInfo(filenameWithPath));
            Controls.Add(exisitingCasePanel);
            exisitingCasePanel.PasswordCheckClick += ExisitingCasePanel_PasswordCheckClick;

        }

        private void ExisitingCasePanel_PasswordCheckClick(object sender, EventArgs e)
        {
            ShowBrowserPanel();
            caseOpened = true;
        }


        void firstLoadPanel_NewCase_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            CaseDetailsPanel2 caseDetailsPanel = new CaseDetailsPanel2();
            Controls.Add(caseDetailsPanel);
            caseDetailsPanel.NextClick += new EventHandler(caseDetailsPanel_NextClick);
        }

        protected void caseDetailsPanel_NextClick(object sender, EventArgs e)
        {
            ShowBrowserPanel();
            caseOpened = true;
        }

        private void ShowBrowserPanel()
        {
            Controls.Clear();
            BrowserPanel browserPanel = new BrowserPanel();
            Controls.Add(browserPanel);
            WindowState = FormWindowState.Maximized;
            browserPanel.CaseClosing += BrowserPanel_CaseClosing;
        }

        private void BrowserPanel_CaseClosing(object sender, EventArgs e)
        {
            Controls.Clear();
            CloseCasePanel closePanel = new CloseCasePanel();
            Controls.Add(closePanel);
            closePanel.PasswordCorrect += ClosePanel_PasswordCorrect;
        }

        private void ClosePanel_PasswordCorrect(object sender, CaseClosingEventArgs e)
        {
            Controls.Clear();
            CloseOSIRT(e.Password);
            Close();
        }
    }
}
