namespace EventScheduleUI
{
    partial class Tabs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabTab = new System.Windows.Forms.TabControl();
            this.tabFull = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.dgvFullView = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageRequirement2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTeaser = new System.Windows.Forms.TabPage();
            this.dgvTeaser = new System.Windows.Forms.DataGridView();
            this.TeaserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaserLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaserDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaserCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabListView = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.chkAge = new System.Windows.Forms.CheckBox();
            this.dgvListView = new System.Windows.Forms.DataGridView();
            this.btnViewSelection = new System.Windows.Forms.Button();
            this.chkEndDate = new System.Windows.Forms.CheckBox();
            this.chkStartDate = new System.Windows.Forms.CheckBox();
            this.chkLocation = new System.Windows.Forms.CheckBox();
            this.chkEventName = new System.Windows.Forms.CheckBox();
            this.chkEndTime = new System.Windows.Forms.CheckBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.chkNotes = new System.Windows.Forms.CheckBox();
            this.chkDescription = new System.Windows.Forms.CheckBox();
            this.chkStartTime = new System.Windows.Forms.CheckBox();
            this.chkRegisteredMaxAttendees = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPaticipantsView = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvParticipantView = new System.Windows.Forms.DataGridView();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project1DataSet = new EventScheduleUI.Project1DataSet();
            this.eventsTableAdapter = new EventScheduleUI.Project1DataSetTableAdapters.EventsTableAdapter();
            this.project1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Logout = new System.Windows.Forms.Button();
            this.tabTab.SuspendLayout();
            this.tabFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullView)).BeginInit();
            this.tabTeaser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeaser)).BeginInit();
            this.tabListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListView)).BeginInit();
            this.tabPaticipantsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTab
            // 
            this.tabTab.Controls.Add(this.tabFull);
            this.tabTab.Controls.Add(this.tabTeaser);
            this.tabTab.Controls.Add(this.tabListView);
            this.tabTab.Controls.Add(this.tabPaticipantsView);
            this.tabTab.Location = new System.Drawing.Point(25, 12);
            this.tabTab.Name = "tabTab";
            this.tabTab.SelectedIndex = 0;
            this.tabTab.Size = new System.Drawing.Size(1534, 565);
            this.tabTab.TabIndex = 0;
            this.tabTab.Enter += new System.EventHandler(this.tabTab_Enter);
            // 
            // tabFull
            // 
            this.tabFull.Controls.Add(this.label2);
            this.tabFull.Controls.Add(this.btnRegister);
            this.tabFull.Controls.Add(this.txtEventID);
            this.tabFull.Controls.Add(this.dgvFullView);
            this.tabFull.Location = new System.Drawing.Point(4, 22);
            this.tabFull.Name = "tabFull";
            this.tabFull.Padding = new System.Windows.Forms.Padding(3);
            this.tabFull.Size = new System.Drawing.Size(1526, 539);
            this.tabFull.TabIndex = 0;
            this.tabFull.Text = "Full View";
            this.tabFull.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(92, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please enter the EventID you want to register for:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegister.Location = new System.Drawing.Point(560, 492);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 40);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtEventID
            // 
            this.txtEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEventID.Location = new System.Drawing.Point(454, 495);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(100, 26);
            this.txtEventID.TabIndex = 2;
            // 
            // dgvFullView
            // 
            this.dgvFullView.AllowUserToAddRows = false;
            this.dgvFullView.AllowUserToDeleteRows = false;
            this.dgvFullView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFullView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.Location,
            this.Status,
            this.StartDate,
            this.EndDate,
            this.StartTime,
            this.EndTime,
            this.ageRequirement2,
            this.Attendees,
            this.Notes,
            this.Description});
            this.dgvFullView.Location = new System.Drawing.Point(-29, 6);
            this.dgvFullView.Name = "dgvFullView";
            this.dgvFullView.ReadOnly = true;
            this.dgvFullView.Size = new System.Drawing.Size(1549, 471);
            this.dgvFullView.TabIndex = 1;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event Name";
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Width = 200;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 75;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 75;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            // 
            // ageRequirement2
            // 
            this.ageRequirement2.HeaderText = "Age Requirement";
            this.ageRequirement2.Name = "ageRequirement2";
            this.ageRequirement2.ReadOnly = true;
            // 
            // Attendees
            // 
            this.Attendees.HeaderText = "Max  Attendees";
            this.Attendees.Name = "Attendees";
            this.Attendees.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 400;
            // 
            // tabTeaser
            // 
            this.tabTeaser.Controls.Add(this.dgvTeaser);
            this.tabTeaser.Location = new System.Drawing.Point(4, 22);
            this.tabTeaser.Name = "tabTeaser";
            this.tabTeaser.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeaser.Size = new System.Drawing.Size(1526, 539);
            this.tabTeaser.TabIndex = 1;
            this.tabTeaser.Text = "Teaser View";
            this.tabTeaser.UseVisualStyleBackColor = true;
            // 
            // dgvTeaser
            // 
            this.dgvTeaser.AllowUserToAddRows = false;
            this.dgvTeaser.AllowUserToDeleteRows = false;
            this.dgvTeaser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeaser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeaserName,
            this.TeaserLocation,
            this.TeaserDate,
            this.TeaserCategory});
            this.dgvTeaser.Location = new System.Drawing.Point(6, 0);
            this.dgvTeaser.Name = "dgvTeaser";
            this.dgvTeaser.ReadOnly = true;
            this.dgvTeaser.Size = new System.Drawing.Size(1211, 533);
            this.dgvTeaser.TabIndex = 0;
            // 
            // TeaserName
            // 
            this.TeaserName.HeaderText = "Event Name";
            this.TeaserName.Name = "TeaserName";
            this.TeaserName.ReadOnly = true;
            this.TeaserName.Width = 280;
            // 
            // TeaserLocation
            // 
            this.TeaserLocation.HeaderText = "Location";
            this.TeaserLocation.Name = "TeaserLocation";
            this.TeaserLocation.ReadOnly = true;
            this.TeaserLocation.Width = 280;
            // 
            // TeaserDate
            // 
            this.TeaserDate.HeaderText = "Date";
            this.TeaserDate.Name = "TeaserDate";
            this.TeaserDate.ReadOnly = true;
            this.TeaserDate.Width = 280;
            // 
            // TeaserCategory
            // 
            this.TeaserCategory.HeaderText = "Category";
            this.TeaserCategory.Name = "TeaserCategory";
            this.TeaserCategory.ReadOnly = true;
            this.TeaserCategory.Width = 280;
            // 
            // tabListView
            // 
            this.tabListView.Controls.Add(this.label3);
            this.tabListView.Controls.Add(this.btnUpdateList);
            this.tabListView.Controls.Add(this.chkAge);
            this.tabListView.Controls.Add(this.dgvListView);
            this.tabListView.Controls.Add(this.btnViewSelection);
            this.tabListView.Controls.Add(this.chkEndDate);
            this.tabListView.Controls.Add(this.chkStartDate);
            this.tabListView.Controls.Add(this.chkLocation);
            this.tabListView.Controls.Add(this.chkEventName);
            this.tabListView.Controls.Add(this.chkEndTime);
            this.tabListView.Controls.Add(this.chkStatus);
            this.tabListView.Controls.Add(this.chkNotes);
            this.tabListView.Controls.Add(this.chkDescription);
            this.tabListView.Controls.Add(this.chkStartTime);
            this.tabListView.Controls.Add(this.chkRegisteredMaxAttendees);
            this.tabListView.Controls.Add(this.label1);
            this.tabListView.Location = new System.Drawing.Point(4, 22);
            this.tabListView.Name = "tabListView";
            this.tabListView.Padding = new System.Windows.Forms.Padding(3);
            this.tabListView.Size = new System.Drawing.Size(1526, 539);
            this.tabListView.TabIndex = 2;
            this.tabListView.Text = "List View";
            this.tabListView.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(11, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "*Event ID, Private, Closed, and CategoryID are shown by default";
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnUpdateList.Location = new System.Drawing.Point(964, 368);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(190, 63);
            this.btnUpdateList.TabIndex = 14;
            this.btnUpdateList.Text = "Update";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Visible = false;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // chkAge
            // 
            this.chkAge.AutoSize = true;
            this.chkAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAge.Location = new System.Drawing.Point(674, 30);
            this.chkAge.Name = "chkAge";
            this.chkAge.Size = new System.Drawing.Size(140, 22);
            this.chkAge.TabIndex = 13;
            this.chkAge.Text = "Age Requirement";
            this.chkAge.UseVisualStyleBackColor = true;
            // 
            // dgvListView
            // 
            this.dgvListView.AllowUserToOrderColumns = true;
            this.dgvListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListView.Location = new System.Drawing.Point(29, 69);
            this.dgvListView.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListView.Name = "dgvListView";
            this.dgvListView.RowTemplate.Height = 28;
            this.dgvListView.Size = new System.Drawing.Size(1397, 251);
            this.dgvListView.TabIndex = 12;
            this.dgvListView.Visible = false;
            // 
            // btnViewSelection
            // 
            this.btnViewSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnViewSelection.Location = new System.Drawing.Point(548, 368);
            this.btnViewSelection.Name = "btnViewSelection";
            this.btnViewSelection.Size = new System.Drawing.Size(339, 63);
            this.btnViewSelection.TabIndex = 11;
            this.btnViewSelection.Text = "View Selection";
            this.btnViewSelection.UseVisualStyleBackColor = true;
            this.btnViewSelection.Click += new System.EventHandler(this.btnViewSelection_Click);
            // 
            // chkEndDate
            // 
            this.chkEndDate.AutoSize = true;
            this.chkEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEndDate.Location = new System.Drawing.Point(383, 30);
            this.chkEndDate.Name = "chkEndDate";
            this.chkEndDate.Size = new System.Drawing.Size(88, 22);
            this.chkEndDate.TabIndex = 10;
            this.chkEndDate.Text = "End Date";
            this.chkEndDate.UseVisualStyleBackColor = true;
            // 
            // chkStartDate
            // 
            this.chkStartDate.AutoSize = true;
            this.chkStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStartDate.Location = new System.Drawing.Point(284, 30);
            this.chkStartDate.Name = "chkStartDate";
            this.chkStartDate.Size = new System.Drawing.Size(93, 22);
            this.chkStartDate.TabIndex = 9;
            this.chkStartDate.Text = "Start Date";
            this.chkStartDate.UseVisualStyleBackColor = true;
            // 
            // chkLocation
            // 
            this.chkLocation.AutoSize = true;
            this.chkLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLocation.Location = new System.Drawing.Point(119, 30);
            this.chkLocation.Name = "chkLocation";
            this.chkLocation.Size = new System.Drawing.Size(84, 22);
            this.chkLocation.TabIndex = 8;
            this.chkLocation.Text = "Location";
            this.chkLocation.UseVisualStyleBackColor = true;
            // 
            // chkEventName
            // 
            this.chkEventName.AutoSize = true;
            this.chkEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEventName.Location = new System.Drawing.Point(5, 30);
            this.chkEventName.Name = "chkEventName";
            this.chkEventName.Size = new System.Drawing.Size(108, 22);
            this.chkEventName.TabIndex = 7;
            this.chkEventName.Text = "Event Name";
            this.chkEventName.UseVisualStyleBackColor = true;
            // 
            // chkEndTime
            // 
            this.chkEndTime.AutoSize = true;
            this.chkEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEndTime.Location = new System.Drawing.Point(578, 30);
            this.chkEndTime.Name = "chkEndTime";
            this.chkEndTime.Size = new System.Drawing.Size(90, 22);
            this.chkEndTime.TabIndex = 6;
            this.chkEndTime.Text = "End Time";
            this.chkEndTime.UseVisualStyleBackColor = true;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStatus.Location = new System.Drawing.Point(209, 30);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(69, 22);
            this.chkStatus.TabIndex = 5;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // chkNotes
            // 
            this.chkNotes.AutoSize = true;
            this.chkNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotes.Location = new System.Drawing.Point(820, 30);
            this.chkNotes.Name = "chkNotes";
            this.chkNotes.Size = new System.Drawing.Size(67, 22);
            this.chkNotes.TabIndex = 4;
            this.chkNotes.Text = "Notes";
            this.chkNotes.UseVisualStyleBackColor = true;
            // 
            // chkDescription
            // 
            this.chkDescription.AutoSize = true;
            this.chkDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescription.Location = new System.Drawing.Point(893, 30);
            this.chkDescription.Name = "chkDescription";
            this.chkDescription.Size = new System.Drawing.Size(102, 22);
            this.chkDescription.TabIndex = 3;
            this.chkDescription.Text = "Description";
            this.chkDescription.UseVisualStyleBackColor = true;
            // 
            // chkStartTime
            // 
            this.chkStartTime.AutoSize = true;
            this.chkStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStartTime.Location = new System.Drawing.Point(477, 30);
            this.chkStartTime.Name = "chkStartTime";
            this.chkStartTime.Size = new System.Drawing.Size(95, 22);
            this.chkStartTime.TabIndex = 2;
            this.chkStartTime.Text = "Start Time";
            this.chkStartTime.UseVisualStyleBackColor = true;
            // 
            // chkRegisteredMaxAttendees
            // 
            this.chkRegisteredMaxAttendees.AutoSize = true;
            this.chkRegisteredMaxAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRegisteredMaxAttendees.Location = new System.Drawing.Point(1001, 30);
            this.chkRegisteredMaxAttendees.Name = "chkRegisteredMaxAttendees";
            this.chkRegisteredMaxAttendees.Size = new System.Drawing.Size(124, 22);
            this.chkRegisteredMaxAttendees.TabIndex = 1;
            this.chkRegisteredMaxAttendees.Text = "Max Attendees";
            this.chkRegisteredMaxAttendees.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to see?*";
            // 
            // tabPaticipantsView
            // 
            this.tabPaticipantsView.Controls.Add(this.btnUpdate);
            this.tabPaticipantsView.Controls.Add(this.dgvParticipantView);
            this.tabPaticipantsView.Location = new System.Drawing.Point(4, 22);
            this.tabPaticipantsView.Name = "tabPaticipantsView";
            this.tabPaticipantsView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaticipantsView.Size = new System.Drawing.Size(1526, 539);
            this.tabPaticipantsView.TabIndex = 3;
            this.tabPaticipantsView.Text = "Participants View";
            this.tabPaticipantsView.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnUpdate.Location = new System.Drawing.Point(6, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 63);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvParticipantView
            // 
            this.dgvParticipantView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantView.Location = new System.Drawing.Point(6, 3);
            this.dgvParticipantView.Name = "dgvParticipantView";
            this.dgvParticipantView.Size = new System.Drawing.Size(659, 235);
            this.dgvParticipantView.TabIndex = 0;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.project1DataSet;
            // 
            // project1DataSet
            // 
            this.project1DataSet.DataSetName = "Project1DataSet";
            this.project1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // project1DataSetBindingSource
            // 
            this.project1DataSetBindingSource.DataSource = this.project1DataSet;
            this.project1DataSetBindingSource.Position = 0;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Red;
            this.Logout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Snow;
            this.Logout.Location = new System.Drawing.Point(1436, 7);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(134, 41);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Tabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1586, 617);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.tabTab);
            this.Name = "Tabs";
            this.Text = "Form2";
            this.tabTab.ResumeLayout(false);
            this.tabFull.ResumeLayout(false);
            this.tabFull.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullView)).EndInit();
            this.tabTeaser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeaser)).EndInit();
            this.tabListView.ResumeLayout(false);
            this.tabListView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListView)).EndInit();
            this.tabPaticipantsView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTab;
        private System.Windows.Forms.TabPage tabFull;
        private System.Windows.Forms.TabPage tabTeaser;
        private System.Windows.Forms.TabPage tabListView;
        private System.Windows.Forms.CheckBox chkEndDate;
        private System.Windows.Forms.CheckBox chkStartDate;
        private System.Windows.Forms.CheckBox chkLocation;
        private System.Windows.Forms.CheckBox chkEndTime;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.CheckBox chkNotes;
        private System.Windows.Forms.CheckBox chkDescription;
        private System.Windows.Forms.CheckBox chkStartTime;
        private System.Windows.Forms.CheckBox chkRegisteredMaxAttendees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEventName;
        private System.Windows.Forms.Button btnViewSelection;
        private System.Windows.Forms.DataGridView dgvListView;
        private System.Windows.Forms.CheckBox chkAge;
        private Project1DataSet project1DataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private Project1DataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.BindingSource project1DataSetBindingSource;
        private System.Windows.Forms.Button btnUpdateList;
        private System.Windows.Forms.DataGridView dgvTeaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaserLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaserDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaserCategory;
        private System.Windows.Forms.DataGridView dgvFullView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageRequirement2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TabPage tabPaticipantsView;
        private System.Windows.Forms.DataGridView dgvParticipantView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Logout;
    }
}