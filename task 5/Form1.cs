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

namespace task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into values(id,name,age)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Inserted Successfully");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            SqlCommand cmd = new SqlCommand("update ut set name=@name, age=@age where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record updated Successfully");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete ut where id=@id", con);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record deleted Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ut", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
