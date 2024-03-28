
namespace Search_Tool
{
    partial class Search
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyword_box = new System.Windows.Forms.TextBox();
            this.choose_folder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.choose_start_dir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selected_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_btn.Location = new System.Drawing.Point(14, 305);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(497, 50);
            this.search_btn.TabIndex = 0;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите слово для поиска";
            // 
            // keyword_box
            // 
            this.keyword_box.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyword_box.Location = new System.Drawing.Point(12, 35);
            this.keyword_box.Name = "keyword_box";
            this.keyword_box.Size = new System.Drawing.Size(497, 30);
            this.keyword_box.TabIndex = 2;
            // 
            // choose_folder_dialog
            // 
            this.choose_folder_dialog.HelpRequest += new System.EventHandler(this.choose_folder_dialog_HelpRequest);
            // 
            // choose_start_dir
            // 
            this.choose_start_dir.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_start_dir.Location = new System.Drawing.Point(13, 218);
            this.choose_start_dir.Name = "choose_start_dir";
            this.choose_start_dir.Size = new System.Drawing.Size(497, 71);
            this.choose_start_dir.TabIndex = 0;
            this.choose_start_dir.Text = "Выберите начальную директорию";
            this.choose_start_dir.UseVisualStyleBackColor = true;
            this.choose_start_dir.Click += new System.EventHandler(this.choose_start_dir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(515, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 403);
            this.dataGridView1.TabIndex = 3;
            // 
            // selected_path
            // 
            this.selected_path.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selected_path.Location = new System.Drawing.Point(13, 99);
            this.selected_path.Multiline = true;
            this.selected_path.Name = "selected_path";
            this.selected_path.ReadOnly = true;
            this.selected_path.Size = new System.Drawing.Size(496, 113);
            this.selected_path.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск в директории:";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selected_path);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.keyword_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choose_start_dir);
            this.Controls.Add(this.search_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "Search Tool";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyword_box;
        private System.Windows.Forms.FolderBrowserDialog choose_folder_dialog;
        private System.Windows.Forms.Button choose_start_dir;
        private System.Windows.Forms.TextBox selected_path;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

