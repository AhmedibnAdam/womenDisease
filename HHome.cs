using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace womenDisease
{
    public partial class HHome : Form
    {
        public HHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            new Home().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            new doctor_orders().Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            new أذن_دخول_مريضة().Show();
        }

        private void HHome_Load(object sender, EventArgs e)
        {

        }
    }
}
