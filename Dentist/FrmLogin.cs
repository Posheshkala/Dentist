using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PublicClass;


namespace Dentist
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Clear clear = new();
            clear.ClearTextBox(this);
        }
        private void BtnCancel_Click(object sender , EventArgs e)
        {
            Application.Exit();
        }
    }
}
