using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeeInfo.Model
{
    public class Employee
    {
        private String name, dob, age;
        private byte gender;
        private bool doesSmoke;
        private String houseColor, hairColor;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (!(Regex.IsMatch(value, @"^([a-zA-Z]+)(\s[a-zA-Z]+)*$")))
                {
                    string error = "Invalid value for name!";
                    Console.WriteLine(error);
                    MessageBox.Show(error, "Error!", MessageBoxButtons.OK);
                    return;
                }
                name = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public byte Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public bool DoesSmoke
        {
            get
            {
                return doesSmoke;
            }

            set
            {
                doesSmoke = value;
            }
        }

        public string HouseColor
        {
            get
            {
                return houseColor;
            }

            set
            {
                houseColor = value;
            }
        }

        public string HairColor
        {
            get
            {
                return hairColor;
            }

            set
            {
                hairColor = value;
            }
        }

        public override string ToString() {
            return String.Format(@"{0}, {1}, {2}, {3}, {4}, {5}, {6}", name, age, dob, gender, doesSmoke, houseColor, hairColor);
        }
    }
}
