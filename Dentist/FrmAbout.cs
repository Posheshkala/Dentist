using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace Dentist
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }
        readonly Assembly assembly = Assembly.GetExecutingAssembly();
        private void FrmAbout_Load(object sender,EventArgs e)
        {
            AssemblyTitleAttribute? assemblyTitleAttribute=assembly.GetCustomAttribute<AssemblyTitleAttribute>();
            AssemblyCompanyAttribute? assemblyCompanyAttribute=assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            AssemblyDescriptionAttribute? assemblyDescriptionAttribute=assembly.GetCustomAttribute<AssemblyDescriptionAttribute>();

            LblName.Text = Application.ProductName;
            LblVersion.Text = Application.ProductVersion;
            LblTitle.Text = assemblyTitleAttribute?.Title;
            LbLCompany.Text = assemblyCompanyAttribute?.Company;
            LblDescription.Text = assemblyDescriptionAttribute?.Description;
            
        }
    }
}
