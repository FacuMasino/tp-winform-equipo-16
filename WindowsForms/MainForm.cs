using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        // ATTRIBUTES

        FormsManager _formsManager = new FormsManager();

        // CONSTRUCT

        public MainForm()
        {
            InitializeComponent();
        }

        // EVENTS

        private void MainForm_Load(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<CatalogForm>(this);
        }

        private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formsManager.loadParentForm<CatalogForm>(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void brandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandCategoryEditForm brandsEditForm = new BrandCategoryEditForm();
            brandsEditForm.LoadBrands();
            brandsEditForm.ShowDialog();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandCategoryEditForm categoriesEditForm = new BrandCategoryEditForm();
            categoriesEditForm.LoadCategories();
            categoriesEditForm.ShowDialog();
        }
    }
}
