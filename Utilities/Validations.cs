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
        public static Color NormalColor = Color.FromArgb(246, 247, 251);

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
                // Si tiene entrada invalida, suma 1 al contador y pintar rojo
                if (!IsGoodInput(inputWrapper))
                {
                    invalids++;
                    PaintBadInput(inputWrapper.Control);
                }
            }
            return (invalids == 0); // si no hay inválidos, retorna true
        }

        public static bool IsGoodInput(InputWrapper input)
        {
            switch (input.InputType.ToString())
            {
                case "System.String":
                    if (!HasData(input.Control.Text, input.MinLength, input.MaxLength))
                    {
                        Debug.Print($"Campo Invalido: {input.Control.Name}");
                        return false;
                    }
                    break;
                case "System.Decimal":
                    // Si se ingresa un nro fuera de rango, decimal.TryParse va a dar false
                    if (
                        !HasData(input.Control.Text, input.MinLength)
                        || !IsDecimal(input.Control.Text)
                        || !decimal.TryParse(input.Control.Text, out decimal num)
                    )
                    {
                        Debug.Print($"Campo Invalido: {input.Control.Name}");
                        return false;
                    }
                    break;
            }
            return true;
        }

        public static void PaintBadInput(Control control)
        {
            if (!control.Enabled)
                return; // si no está habilitado no pintar
            // Asincrónicamente cambia el color y espera 4 segundos
            // Para volverlo a la normalidad
            Task.Run(async () =>
            {
                ChangeCtrlColorFromTask(control, ErrorColor);
                await Task.Delay(4000);
                ChangeCtrlColorFromTask(control, NormalColor);
            });
        }

        /// <summary>
        /// <para>Esta función permite cambiar el BackColor de un control desde un hilo de una tarea
        /// Async pero sin salir del hilo principal del Windows Form, de otra forma se crearía
        /// un hilo paralelo y al tratar de cambiarse el atributo arrojaría una excepción</para>
        /// <see href=" https://learn.microsoft.com/es-es/dotnet/api/system.windows.forms.control.invoke?view=windowsdesktop-8.0">+info</see>
        /// </summary>
        /// <param name="control">Control al cual se le va a cambiar el color de fondo</param>
        /// <param name="color">Color</param>
        private static void ChangeCtrlColorFromTask(Control control, Color color)
        {
            control.Invoke(
                (
                    new MethodInvoker(
                        delegate
                        {
                            control.BackColor = color;
                        }
                    )
                )
            );
        }
    }
}
