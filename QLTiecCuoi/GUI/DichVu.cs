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

namespace GUI
{
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            DichVu_BUS.Instance.Binding(cbTen);
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", cbTen.DataSource, "DonGia");
            txtDonGia.Enabled=false;
        }
    }
}
