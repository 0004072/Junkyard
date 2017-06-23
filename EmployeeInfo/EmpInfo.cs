using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInfo.Model;

namespace EmployeeInfo
{
    public partial class EmpInfo : Form
    {
        private string[] colors;
        private List<Employee> employees;
        public EmpInfo()
        {
            colors = new string[] {
                HairColor.Black.Value,
                HairColor.Brown.Value,
                HairColor.White.Value
            };
            InitializeComponent();
            employees = new List<Employee>();
            this.cmbHairColor.DataSource = this.colors;
        }

        private void txtHouseColor_Click(object sender, EventArgs e)
        {
            DialogResult result = this.clrHouseColor.ShowDialog();
            this.clrHouseColor.SolidColorOnly = false;

            if (result == DialogResult.OK) {
                Color c = clrHouseColor.Color;
                this.txtHouseColor.Text = String.Format(@"#{0}{1}{2}", c.A.ToString("X2"), c.G.ToString("X2"), c.B.ToString("X2"));
                this.txtHouseColor.BackColor = c;
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = txtName.Text;
            emp.Dob = dtBirthDate.Text;
            emp.Gender = 0;
            if (optGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) == optGenMale)
                emp.Gender = 1;
            emp.Age = (DateTime.Now.Year - Convert.ToDateTime(emp.Dob).Year).ToString();
            emp.DoesSmoke = chkDoesSmoke.Checked;
            emp.HouseColor = txtHouseColor.Text;
            emp.HairColor = cmbHairColor.Text;
            employees.Add(emp);
            MessageBox.Show("Employee information has been successfully added!");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            exportToList();
        }

        private void exportToList() {
            FileDialog d = new SaveFileDialog();
            d.Filter = "Text files (*.txt)|*.txt|Comma Separated Value(CSV) files (*.csv)|*.csv";
            DialogResult dr = d.ShowDialog();
            if (dr == DialogResult.OK) {
                using (System.IO.StreamWriter f = new System.IO.StreamWriter(d.FileName, true)){
                    foreach (Employee e in employees) {
                        f.WriteLine(e.ToString());
                    }
                }
            }
        }
    }
}