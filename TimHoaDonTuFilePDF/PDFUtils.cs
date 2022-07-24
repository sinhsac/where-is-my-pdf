using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace TimHoaDonTuFilePDF
{
    internal class PDFUtils
    {
        public static string pdfText(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            return text;
        }
    }
}
