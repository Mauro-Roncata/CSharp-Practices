using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormSecond : Form
    {
        public FormSecond()
        {
            InitializeComponent();
        }

        private void btnPrincip_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormMain()));
            t.Start();
        }
    }
}
