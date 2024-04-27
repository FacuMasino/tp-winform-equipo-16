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

        private void SetupDataGridView()
        {
            if (0 < articlesDataGridView.RowCount)
            {
                articlesDataGridView.Columns["Id"].Width = 50;
                articlesDataGridView.Columns["Price"].DisplayIndex =
                    articlesDataGridView.ColumnCount - 1;
                Functions.FillDataGrid(articlesDataGridView);
            }
        }

        private void ValidateDataGridView()
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
                LoadPreview();
                Functions.LoadImage(pictureBox, "");
            }
        }

        private void RefreshList()
        {
            try
            {
                _articlesList = _articlesManager.List();
                if (HasInvalidArticles(_articlesList) && !chkShowInvalids.Checked)
                {
                    MessageBox.Show(
                        "Se encontraron artículos con información inválida! \n"
                            + "Para dejar de ver este mensaje por favor edítelos tildando la opción: 'Mostrar artículos inválidos'.",
                        "Acciones requeridas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    // filtrar los inválidos
                    _articlesList = _articlesList.FindAll(x => IsValidArticle(x));
                }
                if (HasInvalidArticles(_articlesList) && chkShowInvalids.Checked)
                {
                    _articlesList = _articlesList.FindAll(x => !IsValidArticle(x));
                }
                articlesDataGridView.DataSource = _articlesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool HasInvalidArticles(List<Article> articles)
        {
            int invalids = 0;
            foreach (Article article in articles)
            {
                if (
                    !Validations.HasData(article.Name)
                    || !Validations.HasData(article.Price.ToString())
                    || article.Images.Count == 0
                    || !Validations.HasData(article.Brand.ToString())
                    || !Validations.HasData(article.Category.ToString())
                )
                {
                    invalids++;
                }
            }
            return (invalids > 0);
        }

        private bool IsValidArticle(Article article)
        {
            if (
                !Validations.HasData(article.Name)
                || !Validations.HasData(article.Price.ToString())
                || article.Images.Count == 0
                || !Validations.HasData(article.Brand.ToString())
                || !Validations.HasData(article.Category.ToString())
            )
            {
                return false;
            }

            return true;
        }

        private void ApplyFilter()
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
            ValidateDataGridView();
            articlesDataGridView.DataBindingComplete += articlesDataGridView_DataBindingComplete;
        }

        private void LoadPreview(Article article = null)
        {
            if (article != null)
            {
                idLabel.Text = "Artículo N⁰ " + article.Id.ToString();

                if (Validations.HasData(article.Name))
                {
                    nameLabel.Text = article.Name;
                }
                else
                {
                    nameLabel.Text = "";
                }

                if (Validations.HasData(article.Description))
                {
                    descriptionLabel.Text = article.Description;
                }
                else
                {
                    descriptionLabel.Text = "";
                }

                if (article.Brand != null)
                {
                    brandLabel.Text = "Marca: " + article.Brand.ToString();
                }
                else
                {
                    brandLabel.Text = "";
                }

                if (article.Category != null)
                {
                    categoryLabel.Text = "Categoría: " + article.Category.ToString();
                }
                else
                {
                    categoryLabel.Text = "";
                }

                if (Validations.HasData(article.Price.ToString()))
                {
                    priceLabel.Text = "Precio: " + article.Price.ToString();
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
            RefreshList();
            ApplyFilter();
            articlesDataGridView.SelectionChanged += articlesDataGridView_SelectionChanged;
        }

        private void articlesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (articlesDataGridView.CurrentRow != null)
            {
                _article = (Article)articlesDataGridView.CurrentRow.DataBoundItem;
                LoadPreview(_article);

                string url = "";

                if (0 < _article.Images.Count)
                {
                    url = _article.Images[0].Url;
                }

                Functions.LoadImage(pictureBox, url);
            }
        }

        private void articlesDataGridView_DataBindingComplete(
            object sender,
            DataGridViewBindingCompleteEventArgs e
        )
        {
            SetupDataGridView();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            RegisterForm add = new RegisterForm();
            add.ShowDialog();
            RefreshList();
            ApplyFilter();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            RegisterForm edit = new RegisterForm(_article);
            edit.ShowDialog();
            RefreshList();
            ApplyFilter();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string msg = "Esta acción no puede deshacerse. ¿Está seguro que desea continuar?";
            if (chkDeleteUnused.Checked)
            {
                msg +=
                    "\n Importante: Si la marca y categoría no pertenecen a ningún otro artículo también se eliminarán.";
            }
            try
            {
                DialogResult answer = MessageBox.Show(
                    msg,
                    "Eliminar registro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (answer == DialogResult.Yes)
                {
                    _articlesManager.Delete(
                        _article,
                        chkDeleteUnused.Checked,
                        chkDeleteUnused.Checked
                    );
                    RefreshList();
                    ApplyFilter();
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
            ApplyFilter();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void chkShowInvalids_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
