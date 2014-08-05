using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace two_forms
{
    public abstract class Abstr : Form
    {
        public abstract void ZmienKolor(Form f, ColorDialog color);
    }
}
