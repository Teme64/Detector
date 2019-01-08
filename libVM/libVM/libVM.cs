using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Security.Principal;
using Microsoft.Win32;

namespace libVM
{
    public class libDetectVM
    {
        private List<string> _vmwareMod;
        private List<string> _vboxMod;
        private List<string> _debugMod;

        public bool detectBIOSSerialNumber()
        {
            ManagementObjectSearcher searcher;

            try
            {
                searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if(queryObj["SerialNumber"] == null)
                    {
                        return false;
                    }
                    else if (queryObj["SerialNumber"].ToString().Length < 2)
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch (ManagementException)
            {
                //MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
            return true;
        }

        public string DetectSystemModel()
        {
            ManagementObjectSearcher searcher;

            try
            {
                searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    return queryObj["Model"].ToString();
                }
            }
            catch (ManagementException)
            {
                //MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
            return "";
        }

        private long GetSysDriveSize()
        {
            string sysDriveLetter;
            Hashtable envVars;

            envVars = (Hashtable)Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine);
            try
            { 
                sysDriveLetter = envVars["WinDir"].ToString().ToUpper().Substring(0, 1);
                sysDriveLetter += @":\";
            }
            catch
            {
                sysDriveLetter = @"C:\";
            }
            foreach(DriveInfo dri in DriveInfo.GetDrives())
            {
                if(dri.Name.ToUpper() == sysDriveLetter)
                {
                    return (dri.TotalSize / (1024 * 1024 * 1024)); // To GBs
                }
            }
            return -1;
        }

        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public bool detectVMDrive()
        {
            DriveInfo[] allDrives;

            allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if(d.DriveType == DriveType.CDRom && d.IsReady)
                {
                    try
                    {
                        if (d.VolumeLabel == "VMware Tools")
                        {
                            return true;
                        }
                    }
                    catch(System.IO.IOException)
                    {
                        continue;
                    }
                }
            }
            return false;
        }

        //public bool detectSharedFolder()
        //{
        //    DriveInfo[] allDrives;

        //    allDrives = DriveInfo.GetDrives();
        //    foreach (DriveInfo d in allDrives)
        //    {
        //        if (d.DriveType == DriveType.CDRom && d.IsReady)
        //        {
        //            try
        //            {
        //                if (d.VolumeLabel == "VMware Tools")
        //                {
        //                    return true;
        //                }
        //            }
        //            catch (System.IO.IOException)
        //            {
        //                continue;
        //            }
        //        }
        //    }
        //    return false;
        //}

        public List<string> getProcessNames()
        {
            Process[] processArr;
            List<string> procNames = new List<string>();

            processArr = Process.GetProcesses();
            foreach(Process p in processArr)
            {
                procNames.Add(p.ProcessName);
            }
            return procNames;
        }

        public bool detectVMware()
        {
            List<string> processNames;

            _vmwareMod = new List<string>();
            _vmwareMod.Add("vmtoolsd");
            _vmwareMod.Add("vmnat");
            _vmwareMod.Add("vmnetdhcp");
            _vmwareMod.Add("vmware-authd");
            _vmwareMod.Add("vmplayer");
            _vmwareMod.Add("vmware-vmx");
            processNames = getProcessNames();
            foreach (string s in processNames)
            {
                if (_vmwareMod.Contains(s))
                {
                    return true;
                }
            }
            return false;
        }

        public bool detectVirtualBox()
        {
            List<string> processNames;

            _vboxMod = new List<string>();
            _vboxMod.Add("VBoxTray");
            _vboxMod.Add("VBoxService");
            processNames = getProcessNames();
            foreach(string s in processNames)
            {
                if(_vboxMod.Contains(s))
                {
                    return true;
                }
            }
            return false;
        }

        // HKLM/Software/Microsoft/Windows/CurrentVersion/Run/VBoxTray key, value: C:\Windows\System32\VBoxTray.exe
        public bool detectVMRegistry()
        {
            RegistryKey rk;
            string[] names;

            try
            { 
                rk = Registry.LocalMachine.OpenSubKey(@"Software/Microsoft/Windows/CurrentVersion/Run");
                names = rk.GetValueNames();
            }
            catch
            {
                return false;
            }
            foreach (string s in names)
            {
                if(s == "VBoxTray")
                {
                    return true;
                }
            }
            //
            return false;
        }

        public bool isDebuggerAttached()
        {
            return Debugger.IsAttached;
        }

        public bool detectDebugger()
        {
            List<string> processNames;

            _debugMod = new List<string>();
            _debugMod.Add("ida64");
            _debugMod.Add("x64dbg");
            _debugMod.Add("ollydbg");
            processNames = getProcessNames();
            foreach (string s in processNames)
            {
                if (_debugMod.Contains(s))
                {
                    return true;
                }
            }
            return false;
        }

        public bool isAdminRights()
        {
            return IsAdministrator();
        }

        public bool isSmallSystemDrive()
        {
            long size;

            size = GetSysDriveSize();
            if (size >= 0 && size < 128)
            {
                return true;
            }
            return false;
        }
    }
}
