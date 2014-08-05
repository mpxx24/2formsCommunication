using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace two_forms
{
    public partial class Form1 : Class1
    {
        public Form2 f2 = new Form2();

        public Form1(Form2 innaForma)
        {
            InitializeComponent();
            this.f2 = innaForma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = colorDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
               ZmienKolor(f2, colorDialog1);
            }
        }
        
    }
}
