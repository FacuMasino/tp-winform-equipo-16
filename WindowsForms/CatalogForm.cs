using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogicLayer;
using Domain;
using Utilities;

namespace WindowsForms
{
    public partial class CatalogForm : Form
    {
        // ATTRIBUTES

        private Article _article;
        private ArticlesManager _articlesManager = new ArticlesManager();
        private List<Article> _articlesList = new List<Article>();
        private List<Article> _filteredArticles = new List<Article>();

        // CONSTRUCT

        public CatalogForm()
        {
            InitializeComponent();
        }

        // METHODS

        private void setupDataGridView()
        {
            if (0 < articlesDataGridView.RowCount)
            {
                articlesDataGridView.Columns["Id"].Width = 50;
                articlesDataGridView.Columns["Price"].DisplayIndex = articlesDataGridView.ColumnCount - 1;
                Functions.fillDataGrid(articlesDataGridView);
            }
        }

        private void validateDataGridView()
        {
            if (0 < articlesDataGridView.RowCount)
            {
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            else
            {
                editButton.Enabled = false;
                deleteButton.Enabled = false;
                loadPreview();
                Functions.loadImage(pictureBox, "");
            }
        }

        private void refreshList()
        {
            try
            {
                _articlesList = _articlesManager.List();
                articlesDataGridView.DataSource = _articlesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void applyFilter()
        {
            string filter = filterTextBox.Text;

            if (2 < filter.Length)
            {
                _filteredArticles = _articlesList.FindAll(x =>
                    x.Name.ToUpper().Contains(filter.ToUpper())
                    || x.Category.ToString().ToUpper().Contains(filter.ToUpper())
                    || x.Brand.ToString().ToUpper().Contains(filter.ToUpper())
                    || x.Code.ToUpper().Contains(filter.ToUpper())
                    || x.Description.ToUpper().Contains(filter.ToUpper())
                );
            }
            else
            {
                _filteredArticles = _articlesList;
            }

            articlesDataGridView.DataSource = null;
            articlesDataGridView.DataSource = _filteredArticles;
            validateDataGridView();
            articlesDataGridView.DataBindingComplete += articlesDataGridView_DataBindingComplete;
        }

        private void loadPreview(Article article = null)
        {
            if (article != null)
            {
                idLabel.Text = "Artículo N⁰ " + article.Id.ToString();

                if (Validations.hasData(article.Name))
                {
                    nameLabel.Text = article.Name;
                }
                else
                {
                    nameLabel.Text = "";
                }

                if (Validations.hasData(article.Description))
                {
                    descriptionLabel.Text = article.Description;
                }
                else
                {
                    descriptionLabel.Text = "";
                }

                if (article.Brand!= null)
                {
                    brandLabel.Text = article.Brand.ToString();
                }
                else
                {
                    brandLabel.Text = "";
                }

                if (article.Category != null)
                {
                    categoryLabel.Text = article.Category.ToString();
                }
                else
                {
                    categoryLabel.Text = "";
                }

                if (Validations.hasData(article.Price.ToString()))
                {
                    priceLabel.Text = article.Price.ToString();
                }
                else
                {
                    priceLabel.Text = "";
                }
            }
            else
            {
                idLabel.Text = "No hay artículos disponibles";
                nameLabel.Text = "";
                descriptionLabel.Text = "";
                brandLabel.Text = "";
                categoryLabel.Text = "";
                priceLabel.Text = "";
            }
        }

        // EVENTS

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            articlesDataGridView.SelectionChanged -= articlesDataGridView_SelectionChanged;
            refreshList();
            applyFilter();
            articlesDataGridView.SelectionChanged += articlesDataGridView_SelectionChanged;
        }

        private void articlesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (articlesDataGridView.CurrentRow != null)
            {
                _article = (Article)articlesDataGridView.CurrentRow.DataBoundItem;
                loadPreview(_article);

                string url = "";

                if (0 < _article.Images.Count)
                {
                    url = _article.Images[0].Url;
                }

                Functions.loadImage(pictureBox, url);
            }
        }

        private void articlesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            setupDataGridView();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            RegisterForm add = new RegisterForm();
            add.ShowDialog();
            refreshList();
            applyFilter();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            RegisterForm edit = new RegisterForm(_article);
            edit.ShowDialog();
            refreshList();
            applyFilter();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Esta acción no puede deshacerse. ¿Está seguro que desea continuar?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    _articlesManager.Delete(_article);
                    refreshList();
                    applyFilter();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            filterTextBox.Text = "";
            applyFilter();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            applyFilter();
        }
    }
}
