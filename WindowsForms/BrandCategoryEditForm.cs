using System.Windows.Forms;

namespace WindowsForms
{
    public partial class BrandCategoryEditForm : Form
    {
        public BrandCategoryEditForm()
        {
            InitializeComponent();
        }

        public void LoadBrands()
        {
            // Llamar a este método si se elige la opción de edición de marcas
            this.Text = "Editar Marcas";
        }

        public void LoadCategories()
        {
            // Llamar a este método si se elige la ocpión de edición de categorías
            this.Text = "Editar Categorías";
        }
    }
}
