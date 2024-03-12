using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string tmp = "";
            int money = 0;
            double discountRate = 1.0;
            string discountMethod = "";

            if (RadioButtonList1.SelectedItem != null)
            {
                discountRate = double.Parse(RadioButtonList1.SelectedValue);
                discountMethod = RadioButtonList1.SelectedItem.Text;
            }

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    tmp += item.Text + "<br>";
                    money += int.Parse(item.Value);
                }
            }

            int discountedMoney = (int)Math.Round(money * discountRate);

            Label1.Text = discountMethod + "<br>你點了：<br>" + tmp;
            Label1.Text += "總共 " + money.ToString() + "元 打折後 " + discountedMoney.ToString() + "元";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList1.Items)
            {
                item.Selected = false;
            }
            RadioButtonList1.ClearSelection();
            Label1.Text = "";
        }
    }
}
