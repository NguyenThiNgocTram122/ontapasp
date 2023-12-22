using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiThi
{
    public partial class Capnhat : System.Web.UI.Page

    {
        public static string tram = "Data Source=LAPTOP-00N9N4JN\\SQLEXPRESS;Initial Catalog=QL_SINHVIEN;Integrated Security=True";
        public static SqlConnection cn = new SqlConnection(tram);
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThi(); 
        }
        void HienThi()
        {
            try
            {
                string chuoiSQL = "SELECT * FROM tbl_Monhoc";
                SqlDataAdapter da = new SqlDataAdapter(chuoiSQL, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;

                GridView1.DataBind();
            }
            catch (Exception)
            {
                lbtthongbao.Text = "Lỗi kết nối";
            }
        }
        void ThucThi(string caulenh)
        {
            SqlCommand cm = new SqlCommand(caulenh, cn);
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
        }
        Boolean kiemtra(string caulenh)
        {
            SqlDataAdapter sql = new SqlDataAdapter(caulenh, cn);
            DataTable data = new DataTable();
            sql.Fill(data);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            else { return false; }
        }
        protected void btnthem_Click(object sender, EventArgs e)
        {
            txtmamonhoc.Text = "";
            txttenmonhoc.Text = "";
        }
        protected void btnluu_Click(object sender, EventArgs e)
        {
            string khaibao = "select * from tbl_monhoc where MaMH = '" + txtmamonhoc.Text + "' or TenMH = N'" + txttenmonhoc.Text + "'";

            if (kiemtra(khaibao))
            {

                lbtthongbao.Text = "Tên môn học đã tồn tại";
            }
            else
            {

                string them = "insert into tbl_monhoc values ('" + txtmamonhoc.Text + "' , N'" + txttenmonhoc.Text + "')";
                ThucThi(them);
                HienThi();
            }
        }
        protected void btnsua_Click(object sender, EventArgs e)
        {
            string sua = "update tbl_monhoc set TenMH = N'" + txttenmonhoc.Text + "' where MaMH = '" + txtmamonhoc.Text + "'";
            ThucThi(sua);
            HienThi();
        }
        protected void btnxoa_Click(object sender, EventArgs e)
        {
            string truyen = "delete tbl_monhoc where MaMH = '" + txtmamonhoc.Text + "'";
            ThucThi(truyen);
            HienThi();
            txtmamonhoc.Text = "";
            txttenmonhoc.Text = "";
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ngoctram = "select * from tbl_monhoc";
            SqlDataAdapter sqldata = new SqlDataAdapter(ngoctram, cn);
            DataTable dttable = new DataTable();
            sqldata.Fill(dttable);
            int dong = GridView1.SelectedIndex;
            int page = GridView1.PageIndex;
            txtmamonhoc.Text = dttable.Rows[page * 3 + dong][0].ToString();
            txttenmonhoc.Text = dttable.Rows[page * 3 + dong][1].ToString();
        }
    }
}