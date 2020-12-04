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

namespace ToodeDB
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Tooded.mdf; Integrated Security = True");
        SqlCommand command;
        SqlDataAdapter adapter;
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();

        }

        private void DisplayData()
        {
            connect.Open();
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM ToodeTable", connect);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connect.Close();
        }

        private void ClearData()
        {
            Id = 0;
            Toodetxt.Text = "";
            Kogustxt.Text = "";
            Hindtxt.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Toodetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Kogustxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Hindtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toodedDataSet.ToodeTable' table. You can move, or remove it, as needed.
            this.toodeTableTableAdapter.Fill(this.toodedDataSet.ToodeTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Toodetxt.Text != "" && Kogustxt.Text != "" && Hindtxt.Text != "")
            {
                command = new SqlCommand("INSERT INTO ToodeTable(ToodeNimetus,Kogus,Hind) VALUES(@toode,@kogus,@hind)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", Toodetxt.Text);
                command.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                command.Parameters.AddWithValue("@hind", Hindtxt.Text);
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on lisatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Toodetxt.Text != "" && Kogustxt.Text != "" && Hindtxt.Text != "")
            {
                command = new SqlCommand("UPDATE ToodeTable SET " +
                    "ToodeNimetus=@toode,Kogus=@kogus,Hind=@hind WHERE Id=id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", Toodetxt.Text);
                command.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                command.Parameters.AddWithValue("@hind", Hindtxt.Text);
                command.Parameters.AddWithValue("@pilt", save.FileName=save);
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on uuendatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Toodetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kogustxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Hindtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Id!=0)
            {
                command = new SqlCommand("DELETE ToodeTable WHERE Id=id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", Toodetxt.Text);
                command.Parameters.AddWithValue("@kogus", Kogustxt.Text);
                command.Parameters.AddWithValue("@hind", Hindtxt.Text);
                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on kustutatud");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bpm;*.png;*.jpg)|*.jpeg;*.bpm;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = Toodetxt.Text + "_" + Id;
                save.FileName = "Image Files(*.jpeg;*.bpm;*.png;*.jpg)|*.jpeg;*.bpm;*.png;*.jpg";
                save.ShowDialog();

            }
        }
    }
}
