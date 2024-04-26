using System;
using System.Windows.Forms;
using BusinessLogicLayer;
using Domain;
using Utilities;

namespace WindowsForms
{
    public partial class RegisterForm : Form
    {
        private Article _article = null;
        private BrandsManager _brandsManager = new BrandsManager();
        private CategoriesManager _categoriesManager = new CategoriesManager();
        private ArticlesManager _articlesManager = new ArticlesManager();
        private ImagesManager _imagesManager = new ImagesManager();

        // CONSTRUCT

        public RegisterForm()
        {
            InitializeComponent();
        }

        public RegisterForm(Article article)
        {
            InitializeComponent();
            _article = article;
            Text = "Modificar Articulo";
        }

        // METHODS

        private bool validateRegister()
        {
            if (!Validations.isNumber(priceTextBox.Text))
            {
                Validations.error("El campo de precio solo admite caracteres numéricos.");
                return false;
            }

            // Facu, acá tenés que poner el resto de las validaciones. Borrá esto cuando lo veas xfa. Maxi

            return true;
        }

        private void LoadComboBoxes()
        {
            brandComboBox.DataSource = _brandsManager.List();
            brandComboBox.ValueMember = "Id";
            brandComboBox.DisplayMember = "Description";

            categoryComboBox.DataSource = _categoriesManager.List();
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Description";
        }

        private void ClearComboBoxes()
        {
            brandComboBox.SelectedIndex = -1;
            categoryComboBox.SelectedIndex = -1;
        }

        private void mapArticle()
        {
            codeTextBox.Text = _article.Code;
            nameTextBox.Text = _article.Name;
            descriptionTextBox.Text = _article.Description;
            priceTextBox.Text = _article.Price.ToString();

            if (0 < _article.Brand.Id)
            {
                brandComboBox.SelectedValue = _article.Brand.Id;
            }

            if (0 < _article.Category.Id)
            {
                categoryComboBox.SelectedValue = _article.Category.Id;
            }
        }

        private void setArticle()
        {
            _article.Code = codeTextBox.Text;
            _article.Name = nameTextBox.Text;
            _article.Description = descriptionTextBox.Text;
            _article.Price = decimal.Parse(priceTextBox.Text);

            if (Validations.hasData(brandComboBox.Text))
            {
                _article.Brand.Description = brandComboBox.Text;
            }
            else
            {
                _article.Brand = null; // Esto es una referencia para que el backend no intente agregar algo nulo y se rompan los metodos Add() y Edit() del manager de marcas
            }

            if (Validations.hasData(categoryComboBox.Text))
            {
                _article.Category.Description = categoryComboBox.Text;
            }
            else
            {
                _article.Category = null; // Esto es una referencia para que el backend no intente agregar algo nulo y se rompan los metodos Add() y Edit() del manager de categorias
            }
        }

        // EVENTS

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            ClearComboBoxes();

            if (_article != null) // Editar
            {
                mapArticle();
                Functions.loadImage(pictureBox, imageTextBox.Text); // Facu, puse provisoriamente este metodo para que muestre una sola imagen. Borra esto cuando lo leas, Maxi.
            }
            else // Nuevo
            {
                _article = new Article();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!validateRegister())
            {
                return;
            }

            try
            {
                setArticle();

                if (_article.Id != 0)
                {
                    _articlesManager.Edit(_article);
                    MessageBox.Show("Modificado exitosamente.");
                }
                else
                {
                    _articlesManager.Add(_article);
                    MessageBox.Show("Agregado exitosamente.");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void imageTextBox_Leave(object sender, EventArgs e)
        {
            Functions.loadImage(pictureBox, imageTextBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
