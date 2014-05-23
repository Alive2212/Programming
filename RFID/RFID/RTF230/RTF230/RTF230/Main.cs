using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF230
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RFT230.Base.rft230_GetID());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RFT230.Base.RFT230_INIT();
        }
    }
}
