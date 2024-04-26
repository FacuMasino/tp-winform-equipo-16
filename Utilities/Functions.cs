using System;
using System.Windows.Forms;

namespace Utilities
{
    public static class Functions
    {
        // METHODS

        public static void LoadImage(PictureBox pictureBox, string imageUrl)
        {
            try
            {
                pictureBox.Load(imageUrl);
            }
            catch (Exception)
            {
                pictureBox.Load(".\\..\\..\\..\\images\\404.png");
            }
        }

        public static void FillDataGrid(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
