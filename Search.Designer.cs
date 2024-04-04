
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyword_box = new System.Windows.Forms.TextBox();
            this.choose_folder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.choose_start_dir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open_cmenu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.export_result_cmenu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.selected_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ignore_case = new System.Windows.Forms.CheckBox();
            this.deep_search = new System.Windows.Forms.CheckBox();
            this.regexp_mode = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_btn.Location = new System.Drawing.Point(15, 499);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(663, 62);
            this.search_btn.TabIndex = 0;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите слово для поиска";
            // 
            // keyword_box
            // 
            this.keyword_box.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyword_box.Location = new System.Drawing.Point(16, 65);
            this.keyword_box.Margin = new System.Windows.Forms.Padding(4);
            this.keyword_box.Name = "keyword_box";
            this.keyword_box.Size = new System.Drawing.Size(661, 36);
            this.keyword_box.TabIndex = 2;
            this.keyword_box.TextChanged += new System.EventHandler(this.keyword_box_TextChanged);
            // 
            // choose_start_dir
            // 
            this.choose_start_dir.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_start_dir.Location = new System.Drawing.Point(13, 392);
            this.choose_start_dir.Margin = new System.Windows.Forms.Padding(4);
            this.choose_start_dir.Name = "choose_start_dir";
            this.choose_start_dir.Size = new System.Drawing.Size(663, 87);
            this.choose_start_dir.TabIndex = 0;
            this.choose_start_dir.Text = "Выберите начальную директорию";
            this.choose_start_dir.UseVisualStyleBackColor = true;
            this.choose_start_dir.Click += new System.EventHandler(this.choose_start_dir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(687, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(669, 548);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_cmenu_item,
            this.export_result_cmenu_item});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 52);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // open_cmenu_item
            // 
            this.open_cmenu_item.Enabled = false;
            this.open_cmenu_item.Name = "open_cmenu_item";
            this.open_cmenu_item.Size = new System.Drawing.Size(191, 24);
            this.open_cmenu_item.Text = "Открыть";
            this.open_cmenu_item.ToolTipText = "Открыть выбранный элемент";
            // 
            // export_result_cmenu_item
            // 
            this.export_result_cmenu_item.Name = "export_result_cmenu_item";
            this.export_result_cmenu_item.Size = new System.Drawing.Size(191, 24);
            this.export_result_cmenu_item.Text = "Выгрузить отчет";
            // 
            // selected_path
            // 
            this.selected_path.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selected_path.Location = new System.Drawing.Point(13, 246);
            this.selected_path.Margin = new System.Windows.Forms.Padding(4);
            this.selected_path.Multiline = true;
            this.selected_path.Name = "selected_path";
            this.selected_path.ReadOnly = true;
            this.selected_path.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.selected_path.Size = new System.Drawing.Size(660, 138);
            this.selected_path.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск в директории:";
            // 
            // ignore_case
            // 
            this.ignore_case.AutoSize = true;
            this.ignore_case.Checked = true;
            this.ignore_case.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignore_case.Location = new System.Drawing.Point(18, 108);
            this.ignore_case.Name = "ignore_case";
            this.ignore_case.Size = new System.Drawing.Size(242, 20);
            this.ignore_case.TabIndex = 6;
            this.ignore_case.Text = "Не учитывать регистр символов";
            this.ignore_case.UseVisualStyleBackColor = true;
            this.ignore_case.CheckedChanged += new System.EventHandler(this.ignore_case_CheckedChanged);
            // 
            // deep_search
            // 
            this.deep_search.AutoSize = true;
            this.deep_search.Checked = true;
            this.deep_search.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deep_search.Location = new System.Drawing.Point(267, 109);
            this.deep_search.Name = "deep_search";
            this.deep_search.Size = new System.Drawing.Size(123, 20);
            this.deep_search.TabIndex = 7;
            this.deep_search.Text = "Искать вглубь";
            this.deep_search.UseVisualStyleBackColor = true;
            // 
            // regexp_mode
            // 
            this.regexp_mode.AutoSize = true;
            this.regexp_mode.Location = new System.Drawing.Point(18, 135);
            this.regexp_mode.Name = "regexp_mode";
            this.regexp_mode.Size = new System.Drawing.Size(234, 20);
            this.regexp_mode.TabIndex = 8;
            this.regexp_mode.Text = "Режим регулярного выражения";
            this.regexp_mode.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1372, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.помощьToolStripMenuItem.Text = "Помощь   F1";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1372, 606);
            this.Controls.Add(this.regexp_mode);
            this.Controls.Add(this.deep_search);
            this.Controls.Add(this.ignore_case);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selected_path);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.keyword_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choose_start_dir);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Search";
            this.Text = "Search Tool";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.CheckBox ignore_case;
        private System.Windows.Forms.CheckBox deep_search;
        private System.Windows.Forms.CheckBox regexp_mode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem open_cmenu_item;
        private System.Windows.Forms.ToolStripMenuItem export_result_cmenu_item;
    }
}

