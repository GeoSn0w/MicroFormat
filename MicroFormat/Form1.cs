//MicroFormat Tool
//by GeoSn0w (@FCE365)
//08/08/2018
//This is provided "as-is". No further guarantee or support should be expected or will be given.
//USE AT YOUR OWN RISK!
//I AM NOT LIABLE FOR ANY DATA LOSS / ISSUES THAT MAY BE CAUSED BY THE USAGE OF THIS SOFTWARE.
//PLEASE CREDIT WHERE CREDIT IS DUE!

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MicroFormat
{
    public partial class Form1 : Form
    {
        //DLL IMPORTS
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        //
        static extern bool GetVolumeInformation(string Volume, StringBuilder VolumeName,
        uint VolumeNameSize, out uint volume_serialber, out uint volume_serialberLength,
        out uint flags, StringBuilder fs, uint fs_size);
        //Device States
        private const int WM_DEVICECHANGE = 0x0219;
        private const int DBT_DEVTYP_VOLUME = 0x00000002;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEQUERYREMOVE = 0x8001;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        //Format variables
        string drive_to_prospect = "";
        bool RulesSetEnforcement = false;
        bool isLocked = false;
        bool isDoneQuerying = false;
        string drive;
        string NewFileSystem;
        string NewVolumeLabel;
        bool isQuick = false;
        int clusterSizet;
        public Form1()
        {
            InitializeComponent();
            if (DetectMountedVolumes() == 0)
            {
                evLog.Text = evLog.Text + "Welcome to MicroFormat\nSuccessfully detected mounted volumes.\n";
            }
        }

        private void AppExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewFileSystem = "NTFS";
            NewVolumeLabel = "CHANGE ME";
            isQuick = true;
            getDriveLetter();
        }
        private long getVolumeFreeSpace(string whom)
        {
            foreach (DriveInfo volume in DriveInfo.GetDrives())
            {
                if (volume.IsReady && volume.Name == whom)
                {
                    return volume.TotalFreeSpace;
                }
            }
            return -1;
        }
        private long getVolumeTotalSize(string whom)
        {
            foreach (DriveInfo volume in DriveInfo.GetDrives())
            {
                if (volume.IsReady && volume.Name == whom)
                {
                    return volume.TotalSize;
                }
            }
            return -1;
        }
        private int DetectMountedVolumes()
        {
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                drives_list_cbox.Items.Clear();
                isDoneQuerying = false;
                foreach (DriveInfo drive in allDrives)
                {
                    if (drive.IsReady == true)
                    {
                        string devlabel;
                        string ko = drive.VolumeLabel;
                        string dt = Convert.ToString(drive.DriveType);
                        if (drive.VolumeLabel != "")
                        {
                            devlabel = drive.VolumeLabel;
                        }
                        else {
                            devlabel = "Removable Device";
                        }
                        drives_list_cbox.SelectedIndex = drives_list_cbox.Items.Add(drive.Name + " (" + devlabel + ")");
                    }

                }
                isDoneQuerying = true;
                return 0;
            }
            catch {
                MessageBox.Show("MicroFormat was unable to detect drive info!", "MicroFormat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        //Mad props to https://gist.github.com/bitlimakina/9421370

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if ((message.Msg != WM_DEVICECHANGE) || (message.LParam == IntPtr.Zero))
                return;

            DEV_BROADCAST_VOLUME volume = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(message.LParam, typeof(DEV_BROADCAST_VOLUME));

            if (volume.dbcv_devicetype == DBT_DEVTYP_VOLUME)
            {
                switch (message.WParam.ToInt32())
                {
                    // New device inserted...
                    case DBT_DEVICEARRIVAL:
                        DetectMountedVolumes();
                        break;

                    // Device Removed.
                    case DBT_DEVICEREMOVECOMPLETE:
                        DetectMountedVolumes();     //Refresh the list of active devices in MicroFormat
                        break;
                }
            }
        }

        private string ToDriveName(int mask)
        {
            int offset = 0;
            while ((offset < 26) && ((mask & 0x00000001) == 0))
            {
                mask = mask >> 1;
                offset++;
            }

            if (offset < 26)
                return string.Format("{0}:", Convert.ToChar(Convert.ToInt32('A') + offset));

            return "?";
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct DEV_BROADCAST_VOLUME
        {
            public int dbcv_size;
            public int dbcv_devicetype;
            public int dbcv_reserved;
            public int dbcv_unitmask;
        }

        private void doFormatNow_Click(object sender, EventArgs e)
        {
            DialogResult safetyCheck = MessageBox.Show("WARNING!\nALL YOUR DATA WILL BE DESTROYED! DO YOU REALLY WANT TO CONTINUE? THIS CANNOT BE UNDONE!", "WAIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); ;
            if (safetyCheck == DialogResult.Yes)
            {
                uint volume_serial, volume_serialLength, flags;
                StringBuilder volumename = new StringBuilder(256);
                StringBuilder file_system_arch = new StringBuilder(256);
                bool bdata = GetVolumeInformation(drive_to_prospect, volumename,
                (uint)volumename.Capacity - 1, out volume_serial, out volume_serialLength,
                out flags, file_system_arch, (uint)file_system_arch.Capacity - 1);

                if (bdata)
                {
                    evLog.Text = evLog.Text + "Selected Volume: " + drive_to_prospect + "\n";
                    evLog.Text = evLog.Text + "Volume Serial Number: " +
                    volume_serial.ToString() + " \n";
                    if (volumename != null)
                    {
                        evLog.Text = evLog.Text + "Current Volume Label: " + volumename.ToString() + " \n";
                    }
                    if (file_system_arch != null)
                    {
                        evLog.Text = evLog.Text + "Current Volume File System: " + file_system_arch.ToString() + " \n";
                    }
                }
                switch (FS_CBOX.SelectedIndex)
                {
                    case 0:
                        NewFileSystem = "NTFS";
                        isQuick = true;
                        clusterSizet = 8192;
                        break;
                    case 1:
                        NewFileSystem = "FAT32";
                        isQuick = true;
                        clusterSizet = 4096;
                        break;
                    case 2:
                        NewFileSystem = "NTFS";
                        isQuick = false;
                        clusterSizet = 8192;
                        break;
                    case 3:
                        NewFileSystem = "FAT32";
                        clusterSizet = 4096;
                        isQuick = false;
                        break;

                }
                if (isLocked)
                {
                    evLog.Text = evLog.Text + "Cowardly refusing to format the Windows Volume for your safety.\n";
                }
                else
                {
                    if (VolumeName.Text != "")
                    {
                        NewVolumeLabel = VolumeName.Text;
                    }
                    else
                    {
                        NewVolumeLabel = "NEW VOLUME"; //Fail safe
                    }
                    evLog.Text = evLog.Text + "Now formatting " + drive_to_prospect + "\n";
                    yeeFormatThis.RunWorkerAsync();
                }
            }
        }
        public static bool FormatDrive(string driveLetter, string NewFileSystem, bool quickFormat, int clusterSize, string newLabel = "")
        {
            try {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"select * from Win32_Volume WHERE DriveLetter = '" + driveLetter + "'");
            foreach (ManagementObject volume in searcher.Get())
            {
                volume.InvokeMethod("Format", new object[] {
                    NewFileSystem,
                    quickFormat,
                    clusterSize,
                    newLabel,
                    });
            }
            return true;
            } catch (Exception ex){
               MessageBox.Show("Could not format the drive. Something went wrong.","Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
            }
        }
        private void drives_list_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDriveLetter();
        }
        private void getDriveLetter() {
            if (isDoneQuerying)
            {
                string current_dev = "";
                current_dev = drives_list_cbox.SelectedItem.ToString();
                string drive_letter = current_dev[0].ToString();
                drive = drive_letter + ":";
                drive_to_prospect = drive_letter + ":\\";
                if (drive_to_prospect == Path.GetPathRoot(Environment.SystemDirectory))
                {
                    isLocked = true; //Sanity check to prevent accidental formating of the Windows drive.
                }
                else
                {
                    isLocked = false;
                }
            }
        }
        private void yeeFormatThis_DoWork(object sender, DoWorkEventArgs e)
        {
            doFormatNow.Invoke((MethodInvoker)delegate
            {
                doFormatNow.Text = "Formatting...";
            });
                if (FormatDrive(drive, NewFileSystem, isQuick, clusterSizet, NewVolumeLabel))
            {
                    evLog.Invoke((MethodInvoker)delegate { 
                    evLog.Text = evLog.Text + "SUCCESSFULLY FORMATED DRIVE " + drive_to_prospect;
                    DetectMountedVolumes(); //To update the new Volume Label
                    evLog.Text = evLog.Text + "\nNew Volume Label: " + NewVolumeLabel;
                    evLog.Text = evLog.Text + "\nNew File System: " + NewFileSystem;
                    evLog.Text = evLog.Text + "\nVolume Capacity: " + getVolumeTotalSize(drive + "\\") + " bytes";
                    evLog.Text = evLog.Text + "\nVolume Available Free Space: " + getVolumeFreeSpace(drive+"\\") + " bytes\n";
                    System.Media.SystemSounds.Hand.Play();
                    });
            }
            else
            {
                evLog.Invoke((MethodInvoker)delegate {
                    evLog.ForeColor = Color.Red;
                    evLog.Text = evLog.Text + "FAILED TO FORMAT THE DRIVE\n";
                    System.Media.SystemSounds.Beep.Play();
                });
            }
        }

        private void yeeFormatThis_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            doFormatNow.Invoke((MethodInvoker)delegate
            {
                doFormatNow.Text = "Format Drive";
            });
        }

        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Allows the form to be moved on MouseDown events.
            }
        }

        private void info_about_btn_Click(object sender, EventArgs e)
        {
            //Vanity :P
            MessageBox.Show("MicroFormat Tool\nBy GeoSn0w(@FCe365)\n\nSpecial Thanks to https://www.flaticon.com/authors/those-icons for the HDD icon used in the program.\nAlso special thanks to bitlimakina on Github for his USB Detection code.\n\nThis software is provided AS-IS with no further guarantee or support. I am not liable for any damages to your data, computer or anything else that may result from using this tool.\n\nUSE AT YOUR OWN RISK!\n\nBy using this software you agree with all these.\nBLAH BLAH I am not a lawyer.\n", "Credits & Stuff", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FS_CBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The Volume Label thingie may look simple but it is not.
            // NTFS supports up to 32 characters max but no tabs.
            // Fat32 supports up to 11 characters max and it cannot contain "* ? . , ; : / \ | + = < > [ ]" or any tabs.
            // We have to adjust the textbox for that to prevent errors.

            if (FS_CBOX.SelectedIndex == 0 || FS_CBOX.SelectedIndex == 2) //NTFS
            {
                VolumeName.MaxLength = 32;
                RulesSetEnforcement = false;
                VolumeName.Text = "New Volume";
            } else if (FS_CBOX.SelectedIndex == 1 || FS_CBOX.SelectedIndex == 3)
            {
                VolumeName.MaxLength = 11;
                RulesSetEnforcement = true;
                VolumeName.Text = "New Volume";
            } 
        }
   
        private void VolumeName_TextChanged(object sender, EventArgs e)
        {
            if (RulesSetEnforcement)
            {
                var regex = new Regex(@"[^a-zA-Z0-9\s]");
                if (regex.IsMatch(VolumeName.Text.ToString()))
                {
                    VolumeName.Text = VolumeName.Text.Remove(VolumeName.Text.Length - 1);
                    MessageBox.Show("FAT32 Volume Labels cannot be longer than 11 characters and they cannot contain * ? . , ; : / \\ | + = < > [ ]!", "Wait a minute...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void vanity_link_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/FCE365");
        }
    }
}
