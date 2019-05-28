
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador
{
  public  class Formato
    {
        public void pdf(string filename, string dept, string lugar, string tipo,string proyecto,string asesor,int estudiantes,string nombreEs,int control,string carrera,string tel,string correo, string empresa)
        {

            var logotecN = iTextSharp.text.Image.GetInstance(Properties.Resources.tec, System.Drawing.Imaging.ImageFormat.Png);
            var logosep = iTextSharp.text.Image.GetInstance(Properties.Resources.sep, System.Drawing.Imaging.ImageFormat.Png);
            var ITT = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_ITT1, System.Drawing.Imaging.ImageFormat.Png);
            var iso = iTextSharp.text.Image.GetInstance(Properties.Resources.IQS_ISO_9001, System.Drawing.Imaging.ImageFormat.Png);
            var _info = iTextSharp.text.Image.GetInstance(Properties.Resources.INFO, System.Drawing.Imaging.ImageFormat.Png);
            logotecN.ScalePercent(12f);
            logosep.ScalePercent(12f);
            ITT.ScalePercent(30f);
            iso.ScalePercent(42f);
           _info.ScalePercent(18f);
            _info.SetAbsolutePosition(126f,21f);
            logotecN.SetAbsolutePosition(481f, 764f);
            ITT.SetAbsolutePosition(0, 0);
            logosep.SetAbsolutePosition(0, 778f);
            iso.SetAbsolutePosition(530f, 1);
            var saveFilediloge = new SaveFileDialog();

            saveFilediloge.FileName = filename;
            saveFilediloge.DefaultExt = ".pdf";
            try {
                if (saveFilediloge.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFilediloge.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfdoc, stream);

                        pdfdoc.Open();
                        pdfdoc.Add(logosep);
                        pdfdoc.Add(ITT);
                        pdfdoc.Add(logotecN);
                        pdfdoc.Add(iso);
                        pdfdoc.Add(_info);
                        Paragraph titulo = new Paragraph();

                        PdfPTable table = new PdfPTable(1);
                        PdfPTable Datosproyecto = new PdfPTable(1);
                        PdfPTable DatosNombre = new PdfPTable(1);
                        PdfPTable Estudiante = new PdfPTable(1);
                        PdfPTable infoEst = new PdfPTable(1);
                        PdfPTable firmas = new PdfPTable(2);
                        PdfPTable Empresa = new PdfPTable(1);
                        PdfPTable Extra = new PdfPTable(1);

                        titulo.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12f, BaseColor.BLACK);

                        table.AddCell(GetCell("\n \n \n \n \n \n \n \n Registro de Proyecto", PdfPCell.ALIGN_CENTER));

                        var informacionestudiante = new Phrase();
                        informacionestudiante.Add(new Chunk("Nombre: ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
                        informacionestudiante.Add(nombreEs);
                        informacionestudiante.Add("\nNo. de control: " + control + "\nCarrera: " + carrera + "\nNo. de teléfono y correo electrónico: " + tel + " " + correo);
                        DatosNombre.AddCell(NombreEstudiante("Departamento de " + dept + " \n \n Lugar " + lugar + " Fecha: " + DateTime.Now.ToString("yyyy-MM-dd").ToString() + " ", PdfPCell.ALIGN_LEFT));
                        Estudiante.AddCell(GetCell("Datos del estudiante:", PdfPCell.ALIGN_CENTER));
                        Datosproyecto.AddCell(new Paragraph("Nombre del proyecto:" + proyecto + "\n" + "Nombre del Asesor: " + asesor + "\nNúmero de estudiantes: " + estudiantes + "\nTipo de proyecto " + tipo));
                        infoEst.AddCell(informacionestudiante);
                        firmas.AddCell(Autorizacion("Recibió", "\n \n \n \n \n \n \nING. BARRAZA ARMENTA CHRISTIAN \nCoordinador de la carrera", PdfPCell.ALIGN_LEFT));
                        firmas.AddCell(Autorizacion("Autorizó", "\n \n \n \n \n \n \nM.C RANGEL ALONSO VLADIMIR \nJefe del departamento Academico", PdfPCell.ALIGN_JUSTIFIED));
                        Empresa.AddCell(new Paragraph("Nombre de la Empresa o Institución " + empresa + " \n  "));
                        Extra.AddCell(getextra("Calzada del Tecnológico S/N Esq. Av. Castillo de Chapultepec y calle Cuauhtemotzin, \n Fracc. Tomás Aquino C.P. 22414, Tijuana, Baja California. Conmut. (664) 6078400 Ext. 101, \n e-mail: direccion@tectijuana.mx, \n", "www.tectijuana.edu.mx", PdfPCell.ALIGN_CENTER));
                        DatosNombre.SpacingBefore = 10f;
                        DatosNombre.SpacingAfter = 10f;
                        Estudiante.SpacingAfter = 20f;
                        infoEst.SpacingAfter = 3f;
                        Datosproyecto.SpacingAfter = 7f;
                        firmas.SpacingBefore = 30f;
                        Empresa.SpacingBefore = 60f;
                        Extra.SpacingBefore = 240f;

                        // Extra.KeepTogether = true;
                        pdfdoc.Add(table);
                        pdfdoc.Add(DatosNombre);
                        pdfdoc.Add(Datosproyecto);
                        pdfdoc.Add(Estudiante);
                        pdfdoc.Add(infoEst);
                        pdfdoc.Add(firmas);
                        pdfdoc.Add(Empresa);
                        //    pdfdoc.Add(Extra);

                        pdfdoc.Close();
                        stream.Close();
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Renombra el archivo o eliminelo");
            }
        }

     
        public PdfPCell GetCell(string text, int ali)
        {
            Phrase titulo = new Phrase();
            PdfPCell cell = new PdfPCell(new Phrase(text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            cell.Padding = 0;
            cell.HorizontalAlignment = ali;
            cell.Border = PdfPCell.NO_BORDER;
            return cell;
        }
        public PdfPCell Autorizacion(string data, string text, int ali)
        {
            var titulo = new Phrase();
            titulo.Add(new Chunk(data, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            titulo.Add(text);
            PdfPCell cell = new PdfPCell(titulo);
            cell.Padding = 0;
            cell.HorizontalAlignment = ali;
            cell.Border = PdfPCell.NO_BORDER;
            return cell;
        }
        public PdfPCell getextra(string text, string pag, int ali)
        {
            var titulo = new Phrase();
            titulo.Add(new Chunk(text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 8f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
            titulo.Add(new Chunk(pag, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 8f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            PdfPCell cell = new PdfPCell(titulo);
            cell.Padding = 0;
            cell.HorizontalAlignment = ali;
            cell.Border = PdfPCell.NO_BORDER;
            
            return cell;
        }
        public PdfPCell DatosProyecto(string text, int ali)
        {
            Phrase titulo = new Phrase();
            PdfPCell cell = new PdfPCell(new Phrase(text));
            cell.Padding = 0;
            cell.HorizontalAlignment = ali;
            cell.Border = PdfPCell.BOX;
            return cell;
        }
        public PdfPCell NombreEstudiante(string text, int ali)
        {
            Phrase titulo = new Phrase();
            PdfPCell cell = new PdfPCell(new Phrase(text));
            cell.Padding = 0;
            cell.HorizontalAlignment = ali;
            cell.Border = PdfPCell.NO_BORDER;
            return cell;
        }
    }
}
