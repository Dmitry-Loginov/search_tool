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
            dataGridView1.RowCount = dir_data.Length;
            dataGridView1.ColumnCount = 1;
            for (int i = 0; i < dir_data.Length - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = dir_data[i];
            }
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        public string[] ParseDirectory(string path)
        {
            if (!Directory.Exists(path)) return new string[] { };

            return Directory.GetFileSystemEntries(path);
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
