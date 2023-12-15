using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblAdd.Text = "";
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtAdd1.Text == "" || txtAdd2.Text == "")
            {
                lblAdd.Text = "Ahh Lazy Put some digit!";
            }else
            {
                Loading load = new Loading();
                load.Show();
                lblAdd.Text = txtAdd1.Text + txtAdd2.Text;
            }
            
        }

    }
}
