using System;
using System.Windows.Forms;

namespace Utilities
{
    public class InputWrapper
    {
        public Control Control { get; set; }
        public Type InputType { get; set; }

        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public InputWrapper(TextBox textBox, Type inputType, int minLength = 2, int maxLength = 0)
        {
            this.Control = textBox;
            this.InputType = inputType;
            MinLength = minLength;
            MaxLength = maxLength;
        }

        public InputWrapper(ComboBox comboBox, Type inputType, int minLength = 2, int maxLength = 0)
        {
            this.Control = comboBox;
            this.InputType = inputType;
            MinLength = minLength;
            MaxLength = maxLength;
        }
    }
}
