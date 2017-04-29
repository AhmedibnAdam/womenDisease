using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace womenDisease
{
    class Class1
    {
        public static bool chkName(String str)
        {
            String Arabic = "د جحخهعغفقثصضشسيبلاتنمكطذظزوةىرؤءئ";
            for (int i = 0; i < str.Length; i++)
            {
                if (((str[i] <= 'Z' && str[i] >= 'A') || (str[i] <= 'z' && str[i] >= 'a') || str[i] == ' ' || Arabic.Contains(str[i])))
                    return false;
            }
            return true;
        }


        public static bool chkArabicName(String str)
        {
            String Arabic = "د جحخهعغفقثصضشسيبلاتنمكطذظزوةىرؤءئ";
            for (int i = 0; i < str.Length; i++)
            {
                if (! Arabic.Contains(str[i]))
                    return false;
            }
            return true;
        }
        
        public static bool chkNum(String str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (!((str[i] <= '9' && str[i] >= '0')))
                    return false;
            }
            return true;
        }

        public static bool chkEmpty(String str)
        {
            return !(str.Length > 0);
        }

    }
}
