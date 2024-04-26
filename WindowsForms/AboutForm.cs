using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void lblProjectRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/FacuMasino/tpwinform-prog3");
        }

        private void pbxLnAna_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/ana-clara-bertello-70170a187/");
        }

        private void pbxGHAna_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/Ani77aa");
        }

        private void pbxLnMaxi_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/malvicinomaximilianoraul/");
        }

        private void pbxGHMaxi_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/mrmalvicino");
        }

        private void pbxLnFacu_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/facundomasino/");
        }

        private void pbxGHFacu_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/FacuMasino");
        }
    }
}
