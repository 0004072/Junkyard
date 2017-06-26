using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureMonitor
{
    public partial class frmTempMon : Form
    {
        private Monitor tempMonitor;
        public frmTempMon(float envTemp)
        {
            InitializeComponent();
            this.tempMonitor = new Monitor(envTemp);
            this.btnRainy.Click += new EventHandler(change_temp);
            this.btnSunny.Click += new EventHandler(change_temp);
            this.btnAdHoc.Click += new EventHandler(change_temp);
            this.tempMonitor.TemperatureChanged += new Monitor.ChangeHandler(ShowAlert);
        }

        private void change_temp(object sender, EventArgs e)
        {
            float deltaT = 0.0f;
            switch (((Button)sender).Name) {
                case "btnSunny":
                    deltaT = 10;
                    break;

                case "btnRainy":
                    deltaT = -10;
                    break;

                case "btnAdHoc":
                    Random r = new Random();
                    deltaT = (float)(-5.0 + r.NextDouble() * 10);
                    break;
            }
            float t = tempMonitor.changeTemp(deltaT);
            lblCurrentTemp.Text = String.Format(@"{0}{1}C", t.ToString("#.##"), '\u2070');
        }

        private void ShowAlert(object sender, TempArgs s)
        {
            MessageBox.Show(String.Format(@"Temperature changed by {0}!", s.DeltaT.ToString("#.##")));
        }
    }
}