using System;
using System.IO;

namespace TimHoaDonTuFilePDF
{
    internal class PdfInfo
    {
        private int id;
        private string pdf_path;
        private string pdf_text_content;
        private string pdf_file_name;
        private string pdf_keyword;
        private Status status;
        private DateTime created_at;
        private DateTime updated_at;

        enum Status
        {
            OK, FILE_DELETED
        }

        public PdfInfo(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            pdf_path = filePath;
            pdf_file_name = fileInfo.Name;
            pdf_keyword = "";
            status = Status.OK;
            pdf_text_content = PDFUtils.pdfText(filePath);
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }

        public string getCreatedAt()
        {
            if (created_at == null)
            {
                return "";
            }
            return created_at.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public string getUpdatedAt()
        {
            if (updated_at == null)
            {
                return "";
            }
            return updated_at.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public string getValue()
        {
            return string.Format(Properties.Settings.Default.PDF_VALUES,
                pdf_path,
                pdf_text_content,
                pdf_file_name,
                pdf_keyword,
                status, getCreatedAt(), getUpdatedAt());
        }
    }
}
