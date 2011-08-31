using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

namespace SPKOnlineOLPContest
{
    public partial class DanhSachBai : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (int doKho in Enum.GetValues(typeof(DoKho)))
                {
                    drDoKho.Items.Add(new ListItem(Enum.GetName(typeof(DoKho), doKho), doKho.ToString()));
                }
                IBaiDA baiDA = Setting.DaFactory.GetBaiDA();
                //IBaiDA baiDA = new DataAccess.InMemory.BaiDA();
                List<Bai> dsBai = baiDA.LayTatCa();
                GridView1.DataSource = dsBai;
                DataBind(); 
            }
        }
        
        protected void btnDoKho_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = Setting.DaFactory.GetBaiDA().LayTheoDoKho(((DoKho)Enum.Parse(typeof(DoKho), drDoKho.SelectedItem.Value, true)));
            DataBind();
        }
        
    }
}