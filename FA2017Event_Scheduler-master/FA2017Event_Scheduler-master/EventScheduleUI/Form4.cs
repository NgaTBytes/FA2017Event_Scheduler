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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            DataTable viewSelection = new DataTable();
            this.dgvViewSelection.Columns["EventName"].Visible = false;
        }

        private void dgvViewSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
