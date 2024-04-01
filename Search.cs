using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Tool
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string[] dir_data = ParseDirectory(selected_path.Text);
            var result = dir_data.Where(data => data.Contains(keyword_box.Text)).ToArray();
            dataGridView1.RowCount = result.Length;
            dataGridView1.ColumnCount = 1;
            for (int i = 0; i < result.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = result[i];
            }
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        public string[] ParseDirectory(string path)
        {
            List<string> files = new List<string>();

            if (!Directory.Exists(path)) return new string[] { };

            foreach (string entry in Directory.GetFileSystemEntries(path))
            {
                if (File.Exists(entry))
                {
                    files.Add(entry);
                }
                else if (Directory.Exists(entry))
                {
                    files.AddRange(ParseDirectory(entry));
                }
            }

            return files.ToArray();
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
    }
}
