using System;
using System.Collections.Generic;
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
        private List<InputWrapper> _inputsValidation = new List<InputWrapper>();

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

        private void CreateValidationsList()
        {
            _inputsValidation.Add(new InputWrapper(codeTextBox, typeof(string), 2, 50));
            _inputsValidation.Add(new InputWrapper(nameTextBox, typeof(string), 2, 50));
            _inputsValidation.Add(new InputWrapper(descriptionTextBox, typeof(string), 2, 150));
            _inputsValidation.Add(new InputWrapper(priceTextBox, typeof(decimal)));
            _inputsValidation.Add(new InputWrapper(imageTextBox, typeof(string), 6, 1000));
        }

        private bool ValidateRegister()
        {
            /*if (!Validations.IsNumber(priceTextBox.Text))
            {
                Validations.Error("El campo de precio solo admite caracteres numéricos.");
                return false;
            }*/
            if (!Validations.CheckAllInputs(_inputsValidation))
            {
                Validations.Error("Por favor verifique que los campos ingresados sean correctos.");
                return false;
            }

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

        private void MapArticle()
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

        private void SetArticle()
        {
            _article.Code = codeTextBox.Text;
            _article.Name = nameTextBox.Text;
            _article.Description = descriptionTextBox.Text;
            _article.Price = decimal.Parse(priceTextBox.Text);

            if (Validations.HasData(brandComboBox.Text))
            {
                _article.Brand.Description = brandComboBox.Text;
            }
            else
            {
                _article.Brand = null; // Esto es una referencia para que el backend no intente agregar algo nulo y se rompan los metodos Add() y Edit() del manager de marcas
            }

            if (Validations.HasData(categoryComboBox.Text))
            {
                _article.Category.Description = categoryComboBox.Text;
            }
            else
            {
                _article.Category = null; // Esto es una referencia para que el backend no intente agregar algo nulo y se rompan los metodos Add() y Edit() del manager de categorias
            }
        }

        private void ShowTooltip(Control control, string msg)
        {
            tlpValidations.Show(msg, this, Width - 100, control.Location.Y - 30, 5000);
        }

        private bool ValidateInput(TextBox txtBox)
        {
            InputWrapper input = _inputsValidation.Find(x => txtBox.Equals(x.TextBox));
            if (!Validations.IsGoodInput(input))
                return false;
            return true;
        }

        // EVENTS

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            ClearComboBoxes();
            CreateValidationsList();

            if (_article != null) // Editar
            {
                MapArticle();
                Functions.LoadImage(pictureBox, imageTextBox.Text); // Facu, puse provisoriamente este metodo para que muestre una sola imagen. Borra esto cuando lo leas, Maxi.
            }
            else // Nuevo
            {
                _article = new Article();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateRegister())
            {
                return;
            }

            try
            {
                SetArticle();

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
            if (!ValidateInput(imageTextBox))
            {
                Validations.PaintBadInput(imageTextBox);
                ShowTooltip(
                    imageTextBox,
                    "La URL de la imagen debe contener entre 6 y 1000 caracteres."
                );
                return;
            }
            Functions.LoadImage(pictureBox, imageTextBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void codeTextBox_Leave(object sender, EventArgs e)
        {
            if (!ValidateInput(codeTextBox))
            {
                Validations.PaintBadInput(codeTextBox);
                ShowTooltip(codeTextBox, "El código debe contener entre 2 y 50 caracteres.");
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (!ValidateInput(nameTextBox))
            {
                Validations.PaintBadInput(nameTextBox);
                ShowTooltip(nameTextBox, "El nombre debe contener entre 2 y 50 caracteres.");
            }
        }

        private void descriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (!ValidateInput(descriptionTextBox))
            {
                Validations.PaintBadInput(descriptionTextBox);
                ShowTooltip(
                    descriptionTextBox,
                    "La descripción debe contener entre 2 y 150 caracteres."
                );
            }
        }

        private void priceTextBox_Leave(object sender, EventArgs e)
        {
            if (!ValidateInput(priceTextBox))
            {
                Validations.PaintBadInput(priceTextBox);
                ShowTooltip(
                    priceTextBox,
                    "El precio debe contener solo números enteros o decimales"
                );
            }
        }
    }
}
