
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
            this.txtGolfClubUniqueId = new System.Windows.Forms.TextBox();
            this.txtGolfClubModel = new System.Windows.Forms.TextBox();
            this.txtGolfClubMake = new System.Windows.Forms.TextBox();
            this.txtGolfClubLie = new System.Windows.Forms.TextBox();
            this.txtGolfClubClubID = new System.Windows.Forms.TextBox();
            this.txtGolfClubGolferId = new System.Windows.Forms.TextBox();
            this.lstGolfClubs = new System.Windows.Forms.ListBox();
            this.btnDeleteGolfClub = new System.Windows.Forms.Button();
            this.btnUpdateGolfClub = new System.Windows.Forms.Button();
            this.btnAddGolfClub = new System.Windows.Forms.Button();
            this.btnGetGolfClubs = new System.Windows.Forms.Button();
            this.txtHoleUniqueId = new System.Windows.Forms.TextBox();
            this.txtHoleRating = new System.Windows.Forms.TextBox();
            this.txtHolePar = new System.Windows.Forms.TextBox();
            this.txtHoleYardage = new System.Windows.Forms.TextBox();
            this.txtHoleNumber = new System.Windows.Forms.TextBox();
            this.txtHoleTeeId = new System.Windows.Forms.TextBox();
            this.lstHoles = new System.Windows.Forms.ListBox();
            this.btnDeleteHole = new System.Windows.Forms.Button();
            this.btnUpdateHole = new System.Windows.Forms.Button();
            this.btnAddHole = new System.Windows.Forms.Button();
            this.btnGetHoles = new System.Windows.Forms.Button();
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
            this.btnGetClubType.Location = new System.Drawing.Point(823, 11);
            this.btnGetClubType.Name = "btnGetClubType";
            this.btnGetClubType.Size = new System.Drawing.Size(112, 23);
            this.btnGetClubType.TabIndex = 12;
            this.btnGetClubType.Text = "Get Club Types";
            this.btnGetClubType.UseVisualStyleBackColor = true;
            this.btnGetClubType.Click += new System.EventHandler(this.btnGetClubTypes_Click);
            // 
            // btnAddClubType
            // 
            this.btnAddClubType.Location = new System.Drawing.Point(823, 70);
            this.btnAddClubType.Name = "btnAddClubType";
            this.btnAddClubType.Size = new System.Drawing.Size(112, 23);
            this.btnAddClubType.TabIndex = 13;
            this.btnAddClubType.Text = "Add Club Type";
            this.btnAddClubType.UseVisualStyleBackColor = true;
            this.btnAddClubType.Click += new System.EventHandler(this.btnAddClubType_Click);
            // 
            // btnUpdateClubType
            // 
            this.btnUpdateClubType.Location = new System.Drawing.Point(823, 99);
            this.btnUpdateClubType.Name = "btnUpdateClubType";
            this.btnUpdateClubType.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateClubType.TabIndex = 14;
            this.btnUpdateClubType.Text = "Update Club Type";
            this.btnUpdateClubType.UseVisualStyleBackColor = true;
            this.btnUpdateClubType.Click += new System.EventHandler(this.btnUpdateClubType_Click);
            // 
            // btnDeleteClubType
            // 
            this.btnDeleteClubType.Location = new System.Drawing.Point(823, 128);
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
            this.lstClubType.Location = new System.Drawing.Point(941, 12);
            this.lstClubType.Name = "lstClubType";
            this.lstClubType.Size = new System.Drawing.Size(120, 139);
            this.lstClubType.TabIndex = 16;
            this.lstClubType.SelectedIndexChanged += new System.EventHandler(this.lstClubType_SelectedIndexChanged);
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(1067, 41);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.PlaceholderText = "Club Name";
            this.txtClubName.Size = new System.Drawing.Size(157, 23);
            this.txtClubName.TabIndex = 18;
            // 
            // txtClubUniqueId
            // 
            this.txtClubUniqueId.Enabled = false;
            this.txtClubUniqueId.Location = new System.Drawing.Point(1068, 12);
            this.txtClubUniqueId.Name = "txtClubUniqueId";
            this.txtClubUniqueId.PlaceholderText = "Unique ID";
            this.txtClubUniqueId.Size = new System.Drawing.Size(157, 23);
            this.txtClubUniqueId.TabIndex = 17;
            // 
            // txtPar
            // 
            this.txtPar.Location = new System.Drawing.Point(426, 653);
            this.txtPar.Name = "txtPar";
            this.txtPar.PlaceholderText = "Par";
            this.txtPar.Size = new System.Drawing.Size(157, 23);
            this.txtPar.TabIndex = 27;
            // 
            // txtNumTees
            // 
            this.txtNumTees.Location = new System.Drawing.Point(426, 624);
            this.txtNumTees.Name = "txtNumTees";
            this.txtNumTees.PlaceholderText = "Num Tees";
            this.txtNumTees.Size = new System.Drawing.Size(157, 23);
            this.txtNumTees.TabIndex = 26;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(426, 595);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.PlaceholderText = "Course Name";
            this.txtCourseName.Size = new System.Drawing.Size(157, 23);
            this.txtCourseName.TabIndex = 25;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(427, 566);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.PlaceholderText = "Course ID";
            this.txtCourseID.Size = new System.Drawing.Size(157, 23);
            this.txtCourseID.TabIndex = 24;
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 15;
            this.lstCourses.Location = new System.Drawing.Point(121, 566);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(300, 139);
            this.lstCourses.TabIndex = 23;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(12, 682);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteCourse.TabIndex = 22;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(12, 653);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateCourse.TabIndex = 21;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(12, 624);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(103, 23);
            this.btnAddCourse.TabIndex = 20;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnGetCourses
            // 
            this.btnGetCourses.Location = new System.Drawing.Point(12, 566);
            this.btnGetCourses.Name = "btnGetCourses";
            this.btnGetCourses.Size = new System.Drawing.Size(103, 23);
            this.btnGetCourses.TabIndex = 19;
            this.btnGetCourses.Text = "Get All Courses";
            this.btnGetCourses.UseVisualStyleBackColor = true;
            this.btnGetCourses.Click += new System.EventHandler(this.btnGetCourses_Click);
            // 
            // txtSlope
            // 
            this.txtSlope.Location = new System.Drawing.Point(1068, 683);
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.PlaceholderText = "Slope";
            this.txtSlope.Size = new System.Drawing.Size(157, 23);
            this.txtSlope.TabIndex = 37;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(1068, 654);
            this.txtRating.Name = "txtRating";
            this.txtRating.PlaceholderText = "Rating";
            this.txtRating.Size = new System.Drawing.Size(157, 23);
            this.txtRating.TabIndex = 36;
            // 
            // txtYardage
            // 
            this.txtYardage.Location = new System.Drawing.Point(1068, 625);
            this.txtYardage.Name = "txtYardage";
            this.txtYardage.PlaceholderText = "Yardage";
            this.txtYardage.Size = new System.Drawing.Size(157, 23);
            this.txtYardage.TabIndex = 35;
            // 
            // txtTeeName
            // 
            this.txtTeeName.Location = new System.Drawing.Point(1068, 596);
            this.txtTeeName.Name = "txtTeeName";
            this.txtTeeName.PlaceholderText = "Tee Name";
            this.txtTeeName.Size = new System.Drawing.Size(157, 23);
            this.txtTeeName.TabIndex = 34;
            // 
            // txtTCourseID
            // 
            this.txtTCourseID.Location = new System.Drawing.Point(1069, 567);
            this.txtTCourseID.Name = "txtTCourseID";
            this.txtTCourseID.PlaceholderText = "Course ID";
            this.txtTCourseID.Size = new System.Drawing.Size(157, 23);
            this.txtTCourseID.TabIndex = 33;
            // 
            // lstTeeInformation
            // 
            this.lstTeeInformation.FormattingEnabled = true;
            this.lstTeeInformation.ItemHeight = 15;
            this.lstTeeInformation.Location = new System.Drawing.Point(942, 567);
            this.lstTeeInformation.Name = "lstTeeInformation";
            this.lstTeeInformation.Size = new System.Drawing.Size(120, 139);
            this.lstTeeInformation.TabIndex = 32;
            this.lstTeeInformation.SelectedIndexChanged += new System.EventHandler(this.lstTeeInformation_SelectedIndexChanged);
            // 
            // btnDeleteTeeInfo
            // 
            this.btnDeleteTeeInfo.Location = new System.Drawing.Point(833, 683);
            this.btnDeleteTeeInfo.Name = "btnDeleteTeeInfo";
            this.btnDeleteTeeInfo.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteTeeInfo.TabIndex = 31;
            this.btnDeleteTeeInfo.Text = "Delete Tee Info";
            this.btnDeleteTeeInfo.UseVisualStyleBackColor = true;
            this.btnDeleteTeeInfo.Click += new System.EventHandler(this.btnDeleteTeeInfo_Click);
            // 
            // btnUpdateTeeInfo
            // 
            this.btnUpdateTeeInfo.Location = new System.Drawing.Point(833, 654);
            this.btnUpdateTeeInfo.Name = "btnUpdateTeeInfo";
            this.btnUpdateTeeInfo.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateTeeInfo.TabIndex = 30;
            this.btnUpdateTeeInfo.Text = "Update Tee Info";
            this.btnUpdateTeeInfo.UseVisualStyleBackColor = true;
            this.btnUpdateTeeInfo.Click += new System.EventHandler(this.btnUpdateTeeInfo_Click);
            // 
            // btnAddTeeInfo
            // 
            this.btnAddTeeInfo.Location = new System.Drawing.Point(833, 625);
            this.btnAddTeeInfo.Name = "btnAddTeeInfo";
            this.btnAddTeeInfo.Size = new System.Drawing.Size(103, 23);
            this.btnAddTeeInfo.TabIndex = 29;
            this.btnAddTeeInfo.Text = "Add Tee Info";
            this.btnAddTeeInfo.UseVisualStyleBackColor = true;
            this.btnAddTeeInfo.Click += new System.EventHandler(this.btnAddTeeInfo_Click);
            // 
            // btnGetTeeInformation
            // 
            this.btnGetTeeInformation.Location = new System.Drawing.Point(833, 567);
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
            this.txtUniqueID.Location = new System.Drawing.Point(1067, 538);
            this.txtUniqueID.Name = "txtUniqueID";
            this.txtUniqueID.PlaceholderText = "Unique ID";
            this.txtUniqueID.Size = new System.Drawing.Size(157, 23);
            this.txtUniqueID.TabIndex = 38;
            // 
            // txtGolfClubUniqueId
            // 
            this.txtGolfClubUniqueId.Enabled = false;
            this.txtGolfClubUniqueId.Location = new System.Drawing.Point(248, 229);
            this.txtGolfClubUniqueId.Name = "txtGolfClubUniqueId";
            this.txtGolfClubUniqueId.PlaceholderText = "Unique ID";
            this.txtGolfClubUniqueId.Size = new System.Drawing.Size(157, 23);
            this.txtGolfClubUniqueId.TabIndex = 49;
            // 
            // txtGolfClubModel
            // 
            this.txtGolfClubModel.Location = new System.Drawing.Point(249, 374);
            this.txtGolfClubModel.Name = "txtGolfClubModel";
            this.txtGolfClubModel.PlaceholderText = "Model";
            this.txtGolfClubModel.Size = new System.Drawing.Size(157, 23);
            this.txtGolfClubModel.TabIndex = 48;
            // 
            // txtGolfClubMake
            // 
            this.txtGolfClubMake.Location = new System.Drawing.Point(249, 345);
            this.txtGolfClubMake.Name = "txtGolfClubMake";
            this.txtGolfClubMake.PlaceholderText = "Make";
            this.txtGolfClubMake.Size = new System.Drawing.Size(157, 23);
            this.txtGolfClubMake.TabIndex = 47;
            // 
            // txtGolfClubLie
            // 
            this.txtGolfClubLie.Location = new System.Drawing.Point(249, 316);
            this.txtGolfClubLie.Name = "txtGolfClubLie";
            this.txtGolfClubLie.PlaceholderText = "Lie";
            this.txtGolfClubLie.Size = new System.Drawing.Size(157, 23);
            this.txtGolfClubLie.TabIndex = 46;
            // 
            // txtGolfClubClubID
            // 
            this.txtGolfClubClubID.Location = new System.Drawing.Point(249, 287);
            this.txtGolfClubClubID.Name = "txtGolfClubClubID";
            this.txtGolfClubClubID.PlaceholderText = "Club ID";
            this.txtGolfClubClubID.Size = new System.Drawing.Size(157, 23);
            this.txtGolfClubClubID.TabIndex = 45;
            // 
            // txtGolfClubGolferId
            // 
            this.txtGolfClubGolferId.Location = new System.Drawing.Point(250, 258);
            this.txtGolfClubGolferId.Name = "txtGolfClubGolferId";
            this.txtGolfClubGolferId.PlaceholderText = "Golfer ID";
            this.txtGolfClubGolferId.Size = new System.Drawing.Size(157, 23);
            this.txtGolfClubGolferId.TabIndex = 44;
            // 
            // lstGolfClubs
            // 
            this.lstGolfClubs.FormattingEnabled = true;
            this.lstGolfClubs.ItemHeight = 15;
            this.lstGolfClubs.Location = new System.Drawing.Point(123, 258);
            this.lstGolfClubs.Name = "lstGolfClubs";
            this.lstGolfClubs.Size = new System.Drawing.Size(120, 139);
            this.lstGolfClubs.TabIndex = 43;
            this.lstGolfClubs.SelectedIndexChanged += new System.EventHandler(this.lstGolfClubs_SelectedIndexChanged);
            // 
            // btnDeleteGolfClub
            // 
            this.btnDeleteGolfClub.Location = new System.Drawing.Point(12, 374);
            this.btnDeleteGolfClub.Name = "btnDeleteGolfClub";
            this.btnDeleteGolfClub.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteGolfClub.TabIndex = 42;
            this.btnDeleteGolfClub.Text = "Delete Golf Club";
            this.btnDeleteGolfClub.UseVisualStyleBackColor = true;
            this.btnDeleteGolfClub.Click += new System.EventHandler(this.btnDeleteGolfClub_Click);
            // 
            // btnUpdateGolfClub
            // 
            this.btnUpdateGolfClub.Location = new System.Drawing.Point(7, 345);
            this.btnUpdateGolfClub.Name = "btnUpdateGolfClub";
            this.btnUpdateGolfClub.Size = new System.Drawing.Size(113, 23);
            this.btnUpdateGolfClub.TabIndex = 41;
            this.btnUpdateGolfClub.Text = "Update Golf Club";
            this.btnUpdateGolfClub.UseVisualStyleBackColor = true;
            this.btnUpdateGolfClub.Click += new System.EventHandler(this.btnUpdateGolfClub_Click);
            // 
            // btnAddGolfClub
            // 
            this.btnAddGolfClub.Location = new System.Drawing.Point(12, 316);
            this.btnAddGolfClub.Name = "btnAddGolfClub";
            this.btnAddGolfClub.Size = new System.Drawing.Size(103, 23);
            this.btnAddGolfClub.TabIndex = 40;
            this.btnAddGolfClub.Text = "Add Golf Club";
            this.btnAddGolfClub.UseVisualStyleBackColor = true;
            this.btnAddGolfClub.Click += new System.EventHandler(this.btnAddGolfClub_Click);
            // 
            // btnGetGolfClubs
            // 
            this.btnGetGolfClubs.Location = new System.Drawing.Point(12, 258);
            this.btnGetGolfClubs.Name = "btnGetGolfClubs";
            this.btnGetGolfClubs.Size = new System.Drawing.Size(103, 23);
            this.btnGetGolfClubs.TabIndex = 39;
            this.btnGetGolfClubs.Text = "Get Golf Clubs";
            this.btnGetGolfClubs.UseVisualStyleBackColor = true;
            this.btnGetGolfClubs.Click += new System.EventHandler(this.btnGetGolfClubs_Click);
            // 
            // txtHoleUniqueId
            // 
            this.txtHoleUniqueId.Enabled = false;
            this.txtHoleUniqueId.Location = new System.Drawing.Point(1067, 268);
            this.txtHoleUniqueId.Name = "txtHoleUniqueId";
            this.txtHoleUniqueId.PlaceholderText = "Unique ID";
            this.txtHoleUniqueId.Size = new System.Drawing.Size(157, 23);
            this.txtHoleUniqueId.TabIndex = 60;
            // 
            // txtHoleRating
            // 
            this.txtHoleRating.Location = new System.Drawing.Point(1068, 413);
            this.txtHoleRating.Name = "txtHoleRating";
            this.txtHoleRating.PlaceholderText = "Rating";
            this.txtHoleRating.Size = new System.Drawing.Size(157, 23);
            this.txtHoleRating.TabIndex = 59;
            // 
            // txtHolePar
            // 
            this.txtHolePar.Location = new System.Drawing.Point(1068, 384);
            this.txtHolePar.Name = "txtHolePar";
            this.txtHolePar.PlaceholderText = "Par";
            this.txtHolePar.Size = new System.Drawing.Size(157, 23);
            this.txtHolePar.TabIndex = 58;
            // 
            // txtHoleYardage
            // 
            this.txtHoleYardage.Location = new System.Drawing.Point(1068, 355);
            this.txtHoleYardage.Name = "txtHoleYardage";
            this.txtHoleYardage.PlaceholderText = "Yardage";
            this.txtHoleYardage.Size = new System.Drawing.Size(157, 23);
            this.txtHoleYardage.TabIndex = 57;
            // 
            // txtHoleNumber
            // 
            this.txtHoleNumber.Location = new System.Drawing.Point(1068, 326);
            this.txtHoleNumber.Name = "txtHoleNumber";
            this.txtHoleNumber.PlaceholderText = "Hole Number";
            this.txtHoleNumber.Size = new System.Drawing.Size(157, 23);
            this.txtHoleNumber.TabIndex = 56;
            // 
            // txtHoleTeeId
            // 
            this.txtHoleTeeId.Location = new System.Drawing.Point(1069, 297);
            this.txtHoleTeeId.Name = "txtHoleTeeId";
            this.txtHoleTeeId.PlaceholderText = "Tee ID";
            this.txtHoleTeeId.Size = new System.Drawing.Size(157, 23);
            this.txtHoleTeeId.TabIndex = 55;
            // 
            // lstHoles
            // 
            this.lstHoles.FormattingEnabled = true;
            this.lstHoles.ItemHeight = 15;
            this.lstHoles.Location = new System.Drawing.Point(942, 297);
            this.lstHoles.Name = "lstHoles";
            this.lstHoles.Size = new System.Drawing.Size(120, 139);
            this.lstHoles.TabIndex = 54;
            this.lstHoles.SelectedIndexChanged += new System.EventHandler(this.lstHoles_SelectedIndexChanged);
            // 
            // btnDeleteHole
            // 
            this.btnDeleteHole.Location = new System.Drawing.Point(833, 413);
            this.btnDeleteHole.Name = "btnDeleteHole";
            this.btnDeleteHole.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteHole.TabIndex = 53;
            this.btnDeleteHole.Text = "Delete Hole";
            this.btnDeleteHole.UseVisualStyleBackColor = true;
            this.btnDeleteHole.Click += new System.EventHandler(this.btnDeleteHole_Click);
            // 
            // btnUpdateHole
            // 
            this.btnUpdateHole.Location = new System.Drawing.Point(833, 384);
            this.btnUpdateHole.Name = "btnUpdateHole";
            this.btnUpdateHole.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateHole.TabIndex = 52;
            this.btnUpdateHole.Text = "Update Hole";
            this.btnUpdateHole.UseVisualStyleBackColor = true;
            this.btnUpdateHole.Click += new System.EventHandler(this.btnUpdateHole_Click);
            // 
            // btnAddHole
            // 
            this.btnAddHole.Location = new System.Drawing.Point(833, 355);
            this.btnAddHole.Name = "btnAddHole";
            this.btnAddHole.Size = new System.Drawing.Size(103, 23);
            this.btnAddHole.TabIndex = 51;
            this.btnAddHole.Text = "Add Hole";
            this.btnAddHole.UseVisualStyleBackColor = true;
            this.btnAddHole.Click += new System.EventHandler(this.btnAddHole_Click);
            // 
            // btnGetHoles
            // 
            this.btnGetHoles.Location = new System.Drawing.Point(833, 297);
            this.btnGetHoles.Name = "btnGetHoles";
            this.btnGetHoles.Size = new System.Drawing.Size(103, 23);
            this.btnGetHoles.TabIndex = 50;
            this.btnGetHoles.Text = "Get Holes";
            this.btnGetHoles.UseVisualStyleBackColor = true;
            this.btnGetHoles.Click += new System.EventHandler(this.btnGetHoles_Click);
            // 
            // frmGolfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 718);
            this.Controls.Add(this.txtHoleUniqueId);
            this.Controls.Add(this.txtHoleRating);
            this.Controls.Add(this.txtHolePar);
            this.Controls.Add(this.txtHoleYardage);
            this.Controls.Add(this.txtHoleNumber);
            this.Controls.Add(this.txtHoleTeeId);
            this.Controls.Add(this.lstHoles);
            this.Controls.Add(this.btnDeleteHole);
            this.Controls.Add(this.btnUpdateHole);
            this.Controls.Add(this.btnAddHole);
            this.Controls.Add(this.btnGetHoles);
            this.Controls.Add(this.txtGolfClubUniqueId);
            this.Controls.Add(this.txtGolfClubModel);
            this.Controls.Add(this.txtGolfClubMake);
            this.Controls.Add(this.txtGolfClubLie);
            this.Controls.Add(this.txtGolfClubClubID);
            this.Controls.Add(this.txtGolfClubGolferId);
            this.Controls.Add(this.lstGolfClubs);
            this.Controls.Add(this.btnDeleteGolfClub);
            this.Controls.Add(this.btnUpdateGolfClub);
            this.Controls.Add(this.btnAddGolfClub);
            this.Controls.Add(this.btnGetGolfClubs);
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
        private System.Windows.Forms.TextBox txtGolfClubUniqueId;
        private System.Windows.Forms.TextBox txtGolfClubModel;
        private System.Windows.Forms.TextBox txtGolfClubMake;
        private System.Windows.Forms.TextBox txtGolfClubLie;
        private System.Windows.Forms.TextBox txtGolfClubClubID;
        private System.Windows.Forms.TextBox txtGolfClubGolferId;
        private System.Windows.Forms.ListBox lstGolfClubs;
        private System.Windows.Forms.Button btnDeleteGolfClub;
        private System.Windows.Forms.Button btnUpdateGolfClub;
        private System.Windows.Forms.Button btnAddGolfClub;
        private System.Windows.Forms.Button btnGetGolfClubs;
        private System.Windows.Forms.TextBox txtHoleUniqueId;
        private System.Windows.Forms.TextBox txtHoleRating;
        private System.Windows.Forms.TextBox txtHolePar;
        private System.Windows.Forms.TextBox txtHoleYardage;
        private System.Windows.Forms.TextBox txtHoleNumber;
        private System.Windows.Forms.TextBox txtHoleTeeId;
        private System.Windows.Forms.ListBox lstHoles;
        private System.Windows.Forms.Button btnDeleteHole;
        private System.Windows.Forms.Button btnUpdateHole;
        private System.Windows.Forms.Button btnAddHole;
        private System.Windows.Forms.Button btnGetHoles;
    }
}

