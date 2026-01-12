using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loopie_Helper_GUI
{
    public partial class FormPlaceholder1 : Form
    {
        public FormPlaceholder1()
        {
            InitializeComponent();
        }

        private void picStatsClose_MouseEnter(object sender, EventArgs e)
        {
            picStatsClose.BackColor = Color.FromArgb(154, 236, 153);
        }

        private void picStatsClose_MouseLeave(object sender, EventArgs e)
        {
            picStatsClose.BackColor = Color.Transparent;
        }

        private void picStatsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
