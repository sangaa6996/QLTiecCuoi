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
            DichVu_BUS.Instance.Load(dgvDichVu);
        }
        public void Add()
        {
            string ID_DV = cbTen.Text;
            Nullable<int> SL = Int32.Parse(txtSL.Text);
            CTTIECCUOI ct = new CTTIECCUOI();
            ct.ID_DichVu = ID_DV;
            ct.SoLuongDV = SL;
            DichVu_BUS.Instance.Add(ct);
        }
    }
}
