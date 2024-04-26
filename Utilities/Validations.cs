using System.Windows.Forms;

namespace Utilities
{
    public static class Validations
    {
        // METHODS

        public static bool isNumber(string text)
        {
            foreach (char c in text)
            {
                if (!(char.IsNumber(c)))
                {
                    return false;
                }
            }

            return true;
        }

        public static void error(string message)
        {
            MessageBox.Show(message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool hasData(string text, int minimumLength = 2, int maximumLength = 0)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            if (text == "")
            {
                return false;
            }

            if (text.Length < minimumLength)
            {
                return false;
            }

            if (maximumLength != 0 && maximumLength < text.Length)
            {
                return false;
            }

            return true;
        }
    }
}
