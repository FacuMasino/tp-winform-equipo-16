using System;
using System.Windows.Forms;
using BusinessLogicLayer;
using Domain;
using Utilities;

namespace WindowsForms
{
    public partial class BrandCategoryEditForm : Form
    {
        private BrandsManager _brandsManager = new BrandsManager();
        private CategoriesManager _categoriesManager = new CategoriesManager();

        public BrandCategoryEditForm()
        {
            InitializeComponent();
        }

        public void LoadBrands()
        {
            // Llamar a este método si se elige la opción de edición de marcas
            this.Text = "Editar Marcas";
            LoadComboBoxBrand();
        }

        public void LoadCategories()
        {
            // Llamar a este método si se elige la ocpión de edición de categorías
            this.Text = "Editar Categorías";
            LoadComboBoxCategory();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void LoadComboBoxBrand()
        {
            optionComboBox.DataSource = _brandsManager.List();
            optionComboBox.ValueMember = "Id";
            optionComboBox.DisplayMember = "Description";
        }

        private void LoadComboBoxCategory()
        {
            optionComboBox.DataSource = _categoriesManager.List();
            optionComboBox.ValueMember = "Id";
            optionComboBox.DisplayMember = "Description";
        }
    }
}
