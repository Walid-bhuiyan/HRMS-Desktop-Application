using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HRProfile : Form
    {
        private int hrId;

        private string conStr =
            @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";

        public HRProfile(int id)
        {
            InitializeComponent();
            hrId = id;
            this.Load += HRProfile_Load;
        }

        private void HRProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            



            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string query = @"
                        SELECT hrId, Name, Email, Phone, Gender, Address, DOB
                        FROM HRManagers
                        WHERE hrId = @id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", hrId);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtID.Text = dr["hrId"].ToString();
                        txtName.Text = dr["Name"].ToString();
                        txtEmail.Text = dr["Email"].ToString();
                        txtPhone.Text = dr["Phone"].ToString();
                        txtGender.Text = dr["Gender"].ToString();
                        txtAddress.Text = dr["Address"].ToString();
                        txtDob.Text = Convert.ToDateTime(dr["DOB"]).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        MessageBox.Show("HR profile not found in HRManagers table!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile load error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
