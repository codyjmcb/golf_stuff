using DataModels;
using Repositories;
using ServiceBus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmGolfer : Form
    {
        Service db_Service;

        public frmGolfer()
        {
            InitializeComponent();

            db_Service = new Service(new GolferRepo(), new ClubTypeRepo(), new GolfCourseRepo(), new TeeInformationRepo());
        }

        private void btnAddGolfer_Click(object sender, EventArgs e)
        {
            if (txtGolferId.Text.Length > 0)
            {
                if(txtMiddleInitial.Text.Length > 1)
                {
                    MessageBox.Show("Middle Name cannot be more than one character");
                }
                else
                {
                    char c = '.';
                    if (txtMiddleInitial.Text.Length == 1) c = char.Parse(txtMiddleInitial.Text);

                    Golfer g = new Golfer(
                        txtGolferId.Text,
                        txtFirstName.Text,
                        c,
                        txtLastName.Text,
                        float.Parse(txtHandicap.Text)
                        );

                    if(db_Service.AddGolfer(g))
                    {
                        MessageBox.Show("Successfully Added Golfer");
                        btnGetAllGolfers_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add golfer");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Golfer Selected");
            }
        }

        private void btnDeleteGolfer_Click(object sender, EventArgs e)
        {
            if(txtGolferId.Text.Length > 0)
            {
                if (db_Service.DeleteGolfer(txtGolferId.Text))
                {
                    MessageBox.Show("Successfully Deleted Golfer");
                    btnGetAllGolfers_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to delete golfer");
                }
            }
            else
            {
                MessageBox.Show("No Golfer Selected");
            }
        }

        private void btnUpdateGolfer_Click(object sender, EventArgs e)
        {
            if (txtGolferId.Text.Length > 0)
            {
                if (txtMiddleInitial.Text.Length > 1)
                {
                    MessageBox.Show("Middle Name cannot be more than one character");
                }
                else
                {
                    char c = '.';
                    if (txtMiddleInitial.Text.Length == 1) c = char.Parse(txtMiddleInitial.Text);

                    Golfer g = new Golfer(
                        txtGolferId.Text,
                        txtFirstName.Text,
                        c,
                        txtLastName.Text,
                        float.Parse(txtHandicap.Text)
                        );

                    if (db_Service.UpdateGolfer(g))
                    {
                        MessageBox.Show("Successfully Updated Golfer");
                        btnGetAllGolfers_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update golfer");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Golfer Selected");
            }
        }

        private void btnGetAllGolfers_Click(object sender, EventArgs e)
        {
            lstGolfers.Items.Clear();
            foreach(Golfer g in db_Service.FindAllGolfers())
            {
                lstGolfers.Items.Add(g);
            }
        }

        private void lstGolfers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstGolfers.SelectedItems.Count == 1)
            {
                Golfer g = (Golfer)lstGolfers.SelectedItem;
                txtGolferId.Text = g._golferID;
                txtFirstName.Text = g._firstName;
                txtMiddleInitial.Text = g._middleInitial.ToString();
                txtLastName.Text = g._lastName;
                txtHandicap.Text = g._handicap.ToString();
            }
        }

        private void btnGetClubTypes_Click(object sender, EventArgs e)
        {
            lstClubType.Items.Clear();
            foreach(ClubType c in db_Service.FindAllClubTypes())
            {
                lstClubType.Items.Add(c);
            }
        }

        private void btnAddClubType_Click(object sender, EventArgs e)
        {
            if(txtClubName.Text.Length != 0)
            {
                ClubType c = new ClubType(0, txtClubName.Text);
                if(db_Service.AddClubType(c))
                {
                    MessageBox.Show("Successfully Added Club Type");
                    btnGetClubTypes_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to add club type");
                }
            }
            else
            {
                MessageBox.Show("No Club Name Entered");
            }
        }

        private void btnUpdateClubType_Click(object sender, EventArgs e)
        {
            if (txtClubUniqueId.Text.Length != 0)
            {
                ClubType c = new ClubType(byte.Parse(txtClubUniqueId.Text), txtClubName.Text);

                if (db_Service.UpdateClubType(c))
                {
                    MessageBox.Show("Successfully Updated Club Type");
                    btnGetClubTypes_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to update club type");
                }
            }
            else
            {
                MessageBox.Show("No club type selected");
            }
        }

        private void btnDeleteClubType_Click(object sender, EventArgs e)
        {
            if (txtClubUniqueId.Text.Length != 0)
            {
                if (db_Service.DeleteClubType(txtClubUniqueId.Text))
                {
                    MessageBox.Show("Successfully Deleted Club Type");
                    btnGetClubTypes_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to delete club type");
                }
            }
            else
            {
                MessageBox.Show("No club type selected");
            }
        }

        private void lstClubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstClubType.SelectedItems.Count == 1)
            {
                ClubType c = (ClubType)lstClubType.SelectedItem;
                txtClubUniqueId.Text = c._uniqueID.ToString();
                txtClubName.Text = c._clubName;
            }
        }

        private void btnGetCourses_Click(object sender, EventArgs e)
        {
            lstCourses.Items.Clear();
            foreach (GolfCourse gc in db_Service.FindAllCourses())
            {
                lstCourses.Items.Add(gc);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text.Length != 0)
            {
                GolfCourse gc = new GolfCourse(txtCourseID.Text, txtCourseName.Text, byte.Parse(txtNumTees.Text), byte.Parse(txtPar.Text));
                if (db_Service.AddCourse(gc))
                {
                    MessageBox.Show("Successfully Added golf course");
                    btnGetCourses_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to add golf course");
                }
            }
            else
            {
                MessageBox.Show("No golf course Entered");
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text.Length != 0)
            {
                GolfCourse gc = new GolfCourse(txtCourseID.Text, txtCourseName.Text, byte.Parse(txtNumTees.Text), byte.Parse(txtPar.Text));
                if (db_Service.UpdateCourse(gc))
                {
                    MessageBox.Show("Successfully Added Golf Course");
                    btnGetCourses_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to add golf course");
                }
            }
            else
            {
                MessageBox.Show("No golf course Entered");
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text.Length != 0)
            {
                if (db_Service.DeleteCourse(txtCourseID.Text))
                {
                    MessageBox.Show("Successfully Deleted golf course");
                    btnGetCourses_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to delete golf course");
                }
            }
            else
            {
                MessageBox.Show("No golf course selected");
            }
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCourses.SelectedItems.Count == 1)
            {
                GolfCourse gc = (GolfCourse)lstCourses.SelectedItem;
                txtCourseID.Text = gc._courseID;
                txtCourseName.Text = gc._courseName;
                txtNumTees.Text = gc._numTees.ToString();
                txtPar.Text = gc._par.ToString();
            }
        }

        private void btnGetTeeInformation_Click(object sender, EventArgs e)
        {
            lstTeeInformation.Items.Clear();
            foreach (TeeInformation t in db_Service.FindAllTeeInfo())
            {
                lstTeeInformation.Items.Add(t);
            }
        }

        private void btnAddTeeInfo_Click(object sender, EventArgs e)
        {
            if (txtTCourseID.Text.Length != 0)
            {
                TeeInformation t = new TeeInformation(
                    0,
                    txtTCourseID.Text,
                    txtTeeName.Text,
                    int.Parse(txtYardage.Text),
                    short.Parse(txtSlope.Text),
                    decimal.Parse(txtRating.Text)
                    );

                if (db_Service.AddTeeInformation(t))
                {
                    MessageBox.Show("Successfully added tee info");
                    btnGetTeeInformation_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to add tee info");
                }
            }
            else
            {
                MessageBox.Show("No course Selected");
            }
        }

        private void btnUpdateTeeInfo_Click(object sender, EventArgs e)
        {
            if (txtUniqueID.Text.Length != 0)
            {
                TeeInformation t = new TeeInformation(
                    short.Parse(txtUniqueID.Text),
                    txtTCourseID.Text,
                    txtTeeName.Text,
                    int.Parse(txtYardage.Text),
                    short.Parse(txtSlope.Text),
                    decimal.Parse(txtRating.Text)
                    );

                if (db_Service.UpdateTeeInformation(t))
                {
                    MessageBox.Show("Successfully updated tee info");
                    btnGetTeeInformation_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to udpate tee info");
                }
            }
            else
            {
                MessageBox.Show("No tee info Selected");
            }
        }

        private void btnDeleteTeeInfo_Click(object sender, EventArgs e)
        {
            if(txtTCourseID.Text.Length != 0)
            {
                if(db_Service.DeleteTeeInformation(txtUniqueID.Text))
                {
                    MessageBox.Show("Successfully deleted tee info");
                    btnGetTeeInformation_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to delete tee info");
                }
            }
            else
            {
                MessageBox.Show("No Course Selected");
            }
        }

        private void lstTeeInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstTeeInformation.SelectedItems.Count == 1)
            {
                TeeInformation t = (TeeInformation)lstTeeInformation.SelectedItem;
                txtUniqueID.Text = t._uniqueID.ToString();
                txtTCourseID.Text = t._courseID;
                txtTeeName.Text = t._teeName;
                txtYardage.Text = t._yardage.ToString();
                txtRating.Text = t._rating.ToString();
                txtSlope.Text = t._slope.ToString();
            }
        }
    }
}
