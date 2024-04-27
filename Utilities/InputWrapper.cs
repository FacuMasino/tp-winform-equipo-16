using System;
using System.Windows.Forms;

namespace Utilities
{
    public class InputWrapper
    {
        public TextBox TextBox { get; set; }
        public Type InputType { get; set; }

        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public InputWrapper(TextBox textBox, Type inputType, int minLength = 2, int maxLength = 0)
        {
            this.TextBox = textBox;
            this.InputType = inputType;
            MinLength = minLength;
            MaxLength = maxLength;
        }
    }
}
