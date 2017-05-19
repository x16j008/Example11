using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            int Year = int.Parse(tbxYear.Text);

            if (Year % 4 != 0)
                lblResult.Text = "①平年です";
            else
            {
                if (Year % 100 == 0)
                {
                    if (Year % 400 == 0)
                        lblResult.Text = "②うるう年です";
                    else
                        lblResult.Text = "③平年です";
                }
                else
                    lblResult.Text = "④うるう年です";
            }
        }
    }
}
