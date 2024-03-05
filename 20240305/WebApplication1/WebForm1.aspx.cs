using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int[] data = new int[45];
        Random rand=new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            for (int i = 0; i < 45; i++)
            {
                data[i] = rand.Next(30, 100);
            }
            int counter = 0;
            foreach (int k in data)
            {
                Label1.Text += k + " ";
                counter++;
                if (counter % 15 == 0)
                {
                    Label1.Text += "<br />";
                }
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Array.Sort(data);
            Array.Reverse(data);

            int passMark = 60;
            int passNo = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= passMark)
                {
                    passNo++;
                }
            }

            double passRatio = (double)passNo / data.Length * 100;
            double average = data.Average();

            int[] top3 = data.Take(3).ToArray();

            string result = $"PassNo={passNo} Pass Ratio={passRatio:0}% <br />" +
                            $"Average={average:0.0} <br />" +
                            $"Top 3 >> {string.Join(", ", top3)}";

            Label2.Text = result;
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
        }
    }
}