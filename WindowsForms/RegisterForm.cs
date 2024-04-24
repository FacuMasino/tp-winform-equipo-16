using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using BusinessLogicLayer;
using Domain;

namespace WindowsForms
{
    public partial class RegisterForm : Form
    {
        private Article _article = null;
        private BrandsManager _brandsManager = new BrandsManager();
        private CategoriesManager _categoriesManager = new CategoriesManager();
        private ArticlesManager _articlesManager = new ArticlesManager();

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

        // EVENTS


        /*private void RegisterForm_Load(object sender, EventArgs e)
        {
            BrandsManager brandsManager = new BrandsManager();
            CategoriesManager categoriesManager = new CategoriesManager();
            try
            {
                brandComboBox.DataSource = brandsManager.List();
                categoryComboBox.DataSource = categoriesManager.List();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/
        private void LoadComboBoxes()
        {
            brandComboBox.DataSource = _brandsManager.List();
            brandComboBox.ValueMember = "Id";
            brandComboBox.DisplayMember = "Description";

            categoryComboBox.DataSource = _categoriesManager.List();
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Description";
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();

            if (_article != null) // entra si es art. editado
            {
                codeTextBox.Text = _article.Code;
                nameTextBox.Text = _article.Name;
                descriptionTextBox.Text = _article.Description;
                priceTextBox.Text = _article.Price.ToString();
                brandComboBox.SelectedValue = _article.Brand.Id;
                categoryComboBox.SelectedValue = _article.Category.Id;
                ///agregar imagen
            }
            else // entra aca si es nuevo
            {
                _article = new Article();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _article.Code = codeTextBox.Text;
                _article.Name = nameTextBox.Text;
                _article.Description = descriptionTextBox.Text;
                _article.Price = decimal.Parse(priceTextBox.Text);
                _article.Brand = (Brand)brandComboBox.SelectedItem;
                _article.Category = (Category)categoryComboBox.SelectedItem;

                if (_article.Id != 0)
                {
                    _articlesManager.Edit(_article);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    _articlesManager.Add(_article);
                    MessageBox.Show("Agregado exitosamente");
                }

                //IF - Parte imagen

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
