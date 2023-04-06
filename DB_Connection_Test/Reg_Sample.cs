using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Connection_Test
{
    public partial class Reg_Sample : Form
    {
        public Reg_Sample()
        {
            InitializeComponent();
            init_Combobox_expedition();

        }

        private void init_Combobox_expedition()
        {

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT expedition ");
            sb.Append(" FROM expedition ");
            var sql_select_expedition = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {
                    using (var command = new SqlCommand(sql_select_expedition, connection))
                    using (var reader = command.ExecuteReader())
                    {

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {
                            comboBox_Exp.Items.Add(reader.GetString(0)?.Trim());
                        }
                    }
                }
                finally
                {
                    connection.Close();
                }


            }

        }






        private void button_Go_Click(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;
            string core = comboBox_Core.Text;
            string section = comboBox_Section.Text;
            string int_top = textBox_Interval_Top.Text;
            string int_bottom = textBox_Interval_Bottom.Text;
            
            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            StringBuilder sb= new StringBuilder();
            
            sb.Append(" INSERT INTO ");
            sb.Append(" sample ([section_id], [sample_depth_top], [sample_depth_bottom]) ");
            sb.Append(string.Format(" SELECT section_id, '{0}' , '{1}' ", int_top, int_bottom));
            sb.Append(" FROM section ");
            sb.Append(string.Format(" WHERE section_number = '{0}' ", section));
            sb.Append(" AND core_id =( ");
            sb.Append(" SELECT core_id FROM core ");
            sb.Append(string.Format(" WHERE core_number = '{0}' AND hole_id= ( ", core));
            sb.Append(" SELECT hole_id FROM hole ");
            sb.Append(string.Format("  WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}' ))", exp, site, hole));
            sb.Append(" ; ");
            sb.Append(" SELECT CAST(SCOPE_IDENTITY() AS INT) AS [SCOPE_IDENTITY] ");
            var sql_insert_sample = sb.ToString();


            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    using (var command = new SqlCommand(sql_insert_sample, connection))
                    {
                        int sampleID_new = (int)command.ExecuteScalar();
                        textBox_SampleID.Text = sampleID_new.ToString();
                        toolStripStatusLabel1.Text=" Registered: new sample";
                    }

                }
                finally
                {
                    connection.Close();
                }


            }
        }

        private void comboBox_Exp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            
            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT DISTINCT site ");
            sb.Append(" FROM hole ");
            sb.Append(string.Format("WHERE expedition = '{0}' ", exp));
            var sql_select_site = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {
                    
                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_site, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_Site.Items.Clear();
                        comboBox_Site.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_site = reader[0].ToString();
                            comboBox_Site.Items.Add(str_site?.Trim());

                        }

                    }
                }
                finally
                {
                    connection.Close();
                }


            }
        }

        private void comboBox_Site_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string site = comboBox_Site.Text;


            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT DISTINCT hole ");
            sb.Append(" FROM hole ");
            sb.Append(string.Format("WHERE expedition = '{0}' AND site = '{1}' ", exp, site));
            var sql_select_site = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_site, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_Hole.Items.Clear();
                        comboBox_Hole.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_hole = reader[0].ToString();
                            comboBox_Hole.Items.Add(str_hole?.Trim());

                        }

                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void comboBox_Hole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;


            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT DISTINCT core_number ");
            sb.Append(" FROM core ");
            sb.Append(" WHERE hole_id = ( ");
            sb.Append(string.Format(" SELECT hole_id from hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}') ", exp, site, hole));
            var sql_select_core = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_core, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_Core.Items.Clear();
                        comboBox_Core.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_core = reader[0].ToString();
                            comboBox_Core.Items.Add(str_core?.Trim());

                        }

                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void comboBox_Core_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;
            string core = comboBox_Core.Text;


            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT core_type ");
            sb.Append(" FROM core ");
            sb.Append(string.Format(" WHERE core_number = '{0}' ", core));
            sb.Append(" AND hole_id = ( ");
            sb.Append(string.Format(" SELECT hole_id from hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}') ", exp, site, hole));
            var sql_select_core_type = sb.ToString();


            sb.Clear();
            sb.Append(" SELECT DISTINCT section_number ");
            sb.Append(" FROM section ");
            sb.Append(" WHERE core_id = ( ");
            sb.Append(string.Format(" SELECT core_id from core WHERE core_number = '{0}' ", core));
            sb.Append(" AND hole_id = ( ");
            sb.Append(string.Format(" SELECT hole_id from hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}')) ", exp, site, hole));
            var sql_select_section = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_core_type, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_CoreType.Items.Clear();
                        comboBox_CoreType.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_core_type = reader[0].ToString();
                            comboBox_CoreType.Items.Add(str_core_type?.Trim());


                        }

                        comboBox_CoreType.SelectedIndex = 0;
                    }


                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_section, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_Section.Items.Clear();
                        comboBox_Section.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_section = reader[0].ToString();
                            comboBox_Section.Items.Add(str_section?.Trim());

                        }

                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void comboBox_Section_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;
            string core = comboBox_Core.Text;
            string section = comboBox_Section.Text;


            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT section_id ");
            sb.Append(" FROM section ");
            sb.Append(string.Format(" WHERE section_number = '{0}' ", section));
            sb.Append(" AND core_id = ( ");
            sb.Append(string.Format(" SELECT core_id from core WHERE core_number = '{0}' ", core));
            sb.Append(" AND hole_id = ( ");
            sb.Append(string.Format(" SELECT hole_id from hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}')) ", exp, site, hole));
            var sql_select_section_id = sb.ToString();


            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_section_id, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_SectionID.Items.Clear();
                        comboBox_SectionID.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_curated_length = reader[0].ToString();
                            comboBox_SectionID.Items.Add(str_curated_length?.Trim());

                        }

                        comboBox_SectionID.SelectedIndex = 0;
                    }


                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void comboBox_SectionID_TextChanged(object sender, EventArgs e)
        {
            
            string section_id = comboBox_SectionID.Text;


            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT h.expedition, h.site, h.hole, c.core_number, c.core_type, s.section_number ");
            sb.Append(" FROM section s ");
            sb.Append(" JOIN core c ON s.core_id = c.core_id ");
            sb.Append(" JOIN hole h ON c.hole_id = h.hole_id ");
            sb.Append(string.Format(" WHERE s.section_id = '{0}' ", section_id));
            var sql_select_section_id = sb.ToString();


            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_section_id, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_Site.Items.Clear();
                        comboBox_Hole.Items.Clear();
                        comboBox_Core.Items.Clear();
                        comboBox_CoreType.Items.Clear();
                        comboBox_Section.Items.Clear();

                        comboBox_Exp.Text = "";
                        comboBox_Site.Text = "";
                        comboBox_Hole.Text = "";
                        comboBox_Core.Text = "";
                        comboBox_CoreType.Text = "";
                        comboBox_Section.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_exp = reader[0].ToString();
                            var str_site = reader[1].ToString();
                            var str_hole = reader[2].ToString();
                            var str_core = reader[3].ToString();
                            var str_core_type = reader[4].ToString();
                            var str_section = reader[5].ToString();

                            comboBox_Exp.Text = (str_exp?.Trim());
                            comboBox_Site.Text = (str_site?.Trim());
                            comboBox_Hole.Text = (str_hole?.Trim());
                            comboBox_Core.Text = (str_core?.Trim());
                            comboBox_CoreType.Text = (str_core_type?.Trim());
                            comboBox_Section.Text=(str_section?.Trim());

                        }

                    }


                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void update_DataGridView(object sender, EventArgs e) 
        {
            string exp = comboBox_Exp.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;
            string core = comboBox_Core.Text;
            string section = comboBox_Section.Text;
            

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT smpl.sample_id, hole.expedition, hole.site, hole.hole, core.core_number, core.core_type, sect.section_id, smpl.sample_depth_top, smpl.sample_depth_bottom ");
            sb.Append(" FROM sample smpl ");
            sb.Append(" JOIN section sect ON smpl.section_id = sect.section_id ");
            sb.Append(" JOIN core core ON sect.core_id = core.core_id ");
            sb.Append(" JOIN hole hole ON core.hole_id = hole.hole_id ");
            sb.Append(string.Format(" WHERE hole.expedition = '{0}' ", exp));
            
            if (site != "")
            {
                sb.Append(string.Format(" AND hole.site = '{0}' ", site));
            }
            
            if (hole != "")
            {
                sb.Append(string.Format(" AND hole.hole = '{0}' ", hole));
            }
            
            if (core != "")
            {
                sb.Append(string.Format(" AND core.core_number = '{0}' ", core));
            }
            
            if (section != "")
            {
                sb.Append(string.Format(" AND sect.section_number = '{0}' ", section));
            }
            
            
            var sql_select_samples = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    using (var command = connection.CreateCommand()) 
                    {
                    
                        command.CommandText = sql_select_samples;
                        var dataAdapter = new SqlDataAdapter(command);
                        var dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
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
