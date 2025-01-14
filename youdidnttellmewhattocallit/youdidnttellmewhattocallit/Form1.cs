using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youdidnttellmewhattocallit
{
    public partial class Form1 : Form
    {
        int total = 0;
        int[] bits = new int[8];


        private void Calc()
        {
            if (bits[0] != 0) total += 1;
            if (bits[1] != 0) total += 2;
            if (bits[0] != 0) total += 1;
            if (bits[0] != 0) total += 1;
            if (bits[0] != 0) total += 1;
            if (bits[0] != 0) total += 1;
            if (bits[0] != 0) total += 1;
            if (bits[0] != 0) total += 1;
            if (bits[0] != 0) total += 1;
            if (bits[0] != 0) total += 1;
            if (bits[0] != 0) total += 1;

        }
    }
}
