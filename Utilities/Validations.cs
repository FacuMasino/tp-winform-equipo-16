using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public static class Validations
    {
        // METHODS

        public static Color ErrorColor = Color.FromArgb(249, 178, 173); // Color para errores

        public static bool IsNumber(string text)
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

        public static string RemoveSpaces(string text)
        {
            string temp = "";
            foreach (char c in text)
            {
                if (!char.IsWhiteSpace(c))
                    temp += c;
            }
            return temp;
        }

        public static bool IsAlphanumeric(string text)
        {
            foreach (char c in RemoveSpaces(text))
            {
                if (!char.IsNumber(c) && !char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public static bool IsDecimal(string text)
        {
            int commaCounter = 0;
            if (text[0] == '.')
                return false;
            if (text[text.Length - 1] == '.')
                return false;
            foreach (char c in text)
            {
                if (c == '.')
                    commaCounter++;
                if (!char.IsNumber(c) && c != '.')
                    return false;
            }
            return (commaCounter <= 1);
        }

        public static void Error(string message)
        {
            MessageBox.Show(
                message,
                "Error de validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public static bool HasData(string text, int minimumLength = 2, int maximumLength = 0)
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

        public static bool CheckAllInputs(List<InputWrapper> inputs)
        {
            int invalids = 0;
            foreach (InputWrapper inputWrapper in inputs)
            {
                // Si tiene entrada invalida, suma 1 al contador
                invalids += PaintIfInvalid(inputWrapper) ? 1 : 0;
            }
            return (invalids == 0); // si no hay inválidos, retorna true
        }

        private static bool PaintIfInvalid(InputWrapper input)
        {
            Debug.Print(input.InputType.ToString());
            switch (input.InputType.ToString())
            {
                case "System.String":
                    if (!HasData(input.TextBox.Text, input.MinLength, input.MaxLength))
                    {
                        Debug.Print($"Campo Invalido: {input.TextBox.Name}");
                        PaintBadInput(input.TextBox);
                        return true;
                    }
                    break;
                case "System.Decimal":
                    // Si se ingresa un nro fuera de rango, decimal.TryParse va a dar false
                    if (
                        !HasData(input.TextBox.Text, input.MinLength)
                        || !IsDecimal(input.TextBox.Text)
                        || !decimal.TryParse(input.TextBox.Text, out decimal num)
                    )
                    {
                        Debug.Print($"Campo Invalido: {input.TextBox.Name}");
                        PaintBadInput(input.TextBox);
                        return true;
                    }
                    break;
            }
            return false;
        }

        private static void PaintBadInput(TextBox txtBox)
        {
            // Asincrónicamente cambia el color y espera 4 segundos
            // Para volverlo a la normalidad
            Task.Run(async () =>
            {
                Color prevColor = txtBox.BackColor;
                txtBox.BackColor = ErrorColor;
                await Task.Delay(4000);
                txtBox.BackColor = prevColor;
            });
        }
    }
}
