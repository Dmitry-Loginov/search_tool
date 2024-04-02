using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Search_Tool
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        public string SearchedText { get; set; }

        public bool RegexpError { get; set; }

        public Regex Regex { get; set; }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (regexp_mode.Checked) Regex = CreateRegexByKeywords();
            if (RegexpError) return;

            string[] dir_data = ParseDirectory(selected_path.Text);

            var result = dir_data.Where(data => 
                {
                    bool t =  CheckByKeyword(data);
                    return t;
                }
            ).ToArray();

            if (result.Length == 0) { dataGridView1.Rows.Clear(); return; } ;

            dataGridView1.RowCount = result.Length;
            dataGridView1.ColumnCount = 1;
            for (int i = 0; i < result.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = result[i];
            }
            dataGridView1.Columns[0].Width = dataGridView1.Width;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        public string[] ParseDirectory(string path)
        {
            if (!Directory.Exists(path)) return new string[] { };

            if (!deep_search.Checked) return Directory.GetFileSystemEntries(path);

            List<string> files = new List<string>();

            foreach (string entry in Directory.GetFileSystemEntries(path))
            {
                if (File.Exists(entry))
                {
                    files.Add(entry);
                }
                else if (Directory.Exists(entry))
                {
                    FileInfo fileInfo = new FileInfo(entry);
                    if ((fileInfo.Attributes & FileAttributes.System) == FileAttributes.System &&
                (fileInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) continue;
                    files.AddRange(ParseDirectory(entry));
                }
            }

            return files.ToArray();
        }

        public bool CheckByKeyword(string checked_data)
        {
            if (regexp_mode.Checked)
            {
                return Regex.IsMatch(checked_data);
            }
            else
            {
                checked_data = ignore_case.Checked ? checked_data.ToLower() : checked_data;
                return checked_data.Contains(SearchedText);
            }
        }

        public Regex CreateRegexByKeywords()
        {
            try
            {
                var reg_options = ignore_case.Checked ? RegexOptions.IgnoreCase : RegexOptions.None;
                return new Regex($@"{SearchedText}", reg_options);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении регулярного выражения\n: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegexpError = true;
                return new Regex("");
            }
        }

        private void choose_start_dir_Click(object sender, EventArgs e)
        {
            choose_folder_dialog.Description = "Выберите директорию, в которой будет начинаться поиск";
            choose_folder_dialog.ShowNewFolderButton = true;
            if (choose_folder_dialog.ShowDialog() == DialogResult.OK)
            {
                selected_path.Text = choose_folder_dialog.SelectedPath;
            }
        }

        private void choose_folder_dialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            selected_path.Text = Directory.GetCurrentDirectory();
            SearchedText = "";
            RegexpError = false;
        }

        private void keyword_box_TextChanged(object sender, EventArgs e)
        {
            SearchedText = ignore_case.Checked ? keyword_box.Text.ToLower() : keyword_box.Text;
        }

        private void ignore_case_CheckedChanged(object sender, EventArgs e)
        {
            SearchedText = ignore_case.Checked ? keyword_box.Text.ToLower() : keyword_box.Text;
        }
    }
}
