using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.IO;

namespace SPKOnlineOLPContest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer=null;
            writer = File.AppendText("D:\\spkOnl.txt");
            try
            {

                ProcessStartInfo info = new ProcessStartInfo("D:\\TestApp.exe");
                Process p = new Process();
                p.StartInfo = info;

                bool kq = p.Start();
                if (p.WaitForExit(3000))
                {
                    Response.Write("Run successed quick");
                    writer.WriteLine("Run successed quick");
                }
                else
                {
                    p.Kill();
                    writer.WriteLine("Run successed. Too Long");
                }
            }
            catch (Exception ex)
            {
                writer.Write("<b><font color='red'>" + ex.Message + "</font></b>");
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}