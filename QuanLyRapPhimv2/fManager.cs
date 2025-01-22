using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhimv2
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();


        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thôngTinNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuLieu f = new DuLieu();
            f.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuLieu f = new DuLieu();
            f.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fManager_Load(object sender, EventArgs e)
        {

        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngSuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            f.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.ShowDialog();
        }
    }
}
