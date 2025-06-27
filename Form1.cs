using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadDemoData();
            this.btnAdd.Click += BtnAdd_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnDelete.Click += BtnDelete_Click;
        }

        private void LoadDemoData()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Date Created", typeof(DateTime));
            dt.Columns.Add("Actions", typeof(string));

            dt.Rows.Add(1, "Project Phoenix", "Development", "Active", new DateTime(2023, 1, 15), "View");
            dt.Rows.Add(2, "Task Omega", "Design", "Completed", new DateTime(2023, 2, 20), "View");
            dt.Rows.Add(3, "Feature Sigma", "Product", "Pending", new DateTime(2023, 3, 10), "View");
            dt.Rows.Add(4, "Bug Lambda", "QA", "Resolved", new DateTime(2023, 4, 5), "View");
            dt.Rows.Add(5, "Enhancement Delta", "Development", "Active", new DateTime(2023, 5, 12), "View");
            dt.Rows.Add(6, "Documentation Psi", "Documentation", "Completed", new DateTime(2023, 6, 18), "View");
            dt.Rows.Add(7, "Meeting Chi", "Management", "Scheduled", new DateTime(2023, 7, 22), "View");
            dt.Rows.Add(8, "Review Phi", "Design", "In Review", new DateTime(2023, 8, 1), "View");
            dt.Rows.Add(9, "Release Gamma", "Product", "Released", new DateTime(2023, 9, 8), "View");
            dt.Rows.Add(10, "Support Zeta", "Support", "Open", new DateTime(2023, 10, 15), "View");

            this.dataGridViewEntries.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var dt = this.dataGridViewEntries.DataSource as DataTable;
            if (dt == null) return;
            int newId = dt.Rows.Count + 1;
            dt.Rows.Add(newId, $"New Entry {newId}", "Category", "Status", DateTime.Now, "View");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewEntries.SelectedRows.Count > 0)
            {
                var row = this.dataGridViewEntries.SelectedRows[0];
                row.Cells[1].Value = "[Updated] " + row.Cells[1].Value;
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntries.SelectedRows.Count > 0)
            {
                dataGridViewEntries.Rows.RemoveAt(dataGridViewEntries.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void labelAppName_Click(object sender, EventArgs e)
        {

        }
    }
}
