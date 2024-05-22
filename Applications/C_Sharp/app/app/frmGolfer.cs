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

            GolfersRepo golferRepo = new GolfersRepo();

            db_Service = new Service(golferRepo);
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
    }
}
