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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        
        private void timeProgres_Tick(object sender, EventArgs e)
        {
            pnlProgress.Width += 3;
            if (pnlProgress.Width >= 390)
            {
                timeProgres.Stop();
                this.Hide();
            }
        }
    }
}
