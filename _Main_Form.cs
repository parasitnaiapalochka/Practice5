using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyForm
{

    public partial class _Main_Form : Form
    {
        public _Main_Form()
        {
            InitializeComponent();

        }
        int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            _Add form2 = new _Add();
            form2.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Data.form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
