namespace VectorForms
{
    partial class Form2D
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2D));
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mascaraSoma = new System.Windows.Forms.MaskedTextBox();
            this.labelSoma = new System.Windows.Forms.Label();
            this.mascaraSubtracao = new System.Windows.Forms.MaskedTextBox();
            this.labelSubtracao = new System.Windows.Forms.Label();
            this.mascaraMultiplicacaoEscalar_A = new System.Windows.Forms.MaskedTextBox();
            this.labelMultiplicacaoEscalar = new System.Windows.Forms.Label();
            this.mascaraDot = new System.Windows.Forms.MaskedTextBox();
            this.labelDot = new System.Windows.Forms.Label();
            this.labelIgualdade = new System.Windows.Forms.Label();
            this.textBoxIguais = new System.Windows.Forms.TextBox();
            this.textBoxMagnitude_B = new System.Windows.Forms.TextBox();
            this.textBoxAX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelEscalar = new System.Windows.Forms.Label();
            this.textBoxEscalar = new System.Windows.Forms.TextBox();
            this.mascaraProjecao = new System.Windows.Forms.MaskedTextBox();
            this.labelProjecao = new System.Windows.Forms.Label();
            this.mascaraUnitario_A = new System.Windows.Forms.MaskedTextBox();
            this.labelUnitario = new System.Windows.Forms.Label();
            this.mascaraMultiplicacaoEscalar_B = new System.Windows.Forms.MaskedTextBox();
            this.mascaraDivisaoEscalar_A = new System.Windows.Forms.MaskedTextBox();
            this.labelParente = new System.Windows.Forms.Label();
            this.labelDivisaoEscalar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mascaraDivisaoEscalar_B = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBX = new System.Windows.Forms.TextBox();
            this.labelVetB = new System.Windows.Forms.Label();
            this.labelMagnitude = new System.Windows.Forms.Label();
            this.textBoxMagnitude_A = new System.Windows.Forms.TextBox();
            this.panel2D = new System.Windows.Forms.Panel();
            this.textBoxBY = new System.Windows.Forms.TextBox();
            this.labelTituloVetorB = new System.Windows.Forms.Label();
            this.labelTituloA = new System.Windows.Forms.Label();
            this.mascaraUnitario_B = new System.Windows.Forms.MaskedTextBox();
            this.buttonLimpaCampos = new System.Windows.Forms.Button();
            this.panel2D.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.Green;
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCalcular.Location = new System.Drawing.Point(136, 327);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(126, 45);
            this.buttonCalcular.TabIndex = 7;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "A:";
            // 
            // mascaraSoma
            // 
            this.mascaraSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascaraSoma.Location = new System.Drawing.Point(123, 171);
            this.mascaraSoma.Name = "mascaraSoma";
            this.mascaraSoma.ReadOnly = true;
            this.mascaraSoma.Size = new System.Drawing.Size(111, 26);
            this.mascaraSoma.TabIndex = 6;
            this.mascaraSoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSoma
            // 
            this.labelSoma.AutoSize = true;
            this.labelSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoma.Location = new System.Drawing.Point(54, 173);
            this.labelSoma.Name = "labelSoma";
            this.labelSoma.Size = new System.Drawing.Size(64, 24);
            this.labelSoma.TabIndex = 7;
            this.labelSoma.Text = "Soma:";
            // 
            // mascaraSubtracao
            // 
            this.mascaraSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascaraSubtracao.Location = new System.Drawing.Point(123, 82);
            this.mascaraSubtracao.Name = "mascaraSubtracao";
            this.mascaraSubtracao.ReadOnly = true;
            this.mascaraSubtracao.Size = new System.Drawing.Size(111, 26);
            this.mascaraSubtracao.TabIndex = 8;
            this.mascaraSubtracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSubtracao
            // 
            this.labelSubtracao.AutoSize = true;
            this.labelSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtracao.Location = new System.Drawing.Point(17, 82);
            this.labelSubtracao.Name = "labelSubtracao";
            this.labelSubtracao.Size = new System.Drawing.Size(100, 24);
            this.labelSubtracao.TabIndex = 9;
            this.labelSubtracao.Text = "Subtração:";
            // 
            // mascaraMultiplicacaoEscalar_A
            // 
            this.mascaraMultiplicacaoEscalar_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascaraMultiplicacaoEscalar_A.Location = new System.Drawing.Point(487, 128);
            this.mascaraMultiplicacaoEscalar_A.Name = "mascaraMultiplicacaoEscalar_A";
            this.mascaraMultiplicacaoEscalar_A.ReadOnly = true;
            this.mascaraMultiplicacaoEscalar_A.Size = new System.Drawing.Size(111, 26);
            this.mascaraMultiplicacaoEscalar_A.TabIndex = 12;
            this.mascaraMultiplicacaoEscalar_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMultiplicacaoEscalar
            // 
            this.labelMultiplicacaoEscalar.AutoSize = true;
            this.labelMultiplicacaoEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMultiplicacaoEscalar.Location = new System.Drawing.Point(290, 128);
            this.labelMultiplicacaoEscalar.Name = "labelMultiplicacaoEscalar";
            this.labelMultiplicacaoEscalar.Size = new System.Drawing.Size(191, 24);
            this.labelMultiplicacaoEscalar.TabIndex = 13;
            this.labelMultiplicacaoEscalar.Text = "Multiplicação Escalar:";
            // 
            // mascaraDot
            // 
            this.mascaraDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascaraDot.Location = new System.Drawing.Point(123, 216);
            this.mascaraDot.Name = "mascaraDot";
            this.mascaraDot.ReadOnly = true;
            this.mascaraDot.Size = new System.Drawing.Size(111, 26);
            this.mascaraDot.TabIndex = 14;
            this.mascaraDot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDot
            // 
            this.labelDot.AutoSize = true;
            this.labelDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDot.Location = new System.Drawing.Point(74, 216);
            this.labelDot.Name = "labelDot";
            this.labelDot.Size = new System.Drawing.Size(43, 24);
            this.labelDot.TabIndex = 15;
            this.labelDot.Text = "Dot:";
            // 
            // labelIgualdade
            // 
            this.labelIgualdade.AutoSize = true;
            this.labelIgualdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIgualdade.Location = new System.Drawing.Point(42, 259);
            this.labelIgualdade.Name = "labelIgualdade";
            this.labelIgualdade.Size = new System.Drawing.Size(64, 24);
            this.labelIgualdade.TabIndex = 16;
            this.labelIgualdade.Text = "Iguais:";
            // 
            // textBoxIguais
            // 
            this.textBoxIguais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIguais.Location = new System.Drawing.Point(123, 259);
            this.textBoxIguais.Name = "textBoxIguais";
            this.textBoxIguais.ReadOnly = true;
            this.textBoxIguais.Size = new System.Drawing.Size(54, 26);
            this.textBoxIguais.TabIndex = 17;
            this.textBoxIguais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMagnitude_B
            // 
            this.textBoxMagnitude_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMagnitude_B.Location = new System.Drawing.Point(614, 261);
            this.textBoxMagnitude_B.Name = "textBoxMagnitude_B";
            this.textBoxMagnitude_B.ReadOnly = true;
            this.textBoxMagnitude_B.Size = new System.Drawing.Size(54, 26);
            this.textBoxMagnitude_B.TabIndex = 19;
            this.textBoxMagnitude_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAX
            // 
            this.textBoxAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAX.Location = new System.Drawing.Point(63, 23);
            this.textBoxAX.Name = "textBoxAX";
            this.textBoxAX.Size = new System.Drawing.Size(54, 26);
            this.textBoxAX.TabIndex = 20;
            this.textBoxAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = ",";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "(";
            // 
            // textBoxAY
            // 
            this.textBoxAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAY.Location = new System.Drawing.Point(137, 22);
            this.textBoxAY.Name = "textBoxAY";
            this.textBoxAY.Size = new System.Drawing.Size(54, 26);
            this.textBoxAY.TabIndex = 23;
            this.textBoxAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = ")";
            // 
            // labelEscalar
            // 
            this.labelEscalar.AutoSize = true;
            this.labelEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscalar.Location = new System.Drawing.Point(542, 27);
            this.labelEscalar.Name = "labelEscalar";
            this.labelEscalar.Size = new System.Drawing.Size(77, 24);
            this.labelEscalar.TabIndex = 30;
            this.labelEscalar.Text = "Escalar:";
            // 
            // textBoxEscalar
            // 
            this.textBoxEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEscalar.Location = new System.Drawing.Point(619, 25);
            this.textBoxEscalar.Name = "textBoxEscalar";
            this.textBoxEscalar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxEscalar.Size = new System.Drawing.Size(54, 26);
            this.textBoxEscalar.TabIndex = 59;
            this.textBoxEscalar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mascaraProjecao
            // 
            this.mascaraProjecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascaraProjecao.Location = new System.Drawing.Point(123, 126);
            this.mascaraProjecao.Name = "mascaraProjecao";
            this.mascaraProjecao.ReadOnly = true;
            this.mascaraProjecao.Size = new System.Drawing.Size(111, 26);
            this.mascaraProjecao.TabIndex = 61;
            this.mascaraProjecao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelProjecao
            // 
            this.labelProjecao.AutoSize = true;
            this.labelProjecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjecao.Location = new System.Drawing.Point(27, 128);
            this.labelProjecao.Name = "labelProjecao";
            this.labelProjecao.Size = new System.Drawing.Size(90, 24);
            this.labelProjecao.TabIndex = 62;
            this.labelProjecao.Text = "Projeção:";
            // 
            // mascaraUnitario_A
            // 
            this.mascaraUnitario_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascaraUnitario_A.Location = new System.Drawing.Point(487, 216);
            this.mascaraUnitario_A.Name = "mascaraUnitario_A";
            this.mascaraUnitario_A.ReadOnly = true;
            this.mascaraUnitario_A.Size = new System.Drawing.Size(111, 26);
            this.mascaraUnitario_A.TabIndex = 63;
            this.mascaraUnitario_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelUnitario
            // 
            this.labelUnitario.AutoSize = true;
            this.labelUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitario.Location = new System.Drawing.Point(353, 216);
            this.labelUnitario.Name = "labelUnitario";
            this.labelUnitario.Size = new System.Drawing.Size(128, 24);
            this.labelUnitario.TabIndex = 64;
            this.labelUnitario.Text = "Vetor Unitário:";
            // 
            // mascaraMultiplicacaoEscalar_B
            // 
            this.mascaraMultiplicacaoEscalar_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascaraMultiplicacaoEscalar_B.Location = new System.Drawing.Point(614, 128);
            this.mascaraMultiplicacaoEscalar_B.Name = "mascaraMultiplicacaoEscalar_B";
            this.mascaraMultiplicacaoEscalar_B.ReadOnly = true;
            this.mascaraMultiplicacaoEscalar_B.Size = new System.Drawing.Size(111, 26);
            this.mascaraMultiplicacaoEscalar_B.TabIndex = 65;
            this.mascaraMultiplicacaoEscalar_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mascaraDivisaoEscalar_A
            // 
            this.mascaraDivisaoEscalar_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascaraDivisaoEscalar_A.Location = new System.Drawing.Point(487, 173);
            this.mascaraDivisaoEscalar_A.Name = "mascaraDivisaoEscalar_A";
            this.mascaraDivisaoEscalar_A.ReadOnly = true;
            this.mascaraDivisaoEscalar_A.Size = new System.Drawing.Size(111, 26);
            this.mascaraDivisaoEscalar_A.TabIndex = 67;
            this.mascaraDivisaoEscalar_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelParente
            // 
            this.labelParente.AutoSize = true;
            this.labelParente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParente.Location = new System.Drawing.Point(313, 21);
            this.labelParente.Name = "labelParente";
            this.labelParente.Size = new System.Drawing.Size(21, 29);
            this.labelParente.TabIndex = 27;
            this.labelParente.Text = "(";
            // 
            // labelDivisaoEscalar
            // 
            this.labelDivisaoEscalar.AutoSize = true;
            this.labelDivisaoEscalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivisaoEscalar.Location = new System.Drawing.Point(339, 173);
            this.labelDivisaoEscalar.Name = "labelDivisaoEscalar";
            this.labelDivisaoEscalar.Size = new System.Drawing.Size(142, 24);
            this.labelDivisaoEscalar.TabIndex = 68;
            this.labelDivisaoEscalar.Text = "Divisão Escalar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = ")";
            // 
            // mascaraDivisaoEscalar_B
            // 
            this.mascaraDivisaoEscalar_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascaraDivisaoEscalar_B.Location = new System.Drawing.Point(614, 173);
            this.mascaraDivisaoEscalar_B.Name = "mascaraDivisaoEscalar_B";
            this.mascaraDivisaoEscalar_B.ReadOnly = true;
            this.mascaraDivisaoEscalar_B.Size = new System.Drawing.Size(111, 26);
            this.mascaraDivisaoEscalar_B.TabIndex = 69;
            this.mascaraDivisaoEscalar_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(395, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = ",";
            // 
            // textBoxBX
            // 
            this.textBoxBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBX.Location = new System.Drawing.Point(336, 25);
            this.textBoxBX.Name = "textBoxBX";
            this.textBoxBX.Size = new System.Drawing.Size(54, 26);
            this.textBoxBX.TabIndex = 25;
            this.textBoxBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelVetB
            // 
            this.labelVetB.AutoSize = true;
            this.labelVetB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVetB.Location = new System.Drawing.Point(290, 25);
            this.labelVetB.Name = "labelVetB";
            this.labelVetB.Size = new System.Drawing.Size(27, 24);
            this.labelVetB.TabIndex = 4;
            this.labelVetB.Text = "B:";
            // 
            // labelMagnitude
            // 
            this.labelMagnitude.AllowDrop = true;
            this.labelMagnitude.AutoSize = true;
            this.labelMagnitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMagnitude.Location = new System.Drawing.Point(353, 261);
            this.labelMagnitude.Name = "labelMagnitude";
            this.labelMagnitude.Size = new System.Drawing.Size(104, 24);
            this.labelMagnitude.TabIndex = 71;
            this.labelMagnitude.Text = "Magnitude:";
            // 
            // textBoxMagnitude_A
            // 
            this.textBoxMagnitude_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMagnitude_A.Location = new System.Drawing.Point(487, 261);
            this.textBoxMagnitude_A.Name = "textBoxMagnitude_A";
            this.textBoxMagnitude_A.ReadOnly = true;
            this.textBoxMagnitude_A.Size = new System.Drawing.Size(54, 26);
            this.textBoxMagnitude_A.TabIndex = 72;
            this.textBoxMagnitude_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2D
            // 
            this.panel2D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2D.Controls.Add(this.textBoxBY);
            this.panel2D.Controls.Add(this.labelTituloVetorB);
            this.panel2D.Controls.Add(this.labelTituloA);
            this.panel2D.Controls.Add(this.mascaraUnitario_B);
            this.panel2D.Controls.Add(this.textBoxMagnitude_A);
            this.panel2D.Controls.Add(this.labelMagnitude);
            this.panel2D.Controls.Add(this.labelVetB);
            this.panel2D.Controls.Add(this.textBoxBX);
            this.panel2D.Controls.Add(this.label10);
            this.panel2D.Controls.Add(this.mascaraDivisaoEscalar_B);
            this.panel2D.Controls.Add(this.label8);
            this.panel2D.Controls.Add(this.labelDivisaoEscalar);
            this.panel2D.Controls.Add(this.labelParente);
            this.panel2D.Controls.Add(this.mascaraDivisaoEscalar_A);
            this.panel2D.Controls.Add(this.mascaraMultiplicacaoEscalar_B);
            this.panel2D.Controls.Add(this.labelUnitario);
            this.panel2D.Controls.Add(this.mascaraUnitario_A);
            this.panel2D.Controls.Add(this.labelProjecao);
            this.panel2D.Controls.Add(this.mascaraProjecao);
            this.panel2D.Controls.Add(this.textBoxEscalar);
            this.panel2D.Controls.Add(this.labelEscalar);
            this.panel2D.Controls.Add(this.label7);
            this.panel2D.Controls.Add(this.textBoxAY);
            this.panel2D.Controls.Add(this.label6);
            this.panel2D.Controls.Add(this.label5);
            this.panel2D.Controls.Add(this.textBoxAX);
            this.panel2D.Controls.Add(this.textBoxMagnitude_B);
            this.panel2D.Controls.Add(this.textBoxIguais);
            this.panel2D.Controls.Add(this.labelIgualdade);
            this.panel2D.Controls.Add(this.labelDot);
            this.panel2D.Controls.Add(this.mascaraDot);
            this.panel2D.Controls.Add(this.labelMultiplicacaoEscalar);
            this.panel2D.Controls.Add(this.mascaraMultiplicacaoEscalar_A);
            this.panel2D.Controls.Add(this.labelSubtracao);
            this.panel2D.Controls.Add(this.mascaraSubtracao);
            this.panel2D.Controls.Add(this.labelSoma);
            this.panel2D.Controls.Add(this.mascaraSoma);
            this.panel2D.Controls.Add(this.label2);
            this.panel2D.Location = new System.Drawing.Point(12, 12);
            this.panel2D.Name = "panel2D";
            this.panel2D.Size = new System.Drawing.Size(802, 309);
            this.panel2D.TabIndex = 6;
            // 
            // textBoxBY
            // 
            this.textBoxBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBY.Location = new System.Drawing.Point(411, 24);
            this.textBoxBY.Name = "textBoxBY";
            this.textBoxBY.Size = new System.Drawing.Size(54, 26);
            this.textBoxBY.TabIndex = 76;
            this.textBoxBY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTituloVetorB
            // 
            this.labelTituloVetorB.AutoSize = true;
            this.labelTituloVetorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloVetorB.Location = new System.Drawing.Point(610, 82);
            this.labelTituloVetorB.Name = "labelTituloVetorB";
            this.labelTituloVetorB.Size = new System.Drawing.Size(85, 24);
            this.labelTituloVetorB.TabIndex = 75;
            this.labelTituloVetorB.Text = "Vetor B:";
            // 
            // labelTituloA
            // 
            this.labelTituloA.AutoSize = true;
            this.labelTituloA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloA.Location = new System.Drawing.Point(483, 82);
            this.labelTituloA.Name = "labelTituloA";
            this.labelTituloA.Size = new System.Drawing.Size(86, 24);
            this.labelTituloA.TabIndex = 74;
            this.labelTituloA.Text = "Vetor A:";
            // 
            // mascaraUnitario_B
            // 
            this.mascaraUnitario_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascaraUnitario_B.Location = new System.Drawing.Point(614, 216);
            this.mascaraUnitario_B.Name = "mascaraUnitario_B";
            this.mascaraUnitario_B.ReadOnly = true;
            this.mascaraUnitario_B.Size = new System.Drawing.Size(111, 26);
            this.mascaraUnitario_B.TabIndex = 73;
            this.mascaraUnitario_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonLimpaCampos
            // 
            this.buttonLimpaCampos.BackColor = System.Drawing.Color.Red;
            this.buttonLimpaCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpaCampos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLimpaCampos.Location = new System.Drawing.Point(489, 328);
            this.buttonLimpaCampos.Name = "buttonLimpaCampos";
            this.buttonLimpaCampos.Size = new System.Drawing.Size(126, 45);
            this.buttonLimpaCampos.TabIndex = 8;
            this.buttonLimpaCampos.Text = "Limpar";
            this.buttonLimpaCampos.UseVisualStyleBackColor = false;
            this.buttonLimpaCampos.Click += new System.EventHandler(this.ButtonLimpaCampos_Click);
            // 
            // Form2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(826, 385);
            this.Controls.Add(this.buttonLimpaCampos);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.panel2D);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2D";
            this.Text = "FormVector2D";
            this.panel2D.ResumeLayout(false);
            this.panel2D.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mascaraSoma;
        private System.Windows.Forms.Label labelSoma;
        private System.Windows.Forms.MaskedTextBox mascaraSubtracao;
        private System.Windows.Forms.Label labelSubtracao;
        private System.Windows.Forms.MaskedTextBox mascaraMultiplicacaoEscalar_A;
        private System.Windows.Forms.Label labelMultiplicacaoEscalar;
        private System.Windows.Forms.MaskedTextBox mascaraDot;
        private System.Windows.Forms.Label labelDot;
        private System.Windows.Forms.Label labelIgualdade;
        private System.Windows.Forms.TextBox textBoxIguais;
        private System.Windows.Forms.TextBox textBoxMagnitude_B;
        private System.Windows.Forms.TextBox textBoxAX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEscalar;
        private System.Windows.Forms.TextBox textBoxEscalar;
        private System.Windows.Forms.MaskedTextBox mascaraProjecao;
        private System.Windows.Forms.Label labelProjecao;
        private System.Windows.Forms.MaskedTextBox mascaraUnitario_A;
        private System.Windows.Forms.Label labelUnitario;
        private System.Windows.Forms.MaskedTextBox mascaraMultiplicacaoEscalar_B;
        private System.Windows.Forms.MaskedTextBox mascaraDivisaoEscalar_A;
        private System.Windows.Forms.Label labelParente;
        private System.Windows.Forms.Label labelDivisaoEscalar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mascaraDivisaoEscalar_B;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBX;
        private System.Windows.Forms.Label labelVetB;
        private System.Windows.Forms.Label labelMagnitude;
        private System.Windows.Forms.TextBox textBoxMagnitude_A;
        private System.Windows.Forms.Panel panel2D;
        private System.Windows.Forms.MaskedTextBox mascaraUnitario_B;
        private System.Windows.Forms.Label labelTituloVetorB;
        private System.Windows.Forms.Label labelTituloA;
        private System.Windows.Forms.TextBox textBoxBY;
        private System.Windows.Forms.Button buttonLimpaCampos;
    }
}

