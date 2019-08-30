using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorForms
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void Button2D_Click(object sender, EventArgs e)
        {
            // VERIFICA SE TEM FORM 2D  aberta
            if (Application.OpenForms.OfType<Form2D>().Count() > 0)
            {
                MessageBox.Show("Já existe uma anela de vetor 2D aberta!");
            }
            else
            {
                Form2D form2d = new Form2D();
                form2d.Show();
            }
        }

        private void ButtonVetor3D_Click(object sender, EventArgs e)
        {
            // VERIFICA SE TEM FORM 3D  abert
            if (Application.OpenForms.OfType<Form3D>().Count() > 0)
            {
                MessageBox.Show("Já existe uma anela de vetor 3D aberta!");
            }
            else
            {
                Form3D form3d = new Form3D();
                form3d.Show();
            }
        }
    }
}
