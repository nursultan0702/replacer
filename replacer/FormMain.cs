using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;
using Microsoft.Office.Interop.Excel;

namespace replacer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void addLog(String s)
        {
            //textBoxLog.Text += s + (char)13 + (char)10;
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.DefaultExt = "xls";
            if (of.ShowDialog() == DialogResult.OK)
            {
                textBoxInput.Text = of.FileName;
                buttonLoad_Click_1(sender, e);
                //textBoxDict.Text = Path.GetDirectoryName(of.FileName) + Path.DirectorySeparatorChar+"out_" + Path.GetFileName(of.FileName);
            }
        }

        public void loadExcel(String fileName)
        {
            try
            {
                dg.Rows.Clear();
                dg.Enabled = false;
                Cursor = Cursors.WaitCursor;

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;
                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                dg.ColumnCount = colCount;
                //dg.RowCount = rowCount;
                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                for (int i = 1; i <= rowCount; i++)
                {

                    int iRow = dg.Rows.Add();

                    for (int j = 1; j <= colCount; j++)
                    {
                        String vData = "";
                        //new line
                        if (j == 1)
                            vData = "\r\n";
                        //dg.Rows.Add()
                        //write the value to the console
                        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)

                            vData = xlRange.Cells[i, j].Value2.ToString();

                        dg.Rows[iRow].Cells[j - 1].Value = vData;
                    }
                }

                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad


                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            catch
            {
                throw;
            }
            finally
            {
                Cursor = Cursors.Default;
                dg.Enabled = true;
            }
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "*.xls, *.xlsx";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                textBoxDict.Text = sf.FileName;
            }
        }

        private void buttonLoad_Click_1(object sender, EventArgs e)
        {
            loadExcel(textBoxInput.Text);
        }

        private void buttonDict_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.DefaultExt = "ini";
            //Wof.Filter= "*.ini";
            if (of.ShowDialog() == DialogResult.OK)
            {
                textBoxDict.Text = of.FileName;
                loadDictionary(textBoxDict.Text);
                //textBoxDict.Text = Path.GetDirectoryName(of.FileName) + Path.DirectorySeparatorChar + "out_" + Path.GetFileName(of.FileName);
            }
        }

        private void buttonOpenDict_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBoxDict.Text))
            {
                Process.Start(textBoxDict.Text);
            }
        }

        private void buttonOpenExcel_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBoxInput.Text))
            {
                Process.Start(textBoxInput.Text);
            }
        }
        public class dictItem
        {
            public String value;
            public int colIndex = 1;
        }
        public class dictCol
        {
            public String pkey;
            public dictItem pitem;
            public dictCol (String key, dictItem item)
            {
                pkey = key;
                pitem = item;
            }
            public override string ToString()
            {
                return pkey + "===" + pitem.value + "===" + pitem.colIndex;
            }
                
        }
        public List<dictCol> dictList = new List<dictCol>();
        public Dictionary<int, String> dictAllCol = new Dictionary<int, String>();
        public void loadDictionary(String fileName)
        {
            dictList.Clear();
            dictAllCol.Clear();
            string[] lines = System.IO.File.ReadAllLines(fileName, Encoding.GetEncoding("windows-1251"));
            foreach (String str in lines)
            {
                String s = str;
                String key = s.Substring(0, s.IndexOf("==="));
                s = s.Substring(s.IndexOf("===") + 3);
                String value = s.Substring(0, s.IndexOf("==="));
                s = s.Substring(s.IndexOf("===") + 3);
                dictItem item = new dictItem();
                item.value = value;
                item.colIndex = int.Parse(s);
                if (key.Equals("[OTHER]"))
                {
                    dictAllCol.Add(item.colIndex, item.value);
                }
                else
                {
                    dictList.Add(new dictCol(key, item));
                }
            }
        }

        /*
        private void parseColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBoxInput.Text))
            {
                throw new Exception("Set input file");
            }
            if (!File.Exists(textBoxDict.Text))
            {
                throw new Exception("Set dictionary file");
            }

            loadDictionary(textBoxDict.Text);
            Dictionary<int, int> cols = new Dictionary<int, int>();

            if (dg.SelectedCells.Count > 0)
            {
                int colIndex = dg.SelectedCells[0].ColumnIndex;
                dg.Columns[colIndex].Tag = colIndex;
                foreach (DataGridViewRow row in dg.Rows)
                {
                    String s = "";
                    if (row.Cells[colIndex].Value != null) s = row.Cells[colIndex].Value.ToString();
                    Boolean en = false;
                    foreach (dictCol rec in dictList)
                    {
                        if (s.ToUpper().Contains(rec.Item1.ToUpper()))
                        {
                            int ci = rec.Item2.colIndex;
                            if (ci == 0)
                            {
                                s = s.Replace(rec.Item1, rec.Item2.value);
                                row.Cells[colIndex].Value = s;
                            }
                            else
                            {
                                if (!cols.ContainsKey(ci))
                                {
                                    cols.Add(ci, dg.Columns.Add("col" + ci.ToString(), ci.ToString()));
                                }
                                row.Cells[cols[ci]].Value = rec.Item2.value;
                            }
                            en=true;
                            dg.Columns[colIndex].Tag = ci;
                        }
                     
                    }

                       if (!en)
                        {
                            int ci = (int)dg.Columns[colIndex].Tag;
                                if (!cols.ContainsKey(ci))
                                {
                                    cols.Add(ci, dg.Columns.Add("col" + ci.ToString(), ci.ToString()));
                                }
                                row.Cells[cols[ci]].Value = s;
                        }
                }
            }
        }*/

        private void dg_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                dg.Columns[e.ColumnIndex].Selected = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dg.SelectAll();
            DataObject dataObj = dg.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1251);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void parseAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*if (!File.Exists(textBoxInput.Text) || dg.ColumnCount!=0)
            {
                throw new Exception("Set input file or Data from Database is empty!");
            }*/
            if (!File.Exists(textBoxDict.Text))
            {
                throw new Exception("Set dictionary file");
            }

            loadDictionary(textBoxDict.Text);
            Dictionary<int, int> cols = new Dictionary<int, int>();
            int maxCol = dg.ColumnCount;
            for (int i=0; i < maxCol; i++)
            {
                int colIndex = i;
                dg.Columns[colIndex].Tag = colIndex;
                foreach (DataGridViewRow row in dg.Rows)
                {
                    String s = "";
                    if (row.Cells[colIndex].Value != null) s = row.Cells[colIndex].Value.ToString();
                    Boolean en = false;
                    string[] tokens = s.Split(',');
                    if (tokens.Length > 1)
                    {
                        for (int itr = 0; itr < tokens.Length; itr++) {
                            row.Cells[itr].Value = tokens[itr];  //Исправить надо этот момент
                        }
                    }
                    foreach (dictCol rec in dictList)
                    {
                        if (s.ToUpper().Contains(rec.pkey.ToUpper()))
                        {
                            int ci = rec.pitem.colIndex;
                            if (ci == 0)
                            {
                                s = s.Replace(rec.pkey, rec.pitem.value);
                                row.Cells[colIndex].Value = s;
                                if (checkBoxDebug.Checked) row.Cells[colIndex].ErrorText += rec.ToString()+"\n";
                            }
                            else
                            {
                                if (!cols.ContainsKey(ci))
                                {
                                    cols.Add(ci, dg.Columns.Add("col" + ci.ToString(), ci.ToString()));
                                }
                                row.Cells[cols[ci]].Value = rec.pitem.value;
                                row.Cells[cols[ci]].Style.BackColor = Color.LightGreen;
                                if (checkBoxDebug.Checked) row.Cells[cols[ci]].ErrorText += rec.ToString() + "\n";
                            }
                            en = true;
                            dg.Columns[colIndex].Tag = ci;

                        }
                    }
                    
                    int ci2 = (int)dg.Columns[colIndex].Tag;
                }
            }

            if (checkBoxSetOther.Checked)
            foreach(KeyValuePair<int, string> entry in dictAllCol){
                String s = "";
                foreach (DataGridViewRow row in dg.Rows)
                    if (row.Cells[cols[entry.Key]].Value == null) {
                        row.Cells[cols[entry.Key]].Value = dictAllCol[entry.Key];
                        if (checkBoxDebug.Checked) row.Cells[cols[entry.Key]].ErrorText += "[OTHER]===" + entry.Value + "===" + entry.Key + "\n"; 
                    }
                    
            }

            if (checkBoxAddEmpty.Checked)
            for (int i = 0; i < maxCol; i++)
            {
                int colIndex = i;
                if (dg.Columns[colIndex].Tag != null ){
                    int ci2 = (int)dg.Columns[colIndex].Tag;
                    if (cols.ContainsKey(ci2))
                    foreach (DataGridViewRow row in dg.Rows) {
                        if (row.Cells[cols[ci2]].Value==null) {
                            String s = "";
                            if (row.Cells[colIndex].Value != null) s = row.Cells[colIndex].Value.ToString();
                            row.Cells[cols[ci2]].Value = s;
                            if (checkBoxDebug.Checked) row.Cells[cols[ci2]].ErrorText += "AddEmpty " + s + "\n"; 
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = "User Id=remedy_nfs;Password=mdU4!9W5js;Data Source=//172.28.93.113:1528/KZCHECK";
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM XXVIP.FA_ITSM_V WHERE ACCOUNT_DESC LIKE '%Вычислительная техника%'";
            System.Data.DataTable dt = new System.Data.DataTable();
            OracleDataAdapter oraDa = new OracleDataAdapter(cmd);
            oraDa.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
            textBoxInput.Text = "1";
            buttonParse.PerformClick();
            //ToCsV(dg, @"c:\export"+ date.ToString("dd/MM/yyyy") + ".xls");
            saveViaCopy();
            MessageBox.Show("Parsing Finished at " + date.ToString("dd/MM/yyyy"));

        }  

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dg, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }
        public void saveViaCopy() {
            dg.SelectAll();
            DataObject dataObj = dg.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
