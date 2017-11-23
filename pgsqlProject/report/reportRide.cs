using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace pgsqlProject.report
{
    public class reportRide
    {
        private string fileName = "";
        private Font font;
        private Document doc;

        public reportRide(string fileName)
        {
            this.fileName = fileName;
            pageConfig();
        }

        public void printLastJournal()
        {
            createDocument();
            headerReport("test");
            closeDocument();
        }

        public void showReport()
        {
            Process.Start(config.path + "\\" + fileName);
        }

        private void createDocument()
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            doc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
        }

        private void pageConfig()
        {
            BaseFont baseFont = BaseFont.CreateFont(@"arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            font = new Font(baseFont, Font.DEFAULTSIZE, Font.NORMAL);
        }

        private void closeDocument()
        {
            doc.Close();
        }

        private void headerReport(string title)
        {
            doc.AddTitle(title);
            doc.AddSubject("Отчет для программы автопарк");
            doc.AddKeywords("Автопарк, Отчет, Лабораторная работа");
            doc.AddCreator("Алексеев Егор");
            doc.AddAuthor("Алексеев Егор");
            doc.AddHeader(title, title);

            doc.Add(new Paragraph(@"Тест отчетиков", font));
        }
    }
}
