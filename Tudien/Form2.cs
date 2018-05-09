using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tudien.BLL;
using Microsoft.Win32;

namespace Tudien
{
    public partial class Form2 : Form
    {
        public khoiTaoGame khoiTao;
        public int doDem = 0;
        public static int diem = 0;
        public int time = 100;
        public Form2()
        {
            InitializeComponent();

            //RegistryKey rkApp = Registry.CurrentUser.OpenSubKey
            //         ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            //if(rkApp.GetValue("Myapp") == null)
            //{
            //    rkApp.SetValue("Myapp", Application.ExecutablePath.ToString());
            //}
        }
        
        private void btDapAn1_Click(object sender, EventArgs e)
        {
            if(btDapAn1.Text.ToString() == khoiTao.dung)
            {
                diem++;
                //MessageBox.Show(khoiTao.diem.ToString());
                khoiTao.HienThi(tbCauHoi, btDapAn1, btDapAn2, btDapAn3, btDapAn4);
                label2.Text = diem.ToString();
                hieuUngAnhSangDung();
            }
            else
            {
                khoiTao.HienThi(tbCauHoi, btDapAn1, btDapAn2, btDapAn3, btDapAn4);
                hieuUngAnhSangSai();
            }
        }

        private void btDapAn2_Click(object sender, EventArgs e)
        {
            if (btDapAn2.Text.ToString() == khoiTao.dung)
            {
                diem++;
                //MessageBox.Show(khoiTao.diem.ToString());
                khoiTao.HienThi(tbCauHoi, btDapAn1, btDapAn2, btDapAn3, btDapAn4);
                label2.Text = diem.ToString();
                hieuUngAnhSangDung();
            }
            else
            {
                khoiTao.HienThi(tbCauHoi, btDapAn1, btDapAn2, btDapAn3, btDapAn4);
                hieuUngAnhSangSai();
            }
        }

        private void btDapAn3_Click(object sender, EventArgs e)
        {
            if (btDapAn3.Text.ToString() == khoiTao.dung)
            {
                diem++;
                //MessageBox.Show(khoiTao.diem.ToString());
                khoiTao.HienThi(tbCauHoi, btDapAn1, btDapAn2, btDapAn3, btDapAn4);
                label2.Text = diem.ToString();
                hieuUngAnhSangDung();
            }
            else
            {
                khoiTao.HienThi(tbCauHoi, btDapAn1, btDapAn2, btDapAn3, btDapAn4);
                hieuUngAnhSangSai();
            }
        }

        private void btDapAn4_Click(object sender, EventArgs e)
        {
            if (btDapAn4.Text.ToString() == khoiTao.dung)
            {
                diem++;
                //MessageBox.Show(khoiTao.diem.ToString());
                khoiTao.HienThi(tbCauHoi, btDapAn1, btDapAn2, btDapAn3, btDapAn4);
                label2.Text = diem.ToString();
                hieuUngAnhSangDung();
            }
            else
            {
                khoiTao.HienThi(tbCauHoi, btDapAn1, btDapAn2, btDapAn3, btDapAn4);
                hieuUngAnhSangSai();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnSetup.Enabled = false;
            khoiTao = new khoiTaoGame();
            khoiTao.doiViTri();
            khoiTao.HienThi(tbCauHoi, btDapAn1, btDapAn2, btDapAn3, btDapAn4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = time.ToString();
            if(time == 0)
            {
                timer1.Stop();

                bool result = HoiLamTiep();
                while (!result)
                {
                    result = HoiLamTiep();
                }
                

                time = 100;
            }
            if(diem == 100)
            {
                timer1.Stop();
                MessageBox.Show("Chúc mừng bạn đã đạt được 100 lần làm đúng");
                //diem = 0;
                
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Tudien.Form1();
            frm.Show();
        }
        private void hieuUngAnhSangDung()
        {
            label3.BackColor = Color.LimeGreen;
        }
        private void hieuUngAnhSangSai()
        {
            label3.BackColor = Color.Red;
        }
     
        private bool HoiLamTiep()
        {
            string message = "Không đủ 100 điểm, ấn ok để làm lại";
            string caption = "Luyện từ !";
            var result = MessageBox.Show(message,caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                return false;
            }
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(diem != 100)
            {
                MessageBox.Show("Bạn cần cố gắng hơn chưa đủ 100 đâu");
                e.Cancel = true;
            }
        }
    }
}
