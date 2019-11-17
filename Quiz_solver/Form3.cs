using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_solver
{
    public partial class Form3 : Form
    {
        public Form3(decimal points)
        {
            InitializeComponent();
            label_wynik_pkt.Text = points.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
