
namespace app
{
    partial class frmGolfer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetAllGolfers = new System.Windows.Forms.Button();
            this.btnAddGolfer = new System.Windows.Forms.Button();
            this.btnUpdateGolfer = new System.Windows.Forms.Button();
            this.btnDeleteGolfer = new System.Windows.Forms.Button();
            this.lstGolfers = new System.Windows.Forms.ListBox();
            this.txtGolferId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtHandicap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetAllGolfers
            // 
            this.btnGetAllGolfers.Location = new System.Drawing.Point(119, 156);
            this.btnGetAllGolfers.Name = "btnGetAllGolfers";
            this.btnGetAllGolfers.Size = new System.Drawing.Size(103, 23);
            this.btnGetAllGolfers.TabIndex = 0;
            this.btnGetAllGolfers.Text = "Get All Golfers";
            this.btnGetAllGolfers.UseVisualStyleBackColor = true;
            this.btnGetAllGolfers.Click += new System.EventHandler(this.btnGetAllGolfers_Click);
            // 
            // btnAddGolfer
            // 
            this.btnAddGolfer.Location = new System.Drawing.Point(119, 214);
            this.btnAddGolfer.Name = "btnAddGolfer";
            this.btnAddGolfer.Size = new System.Drawing.Size(103, 23);
            this.btnAddGolfer.TabIndex = 2;
            this.btnAddGolfer.Text = "Add Golfer";
            this.btnAddGolfer.UseVisualStyleBackColor = true;
            this.btnAddGolfer.Click += new System.EventHandler(this.btnAddGolfer_Click);
            // 
            // btnUpdateGolfer
            // 
            this.btnUpdateGolfer.Location = new System.Drawing.Point(119, 243);
            this.btnUpdateGolfer.Name = "btnUpdateGolfer";
            this.btnUpdateGolfer.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateGolfer.TabIndex = 3;
            this.btnUpdateGolfer.Text = "Update Golfer";
            this.btnUpdateGolfer.UseVisualStyleBackColor = true;
            this.btnUpdateGolfer.Click += new System.EventHandler(this.btnUpdateGolfer_Click);
            // 
            // btnDeleteGolfer
            // 
            this.btnDeleteGolfer.Location = new System.Drawing.Point(119, 272);
            this.btnDeleteGolfer.Name = "btnDeleteGolfer";
            this.btnDeleteGolfer.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteGolfer.TabIndex = 4;
            this.btnDeleteGolfer.Text = "Delete Golfer";
            this.btnDeleteGolfer.UseVisualStyleBackColor = true;
            this.btnDeleteGolfer.Click += new System.EventHandler(this.btnDeleteGolfer_Click);
            // 
            // lstGolfers
            // 
            this.lstGolfers.FormattingEnabled = true;
            this.lstGolfers.ItemHeight = 15;
            this.lstGolfers.Location = new System.Drawing.Point(228, 156);
            this.lstGolfers.Name = "lstGolfers";
            this.lstGolfers.Size = new System.Drawing.Size(120, 139);
            this.lstGolfers.TabIndex = 6;
            this.lstGolfers.SelectedIndexChanged += new System.EventHandler(this.lstGolfers_SelectedIndexChanged);
            // 
            // txtGolferId
            // 
            this.txtGolferId.Location = new System.Drawing.Point(355, 156);
            this.txtGolferId.Name = "txtGolferId";
            this.txtGolferId.PlaceholderText = "Golfer Id";
            this.txtGolferId.Size = new System.Drawing.Size(157, 23);
            this.txtGolferId.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(354, 185);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(157, 23);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(354, 214);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.PlaceholderText = "Middle Initial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(157, 23);
            this.txtMiddleInitial.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(354, 243);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(157, 23);
            this.txtLastName.TabIndex = 10;
            // 
            // txtHandicap
            // 
            this.txtHandicap.Location = new System.Drawing.Point(354, 272);
            this.txtHandicap.Name = "txtHandicap";
            this.txtHandicap.PlaceholderText = "Handicap";
            this.txtHandicap.Size = new System.Drawing.Size(157, 23);
            this.txtHandicap.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHandicap);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtGolferId);
            this.Controls.Add(this.lstGolfers);
            this.Controls.Add(this.btnDeleteGolfer);
            this.Controls.Add(this.btnUpdateGolfer);
            this.Controls.Add(this.btnAddGolfer);
            this.Controls.Add(this.btnGetAllGolfers);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllGolfers;
        private System.Windows.Forms.Button btnAddGolfer;
        private System.Windows.Forms.Button btnUpdateGolfer;
        private System.Windows.Forms.Button btnDeleteGolfer;
        private System.Windows.Forms.ListBox lstGolfers;
        private System.Windows.Forms.TextBox txtGolferId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtHandicap;
    }
}

