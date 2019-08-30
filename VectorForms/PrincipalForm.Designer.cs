namespace VectorForms
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button2D;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            System.Windows.Forms.Button buttonVetor3D;
            this.labelInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            button2D = new System.Windows.Forms.Button();
            buttonVetor3D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2D
            // 
            button2D.BackColor = System.Drawing.Color.Black;
            button2D.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(button2D, "button2D");
            button2D.ForeColor = System.Drawing.Color.WhiteSmoke;
            button2D.Name = "button2D";
            button2D.UseVisualStyleBackColor = false;
            button2D.Click += new System.EventHandler(this.Button2D_Click);
            // 
            // buttonVetor3D
            // 
            buttonVetor3D.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(buttonVetor3D, "buttonVetor3D");
            buttonVetor3D.ForeColor = System.Drawing.Color.WhiteSmoke;
            buttonVetor3D.Name = "buttonVetor3D";
            buttonVetor3D.UseVisualStyleBackColor = false;
            buttonVetor3D.Click += new System.EventHandler(this.ButtonVetor3D_Click);
            // 
            // labelInicio
            // 
            resources.ApplyResources(this.labelInicio, "labelInicio");
            this.labelInicio.Name = "labelInicio";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // PrincipalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Pink;
            this.CancelButton = button2D;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(buttonVetor3D);
            this.Controls.Add(button2D);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrincipalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label label1;
    }
}