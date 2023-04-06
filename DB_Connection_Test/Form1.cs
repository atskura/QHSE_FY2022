using System;
using System.Data.SqlClient;

namespace DB_Connection_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var sql = "SELECT * from expedition";

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {
                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            textBox1.Text = reader["expedition"].ToString();
                        }
                    }
                }
                finally
                {
                    connection.Close();
                }


                string v = string.Format("Exp. {0}", textBox1.Text);
                label1.Text = v;
            }

        }



        private void button_ShowForm_Viewer_Click(object sender, EventArgs e)
        {
            Viewer form_viewer = new Viewer();
            form_viewer.Show();
        }

        private void button_ShowForm_Reg_Sample_Click(object sender, EventArgs e)
        {
            Reg_Sample form_reg_sample = new Reg_Sample();
            form_reg_sample.Show();
        }

        private void button_ShowForm_Reg_Core_Click(object sender, EventArgs e)
        {
            Reg_Core form_reg_core = new Reg_Core();
            form_reg_core.Show();
        }

        private void button_ShowForm_Reg_Data_Click(object sender, EventArgs e)
        {
            Reg_Data form_reg_data = new Reg_Data();
            form_reg_data.Show();
        }
    }
}