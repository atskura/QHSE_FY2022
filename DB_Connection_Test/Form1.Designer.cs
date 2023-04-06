namespace DB_Connection_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button_ShowForm_Viewer = new Button();
            button_ShowForm_Reg_Sample = new Button();
            button_ShowForm_Reg_Core = new Button();
            button_ShowForm_Reg_Data = new Button();
            label_Registration = new Label();
            label_Viewer = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(177, 380);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 263);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 316);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(494, 323);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            // 
            // button_ShowForm_Viewer
            // 
            button_ShowForm_Viewer.Location = new Point(310, 47);
            button_ShowForm_Viewer.Name = "button_ShowForm_Viewer";
            button_ShowForm_Viewer.Size = new Size(215, 34);
            button_ShowForm_Viewer.TabIndex = 5;
            button_ShowForm_Viewer.Text = "Open form: Viewer";
            button_ShowForm_Viewer.UseVisualStyleBackColor = true;
            button_ShowForm_Viewer.Click += button_ShowForm_Viewer_Click;
            // 
            // button_ShowForm_Reg_Sample
            // 
            button_ShowForm_Reg_Sample.Location = new Point(27, 101);
            button_ShowForm_Reg_Sample.Name = "button_ShowForm_Reg_Sample";
            button_ShowForm_Reg_Sample.Size = new Size(215, 34);
            button_ShowForm_Reg_Sample.TabIndex = 6;
            button_ShowForm_Reg_Sample.Text = "Open form: Reg_Sample";
            button_ShowForm_Reg_Sample.UseVisualStyleBackColor = true;
            button_ShowForm_Reg_Sample.Click += button_ShowForm_Reg_Sample_Click;
            // 
            // button_ShowForm_Reg_Core
            // 
            button_ShowForm_Reg_Core.Location = new Point(27, 47);
            button_ShowForm_Reg_Core.Name = "button_ShowForm_Reg_Core";
            button_ShowForm_Reg_Core.Size = new Size(215, 34);
            button_ShowForm_Reg_Core.TabIndex = 7;
            button_ShowForm_Reg_Core.Text = "Open form: Reg_Core";
            button_ShowForm_Reg_Core.UseVisualStyleBackColor = true;
            button_ShowForm_Reg_Core.Click += button_ShowForm_Reg_Core_Click;
            // 
            // button_ShowForm_Reg_Data
            // 
            button_ShowForm_Reg_Data.Location = new Point(27, 159);
            button_ShowForm_Reg_Data.Name = "button_ShowForm_Reg_Data";
            button_ShowForm_Reg_Data.Size = new Size(215, 34);
            button_ShowForm_Reg_Data.TabIndex = 8;
            button_ShowForm_Reg_Data.Text = "Open form: Reg_Data";
            button_ShowForm_Reg_Data.UseVisualStyleBackColor = true;
            button_ShowForm_Reg_Data.Click += button_ShowForm_Reg_Data_Click;
            // 
            // label_Registration
            // 
            label_Registration.AutoSize = true;
            label_Registration.Location = new Point(27, 9);
            label_Registration.Name = "label_Registration";
            label_Registration.Size = new Size(107, 25);
            label_Registration.TabIndex = 9;
            label_Registration.Text = "Registration";
            // 
            // label_Viewer
            // 
            label_Viewer.AutoSize = true;
            label_Viewer.Location = new Point(310, 9);
            label_Viewer.Name = "label_Viewer";
            label_Viewer.Size = new Size(64, 25);
            label_Viewer.TabIndex = 10;
            label_Viewer.Text = "Viewer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 216);
            Controls.Add(label_Viewer);
            Controls.Add(label_Registration);
            Controls.Add(button_ShowForm_Reg_Data);
            Controls.Add(button_ShowForm_Reg_Core);
            Controls.Add(button_ShowForm_Reg_Sample);
            Controls.Add(button_ShowForm_Viewer);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Start";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button_ShowForm_Viewer;
        private Button button_ShowForm_Reg_Sample;
        private Button button_ShowForm_Reg_Core;
        private Button button_ShowForm_Reg_Data;
        private Label label_Registration;
        private Label label_Viewer;
    }
}