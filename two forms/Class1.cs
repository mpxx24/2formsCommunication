using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace two_forms
{
    public class Class1 : Abstr
    {
        public override void ZmienKolor(Form f, ColorDialog color)
        {
            f.BackColor = color.Color;
        }
    }
}
