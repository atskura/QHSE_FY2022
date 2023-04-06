namespace DB_Connection_Test
{
    partial class Reg_Sample
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
            this.comboBox_Exp = new System.Windows.Forms.ComboBox();
            this.comboBox_Site = new System.Windows.Forms.ComboBox();
            this.comboBox_Hole = new System.Windows.Forms.ComboBox();
            this.button_Go = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox_Core = new System.Windows.Forms.ComboBox();
            this.comboBox_Section = new System.Windows.Forms.ComboBox();
            this.label_Exp = new System.Windows.Forms.Label();
            this.label_Site = new System.Windows.Forms.Label();
            this.label_Hole = new System.Windows.Forms.Label();
            this.label_Core = new System.Windows.Forms.Label();
            this.label_Section = new System.Windows.Forms.Label();
            this.label_CoreType = new System.Windows.Forms.Label();
            this.comboBox_CoreType = new System.Windows.Forms.ComboBox();
            this.label_SecitonID = new System.Windows.Forms.Label();
            this.comboBox_SectionID = new System.Windows.Forms.ComboBox();
            this.textBox_Interval_Top = new System.Windows.Forms.TextBox();
            this.textBox_Interval_Bottom = new System.Windows.Forms.TextBox();
            this.label_Intervals = new System.Windows.Forms.Label();
            this.label_Interval_Top = new System.Windows.Forms.Label();
            this.label_Interval_Bottom = new System.Windows.Forms.Label();
            this.label_SampleID = new System.Windows.Forms.Label();
            this.textBox_SampleID = new System.Windows.Forms.TextBox();
            this.dataGridView_SampleList = new System.Windows.Forms.DataGridView();
            this.DGVcolumn_SampleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVcolumn_Exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVcolumn_Grid_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hole_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVcolumn_Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVcolumn_CoreType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVcolumn_Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVcolumn_Interval_Top = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVcolumn_Interval_Bottom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_update_DGV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SampleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Exp
            // 
            this.comboBox_Exp.FormattingEnabled = true;
            this.comboBox_Exp.Location = new System.Drawing.Point(77, 52);
            this.comboBox_Exp.Name = "comboBox_Exp";
            this.comboBox_Exp.Size = new System.Drawing.Size(183, 33);
            this.comboBox_Exp.TabIndex = 0;
            this.comboBox_Exp.SelectedIndexChanged += new System.EventHandler(this.comboBox_Exp_SelectedIndexChanged);
            // 
            // comboBox_Site
            // 
            this.comboBox_Site.FormattingEnabled = true;
            this.comboBox_Site.Location = new System.Drawing.Point(341, 52);
            this.comboBox_Site.Name = "comboBox_Site";
            this.comboBox_Site.Size = new System.Drawing.Size(183, 33);
            this.comboBox_Site.TabIndex = 1;
            this.comboBox_Site.SelectedIndexChanged += new System.EventHandler(this.comboBox_Site_SelectedIndexChanged);
            // 
            // comboBox_Hole
            // 
            this.comboBox_Hole.FormattingEnabled = true;
            this.comboBox_Hole.Location = new System.Drawing.Point(600, 52);
            this.comboBox_Hole.Name = "comboBox_Hole";
            this.comboBox_Hole.Size = new System.Drawing.Size(74, 33);
            this.comboBox_Hole.TabIndex = 2;
            this.comboBox_Hole.SelectedIndexChanged += new System.EventHandler(this.comboBox_Hole_SelectedIndexChanged);
            // 
            // button_Go
            // 
            this.button_Go.Location = new System.Drawing.Point(553, 264);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(211, 33);
            this.button_Go.TabIndex = 7;
            this.button_Go.Text = "Register New Sample";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button_Go_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 822);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(181, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // comboBox_Core
            // 
            this.comboBox_Core.FormattingEnabled = true;
            this.comboBox_Core.Location = new System.Drawing.Point(124, 125);
            this.comboBox_Core.Name = "comboBox_Core";
            this.comboBox_Core.Size = new System.Drawing.Size(135, 33);
            this.comboBox_Core.TabIndex = 3;
            this.comboBox_Core.SelectedIndexChanged += new System.EventHandler(this.comboBox_Core_SelectedIndexChanged);
            // 
            // comboBox_Section
            // 
            this.comboBox_Section.FormattingEnabled = true;
            this.comboBox_Section.Location = new System.Drawing.Point(586, 125);
            this.comboBox_Section.Name = "comboBox_Section";
            this.comboBox_Section.Size = new System.Drawing.Size(88, 33);
            this.comboBox_Section.TabIndex = 5;
            this.comboBox_Section.SelectedIndexChanged += new System.EventHandler(this.comboBox_Section_SelectedIndexChanged);
            // 
            // label_Exp
            // 
            this.label_Exp.AutoSize = true;
            this.label_Exp.Location = new System.Drawing.Point(33, 52);
            this.label_Exp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Exp.Name = "label_Exp";
            this.label_Exp.Size = new System.Drawing.Size(40, 25);
            this.label_Exp.TabIndex = 7;
            this.label_Exp.Text = "Exp";
            // 
            // label_Site
            // 
            this.label_Site.AutoSize = true;
            this.label_Site.Location = new System.Drawing.Point(297, 52);
            this.label_Site.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Site.Name = "label_Site";
            this.label_Site.Size = new System.Drawing.Size(41, 25);
            this.label_Site.TabIndex = 8;
            this.label_Site.Text = "Site";
            // 
            // label_Hole
            // 
            this.label_Hole.AutoSize = true;
            this.label_Hole.Location = new System.Drawing.Point(551, 52);
            this.label_Hole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Hole.Name = "label_Hole";
            this.label_Hole.Size = new System.Drawing.Size(49, 25);
            this.label_Hole.TabIndex = 9;
            this.label_Hole.Text = "Hole";
            // 
            // label_Core
            // 
            this.label_Core.AutoSize = true;
            this.label_Core.Location = new System.Drawing.Point(73, 125);
            this.label_Core.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Core.Name = "label_Core";
            this.label_Core.Size = new System.Drawing.Size(49, 25);
            this.label_Core.TabIndex = 10;
            this.label_Core.Text = "Core";
            // 
            // label_Section
            // 
            this.label_Section.AutoSize = true;
            this.label_Section.Location = new System.Drawing.Point(496, 125);
            this.label_Section.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Section.Name = "label_Section";
            this.label_Section.Size = new System.Drawing.Size(70, 25);
            this.label_Section.TabIndex = 11;
            this.label_Section.Text = "Section";
            // 
            // label_CoreType
            // 
            this.label_CoreType.AutoSize = true;
            this.label_CoreType.Location = new System.Drawing.Point(284, 125);
            this.label_CoreType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CoreType.Name = "label_CoreType";
            this.label_CoreType.Size = new System.Drawing.Size(90, 25);
            this.label_CoreType.TabIndex = 12;
            this.label_CoreType.Text = "Core Type";
            // 
            // comboBox_CoreType
            // 
            this.comboBox_CoreType.FormattingEnabled = true;
            this.comboBox_CoreType.Location = new System.Drawing.Point(374, 125);
            this.comboBox_CoreType.Name = "comboBox_CoreType";
            this.comboBox_CoreType.Size = new System.Drawing.Size(75, 33);
            this.comboBox_CoreType.TabIndex = 4;
            // 
            // label_SecitonID
            // 
            this.label_SecitonID.AutoSize = true;
            this.label_SecitonID.Location = new System.Drawing.Point(496, 185);
            this.label_SecitonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SecitonID.Name = "label_SecitonID";
            this.label_SecitonID.Size = new System.Drawing.Size(93, 25);
            this.label_SecitonID.TabIndex = 14;
            this.label_SecitonID.Text = "Section ID";
            // 
            // comboBox_SectionID
            // 
            this.comboBox_SectionID.FormattingEnabled = true;
            this.comboBox_SectionID.Location = new System.Drawing.Point(586, 180);
            this.comboBox_SectionID.Name = "comboBox_SectionID";
            this.comboBox_SectionID.Size = new System.Drawing.Size(197, 33);
            this.comboBox_SectionID.TabIndex = 6;
            this.comboBox_SectionID.TextChanged += new System.EventHandler(this.comboBox_SectionID_TextChanged);
            // 
            // textBox_Interval_Top
            // 
            this.textBox_Interval_Top.Location = new System.Drawing.Point(80, 264);
            this.textBox_Interval_Top.Name = "textBox_Interval_Top";
            this.textBox_Interval_Top.Size = new System.Drawing.Size(150, 31);
            this.textBox_Interval_Top.TabIndex = 15;
            // 
            // textBox_Interval_Bottom
            // 
            this.textBox_Interval_Bottom.Location = new System.Drawing.Point(344, 264);
            this.textBox_Interval_Bottom.Name = "textBox_Interval_Bottom";
            this.textBox_Interval_Bottom.Size = new System.Drawing.Size(150, 31);
            this.textBox_Interval_Bottom.TabIndex = 16;
            // 
            // label_Intervals
            // 
            this.label_Intervals.AutoSize = true;
            this.label_Intervals.Location = new System.Drawing.Point(33, 230);
            this.label_Intervals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Intervals.Name = "label_Intervals";
            this.label_Intervals.Size = new System.Drawing.Size(197, 25);
            this.label_Intervals.TabIndex = 17;
            this.label_Intervals.Text = "Sampling Intervals (cm)";
            // 
            // label_Interval_Top
            // 
            this.label_Interval_Top.AutoSize = true;
            this.label_Interval_Top.Location = new System.Drawing.Point(33, 264);
            this.label_Interval_Top.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Interval_Top.Name = "label_Interval_Top";
            this.label_Interval_Top.Size = new System.Drawing.Size(41, 25);
            this.label_Interval_Top.TabIndex = 18;
            this.label_Interval_Top.Text = "Top";
            // 
            // label_Interval_Bottom
            // 
            this.label_Interval_Bottom.AutoSize = true;
            this.label_Interval_Bottom.Location = new System.Drawing.Point(265, 264);
            this.label_Interval_Bottom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Interval_Bottom.Name = "label_Interval_Bottom";
            this.label_Interval_Bottom.Size = new System.Drawing.Size(72, 25);
            this.label_Interval_Bottom.TabIndex = 19;
            this.label_Interval_Bottom.Text = "Bottom";
            // 
            // label_SampleID
            // 
            this.label_SampleID.AutoSize = true;
            this.label_SampleID.Location = new System.Drawing.Point(496, 352);
            this.label_SampleID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SampleID.Name = "label_SampleID";
            this.label_SampleID.Size = new System.Drawing.Size(94, 25);
            this.label_SampleID.TabIndex = 20;
            this.label_SampleID.Text = "Sample ID";
            // 
            // textBox_SampleID
            // 
            this.textBox_SampleID.Location = new System.Drawing.Point(586, 352);
            this.textBox_SampleID.Name = "textBox_SampleID";
            this.textBox_SampleID.ReadOnly = true;
            this.textBox_SampleID.Size = new System.Drawing.Size(197, 31);
            this.textBox_SampleID.TabIndex = 21;
            // 
            // dataGridView_SampleList
            // 
            this.dataGridView_SampleList.AllowUserToAddRows = false;
            this.dataGridView_SampleList.AllowUserToDeleteRows = false;
            this.dataGridView_SampleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SampleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVcolumn_SampleID,
            this.DGVcolumn_Exp,
            this.DGVcolumn_Grid_Site,
            this.hole_number,
            this.DGVcolumn_Core,
            this.DGVcolumn_CoreType,
            this.DGVcolumn_Section,
            this.DGVcolumn_Interval_Top,
            this.DGVcolumn_Interval_Bottom});
            this.dataGridView_SampleList.Location = new System.Drawing.Point(19, 420);
            this.dataGridView_SampleList.Name = "dataGridView_SampleList";
            this.dataGridView_SampleList.ReadOnly = true;
            this.dataGridView_SampleList.RowHeadersWidth = 62;
            this.dataGridView_SampleList.RowTemplate.Height = 33;
            this.dataGridView_SampleList.Size = new System.Drawing.Size(769, 376);
            this.dataGridView_SampleList.TabIndex = 22;
            // 
            // DGVcolumn_SampleID
            // 
            this.DGVcolumn_SampleID.HeaderText = "Sample ID";
            this.DGVcolumn_SampleID.MinimumWidth = 8;
            this.DGVcolumn_SampleID.Name = "DGVcolumn_SampleID";
            this.DGVcolumn_SampleID.ReadOnly = true;
            this.DGVcolumn_SampleID.Width = 150;
            // 
            // DGVcolumn_Exp
            // 
            this.DGVcolumn_Exp.HeaderText = "Exp";
            this.DGVcolumn_Exp.MinimumWidth = 8;
            this.DGVcolumn_Exp.Name = "DGVcolumn_Exp";
            this.DGVcolumn_Exp.ReadOnly = true;
            this.DGVcolumn_Exp.Width = 50;
            // 
            // DGVcolumn_Grid_Site
            // 
            this.DGVcolumn_Grid_Site.HeaderText = "Site";
            this.DGVcolumn_Grid_Site.MinimumWidth = 8;
            this.DGVcolumn_Grid_Site.Name = "DGVcolumn_Grid_Site";
            this.DGVcolumn_Grid_Site.ReadOnly = true;
            this.DGVcolumn_Grid_Site.Width = 150;
            // 
            // hole_number
            // 
            this.hole_number.HeaderText = "Hole";
            this.hole_number.MinimumWidth = 8;
            this.hole_number.Name = "hole_number";
            this.hole_number.ReadOnly = true;
            this.hole_number.Width = 50;
            // 
            // DGVcolumn_Core
            // 
            this.DGVcolumn_Core.HeaderText = "Core";
            this.DGVcolumn_Core.MinimumWidth = 8;
            this.DGVcolumn_Core.Name = "DGVcolumn_Core";
            this.DGVcolumn_Core.ReadOnly = true;
            this.DGVcolumn_Core.Width = 50;
            // 
            // DGVcolumn_CoreType
            // 
            this.DGVcolumn_CoreType.HeaderText = "Type";
            this.DGVcolumn_CoreType.MinimumWidth = 8;
            this.DGVcolumn_CoreType.Name = "DGVcolumn_CoreType";
            this.DGVcolumn_CoreType.ReadOnly = true;
            this.DGVcolumn_CoreType.Width = 50;
            // 
            // DGVcolumn_Section
            // 
            this.DGVcolumn_Section.HeaderText = "Sect.";
            this.DGVcolumn_Section.MinimumWidth = 8;
            this.DGVcolumn_Section.Name = "DGVcolumn_Section";
            this.DGVcolumn_Section.ReadOnly = true;
            this.DGVcolumn_Section.Width = 50;
            // 
            // DGVcolumn_Interval_Top
            // 
            this.DGVcolumn_Interval_Top.HeaderText = "Top";
            this.DGVcolumn_Interval_Top.MinimumWidth = 8;
            this.DGVcolumn_Interval_Top.Name = "DGVcolumn_Interval_Top";
            this.DGVcolumn_Interval_Top.ReadOnly = true;
            this.DGVcolumn_Interval_Top.Width = 150;
            // 
            // DGVcolumn_Interval_Bottom
            // 
            this.DGVcolumn_Interval_Bottom.HeaderText = "Btm";
            this.DGVcolumn_Interval_Bottom.MinimumWidth = 8;
            this.DGVcolumn_Interval_Bottom.Name = "DGVcolumn_Interval_Bottom";
            this.DGVcolumn_Interval_Bottom.ReadOnly = true;
            this.DGVcolumn_Interval_Bottom.Width = 150;
            // 
            // button_update_DGV
            // 
            this.button_update_DGV.Location = new System.Drawing.Point(19, 371);
            this.button_update_DGV.Name = "button_update_DGV";
            this.button_update_DGV.Size = new System.Drawing.Size(169, 43);
            this.button_update_DGV.TabIndex = 23;
            this.button_update_DGV.Text = "View Sample List";
            this.button_update_DGV.UseVisualStyleBackColor = true;
            this.button_update_DGV.Click += new System.EventHandler(this.update_DataGridView);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(745, 376);
            this.dataGridView1.TabIndex = 24;
            // 
            // Reg_Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 854);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_update_DGV);
            this.Controls.Add(this.dataGridView_SampleList);
            this.Controls.Add(this.textBox_SampleID);
            this.Controls.Add(this.label_SampleID);
            this.Controls.Add(this.label_Interval_Bottom);
            this.Controls.Add(this.label_Interval_Top);
            this.Controls.Add(this.label_Intervals);
            this.Controls.Add(this.textBox_Interval_Bottom);
            this.Controls.Add(this.textBox_Interval_Top);
            this.Controls.Add(this.comboBox_SectionID);
            this.Controls.Add(this.label_SecitonID);
            this.Controls.Add(this.comboBox_CoreType);
            this.Controls.Add(this.label_CoreType);
            this.Controls.Add(this.label_Section);
            this.Controls.Add(this.label_Core);
            this.Controls.Add(this.label_Hole);
            this.Controls.Add(this.label_Site);
            this.Controls.Add(this.label_Exp);
            this.Controls.Add(this.comboBox_Section);
            this.Controls.Add(this.comboBox_Core);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Go);
            this.Controls.Add(this.comboBox_Hole);
            this.Controls.Add(this.comboBox_Site);
            this.Controls.Add(this.comboBox_Exp);
            this.Name = "Reg_Sample";
            this.Text = "Reg_Sample";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SampleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox_Exp;
        private ComboBox comboBox_Site;
        private ComboBox comboBox_Hole;
        private Button button_Go;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ComboBox comboBox_Core;
        private ComboBox comboBox_Section;
        private Label label_Exp;
        private Label label_Site;
        private Label label_Hole;
        private Label label_Core;
        private Label label_Section;
        private Label label_CoreType;
        private ComboBox comboBox_CoreType;
        private Label label_SecitonID;
        private ComboBox comboBox_SectionID;
        private TextBox textBox_Interval_Top;
        private TextBox textBox_Interval_Bottom;
        private Label label_Intervals;
        private Label label_Interval_Top;
        private Label label_Interval_Bottom;
        private Label label_SampleID;
        private TextBox textBox_SampleID;
        private DataGridView dataGridView_SampleList;
        private Button button_update_DGV;
        private DataGridViewTextBoxColumn DGVcolumn_SampleID;
        private DataGridViewTextBoxColumn DGVcolumn_Exp;
        private DataGridViewTextBoxColumn DGVcolumn_Grid_Site;
        private DataGridViewTextBoxColumn hole_number;
        private DataGridViewTextBoxColumn DGVcolumn_Core;
        private DataGridViewTextBoxColumn DGVcolumn_CoreType;
        private DataGridViewTextBoxColumn DGVcolumn_Section;
        private DataGridViewTextBoxColumn DGVcolumn_Interval_Top;
        private DataGridViewTextBoxColumn DGVcolumn_Interval_Bottom;
        private DataGridView dataGridView1;
    }
}