using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace Information_Accumulate_From_USB_Drive
{
    public partial class IA_USB : Form
    {
        private DriveDetector driveDetector = null;
        public IA_USB()
        {
            InitializeComponent();
            driveDetector = new DriveDetector();
            driveDetector.DeviceArrived += new DriveDetectorEventHandler(OnDriveArrived);
            driveDetector.DeviceRemoved += new DriveDetectorEventHandler(OnDriveRemoved);
        }
        private void OnDriveArrived(object sender, DriveDetectorEventArgs e)
        {
            // Report the event in the listbox.
            // e.Drive is the drive letter for the device which just arrived, e.g. "E:\\"
            string s = "Drive arrived " + e.Drive;
            label2.Text = s;
            Open_USB_Safely.Text = "Open USB Safely";
                e.HookQueryRemove = true;
        }

        // Called by DriveDetector after removable device has been unpluged 
        private void OnDriveRemoved(object sender, DriveDetectorEventArgs e)
        {
            // TODO: do clean up here, etc. Letter of the removed drive is in e.Drive;

            // Just add report to the listbox
            string s = "Drive removed " + e.Drive;
            label2.Text=s;
            Open_USB_Safely.Text = "Remove USB Safely";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var form3 = new Folder_Lock();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form4 = new Manual_Virus_Remover();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IA_USB_Load(object sender, EventArgs e)
        {
            USB_DRIVE_PROTECTED.Visible = false;
            Thread.Text = "No Thread Found";
            Open_USB_Safely.Visible = true;
            button6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\Thiyan_Sri\Documents\Visual Studio 2010\Projects\Information Accumulate From USB Drive\Information Accumulate From USB Drive\USB Monitor.exe";
            Process.Start(start);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\Thiyan_Sri\Documents\Visual Studio 2010\Projects\Information Accumulate From USB Drive\Information Accumulate From USB Drive\Usb locker.exe";
            start.Verb = "runas";
            Process.Start(start);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            USB_DRIVE_PROTECTED.Visible = true;
            Thread.Visible = false;
            Open_USB_Safely.Visible = false;
            USB_DRIVE_PROTECTED.Text = "USB FLASH DRIVE IS PROTECTED";
            button6.Visible = true;
        }
    }
           
}
