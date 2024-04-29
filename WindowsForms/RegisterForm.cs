using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private List<InputWrapper> _inputsValidation = new List<InputWrapper>();
        private ImagesManager _imagesManager = new ImagesManager();
        private List<Image> _images = new List<Image>();
        private int _imageIndex = 0;

        // CONSTRUCT

        public RegisterForm()
        {
            InitializeComponent();
            brandCheckBox.Visible = false;
            categoryCheckBox.Visible = false;
            brandComboBox.Width = codeTextBox.Width;
            categoryComboBox.Width = codeTextBox.Width;
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
            _inputsValidation.Add(new InputWrapper(brandComboBox, typeof(string), 1));
            _inputsValidation.Add(new InputWrapper(categoryComboBox, typeof(string), 1));
            _inputsValidation.Add(new InputWrapper(imageTextBox, typeof(string), 6, 1000));
            _inputsValidation.Add(new InputWrapper(priceTextBox, typeof(decimal), 1));
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

        private void mapImage()
        {
            imageTextBox.Text = _article.Images[_imageIndex]?.Url;
        }

        private void MapArticle()
        {
            codeTextBox.Text = _article.Code;
            nameTextBox.Text = _article.Name;
            descriptionTextBox.Text = _article.Description;
            priceTextBox.Text = _article.Price.ToString();
            mapImage();

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

            // IMPORTANTE:
            // Cambiar esto cuando se de funcionalidad a agregar multiples imagenes
            if (_article.Images.Count > 0)
            {
                _article.Images[0].Url = imageTextBox.Text;
            }
            else
            {
                Image auxImg = new Image();
                auxImg.Url = imageTextBox.Text;
                _article.Images.Add(auxImg);
            }

            if (Validations.HasData(brandComboBox.Text))
            {
                _article.Brand.Description = brandComboBox.Text;
            }
            else
            {
                _article.Brand = null;
            }

            if (Validations.HasData(categoryComboBox.Text))
            {
                _article.Category.Description = categoryComboBox.Text;
            }
            else
            {
                _article.Category = null;
            }
        }

        private void ShowTooltip(Control control, string msg)
        {
            tlpValidations.Show(msg, this, Width - 100, control.Location.Y - 30, 5000);
        }

        private bool ValidateInput(Control control)
        {
            if (_inputsValidation.Count == 0)
            {
                return false; // Todavia no se carga la lista de inputs
            }

            InputWrapper input = _inputsValidation.Find(x => control.Equals(x.Control));

            if (!Validations.IsGoodInput(input))
            {
                return false;
            }

            return true;
        }

        private void EnableNextInput(Control actualControl)
        {
            int inputIndex = _inputsValidation.FindIndex(x => x.Control.Equals(actualControl));
            Debug.Print($"input actual: {_inputsValidation[inputIndex].Control.Name}");
            Debug.Print($"input siguiente: {_inputsValidation[inputIndex + 1].Control.Name}");

            if (!_inputsValidation[inputIndex + 1].Control.Enabled)
            {
                _inputsValidation[inputIndex + 1].Control.Enabled = true;
            }
        }

        private void DisableControlInputs()
        {
            foreach (InputWrapper input in _inputsValidation)
            {
                if (input.Control.Equals(codeTextBox))
                {
                    continue;
                }

                input.Control.Enabled = false;
            }
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
                Functions.LoadImage(pictureBox, imageTextBox.Text);
            }
            else // Nuevo
            {
                DisableControlInputs();
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
                    Brand oldBrand = new Brand();
                    oldBrand.Id = _article.Brand.Id;

                    Category oldCategory = new Category();
                    oldCategory.Id = _article.Category.Id;

                    if (brandCheckBox.Checked)
                    {
                        _brandsManager.Edit(_article.Brand);
                    }

                    if (categoryCheckBox.Checked)
                    {
                        _categoriesManager.Edit(_article.Category);
                    }

                    _articlesManager.Edit(_article);
                    _brandsManager.PurgeBrand(oldBrand);
                    _categoriesManager.PurgeCategory(oldCategory);

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

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateInput(codeTextBox))
                EnableNextInput(codeTextBox);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateInput(nameTextBox))
                EnableNextInput(nameTextBox);
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateInput(descriptionTextBox))
                EnableNextInput(descriptionTextBox);
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e) { }

        private void brandComboBox_Leave(object sender, EventArgs e)
        {
            if (!ValidateInput(brandComboBox))
            {
                Validations.PaintBadInput(brandComboBox);
                ShowTooltip(
                    brandComboBox,
                    "Debe seleccionar una Marca de la lista o ingresar una nueva"
                );
            }
        }

        private void brandComboBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateInput(brandComboBox))
                EnableNextInput(brandComboBox);
        }

        private void categoryComboBox_Leave(object sender, EventArgs e)
        {
            if (!ValidateInput(categoryComboBox))
            {
                Validations.PaintBadInput(categoryComboBox);
                ShowTooltip(
                    categoryComboBox,
                    "Debe seleccionar una Categoría de la lista o ingresar una nueva"
                );
            }
        }

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateInput(categoryComboBox))
                EnableNextInput(categoryComboBox);
        }

        private void imageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateInput(imageTextBox))
                EnableNextInput(imageTextBox);
        }

        private void prevImgButton_Click(object sender, EventArgs e)
        {
            if (0 < _imageIndex)
            {
                _imageIndex --;
                label1.Text = _imageIndex.ToString(); //borrar y borrar compoennte
                mapImage();
                Functions.LoadImage(pictureBox, imageTextBox.Text);
            }
        }

        private void nextImgButton_Click(object sender, EventArgs e)
        {
            int imagesAmount = _article.Images.Count;

            if (_imageIndex < imagesAmount)
            {
                _imageIndex ++;
                label1.Text = _imageIndex.ToString(); //borrar comp[onente

                if (_imageIndex != imagesAmount)
                {
                    mapImage();
                    Functions.LoadImage(pictureBox, imageTextBox.Text);
                }
                else
                {
                    imageTextBox.Text = "";
                    Functions.LoadImage(pictureBox, "https://scontent.faep24-1.fna.fbcdn.net/v/t39.30808-6/300048077_475711724563828_9035779901907420679_n.png?_nc_cat=109&ccb=1-7&_nc_sid=5f2048&_nc_ohc=FJ0M5nhZ1wMQ7kNvgHMN7nf&_nc_ht=scontent.faep24-1.fna&oh=00_AfAwqHQEqupbkK5sc0H8yUgCAWI__tkqnt9lsZix48LHcA&oe=6634F4F0");
                }
            }
        }
    }
}
