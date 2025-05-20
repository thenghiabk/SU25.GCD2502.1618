using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1618_GCD2502
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String hoTen = txtHoTen.Text;
            String tuoi = txtTuoi.Text;
            String diaChi = txtDiaChi.Text;
            String phong = cbbPhong.Text;
            String chucVu = ccbChucVu.Text;

            lblHoTen.Text = hoTen;
            lblTuoi.Text = tuoi;
            lblDiaChi.Text = diaChi;
            lblPhong.Text = phong;
            lblChucVu.Text = chucVu;

        }
    }
}
