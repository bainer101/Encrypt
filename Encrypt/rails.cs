using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class rails : Form
    {
        // this code makes the user's input into the form accessible to the main class
        public string numrails;

        public rails()
        {
            InitializeComponent();
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            numrails = textbox.Text;
        }
    }
}
