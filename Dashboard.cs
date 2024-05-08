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
        // BITMEDI
        Panel studentPanel = new Panel();

        Button HomeButton = new Button();
        HomeButton = Dashboard.HomeButton;

        Button StudentsButton = new Button();
        Button CanteenButton = new Button();
        Button AbscenceButton = new Button();

        String[] WhichPanel = { "Home", "Students", "Canteen", "Abscence" };
        String SelectedPanel = "Home";


        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }


        private void MenuButton_Click(object sender, EventArgs e)
        {
            Switch SelectedPanel
{
                case "Home":
                    studentPanel.Visible = false;
                    break;
                case "Students":
                    studentPanel.Visible = true;
                    break;
                case "Canteen":
                    studentPanel.Visible = false;
                    break;
                case "Abscence":
                    studentPanel.Visible = false;
                    break;
                default:

                    break;
                }
            }
        }
    }
