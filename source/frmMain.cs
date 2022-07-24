using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace find_my_pdf
{
    public partial class frmMain : Form
    {
        SQLiteConnection _con = new SQLiteConnection();
        string dbFileName = "xdb.xdb";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            createTable(Properties.Settings.Default.CREATE_PDF_TABLE);
            createTable(Properties.Settings.Default.CREATE_HISTORY_TABLE);
            countTotalPDFs();
            loadKeywordHistories();
        }

        public void createTable(string sql)
        {
            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
            }
            createConection();
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void createConection()
        {
            string _strConnect = "Data Source=" + dbFileName + ";Version=3;";
            _con.ConnectionString = _strConnect;
            if (_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
        }

        public void closeConnection()
        {
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchFile();
            if (string.IsNullOrEmpty(txtKeyword.Text) || txtKeyword.Items.Contains(txtKeyword.Text))
            {
                return;
            }
            saveKeywordToHistories();
        }

        private void saveKeywordToHistories()
        {
            string sql = string.Format("INSERT INTO search_history(search_text) VALUES ('{0}')", txtKeyword.Text);
            try
            {
                executeSQL(sql);
            }
            catch { }
            finally
            {
                txtKeyword.Items.Add(txtKeyword.Text);
            }
        }

        private void loadKeywordHistories()
        {
            createConection();
            SQLiteCommand cmd = new SQLiteCommand(Properties.Settings.Default.LAST_TEN_HISTORIES, _con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                txtKeyword.Items.Add(reader.GetString(0));
            }
            closeConnection();
        }

        private void searchFile()
        {
            if (string.IsNullOrEmpty(txtKeyword.Text))
            {
                MessageBox.Show("Nhập dữ liệu vô mới tìm được chứ ku.", "Êh Êh Êh");
                return;
            }
            string sql = string.Format(Properties.Settings.Default.PDF_SEARCH, txtKeyword.Text);
            DataSet ds = new DataSet();
            createConection();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, _con);
            da.Fill(ds);
            closeConnection();
            dgvMain.DataSource = ds.Tables[0];
        }

        private void countTotalPDFs()
        {
            createConection();
            SQLiteCommand cmd = new SQLiteCommand(Properties.Settings.Default.PDF_COUNTER, _con);
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            closeConnection();
            this.Text = String.Format(Properties.Settings.Default.LBL_BTN_QUET, total);
        }

        private void executeSQL(string sql)
        {
            createConection();
            Exception ee = null;
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, _con);
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                ee = ex;
            }
            closeConnection();
            if (ee != null)
            {
                throw ee;
            }
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchFile();
                saveKeywordToHistories();
            }
        }

        private void tsmenuScanPDF_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string folderPath = folderBrowser.SelectedPath;
            if (folderPath == null)
            {
                return;
            }
            string[] allfiles = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
            if (allfiles == null || allfiles.Length == 0)
            {
                return;
            }
            int counter = 0;
            int errorCounter = 0;
            foreach (string fileName in allfiles)
            {
                if (!fileName.ToLower().EndsWith(".pdf"))
                {
                    continue;
                }
                PdfInfo pdfInfo = new PdfInfo(fileName);
                string sql = Properties.Settings.Default.PDF_INSERT_ + pdfInfo.getValue() + ";";
                try
                {
                    executeSQL(sql);
                    counter++;
                }
                catch
                {
                    errorCounter++;
                }

            }

            MessageBox.Show(string.Format("Đã quét xong {0} files PDF, trong đó \n\n{1} files thành công, \n{2} files không thành công. ",
                allfiles.Length,
                counter, errorCounter),
                "Thông báo !!!");
            countTotalPDFs();
        }

        private void txtKeyword_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchFile();
        }
    }
}