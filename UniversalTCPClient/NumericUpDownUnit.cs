using System.Windows.Forms;

namespace UniversalTCPClient
{
    class NumericUpDownUnit : NumericUpDown
    {
        private string unit = "";

        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
            }
        }


        protected override void UpdateEditText()
        {
            Text = Value + " " + unit;
        }
    }
}
