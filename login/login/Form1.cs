using System.Data.SqlClient;
namespace login
{
    public partial class Form1 : Form
    {
        SqlConnection con =new SqlConnection();
        SqlCommand com = new SqlCommand();   
         
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-7OFS8L5\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from users";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (textBox1.Text.Equals(dr["username"].ToString()) && textBox2.Text.Equals(dr["password"].ToString()))
                {  
                   MessageBox.Show("تسجيل الدخول بنجاح");

                }
                else
                {
                   MessageBox.Show("خطا في التسجيل");
                }



            }
            con.Close();



            
        }
    }
}