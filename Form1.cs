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
using System.Runtime.InteropServices;
using System.Net;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web;
using System.Management;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string r = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
            {
                ManagementObjectCollection information = searcher.Get();
                if (information != null)
                {
                    foreach (ManagementObject obj in information)
                    {
                        r = obj["Caption"].ToString() + " - " + obj["OSArchitecture"].ToString();
                    }
                }
                r = r.Replace("NT 5.1.2600", "XP");
                r = r.Replace("NT 5.2.3790", "Server 2003");
                lblwin.Text = r;
            }
            this.ControlBox = false;
            
            //tìm khu vực cài bkav
            //tìm khu vực programfile
            string programFilesX86Path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            //đường dẫn foilder cài dặt
            //bản pro
            string setuppart = programFilesX86Path+"\\BkavPro";
            //string setuppart1 = programFilesX86Path + "\\BKav";
                //kiểm tra đường dẫn tồn tại
                if (Directory.Exists(setuppart) ) 
                {
                    //tìm xem file có tồn tại không
                    string fileexist = setuppart + "\\BkavUnst.exe";
                    if (File.Exists(fileexist))
                    {
                        txtinsdrect.Text = fileexist;
                        btnunin.Enabled = true;
                        btnunin.PerformClick();
                    }
                    else
                    {
                        if(Directory.Exists(setuppart))
                        {
                            txtinsdrect.Text = "Bạn đã gỡ BKAV Pro. Vui lòng bấm nút Delete Leftover để xoá thư mục còn xót";
                            btnremove.Enabled= true;
                            //btnremove.PerformClick();
                        }
                    }
                 }
                else
                {
                    MessageBox.Show("Bạn đang không dùng BKAV!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
                }
        }

        private void btnunin_Click(object sender, EventArgs e)
        {
                string programFilesX86Path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                string setuppart = programFilesX86Path + "\\BkavPro";
                string fileexist = setuppart + "\\BkavUnst.exe";
            
                    Process.Start(fileexist);
                    btnunin.Enabled=false;

        }
        private void btnremove_Click(object sender, EventArgs e)
        {
            string programFilesX86Path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string setuppart = programFilesX86Path + "\\BkavPro";
            string setuppart1 = programFilesX86Path + "\\Bkav Corporation";


            // Hợp nhất hai lệnh RD thành một chuỗi duy nhất, sử dụng '&&' để đảm bảo 
            // lệnh thứ hai chỉ chạy nếu lệnh thứ nhất thành công (hoặc '&' để chạy cả hai)
            string combinedArguments = $"/C rd /s /q \"{setuppart}\" && rd /s /q \"{setuppart1}\"";

            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    // Sử dụng chuỗi đối số đã hợp nhất
                    Arguments = combinedArguments,
                    // Chỉ cần một lần yêu cầu quyền Admin
                    Verb = "runas",
                    UseShellExecute = true,
                    CreateNoWindow = true
                };

                // Chỉ khởi động MỘT tiến trình
                Process.Start(procStartInfo);
                Application.Exit();
                //đợi đến xong rồi tự thoát
                // Thông báo cho người dùng
                // Nếu bạn đang dùng WinForms, bạn có thể uncomment dòng này:
                // MessageBox.Show("Yêu cầu xóa các thư mục Bkav đã được gửi. Vui lòng chấp nhận cửa sổ UAC.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Thường xảy ra khi người dùng hủy bỏ cửa sổ UAC
                 MessageBox.Show($"Lỗi khi khởi tạo tiến trình xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblwin_Click(object sender, EventArgs e)
        {

        }
    }
}
