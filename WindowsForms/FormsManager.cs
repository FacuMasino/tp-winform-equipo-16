using System.Windows.Forms;

namespace WindowsForms
{
    public class FormsManager
    {
        // METHODS

        public void loadDialogForm<FormClass>() where FormClass : Form, new()
        {
            FormClass form = new FormClass();
            form.ShowDialog();
        }

        public void loadParentForm<FormClass>(Form mdiParent) where FormClass : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormClass formClass)
                {
                    if (formClass.WindowState == FormWindowState.Minimized)
                    {
                        formClass.WindowState = FormWindowState.Normal;
                    }

                    formClass.BringToFront();
                    return;
                }
            }

            FormClass newForm = new FormClass();
            newForm.MdiParent = mdiParent;
            newForm.Show();
        }
    }
}
