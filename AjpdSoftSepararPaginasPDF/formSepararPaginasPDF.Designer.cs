namespace AjpdSoftSepararPaginasPDF
{
    partial class formSepararPaginasPDF
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSepararPaginasPDF));
            this.linkAjpdSoft = new System.Windows.Forms.LinkLabel();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPalabrasClave = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lsFicherosPDFDivididos = new System.Windows.Forms.ListBox();
            this.lInfoProgreso = new System.Windows.Forms.Label();
            this.bp = new System.Windows.Forms.ProgressBar();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lInfoPDF = new System.Windows.Forms.Label();
            this.btSelPDFOrigen = new System.Windows.Forms.Button();
            this.txtFicheroPDFOrigen = new System.Windows.Forms.TextBox();
            this.dlAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSepararPaginasPDF = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bSelCarpetaDestinoPDF = new System.Windows.Forms.Button();
            this.txtCarpetaDestinoPDF = new System.Windows.Forms.TextBox();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkAjpdSoft
            // 
            this.linkAjpdSoft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAjpdSoft.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAjpdSoft.Location = new System.Drawing.Point(18, 558);
            this.linkAjpdSoft.Name = "linkAjpdSoft";
            this.linkAjpdSoft.Size = new System.Drawing.Size(702, 13);
            this.linkAjpdSoft.TabIndex = 11;
            this.linkAjpdSoft.TabStop = true;
            this.linkAjpdSoft.Text = "Más aplicaciones gratuitas y nuevas versiones en www.ajpdsoft.com";
            this.linkAjpdSoft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkAjpdSoft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAjpdSoft_LinkClicked);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox3.Controls.Add(this.label8);
            this.GroupBox3.Controls.Add(this.txtAutor);
            this.GroupBox3.Controls.Add(this.label5);
            this.GroupBox3.Controls.Add(this.txtPalabrasClave);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.txtAsunto);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.txtTitulo);
            this.GroupBox3.Controls.Add(this.label4);
            this.GroupBox3.Location = new System.Drawing.Point(18, 80);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(702, 118);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Información de los ficheros PDF  que se crearán ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(85, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(471, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Estos metadatos se añadirán a los ficheros PDF resultantes de cada página del fic" +
    "hero PDF origen";
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutor.Location = new System.Drawing.Point(486, 76);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(202, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Autor";
            // 
            // txtPalabrasClave
            // 
            this.txtPalabrasClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPalabrasClave.Location = new System.Drawing.Point(84, 77);
            this.txtPalabrasClave.Name = "txtPalabrasClave";
            this.txtPalabrasClave.Size = new System.Drawing.Size(363, 20);
            this.txtPalabrasClave.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 78);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Palabras clave";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsunto.Location = new System.Drawing.Point(84, 51);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(604, 20);
            this.txtAsunto.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(44, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Asunto";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.Location = new System.Drawing.Point(84, 26);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(604, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Título";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox2.Controls.Add(this.lsFicherosPDFDivididos);
            this.GroupBox2.Controls.Add(this.lInfoProgreso);
            this.GroupBox2.Controls.Add(this.bp);
            this.GroupBox2.Location = new System.Drawing.Point(18, 358);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(702, 195);
            this.GroupBox2.TabIndex = 4;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Resultado";
            // 
            // lsFicherosPDFDivididos
            // 
            this.lsFicherosPDFDivididos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsFicherosPDFDivididos.FormattingEnabled = true;
            this.lsFicherosPDFDivididos.Location = new System.Drawing.Point(17, 57);
            this.lsFicherosPDFDivididos.Name = "lsFicherosPDFDivididos";
            this.lsFicherosPDFDivididos.ScrollAlwaysVisible = true;
            this.lsFicherosPDFDivididos.Size = new System.Drawing.Size(665, 134);
            this.lsFicherosPDFDivididos.TabIndex = 3;
            this.lsFicherosPDFDivididos.DoubleClick += new System.EventHandler(this.lsFicherosPDFDivididos_DoubleClick);
            // 
            // lInfoProgreso
            // 
            this.lInfoProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lInfoProgreso.Location = new System.Drawing.Point(17, 21);
            this.lInfoProgreso.Name = "lInfoProgreso";
            this.lInfoProgreso.Size = new System.Drawing.Size(665, 13);
            this.lInfoProgreso.TabIndex = 2;
            // 
            // bp
            // 
            this.bp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bp.Location = new System.Drawing.Point(16, 38);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(666, 13);
            this.bp.TabIndex = 1;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.lInfoPDF);
            this.GroupBox1.Controls.Add(this.btSelPDFOrigen);
            this.GroupBox1.Controls.Add(this.txtFicheroPDFOrigen);
            this.GroupBox1.Location = new System.Drawing.Point(18, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(702, 65);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Fichero PDF a dividir ";
            // 
            // lInfoPDF
            // 
            this.lInfoPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lInfoPDF.Location = new System.Drawing.Point(19, 46);
            this.lInfoPDF.Name = "lInfoPDF";
            this.lInfoPDF.Size = new System.Drawing.Size(666, 13);
            this.lInfoPDF.TabIndex = 24;
            // 
            // btSelPDFOrigen
            // 
            this.btSelPDFOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelPDFOrigen.Location = new System.Drawing.Point(664, 20);
            this.btSelPDFOrigen.Name = "btSelPDFOrigen";
            this.btSelPDFOrigen.Size = new System.Drawing.Size(24, 23);
            this.btSelPDFOrigen.TabIndex = 1;
            this.btSelPDFOrigen.Text = "...";
            this.btSelPDFOrigen.UseVisualStyleBackColor = true;
            this.btSelPDFOrigen.Click += new System.EventHandler(this.btSelPDFOrigen_Click);
            // 
            // txtFicheroPDFOrigen
            // 
            this.txtFicheroPDFOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFicheroPDFOrigen.Location = new System.Drawing.Point(16, 22);
            this.txtFicheroPDFOrigen.Name = "txtFicheroPDFOrigen";
            this.txtFicheroPDFOrigen.Size = new System.Drawing.Size(642, 20);
            this.txtFicheroPDFOrigen.TabIndex = 0;
            this.txtFicheroPDFOrigen.TextChanged += new System.EventHandler(this.txtFicheroPDFOrigen_TextChanged);
            // 
            // dlAbrir
            // 
            this.dlAbrir.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtNombre);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btSepararPaginasPDF);
            this.groupBox4.Controls.Add(this.shapeContainer1);
            this.groupBox4.Location = new System.Drawing.Point(18, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(702, 82);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Separar páginas PDF ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(70, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nombre de los ficheros PDF, se añadirá el número de página al final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(71, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(460, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre";
            // 
            // btSepararPaginasPDF
            // 
            this.btSepararPaginasPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSepararPaginasPDF.Image = ((System.Drawing.Image)(resources.GetObject("btSepararPaginasPDF.Image")));
            this.btSepararPaginasPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSepararPaginasPDF.Location = new System.Drawing.Point(540, 23);
            this.btSepararPaginasPDF.Name = "btSepararPaginasPDF";
            this.btSepararPaginasPDF.Size = new System.Drawing.Size(142, 48);
            this.btSepararPaginasPDF.TabIndex = 1;
            this.btSepararPaginasPDF.Text = "Ejecutar proceso";
            this.btSepararPaginasPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSepararPaginasPDF.UseVisualStyleBackColor = true;
            this.btSepararPaginasPDF.Click += new System.EventHandler(this.btSepararPaginasPDF_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(696, 63);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 533;
            this.lineShape1.X2 = 533;
            this.lineShape1.Y1 = 9;
            this.lineShape1.Y2 = 53;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.bSelCarpetaDestinoPDF);
            this.groupBox5.Controls.Add(this.txtCarpetaDestinoPDF);
            this.groupBox5.Location = new System.Drawing.Point(18, 207);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(701, 52);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Carpeta de destino de los ficheros PDF que se crearán de cada página ";
            // 
            // bSelCarpetaDestinoPDF
            // 
            this.bSelCarpetaDestinoPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSelCarpetaDestinoPDF.Location = new System.Drawing.Point(658, 22);
            this.bSelCarpetaDestinoPDF.Name = "bSelCarpetaDestinoPDF";
            this.bSelCarpetaDestinoPDF.Size = new System.Drawing.Size(24, 23);
            this.bSelCarpetaDestinoPDF.TabIndex = 1;
            this.bSelCarpetaDestinoPDF.Text = "...";
            this.bSelCarpetaDestinoPDF.UseVisualStyleBackColor = true;
            this.bSelCarpetaDestinoPDF.Click += new System.EventHandler(this.bSelCarpetaDestinoPDF_Click);
            // 
            // txtCarpetaDestinoPDF
            // 
            this.txtCarpetaDestinoPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarpetaDestinoPDF.Location = new System.Drawing.Point(17, 24);
            this.txtCarpetaDestinoPDF.Name = "txtCarpetaDestinoPDF";
            this.txtCarpetaDestinoPDF.Size = new System.Drawing.Size(635, 20);
            this.txtCarpetaDestinoPDF.TabIndex = 0;
            // 
            // formSepararPaginasPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 581);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.linkAjpdSoft);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSepararPaginasPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjpdSoft Separar Páginas PDF";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.LinkLabel linkAjpdSoft;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lInfoProgreso;
        internal System.Windows.Forms.ProgressBar bp;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btSelPDFOrigen;
        internal System.Windows.Forms.TextBox txtFicheroPDFOrigen;
        private System.Windows.Forms.OpenFileDialog dlAbrir;
        private System.Windows.Forms.FolderBrowserDialog dlCarpeta;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button btSepararPaginasPDF;
        internal System.Windows.Forms.TextBox txtPalabrasClave;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtAsunto;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtTitulo;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Button bSelCarpetaDestinoPDF;
        internal System.Windows.Forms.TextBox txtCarpetaDestinoPDF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        internal System.Windows.Forms.TextBox txtAutor;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lsFicherosPDFDivididos;
        private System.Windows.Forms.Label lInfoPDF;
        private System.Windows.Forms.Label label8;
    }
}

