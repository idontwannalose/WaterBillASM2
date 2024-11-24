using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBill_ASM2
{
    public partial class ManageBill : Form
    {
        string[] names = new string[100];
        int[] types = new int[100];
        double[] lastMonths = new double[100];
        double[] thisMonths = new double[100];
        int[] numberPeople = new int[100];
        double[] usages = new double[100];
        double[] totalCosts = new double[100];
        

        int n = 0;
        int index = -1;
        public void Display()
        {
            dgvBill.DataSource = null;

            var bills = new DataTable();
            bills.Columns.Add("Name");
            bills.Columns.Add("Last Month");
            bills.Columns.Add("This Month");
            bills.Columns.Add("usage");
            bills.Columns.Add("Total Cost");

            for (int i = 0; i < n; i++)
            {
                bills.Rows.Add(names[i], lastMonths[i], thisMonths[i], usages[i], totalCosts[i]);
            }
            dgvBill.DataSource = bills;
            dgvBill.Refresh();
        }

        public void ClearData()
        {
            txtNameOfCustomer.Clear();
            txtWaterMeterLastMonth.Clear();
            txtWaterMeterThisMonth.Clear();
            txtNumberOfCustomer.Clear();
            cbBoxTypeOfCustomer.Text = "";
            txtSearchByName.Clear();
            Display();
        }


        private double GetPriceUnit(int customerType, double usageTotal)
        {
            double priceUnit = 0;
            if (customerType == 0)
            {
                int numberPeople = int.Parse(txtNumberOfCustomer.Text);
                double avg = usageTotal / numberPeople;
                if (avg <= 10)
                {
                    priceUnit = 5973;
                }
                else if (avg <= 20)
                {
                    priceUnit = 7052;
                }
                else if (avg <= 30)
                {
                    priceUnit = 8699;
                }
                else
                {
                    priceUnit = 15929;
                }
            }
            else if(customerType == 1)
            {
                priceUnit = 9955;
            }
            else if(customerType==2)
            {
                priceUnit = 11615;
            }
            else if(customerType == 3)
            {
                priceUnit = 22608;
            }
            return priceUnit;
        }


        public ManageBill()
        {
            InitializeComponent();
        }

        private void btnExportInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtNameOfCustomer.Text;
                double waterMeterLastMonth = Double.Parse(txtWaterMeterLastMonth.Text);
                double waterMeterThisMonth = Double.Parse(txtWaterMeterThisMonth.Text);
                if (waterMeterThisMonth < waterMeterLastMonth)
                {
                    MessageBox.Show("Water meter this month can't be less than water meter last month");
                    return;
                }
                int customerType = cbBoxTypeOfCustomer.SelectedIndex;
                double usageTotal = waterMeterThisMonth - waterMeterLastMonth;
                double priceUnit = GetPriceUnit(customerType, usageTotal);
                double totalBill = priceUnit * usageTotal * 1.1;
                Display();
                MessageBox.Show("Customer name: " + customerName + "\n" + "Usage: " + usageTotal + "m3" + "\n" + "Bill: " + totalBill + "vnd");
            }
            catch (FormatException) 
            {
                MessageBox.Show("Invalid input! Please enter numeric values for meter readings.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
         }



        private void cbBoxTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbBoxTypeOfCustomer.SelectedIndex;
            if (selectedIndex == 0)
            {
                txtNumberOfCustomer.Visible = true;
                lbNumberOfCustomer.Visible = true;
            }
            else
            {
                txtNumberOfCustomer.Visible = false;
                lbNumberOfCustomer.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtNameOfCustomer.Text;
                double waterMeterLastMonth = double.Parse(txtWaterMeterLastMonth.Text);
                double waterMeterThisMonth = double.Parse(txtWaterMeterThisMonth.Text);
                if (waterMeterThisMonth < waterMeterLastMonth)
                {
                    MessageBox.Show("Water meter this month can't be less than water meter last month");
                    return;
                }
                int customerType = cbBoxTypeOfCustomer.SelectedIndex;
                double usageTotal = waterMeterThisMonth - waterMeterLastMonth; ;
                double priceUnit = GetPriceUnit(customerType, usageTotal); ;
                double totalBill = priceUnit * usageTotal * 1.1;
                names[n] = customerName;
                types[n] = customerType;
                lastMonths[n] = waterMeterLastMonth;
                thisMonths[n] = waterMeterThisMonth;
                numberPeople[n] = (customerType == 0) ? int.Parse(txtNumberOfCustomer.Text) : 0;
                usages[n] = usageTotal;
                totalCosts[n] = totalBill;
                n++;
                Display();
                MessageBox.Show("Save successfully!!");
                ClearData();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input! Please enter numeric values for meter readings.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }

        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txtNameOfCustomer.Text = names[index];
            cbBoxTypeOfCustomer.SelectedIndex = types[index];
            txtWaterMeterLastMonth.Text = lastMonths[index].ToString();
            txtWaterMeterThisMonth.Text = thisMonths[index].ToString();
            txtNumberOfCustomer.Text = (types[index] == 0) ? numberPeople[index].ToString() : "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần chỉnh sửa.");
                return;
            }
            if (MessageBox.Show("Do you want to edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (double.TryParse(txtWaterMeterLastMonth.Text, out double waterMeterLastMonth) && double.TryParse(txtWaterMeterThisMonth.Text, out double waterMeterThisMonth))
                {
                    string customerName = txtNameOfCustomer.Text;
                    int customerType = cbBoxTypeOfCustomer.SelectedIndex;
                    double usageTotal = waterMeterThisMonth - waterMeterLastMonth; ;
                    double priceUnit = GetPriceUnit(customerType, usageTotal); ;
                    double totalBill = priceUnit * usageTotal * 1.1;

                    names[index] = customerName;
                    types[index] = customerType;
                    lastMonths[index] = waterMeterLastMonth;
                    thisMonths[index] = waterMeterThisMonth;
                    numberPeople[index] = (customerType == 0) ? int.Parse(txtNumberOfCustomer.Text) : 0;
                    usages[index] = usageTotal;
                    totalCosts[index] = totalBill;

                    Display();
                    MessageBox.Show("Updated successfully!!");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please enter the valid number for water usage!");
                }
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    names[i] = names[i + 1];
                    types[i] = types[i + 1];
                    lastMonths[i] = lastMonths[i + 1];
                    thisMonths[i] = thisMonths[i + 1];
                    numberPeople[i] = numberPeople[i + 1];
                    usages[i] = usages[i + 1];
                    totalCosts[i] = totalCosts[i + 1];
                }
                n--;
                Display();
                MessageBox.Show("Deleted successfully!!");
                ClearData();
            }
        }
        private void Swap(int i, int j)
        {
            (names[i], names[j]) = (names[j], names[i]);
            (types[i], types[j]) = (types[j], types[i]);
            (lastMonths[i], lastMonths[j]) = (lastMonths[j], lastMonths[i]);
            (thisMonths[i], thisMonths[j]) = (thisMonths[j], thisMonths[i]);
            (numberPeople[i], numberPeople[j]) = (numberPeople[j], numberPeople[i]);
            (usages[i], usages[j]) = (usages[j], usages[i]);
            (totalCosts[i], totalCosts[j]) = (totalCosts[j], totalCosts[i]);
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            for(int i =0; i < n- 1; i++)
            {
                for (int j =0; j < n - i - 1; j++)
                {
                    if (totalCosts[j] > totalCosts[j + 1])
                    {
                        Swap(j,j+1);
                    }
                }
            }
            Display();
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (totalCosts[j] < totalCosts[j + 1])
                    {
                        Swap(j, j + 1);
                    }
                }
            }
            Display();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            Display();
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchByName.Text;
            if(!string.IsNullOrEmpty(searchText) )
            {
                var filteredBills = new DataTable();
                filteredBills.Columns.Add("Name");
                filteredBills.Columns.Add("Type");
                filteredBills.Columns.Add("Last Month");
                filteredBills.Columns.Add("This Month");
                filteredBills.Columns.Add("Usage");
                filteredBills.Columns.Add("Total Cost");

                for(int i = 0;i < n; i++)
                {
                    if(names[i] != null && names[i].IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        filteredBills.Rows.Add(names[i], types[i], lastMonths[i], thisMonths[i], usages[i], totalCosts[i]);
                    }
                }
                dgvBill.DataSource = filteredBills;
            }
            else
            {
                Display();
            }
        }
     }
}
