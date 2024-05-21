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
    public partial class frmMain : Form
    {
        Service db_Service;

        public frmMain()
        {
            InitializeComponent();

            GolfersRepo golferRepo = new GolfersRepo();

            db_Service = new Service(golferRepo);
        }

        private void btnGetGolfer_Click(object sender, EventArgs e)
        {
            txtResponse.Text = db_Service.FindGolfer("12345")._golferID;
        }

        private void btnAddGolfer_Click(object sender, EventArgs e)
        {
            txtResponse.Text = db_Service.AddGolfer(new Golfer("12345", "Cody", 'J', "McBride", 0)).ToString();
        }

        private void btnDeleteGolfer_Click(object sender, EventArgs e)
        {
            txtResponse.Text = db_Service.DeleteGolfer("12345").ToString();
        }

        private void btnUpdateGolfer_Click(object sender, EventArgs e)
        {
            txtResponse.Text = db_Service.UpdateGolfer(new Golfer("12345", "Cody", 'J', "McBride", 0)).ToString();
        }

        private void btnGetAllGolfers_Click(object sender, EventArgs e)
        {
            foreach(Golfer g in db_Service.FindAllGolfers())
            {
                txtResponse.Text += g.ToString();
            }
        }
    }
}
