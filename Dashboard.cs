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

        private readonly Dictionary<string, Panel> buttonPanelMap = new Dictionary<string, Panel>();
        public Dashboard()
        {
            InitializeComponent();

            buttonPanelMap.Add("HomeButton", HomePanel);
            buttonPanelMap.Add("StudentsButton", StudentPanel);
            buttonPanelMap.Add("CanteenButton", CanteenPanel);
            buttonPanelMap.Add("AbscenceButton", AbscencePanel);


        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

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
    }
}
