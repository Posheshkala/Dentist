using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public void FrmMain_Load(object sender ,EventArgs e)
        {
            FrmLogin frmLogin = new();
            frmLogin.ShowDialog();
        }

        private void TMSVersion_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new ();
            frmAbout.ShowDialog();
        }
    }
}
