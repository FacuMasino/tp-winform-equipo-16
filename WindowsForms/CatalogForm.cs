using System;
using System.Windows.Forms;
using BusinessLogicLayer;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            ArticlesManager articlesManager = new ArticlesManager();
            ArticlesdataGridView.DataSource = articlesManager.List();
        }
    }
}
