using System;
using System.Collections.Generic;
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
        private List<Article> _articlesList = new List<Article>();
        private List<Article> _filteredArticles = new List<Article>();

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
                _articlesList = articlesManager.List();
                ArticlesdataGridView.DataSource = _articlesList;
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

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Article> _filteredArticles;
            string filter = filterTextBox.Text;

            if (filter != " ")
            {
                _filteredArticles = _articlesList.FindAll(x =>
                    x.Name.ToUpper().Contains(filter.ToUpper())
                    || x.Category.Description.ToUpper().Contains(filter.ToUpper())
                    || x.Brand.Description.ToUpper().Contains(filter.ToUpper())
                    || x.Code.ToUpper().Contains(filter.ToUpper())
                    || x.Description.ToUpper().Contains(filter.ToUpper())
                );
            }
            else
            {
                _filteredArticles = _articlesList;
            }

            ArticlesdataGridView.DataSource = _filteredArticles;
        }
    }
}
