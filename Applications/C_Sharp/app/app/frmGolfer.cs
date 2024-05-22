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

            db_Service = new Service(new GolfersRepo(), new ClubTypeRepo());
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
                ClubType c = new ClubType(byte.Parse(txtClubUniqueId.Text), "doesn't matter");

                if (db_Service.DeleteClubType(c._uniqueID.ToString()))
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
    }
}
