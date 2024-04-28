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
using System.Configuration;


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
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ToString());
            //con.Open();

            //SqlCommand cmd = new SqlCommand("SELECT * FROM User WHERE Email = @Email AND Password = @Password", con);

            //SqlParameter Email = new SqlParameter("@Email", EmailInput.Text);
            //SqlParameter Password = new SqlParameter("@Password", PasswordInput.Text);

            //try
            //{
            //    if (EmailInput.Text == "" && PasswordInput.Text == "")
            //    {
            //        MessageBox.Show("Alanlar boş bırakılamaz", "Başarısız giriş", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        //LOGIN VALIDATION LAZIM!!!
            //        //MessageBox.Show("Başarılı giriş");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hata: " + ex.Message);
            //}

            if (EmailInput.Text == "" || PasswordInput.Text == "")
            {
                MessageBox.Show("E-posta ve şifre alanları boş bırakılamaz!", "Başarısız Giriş", MessageBoxButtons.OK);
                return;
            }

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE Email = @Email AND Password = @Password", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", EmailInput.Text);
                        cmd.Parameters.AddWithValue("@Password", PasswordInput.Text);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());
                       

                        if (result > 0)
                        {
                            MessageBox.Show("Başarılı giriş", "Giriş Başarılı", MessageBoxButtons.OK);
                            // Giriş başarılı ise ana sayfaya yönlendirme veya başka bir işlem yap
                        }
                        else
                        {
                            MessageBox.Show("E-posta veya şifre hatalı!", "Başarısız Giriş", MessageBoxButtons.OK);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
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


        private void PasswordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }
    }
}
