using iTextSharp.text; //test
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDF
{
    public partial class Form1 : Form
    {
        private void fillPDFForm()
        {
            string formFile = "E:\\PDFTest\\paycheck.pdf";
            string newFile = "E:\\PDFTest\\newFile1.pdf";
            string newFile2 = "E:\\PDFTest\\newFile2.pdf";
            PdfReader reader = new PdfReader(formFile);

            //using (PdfStamper stamper = new PdfStamper(reader, new FileStream(newFile, FileMode.Create)))
            //{
            //    AcroFields af = stamper.AcroFields;
            //    AcroFields fields = stamper.AcroFields;

            //    fields.SetField("Textfield11", "ggggg");

            //    stamper.FormFlattening = true;
            //    stamper.Close();
            //}

            using (PdfStamper stamper = new PdfStamper(reader, new FileStream(newFile, FileMode.Create)))
            {
                AcroFields af = stamper.AcroFields;

                AcroFields fields = stamper.AcroFields;



                //for (int i = 0; i < af.Fields.Count; i++)
                //{
                //    fields.SetField(af.Fields[i]["Key"], "12ab");
                //}

                //PdfContentByte content = stamper.GetOverContent(1);
                //iTextSharp.text.Image image = (iTextSharp.text.Image.GetInstance("E:\\LiquorClinicChanges\\Liquor\\Content\\Logo\\12.jpg"));
                //image.SetAbsolutePosition(350, 700);
                //image.ScaleAbsolute(50, 50);
                //content.AddImage(image);

                foreach (var field in af.Fields)
                {
                    var str = field.Key.Replace("topmostSubform[0].Copy1[0].Entity[0].f2_", "");
                    str = str.Replace("topmostSubform[0].Page1[0].Entity[0].f1_", "");
                    str = str.Replace("topmostSubform[0].Page1[0].Entity[0].f1_", "");
                    str = str.Replace("topmostSubform[0].Page2[0].f2_", "");
                    str = str.Replace("topmostSubform[0].Page3[0].f3_", "");
                    str = str.Replace("topmostSubform[0].Page4[0].f4_", "");
                    str = str.Replace("topmostSubform[0].Page1[0].GrayBoxes[0].c1", "");
                    str = str.Replace("topmostSubform[0].Page1[0].GrayBoxes[0].f1", "");
                    fields.SetField(field.Key, str);

                    //if (field.Key == "Employer_Name")
                    //{

                    //PdfContentByte content = stamper.GetOverContent(1);
                    //iTextSharp.text.Image image = (iTextSharp.text.Image.GetInstance("E:\\LiquorClinicChanges\\Liquor\\Content\\Logo\\12.jpeg="));
                    //image.SetAbsolutePosition(0, 740);
                    //image.ScaleAbsolute(40, 40);
                    //content.AddImage(image);

                    //}
                } 
               // fields.SetField("ChkBox", "On");
               // fields.SetField("Text1", "00");
                // set form fields
                //fields.SetField("topmostSubform[0].Page1[0].f1_12[0]", "Himanshu Gupta");
                //fields.SetField("address", "xxxxx, yyyy");
                //fields.SetField("postal_code", "12345");
                //fields.SetField("email", "johndoe@xxx.com");

                // flatten form fields and close document
                stamper.FormFlattening = true;
                stamper.Close();
            }



            //using (Stream inputPdfStream = new FileStream(newFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            ////using (Stream inputImageStream = new FileStream(@"E:\LiquorClinicChanges\Liquor\Content\Sign\Blank2020053115184114720201010200401014.bmp", FileMode.Open, FileAccess.Read, FileShare.Read))
            //using (Stream inputImageStream = new FileStream(@"E:\LiquorClinicChanges\Liquor\Content\Sign\cross.png", FileMode.Open, FileAccess.Read, FileShare.Read))
            //using (Stream outputPdfStream = new FileStream(newFile2, FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    reader = new PdfReader(inputPdfStream);
            //    var stamper = new PdfStamper(reader, outputPdfStream);
            //    var pdfContentByte = stamper.GetOverContent(3);

            //    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(inputImageStream);
            //    image.SetAbsolutePosition(66, 365);
            //    image.ScalePercent(4f);
            //    pdfContentByte.AddImage(image);
            //    stamper.Close();
            //}


            //Document doc = new Document();

            //PdfWriter.GetInstance(doc, new FileStream(newFile, FileMode.OpenOrCreate));
            //doc.Open();

            //    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance();
            //    image.ScaleAbsolute(0, 0);
            //    image.SetAbsolutePosition(0, 0);
            //    image.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
            //    image.ScalePercent(20f);
            //    doc.Add(image);

        }
        public Form1()
        {
            InitializeComponent();
            fillPDFForm();
            //string oldFile = "E:\\PDFTest\\1.pdf";
            //string newFile = "E:\\PDFTest\\newFile.pdf";

            //string pdfTemplate = "E:\\PDFTest\\1.pdf";
            //// title the form  
            //this.Text += " - " + pdfTemplate;
            //// create a new PDF reader based on the PDF template document  
            //PdfReader pdfReader = new PdfReader(pdfTemplate);
            //// create and populate a string builder with each of the  
            //// field names available in the subject PDF  
            //StringBuilder sb = new StringBuilder();
            //PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            //AcroFields pdfFormFields = pdfStamper.AcroFields;
            //pdfFormFields.SetField("f1_01[0]", "1");
            //pdfFormFields.SetField("f1_02[0]", "1");
            //pdfFormFields.SetField("f1_03[0]", "1");
            //pdfFormFields.SetField("f1_04[0]", "8");
            //pdfFormFields.SetField("f1_05[0]", "0");
            //pdfFormFields.SetField("f1_06[0]", "1");
            //pdfFormFields.SetField("f1_07[0]", "16");
            //pdfFormFields.SetField("f1_08[0]", "28");
            //pdfFormFields.SetField("f1_09[0]", "Franklin A.");
            //pdfFormFields.SetField("f1_10[0]", "Benefield");
            //pdfFormFields.SetField("f1_11[0]", "532");
            //pdfFormFields.SetField("f1_12[0]", "12");
            //pdfFormFields.SetField("f1_13[0]", "1234");
            //// The form's checkboxes  
            //pdfFormFields.SetField("c1_01[0]", "0");
            //pdfFormFields.SetField("c1_02[0]", "Yes");
            //pdfFormFields.SetField("c1_03[0]", "0");
            //pdfFormFields.SetField("c1_04[0]", "Yes");
            //// The rest of the form pdfFormFields  
            //pdfFormFields.SetField("f1_14[0]", "100 North Cujo Street");
            //pdfFormFields.SetField("f1_15[0]", "Nome, AK  67201");
            //pdfFormFields.SetField("f1_16[0]", "9");
            //pdfFormFields.SetField("f1_17[0]", "10");
            //pdfFormFields.SetField("f1_18[0]", "11");
            //pdfFormFields.SetField("f1_19[0]", "Walmart, Nome, AK");
            //pdfFormFields.SetField("f1_20[0]", "WAL666");
            //pdfFormFields.SetField("f1_21[0]", "AB");
            //pdfFormFields.SetField("f1_22[0]", "4321");

            //// flatten the form to remove editting options, set it to false  
            //// to leave the form open to subsequent manual edits  
            //pdfStamper.FormFlattening = false;
            //// close the pdf  
            //pdfStamper.Close();

            //PdfReader reader = new PdfReader(oldFile);
            ////This line return true that means this document is tagged
            //bool isTagged = reader.IsTagged();
            //var metadeta = reader.Metadata;
            

            //// open the reader
            
            //iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
            //Document document = new Document(size);

            //// open the writer
            //FileStream fs = new FileStream(newFile, FileMode.Create, FileAccess.Write);
            //PdfWriter writer = PdfWriter.GetInstance(document, fs);
            //document.Open();

            //// the pdf content
            //PdfContentByte cb = writer.DirectContent;

            //// select the font properties
            //BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            //cb.SetColorFill(BaseColor.DARK_GRAY);
            //cb.SetFontAndSize(bf, 8);

            //// write the text in the pdf content
            //cb.BeginText();
            //string text = "Some random blablablabla...";
            //// put the alignment and coordinates here
            //cb.ShowTextAligned(0, text, 10, 12, 0);
            //cb.EndText();
            //cb.BeginText();
            //text = "Other random blabla...";
            //// put the alignment and coordinates here
            //cb.ShowTextAligned(2, text, 100, 200, 0);
            //cb.EndText();

            //// create the new page and add it to the pdf
            //PdfImportedPage page = writer.GetImportedPage(reader, 1);
            //cb.AddTemplate(page, 0, 0);

            //// close the streams and voilá the file should be changed :)
            //document.Close();
            //fs.Close();
            //writer.Close();
            //reader.Close();
        }
    }
}
