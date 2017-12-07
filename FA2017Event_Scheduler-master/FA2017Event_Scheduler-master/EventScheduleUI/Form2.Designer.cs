namespace EventScheduleUI
{
    partial class Form2
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
            this.tabListView = new System.Windows.Forms.TabPage();
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
            this.tabListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTab
            // 
            this.tabTab.Controls.Add(this.tabFull);
            this.tabTab.Controls.Add(this.tabTeaser);
            this.tabTab.Controls.Add(this.tabListView);
            this.tabTab.Location = new System.Drawing.Point(-3, 5);
            this.tabTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTab.Name = "tabTab";
            this.tabTab.SelectedIndex = 0;
            this.tabTab.Size = new System.Drawing.Size(1854, 946);
            this.tabTab.TabIndex = 0;
            // 
            // tabFull
            // 
            this.tabFull.Controls.Add(this.dgvFullView);
            this.tabFull.Location = new System.Drawing.Point(4, 29);
            this.tabFull.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFull.Name = "tabFull";
            this.tabFull.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFull.Size = new System.Drawing.Size(1846, 913);
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
            this.dgvFullView.Location = new System.Drawing.Point(15, 9);
            this.dgvFullView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFullView.Name = "dgvFullView";
            this.dgvFullView.Size = new System.Drawing.Size(1803, 794);
            this.dgvFullView.TabIndex = 1;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event Name";
            this.EventName.Name = "EventName";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
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
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
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
            // 
            // tabTeaser
            // 
            this.tabTeaser.Location = new System.Drawing.Point(4, 29);
            this.tabTeaser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeaser.Name = "tabTeaser";
            this.tabTeaser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeaser.Size = new System.Drawing.Size(1846, 913);
            this.tabTeaser.TabIndex = 1;
            this.tabTeaser.Text = "Teaser View";
            this.tabTeaser.UseVisualStyleBackColor = true;
            // 
            // tabListView
            // 
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
            this.tabListView.Location = new System.Drawing.Point(4, 29);
            this.tabListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabListView.Name = "tabListView";
            this.tabListView.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabListView.Size = new System.Drawing.Size(1846, 913);
            this.tabListView.TabIndex = 2;
            this.tabListView.Text = "List View";
            this.tabListView.UseVisualStyleBackColor = true;
            this.tabListView.Click += new System.EventHandler(this.tabListView_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnExecute.Location = new System.Drawing.Point(410, 555);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(508, 97);
            this.btnExecute.TabIndex = 11;
            this.btnExecute.Text = "View Selection";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // chkEndDate
            // 
            this.chkEndDate.AutoSize = true;
            this.chkEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkEndDate.Location = new System.Drawing.Point(996, 243);
            this.chkEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEndDate.Name = "chkEndDate";
            this.chkEndDate.Size = new System.Drawing.Size(138, 33);
            this.chkEndDate.TabIndex = 10;
            this.chkEndDate.Text = "End Date";
            this.chkEndDate.UseVisualStyleBackColor = true;
            // 
            // chkStartDate
            // 
            this.chkStartDate.AutoSize = true;
            this.chkStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkStartDate.Location = new System.Drawing.Point(765, 243);
            this.chkStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkStartDate.Name = "chkStartDate";
            this.chkStartDate.Size = new System.Drawing.Size(144, 33);
            this.chkStartDate.TabIndex = 9;
            this.chkStartDate.Text = "Start Date";
            this.chkStartDate.UseVisualStyleBackColor = true;
            // 
            // chkLocation
            // 
            this.chkLocation.AutoSize = true;
            this.chkLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkLocation.Location = new System.Drawing.Point(520, 243);
            this.chkLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLocation.Name = "chkLocation";
            this.chkLocation.Size = new System.Drawing.Size(130, 33);
            this.chkLocation.TabIndex = 8;
            this.chkLocation.Text = "Location";
            this.chkLocation.UseVisualStyleBackColor = true;
            // 
            // chkEventName
            // 
            this.chkEventName.AutoSize = true;
            this.chkEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkEventName.Location = new System.Drawing.Point(272, 243);
            this.chkEventName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEventName.Name = "chkEventName";
            this.chkEventName.Size = new System.Drawing.Size(170, 33);
            this.chkEventName.TabIndex = 7;
            this.chkEventName.Text = "Event Name";
            this.chkEventName.UseVisualStyleBackColor = true;
            this.chkEventName.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // chkEndTime
            // 
            this.chkEndTime.AutoSize = true;
            this.chkEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkEndTime.Location = new System.Drawing.Point(272, 409);
            this.chkEndTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEndTime.Name = "chkEndTime";
            this.chkEndTime.Size = new System.Drawing.Size(144, 33);
            this.chkEndTime.TabIndex = 6;
            this.chkEndTime.Text = "End Time";
            this.chkEndTime.UseVisualStyleBackColor = true;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkStatus.Location = new System.Drawing.Point(520, 409);
            this.chkStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(105, 33);
            this.chkStatus.TabIndex = 5;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // chkNotes
            // 
            this.chkNotes.AutoSize = true;
            this.chkNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkNotes.Location = new System.Drawing.Point(765, 409);
            this.chkNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNotes.Name = "chkNotes";
            this.chkNotes.Size = new System.Drawing.Size(103, 33);
            this.chkNotes.TabIndex = 4;
            this.chkNotes.Text = "Notes";
            this.chkNotes.UseVisualStyleBackColor = true;
            // 
            // chkDescription
            // 
            this.chkDescription.AutoSize = true;
            this.chkDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkDescription.Location = new System.Drawing.Point(996, 409);
            this.chkDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDescription.Name = "chkDescription";
            this.chkDescription.Size = new System.Drawing.Size(161, 33);
            this.chkDescription.TabIndex = 3;
            this.chkDescription.Text = "Description";
            this.chkDescription.UseVisualStyleBackColor = true;
            // 
            // chkStartTime
            // 
            this.chkStartTime.AutoSize = true;
            this.chkStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkStartTime.Location = new System.Drawing.Point(1227, 243);
            this.chkStartTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkStartTime.Name = "chkStartTime";
            this.chkStartTime.Size = new System.Drawing.Size(150, 33);
            this.chkStartTime.TabIndex = 2;
            this.chkStartTime.Text = "Start Time";
            this.chkStartTime.UseVisualStyleBackColor = true;
            // 
            // chkRegisteredMaxAttendees
            // 
            this.chkRegisteredMaxAttendees.AutoSize = true;
            this.chkRegisteredMaxAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkRegisteredMaxAttendees.Location = new System.Drawing.Point(1227, 409);
            this.chkRegisteredMaxAttendees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRegisteredMaxAttendees.Name = "chkRegisteredMaxAttendees";
            this.chkRegisteredMaxAttendees.Size = new System.Drawing.Size(323, 33);
            this.chkRegisteredMaxAttendees.TabIndex = 1;
            this.chkRegisteredMaxAttendees.Text = "Registered/Max Attendees";
            this.chkRegisteredMaxAttendees.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(262, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to see?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1869, 949);
            this.Controls.Add(this.tabTab);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabTab.ResumeLayout(false);
            this.tabFull.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullView)).EndInit();
            this.tabListView.ResumeLayout(false);
            this.tabListView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTab;
        private System.Windows.Forms.TabPage tabFull;
        private System.Windows.Forms.TabPage tabTeaser;
        private System.Windows.Forms.TabPage tabListView;
        private System.Windows.Forms.DataGridView dgvFullView;
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
        
    }
}