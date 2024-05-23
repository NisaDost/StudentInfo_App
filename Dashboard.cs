using StudentInfo_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo_App
{
    public partial class Dashboard : Form
    {
        #region move form borderless
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        #endregion
        private readonly Dictionary<string, Panel> buttonPanelMap = new Dictionary<string, Panel>();
        public Dashboard()
        {
            InitializeComponent();


            buttonPanelMap.Add("HomeButton", HomePanel);
            buttonPanelMap.Add("StudentsButton", StudentPanel);
            buttonPanelMap.Add("CanteenButton", CanteenPanel);
            buttonPanelMap.Add("AbscenceButton", AbscencePanel);
            buttonPanelMap.Add("StudentRegistrationBtn", StudentPanelRegistrationPanel);
            buttonPanelMap.Add("StudentListBtn", StudentListPanel);

            ShowPanel(HomePanel);

            //şimdiki zamanı labele atar
            timer1.Interval = 1000; // 1 saniye
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();
            DateAndTime.Text = DateTime.Now.ToString("F");


            #region Cityi seçince district ona göre geliyor
            var DB = new SchoolDBEntities1();
            var Cities = DB.CITies.ToList();
            var cityNames = Cities.Select(c => c.CITYNAME).ToList();
            StudentCityCB.DataSource = cityNames;

            // Event handler for city selection change
            StudentCityCB.SelectedIndexChanged += new EventHandler(StudentCityCB_SelectedIndexChanged);

            void StudentCityCB_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Get selected city name
                var selectedCityName = StudentCityCB.SelectedItem.ToString();

                var selectedCity = DB.CITies.FirstOrDefault(c => c.CITYNAME == selectedCityName);
                if (selectedCity != null)
                {
                    var districts = DB.DISTRICTs
                                      .Where(d => d.CITY_ID == selectedCity.Id)
                                      .ToList();
                    StudentDistrictCB.DataSource = districts;
                    StudentDistrictCB.DisplayMember = "DISTRICTNAME";  // Görüntülemede district ismini kullan
                    StudentDistrictCB.ValueMember = "Id";  // Değer olarak district_id'yi kullan
                }
                else
                {
                    StudentDistrictCB.DataSource = new List<DISTRICT>(); // Empty list if no city is selected
                }
            }

            // Initially populate districts based on the first city
            if (Cities.Any())
            {
                var firstCity = Cities.First();
                var initialDistricts = DB.DISTRICTs
                                         .Where(d => d.CITY_ID == firstCity.Id)
                                         .ToList();
                StudentDistrictCB.DataSource = initialDistricts;
                StudentDistrictCB.DisplayMember = "DISTRICTNAME";  // Görüntülemede district ismini kullan
                StudentDistrictCB.ValueMember = "Id";  // Değer olarak district_id'yi kullan
            }

            StudentGenderCB.Items.Clear();
            StudentGenderCB.Items.Add("Male");
            StudentGenderCB.Items.Add("Female");
            StudentGenderCB.SelectedIndex = 0;

            #endregion

            #region ComboBox class values
            var classes = DB.CLASSes.ToList();
            var className = classes.Select(c => c.class_name).ToList();
            StudentClassCB.DataSource = className;
            #endregion

            #region ComboBox class values for Student List Filtering
            var classListNames = classes.Select(c => c.class_name).ToList();
            StudentListClassCB.DataSource = classListNames;

            // Event handler for class selection change
            StudentListClassCB.SelectedIndexChanged += new EventHandler(StudentListClassCB_SelectedIndexChanged);
            #endregion

        }
        # region Student Listesini alır ve DataGridView e bağlar
        private void StudentListClassCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentListClassCB.SelectedValue != null)
            {
                // Seçilen sınıf adını alıyoruz
                var selectedClassName = StudentListClassCB.SelectedItem.ToString();

                using (var DB = new SchoolDBEntities1())
                {
                    // Seçilen sınıfın ID'sini alıyoruz
                    var selectedClass = DB.CLASSes.FirstOrDefault(c => c.class_name == selectedClassName);

                    if (selectedClass != null)
                    {
                        // Seçilen sınıf ID'sine göre öğrencileri yüklüyoruz
                        var students = (from s in DB.STUDENTs
                                        join d in DB.DISTRICTs on s.district_id equals d.Id
                                        join c in DB.CITies on d.CITY_ID equals c.Id
                                        join cl in DB.CLASSes on s.class_id equals cl.class_id
                                        join p in DB.PARENTs on s.parent_id equals p.parent_id
                                        where s.class_id == selectedClass.class_id
                                        select new
                                        {
                                            s.student_firstname,
                                            s.student_lastname,
                                            s.student_birthdate,
                                            s.student_gender,
                                            s.student_adress,
                                            s.student_balance,
                                            CityName = c.CITYNAME,
                                            DistrictName = d.DISTRICTNAME,
                                            ClassName = cl.class_name,
                                            ParentName = p.parent_fullname,
                                            ParentEmail = p.parent_email,
                                            s.student_schoolNo
                                        }).ToList();
                        StudentDataGridView.DataSource = students;
                    
                        if (StudentDataGridView.Columns.Count > 0)
                        {
                            //Başlıkların isimlerini değiştiriyorum
                            StudentDataGridView.Columns["student_firstname"].HeaderText = "Ad";
                            StudentDataGridView.Columns["student_lastname"].HeaderText = "Soyad";
                            StudentDataGridView.Columns["student_schoolNo"].HeaderText = "Okul Numarası";
                            StudentDataGridView.Columns["student_birthdate"].HeaderText = "Doğum Tarihi";
                            StudentDataGridView.Columns["student_gender"].HeaderText = "Cinsiyet";
                            StudentDataGridView.Columns["student_adress"].HeaderText = "Adres";
                            StudentDataGridView.Columns["student_balance"].HeaderText = "Bakiye";
                            StudentDataGridView.Columns["CityName"].HeaderText = "Şehir";
                            StudentDataGridView.Columns["DistrictName"].HeaderText = "İlçe";
                            StudentDataGridView.Columns["ClassName"].HeaderText = "Sınıf";
                            StudentDataGridView.Columns["ParentName"].HeaderText = "Ebeveyn Adı";
                            StudentDataGridView.Columns["ParentEmail"].HeaderText = "Ebeveyn Emaili";
                        }
                            // Öğrenci listesini DataGridView'a bağlıyoruz
                            StudentDataGridView.DataSource = students;
                    }
                }
            }
        }
        #endregion

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateAndTime.Text = DateTime.Now.ToString("F");
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && buttonPanelMap.ContainsKey(clickedButton.Name))
            {
                string buttonName = clickedButton.Name;
                ShowPanel(buttonPanelMap[buttonName]);
            }
        }
        private void ShowPanel(Panel panelToShow)
        {
            foreach (Panel panel in buttonPanelMap.Values)
            {
                panel.Visible = false;
            }
            panelToShow.Visible = true;

        }


        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                return;
            }
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveStudentBtn_Click(object sender, EventArgs e)
        {
            #region Student Kaydetme
            var DB = new SchoolDBEntities1();
            // Yeni parent nesnesini oluştur
            var parent = new PARENT
            {
                parent_fullname = ParentNameTB.Text,
                parent_phone = ParentPhoneTB.Text,
                parent_email = ParentEmailTB.Text
            };

            // Parent nesnesini veritabanına ekle ve kaydet
            DB.PARENTs.Add(parent);
            DB.SaveChanges();

            // Kaydedilen parent nesnesini tekrar çek
            var savedParent = DB.PARENTs.FirstOrDefault(p => p.parent_email == parent.parent_email);

            // Okul numarasını kontrol et
            int schoolNumber;
            if (!int.TryParse(StudentSchoolNumberTB.Text, out schoolNumber))
            {
                //Sadece integer türünde nesne alır
                MessageBox.Show("Geçersiz okul numarası. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingStudent = DB.STUDENTs.FirstOrDefault(s => s.student_schoolNo == schoolNumber);

            if (existingStudent != null)
            {
                // Aynı okul numarasına sahip bir öğrenci mevcut, hata mesajı göster
                MessageBox.Show("Bu okul numarasına sahip bir öğrenci zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedDistrict = (DISTRICT)StudentDistrictCB.SelectedItem;

            // Yeni student nesnesini oluştur
            var student = new STUDENT
            {
                student_firstname = StudentFirstNameTB.Text,
                student_lastname = StudentLastNameTB.Text,
                student_adress = StudentAdressTB.Text,
                student_birthdate = StudentBirthdayDTP.Value,
                student_gender = StudentGenderCB.Text,
                district_id = selectedDistrict.Id,
                student_schoolNo = schoolNumber,
                parent_id = savedParent.parent_id, // Parent ID'sini foreign key olarak ekle
                class_id = (StudentClassCB.SelectedIndex + 1)
            };

            // Student nesnesini veritabanına ekle ve kaydet
            DB.STUDENTs.Add(student);
            DB.SaveChanges();

            // Kaydedilen student nesnesini tekrar çek
            var savedStudent = DB.STUDENTs.FirstOrDefault(s => s.student_firstname == student.student_firstname && s.student_lastname == student.student_lastname);

            // Parent nesnesini güncelle ve student ID'sini foreign key olarak ekle
            if (savedStudent != null)
            {
                savedParent.student_id = savedStudent.student_id; // Eğer PARENT tablosunda student_id foreign key olarak tanımlandıysa
                DB.SaveChanges();
            }


            MessageBox.Show("Öğrenci başarıyla kaydedildi.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ParentNameTB.Clear();
            ParentPhoneTB.Clear();
            ParentEmailTB.Clear();
            StudentFirstNameTB.Clear();
            StudentLastNameTB.Clear();
            StudentAdressTB.Clear();
            StudentSchoolNumberTB.Clear();
            StudentClassCB.SelectedIndex = 0;
            StudentBirthdayDTP.Value = DateTime.Now;
            StudentGenderCB.SelectedIndex = 0;
            StudentCityCB.SelectedIndex = 0;
            if (StudentDistrictCB.Items.Count > 0)
            {
                StudentDistrictCB.SelectedIndex = 0;
            }
            #endregion
        }

    }
}
