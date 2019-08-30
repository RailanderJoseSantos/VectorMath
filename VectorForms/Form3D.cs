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
    public partial class Form3D : Form
    {
        public Form3D()
        {
            InitializeComponent();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            if (!CamposVazios())
            {
                if (textBoxAX.Text.Trim() != "" & textBoxAY.Text.Trim() != "" & textBoxAZ.Text.Trim() != "")
                {
                    //LE VETOR A 
                    float vetAX = float.Parse(textBoxAX.Text);
                    float vetAY = float.Parse(textBoxAY.Text);
                    float vetAZ = float.Parse(textBoxAZ.Text);
                    //instancia o vetor A
                    Vector3D vectorA = new Vector3D(vetAX, vetAY, vetAZ);
                    Vector3D aux = new Vector3D();

                     //verifica se tem segundo vetor como entrada (ACIONA METODOS QUE TRABALHA COM 2 VETORES)
                    if (textBoxBX.Text.Trim() != "" & textBoxBY.Text.Trim() != "" & textBoxBZ.Text.Trim() != "")
                    {
                        //LE VETOR B
                        float vetBX = float.Parse(textBoxBX.Text);
                        float vetBY = float.Parse(textBoxBY.Text);
                        float vetBZ = float.Parse(textBoxBZ.Text);
                        Vector3D vectorB = new Vector3D(vetBX, vetBY, vetBZ);

                        float escalar = float.Parse(textBoxEscalar.Text);

                        String multEAX = Math.Round(aux.MultiplicacaoEscalar(vectorA, escalar).GetX(), 1).ToString().Replace(",", ".");
                        String multEAY = Math.Round(aux.MultiplicacaoEscalar(vectorA, escalar).GetY(), 1).ToString().Replace(",", ".");
                        String multEAZ = Math.Round(aux.MultiplicacaoEscalar(vectorA, escalar).GetZ(), 1).ToString().Replace(",", ".");
                        mascaraMultiplicacaoEscalar_A.Text = $"({multEAX}, {multEAY}, {multEAZ})";

                        String multEBX = Math.Round(aux.MultiplicacaoEscalar(vectorB, escalar).GetX(), 1).ToString().Replace(",", ".");
                        String multEBY = Math.Round(aux.MultiplicacaoEscalar(vectorB, escalar).GetY(), 1).ToString().Replace(",", ".");
                        String multEBZ = Math.Round(aux.MultiplicacaoEscalar(vectorB, escalar).GetZ(), 1).ToString().Replace(",", ".");
                        mascaraMultiplicacaoEscalar_B.Text = $"({multEBX}, {multEBY}, {multEBZ})";

                        String divEAX = Math.Round(aux.DivisaoEscalar(vectorA, escalar).GetX(), 1).ToString().Replace(",", ".");
                        String divEAY = Math.Round(aux.DivisaoEscalar(vectorA, escalar).GetY(), 1).ToString().Replace(",", ".");
                        String divEAZ = Math.Round(aux.DivisaoEscalar(vectorA, escalar).GetZ(), 1).ToString().Replace(",", ".");
                        mascaraDivisaoEscalar_A.Text = $"({divEAX}, {divEAY}, {divEAZ})";

                        String divEBX = Math.Round(aux.DivisaoEscalar(vectorB, escalar).GetX(), 1).ToString().Replace(",", ".");
                        String divEBY = Math.Round(aux.DivisaoEscalar(vectorB, escalar).GetY(), 1).ToString().Replace(",", ".");
                        String divEBZ = Math.Round(aux.DivisaoEscalar(vectorB, escalar).GetZ(), 1).ToString().Replace(",", ".");
                        mascaraDivisaoEscalar_B.Text = $"({divEBX}, {divEBY}, {divEBZ})";

                        String somX = Math.Round(aux.Soma(vectorA, vectorB).GetX(), 1).ToString().Replace(",", ".");
                        String somY = Math.Round(aux.Soma(vectorA, vectorB).GetY(), 1).ToString().Replace(",", ".");
                        String somZ = Math.Round(aux.Soma(vectorA, vectorB).GetZ(), 1).ToString().Replace(",", ".");
                        mascaraSoma.Text = $"({somX}, {somY}, {somZ})";

                        String subX = Math.Round(aux.Subtracao(vectorA, vectorB).GetX(), 1).ToString().Replace(",", ".");
                        String subY = Math.Round(aux.Subtracao(vectorA, vectorB).GetY(), 1).ToString().Replace(",", ".");
                        String subZ = Math.Round(aux.Subtracao(vectorA, vectorB).GetZ(), 1).ToString().Replace(",", ".");
                        mascaraSubtracao.Text = $"({subX}, {subY}, {subZ})";

                        mascaraDot.Text = Math.Round(aux.Dot(vectorA, vectorB), 1).ToString();

                        //tratamento pra substituir virgula por ponto (somente no calculo)
                        String projX = Math.Round(aux.Projecao(vectorB, vectorA).GetX(), 1).ToString().Replace(",", ".");
                        String projY = Math.Round(aux.Projecao(vectorB, vectorA).GetY(), 1).ToString().Replace(",", ".");
                        String projZ = Math.Round(aux.Projecao(vectorB, vectorA).GetZ(), 1).ToString().Replace(",", ".");
                        mascaraProjecao.Text = $"({projX}, {projY}, {projZ})";

                        String crossX = Math.Round(aux.Cross(vectorA, vectorB).GetX(), 1).ToString().Replace(",", ".");
                        String crossY = Math.Round(aux.Cross(vectorA, vectorB).GetY(), 1).ToString().Replace(",", ".");
                        String crossZ = Math.Round(aux.Cross(vectorA, vectorB).GetZ(), 1).ToString().Replace(",", ".");
                        mascaraCross.Text = $"({crossX}, {crossY}, {crossZ})";

                        if (aux.Igualdade(vectorA, vectorB)) textBoxIguais.Text = "Sim";
                        else textBoxIguais.Text = "Não";

                        textBoxMagnitude_A.Text = Math.Round(aux.Magnitude(vectorA), 1).ToString();
                        textBoxMagnitude_B.Text = Math.Round(aux.Magnitude(vectorB), 1).ToString();

                        String normaAX = Math.Round(aux.Normalizar(vectorA).GetX(), 1).ToString().Replace(",", ".");
                        String normaAY = Math.Round(aux.Normalizar(vectorA).GetY(), 1).ToString().Replace(",", ".");
                        String normaAZ = Math.Round(aux.Normalizar(vectorA).GetZ(), 1).ToString().Replace(",", ".");
                        mascaraUnitario_A.Text = $"({normaAX}, {normaAY}, {normaAZ})";

                        String normaBX = Math.Round(aux.Normalizar(vectorB).GetX(), 1).ToString().Replace(",", ".");
                        String normaBY = Math.Round(aux.Normalizar(vectorB).GetY(), 1).ToString().Replace(",", ".");
                        String normaBZ = Math.Round(aux.Normalizar(vectorB).GetZ(), 1).ToString().Replace(",", ".");
                        mascaraUnitario_B.Text = $"({normaBX}, {normaBY}, {normaBZ})";

                    }
                }

            }
        }
        private bool CamposVazios()
        {
            if (textBoxAX.Text.Trim() == "" | textBoxAY.Text.Trim() == "" | textBoxAZ.Text.Trim() == "" | textBoxEscalar.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, preencha os dois vetores e o escalar!");
                return true;
            }
            else
                return false;
        }

        private void ButtonResetar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void TextBoxEscalar_Click(object sender, EventArgs e)
        {
            if (textBoxBX.Text.Trim() != "" | textBoxBY.Text.Trim() != "" | textBoxBZ.Text.Trim() != "")
            {
                textBoxBX.Clear();
                textBoxBY.Clear();
                textBoxBZ.Clear();
            }
        }
        void LimpaCampos()
        {
            textBoxIguais.Clear();
            textBoxIguais.Clear();
            textBoxMagnitude_A.Clear();
            textBoxMagnitude_B.Clear();
            textBoxAX.Clear();
            textBoxAY.Clear();
            textBoxAZ.Clear();
            textBoxBX.Clear();
            textBoxBY.Clear();
            textBoxBZ.Clear();
            mascaraCross.Clear();
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
