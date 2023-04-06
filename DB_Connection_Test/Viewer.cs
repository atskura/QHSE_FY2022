using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Collections.Specialized.BitVector32;
using System.Security.Policy;

namespace DB_Connection_Test
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();

            comboBox_table.Items.Add("expedition");
            comboBox_table.Items.Add("site");
            comboBox_table.Items.Add("hole");
            comboBox_table.Items.Add("core");
            comboBox_table.Items.Add("sample");
            comboBox_table.Items.Add("Measurement Data");
            comboBox_table.SelectedIndex = 0;

        }

        private void Viewer_Load(object sender, EventArgs e)
        {

        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            string table_name = comboBox_table.Text;

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var sql = string.Format("SELECT * from {0}", table_name);

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
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            textBox_data.AppendText(string.Format("{0}, ", reader.GetName(i).ToString()));
                        }
                        textBox_data.AppendText("\r\n");

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            // 全てのカラムを表示
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                var str_data = reader[i].ToString();
                                textBox_data.AppendText(string.Format("{0}, ", str_data?.Trim()));
                            }

                            textBox_data.AppendText("\r\n");
                        }
                    }
                }
                finally
                {
                    connection.Close();
                }


            }
        }

        private void button_updateDGV_Click(object sender, EventArgs e)
        {
            string table_name = comboBox_table.Text;

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var sql_select_data = string.Format("SELECT * from {0}", table_name);

            if (table_name == "Measurement Data")
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(" SELECT meas.sample_id ");
                sb.Append(" ,hole.expedition as exp ");
                sb.Append(" ,hole.site as site ");
                sb.Append(" ,hole.hole as hole ");
                sb.Append(" ,core.core_number as core ");
                sb.Append(" ,core.core_type ");
                sb.Append(" ,sect.section_number as section ");
                sb.Append(" ,sample.sample_depth_top as depth_top ");
                sb.Append(" ,sample.sample_depth_bottom as depth_bottom ");
                sb.Append(" ,inst.inst_name as instrument ");
                sb.Append(" ,method.method_name as parameter ");
                sb.Append(" ,meas.data_1 as data ");

                sb.Append(" FROM measurement meas ");
                sb.Append(" JOIN method method ON meas.method_id = method.method_id ");
                sb.Append(" JOIN instrument inst ON method.inst_id = inst.inst_id ");
                sb.Append(" JOIN sample sample ON meas.sample_id = sample.sample_id ");

                sb.Append(" JOIN section sect ON sample.section_id = sect.section_id ");
                sb.Append(" JOIN core core ON sect.core_id = core.core_id ");
                sb.Append(" JOIN hole hole ON core.hole_id = hole.hole_id ");
                sql_select_data = sb.ToString();

            }

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    using (var command = connection.CreateCommand())
                    {

                        command.CommandText = sql_select_data;
                        var dataAdapter = new SqlDataAdapter(command);
                        var dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridView_list.DataSource = dataTable;
                    }

                    //using (var command = new SqlCommand(sql_select_samples, connection))
                    //using (var reader = command.ExecuteReader())
                    //{


                    //    // 1行ごとに読み取る。読み取ったらtrue
                    //    while (reader.Read())
                    //    {

                    //        // 列名を指定して、読み取ったデータをコンソール上に表示
                    //        // textBox_data.AppendText(reader[0].ToString());

                    //        //var str_site = reader[0].ToString();
                    //        //comboBox_Site.Items.Add(str_site?.Trim());
                    //        ////dataGridView_SampleList.Rows.Add(reader[0].ToString(), reader[1].ToString());
                    //    }

                    //}

                }
                finally
                {
                    connection.Close();
                }


            }
        }
    }
}
