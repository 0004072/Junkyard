using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    class HairColor
    {
        private string value;

        public string Value {
            get {
                return this.value;
            }
        }

        private HairColor(string v) {
            this.value = v;
        }

        public static HairColor Black {
            get {
                return new HairColor("Black");
            }
        }

        public static HairColor Brown {
            get
            {
                return new HairColor("Brown");
            }
        }

        public static HairColor White
        {
            get
            {
                return new HairColor("White");
            }
        }
    }
}
