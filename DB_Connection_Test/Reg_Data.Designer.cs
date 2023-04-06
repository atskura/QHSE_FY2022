namespace DB_Connection_Test
{
    partial class Reg_Data
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
            textBox_sampleID = new TextBox();
            label_SampleID = new Label();
            label_SampleSource = new Label();
            label_SampleSource_text = new Label();
            comboBox_Inst = new ComboBox();
            label_Instrument = new Label();
            dataGridView_data = new DataGridView();
            Column_methodID = new DataGridViewTextBoxColumn();
            Column_method = new DataGridViewTextBoxColumn();
            Column_value = new DataGridViewTextBoxColumn();
            button_register = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_data).BeginInit();
            SuspendLayout();
            // 
            // textBox_sampleID
            // 
            textBox_sampleID.Location = new Point(12, 37);
            textBox_sampleID.Name = "textBox_sampleID";
            textBox_sampleID.Size = new Size(263, 31);
            textBox_sampleID.TabIndex = 0;
            textBox_sampleID.TextChanged += textBox1_TextChanged;
            // 
            // label_SampleID
            // 
            label_SampleID.AutoSize = true;
            label_SampleID.Location = new Point(12, 9);
            label_SampleID.Name = "label_SampleID";
            label_SampleID.Size = new Size(94, 25);
            label_SampleID.TabIndex = 1;
            label_SampleID.Text = "Sample ID";
            // 
            // label_SampleSource
            // 
            label_SampleSource.AutoSize = true;
            label_SampleSource.Location = new Point(12, 80);
            label_SampleSource.Name = "label_SampleSource";
            label_SampleSource.Size = new Size(130, 25);
            label_SampleSource.TabIndex = 2;
            label_SampleSource.Text = "Sample Source";
            // 
            // label_SampleSource_text
            // 
            label_SampleSource_text.AutoSize = true;
            label_SampleSource_text.BackColor = SystemColors.ControlLightLight;
            label_SampleSource_text.Location = new Point(12, 105);
            label_SampleSource_text.Name = "label_SampleSource_text";
            label_SampleSource_text.Size = new Size(237, 25);
            label_SampleSource_text.TabIndex = 3;
            label_SampleSource_text.Text = "exp-hole-core-section depth";
            // 
            // comboBox_Inst
            // 
            comboBox_Inst.FormattingEnabled = true;
            comboBox_Inst.Location = new Point(330, 37);
            comboBox_Inst.Name = "comboBox_Inst";
            comboBox_Inst.Size = new Size(276, 33);
            comboBox_Inst.TabIndex = 4;
            comboBox_Inst.SelectedIndexChanged += comboBox_Inst_SelectedIndexChanged;
            // 
            // label_Instrument
            // 
            label_Instrument.AutoSize = true;
            label_Instrument.Location = new Point(330, 9);
            label_Instrument.Name = "label_Instrument";
            label_Instrument.Size = new Size(98, 25);
            label_Instrument.TabIndex = 5;
            label_Instrument.Text = "Instrument";
            // 
            // dataGridView_data
            // 
            dataGridView_data.AllowUserToAddRows = false;
            dataGridView_data.AllowUserToDeleteRows = false;
            dataGridView_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_data.Columns.AddRange(new DataGridViewColumn[] { Column_methodID, Column_method, Column_value });
            dataGridView_data.Location = new Point(12, 151);
            dataGridView_data.Name = "dataGridView_data";
            dataGridView_data.RowHeadersWidth = 62;
            dataGridView_data.RowTemplate.Height = 33;
            dataGridView_data.Size = new Size(749, 271);
            dataGridView_data.TabIndex = 6;
            // 
            // Column_methodID
            // 
            Column_methodID.HeaderText = "Method ID";
            Column_methodID.MinimumWidth = 8;
            Column_methodID.Name = "Column_methodID";
            Column_methodID.Visible = false;
            Column_methodID.Width = 150;
            // 
            // Column_method
            // 
            Column_method.HeaderText = "Parameter";
            Column_method.MinimumWidth = 8;
            Column_method.Name = "Column_method";
            Column_method.Width = 300;
            // 
            // Column_value
            // 
            Column_value.HeaderText = "Value";
            Column_value.MinimumWidth = 8;
            Column_value.Name = "Column_value";
            Column_value.Width = 200;
            // 
            // button_register
            // 
            button_register.Location = new Point(619, 433);
            button_register.Name = "button_register";
            button_register.Size = new Size(142, 30);
            button_register.TabIndex = 7;
            button_register.Text = "Register Data";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // Reg_Data
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(button_register);
            Controls.Add(dataGridView_data);
            Controls.Add(label_Instrument);
            Controls.Add(comboBox_Inst);
            Controls.Add(label_SampleSource_text);
            Controls.Add(label_SampleSource);
            Controls.Add(label_SampleID);
            Controls.Add(textBox_sampleID);
            Name = "Reg_Data";
            Text = "Register Data";
            ((System.ComponentModel.ISupportInitialize)dataGridView_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_sampleID;
        private Label label_SampleID;
        private Label label_SampleSource;
        private Label label_SampleSource_text;
        private ComboBox comboBox_Inst;
        private Label label_Instrument;
        private DataGridView dataGridView_data;
        private Button button_register;
        private DataGridViewTextBoxColumn Column_methodID;
        private DataGridViewTextBoxColumn Column_method;
        private DataGridViewTextBoxColumn Column_value;
    }
}