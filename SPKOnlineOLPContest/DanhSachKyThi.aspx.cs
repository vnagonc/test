using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

namespace SPKOnlineOLPContest
{
    public partial class DanhSachKyThi : System.Web.UI.Page
    {
        IKyThiDA ktDA = Setting.DaFactory.GetKyThiDA();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                ListItem item;
                foreach (KyThi kt in ktDA.LayTatCa())
                {
                    item = new ListItem(kt.TenKyThi, kt.ID.ToString());
                    drID.Items.Add(item);
                }
                grvKyThi.DataSource = ktDA.LayTatCa();
                DataBind();
            }
        }

        protected void btnLayTheoMa_Click(object sender, EventArgs e)
        {
            int selectedMakyThi = int.Parse(drID.SelectedValue);
            KyThi kt= ktDA.LayTheoMa(selectedMakyThi);
            Response.Write("<b>Bạn vừa chọn kỳ thi: " + kt.TenKyThi+"</b><br>");
        }        
    }
}