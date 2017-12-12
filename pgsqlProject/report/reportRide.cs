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
using System.Data;

namespace pgsqlProject.report
{
    public class reportRide
    {
        procedure sql = new procedure();
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
            DataTable dtJ = sql.getLastJournal();
            createDocument();
            headerReport("Отчет поездок за прошедший месяц");
            doc.Add(Chunk.NEWLINE);
            bodyLastReport(dtJ);
            closeDocument();
        }

        public void printPrem()
        {
            DataTable dtP = sql.getPrem();
            createDocument();
            headerReport("Отчет по примиальным за последние 2 месяца");
            doc.Add(Chunk.NEWLINE);
            bodyPremReport(dtP);
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
            doc.Add(new Paragraph(title, font));
        }

        private void bodyLastReport(DataTable dt)
        {
            PdfPTable table = new PdfPTable(6);

            table.AddCell(new Phrase("Время отбытия", font));
            table.AddCell(new Phrase("Время прибытия", font));
            table.AddCell(new Phrase("Номер авто", font));
            table.AddCell(new Phrase("Имя", font));
            table.AddCell(new Phrase("Фамилия", font));
            table.AddCell(new Phrase("Маршрут", font));

            foreach (DataRow d in dt.Rows)
            { 
                table.AddCell(new Phrase(d["time_in"].ToString(), font));
                table.AddCell(new Phrase(d["time_out"].ToString(), font));
                table.AddCell(new Phrase(d["num"].ToString(), font));
                table.AddCell(new Phrase(d["first_name"].ToString(), font));
                table.AddCell(new Phrase(d["last_name"].ToString(), font));
                table.AddCell(new Phrase(d["name"].ToString(), font));
            }
            doc.Add(table);
        }

        private void bodyPremReport(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["getprem"] != DBNull.Value)
                doc.Add(new Paragraph(dt.Rows[0]["getprem"].ToString(), font));
            else
                doc.Add(new Paragraph("В последних двух месяцах не было премий", font));
        }
    }
}
