using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CODEX8
{
    public partial class frmBeneficiaryDashboard : Form
    {
        string donationsFile = Path.Combine(Application.StartupPath, "donations.txt");
        string requestsFile = Path.Combine(Application.StartupPath, "requests.txt");
        public frmBeneficiaryDashboard()
        {
            InitializeComponent();
        }

        private void LoadAvailableFood()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item Name");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Category");
            dt.Columns.Add("Expiry Date");

            if (File.Exists(donationsFile))
            {
                using (StreamReader sr = new StreamReader(donationsFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data.Length >= 4)
                        {
                            dt.Rows.Add(data[0], data[1], data[2], data[3]);
                        }
                    }
                }
            }
            dgvAvailableFood.DataSource = dt;
        }

        private void btnRequestFood_Click(object sender, EventArgs e)
        {
            if (dgvAvailableFood.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please click on a food item to request it.", "No item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string requestedItem = dgvAvailableFood.SelectedRows[0].Cells["Item Name"].Value.ToString();
            string requestDate = DateTime.Now.ToShortDateString();

            try
            {
                string requestData = $"{requestedItem},{requestDate},Pending\n";
                File.AppendAllText(requestsFile, requestData);
                MessageBox.Show($"You have successfully requested: {requestedItem}. The Admin will review your request soon.", "Request Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving request: " + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void frmBeneficiaryDashboard_Load(object sender, EventArgs e)
        {
            LoadAvailableFood();
        }

        
    }
}
