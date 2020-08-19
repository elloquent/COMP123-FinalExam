using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    // Author Name Richard Elridge
    // Student number 301107264
    // modify 20/08/2020
    // This program is use to interact with different windows form
    public partial class splashform : Form
    {
        public splashform()
        {
            InitializeComponent();
        }
        //call the generatename form after the time on the timer expires and hide the current page
        private void splashtimer_Tick(object sender, EventArgs e)
        {
            Program.genform.Show();
            this.Hide();
            splashtimer.Enabled = false;
        }

        private void splashform_Load(object sender, EventArgs e)
        {

        }
    }
}
