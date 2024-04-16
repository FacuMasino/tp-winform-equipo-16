using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        // ATTRIBUTES

        FormsManager _formsManager = new FormsManager();

        // CONSTRUCT

        public MainForm()
        {
            InitializeComponent();
        }

        // EVENTS

        private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<CatalogForm>(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/FacuMasino/tpwinform-prog3");
        }
    }
}
