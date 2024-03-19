using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class qlhoadontra : Form
    {
        public qlhoadontra()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void qlhoadontra_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var quyry = from a in data.hoadon_tras
                        join b in data.hoadon_thues on a.id_hoadon_thue equals b.id_hoadon_thue
                        select new
                        {
                            Mã_Hóa_Đơn_Trả=a.id_hoadon_tra,
                            Mã_Hóa_Đơn_Thuê = b.id_hoadon_thue,
                            Ngày_Trả=a.ngay_tra
                            
                        };

            txt_idhdthue.DataSource = data.hoadon_thues;
            txt_idhdthue.DisplayMember = "id_hoadon_thue";
            txt_idhdthue.ValueMember = "id_hoadon_thue";

            data_hdtra.DataSource = quyry.ToList();
            data_hdtra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_hdtra.Enabled = false;
        }

        private void data_hdtra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_hdtra.Rows[e.RowIndex];
            txt_hdtra.Text = row.Cells["Mã_Hóa_Đơn_Trả"].Value.ToString();
            txt_hdtra.Enabled = false;
            txt_idhdthue.Text = row.Cells["Mã_Hóa_Đơn_Thuê"].Value.ToString();
            txt_ngaytra.Text = row.Cells["Ngày_Trả"].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {

                hoadon_tra nk = new hoadon_tra();

                nk.id_hoadon_thue = Convert.ToInt32(txt_idhdthue.Text.ToString());
                nk.ngay_tra = Convert.ToDateTime(txt_ngaytra.Text.ToString());
                data.hoadon_tras.InsertOnSubmit(nk);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Thất Bại");
            }
            finally
            {
                var nk = data.hoadon_tras;
                data_hdtra.DataSource = nk;
                qlhoadontra_Load(sender, e);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                var nk1 = txt_hdtra.Text;
                hoadon_tra edit_nk = data.hoadon_tras.Where(o => o.id_hoadon_tra.Equals(nk1)).FirstOrDefault();
                edit_nk.id_hoadon_thue = Convert.ToInt32(txt_idhdthue.Text.ToString());
                edit_nk.ngay_tra = Convert.ToDateTime(txt_ngaytra.Text.ToString());


            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            finally
            {
                var nnk = data.hoadon_tras;
                data_hdtra.DataSource = nnk;
                data.SubmitChanges();
                qlhoadontra_Load(sender, e);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var nk2 = txt_hdtra.Text;
                hoadon_tra del_nk = data.hoadon_tras.Where(o => o.id_hoadon_tra.Equals(nk2)).FirstOrDefault();
                data.hoadon_tras.DeleteOnSubmit(del_nk);
                data.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại !");
            }
            finally
            {
                var nk3 = data.hoadon_tras;
                data_hdtra.DataSource = nk3;

                qlhoadontra_Load(sender, e);
                txt_hdtra.Text = "";
                txt_idhdthue.Text = "";
                txt_ngaytra.Text = "";
                txt_search.Text = "";

            }
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
            qlhoadontra_Load(sender, e);
            txt_hdtra.Text = "";
            txt_idhdthue.Text = "";
            txt_ngaytra.Text = "";
            txt_search.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var c = txt_search.Text;
            var quyry = from a in data.hoadon_tras
                        join b in data.hoadon_thues on a.id_hoadon_thue equals b.id_hoadon_thue
                        select new
                        {
                            Mã_Hóa_Đơn_Trả = a.id_hoadon_tra,
                            Mã_Hóa_Đơn_Thuê = b.id_hoadon_thue,
                            Ngày_Trả = a.ngay_tra

                        };

            var quyery2 = from k in quyry
                          where k.Mã_Hóa_Đơn_Trả == Convert.ToInt32(c)
                          select k;
            data_hdtra.DataSource = quyery2.ToList();
        }
    }
}
