using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asg2
{
    public partial class btnloop : Form
    {
        public btnloop()
        {
            InitializeComponent();
        }

        private void btnloop_Load(object sender, EventArgs e)
        {

        }

        private void btnloop1_Click(object sender, EventArgs e)
        {
            // Remove the instructions from the label
            lblmessage1.Text = "";
            // use a loop to display numbers from 100 to 120 on our label
            // for loop structure: start#, condition for continuing, Increment
            for (Int32 counter = 100; counter <=120; counter++)
            {
                // add the current # on to the end of the label text
                lblmessage1.Text += counter + " ";
            } 
        }
    }
}
