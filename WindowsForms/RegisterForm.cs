using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class RegisterForm : Form
    {
        // CONSTRUCT

        public RegisterForm()
        {
            InitializeComponent();
        }

        // EVENTS

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
