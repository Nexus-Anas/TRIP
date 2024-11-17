using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRIP_APP.Models;

namespace TRIP_APP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var region = Data.Trip.Name;
            lblRegion.Text = region;
            var lsParticipants = Data.Trip.Participants;
            dgvParticipants.DataSource = lsParticipants;
            comboParticipants.DataSource = lsParticipants;
            comboParticipants.DisplayMember = "Name";
            comboParticipants.ValueMember = "Id";


            if (Data.Trip.IsEnded)
            {
                lblSummary.Visible = true;
                btnFinishTrip.Enabled = false;
                btnNewActivity.Enabled = false;
                btnNewTrip.Visible = true;

                DisplaySummary();
            }
        }




        /////////////////////////////////////Global Variables/////////////////////////////////////////////////
        private bool _mouseDown;
        private Point _startPoint = new Point(0, 0);
        private int _currentActivityID;
        private int _currentPersonInChargeID;
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Indicator.Top = ((Control)sender).Top;
            MultiPage.SetPage("tabPage1");
            Indicator2.Visible = false;
        }

        private void btnNewActivity_Click(object sender, EventArgs e)
        {
            Indicator.Top = ((Control)sender).Top;
            MultiPage.SetPage("tabPage2");
            Indicator2.Visible = false;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            Indicator.Top = ((Control)sender).Top;
            MultiPage.SetPage("tabPage3");
            Indicator2.Visible = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (comboParticipants.SelectedItem != null)
            {
                int id = (int)comboParticipants.SelectedValue;
                _currentPersonInChargeID = id;
                var personInCharge = Data.Trip.Participants.Where(p => p.Id == id).FirstOrDefault();
                var debtors = new List<Debtors>();
                foreach (var item in Data.Trip.Participants)
                    if (item.Id != id)
                    {
                        var debtor = new Debtors() { Debtor = item, Amount = 0 };
                        debtors.Add(debtor);
                    }

                if (Data.Trip.Activities == null)
                    Data.Trip.Activities = new List<Activity>();

                int activity_id = Data.Trip.Activities == null ? 1 : Data.Trip.Activities.Count + 1;
                _currentActivityID = activity_id;
                var activity = new Activity() { Id = activity_id, Name = txtActivityName.Text, PersonInCharge = personInCharge, Debtors = debtors };
                Data.Trip.Activities.Add(activity);
                
                panelCreateActivity.Enabled = false;
                panelPerformActivity.Visible = true;
                lblPersonInCharge.Text = personInCharge.Name;


                var ls = new List<Person>();
                foreach (var item in debtors)
                    ls.Add(new Person() { Id = item.Debtor.Id, Name = item.Debtor.Name });

                dgvDebtorsActivity.DataSource = debtors;
                comboDebtors.DataSource = ls;
                comboDebtors.DisplayMember = "Name";
                comboDebtors.ValueMember = "Id";
            }
            txtActivityName.ResetText();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int id = (int)comboDebtors.SelectedValue;
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            foreach (var item in Data.Trip.Activities)
                foreach (var item2 in item.Debtors)
                    if (item2.Debtor.Id == id)
                        item2.Amount += amount;
            var activity = Data.Trip.Activities.Where(a => a.Id == _currentActivityID).FirstOrDefault();
            var debtors = activity.Debtors.ToList();
            dgvDebtorsActivity.DataSource = null;
            dgvDebtorsActivity.DataSource = debtors;
        }

        private void btnEndActivity_Click(object sender, EventArgs e)
        {
            var data = new Data();
            data.UpdateTripInJson(Data.Trip.Id, Data.Trip);

            _currentPersonInChargeID = 0;
            _currentActivityID = 0;

            panelCreateActivity.Enabled = true;
            panelPerformActivity.Visible = false;
            lblPersonInCharge.Text = string.Empty;
        }

        private void btnFinishTrip_Click(object sender, EventArgs e)
        {
            lblSummary.Visible = true;
            btnFinishTrip.Enabled = false;
            btnDashboard.Enabled = false;
            btnNewActivity.Enabled = false;
            btnSummary.Enabled = false;
            btnNewTrip.Visible = true;

            Data.Trip.IsEnded = true;
            var data = new Data();
            data.UpdateTripInJson(Data.Trip);

            DisplaySummary();
            
        }

        private void btnNewTrip_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }








        private void DisplaySummary()
        {
            var dict = new Dictionary<Person, Dictionary<Person, decimal>>();

            foreach (var activity in Data.Trip.Activities)
            {
                if (!dict.ContainsKey(activity.PersonInCharge))
                    dict[activity.PersonInCharge] = new Dictionary<Person, decimal>();

                foreach (var debtor in activity.Debtors)
                {
                    if (!dict[activity.PersonInCharge].ContainsKey(debtor.Debtor))
                        dict[activity.PersonInCharge][debtor.Debtor] = debtor.Amount;
                    else
                        dict[activity.PersonInCharge][debtor.Debtor] += debtor.Amount;
                }
            }




            for (int i = 0; i < dict.Keys.Count; i++)
            {
                var owner = dict.Keys.ElementAt(i);

                for (int j = 1; j < dict.Keys.Count; j++)
                {
                    var nextOwner = dict.Keys.ElementAt(j);

                    var ownerDebtors = dict[owner];
                    var nextOwnerDebtors = dict[nextOwner];

                    foreach (var debtor in ownerDebtors.Keys.ToList())
                        foreach (var nextDebtor in nextOwnerDebtors.Keys.ToList())
                            if (owner.Id == nextDebtor.Id && nextOwner.Id == debtor.Id)
                            {
                                decimal debtorValue = ownerDebtors[debtor];
                                decimal nextDebtorValue = nextOwnerDebtors[nextDebtor];

                                if (debtorValue > nextDebtorValue)
                                {
                                    debtorValue -= nextDebtorValue;
                                    nextDebtorValue = 0;
                                }
                                else
                                {
                                    nextDebtorValue -= debtorValue;
                                    debtorValue = 0;
                                }

                                ownerDebtors[debtor] = debtorValue;
                                nextOwnerDebtors[nextDebtor] = nextDebtorValue;
                            }
                }
            }

            foreach (var owner in dict.Keys)
            {
                lblSummary.Text += $"\nPerson in Charge: {owner.Name}\nDebtors:\n";

                foreach (var debtor in dict[owner])
                    lblSummary.Text += $"-{debtor.Key.Name} : {debtor.Value} DH\n";
            }
        }

        private void debtorsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
