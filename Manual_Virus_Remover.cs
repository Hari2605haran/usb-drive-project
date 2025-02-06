using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Information_Accumulate_From_USB_Drive
{
    public partial class Manual_Virus_Remover : Form
    {
        public Manual_Virus_Remover()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveListCombo.Items.Clear();
            DriveListCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DriveInfo j in DriveInfo.GetDrives())
            {
                DriveListCombo.Items.Add(j);
            }
        }

        private void Manual_Virus_Remover_Load(object sender, EventArgs e)
        {
            DriveListCombo.Items.Clear();
            DriveListCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DriveInfo h in DriveInfo.GetDrives())
            {
                DriveListCombo.Items.Add(h);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string driveletter = DriveListCombo.Text;
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & attrib *. -h -s /s /d";
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                //cmdLine.StartInfo.Arguments = "/k ipconfig";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
                MessageBox.Show("All hidden files are unhide");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DriveListCombo.Items.Clear();
            DriveListCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DriveInfo h in DriveInfo.GetDrives())
            {
                DriveListCombo.Items.Add(h);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string driveletter = DriveListCombo.Text;
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A *.lnk";
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();

                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A *.vba & DEL /F /S /Q /A *.vbs & DEL /F /S /Q /A *.vbe";
                Process cmdLine1 = new Process();
                cmdLine1.StartInfo.FileName = "cmd.exe";
                cmdLine1.StartInfo.Arguments = unhideDrive;
                cmdLine1.Start();
            }
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A autorun.inf";
                Process cmdLine2 = new Process();
                cmdLine2.StartInfo.FileName = "cmd.exe";
                cmdLine2.StartInfo.Arguments = unhideDrive;
                cmdLine2.Start();
            }
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A *.ini";
                Process cmdLine3 = new Process();
                cmdLine3.StartInfo.FileName = "cmd.exe";
                cmdLine3.StartInfo.Arguments = unhideDrive;
                cmdLine3.Start();
            }
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A thumbs.db & DEL /F /S /Q /A RECYCLER.exe";
                Process cmdLine4 = new Process();
                cmdLine4.StartInfo.FileName = "cmd.exe";
                cmdLine4.StartInfo.Arguments = unhideDrive;
                cmdLine4.Start();
            }
            if (driveletter == null || driveletter == "")
            {
                MessageBox.Show("Please Select a Drive Letter First");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A *.exe";
                Process cmdLine5 = new Process();
                cmdLine5.StartInfo.FileName = "cmd.exe";
                cmdLine5.StartInfo.Arguments = unhideDrive;
                cmdLine5.Start();
            }
            MessageBox.Show("All virus are Removed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string driveletter = DriveListCombo.Text;
            if (driveletter == null || driveletter == "" || driveletter == "C:\\")
            {
                MessageBox.Show("Please Select a Drive Letter First and Drive C cannot Be invoked");
            }
            else
            {
                string unhideDrive = DriveListCombo.Text;
                unhideDrive = unhideDrive[0].ToString();
                unhideDrive = "/c " + unhideDrive + ": & DEL /F /S /Q /A *.*";
                Process cmdLine = new Process();
                cmdLine.StartInfo.FileName = "cmd.exe";
                cmdLine.StartInfo.Arguments = unhideDrive;
                cmdLine.Start();
            }
            MessageBox.Show("Formte the Usb");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream("rinzler_restore_taskmanager.reg", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs1);
            writer.Write("Windows Registry Editor Version 5.00\r\n;Created by Sayem Chaklader\r\n[HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System] “DisableTaskMgr” =dword:00000000");
            writer.Close();
            string unhideDrive = "rinzler_restore_taskmanager.reg";
            Process cmdLine = new Process();
            cmdLine.StartInfo.FileName = "regedit";
            cmdLine.StartInfo.Arguments = unhideDrive;
            cmdLine.Start();

            FileStream fs2 = new FileStream("restore_registry.bat", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer1 = new StreamWriter(fs2);
            writer1.Write("echo Windows Registry Editor Version 5.00>Enable.reg\r\necho >>Enable.reg\r\necho [HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System]>>Enable.reg\r\necho \"DisableRegistryTools\"=dword:00000000>>Enable.reg\r\nregedit.exe /s Enable.reg\r\ndel /f Enable.reg\r\nexit");
            writer1.Close();
            string restore_registry = "/c restore_registry.bat";
            Process cmdLine1 = new Process();
            cmdLine1.StartInfo.FileName = "cmd.exe";
            cmdLine1.StartInfo.Arguments = restore_registry;
            cmdLine1.Start();

            FileStream fs3 = new FileStream("enable_folder_option.bat", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer2 = new StreamWriter(fs3);
            writer2.Write("echo Windows Registry Editor Version 5.00>Enable.reg\r\necho >>Enable.reg\r\necho [HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer]>>Enable.reg\r\necho \"NoFolderOptions\"=dword:000000000>>Enable.reg\r\nregedit.exe /s Enable.reg\r\ndel /f Enable.reg\r\nexit");
            writer2.Close();
            string folder_option = "/c enable_folder_option.bat";
            Process cmdLine2 = new Process();
            cmdLine2.StartInfo.FileName = "cmd.exe";
            cmdLine2.StartInfo.Arguments = folder_option;
            cmdLine2.Start();
            MessageBox.Show("Successfully Enabled Taskmanager & Registry & Folder option");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
