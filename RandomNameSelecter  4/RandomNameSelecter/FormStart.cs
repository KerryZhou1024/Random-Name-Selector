using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNameSelecter
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }


        private void cbFormStartIsFirstTime_CheckedChanged(object sender, EventArgs e)
        {
            if(cbFormStartIsFirstTime.Checked)
            {

            }
        }
        public bool closeflag = true;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            closeflag = false;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
