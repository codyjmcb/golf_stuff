
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
            this.btnGetClubType = new System.Windows.Forms.Button();
            this.btnAddClubType = new System.Windows.Forms.Button();
            this.btnUpdateClubType = new System.Windows.Forms.Button();
            this.btnDeleteClubType = new System.Windows.Forms.Button();
            this.lstClubType = new System.Windows.Forms.ListBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.txtClubUniqueId = new System.Windows.Forms.TextBox();
            this.txtPar = new System.Windows.Forms.TextBox();
            this.txtNumTees = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnGetCourses = new System.Windows.Forms.Button();
            this.txtSlope = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtYardage = new System.Windows.Forms.TextBox();
            this.txtTeeName = new System.Windows.Forms.TextBox();
            this.txtTCourseID = new System.Windows.Forms.TextBox();
            this.lstTeeInformation = new System.Windows.Forms.ListBox();
            this.btnDeleteTeeInfo = new System.Windows.Forms.Button();
            this.btnUpdateTeeInfo = new System.Windows.Forms.Button();
            this.btnAddTeeInfo = new System.Windows.Forms.Button();
            this.btnGetTeeInformation = new System.Windows.Forms.Button();
            this.txtUniqueID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetAllGolfers
            // 
            this.btnGetAllGolfers.Location = new System.Drawing.Point(12, 12);
            this.btnGetAllGolfers.Name = "btnGetAllGolfers";
            this.btnGetAllGolfers.Size = new System.Drawing.Size(103, 23);
            this.btnGetAllGolfers.TabIndex = 0;
            this.btnGetAllGolfers.Text = "Get All Golfers";
            this.btnGetAllGolfers.UseVisualStyleBackColor = true;
            this.btnGetAllGolfers.Click += new System.EventHandler(this.btnGetAllGolfers_Click);
            // 
            // btnAddGolfer
            // 
            this.btnAddGolfer.Location = new System.Drawing.Point(12, 70);
            this.btnAddGolfer.Name = "btnAddGolfer";
            this.btnAddGolfer.Size = new System.Drawing.Size(103, 23);
            this.btnAddGolfer.TabIndex = 2;
            this.btnAddGolfer.Text = "Add Golfer";
            this.btnAddGolfer.UseVisualStyleBackColor = true;
            this.btnAddGolfer.Click += new System.EventHandler(this.btnAddGolfer_Click);
            // 
            // btnUpdateGolfer
            // 
            this.btnUpdateGolfer.Location = new System.Drawing.Point(12, 99);
            this.btnUpdateGolfer.Name = "btnUpdateGolfer";
            this.btnUpdateGolfer.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateGolfer.TabIndex = 3;
            this.btnUpdateGolfer.Text = "Update Golfer";
            this.btnUpdateGolfer.UseVisualStyleBackColor = true;
            this.btnUpdateGolfer.Click += new System.EventHandler(this.btnUpdateGolfer_Click);
            // 
            // btnDeleteGolfer
            // 
            this.btnDeleteGolfer.Location = new System.Drawing.Point(12, 128);
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
            this.lstGolfers.Location = new System.Drawing.Point(121, 12);
            this.lstGolfers.Name = "lstGolfers";
            this.lstGolfers.Size = new System.Drawing.Size(120, 139);
            this.lstGolfers.TabIndex = 6;
            this.lstGolfers.SelectedIndexChanged += new System.EventHandler(this.lstGolfers_SelectedIndexChanged);
            // 
            // txtGolferId
            // 
            this.txtGolferId.Location = new System.Drawing.Point(248, 12);
            this.txtGolferId.Name = "txtGolferId";
            this.txtGolferId.PlaceholderText = "Golfer Id";
            this.txtGolferId.Size = new System.Drawing.Size(157, 23);
            this.txtGolferId.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(247, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(157, 23);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(247, 70);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.PlaceholderText = "Middle Initial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(157, 23);
            this.txtMiddleInitial.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(247, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(157, 23);
            this.txtLastName.TabIndex = 10;
            // 
            // txtHandicap
            // 
            this.txtHandicap.Location = new System.Drawing.Point(247, 128);
            this.txtHandicap.Name = "txtHandicap";
            this.txtHandicap.PlaceholderText = "Handicap";
            this.txtHandicap.Size = new System.Drawing.Size(157, 23);
            this.txtHandicap.TabIndex = 11;
            // 
            // btnGetClubType
            // 
            this.btnGetClubType.Location = new System.Drawing.Point(596, 11);
            this.btnGetClubType.Name = "btnGetClubType";
            this.btnGetClubType.Size = new System.Drawing.Size(112, 23);
            this.btnGetClubType.TabIndex = 12;
            this.btnGetClubType.Text = "Get Club Types";
            this.btnGetClubType.UseVisualStyleBackColor = true;
            this.btnGetClubType.Click += new System.EventHandler(this.btnGetClubTypes_Click);
            // 
            // btnAddClubType
            // 
            this.btnAddClubType.Location = new System.Drawing.Point(596, 70);
            this.btnAddClubType.Name = "btnAddClubType";
            this.btnAddClubType.Size = new System.Drawing.Size(112, 23);
            this.btnAddClubType.TabIndex = 13;
            this.btnAddClubType.Text = "Add Club Type";
            this.btnAddClubType.UseVisualStyleBackColor = true;
            this.btnAddClubType.Click += new System.EventHandler(this.btnAddClubType_Click);
            // 
            // btnUpdateClubType
            // 
            this.btnUpdateClubType.Location = new System.Drawing.Point(596, 99);
            this.btnUpdateClubType.Name = "btnUpdateClubType";
            this.btnUpdateClubType.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateClubType.TabIndex = 14;
            this.btnUpdateClubType.Text = "Update Club Type";
            this.btnUpdateClubType.UseVisualStyleBackColor = true;
            this.btnUpdateClubType.Click += new System.EventHandler(this.btnUpdateClubType_Click);
            // 
            // btnDeleteClubType
            // 
            this.btnDeleteClubType.Location = new System.Drawing.Point(596, 128);
            this.btnDeleteClubType.Name = "btnDeleteClubType";
            this.btnDeleteClubType.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteClubType.TabIndex = 15;
            this.btnDeleteClubType.Text = "Delete Club Type";
            this.btnDeleteClubType.UseVisualStyleBackColor = true;
            this.btnDeleteClubType.Click += new System.EventHandler(this.btnDeleteClubType_Click);
            // 
            // lstClubType
            // 
            this.lstClubType.FormattingEnabled = true;
            this.lstClubType.ItemHeight = 15;
            this.lstClubType.Location = new System.Drawing.Point(714, 12);
            this.lstClubType.Name = "lstClubType";
            this.lstClubType.Size = new System.Drawing.Size(120, 139);
            this.lstClubType.TabIndex = 16;
            this.lstClubType.SelectedIndexChanged += new System.EventHandler(this.lstClubType_SelectedIndexChanged);
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(840, 41);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.PlaceholderText = "Club Name";
            this.txtClubName.Size = new System.Drawing.Size(157, 23);
            this.txtClubName.TabIndex = 18;
            // 
            // txtClubUniqueId
            // 
            this.txtClubUniqueId.Enabled = false;
            this.txtClubUniqueId.Location = new System.Drawing.Point(841, 12);
            this.txtClubUniqueId.Name = "txtClubUniqueId";
            this.txtClubUniqueId.PlaceholderText = "Unique ID";
            this.txtClubUniqueId.Size = new System.Drawing.Size(157, 23);
            this.txtClubUniqueId.TabIndex = 17;
            // 
            // txtPar
            // 
            this.txtPar.Location = new System.Drawing.Point(426, 528);
            this.txtPar.Name = "txtPar";
            this.txtPar.PlaceholderText = "Par";
            this.txtPar.Size = new System.Drawing.Size(157, 23);
            this.txtPar.TabIndex = 27;
            // 
            // txtNumTees
            // 
            this.txtNumTees.Location = new System.Drawing.Point(426, 499);
            this.txtNumTees.Name = "txtNumTees";
            this.txtNumTees.PlaceholderText = "Num Tees";
            this.txtNumTees.Size = new System.Drawing.Size(157, 23);
            this.txtNumTees.TabIndex = 26;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(426, 470);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.PlaceholderText = "Course Name";
            this.txtCourseName.Size = new System.Drawing.Size(157, 23);
            this.txtCourseName.TabIndex = 25;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(427, 441);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.PlaceholderText = "Course ID";
            this.txtCourseID.Size = new System.Drawing.Size(157, 23);
            this.txtCourseID.TabIndex = 24;
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 15;
            this.lstCourses.Location = new System.Drawing.Point(121, 441);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(300, 139);
            this.lstCourses.TabIndex = 23;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(12, 557);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteCourse.TabIndex = 22;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(12, 528);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateCourse.TabIndex = 21;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(12, 499);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(103, 23);
            this.btnAddCourse.TabIndex = 20;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnGetCourses
            // 
            this.btnGetCourses.Location = new System.Drawing.Point(12, 441);
            this.btnGetCourses.Name = "btnGetCourses";
            this.btnGetCourses.Size = new System.Drawing.Size(103, 23);
            this.btnGetCourses.TabIndex = 19;
            this.btnGetCourses.Text = "Get All Courses";
            this.btnGetCourses.UseVisualStyleBackColor = true;
            this.btnGetCourses.Click += new System.EventHandler(this.btnGetCourses_Click);
            // 
            // txtSlope
            // 
            this.txtSlope.Location = new System.Drawing.Point(841, 557);
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.PlaceholderText = "Slope";
            this.txtSlope.Size = new System.Drawing.Size(157, 23);
            this.txtSlope.TabIndex = 37;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(841, 528);
            this.txtRating.Name = "txtRating";
            this.txtRating.PlaceholderText = "Rating";
            this.txtRating.Size = new System.Drawing.Size(157, 23);
            this.txtRating.TabIndex = 36;
            // 
            // txtYardage
            // 
            this.txtYardage.Location = new System.Drawing.Point(841, 499);
            this.txtYardage.Name = "txtYardage";
            this.txtYardage.PlaceholderText = "Yardage";
            this.txtYardage.Size = new System.Drawing.Size(157, 23);
            this.txtYardage.TabIndex = 35;
            // 
            // txtTeeName
            // 
            this.txtTeeName.Location = new System.Drawing.Point(841, 470);
            this.txtTeeName.Name = "txtTeeName";
            this.txtTeeName.PlaceholderText = "Tee Name";
            this.txtTeeName.Size = new System.Drawing.Size(157, 23);
            this.txtTeeName.TabIndex = 34;
            // 
            // txtTCourseID
            // 
            this.txtTCourseID.Location = new System.Drawing.Point(842, 441);
            this.txtTCourseID.Name = "txtTCourseID";
            this.txtTCourseID.PlaceholderText = "Course ID";
            this.txtTCourseID.Size = new System.Drawing.Size(157, 23);
            this.txtTCourseID.TabIndex = 33;
            // 
            // lstTeeInformation
            // 
            this.lstTeeInformation.FormattingEnabled = true;
            this.lstTeeInformation.ItemHeight = 15;
            this.lstTeeInformation.Location = new System.Drawing.Point(715, 441);
            this.lstTeeInformation.Name = "lstTeeInformation";
            this.lstTeeInformation.Size = new System.Drawing.Size(120, 139);
            this.lstTeeInformation.TabIndex = 32;
            this.lstTeeInformation.SelectedIndexChanged += new System.EventHandler(this.lstTeeInformation_SelectedIndexChanged);
            // 
            // btnDeleteTeeInfo
            // 
            this.btnDeleteTeeInfo.Location = new System.Drawing.Point(606, 557);
            this.btnDeleteTeeInfo.Name = "btnDeleteTeeInfo";
            this.btnDeleteTeeInfo.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteTeeInfo.TabIndex = 31;
            this.btnDeleteTeeInfo.Text = "Delete Tee Info";
            this.btnDeleteTeeInfo.UseVisualStyleBackColor = true;
            this.btnDeleteTeeInfo.Click += new System.EventHandler(this.btnDeleteTeeInfo_Click);
            // 
            // btnUpdateTeeInfo
            // 
            this.btnUpdateTeeInfo.Location = new System.Drawing.Point(606, 528);
            this.btnUpdateTeeInfo.Name = "btnUpdateTeeInfo";
            this.btnUpdateTeeInfo.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateTeeInfo.TabIndex = 30;
            this.btnUpdateTeeInfo.Text = "Update Tee Info";
            this.btnUpdateTeeInfo.UseVisualStyleBackColor = true;
            this.btnUpdateTeeInfo.Click += new System.EventHandler(this.btnUpdateTeeInfo_Click);
            // 
            // btnAddTeeInfo
            // 
            this.btnAddTeeInfo.Location = new System.Drawing.Point(606, 499);
            this.btnAddTeeInfo.Name = "btnAddTeeInfo";
            this.btnAddTeeInfo.Size = new System.Drawing.Size(103, 23);
            this.btnAddTeeInfo.TabIndex = 29;
            this.btnAddTeeInfo.Text = "Add Tee Info";
            this.btnAddTeeInfo.UseVisualStyleBackColor = true;
            this.btnAddTeeInfo.Click += new System.EventHandler(this.btnAddTeeInfo_Click);
            // 
            // btnGetTeeInformation
            // 
            this.btnGetTeeInformation.Location = new System.Drawing.Point(606, 441);
            this.btnGetTeeInformation.Name = "btnGetTeeInformation";
            this.btnGetTeeInformation.Size = new System.Drawing.Size(103, 23);
            this.btnGetTeeInformation.TabIndex = 28;
            this.btnGetTeeInformation.Text = "Get Tee Info";
            this.btnGetTeeInformation.UseVisualStyleBackColor = true;
            this.btnGetTeeInformation.Click += new System.EventHandler(this.btnGetTeeInformation_Click);
            // 
            // txtUniqueID
            // 
            this.txtUniqueID.Enabled = false;
            this.txtUniqueID.Location = new System.Drawing.Point(840, 412);
            this.txtUniqueID.Name = "txtUniqueID";
            this.txtUniqueID.PlaceholderText = "Unique ID";
            this.txtUniqueID.Size = new System.Drawing.Size(157, 23);
            this.txtUniqueID.TabIndex = 38;
            // 
            // frmGolfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 592);
            this.Controls.Add(this.txtUniqueID);
            this.Controls.Add(this.txtSlope);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtYardage);
            this.Controls.Add(this.txtTeeName);
            this.Controls.Add(this.txtTCourseID);
            this.Controls.Add(this.lstTeeInformation);
            this.Controls.Add(this.btnDeleteTeeInfo);
            this.Controls.Add(this.btnUpdateTeeInfo);
            this.Controls.Add(this.btnAddTeeInfo);
            this.Controls.Add(this.btnGetTeeInformation);
            this.Controls.Add(this.txtPar);
            this.Controls.Add(this.txtNumTees);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnGetCourses);
            this.Controls.Add(this.txtClubName);
            this.Controls.Add(this.txtClubUniqueId);
            this.Controls.Add(this.lstClubType);
            this.Controls.Add(this.btnDeleteClubType);
            this.Controls.Add(this.btnUpdateClubType);
            this.Controls.Add(this.btnAddClubType);
            this.Controls.Add(this.btnGetClubType);
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
            this.Name = "frmGolfer";
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
        private System.Windows.Forms.Button btnGetClubType;
        private System.Windows.Forms.Button btnAddClubType;
        private System.Windows.Forms.Button btnUpdateClubType;
        private System.Windows.Forms.Button btnDeleteClubType;
        private System.Windows.Forms.ListBox lstClubType;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.TextBox txtClubUniqueId;
        private System.Windows.Forms.TextBox txtPar;
        private System.Windows.Forms.TextBox txtNumTees;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnGetCourses;
        private System.Windows.Forms.TextBox txtSlope;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtYardage;
        private System.Windows.Forms.TextBox txtTeeName;
        private System.Windows.Forms.TextBox txtTCourseID;
        private System.Windows.Forms.ListBox lstTeeInformation;
        private System.Windows.Forms.Button btnDeleteTeeInfo;
        private System.Windows.Forms.Button btnUpdateTeeInfo;
        private System.Windows.Forms.Button btnAddTeeInfo;
        private System.Windows.Forms.Button btnGetTeeInformation;
        private System.Windows.Forms.TextBox txtUniqueID;
    }
}

