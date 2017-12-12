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
            this.tabTab = new System.Windows.Forms.TabControl();
            this.tabFull = new System.Windows.Forms.TabPage();
            this.dgvFullView = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTeaser = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeaserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaserLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaserDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeaserCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabListView = new System.Windows.Forms.TabPage();
            this.dgvListView = new System.Windows.Forms.DataGridView();
            this.EventNameForm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationForm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateForm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateForm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeForm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeForm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusForm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesForm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionForm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeesForm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExecute = new System.Windows.Forms.Button();
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
            this.tabTab.SuspendLayout();
            this.tabFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullView)).BeginInit();
            this.tabTeaser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTab
            // 
            this.tabTab.Controls.Add(this.tabFull);
            this.tabTab.Controls.Add(this.tabTeaser);
            this.tabTab.Controls.Add(this.tabListView);
            this.tabTab.Location = new System.Drawing.Point(25, 12);
            this.tabTab.Name = "tabTab";
            this.tabTab.SelectedIndex = 0;
            this.tabTab.Size = new System.Drawing.Size(1246, 615);
            this.tabTab.TabIndex = 0;
            this.tabTab.Enter += new System.EventHandler(this.tabTab_Enter);
            // 
            // tabFull
            // 
            this.tabFull.Controls.Add(this.dgvFullView);
            this.tabFull.Location = new System.Drawing.Point(4, 22);
            this.tabFull.Name = "tabFull";
            this.tabFull.Padding = new System.Windows.Forms.Padding(3);
            this.tabFull.Size = new System.Drawing.Size(1238, 589);
            this.tabFull.TabIndex = 0;
            this.tabFull.Text = "Full View";
            this.tabFull.UseVisualStyleBackColor = true;
            // 
            // dgvFullView
            // 
            this.dgvFullView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFullView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.Location,
            this.Status,
            this.StartDate,
            this.EndDate,
            this.StartTime,
            this.EndTime,
            this.Attendees,
            this.Notes,
            this.Description});
            this.dgvFullView.Location = new System.Drawing.Point(0, 0);
            this.dgvFullView.Name = "dgvFullView";
            this.dgvFullView.Size = new System.Drawing.Size(1432, 516);
            this.dgvFullView.TabIndex = 1;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event Name";
            this.EventName.Name = "EventName";
            this.EventName.Width = 200;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 75;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 75;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            // 
            // Attendees
            // 
            this.Attendees.HeaderText = "Registered/Max  Attendees";
            this.Attendees.Name = "Attendees";
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 400;
            // 
            // tabTeaser
            // 
            this.tabTeaser.Controls.Add(this.dataGridView1);
            this.tabTeaser.Location = new System.Drawing.Point(4, 22);
            this.tabTeaser.Name = "tabTeaser";
            this.tabTeaser.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeaser.Size = new System.Drawing.Size(1238, 589);
            this.tabTeaser.TabIndex = 1;
            this.tabTeaser.Text = "Teaser View";
            this.tabTeaser.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeaserName,
            this.TeaserLocation,
            this.TeaserDate,
            this.TeaserCategory});
            this.dataGridView1.Location = new System.Drawing.Point(11, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1211, 573);
            this.dataGridView1.TabIndex = 0;
            // 
            // TeaserName
            // 
            this.TeaserName.HeaderText = "Event Name";
            this.TeaserName.Name = "TeaserName";
            this.TeaserName.Width = 280;
            // 
            // TeaserLocation
            // 
            this.TeaserLocation.HeaderText = "Location";
            this.TeaserLocation.Name = "TeaserLocation";
            this.TeaserLocation.Width = 280;
            // 
            // TeaserDate
            // 
            this.TeaserDate.HeaderText = "Date";
            this.TeaserDate.Name = "TeaserDate";
            this.TeaserDate.Width = 280;
            // 
            // TeaserCategory
            // 
            this.TeaserCategory.HeaderText = "Category";
            this.TeaserCategory.Name = "TeaserCategory";
            this.TeaserCategory.Width = 280;
            // 
            // tabListView
            // 
            this.tabListView.Controls.Add(this.dgvListView);
            this.tabListView.Controls.Add(this.btnExecute);
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
            this.tabListView.Size = new System.Drawing.Size(1238, 589);
            this.tabListView.TabIndex = 2;
            this.tabListView.Text = "List View";
            this.tabListView.UseVisualStyleBackColor = true;
            this.tabListView.Click += new System.EventHandler(this.tabListView_Click);
            // 
            // dgvListView
            // 
            this.dgvListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventNameForm2,
            this.LocationForm2,
            this.StartDateForm2,
            this.EndDateForm2,
            this.StartTimeForm2,
            this.EndTimeForm2,
            this.StatusForm2,
            this.NotesForm2,
            this.DescriptionForm2,
            this.AttendeesForm2});
            this.dgvListView.Location = new System.Drawing.Point(5, 68);
            this.dgvListView.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListView.Name = "dgvListView";
            this.dgvListView.RowTemplate.Height = 28;
            this.dgvListView.Size = new System.Drawing.Size(1078, 251);
            this.dgvListView.TabIndex = 12;
            this.dgvListView.Visible = false;
            this.dgvListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListView_CellContentClick);
            // 
            // EventNameForm2
            // 
            this.EventNameForm2.HeaderText = "Event Name";
            this.EventNameForm2.Name = "EventNameForm2";
            // 
            // LocationForm2
            // 
            this.LocationForm2.HeaderText = "Location";
            this.LocationForm2.Name = "LocationForm2";
            // 
            // StartDateForm2
            // 
            this.StartDateForm2.HeaderText = "Start Date";
            this.StartDateForm2.Name = "StartDateForm2";
            // 
            // EndDateForm2
            // 
            this.EndDateForm2.HeaderText = "End Date";
            this.EndDateForm2.Name = "EndDateForm2";
            // 
            // StartTimeForm2
            // 
            this.StartTimeForm2.HeaderText = "Start Time";
            this.StartTimeForm2.Name = "StartTimeForm2";
            // 
            // EndTimeForm2
            // 
            this.EndTimeForm2.HeaderText = "End Time";
            this.EndTimeForm2.Name = "EndTimeForm2";
            // 
            // StatusForm2
            // 
            this.StatusForm2.HeaderText = "Status";
            this.StatusForm2.Name = "StatusForm2";
            // 
            // NotesForm2
            // 
            this.NotesForm2.HeaderText = "Notes";
            this.NotesForm2.Name = "NotesForm2";
            // 
            // DescriptionForm2
            // 
            this.DescriptionForm2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DescriptionForm2.HeaderText = "Description";
            this.DescriptionForm2.Name = "DescriptionForm2";
            this.DescriptionForm2.Width = 85;
            // 
            // AttendeesForm2
            // 
            this.AttendeesForm2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AttendeesForm2.HeaderText = "Registered/Max Attendees";
            this.AttendeesForm2.Name = "AttendeesForm2";
            this.AttendeesForm2.Width = 145;
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnExecute.Location = new System.Drawing.Point(273, 361);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(339, 63);
            this.btnExecute.TabIndex = 11;
            this.btnExecute.Text = "View Selection";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // chkEndDate
            // 
            this.chkEndDate.AutoSize = true;
            this.chkEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkEndDate.Location = new System.Drawing.Point(311, 30);
            this.chkEndDate.Name = "chkEndDate";
            this.chkEndDate.Size = new System.Drawing.Size(96, 24);
            this.chkEndDate.TabIndex = 10;
            this.chkEndDate.Text = "End Date";
            this.chkEndDate.UseVisualStyleBackColor = true;
            // 
            // chkStartDate
            // 
            this.chkStartDate.AutoSize = true;
            this.chkStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkStartDate.Location = new System.Drawing.Point(209, 30);
            this.chkStartDate.Name = "chkStartDate";
            this.chkStartDate.Size = new System.Drawing.Size(102, 24);
            this.chkStartDate.TabIndex = 9;
            this.chkStartDate.Text = "Start Date";
            this.chkStartDate.UseVisualStyleBackColor = true;
            // 
            // chkLocation
            // 
            this.chkLocation.AutoSize = true;
            this.chkLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkLocation.Location = new System.Drawing.Point(117, 30);
            this.chkLocation.Name = "chkLocation";
            this.chkLocation.Size = new System.Drawing.Size(89, 24);
            this.chkLocation.TabIndex = 8;
            this.chkLocation.Text = "Location";
            this.chkLocation.UseVisualStyleBackColor = true;
            // 
            // chkEventName
            // 
            this.chkEventName.AutoSize = true;
            this.chkEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkEventName.Location = new System.Drawing.Point(5, 30);
            this.chkEventName.Name = "chkEventName";
            this.chkEventName.Size = new System.Drawing.Size(115, 24);
            this.chkEventName.TabIndex = 7;
            this.chkEventName.Text = "Event Name";
            this.chkEventName.UseVisualStyleBackColor = true;
            this.chkEventName.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // chkEndTime
            // 
            this.chkEndTime.AutoSize = true;
            this.chkEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkEndTime.Location = new System.Drawing.Point(513, 30);
            this.chkEndTime.Name = "chkEndTime";
            this.chkEndTime.Size = new System.Drawing.Size(95, 24);
            this.chkEndTime.TabIndex = 6;
            this.chkEndTime.Text = "End Time";
            this.chkEndTime.UseVisualStyleBackColor = true;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkStatus.Location = new System.Drawing.Point(615, 30);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(75, 24);
            this.chkStatus.TabIndex = 5;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // chkNotes
            // 
            this.chkNotes.AutoSize = true;
            this.chkNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkNotes.Location = new System.Drawing.Point(690, 30);
            this.chkNotes.Name = "chkNotes";
            this.chkNotes.Size = new System.Drawing.Size(70, 24);
            this.chkNotes.TabIndex = 4;
            this.chkNotes.Text = "Notes";
            this.chkNotes.UseVisualStyleBackColor = true;
            // 
            // chkDescription
            // 
            this.chkDescription.AutoSize = true;
            this.chkDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkDescription.Location = new System.Drawing.Point(764, 30);
            this.chkDescription.Name = "chkDescription";
            this.chkDescription.Size = new System.Drawing.Size(108, 24);
            this.chkDescription.TabIndex = 3;
            this.chkDescription.Text = "Description";
            this.chkDescription.UseVisualStyleBackColor = true;
            // 
            // chkStartTime
            // 
            this.chkStartTime.AutoSize = true;
            this.chkStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkStartTime.Location = new System.Drawing.Point(408, 30);
            this.chkStartTime.Name = "chkStartTime";
            this.chkStartTime.Size = new System.Drawing.Size(101, 24);
            this.chkStartTime.TabIndex = 2;
            this.chkStartTime.Text = "Start Time";
            this.chkStartTime.UseVisualStyleBackColor = true;
            // 
            // chkRegisteredMaxAttendees
            // 
            this.chkRegisteredMaxAttendees.AutoSize = true;
            this.chkRegisteredMaxAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkRegisteredMaxAttendees.Location = new System.Drawing.Point(877, 30);
            this.chkRegisteredMaxAttendees.Name = "chkRegisteredMaxAttendees";
            this.chkRegisteredMaxAttendees.Size = new System.Drawing.Size(217, 24);
            this.chkRegisteredMaxAttendees.TabIndex = 1;
            this.chkRegisteredMaxAttendees.Text = "Registered/Max Attendees";
            this.chkRegisteredMaxAttendees.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to see?";
            // 
            // Tabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 617);
            this.Controls.Add(this.tabTab);
            this.Name = "Tabs";
            this.Text = "Form2";
            this.tabTab.ResumeLayout(false);
            this.tabFull.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullView)).EndInit();
            this.tabTeaser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabListView.ResumeLayout(false);
            this.tabListView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTab;
        private System.Windows.Forms.TabPage tabFull;
        private System.Windows.Forms.TabPage tabTeaser;
        private System.Windows.Forms.TabPage tabListView;
        private System.Windows.Forms.DataGridView dgvFullView;
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
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaserLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaserDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeaserCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridView dgvListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventNameForm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationForm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateForm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDateForm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeForm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeForm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusForm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesForm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionForm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeesForm2;
    }
}