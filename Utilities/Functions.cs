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

        public static void HighlightInvalidsDGV(DataGridView dataGridView)
        {
            DataGridViewCellStyle invalidCellStyle = dataGridView.DefaultCellStyle.Clone();
            invalidCellStyle.BackColor = Validations.ErrorColor;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Verifica si tiene datos solo si no es la columna ID
                    if (cell.ColumnIndex != 0 && !Validations.HasData(cell.Value.ToString()))
                    {
                        row.DefaultCellStyle = invalidCellStyle;
                    }
                }
            }
        }
    }
}
