using System;
using System.Text;

namespace Samples.css
{
    public partial class Forms : System.Web.UI.Page
    {
        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RadioButtonList2_Literal.Text = String.Format("Selected Item Changed: '{0}' ({1})",
                RadioButtonList2.SelectedItem.Text, RadioButtonList2.SelectedValue);
            RadioButtonList2_Alert.Visible = true;
        }

        protected void CheckBoxList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = this.CheckBoxList3.GetSelectedItems();
            if (selected == null || selected.Length == 0)
            {
                CheckBoxList3_Literal.Text = "No Items Checked";
            }
            else
            {
                StringBuilder text = new StringBuilder();
                text.AppendFormat("{0} Item{1} Checked<ul>", selected.Length, selected.Length == 1 ? "" : "s");
                foreach (var item in selected)
                {
                    text.AppendFormat("<li>'{0}' ({1})</li>", item.Text, item.Value);
                }
                text.Append("</ul>");
                CheckBoxList3_Literal.Text = text.ToString();
            }
            CheckBoxList3_Alert.Visible = true;
        }
    }
}