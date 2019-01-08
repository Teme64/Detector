using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detector
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //
            InitForm();
        }

        private void InitForm()
        {
            Font listFont;

            listFont = new Font("Consolas", 10.0F, FontStyle.Regular);
            lstProcesses.Font = listFont;
            //
            lblDetectVM.Text = "-";
            lblIsDebugger.Text = "-";
            lblDetectRegistryKey.Text = "-";
            lblDetectDrives.Text = "-";
            lblSystemDriveSize.Text = "-";
            lblDetectBIOSSerialNumber.Text = "-";
            lblDetectSystemModel.Text = "-";
        }

        private void cmdDetectVM_Click(object sender, EventArgs e)
        {
            libVM.libDetectVM oVM;

            lblDetectVM.Text = "No VM Detected";
            oVM = new libVM.libDetectVM();
            if(oVM.detectVMware())
            {
                lblDetectVM.Text = "VMware";
            }
            if(oVM.detectVirtualBox())
            {
                lblDetectVM.Text = "VirtualBox";
            }
        }

        private void cmdIsDebuggerAttached_Click(object sender, EventArgs e)
        {
            libVM.libDetectVM oVM;

            lblIsDebugger.Text = "No Debugger Detected";
            oVM = new libVM.libDetectVM();
            if (oVM.isDebuggerAttached())
            {
                lblIsDebugger.Text = "Debugger Attached";
            }
            if(oVM.detectDebugger())
            {
                lblIsDebugger.Text = "Debugger Running";
            }
        }

        private void cmdDetectRegistryKey_Click(object sender, EventArgs e)
        {
            libVM.libDetectVM oVM;

            lblDetectRegistryKey.Text = "No Registry Key Detected";
            oVM = new libVM.libDetectVM();
            if (oVM.detectVMRegistry())
            {
                lblDetectRegistryKey.Text = "Registry Key Detected";
            }
        }

        private void cmdDetectDrives_Click(object sender, EventArgs e)
        {
            libVM.libDetectVM oVM;

            lblDetectDrives.Text = "No Drive(s) Detected";
            oVM = new libVM.libDetectVM();
            if (oVM.detectVMDrive())
            {
                lblDetectDrives.Text = "Drive(s) Detected";
            }
        }

        private void cmdSystemDriveSize_Click(object sender, EventArgs e)
        {
            libVM.libDetectVM oVM;

            lblSystemDriveSize.Text = "System Drive Size Is Normal";
            oVM = new libVM.libDetectVM();
            if (oVM.isSmallSystemDrive())
            {
                lblSystemDriveSize.Text = "Small System Drive Size Detected";
            }
        }

        private void cmdListProcesses_Click(object sender, EventArgs e)
        {
            libVM.libDetectVM oVM;
            List<string> processNames;

            lstProcesses.Items.Clear();
            oVM = new libVM.libDetectVM();
            processNames = oVM.getProcessNames();
            foreach(string s in processNames)
            {
                lstProcesses.Items.Add(s);
            }
        }

        private void cmdAccessRights_Click(object sender, EventArgs e)
        {
            libVM.libDetectVM oVM;

            oVM = new libVM.libDetectVM();
            if (oVM.isAdminRights())
            {
                MessageBox.Show("User is admin", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User is standard user", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdDetectBIOSSerialNumber_Click(object sender, EventArgs e)
        {
            libVM.libDetectVM oVM;

            lblDetectBIOSSerialNumber.Text = "System Has BIOS S/N";
            oVM = new libVM.libDetectVM();
            if(!oVM.detectBIOSSerialNumber())
            {
                lblDetectBIOSSerialNumber.Text = "No BIOS S/N Detected";
            }
        }

        private void cmdDetectSystemModel_Click(object sender, EventArgs e)
        {
            libVM.libDetectVM oVM;

            lblDetectSystemModel.Text = "No System Model";
            oVM = new libVM.libDetectVM();
            lblDetectSystemModel.Text = oVM.DetectSystemModel();
        }
    }
}
