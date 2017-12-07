using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventScheduleUI
{
    public partial class ListView : Form
    {

        public Tabs checkboxes;
        public ListView()
        {
            InitializeComponent();
            DataTable viewSelection = new DataTable();
            //this.dgvViewSelection.Columns["EventName"].Visible = false;
            //Form2 f2 = this.f2.f4;
            if (checkboxes.isChecked[0])
            {
                this.dgvViewSelection.Columns["EventName"].Visible = false;
            }
            if (!checkboxes.isChecked[1])
            {
                this.dgvViewSelection.Columns["Location"].Visible = false;
            }
            if (!checkboxes.isChecked[2])
            {
                this.dgvViewSelection.Columns["Status"].Visible = false;
            }
            if (!checkboxes.isChecked[3])
            {
                this.dgvViewSelection.Columns["StartDate"].Visible = false;
            }
            if (!checkboxes.isChecked[4])
            {
                this.dgvViewSelection.Columns["EndDate"].Visible = false;
            }
            if (!checkboxes.isChecked[5])
            {
                this.dgvViewSelection.Columns["StartTime"].Visible = false;
            }
            if (!checkboxes.isChecked[6])
            {
                this.dgvViewSelection.Columns["EndTime"].Visible = false;
            }
            if (!checkboxes.isChecked[7])
            {
                this.dgvViewSelection.Columns["Attendees"].Visible = false;
            }
            if (!checkboxes.isChecked[8])
            {
                this.dgvViewSelection.Columns["Notes"].Visible = false;
            }
            if (!checkboxes.isChecked[9])
            {
                this.dgvViewSelection.Columns["Description"].Visible = false;
            }
        }

        private void dgvViewSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
