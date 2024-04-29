using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using Domain;
using Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms
{
    public partial class BrandCategoryEditForm : Form
    {
        private Category _category;
        private Brand _brand;
        private BrandsManager _brandsManager = new BrandsManager();
        private CategoriesManager _categoriesManager = new CategoriesManager();
        private List<Brand> _brandsList = new List<Brand>();
        private List<Category> _categoriesList = new List<Category>();
        public bool IsBrand = false;

        public BrandCategoryEditForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// <c>LoadBrands</c> Carga la interfaz de usuario correspondiente a la edición de  marcas.
        /// </summary>
        public void LoadBrands()
        {
            // Llamar a este método si se elige la opción de edición de marcas para los artículos
            this.Text = "Editar Marcas";
            LoadComboBoxBrand();
            IsBrand = true;
        }

        /// <summary>
        /// <c>LoadCategories</c> Carga la interfaz de usuario correspondiente a la edición de  categorias los artículos.
        /// </summary>
        public void LoadCategories()
        {
            // Llamar a este método si se elige la ocpión de edición de categorías
            this.Text = "Editar Categorías";
            LoadComboBoxCategory();
            IsBrand = false;
        }

        /// <summary>
        /// <c>cancelButton_Click</c> Cierra la ventana si se presiona la opción Cancelar en la edición.
        /// </summary>
        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// <c>LoadComboBoxBrand</c> Carga las marcas disponibles en el ComboBox y agrega la opción de agregar Nueva Marca"
        /// </summary>
        private void LoadComboBoxBrand()
        {
            Brand auxBrand = new Brand();
            auxBrand.Description = "Agregar nueva Marca";
            _brandsList = _brandsManager.List();
            _brandsList.Add(auxBrand);
            _brandsList.Concat(_brandsManager.List()).ToList();
            optionComboBox.DataSource = _brandsList;
            optionComboBox.ValueMember = "Id";
            optionComboBox.DisplayMember = "Description";
        }

        /// <summary>
        /// <c>LoadComboBoxCategory</c> Carga las categorias disponibles en el ComboBox y agrega la opción de agregar Nueva Categoria"
        /// </summary>

        private void LoadComboBoxCategory()
        {
            Category auxCategory = new Category();
            auxCategory.Description = "Agregar nueva Categoria";
            _categoriesList = _categoriesManager.List();
            _categoriesList.Add(auxCategory);
            _categoriesList.Concat(_categoriesManager.List()).ToList();
            optionComboBox.DataSource = _categoriesList;
            optionComboBox.ValueMember = "Id";
            optionComboBox.DisplayMember = "Description";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string msg =
                "Esta seguro que desea eliminar el registro seleccionado? No podrá deshacer la acción una vez realizada";

            try
            {
                DialogResult answer = MessageBox.Show(
                    msg,
                    "Eliminar registro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (answer == DialogResult.Yes && IsBrand == true)
                {
                    _brandsManager.Delete(_brand);
                    LoadComboBoxBrand();
                }
                else if (answer == DialogResult.Yes && IsBrand == false)
                {
                    _categoriesManager.Delete(_category);
                    LoadComboBoxCategory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
