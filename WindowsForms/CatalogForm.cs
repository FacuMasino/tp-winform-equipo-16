using System;
using System.Security;
using System.Windows.Forms;
using BusinessLogicLayer;
using Domain;

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
            RegisterForm add = new RegisterForm();
            add.ShowDialog();
            refresh();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Article selected;
            selected = (Article)ArticlesdataGridView.CurrentRow.DataBoundItem;

            RegisterForm edit = new RegisterForm(selected);
            edit.ShowDialog();
            refresh();
        }

        private void refresh()
        {
            ArticlesManager articlesManager = new ArticlesManager();

            try
            {
                ArticlesdataGridView.DataSource = articlesManager.List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) { }

        private void clearButton_Click(object sender, EventArgs e) { }

        private void searchButton_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
