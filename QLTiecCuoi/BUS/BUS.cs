using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class DichVu_BUS
    {
        private static DichVu_BUS instance;

        public static DichVu_BUS Instance 
        {
            get 
            {
                if (instance == null)
                    instance = new DichVu_BUS();
                return instance; 
            }
        }

        public void Binding(ComboBox data)
        {
            data.DataSource = DichVu_DAO.Instance.Binding();
            //data.DataSource = DichVu_DAO.Instance.Bingding();
            data.DisplayMember="Id";
        }
        //public void DataBingding(TextBox txt)
        //{
        //    txt.DataBindings.Add("Text", DichVu_DAO.Instance.DataBingding(), "DonGia");
        //}
    }
    public class DSSanh_BUS
    {
        private static DSSanh_BUS instance;
        public static DSSanh_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DSSanh_BUS();
                return instance;
            }
        }
        public void Load(DataGridView data)
        {
            data.DataSource = DSSanh_DAO.Instance.Load();
        }
    }
}
