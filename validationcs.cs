using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Text;

namespace womenDisease
{
    class validation
    {
        public static void letter(object sender, KeyPressEventArgs e, Form frm)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                int VisibleTime = 1500;  //in milliseconds
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;



                tt.Show(" الرجاء ادخال حروف", frm, ((Control)sender).Location.X, ((Control)sender).Location.Y , VisibleTime);
            }


        }


        public static void integer(object sender, KeyPressEventArgs e, Form frm)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                int VisibleTime = 1500;  //in milliseconds
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;

                tt.Show(" الرجاء ادخال أرقام", frm, ((Control)sender).Location.X , ((Control)sender).Location.Y, VisibleTime);
            }
			
        }


         public static void Float(object sender, KeyPressEventArgs e, Form frm)
         {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
             {
                 e.Handled = true;
                 int VisibleTime = 1500;  //in milliseconds
                 ToolTip tt = new ToolTip();
                 tt.IsBalloon = true;

                 tt.Show(" الرجاء ادخال أرقام ", frm, ((Control)sender).Location.X , ((Control)sender).Location.Y, VisibleTime);

             }

             // only allow one decimal point
             if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
             {
                 e.Handled = true;
                 int VisibleTime = 1500;  //in milliseconds
                 ToolTip tt = new ToolTip();
                 tt.IsBalloon = true;


                 tt.Show(" مسموح بعلامة عشرية واحدة", frm, ((Control)sender).Location.X , ((Control)sender).Location.Y, VisibleTime);

             }
         }
    }
}
