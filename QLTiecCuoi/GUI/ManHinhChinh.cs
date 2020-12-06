using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            TiecCuoi tc = new TiecCuoi();
            ManHinhChinh_BUS.Instance.Add();
            this.Hide();
            DatTiec dattiec = new DatTiec();
            dattiec.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DsSanh ds = new DsSanh();
            ds.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DsTiecCuoi dsTiec = new DsTiecCuoi();
            dsTiec.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon hd = new HoaDon();
            hd.ShowDialog();
            this.Show();
        }
    }
}
