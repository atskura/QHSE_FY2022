namespace DB_Connection_Test
{
    partial class Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox_table = new ComboBox();
            button_Go = new Button();
            textBox_data = new TextBox();
            dataGridView_list = new DataGridView();
            button_updateDGV = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_list).BeginInit();
            SuspendLayout();
            // 
            // comboBox_table
            // 
            comboBox_table.FormattingEnabled = true;
            comboBox_table.Location = new Point(12, 12);
            comboBox_table.Name = "comboBox_table";
            comboBox_table.Size = new Size(265, 33);
            comboBox_table.TabIndex = 0;
            // 
            // button_Go
            // 
            button_Go.Location = new Point(12, 475);
            button_Go.Name = "button_Go";
            button_Go.Size = new Size(112, 34);
            button_Go.TabIndex = 1;
            button_Go.Text = "Go";
            button_Go.UseVisualStyleBackColor = true;
            button_Go.Click += button_Go_Click;
            // 
            // textBox_data
            // 
            textBox_data.Location = new Point(12, 515);
            textBox_data.Multiline = true;
            textBox_data.Name = "textBox_data";
            textBox_data.ScrollBars = ScrollBars.Both;
            textBox_data.Size = new Size(776, 322);
            textBox_data.TabIndex = 2;
            // 
            // dataGridView_list
            // 
            dataGridView_list.AllowUserToAddRows = false;
            dataGridView_list.AllowUserToDeleteRows = false;
            dataGridView_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_list.Location = new Point(12, 55);
            dataGridView_list.Name = "dataGridView_list";
            dataGridView_list.ReadOnly = true;
            dataGridView_list.RowHeadersWidth = 62;
            dataGridView_list.RowTemplate.Height = 33;
            dataGridView_list.Size = new Size(1723, 373);
            dataGridView_list.TabIndex = 3;
            // 
            // button_updateDGV
            // 
            button_updateDGV.Location = new Point(299, 12);
            button_updateDGV.Name = "button_updateDGV";
            button_updateDGV.Size = new Size(112, 34);
            button_updateDGV.TabIndex = 4;
            button_updateDGV.Text = "Go";
            button_updateDGV.UseVisualStyleBackColor = true;
            button_updateDGV.Click += button_updateDGV_Click;
            // 
            // Viewer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1752, 443);
            Controls.Add(button_updateDGV);
            Controls.Add(dataGridView_list);
            Controls.Add(textBox_data);
            Controls.Add(button_Go);
            Controls.Add(comboBox_table);
            Name = "Viewer";
            Text = "Viewer";
            Load += Viewer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_table;
        private Button button_Go;
        private TextBox textBox_data;
        private DataGridView dataGridView_list;
        private Button button_updateDGV;
    }
}