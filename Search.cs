using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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

        public string[] SearchResult { get; set; }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (regexp_mode.Checked) Regex = CreateRegexByKeywords(); else RegexpError = false;
            if (RegexpError)
            { 
                dataGridView1.Rows.Clear();

                for (int i = 0; i < contextMenuStrip1.Items.Count; i++)
                {
                    contextMenuStrip1.Items[i].Enabled = false;
                }

                return;
            }

            SearchResult = ParseDirectory(selected_path.Text);

            var result = SearchResult.Where(data => 
                {
                    bool t =  CheckByKeyword(data);
                    return t;
                }
            ).ToArray();

            if (result.Length == 0)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < contextMenuStrip1.Items.Count; i++)
                {
                    contextMenuStrip1.Items[i].Enabled = false;
                }
                return;
            }

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
            SelectedItem = dataGridView1.SelectedCells[0].Value.ToString();
            for (int i = 0; i < contextMenuStrip1.Items.Count; i++)
            {
                contextMenuStrip1.Items[i].Enabled = true;
            }
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

                    files.Add(entry);
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
                var result = new Regex($@"{SearchedText}", reg_options);
                RegexpError = false;
                return result;
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

        private void Search_Load(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            selected_path.Text = Directory.GetCurrentDirectory();
            SearchedText = "";
            RegexpError = false;
            open_cmenu_item.Click += OpenClick;
            export_result_cmenu_item.Click += ExportClick;
        }

        private void keyword_box_TextChanged(object sender, EventArgs e)
        {
            SearchedText = ignore_case.Checked ? keyword_box.Text.ToLower() : keyword_box.Text;
        }

        private void ignore_case_CheckedChanged(object sender, EventArgs e)
        {
            SearchedText = ignore_case.Checked ? keyword_box.Text.ToLower() : keyword_box.Text;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0 || dataGridView1.SelectedCells[0].Value == null) return;
            SelectedItem = dataGridView1.SelectedCells[0].Value.ToString();
        }

        public string SelectedItem { get; set; }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Hide();
        }

        public void ExportClick(object sender, EventArgs e)
        {
            string searchResult = $"Результат поиска: {keyword_box.Text}";

            int fileCount = 0;
            int folderCount = 0;
            int totalCount = SearchResult.Length;

            // Создаем новый пакет Excel
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage())
            {
                // Добавляем лист
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Данные");

                // Заполняем столбец A данными
                for (int i = 0; i < SearchResult.Length; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = SearchResult[i];
                    if (File.Exists(SearchResult[i]))
                    {
                        fileCount++;
                    }
                    else if (Directory.Exists(SearchResult[i]))
                    {
                        folderCount++;
                    }
                }

                // Добавляем заголовок столбца
                worksheet.Cells[1, 1].Value = searchResult;

                var date_time_export = DateTime.Now.ToString().Replace(':', '_');

                // Добавляем таблицу со статистикой
                worksheet.Cells[1, 3].Value = "Дата и время выгрузки отчета:";
                worksheet.Cells[1, 4].Value = date_time_export.Replace('_', ':');
                worksheet.Cells[2, 3].Value = "Количество файлов:";
                worksheet.Cells[2, 4].Value = fileCount;
                worksheet.Cells[3, 3].Value = "Количество папок:";
                worksheet.Cells[3, 4].Value = folderCount;
                worksheet.Cells[4, 3].Value = "Общее количество элементов:";
                worksheet.Cells[4, 4].Value = totalCount;

                // Получаем все используемые колонки
                int startColumn = worksheet.Dimension.Start.Column;
                int endColumn = worksheet.Dimension.End.Column;

                // Проходим по каждой колонке и делаем их шире
                for (int col = startColumn; col <= endColumn; col++)
                {
                    worksheet.Column(col).AutoFit();
                }

                string projectPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                // Путь к папке reports внутри проекта
                string filePath = Path.Combine(projectPath, $"результат {date_time_export}.xlsx");

                package.SaveAs(filePath);
            }

            Console.WriteLine("Файл Excel успешно создан.");
            Console.ReadLine();
        }

        public void OpenClick(object sender, EventArgs e)
        {
            if (!contextMenuStrip1.Items[0].Enabled) return;

            bool isDirectory = Directory.Exists(SelectedItem);
            bool isFile = File.Exists(SelectedItem);

            if (isDirectory || isFile)
            {
                try
                {
                    Process.Start(SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Указанный путь не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Help.pdf");
        }
    }
}
