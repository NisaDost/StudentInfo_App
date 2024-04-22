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

namespace StudentInfo_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoleDropDown.Items.Add("Admin");
            RoleDropDown.Items.Add("Student / Parent");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=NISA-PC;Initial Catalog=SchoolDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            try
            {
                if (EmailInput.Text == "" && PasswordInput.Text == "")
                {
                    MessageBox.Show("Alanlar boş bırakılamaz", "Başarısız giriş", MessageBoxButtons.OK);
                }
                else
                {
                    //LOGIN VALIDATION LAZIM!!!
                    //MessageBox.Show("Başarılı giriş");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void UsernameInput_TextChanged(object sender, EventArgs e)
        {
            //HENÜZ İŞLEVSEL DEĞİL
            //bool IsValidEmail(string eMail)
            //{
            //    bool Result = false;

            //    try
            //    {
            //        var eMailValidator = new System.Net.Mail.MailAddress(eMail);

            //        Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            //    }
            //    catch
            //    {
            //        Result = false;
            //    };

            //    return Result;
            //}
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void RoleDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
