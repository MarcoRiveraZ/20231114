namespace Proyecto_CSharp_Modulo1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tpTriangulo = new TabPage();
            lblAlturaTri = new Label();
            lblBaseTri = new Label();
            txtAlturaTri = new TextBox();
            txtBaseTri = new TextBox();
            tpRectangulo = new TabPage();
            tpParalelogramo = new TabPage();
            btnCrearTri = new Button();
            btnCrearRec = new Button();
            lblAlturaRec = new Label();
            lblBaseRec = new Label();
            txtBaseRec = new TextBox();
            txtAlturaRec = new TextBox();
            btnCrearPar = new Button();
            lblAlturaPar = new Label();
            lblBasePar = new Label();
            txtBasePar = new TextBox();
            txtAlturaPar = new TextBox();
            tabControl1.SuspendLayout();
            tpTriangulo.SuspendLayout();
            tpRectangulo.SuspendLayout();
            tpParalelogramo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpTriangulo);
            tabControl1.Controls.Add(tpRectangulo);
            tabControl1.Controls.Add(tpParalelogramo);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(457, 311);
            tabControl1.TabIndex = 0;
            // 
            // tpTriangulo
            // 
            tpTriangulo.Controls.Add(btnCrearTri);
            tpTriangulo.Controls.Add(lblAlturaTri);
            tpTriangulo.Controls.Add(lblBaseTri);
            tpTriangulo.Controls.Add(txtAlturaTri);
            tpTriangulo.Controls.Add(txtBaseTri);
            tpTriangulo.Location = new Point(4, 24);
            tpTriangulo.Name = "tpTriangulo";
            tpTriangulo.Padding = new Padding(3);
            tpTriangulo.Size = new Size(449, 283);
            tpTriangulo.TabIndex = 0;
            tpTriangulo.Text = "Triangulo";
            tpTriangulo.UseVisualStyleBackColor = true;
            // 
            // lblAlturaTri
            // 
            lblAlturaTri.AutoSize = true;
            lblAlturaTri.Location = new Point(97, 99);
            lblAlturaTri.Name = "lblAlturaTri";
            lblAlturaTri.Size = new Size(39, 15);
            lblAlturaTri.TabIndex = 3;
            lblAlturaTri.Text = "Altura";
            // 
            // lblBaseTri
            // 
            lblBaseTri.AutoSize = true;
            lblBaseTri.Location = new Point(97, 38);
            lblBaseTri.Name = "lblBaseTri";
            lblBaseTri.Size = new Size(31, 15);
            lblBaseTri.TabIndex = 2;
            lblBaseTri.Text = "Base";
            // 
            // txtAlturaTri
            // 
            txtAlturaTri.Location = new Point(203, 91);
            txtAlturaTri.Name = "txtAlturaTri";
            txtAlturaTri.Size = new Size(100, 23);
            txtAlturaTri.TabIndex = 1;
            // 
            // txtBaseTri
            // 
            txtBaseTri.Location = new Point(203, 30);
            txtBaseTri.Name = "txtBaseTri";
            txtBaseTri.Size = new Size(100, 23);
            txtBaseTri.TabIndex = 0;
            // 
            // tpRectangulo
            // 
            tpRectangulo.Controls.Add(btnCrearRec);
            tpRectangulo.Controls.Add(lblAlturaRec);
            tpRectangulo.Controls.Add(lblBaseRec);
            tpRectangulo.Controls.Add(txtBaseRec);
            tpRectangulo.Controls.Add(txtAlturaRec);
            tpRectangulo.Location = new Point(4, 24);
            tpRectangulo.Name = "tpRectangulo";
            tpRectangulo.Padding = new Padding(3);
            tpRectangulo.Size = new Size(449, 283);
            tpRectangulo.TabIndex = 1;
            tpRectangulo.Text = "Rectangulo";
            tpRectangulo.UseVisualStyleBackColor = true;
            // 
            // tpParalelogramo
            // 
            tpParalelogramo.Controls.Add(btnCrearPar);
            tpParalelogramo.Controls.Add(lblAlturaPar);
            tpParalelogramo.Controls.Add(lblBasePar);
            tpParalelogramo.Controls.Add(txtBasePar);
            tpParalelogramo.Controls.Add(txtAlturaPar);
            tpParalelogramo.Location = new Point(4, 24);
            tpParalelogramo.Name = "tpParalelogramo";
            tpParalelogramo.Size = new Size(449, 283);
            tpParalelogramo.TabIndex = 2;
            tpParalelogramo.Text = "Paralelogramo";
            tpParalelogramo.UseVisualStyleBackColor = true;
            // 
            // btnCrearTri
            // 
            btnCrearTri.Location = new Point(163, 161);
            btnCrearTri.Name = "btnCrearTri";
            btnCrearTri.Size = new Size(106, 23);
            btnCrearTri.TabIndex = 4;
            btnCrearTri.Text = "Crear Triangulo";
            btnCrearTri.UseVisualStyleBackColor = true;
            // 
            // btnCrearRec
            // 
            btnCrearRec.Location = new Point(181, 172);
            btnCrearRec.Name = "btnCrearRec";
            btnCrearRec.Size = new Size(106, 23);
            btnCrearRec.TabIndex = 9;
            btnCrearRec.Text = "Crear Rectangulo";
            btnCrearRec.UseVisualStyleBackColor = true;
            // 
            // lblAlturaRec
            // 
            lblAlturaRec.AutoSize = true;
            lblAlturaRec.Location = new Point(115, 110);
            lblAlturaRec.Name = "lblAlturaRec";
            lblAlturaRec.Size = new Size(39, 15);
            lblAlturaRec.TabIndex = 8;
            lblAlturaRec.Text = "Altura";
            // 
            // lblBaseRec
            // 
            lblBaseRec.AutoSize = true;
            lblBaseRec.Location = new Point(115, 49);
            lblBaseRec.Name = "lblBaseRec";
            lblBaseRec.Size = new Size(31, 15);
            lblBaseRec.TabIndex = 7;
            lblBaseRec.Text = "Base";
            // 
            // txtBaseRec
            // 
            txtBaseRec.Location = new Point(221, 41);
            txtBaseRec.Name = "txtBaseRec";
            txtBaseRec.Size = new Size(100, 23);
            txtBaseRec.TabIndex = 6;
            // 
            // txtAlturaRec
            // 
            txtAlturaRec.Location = new Point(221, 102);
            txtAlturaRec.Name = "txtAlturaRec";
            txtAlturaRec.Size = new Size(100, 23);
            txtAlturaRec.TabIndex = 5;
            // 
            // btnCrearPar
            // 
            btnCrearPar.Location = new Point(160, 177);
            btnCrearPar.Name = "btnCrearPar";
            btnCrearPar.Size = new Size(129, 23);
            btnCrearPar.TabIndex = 14;
            btnCrearPar.Text = "Crear Paralelogramo";
            btnCrearPar.UseVisualStyleBackColor = true;
            // 
            // lblAlturaPar
            // 
            lblAlturaPar.AutoSize = true;
            lblAlturaPar.Location = new Point(116, 119);
            lblAlturaPar.Name = "lblAlturaPar";
            lblAlturaPar.Size = new Size(39, 15);
            lblAlturaPar.TabIndex = 13;
            lblAlturaPar.Text = "Altura";
            // 
            // lblBasePar
            // 
            lblBasePar.AutoSize = true;
            lblBasePar.Location = new Point(116, 58);
            lblBasePar.Name = "lblBasePar";
            lblBasePar.Size = new Size(31, 15);
            lblBasePar.TabIndex = 12;
            lblBasePar.Text = "Base";
            // 
            // txtBasePar
            // 
            txtBasePar.Location = new Point(214, 50);
            txtBasePar.Name = "txtBasePar";
            txtBasePar.Size = new Size(100, 23);
            txtBasePar.TabIndex = 11;
            // 
            // txtAlturaPar
            // 
            txtAlturaPar.Location = new Point(214, 111);
            txtAlturaPar.Name = "txtAlturaPar";
            txtAlturaPar.Size = new Size(100, 23);
            txtAlturaPar.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Proyecto M1";
            tabControl1.ResumeLayout(false);
            tpTriangulo.ResumeLayout(false);
            tpTriangulo.PerformLayout();
            tpRectangulo.ResumeLayout(false);
            tpRectangulo.PerformLayout();
            tpParalelogramo.ResumeLayout(false);
            tpParalelogramo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpTriangulo;
        private TabPage tpRectangulo;
        private TabPage tpParalelogramo;
        private Label lblAlturaTri;
        private Label lblBaseTri;
        private TextBox txtAlturaTri;
        private TextBox txtBaseTri;
        private Button btnCrearTri;
        private Button btnCrearRec;
        private Label lblAlturaRec;
        private Label lblBaseRec;
        private TextBox txtBaseRec;
        private TextBox txtAlturaRec;
        private Button btnCrearPar;
        private Label lblAlturaPar;
        private Label lblBasePar;
        private TextBox txtBasePar;
        private TextBox txtAlturaPar;
    }
}