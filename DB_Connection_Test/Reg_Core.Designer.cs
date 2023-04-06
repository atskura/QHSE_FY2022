namespace DB_Connection_Test
{
    partial class Reg_Core
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
            this.comboBox_ExpName = new System.Windows.Forms.ComboBox();
            this.comboBox_Site = new System.Windows.Forms.ComboBox();
            this.comboBox_Hole = new System.Windows.Forms.ComboBox();
            this.comboBox_Core = new System.Windows.Forms.ComboBox();
            this.comboBox_CoreType = new System.Windows.Forms.ComboBox();
            this.comboBox_Section = new System.Windows.Forms.ComboBox();
            this.groupBox_ExpSiteHole = new System.Windows.Forms.GroupBox();
            this.label_hole = new System.Windows.Forms.Label();
            this.label_site = new System.Windows.Forms.Label();
            this.label_exp_name = new System.Windows.Forms.Label();
            this.label_exp = new System.Windows.Forms.Label();
            this.button_Reg_Hole = new System.Windows.Forms.Button();
            this.groupBox_Core = new System.Windows.Forms.GroupBox();
            this.label_core_type = new System.Windows.Forms.Label();
            this.label_core = new System.Windows.Forms.Label();
            this.button_Reg_Core = new System.Windows.Forms.Button();
            this.groupBox_Section = new System.Windows.Forms.GroupBox();
            this.label_curated_length = new System.Windows.Forms.Label();
            this.label_section = new System.Windows.Forms.Label();
            this.button_Reg_Section = new System.Windows.Forms.Button();
            this.comboBox_CuratedLength = new System.Windows.Forms.ComboBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.groupBox_ExpSiteHole.SuspendLayout();
            this.groupBox_Core.SuspendLayout();
            this.groupBox_Section.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Exp
            // 
            this.comboBox_Exp.FormattingEnabled = true;
            this.comboBox_Exp.Location = new System.Drawing.Point(43, 25);
            this.comboBox_Exp.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Exp.Name = "comboBox_Exp";
            this.comboBox_Exp.Size = new System.Drawing.Size(123, 23);
            this.comboBox_Exp.TabIndex = 0;
            this.comboBox_Exp.SelectedIndexChanged += new System.EventHandler(this.comboBox_Exp_SelectedIndexChanged);
            // 
            // comboBox_ExpName
            // 
            this.comboBox_ExpName.FormattingEnabled = true;
            this.comboBox_ExpName.Location = new System.Drawing.Point(247, 25);
            this.comboBox_ExpName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_ExpName.Name = "comboBox_ExpName";
            this.comboBox_ExpName.Size = new System.Drawing.Size(148, 23);
            this.comboBox_ExpName.TabIndex = 1;
            // 
            // comboBox_Site
            // 
            this.comboBox_Site.FormattingEnabled = true;
            this.comboBox_Site.Location = new System.Drawing.Point(43, 49);
            this.comboBox_Site.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Site.Name = "comboBox_Site";
            this.comboBox_Site.Size = new System.Drawing.Size(123, 23);
            this.comboBox_Site.TabIndex = 2;
            this.comboBox_Site.SelectedIndexChanged += new System.EventHandler(this.comboBox_Site_SelectedIndexChanged);
            // 
            // comboBox_Hole
            // 
            this.comboBox_Hole.FormattingEnabled = true;
            this.comboBox_Hole.Location = new System.Drawing.Point(247, 49);
            this.comboBox_Hole.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Hole.Name = "comboBox_Hole";
            this.comboBox_Hole.Size = new System.Drawing.Size(56, 23);
            this.comboBox_Hole.TabIndex = 3;
            this.comboBox_Hole.SelectedIndexChanged += new System.EventHandler(this.comboBox_Hole_SelectedIndexChanged);
            // 
            // comboBox_Core
            // 
            this.comboBox_Core.FormattingEnabled = true;
            this.comboBox_Core.Location = new System.Drawing.Point(43, 25);
            this.comboBox_Core.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Core.Name = "comboBox_Core";
            this.comboBox_Core.Size = new System.Drawing.Size(123, 23);
            this.comboBox_Core.TabIndex = 4;
            this.comboBox_Core.SelectedIndexChanged += new System.EventHandler(this.comboBox_Core_SelectedIndexChanged);
            // 
            // comboBox_CoreType
            // 
            this.comboBox_CoreType.FormattingEnabled = true;
            this.comboBox_CoreType.Location = new System.Drawing.Point(267, 25);
            this.comboBox_CoreType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_CoreType.Name = "comboBox_CoreType";
            this.comboBox_CoreType.Size = new System.Drawing.Size(52, 23);
            this.comboBox_CoreType.TabIndex = 5;
            // 
            // comboBox_Section
            // 
            this.comboBox_Section.FormattingEnabled = true;
            this.comboBox_Section.Location = new System.Drawing.Point(61, 25);
            this.comboBox_Section.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Section.Name = "comboBox_Section";
            this.comboBox_Section.Size = new System.Drawing.Size(62, 23);
            this.comboBox_Section.TabIndex = 6;
            this.comboBox_Section.SelectedIndexChanged += new System.EventHandler(this.comboBox_Section_SelectedIndexChanged);
            // 
            // groupBox_ExpSiteHole
            // 
            this.groupBox_ExpSiteHole.Controls.Add(this.label_hole);
            this.groupBox_ExpSiteHole.Controls.Add(this.label_site);
            this.groupBox_ExpSiteHole.Controls.Add(this.label_exp_name);
            this.groupBox_ExpSiteHole.Controls.Add(this.label_exp);
            this.groupBox_ExpSiteHole.Controls.Add(this.button_Reg_Hole);
            this.groupBox_ExpSiteHole.Controls.Add(this.comboBox_Exp);
            this.groupBox_ExpSiteHole.Controls.Add(this.comboBox_ExpName);
            this.groupBox_ExpSiteHole.Controls.Add(this.comboBox_Site);
            this.groupBox_ExpSiteHole.Controls.Add(this.comboBox_Hole);
            this.groupBox_ExpSiteHole.Location = new System.Drawing.Point(20, 7);
            this.groupBox_ExpSiteHole.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_ExpSiteHole.Name = "groupBox_ExpSiteHole";
            this.groupBox_ExpSiteHole.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_ExpSiteHole.Size = new System.Drawing.Size(526, 76);
            this.groupBox_ExpSiteHole.TabIndex = 7;
            this.groupBox_ExpSiteHole.TabStop = false;
            this.groupBox_ExpSiteHole.Text = "Exp-Site-Hole";
            // 
            // label_hole
            // 
            this.label_hole.AutoSize = true;
            this.label_hole.Location = new System.Drawing.Point(209, 50);
            this.label_hole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hole.Name = "label_hole";
            this.label_hole.Size = new System.Drawing.Size(32, 15);
            this.label_hole.TabIndex = 8;
            this.label_hole.Text = "Hole";
            // 
            // label_site
            // 
            this.label_site.AutoSize = true;
            this.label_site.Location = new System.Drawing.Point(10, 49);
            this.label_site.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_site.Name = "label_site";
            this.label_site.Size = new System.Drawing.Size(26, 15);
            this.label_site.TabIndex = 7;
            this.label_site.Text = "Site";
            // 
            // label_exp_name
            // 
            this.label_exp_name.AutoSize = true;
            this.label_exp_name.Location = new System.Drawing.Point(176, 25);
            this.label_exp_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_exp_name.Name = "label_exp_name";
            this.label_exp_name.Size = new System.Drawing.Size(63, 15);
            this.label_exp_name.TabIndex = 6;
            this.label_exp_name.Text = "Exp. Name";
            // 
            // label_exp
            // 
            this.label_exp.AutoSize = true;
            this.label_exp.Location = new System.Drawing.Point(8, 25);
            this.label_exp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(29, 15);
            this.label_exp.TabIndex = 5;
            this.label_exp.Text = "Exp.";
            // 
            // button_Reg_Hole
            // 
            this.button_Reg_Hole.Location = new System.Drawing.Point(399, 45);
            this.button_Reg_Hole.Margin = new System.Windows.Forms.Padding(2);
            this.button_Reg_Hole.Name = "button_Reg_Hole";
            this.button_Reg_Hole.Size = new System.Drawing.Size(113, 23);
            this.button_Reg_Hole.TabIndex = 4;
            this.button_Reg_Hole.Text = "Register Hole";
            this.button_Reg_Hole.UseVisualStyleBackColor = true;
            this.button_Reg_Hole.Click += new System.EventHandler(this.button_Reg_Hole_Click);
            // 
            // groupBox_Core
            // 
            this.groupBox_Core.Controls.Add(this.label_core_type);
            this.groupBox_Core.Controls.Add(this.label_core);
            this.groupBox_Core.Controls.Add(this.button_Reg_Core);
            this.groupBox_Core.Controls.Add(this.comboBox_Core);
            this.groupBox_Core.Controls.Add(this.comboBox_CoreType);
            this.groupBox_Core.Location = new System.Drawing.Point(20, 87);
            this.groupBox_Core.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Core.Name = "groupBox_Core";
            this.groupBox_Core.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Core.Size = new System.Drawing.Size(526, 60);
            this.groupBox_Core.TabIndex = 8;
            this.groupBox_Core.TabStop = false;
            this.groupBox_Core.Text = "Core";
            // 
            // label_core_type
            // 
            this.label_core_type.AutoSize = true;
            this.label_core_type.Location = new System.Drawing.Point(200, 26);
            this.label_core_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_core_type.Name = "label_core_type";
            this.label_core_type.Size = new System.Drawing.Size(58, 15);
            this.label_core_type.TabIndex = 10;
            this.label_core_type.Text = "Core Type";
            // 
            // label_core
            // 
            this.label_core.AutoSize = true;
            this.label_core.Location = new System.Drawing.Point(4, 26);
            this.label_core.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_core.Name = "label_core";
            this.label_core.Size = new System.Drawing.Size(31, 15);
            this.label_core.TabIndex = 9;
            this.label_core.Text = "Core";
            // 
            // button_Reg_Core
            // 
            this.button_Reg_Core.Location = new System.Drawing.Point(399, 25);
            this.button_Reg_Core.Margin = new System.Windows.Forms.Padding(2);
            this.button_Reg_Core.Name = "button_Reg_Core";
            this.button_Reg_Core.Size = new System.Drawing.Size(113, 23);
            this.button_Reg_Core.TabIndex = 5;
            this.button_Reg_Core.Text = "Register Core";
            this.button_Reg_Core.UseVisualStyleBackColor = true;
            this.button_Reg_Core.Click += new System.EventHandler(this.button_Reg_Core_Click);
            // 
            // groupBox_Section
            // 
            this.groupBox_Section.Controls.Add(this.label_curated_length);
            this.groupBox_Section.Controls.Add(this.label_section);
            this.groupBox_Section.Controls.Add(this.button_Reg_Section);
            this.groupBox_Section.Controls.Add(this.comboBox_CuratedLength);
            this.groupBox_Section.Controls.Add(this.comboBox_Section);
            this.groupBox_Section.Location = new System.Drawing.Point(20, 151);
            this.groupBox_Section.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Section.Name = "groupBox_Section";
            this.groupBox_Section.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Section.Size = new System.Drawing.Size(526, 53);
            this.groupBox_Section.TabIndex = 9;
            this.groupBox_Section.TabStop = false;
            this.groupBox_Section.Text = "Section";
            // 
            // label_curated_length
            // 
            this.label_curated_length.AutoSize = true;
            this.label_curated_length.Location = new System.Drawing.Point(140, 25);
            this.label_curated_length.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_curated_length.Name = "label_curated_length";
            this.label_curated_length.Size = new System.Drawing.Size(115, 15);
            this.label_curated_length.TabIndex = 12;
            this.label_curated_length.Text = "Curated Length (cm)";
            // 
            // label_section
            // 
            this.label_section.AutoSize = true;
            this.label_section.Location = new System.Drawing.Point(8, 25);
            this.label_section.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_section.Name = "label_section";
            this.label_section.Size = new System.Drawing.Size(46, 15);
            this.label_section.TabIndex = 11;
            this.label_section.Text = "Section";
            // 
            // button_Reg_Section
            // 
            this.button_Reg_Section.Location = new System.Drawing.Point(399, 21);
            this.button_Reg_Section.Margin = new System.Windows.Forms.Padding(2);
            this.button_Reg_Section.Name = "button_Reg_Section";
            this.button_Reg_Section.Size = new System.Drawing.Size(113, 23);
            this.button_Reg_Section.TabIndex = 8;
            this.button_Reg_Section.Text = "Register Section";
            this.button_Reg_Section.UseVisualStyleBackColor = true;
            this.button_Reg_Section.Click += new System.EventHandler(this.button_Reg_Section_Click);
            // 
            // comboBox_CuratedLength
            // 
            this.comboBox_CuratedLength.FormattingEnabled = true;
            this.comboBox_CuratedLength.Location = new System.Drawing.Point(267, 25);
            this.comboBox_CuratedLength.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_CuratedLength.Name = "comboBox_CuratedLength";
            this.comboBox_CuratedLength.Size = new System.Drawing.Size(83, 23);
            this.comboBox_CuratedLength.TabIndex = 7;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(20, 207);
            this.textBox_Status.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Status.Multiline = true;
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Status.Size = new System.Drawing.Size(527, 57);
            this.textBox_Status.TabIndex = 10;
            // 
            // Reg_Core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.groupBox_Section);
            this.Controls.Add(this.groupBox_Core);
            this.Controls.Add(this.groupBox_ExpSiteHole);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reg_Core";
            this.Text = "Reg_Core";
            this.groupBox_ExpSiteHole.ResumeLayout(false);
            this.groupBox_ExpSiteHole.PerformLayout();
            this.groupBox_Core.ResumeLayout(false);
            this.groupBox_Core.PerformLayout();
            this.groupBox_Section.ResumeLayout(false);
            this.groupBox_Section.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox_Exp;
        private ComboBox comboBox_ExpName;
        private ComboBox comboBox_Site;
        private ComboBox comboBox_Hole;
        private ComboBox comboBox_Core;
        private ComboBox comboBox_CoreType;
        private ComboBox comboBox_Section;
        private GroupBox groupBox_ExpSiteHole;
        private Button button_Reg_Hole;
        private GroupBox groupBox_Core;
        private Button button_Reg_Core;
        private GroupBox groupBox_Section;
        private Button button_Reg_Section;
        private ComboBox comboBox_CuratedLength;
        private TextBox textBox_Status;
        private Label label_hole;
        private Label label_site;
        private Label label_exp_name;
        private Label label_exp;
        private Label label_core_type;
        private Label label_core;
        private Label label_curated_length;
        private Label label_section;
    }
}