using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TRIP_APP.Models;

namespace TRIP_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerLoading.Start();

            _trips = _data.LoadTripsFromJson();
            if (_trips.Count == 0)
                btnSelectTrip.Enabled = false;

            dgvTrip.DataSource = _trips;
        }




        /////////////////////////////////////Global Variables/////////////////////////////////////////////////
        private bool _mouseDown;
        private Point _startPoint = new Point(0, 0);
        private int _sec = 0;
        private Trip _trip;
        private List<Trip> _trips = new List<Trip>();
        private int _trip_id;
        private Data _data = new Data();
        //////////////////////////////////////////////////////////////////////////////////////////////////////






        /////////////////////////////////////Settings/////////////////////////////////////////////////////////
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void navBar_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true; _startPoint = new Point(e.X, e.Y);
        }
        private void navBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                var point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }
        private void navBar_MouseUp(object sender, MouseEventArgs e) => _mouseDown = false;

        private void btnNewTrip_MouseEnter(object sender, EventArgs e)
            => btnNewTrip.BaseColor = Color.FromArgb(76, 75, 105);
        private void btnNewTrip_MouseLeave(object sender, EventArgs e)
            => btnNewTrip.BaseColor = Color.FromArgb(52, 51, 73);
        private void btnStartTrip_MouseEnter(object sender, EventArgs e)
            => btnStartTrip.BaseColor = Color.FromArgb(76, 75, 105);
        private void btnStartTrip_MouseLeave(object sender, EventArgs e)
            => btnStartTrip.BaseColor = Color.FromArgb(52, 51, 73);
        //////////////////////////////////////////////////////////////////////////////////////////////////////





        //Page 1
        private void timerLoading_Tick(object sender, EventArgs e)
        {
            _sec++;
            if (_sec == 4)
            {
                Multipage.SetPage("tabPage2");
                timerLoading.Stop();
                _sec = 0;
            }
        }





        //Page 2
        private void btnNewTrip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddTrip.Text))
            {
                MessageBox.Show("Please enter the trip name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in _trips)
                if (!item.IsEnded)
                {
                    MessageBox.Show("You can't create unless you ended your actual trip!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            _trip = new Trip() { Id = _trips.Count + 1, Name = txtAddTrip.Text };
            _trip.Participants = new List<Person>();
            Multipage.SetPage("tabPage3");
        }




        private void btnSelectTrip_Click(object sender, EventArgs e)
        {
            if (_trip_id == 0)
            {
                MessageBox.Show("Please select a trip!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _trip = _trips.Where(t => t.Id == _trip_id).FirstOrDefault();
            Data.Trip = _trip;
            LoadTripProgressBar.Start();
            timerLoadTrip.Start();
        }





        private void dgvTrip_CellClick(object sender, DataGridViewCellEventArgs e)
            => _trip_id = Convert.ToInt32(dgvTrip.Rows[e.RowIndex].Cells[0].Value);




        private void timerLoadTrip_Tick(object sender, EventArgs e)
        {
            _sec++;

            if (_sec == 3)
            {
                new MainForm().Show();
                timerLoadTrip.Stop();
                Hide();
            }
        }






        //Page 3
        private void btnAddPeople_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddPeople.Text))
            {
                MessageBox.Show("Please enter a valid name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var person = new Person() { Id = _trip.Participants.Count + 1, Name = txtAddPeople.Text };
            _trip.Participants.Add(person);
            dgvParticipants.DataSource = null;
            dgvParticipants.DataSource = _trip.Participants;
            txtAddPeople.ResetText();
            txtAddPeople.Focus();
        }




        private void btnStartTrip_Click(object sender, EventArgs e)
        {
            if (dgvParticipants.Rows.Count < 2)
            {
                MessageBox.Show("Please enter at least 2 people", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ls = _data.LoadTripsFromJson();
            ls.Add(_trip);
            _data.SaveTripsToJson(ls);
            _trip.Activities = new List<Activity>();
            Data.Trip = _trip;
            progressBar.Start();
            timerStartTrip.Start();
        }




        private void timerStartTrip_Tick(object sender, EventArgs e)
        {
            _sec++;
            if (_sec == 3)
            {
                new MainForm().Show();
                timerStartTrip.Stop();
                Hide();
            }
        }

        private void btnStartTrip_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
