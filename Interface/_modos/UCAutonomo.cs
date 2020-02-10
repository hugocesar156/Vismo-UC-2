using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vismo._modos
{
    public partial class UCAutonomo : UserControl
    {
        public UCAutonomo()
        {
            InitializeComponent();

            Point point = new Point(384, 3);
            FrmPrincipal.Instance.Home.Location = point;
        }  
    }
}
