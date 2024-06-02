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
using OfficeOpenXml;
using System.IO;
//using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Data.Entity.Validation;
using System.Net.Mail;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

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
            //update için
            LoadCities();
            // Şehir ComboBox'ında seçim değiştiğinde ilçeleri yükle
            UpdateStudentCityCB.SelectedIndexChanged += new EventHandler(UpdateStudentCityCB_SelectedIndexChanged);
            LoadClassNames();
            LoadUpdateClassNames();
            LoadDeleteClassNames();
            TeacherAddLoadBranches();
            TeacherAddLoadTeachers();
            TeacherAddLoadClasses();
            SelectTeacherCB.SelectedIndexChanged += SelectTeacherCB_SelectedIndexChanged;
            UpdateTeacherLoadBranchesAndClasses();
            SelectUpdateTeacherCB.SelectedIndexChanged += new System.EventHandler(this.UpdateSelectTeacherCB_SelectedIndexChanged);
            TeacherListLoadAllClasses();
            TeacherDeleteLoadTeachers();
            LoadCategories();

            buttonPanelMap.Add("HomeButton", HomePanel);
            buttonPanelMap.Add("StudentsButton", StudentPanel);
            buttonPanelMap.Add("CanteenButton", CanteenPanel);
            buttonPanelMap.Add("AbscenceButton", AbscencePanel);
            buttonPanelMap.Add("StudentRegistrationBtn", StudentPanelRegistrationPanel);
            buttonPanelMap.Add("StudentListBtn", StudentListPanel);
            buttonPanelMap.Add("StudentDeleteBtn", StudentDeletePanel);
            buttonPanelMap.Add("StudentAbsenceAttandanceBtn", AbscenceInfoPanel);
            buttonPanelMap.Add("StudentEntryAttandanceBtn", StudentAttandanceEntryPanel);
            buttonPanelMap.Add("TeacherButoon", TeacherPanel);
            buttonPanelMap.Add("TeacherAddBtn", TeacheAddPnl);
            buttonPanelMap.Add("StudentUpdatebtn", StudentUpdatePanel);
            buttonPanelMap.Add("ClassButon", ClassPanel);
            buttonPanelMap.Add("AddClassBtn", AddClassPnl);
            buttonPanelMap.Add("UpdateClassBtn", UpdateClassPnl);
            buttonPanelMap.Add("ListClassBtn", ListClassPnl);
            buttonPanelMap.Add("DeleteClassBtn", DeleteClassPnl);
            buttonPanelMap.Add("DefineAClassTeacherBtn", AssignTeacherToClassPnl);
            buttonPanelMap.Add("UpdateTeacherBtn", UpdateTeacherPnl);
            buttonPanelMap.Add("ListTeacherBtn", ListTeacherPnl);
            buttonPanelMap.Add("TeacherDeleteBtn", DeleteTeacherPnl);
            buttonPanelMap.Add("StudentCanteenButton", StudentCanteenPnl);
            buttonPanelMap.Add("ListProductBtn", ListProductPnl);


            //buttonPanelMap.Add("TeacherDeleteBtn", TeacherDeletePnl);

            ShowPanel(HomePanel);

            //şimdiki zamanı labele atar
            timer1.Interval = 1000; // 1 saniye
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();
            DateAndTime.Text = DateTime.Now.ToString("F");


            #region Cityi seçince district ona göre geliyor
            var DB = new NewSchoolDBEntities();
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
            UpdateStudentGenderCB.Items.Add("Male");
            UpdateStudentGenderCB.Items.Add("Female");


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

        private void StudentListClassCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            # region Student Listesini alır ve DataGridView e bağlar
            if (StudentListClassCB.SelectedValue != null)
            {
                // Seçilen sınıf adını alıyoruz
                var selectedClassName = StudentListClassCB.SelectedItem.ToString();

                using (var DB = new NewSchoolDBEntities())
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
            #endregion
        }

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
            try
            {
                // Girdi kontrolleri
                if (string.IsNullOrWhiteSpace(ParentNameTB.Text) || ParentNameTB.Text.Length > 30)
                {
                    MessageBox.Show("Parent ismi zorunludur ve en fazla 30 karakter olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(ParentPhoneTB.Text) || !ParentPhoneTB.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Geçersiz telefon numarası. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(ParentEmailTB.Text) || !IsValidEmail(ParentEmailTB.Text))
                {
                    MessageBox.Show("Geçersiz email adresi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(StudentFirstNameTB.Text) || StudentFirstNameTB.Text.Length > 30)
                {
                    MessageBox.Show("Öğrenci ismi zorunludur ve en fazla 30 karakter olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(StudentLastNameTB.Text) || StudentLastNameTB.Text.Length > 30)
                {
                    MessageBox.Show("Öğrenci soyismi zorunludur ve en fazla 30 karakter olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(StudentAdressTB.Text))
                {
                    MessageBox.Show("Adres zorunludur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (StudentGenderCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Cinsiyet seçimi zorunludur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (StudentCityCB.SelectedIndex == -1)
                {
                    MessageBox.Show("Şehir seçimi zorunludur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (StudentDistrictCB.SelectedIndex == -1)
                {
                    MessageBox.Show("İlçe seçimi zorunludur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Okul numarasını kontrol et
                if (!int.TryParse(StudentSchoolNumberTB.Text, out int schoolNumber))
                {
                    MessageBox.Show("Geçersiz okul numarası. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var DB = new NewSchoolDBEntities();

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
                    parent_id = savedParent.parent_id,
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
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine("Entity: {0} Property: {1} Error: {2}",
                            validationErrors.Entry.Entity.GetType().Name,
                            validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }
                MessageBox.Show("Veri doğrulama hatası oluştu. Lütfen girdiğiniz bilgileri kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        // Email doğrulama metodunu ekleyin
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private STUDENT currentStudent;
        private void SearchStudentButton_Click(object sender, EventArgs e)
        {
            #region Öğrenci arama 
            var DB = new NewSchoolDBEntities();
            int studentNumber;
            if (int.TryParse(StudentNumberTextBox.Text, out studentNumber))
            {
                currentStudent = DB.STUDENTs.FirstOrDefault(s => s.student_schoolNo == studentNumber);
                if (currentStudent != null)
                {
                    string birthdate = currentStudent.student_birthdate.HasValue ? currentStudent.student_birthdate.Value.ToShortDateString() : "Bilinmiyor";
                    StudentInfoLabel2.Text = $"Adı Soyadı: {currentStudent.student_firstname} {currentStudent.student_lastname}\n" +
                                            $"Doğum Tarihi: {birthdate}\n" +
                                            $"Sınıf: {DB.CLASSes.FirstOrDefault(cl => cl.class_id == currentStudent.class_id)?.class_name}";
                    DeleteStudentButton.Enabled = true; // Silme butonunu etkinleştir
                }
                else
                {
                    StudentInfoLabel2.Text = "Öğrenci bulunamadı.";
                    DeleteStudentButton.Enabled = false; // Silme butonunu devre dışı bırak
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir öğrenci numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

        }
        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            #region Öğrenci silme
            // biz parent ı student a student ı parent relation kurduğumuz için önce parent ı silmemiz gerekiyor.
            if (currentStudent != null)
            {
                using (var DB = new NewSchoolDBEntities())
                {
                    // Öğrenci kaydını bul
                    var studentToDelete = DB.STUDENTs.FirstOrDefault(s => s.student_id == currentStudent.student_id);

                    if (studentToDelete != null)
                    {
                        // Önce ilgili ATTENDANCE kayıtlarını sil veya güncelle
                        var attendanceRecordsToUpdate = DB.ATTENDANCEs.Where(a => a.student_id == studentToDelete.student_id).ToList();
                        foreach (var record in attendanceRecordsToUpdate)
                        {
                            // Ya silme
                            // DB.ATTENDANCEs.Remove(record);

                            // Ya da null yapma
                            record.student_id = null;
                        }

                        // Önce ilgili ACCESS_LOG kayıtlarını sil veya güncelle
                        var accessLogRecordsToUpdate = DB.ACCESS_LOG.Where(a => a.student_id == studentToDelete.student_id).ToList();
                        foreach (var record in accessLogRecordsToUpdate)
                        {
                            // Ya silme
                            // DB.ACCESS_LOGs.Remove(record);

                            // Ya da null yapma
                            record.student_id = null;
                        }

                        // Önce ilgili parent kayıtlarının student_id alanını null yap
                        var parentsToUpdate = DB.PARENTs.Where(p => p.student_id == studentToDelete.student_id).ToList();
                        foreach (var parent in parentsToUpdate)
                        {
                            parent.student_id = null;
                        }

                        // Değişiklikleri kaydet
                        DB.SaveChanges();

                        // Şimdi öğrenci kaydını sil
                        DB.STUDENTs.Remove(studentToDelete);
                        DB.SaveChanges();

                        MessageBox.Show("Öğrenci ve ilgili parent kayıtları başarıyla silindi.", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // UI elemanlarını sıfırla
                        StudentNumberTextBox.Clear();
                        StudentInfoLabel2.Text = "";
                        DeleteStudentButton.Enabled = false;
                        currentStudent = null;
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Öğrenci silinemedi. Lütfen önce arama yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        #region Öğrenci Absence ve Attandance Gösterilme paneli
        private void FetchStudentButton_Click(object sender, EventArgs e)
        {
            #region öğrenci arama
            int studentNumber;
            if (int.TryParse(StudentNumber2TextBox.Text, out studentNumber))
            {
                using (var DB = new NewSchoolDBEntities())
                {
                    var student = DB.STUDENTs.FirstOrDefault(s => s.student_schoolNo == studentNumber);

                    if (student != null)
                    {
                        StudentInfo2Label.Text = $"Adı: {student.student_firstname} {student.student_lastname}\n" +
                                                $"Doğum Tarihi: {student.student_birthdate?.ToShortDateString() ?? "Bilinmiyor"}\n" +
                                                $"Sınıf: {DB.CLASSes.FirstOrDefault(cl => cl.class_id == student.class_id)?.class_name}";

                        var attendances = DB.ATTENDANCEs.Where(a => a.student_id == student.student_id)
                                                        .Select(a => new { a.date })
                                                        .ToList();
                        AttendanceDataGridView.DataSource = attendances;
                        //10 un üzerinde ise attandance si message box ile bildiri veriyor.
                        int attandancelimit = 10;
                        if (attendances.Count >= attandancelimit)
                        {
                            MessageBox.Show($"Öğrenci {attandancelimit} gün devamsızlık yapmıştır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        var accessLogs = DB.ACCESS_LOG.Where(al => al.student_id == student.student_id)
                                                      .Select(al => new { al.entry_time, al.exit_time })
                                                      .ToList();
                        AccessLogDataGridView.DataSource = accessLogs;
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StudentInfo2Label.Text = "";
                        AttendanceDataGridView.DataSource = null;
                        AccessLogDataGridView.DataSource = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçersiz öğrenci numarası. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion 
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            #region Tarih Filtreleme
            int studentNumber;
            if (int.TryParse(StudentNumber2TextBox.Text, out studentNumber))
            {
                using (var DB = new NewSchoolDBEntities())
                {
                    var student = DB.STUDENTs.FirstOrDefault(s => s.student_schoolNo == studentNumber);

                    if (student != null)
                    {
                        DateTime startDate = StartDatePicker.Value;
                        DateTime endDate = EndDatePicker.Value;

                        // Devamsızlık kayıtlarını al
                        var attendances = DB.ATTENDANCEs
                            .Where(a => a.student_id == student.student_id && a.date >= startDate && a.date <= endDate)
                            .Select(a => new { Tarih = a.date, Durum = "Yok" }) // Devamsızlık varsa "Yok" yaz
                            .ToList();
                        AttendanceDataGridView.DataSource = attendances;

                        // Access Log kayıtlarını al
                        var accessLogs = DB.ACCESS_LOG
                            .Where(al => al.student_id == student.student_id && al.entry_time >= startDate && al.entry_time <= endDate)
                            .Select(al => new { Giriş = al.entry_time, Çıkış = al.exit_time })
                            .ToList();
                        AccessLogDataGridView.DataSource = accessLogs;

                        // Öğrenci bilgisini göster
                        StudentInfoLabel.Text = $"Öğrenci Adı: {student.student_firstname} {student.student_lastname}\n" +
                                                $"Okul Numarası: {student.student_schoolNo}";

                        // Veri tablolarının başlıklarını güncelle
                        AttendanceDataGridView.Columns[0].HeaderText = "Date";
                        AttendanceDataGridView.Columns[1].HeaderText = "Status";
                        AccessLogDataGridView.Columns[0].HeaderText = "Entry";
                        AccessLogDataGridView.Columns[1].HeaderText = "Exit";
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StudentInfoLabel.Text = "";
                        AttendanceDataGridView.DataSource = null;
                        AccessLogDataGridView.DataSource = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçersiz öğrenci numarası. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            #region Excel dosyasına döküyor
            var attendanceData = AttendanceDataGridView.DataSource as List<dynamic>;
            var accessLogData = AccessLogDataGridView.DataSource as List<dynamic>;

            if (attendanceData != null && accessLogData != null)
            {
                if (attendanceData.Count > 0 && accessLogData.Count > 0)
                {
                    using (var package = new ExcelPackage())
                    {
                        // Create Attendance sheet
                        var attendanceSheet = package.Workbook.Worksheets.Add("Attendance");
                        attendanceSheet.Cells[1, 1].Value = "Date";

                        for (int i = 0; i < attendanceData.Count; i++)
                        {
                            attendanceSheet.Cells[i + 2, 1].Value = attendanceData[i].date;
                        }

                        // Create Access Log sheet
                        var accessLogSheet = package.Workbook.Worksheets.Add("Access Log");
                        accessLogSheet.Cells[1, 1].Value = "Entry Time";
                        accessLogSheet.Cells[1, 2].Value = "Exit Time";

                        for (int i = 0; i < accessLogData.Count; i++)
                        {
                            accessLogSheet.Cells[i + 2, 1].Value = accessLogData[i].entry_time;
                            accessLogSheet.Cells[i + 2, 2].Value = accessLogData[i].exit_time;
                        }

                        // Save the file
                        var saveFileDialog = new SaveFileDialog
                        {
                            Filter = "Excel files (*.xlsx)|*.xlsx",
                            FileName = "Export.xlsx"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            package.SaveAs(fileInfo);
                            MessageBox.Show("Data has been successfully exported to Excel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No data to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

        }
        #endregion

        #region Devamsızlık ekleme paneli
        private void StudentSearchBtn_Click(object sender, EventArgs e)
        {
            #region Öğrenci arama
            int studentNumber;
            if (int.TryParse(StudentNumber3TB.Text, out studentNumber))
            {
                using (var DB = new NewSchoolDBEntities())
                {
                    var student = DB.STUDENTs.FirstOrDefault(s => s.student_schoolNo == studentNumber);

                    if (student != null)
                    {
                        StudentInfo3Label.Text = $"Adı: {student.student_firstname} {student.student_lastname}\n" +
                                                $"Doğum Tarihi: {student.student_birthdate?.ToShortDateString() ?? "Bilinmiyor"}\n" +
                                                $"Sınıf: {DB.CLASSes.FirstOrDefault(cl => cl.class_id == student.class_id)?.class_name}";

                        var attendances = DB.ATTENDANCEs.Where(a => a.student_id == student.student_id)
                                                        .Select(a => new { a.date })
                                                        .ToList();
                        AttendanceDataGridView.DataSource = attendances;
                        //10 un üzerinde ise attandance si message box ile bildiri veriyor.
                        int attandancelimit = 10;
                        if (attendances.Count >= attandancelimit)
                        {
                            MessageBox.Show($"Öğrenci {attandancelimit} gün devamsızlık yapmıştır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        var accessLogs = DB.ACCESS_LOG.Where(al => al.student_id == student.student_id)
                                                      .Select(al => new { al.entry_time, al.exit_time })
                                                      .ToList();
                        AccessLogDataGridView.DataSource = accessLogs;
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StudentInfo3Label.Text = "";
                        AttendanceDataGridView.DataSource = null;
                        AccessLogDataGridView.DataSource = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçersiz öğrenci numarası. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void AddAttendanceButton_Click(object sender, EventArgs e)
        {
            #region Öğrenci Devamsızlık ekleme
            int studentNumber;
            if (int.TryParse(StudentNumber3TB.Text, out studentNumber))
            {
                using (var DB = new NewSchoolDBEntities())
                {
                    var student = DB.STUDENTs.FirstOrDefault(s => s.student_schoolNo == studentNumber);

                    if (student != null)
                    {
                        DateTime selectedDate = AttendanceDatePicker.Value.Date;

                        // Daha önce aynı tarihte kayıt olup olmadığını kontrol et
                        var existingAttendance = DB.ATTENDANCEs
                                                   .FirstOrDefault(a => a.student_id == student.student_id && a.date == selectedDate);

                        if (existingAttendance == null)
                        {
                            // Yeni devamsızlık kaydı ekle
                            var newAttendance = new ATTENDANCE
                            {
                                student_id = student.student_id,
                                date = selectedDate
                            };

                            DB.ATTENDANCEs.Add(newAttendance);
                            DB.SaveChanges();

                            MessageBox.Show("Devamsızlık kaydı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Bu tarihte zaten devamsızlık kaydı var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçersiz öğrenci numarası. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
        #endregion

        #region Öğrenci update
        // City (şehir) verilerini yükleme
        private void LoadCities()
        {
            var DB = new NewSchoolDBEntities();
            var cities = DB.CITies.ToList();

            // ComboBox'a şehirleri yükleme
            UpdateStudentCityCB.DataSource = cities;
            UpdateStudentCityCB.DisplayMember = "CITYNAME";
            UpdateStudentCityCB.ValueMember = "Id"; // Her bir şehrin Id'sini değer olarak kullan
        }

        // Seçilen şehre göre ilçeleri yükleme
        private void LoadDistrictsByCity(int selectedCityId)
        {
            var DB = new NewSchoolDBEntities();
            var districts = DB.DISTRICTs.Where(d => d.CITY_ID == selectedCityId).ToList();

            // ComboBox'a ilçeleri yükleme
            UpdateStudentDistrictCB.DataSource = districts;
            UpdateStudentDistrictCB.DisplayMember = "DISTRICTNAME";
            UpdateStudentDistrictCB.ValueMember = "Id"; // Her bir ilçenin Id'sini değer olarak kullan
        }

        // Şehir seçimi değiştiğinde ilçeleri yükleme
        private void UpdateStudentCityCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen şehrin Id'sini al
            if (UpdateStudentCityCB.SelectedValue is int selectedCityId)
            {
                LoadDistrictsByCity(selectedCityId);
            }
        }


        private void GetStudentInfoBtn_Click(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            var DB = new NewSchoolDBEntities();

            if (!int.TryParse(UpdateStudentSchoolNumberTB.Text, out int schoolNumber))
            {
                MessageBox.Show("Geçersiz okul numarası. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var student = DB.STUDENTs.FirstOrDefault(s => s.student_schoolNo == schoolNumber);
            if (student != null)
            {
                UpdateStudentFirstNameTB.Text = student.student_firstname;
                UpdateStudentLastNameTB.Text = student.student_lastname;
                UpdateStudentAddressTB.Text = student.student_adress;
                UpdateStudentNumberTB.Text = student.student_schoolNo.ToString();
                UpdateStudentBirthdayDTP.Value = student.student_birthdate ?? DateTime.Now;
                UpdateStudentGenderCB.Text = student.student_gender;

                var parent = DB.PARENTs.FirstOrDefault(p => p.parent_id == student.parent_id);
                if (parent != null)
                {
                    UpdateParentNameTB.Text = parent.parent_fullname;
                    UpdateParentPhoneTB.Text = parent.parent_phone;
                    UpdateParentEmailTB.Text = parent.parent_email;
                }

                // İl ve ilçe bilgilerini combobox'lara doldur
                var district = DB.DISTRICTs.FirstOrDefault(d => d.Id == student.district_id);
                if (district != null)
                {
                    var city = DB.CITies.FirstOrDefault(c => c.Id == district.CITY_ID);
                    if (city != null)
                    {
                        // Şehir bilgisini güncelle
                        UpdateStudentCityCB.DataSource = DB.CITies.ToList();
                        UpdateStudentCityCB.DisplayMember = "CITYNAME";
                        UpdateStudentCityCB.ValueMember = "Id";
                        UpdateStudentCityCB.SelectedValue = city.Id;

                        // İlçe bilgilerini güncelle
                        var districts = DB.DISTRICTs.Where(d => d.CITY_ID == city.Id).ToList();
                        UpdateStudentDistrictCB.DataSource = districts;
                        UpdateStudentDistrictCB.DisplayMember = "DISTRICTNAME";
                        UpdateStudentDistrictCB.ValueMember = "Id";
                        UpdateStudentDistrictCB.SelectedValue = district.Id;
                    }
                }

                // Sınıf bilgilerini combobox'a doldur
                var classes = DB.CLASSes.ToList();
                UpdateStudentClassCB.DataSource = classes;
                UpdateStudentClassCB.DisplayMember = "class_name";
                UpdateStudentClassCB.ValueMember = "class_id";
                UpdateStudentClassCB.SelectedValue = student.class_id;
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateStudentBtn_Click(object sender, EventArgs e)
        {
            var DB = new NewSchoolDBEntities();
            // Girdi kontrolleri
            if (!ValidateInputs())
            {
                // Eğer girdi kontrollerinden herhangi biri başarısız olursa işlemi durdur
                return;
            }

            if (!int.TryParse(UpdateStudentSchoolNumberTB.Text, out int schoolNumber))
            {
                MessageBox.Show("Geçersiz okul numarası. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var student = DB.STUDENTs.FirstOrDefault(s => s.student_schoolNo == schoolNumber);
            if (student != null)
            {
                // Öğrenci bilgilerini güncelle
                student.student_firstname = UpdateStudentFirstNameTB.Text;
                student.student_lastname = UpdateStudentLastNameTB.Text;
                student.student_adress = UpdateStudentAddressTB.Text;
                student.student_birthdate = UpdateStudentBirthdayDTP.Value;
                student.student_gender = UpdateStudentGenderCB.Text;
                student.student_schoolNo = int.Parse(UpdateStudentNumberTB.Text); // Öğrenci numarasını güncelle

                // Ebeveyn bilgilerini güncelle
                var parent = DB.PARENTs.FirstOrDefault(p => p.parent_id == student.parent_id);
                if (parent != null)
                {
                    parent.parent_fullname = UpdateParentNameTB.Text;
                    parent.parent_phone = UpdateParentPhoneTB.Text;
                    parent.parent_email = UpdateParentEmailTB.Text;
                }

                // Şehir ve ilçe bilgilerini güncelle
                if (UpdateStudentDistrictCB.SelectedValue != null)
                {
                    student.district_id = (int)UpdateStudentDistrictCB.SelectedValue;
                }

                // Sınıf bilgisini güncelle
                if (UpdateStudentClassCB.SelectedValue != null)
                {
                    student.class_id = (int)UpdateStudentClassCB.SelectedValue;
                }

                // Değişiklikleri veritabanına kaydet
                DB.SaveChanges();
                MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateInputs()
        {
            // Parent ismi kontrolü
            if (string.IsNullOrWhiteSpace(UpdateParentNameTB.Text) || UpdateParentNameTB.Text.Length > 30)
            {
                MessageBox.Show("Parent ismi zorunludur ve en fazla 30 karakter olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Parent telefon numarası kontrolü
            if (string.IsNullOrWhiteSpace(UpdateParentPhoneTB.Text) || !UpdateParentPhoneTB.Text.All(char.IsDigit))
            {
                MessageBox.Show("Geçersiz telefon numarası. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Parent email kontrolü
            if (string.IsNullOrWhiteSpace(UpdateParentEmailTB.Text) || !IsValidEmail(UpdateParentEmailTB.Text))
            {
                MessageBox.Show("Geçersiz email adresi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Öğrenci ismi kontrolü
            if (string.IsNullOrWhiteSpace(UpdateStudentFirstNameTB.Text) || UpdateStudentFirstNameTB.Text.Length > 30)
            {
                MessageBox.Show("Öğrenci ismi zorunludur ve en fazla 30 karakter olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Öğrenci soyismi kontrolü
            if (string.IsNullOrWhiteSpace(UpdateStudentLastNameTB.Text) || UpdateStudentLastNameTB.Text.Length > 30)
            {
                MessageBox.Show("Öğrenci soyismi zorunludur ve en fazla 30 karakter olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Adres kontrolü
            if (string.IsNullOrWhiteSpace(UpdateStudentAddressTB.Text))
            {
                MessageBox.Show("Adres zorunludur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Şehir seçimi kontrolü
            if (UpdateStudentCityCB.SelectedIndex == -1)
            {
                MessageBox.Show("Şehir seçimi zorunludur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // İlçe seçimi kontrolü
            if (UpdateStudentDistrictCB.SelectedIndex == -1)
            {
                MessageBox.Show("İlçe seçimi zorunludur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion

        #region Sınıf ekleme
        private void AddClassBtn2_Click(object sender, EventArgs e)
        {
            string className = AddClassTB.Text.Trim(); // Girilen sınıf adını alırken baştaki ve sondaki boşlukları kaldır

            // Girilen sınıf adı boş ise uyarı ver ve işlemi sonlandır
            if (string.IsNullOrWhiteSpace(className))
            {
                MessageBox.Show("Lütfen bir sınıf adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var DB = new NewSchoolDBEntities())
            {
                // Girilen sınıf adının veritabanında olup olmadığını kontrol et
                bool classExists = DB.CLASSes.Any(c => c.class_name == className);

                // Eğer sınıf zaten veritabanında varsa, kullanıcıya uyarı ver ve işlemi sonlandır
                if (classExists)
                {
                    MessageBox.Show("Bu sınıf zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Yeni bir sınıf nesnesi oluştur ve veritabanına ekle
                CLASS newClass = new CLASS
                {
                    class_name = className
                };
                DB.CLASSes.Add(newClass);

                // Değişiklikleri kaydet
                DB.SaveChanges();

                // Kullanıcıya başarılı bir mesaj göster
                MessageBox.Show("Sınıf başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Sınıf updateleme

        private void LoadClassNames()
        {
            var DB = new NewSchoolDBEntities();
            // Veritabanından sınıf isimlerini al
            var classNames = DB.CLASSes.Select(c => c.class_name).ToList();

            // ComboBox'ı sınıf isimleriyle doldur
            classComboBox.DataSource = classNames;
        }
        private void updateClassButton_Click(object sender, EventArgs e)
        {
            var DB = new NewSchoolDBEntities();
            // Seçilen sınıfın adını al
            string selectedClassName = classComboBox.SelectedItem.ToString();

            // Yeni sınıf adını al
            string newClassName = newClassNameTextBox.Text;

            // Eğer herhangi bir sınıf seçilmediyse veya yeni sınıf adı boşsa işlemi durdur
            if (string.IsNullOrEmpty(selectedClassName) || string.IsNullOrEmpty(newClassName))
            {
                MessageBox.Show("Lütfen bir sınıf seçin ve yeni sınıf adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçilen sınıf adıyla veritabanında sınıfı bul
            var selectedClass = DB.CLASSes.FirstOrDefault(c => c.class_name == selectedClassName);

            // Eğer seçilen sınıf bulunamadıysa işlemi durdur
            if (selectedClass == null)
            {
                MessageBox.Show("Seçilen sınıf bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yeni sınıf adıyla veritabanında başka bir sınıf var mı kontrol et
            var existingClass = DB.CLASSes.FirstOrDefault(c => c.class_name == newClassName);

            // Eğer yeni sınıf adıyla bir sınıf bulunduysa işlemi durdur
            if (existingClass != null)
            {
                MessageBox.Show("Bu isimde bir sınıf zaten mevcut. Lütfen farklı bir isim girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçilen sınıfın adını güncelle
            selectedClass.class_name = newClassName;

            try
            {
                // Değişiklikleri kaydet
                DB.SaveChanges();
                MessageBox.Show("Sınıf başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sınıf güncelleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Sınıf Listeleme
        private void ListStudentButton_Click(object sender, EventArgs e)
        {
            var DB = new NewSchoolDBEntities();

            // Seçilen sınıf adını al
            string selectedClassName = ListClassCB.SelectedItem.ToString();

            // Eğer herhangi bir sınıf seçilmediyse işlemi durdur
            if (string.IsNullOrEmpty(selectedClassName))
            {
                MessageBox.Show("Lütfen bir sınıf seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçilen sınıfın ID'sini bul
            var selectedClass = DB.CLASSes.FirstOrDefault(c => c.class_name == selectedClassName);

            // Eğer seçilen sınıf bulunamadıysa işlemi durdur
            if (selectedClass == null)
            {
                MessageBox.Show("Seçilen sınıf bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçilen sınıftaki öğrenci sayısını bul
            int studentCount = DB.STUDENTs.Count(s => s.class_id == selectedClass.class_id);

            // Öğrenci sayısını ekrana yazdır
            HowManyStudentLbl.Text = $"{selectedClassName} sınıfında toplam {studentCount} öğrenci bulunmaktadır.";

        }

        private void LoadUpdateClassNames()
        {
            var DB = new NewSchoolDBEntities();
            // Veritabanından sınıf isimlerini al
            var classNames = DB.CLASSes.Select(c => c.class_name).ToList();

            // ComboBox'ı sınıf isimleriyle doldur
            ListClassCB.DataSource = classNames;
        }


        #endregion

        #region Sınıf Silme
        private void DeleteClassButton_Click(object sender, EventArgs e)
        {
            var DB = new NewSchoolDBEntities();

            // Seçilen sınıf adını al
            string selectedClassName = DeleteClassCB.SelectedItem.ToString();

            // Eğer herhangi bir sınıf seçilmediyse işlemi durdur
            if (string.IsNullOrEmpty(selectedClassName))
            {
                MessageBox.Show("Lütfen bir sınıf seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçilen sınıfın ID'sini bul
            var selectedClass = DB.CLASSes.FirstOrDefault(c => c.class_name == selectedClassName);

            // Eğer seçilen sınıf bulunamadıysa işlemi durdur
            if (selectedClass == null)
            {
                MessageBox.Show("Seçilen sınıf bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçilen sınıfta öğrenci veya öğretmen var mı kontrol et
            bool hasStudents = DB.STUDENTs.Any(s => s.class_id == selectedClass.class_id);

            // Eğer sınıfta öğrenci veya öğretmen yoksa sınıfı sil
            DB.CLASSes.Remove(selectedClass);

            try
            {
                // Değişiklikleri kaydet
                DB.SaveChanges();
                MessageBox.Show("Sınıf başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sınıf silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadDeleteClassNames()
        {
            var DB = new NewSchoolDBEntities();
            // Veritabanından sınıf isimlerini al
            var classNames = DB.CLASSes.Select(c => c.class_name).ToList();

            // ComboBox'ı sınıf isimleriyle doldur
            DeleteClassCB.DataSource = classNames;
        }

        #endregion

        #region Öğretmen ekleme
        private void TeacherAddLoadBranches()
        {
            var DB = new NewSchoolDBEntities();
            var branches = DB.BRANCHes.ToList();
            TeacherAddBranchCB.DataSource = branches;
            TeacherAddBranchCB.DisplayMember = "branch_name";
            TeacherAddBranchCB.ValueMember = "branch_id";
        }
        private void TeacherAdd2Btn_Click(object sender, EventArgs e)
        {
            var DB = new NewSchoolDBEntities();

            // Öğretmen bilgilerini al
            string teacherName = TeacherAddNameTB.Text;
            int selectedBranchId = (int)TeacherAddBranchCB.SelectedValue;

            // Girdi kontrolleri
            if (string.IsNullOrEmpty(teacherName))
            {
                MessageBox.Show("Lütfen öğretmenin adını girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Öğretmen ekle
            var newTeacher = new TEACHER
            {
                teacher_fullname = teacherName,
                branch_id = selectedBranchId
            };
            DB.TEACHERs.Add(newTeacher);

            try
            {
                // Değişiklikleri kaydet
                DB.SaveChanges();
                MessageBox.Show("Öğretmen başarıyla eklendi. Şimdi sınıfa atayabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Öğretmen ekleme işlemi başarılı olduğunda öğretmeni sınıfa atama paneline yönlendir
                DefineAClassTeacherBtn.Visible = true; // Yönlendirme butonunu görünür yap
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğretmen ekleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Öğretmen ve sınıf bilgilerini ComboBox'lara yükleme
        private void TeacherAddLoadTeachers()
        {
            var DB = new NewSchoolDBEntities();
            var teachers = DB.TEACHERs.ToList();
            SelectTeacherCB.DataSource = teachers;
            SelectTeacherCB.DisplayMember = "teacher_fullname";
            SelectTeacherCB.ValueMember = "teacher_id";
        }

        private void TeacherAddLoadClasses()
        {
            var DB = new NewSchoolDBEntities();
            var classes = DB.CLASSes.ToList();
            SelectClassCB.DataSource = classes;
            SelectClassCB.DisplayMember = "class_name";
            SelectClassCB.ValueMember = "class_id";
        }

        private void AssignClassBtn_Click(object sender, EventArgs e)
        {
            var DB = new NewSchoolDBEntities();

            // Öğretmen ve sınıf bilgilerini al
            int selectedTeacherId = (int)SelectTeacherCB.SelectedValue;
            int selectedClassId = (int)SelectClassCB.SelectedValue;

            // Aynı sınıfta aynı branştan bir öğretmen var mı kontrol et
            var selectedTeacher = DB.TEACHERs.FirstOrDefault(t => t.teacher_id == selectedTeacherId);
            var existingTeacherInClass = DB.TEACHER_CLASS
                .Join(DB.TEACHERs, tc => tc.teacher_id, t => t.teacher_id, (tc, t) => new { tc, t })
                .FirstOrDefault(x => x.tc.class_id == selectedClassId && x.t.branch_id == selectedTeacher.branch_id);

            if (existingTeacherInClass != null)
            {
                MessageBox.Show("Bu sınıfta bu branştan bir öğretmen zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // teacher_class tablosuna kayıt ekle
            var newTeacherClass = new TEACHER_CLASS
            {
                teacher_id = selectedTeacherId,
                class_id = selectedClassId
            };
            DB.TEACHER_CLASS.Add(newTeacherClass);

            try
            {
                // Değişiklikleri kaydet
                DB.SaveChanges();
                MessageBox.Show("Öğretmen başarıyla sınıfa atandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException dbEx)
            {
                var errorMessage = dbEx.InnerException?.InnerException?.Message ?? dbEx.Message;
                MessageBox.Show("Öğretmen sınıfa atama işlemi sırasında bir hata oluştu: " + errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğretmen sınıfa atama işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectTeacherCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var DB = new NewSchoolDBEntities();

            // Seçili öğretmenin ID'sini al
            int selectedTeacherId = (int)SelectTeacherCB.SelectedValue;

            // Öğretmen bilgilerini veritabanından al
            var selectedTeacher = DB.TEACHERs.FirstOrDefault(t => t.teacher_id == selectedTeacherId);

            if (selectedTeacher != null)
            {
                // Öğretmenin branşını al
                var branch = DB.BRANCHes.FirstOrDefault(b => b.branch_id == selectedTeacher.branch_id);

                // Branşı etikete yazdır
                if (branch != null)
                {
                    TeacherBranchLbl.Text = branch.branch_name;
                }
                else
                {
                    TeacherBranchLbl.Text = "Branch not found";
                }
            }
            else
            {
                TeacherBranchLbl.Text = "Teacher not found";
            }
        }


        #endregion

        #region Öğretmen Güncelleme
        private void UpdateTeacherLoadBranchesAndClasses()
        {
            var DB = new NewSchoolDBEntities();

            // Öğretmenleri ComboBox'a yükle
            var teachers = DB.TEACHERs.Select(t => new { t.teacher_id, t.teacher_fullname }).ToList();
            SelectUpdateTeacherCB.DataSource = teachers;
            SelectUpdateTeacherCB.DisplayMember = "teacher_fullname";
            SelectUpdateTeacherCB.ValueMember = "teacher_id";

            // Branşları ComboBox'a yükle
            var branches = DB.BRANCHes.Select(b => new { b.branch_id, b.branch_name }).ToList();
            UpdateTeacherBranchCB.DataSource = branches;
            UpdateTeacherBranchCB.DisplayMember = "branch_name";
            UpdateTeacherBranchCB.ValueMember = "branch_id";

            // Tüm sınıfları ComboBox'a yükle
            var classes = DB.CLASSes.Select(c => new { c.class_id, c.class_name }).ToList();
            SelectTeacherClassCB.DataSource = classes;
            SelectTeacherClassCB.DisplayMember = "class_name";
            SelectTeacherClassCB.ValueMember = "class_id";
        }
        private void UpdateSelectTeacherCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var DB = new NewSchoolDBEntities();

            // Seçili öğretmenin ID'sini al
            int selectedTeacherId = (int)SelectTeacherCB.SelectedValue;

            // Öğretmen bilgilerini veritabanından al
            var selectedTeacher = DB.TEACHERs.FirstOrDefault(t => t.teacher_id == selectedTeacherId);
            var teacherClasses = DB.TEACHER_CLASS.Where(tc => tc.teacher_id == selectedTeacherId)
                                                 .Select(tc => tc.CLASS)
                                                 .ToList();

            if (selectedTeacher != null)
            {
                // Öğretmenin adını ve branşını TextBox'a yükle
                UpdateTeacherNameTB.Text = selectedTeacher.teacher_fullname;
                UpdateTeacherBranchCB.Text = DB.BRANCHes.FirstOrDefault(b => b.branch_id == selectedTeacher.branch_id)?.branch_name;

                // Öğretmenin sınıflarını ComboBox'a yükle
                WhichClassUpdatedCB.DataSource = teacherClasses;
                WhichClassUpdatedCB.DisplayMember = "class_name";
                WhichClassUpdatedCB.ValueMember = "class_id";
            }
            else
            {
                MessageBox.Show("Öğretmen bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTeacherBtn2_Click(object sender, EventArgs e)
        {
            var DB = new NewSchoolDBEntities();

            // Seçili öğretmenin ID'sini al
            int selectedTeacherId = (int)SelectTeacherCB.SelectedValue;

            // Seçili sınıfın ID'sini al
            int currentClassId = (int)WhichClassUpdatedCB.SelectedValue;

            // Yeni sınıf ID'sini al
            int newClassId = (int)SelectTeacherClassCB.SelectedValue;

            // Girdi kontrolleri
            if (newClassId == currentClassId)
            {
                MessageBox.Show("Lütfen farklı bir sınıf seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Seçili öğretmeni ve sınıfı veritabanından al
            var selectedTeacher = DB.TEACHERs.FirstOrDefault(t => t.teacher_id == selectedTeacherId);
            var teacherClass = DB.TEACHER_CLASS.FirstOrDefault(tc => tc.teacher_id == selectedTeacherId && tc.class_id == currentClassId);

            // Aynı sınıfta aynı branşta öğretmen var mı kontrol et
            var existingTeacherClass = DB.TEACHER_CLASS
                .Join(DB.TEACHERs,
                      tc => tc.teacher_id,
                      t => t.teacher_id,
                      (tc, t) => new { tc.class_id, t.branch_id })
                .FirstOrDefault(x => x.class_id == newClassId && x.branch_id == selectedTeacher.branch_id);

            if (existingTeacherClass != null)
            {
                MessageBox.Show("Aynı sınıfta aynı branşta bir öğretmen zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedTeacher != null && teacherClass != null)
            {
                // Öğretmenin sınıfını güncelle
                teacherClass.class_id = newClassId;

                try
                {
                    // Değişiklikleri kaydet
                    DB.SaveChanges();
                    MessageBox.Show("Öğretmenin sınıfı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Öğretmenin güncellenen sınıflarını yeniden yükle
                    var teacherClasses = DB.TEACHER_CLASS.Where(tc => tc.teacher_id == selectedTeacherId)
                                                          .Select(tc => tc.CLASS)
                                                          .ToList();
                    WhichClassUpdatedCB.DataSource = teacherClasses;
                    WhichClassUpdatedCB.DisplayMember = "class_name";
                    WhichClassUpdatedCB.ValueMember = "class_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğretmenin sınıfını güncelleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Öğretmen veya sınıf bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Öğretmen Listeleme
        private void TeacherListLoadAllClasses()
        {
            var DB = new NewSchoolDBEntities();

            // Tüm sınıfları ComboBox'a yükle
            var classes = DB.CLASSes.ToList();
            FilterClassCB.DataSource = classes;
            FilterClassCB.DisplayMember = "class_name";
            FilterClassCB.ValueMember = "class_id";
        }
        private void FilterTeacherBtn_Click(object sender, EventArgs e)
        {
            var DB = new NewSchoolDBEntities();

            // Seçilen sınıf ID'sini al
            int selectedClassId = (int)FilterClassCB.SelectedValue;

            // Seçilen sınıfa göre öğretmenleri ve bilgilerini al
            var teachers = DB.TEACHERs.Where(t => t.TEACHER_CLASS.Any(tc => tc.class_id == selectedClassId))
                                      .Select(t => new
                                      {
                                          TeacherName = t.teacher_fullname,
                                          BranchName = t.BRANCH.branch_name,
                                          ClassName = t.TEACHER_CLASS.FirstOrDefault(tc => tc.class_id == selectedClassId).CLASS.class_name
                                      })
                                      .ToList();

            // Datagridview'e öğretmenleri yükle
            ListedTeacherDGV.DataSource = teachers;

            // Kolon adlarını değiştir
            ListedTeacherDGV.Columns["TeacherName"].HeaderText = "Öğretmen İsmi";
            ListedTeacherDGV.Columns["BranchName"].HeaderText = "Branşı";
            ListedTeacherDGV.Columns["ClassName"].HeaderText = "Şube/Şubeler";
        }
        #endregion

        #region Öğretmen silme
        private void TeacherDeleteLoadTeachers()
        {
            var DB = new NewSchoolDBEntities();

            // Tüm öğretmenleri ComboBox'a yükle
            var teachers = DB.TEACHERs.ToList();
            SelectDeleteTeacherCB.DataSource = teachers;
            SelectDeleteTeacherCB.DisplayMember = "teacher_fullname";
            SelectDeleteTeacherCB.ValueMember = "teacher_id";
        }
        private void SearchTeacherBtn_Click(object sender, EventArgs e)
        {
            if (SelectDeleteTeacherCB.SelectedItem != null)
            {
                var selectedTeacher = (TEACHER)SelectDeleteTeacherCB.SelectedItem;
                GetTeacherInfoLbl.Text = $"Öğretmen Adı: {selectedTeacher.teacher_fullname}\nBranşı: {selectedTeacher.BRANCH.branch_name}\n";
            }
            else
            {
                MessageBox.Show("Lütfen öğretmen seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void DeleteTeacherBtn_Click(object sender, EventArgs e)
        {
            if (SelectDeleteTeacherCB.SelectedItem != null)
            {
                var selectedTeacher = (TEACHER)SelectDeleteTeacherCB.SelectedItem;
                var selectedTeacherId = selectedTeacher.teacher_id;

                var DB = new NewSchoolDBEntities();

                try
                {
                    // Nesneyi izlenmeyen duruma getir
                    DB.Entry(selectedTeacher).State = EntityState.Detached;

                    // Nesneyi yeniden al
                    selectedTeacher = DB.TEACHERs.Find(selectedTeacherId);

                    // Nesneyi sil
                    DB.TEACHERs.Remove(selectedTeacher);
                    DB.SaveChanges();

                    // Başarılı bir şekilde silindiğine dair mesaj göster
                    MessageBox.Show("Öğretmen başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Öğretmenleri yeniden yükle
                    TeacherDeleteLoadTeachers();
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıya bilgi ver
                    MessageBox.Show("Öğretmen silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Öğretmen seçilmediğinde kullanıcıya bilgi ver
                MessageBox.Show("Lütfen silmek istediğiniz öğretmeni seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region kantinde öğrencinin yasaklı ürün getirme
        private void CanteenSeachStudentBtn_Click(object sender, EventArgs e)
        {
            int studentNumber;
            if (int.TryParse(CanteenStudentNumberTB.Text, out studentNumber))
            {
                LoadStudentCanteenInfo(studentNumber);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStudentCanteenInfo(int studentNumber)
        {
            using (var DB = new NewSchoolDBEntities())
            {
                // Öğrenci bilgilerini al
                var student = DB.STUDENTs.FirstOrDefault(s => s.student_schoolNo == studentNumber);
                if (student != null)
                {
                    CanteenStudentGetInfoLbl.Text = $"Adı: {student.student_firstname} {student.student_lastname}\n Sınıfı: {student.CLASS.class_name} \n Numarası: {student.student_schoolNo}";

                    // Yasaklı ürünleri al
                    var bannedProducts = DB.CANTEENs
                        .Where(c => c.student_id == student.student_id && (c.is_available_for_student ?? false) == false)
                        .Select(c => new
                        {
                            ÜrünAdı = c.PRODUCT.product_name,
                            Kategori = c.PRODUCT.CATEGORY.category_name,
                            Fiyat = c.PRODUCT.product_price
                        })
                        .ToList();

                    // DataGridView'a yükle
                    CanteenStudentDGV.DataSource = bannedProducts;
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CanteenStudentGetInfoLbl.Text = string.Empty;
                    CanteenStudentDGV.DataSource = null;
                }
            }
        }
        #endregion

        #region List Product
        private void LoadCategories()
        {
            using (var DB = new NewSchoolDBEntities())
            {
                var categories = DB.CATEGORies.Select(c => new { c.category_id, c.category_name }).ToList();
                SelectCategoryCB.DataSource = categories;
                SelectCategoryCB.DisplayMember = "category_name";
                SelectCategoryCB.ValueMember = "category_id";
            }
        }
        private void bFilterListByCategorysBtn_Click(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)SelectCategoryCB.SelectedValue;
            LoadProducts(selectedCategoryId);
        }
        private void LoadProducts(int categoryId)
        {
            using (var DB = new NewSchoolDBEntities())
            {
                var products = DB.PRODUCTs
                    .Where(p => p.category_id == categoryId)
                    .Select(p => new
                    {
                        ÜrünAdı = p.product_name,
                        Kategori = p.CATEGORY.category_name,
                        Fiyat = p.product_price,
                        StokDurumu = p.stock_amount,
                        SKT = p.expiration_date
                    })
                    .ToList();

                ListProductDGV.DataSource = products;

                foreach (DataGridViewRow row in ListProductDGV.Rows)
                {
                    var stockQuantity = (int)row.Cells["StokDurumu"].Value;
                    var expirationDate = (DateTime)row.Cells["SKT"].Value;

                    if (stockQuantity < 3)
                    {
                        row.Cells["StokDurumu"].Style.BackColor = Color.Red;
                    }

                    if ((expirationDate - DateTime.Now).TotalDays <= 3)
                    {
                        row.Cells["SKT"].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        #endregion
    }
}
