using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace AjpdSoftSepararPaginasPDF
{
    public partial class formSepararPaginasPDF : Form
    {
        public formSepararPaginasPDF()
        {
            InitializeComponent();
        }

        private void linkAjpdSoft_LinkClicked(object sender, 
            LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ajpdsoft.com");
        }

        private void btSelPDFOrigen_Click(object sender, EventArgs e)
        {
            dlAbrir.CheckFileExists = true;
            dlAbrir.CheckPathExists = true;
            dlAbrir.Multiselect = false;
            dlAbrir.DefaultExt = "pdf";
            dlAbrir.FileName = "";
            dlAbrir.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            dlAbrir.Title = "Seleccionar fichero PDF a dividir y separar páginas";
            if (dlAbrir.ShowDialog() == DialogResult.OK) 
            {
                txtFicheroPDFOrigen.Text = dlAbrir.FileName;
            }          
        }

        private void bSelCarpetaDestinoPDF_Click(object sender, EventArgs e)
        {
            dlCarpeta.RootFolder = System.Environment.SpecialFolder.Desktop;
            dlCarpeta.ShowNewFolderButton = true;
            dlCarpeta.Description = "Selecciona la carpeta de destino de los ficheros " + 
                    "PDF resultantes de extraer cada página del PDF " +
                    "origen en un fichero PDF destino"; 
            if (dlCarpeta.ShowDialog() == DialogResult.OK)
            {
                txtCarpetaDestinoPDF.Text = dlCarpeta.SelectedPath;
            }
        }


        private void btSepararPaginasPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaFicheroPDFOrigenDividir = txtFicheroPDFOrigen.Text;

                if (!File.Exists(rutaFicheroPDFOrigenDividir))
                {
                    MessageBox.Show("El fichero origen del que se extraerán las páginas " +
                        "en ficheros PDF divididos no existe.", "Fichero origen PDF no existe",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFicheroPDFOrigen.Focus();
                }
                else
                {
                    if (!Directory.Exists(txtCarpetaDestinoPDF.Text))
                    {
                        MessageBox.Show("La carpeta de destino donde se crearán los " +
                            "ficheros PDF de las páginas extraídas no existe.",
                            "Carpeta destino para PDF no existe",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCarpetaDestinoPDF.Focus();
                    }
                    else
                    {
                        PdfDocument ficheroPDFOrigenDividir =
                            PdfReader.Open(rutaFicheroPDFOrigenDividir, PdfDocumentOpenMode.Import);

                        string nombreFicheroDestinoPaginasPDF =
                            Path.GetFileNameWithoutExtension(txtNombre.Text);
                        lInfoProgreso.Text = "Extrayendo páginas de fichero PDF";
                        lInfoProgreso.Refresh();
                        bp.Minimum = 0;
                        bp.Maximum = ficheroPDFOrigenDividir.PageCount;
                        bp.Value = 0;
                        for (int paginaPDFActual = 0;
                            paginaPDFActual < ficheroPDFOrigenDividir.PageCount;
                            paginaPDFActual++)
                        {
                            lInfoProgreso.Text = "Dividiendo página " +
                                Convert.ToString(paginaPDFActual + 1);
                            lInfoProgreso.Refresh();

                            // Crear el documento PDF destino de la página extraida
                            PdfDocument ficheroPDFPaginaDestino = new PdfDocument();
                            ficheroPDFPaginaDestino.Info.Subject = txtAsunto.Text;
                            ficheroPDFPaginaDestino.Info.Title = txtTitulo.Text;
                            ficheroPDFPaginaDestino.Info.Author = txtAutor.Text;
                            ficheroPDFPaginaDestino.Info.Keywords = txtPalabrasClave.Text;
                            ficheroPDFPaginaDestino.Info.Creator = Application.ProductName;
                            ficheroPDFPaginaDestino.Info.ModificationDate = DateTime.Now;

                            /*
                             ficheroPDFPaginaDestino.Info.Title =
                                String.Format("Página {0} de {1}", paginaPDFActual + 1,
                                ficheroPDFOrigenDividir.PageCount);
                            */

                            // Añadir la página y guardar el fichero PDF creado
                            ficheroPDFPaginaDestino.AddPage(ficheroPDFOrigenDividir.Pages[paginaPDFActual]);
                            string nombreFicheroPDFDestino = Path.Combine(txtCarpetaDestinoPDF.Text,
                                nombreFicheroDestinoPaginasPDF + " - Página " +
                                Convert.ToString(paginaPDFActual + 1)) + ".pdf";
                            ficheroPDFPaginaDestino.Save(nombreFicheroPDFDestino);
                            lsFicherosPDFDivididos.Items.Add(nombreFicheroPDFDestino);
                            bp.Value = paginaPDFActual + 1;
                        }
                        lInfoProgreso.Text = "Fichero dividido en páginas correctamente: se han generado " +
                            Convert.ToString(ficheroPDFOrigenDividir.PageCount) + " ficheros PDF";
                        lInfoProgreso.Refresh();
                    }
                }
            }
            catch (Exception errorM)
            {
                MessageBox.Show("Error al extraer páginas de fichero PDF." +
                    System.Environment.NewLine + System.Environment.NewLine +
                    errorM.Message, "Error al crear PDF",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFicheroPDFOrigen_TextChanged(object sender, EventArgs e)
        {
            string rutaFicheroPDFOrigenDividir = txtFicheroPDFOrigen.Text;

            if (File.Exists(rutaFicheroPDFOrigenDividir))
            {
                try
                {
                    PdfDocument ficheroPDFOrigenDividir =
                        PdfReader.Open(rutaFicheroPDFOrigenDividir, PdfDocumentOpenMode.InformationOnly);

                    txtNombre.Text =
                        Path.GetFileNameWithoutExtension(rutaFicheroPDFOrigenDividir);
                    txtTitulo.Text = ficheroPDFOrigenDividir.Info.Title;
                    txtAutor.Text = ficheroPDFOrigenDividir.Info.Author;
                    txtAsunto.Text = ficheroPDFOrigenDividir.Info.Subject;
                    txtPalabrasClave.Text = ficheroPDFOrigenDividir.Info.Keywords;
                    lInfoPDF.Text = "Nº de páginas: " + ficheroPDFOrigenDividir.PageCount +
                        ", se generarán " + ficheroPDFOrigenDividir.PageCount +
                        " ficheros PDF, uno por cada página del fichero PDF origen";
                }
                catch (Exception errorM)
                {
                    MessageBox.Show("Error al leer fichero PDF." +
                        System.Environment.NewLine + System.Environment.NewLine +
                        errorM.Message, "Error al abrir PDF",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lsFicherosPDFDivididos_DoubleClick(object sender, EventArgs e)
        {
            if (lsFicherosPDFDivididos.SelectedIndex >= 0)
            {
                string ficheroPDF = lsFicherosPDFDivididos.SelectedItem.ToString();
                if (File.Exists(ficheroPDF))
                {
                    System.Diagnostics.Process.Start(ficheroPDF);
                }
                else
                {
                    MessageBox.Show("El fichero PDF seleccionado no existe " +
                        "o se ha cambiado de ubicación.",
                        "Fichero PDF no existe",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
