//The purpose of this project is to allow me to save web links to a text file.
using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace Practice_2__Local_Web_Bookmark
{
    public partial class BookmarkForm : Form
    {
        private const string Na = "N/A";
        private readonly string DefaultBrowserPath;

        public BookmarkForm()
        {
            InitializeComponent();

            txtWebLink.Focus();
            lblMaxLines.Text = lblCurrLine.Text = 0.ToString();
            DefaultBrowserPath = Browser.GetDefault();
            if (!string.IsNullOrEmpty(DefaultBrowserPath))
            {
                //break the file path into chunks
                //browser exe name is always before ".exe" so it would be in the (n - 2)th position
                //also accounting for browsers that have two or more words in their names, so we title case them
                string[] lines = DefaultBrowserPath.Split('\\', '.');

                lblDefaultBrowser.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lines[lines.Length - 2]);
            }
            else
                chkIncognito.Enabled = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {            
            WebListBox.Items.Add(txtWebLink.Text);
            txtWebLink.Text = "";
            lblMaxLines.Text = WebListBox.Items.Count.ToString();
            AutoScrollListBox();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            string line;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //allows me to read a text file line by line
                using (StreamReader r = new StreamReader(openFileDialog1.FileName))
                {
                    while ((line = r.ReadLine()) != null)
                         WebListBox.Items.Add(line);
                    AutoScrollListBox();
                    lblMaxLines.Text = WebListBox.Items.Count.ToString();

                    string filename = openFileDialog1.FileName; // this code displays the name
                    lblFilePath.Text = Path.GetFullPath(filename); //of the file that was opened.
                    lblFileName.Text = Path.GetFileName(filename);
                    DateTime lastModified = File.GetLastWriteTime(filename);
                    lblDateSaved.Text = lastModified.ToString();
                    r.Close();
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            try
            {
                string listboxitem = WebListBox.SelectedItem.ToString();
                Clipboard.SetText(listboxitem, TextDataFormat.Text);
            }
            catch (NullReferenceException)
            {
                //MessageBox.Show(ex.Message, "Copy Error");
            }
            catch(ArgumentNullException) { }
        }

        private void DeleteItem()
        {
            if (WebListBox.SelectedItems.Count != 0)
            {                
                while (WebListBox.SelectedIndex != -1)
                {
                    WebListBox.Items.RemoveAt(WebListBox.SelectedIndex);
                    lblMaxLines.Text = WebListBox.Items.Count.ToString();
                }
                txtModifyLink.Text = "";
                AutoScrollListBox();
            }
        }

        private void VisitURL()
        {
            if(WebListBox.SelectedItem != null)
            {
                string url = WebListBox.SelectedItem.ToString();
                if (WebValidator.URLIsValid(url))
                {
                    Process process = new Process();
                    try
                    {
                        process.StartInfo.FileName = DefaultBrowserPath;
                        process.StartInfo.Arguments = !chkIncognito.Checked ? url : $"{url} --incognito";
                        process.Start();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "URL error");
                    }
                    finally
                    {
                        process.Dispose();
                    }
                }
            }           
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Delete all text from list and clear file name from the form?",
                "Caution", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                WebListBox.Items.Clear();
                lblFilePath.Text = lblFileName.Text = lblDateSaved.Text = Na;
                lblCurrLine.Text = lblMaxLines.Text = 0.ToString();
                txtModifyLink.Text = "";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            var fileNameAndPath = lblFilePath.Text;
            if (!File.Exists(fileNameAndPath) || fileNameAndPath == Na)
            {
                SaveAsTextFile();
                return;
            }
            //try
            //{
                //My best solution many years later...
                string contents = "";
                foreach (var item in WebListBox.Items)
                    contents += item + "\n";

                File.WriteAllText(fileNameAndPath, contents);
                DateTime lastModified = File.GetLastWriteTime(fileNameAndPath);
                lblDateSaved.Text = lastModified.ToString();
                //ehhhhh.... good enough I suppose...
                //this answer https://stackoverflow.com/questions/2695444/clearing-content-of-text-file-using-c-sharp
                //gave me the idea

                //using (FileStream fstream = new FileStream(fileNameAndPath,
                //    FileMode.Open,
                //        FileAccess.Write))
                //{
                //    using (StreamWriter write = new StreamWriter(fstream))
                //    {
                //        foreach (var item in WebListBox.Items)
                //            write.WriteLine(item.ToString());
                //        write.Close();
                //    }
                //    DateTime lastModified = File.GetLastWriteTime(fileNameAndPath);
                //    lblDateSaved.Text = lastModified.ToString();
                //    fstream.Close();
                //}
            //}
            //catch (DirectoryNotFoundException ex)
            //{
            //    MessageBox.Show(ex.Message, "File not found error");
            //}
        }

        private void SaveAsTextFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream S = File.Open(saveFileDialog1.FileName, FileMode.Create))
                    {
                        using (StreamWriter st = new StreamWriter(S))
                        {
                            foreach (var aa in WebListBox.Items)
                                st.WriteLine(aa.ToString());
                            st.Close();
                        }

                        lblDateSaved.Text = DateTime.Now.ToString();
                        string filename = saveFileDialog1.FileName; //displays the name
                        lblFileName.Text = Path.GetFileName(filename);
                        lblFilePath.Text = Path.GetFullPath(filename); //of the file,                                   
                        DateTime lastModified = File.GetLastWriteTime(filename);
                        lblDateSaved.Text = lastModified.ToString();
                        S.Close();
                        //with the full path of the file, I can save it to the exact designation
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Unable to Save File");
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            //saveFileDialog1.Title = "Save as Text File";

            SaveAsTextFile();
        }

        private void visitURLToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            VisitURL();
        }

        private void WebListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lineNum = WebListBox.SelectedIndex + 1;
            lblCurrLine.Text = lineNum.ToString();
            if(WebListBox.SelectedIndex != -1)
                txtModifyLink.Text = WebListBox.SelectedItem.ToString();
        }

        private void WebListBox_DoubleClick(object sender, EventArgs e)
        {
            VisitURL();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Info = new Info();
            Info.Show();
        }

        private void AutoScrollListBox()
        {
            int items = WebListBox.Height / WebListBox.ItemHeight;
            WebListBox.TopIndex = WebListBox.Items.Count - items;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (WebListBox.SelectedItems.Count != 0)
            {
                if (txtModifyLink.Text != WebListBox.SelectedItem.ToString()) 
                {
                    while (WebListBox.SelectedIndex != -1)
                    {
                        WebListBox.Items.Insert(WebListBox.SelectedIndex, txtModifyLink.Text);
                        WebListBox.Items.Remove(WebListBox.SelectedItem);
                    }
                }
                txtModifyLink.Text = ""; 
                WebListBox.SelectedIndex = -1;
            }          
        }
    }
}