using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibCG;
namespace VectorForms
{
    public partial class Form2D : Form
    {
        public Form2D()
        {
            InitializeComponent();
        }

       
        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            if (!CamposVazios())
            {
                //se vetor 2D
                if (textBoxAX.Text.Trim() != "" & textBoxAY.Text.Trim() != "")
                {
                    //LE VETOR A 
                    float vetAX = float.Parse(textBoxAX.Text);
                    float vetAY = float.Parse(textBoxAY.Text);
                    //instancia o vetor A
                    Vector2D vectorA = new Vector2D(vetAX, vetAY);
                    Vector2D aux = new Vector2D();

                    //verifica se tem segundo vetor como entrada (ACIONA METODOS QUE TRABALHA COM 2 VETORES)
                    if (textBoxBX.Text.Trim() != "" & textBoxBY.Text.Trim() != "")
                    {

                        float vetBX = float.Parse(textBoxBX.Text);
                        float vetBY = float.Parse(textBoxBY.Text);
                        Vector2D vectorB = new Vector2D(vetBX, vetBY);

                        float escalar = float.Parse(textBoxEscalar.Text);
                        String multEAX = Math.Round(aux.MultiplicacaoEscalar(vectorA, escalar).GetX(), 1).ToString().Replace(",", ".");
                        String multEAY = Math.Round(aux.MultiplicacaoEscalar(vectorA, escalar).GetY(), 1).ToString().Replace(",", ".");
                        mascaraMultiplicacaoEscalar_A.Text = $"({multEAX}, {multEAY})";

                        String multEBX = Math.Round(aux.MultiplicacaoEscalar(vectorB, escalar).GetX(), 1).ToString().Replace(",", ".");
                        String multEBY = Math.Round(aux.MultiplicacaoEscalar(vectorB, escalar).GetY(), 1).ToString().Replace(",", ".");
                        mascaraMultiplicacaoEscalar_B.Text = $"({multEBX}, {multEBY})";

                        String divAX = Math.Round(aux.DivisaoEscalar(vectorA, escalar).GetX(), 1).ToString().Replace(",", ".");
                        String divAY = Math.Round(aux.DivisaoEscalar(vectorA, escalar).GetY(), 1).ToString().Replace(",", ".");
                        mascaraDivisaoEscalar_A.Text = $"({divAX}, {divAY})";

                        String divBX = Math.Round(aux.DivisaoEscalar(vectorB, escalar).GetX(), 1).ToString().Replace(",", ".");
                        String divBY = Math.Round(aux.DivisaoEscalar(vectorB, escalar).GetY(), 1).ToString().Replace(",", ".");
                        mascaraDivisaoEscalar_B.Text = $"({divBX}, {divBY})";
                        mascaraDot.Text = aux.Dot(vectorA, vectorB).ToString();

                        String projX = Math.Round(aux.Projecao(vectorB, vectorA).GetX(), 1).ToString().Replace(",", ".");
                        String projY = Math.Round(aux.Projecao(vectorB, vectorA).GetY(), 1).ToString().Replace(",", ".");
                        mascaraProjecao.Text = $"({projX}, {projY})";

                        String somX = Math.Round(aux.Soma(vectorA, vectorB).GetX(), 1).ToString().Replace(",", ".");
                        String somY = Math.Round(aux.Soma(vectorA, vectorB).GetY(), 1).ToString().Replace(",", ".");
                        mascaraSoma.Text = $"({somX}, {somY})";

                        String subX = Math.Round(aux.Subtracao(vectorA, vectorB).GetX(), 1).ToString().Replace(",", ".");
                        String subY = Math.Round(aux.Subtracao(vectorA, vectorB).GetY(), 1).ToString().Replace(",", ".");
                        mascaraSubtracao.Text = $"({subX}, {subY})";

                        mascaraDot.Text = Math.Round(aux.Dot(vectorA, vectorB), 1).ToString();

                        textBoxMagnitude_A.Text = Math.Round(aux.Magnitude(vectorA), 1).ToString();
                        textBoxMagnitude_B.Text = Math.Round(aux.Magnitude(vectorB), 1).ToString();

                        String normaAX = Math.Round(aux.Normalizar(vectorA).GetX(), 1).ToString().Replace(",", ".");
                        String normaAY = Math.Round(aux.Normalizar(vectorA).GetY(), 1).ToString().Replace(",", ".");
                        mascaraUnitario_A.Text = $"({normaAX}, {normaAY})";

                        String normaBX = Math.Round(aux.Normalizar(vectorB).GetX(), 1).ToString().Replace(",", ".");
                        String normaBY = Math.Round(aux.Normalizar(vectorB).GetY(), 1).ToString().Replace(",", ".");
                        mascaraUnitario_B.Text = $"({normaBX}, {normaBY})";

                        if (aux.Igualdade(vectorA, vectorB)) textBoxIguais.Text = "Sim";
                        else textBoxIguais.Text = "Não";
                    }
                }
            }
        }
        private bool CamposVazios()
        {
            if (textBoxAX.Text.Trim() == "" | textBoxAY.Text.Trim() == "" | textBoxEscalar.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, preencha os dois vetores e o escalar!");
                return true;
            }
            else
                return false;
        }

        void LimpaCampos()
        {
            textBoxIguais.Clear();
            textBoxMagnitude_A.Clear();
            textBoxMagnitude_B.Clear();
            textBoxAX.Clear();
            textBoxAY.Clear();
            textBoxBX.Clear();
            textBoxBY.Clear();
            mascaraUnitario_A.Clear();
            mascaraUnitario_B.Clear();
            mascaraProjecao.Clear();
            mascaraSoma.Clear();
            mascaraDivisaoEscalar_A.Clear();
            mascaraDivisaoEscalar_B.Clear();
            mascaraSubtracao.Clear();
            mascaraDot.Clear();
            textBoxEscalar.Clear();
            mascaraMultiplicacaoEscalar_A.Clear();
            mascaraMultiplicacaoEscalar_B.Clear();
        }

        private void ButtonLimpaCampos_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
