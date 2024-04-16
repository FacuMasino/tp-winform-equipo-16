using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class CatalogForm : Form
    {
        // ATTRIBUTES

        FormsManager _formsManager = new FormsManager();

        // CONSTRUCT

        public CatalogForm()
        {
            InitializeComponent();
        }

        // EVENTS

        private void newButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadDialogForm<RegisterForm>();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            _formsManager.loadDialogForm<RegisterForm>();
        }

        private void deleteButton_Click(object sender, EventArgs e) { }

        private void clearButton_Click(object sender, EventArgs e) { }

        private void searchButton_Click(object sender, EventArgs e) { }
    }
}
