using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD.Views
{
    public partial class DuplicateWarning : Form
    {
        public delegate void Confirm(bool accept);
        public Confirm? confirm { get; set; }
        public DuplicateWarning()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool accept = true;
            confirm(accept);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool accept = false;
            confirm(accept);
            this.Close();
        }
    }
}
