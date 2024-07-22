using System;
using System.Globalization;
using System.Windows.Forms;

namespace MetricsVisualizer.CurvesForms
{
    public partial class HyperbolaForm : Form
    {
        public Double focus1X = Double.NaN;
        public Double focus1Y = Double.NaN;
        public Double focus2X = Double.NaN;
        public Double focus2Y = Double.NaN;
        public Double constant = Double.NaN;

        public HyperbolaForm()
        {
            InitializeComponent();
        }

        private void updateHyperbolaOptions()
        {
            if (hyperbolaFirstFocusXTextBox.Text != "")
                focus1X = Convert.ToDouble(hyperbolaFirstFocusXTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (hyperbolaFirstFocusYTextBox.Text != "")
                focus1Y = Convert.ToDouble(hyperbolaFirstFocusYTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (hyperbolaSecondFocusXTextBox.Text != "")
                focus2X = Convert.ToDouble(hyperbolaSecondFocusXTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (hyperbolaSecondFocusYTextBox.Text != "")
                focus2Y = Convert.ToDouble(hyperbolaSecondFocusYTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (hyperbolaConstantTextBox.Text != "")
                constant = Convert.ToDouble(hyperbolaConstantTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
        }

        private void hyperbolaBuildButtonClick(object sender, EventArgs e)
        {
            updateHyperbolaOptions();
            if (!Double.IsNaN(focus1X) && !Double.IsNaN(focus1Y) && !Double.IsNaN(focus2X) && !Double.IsNaN(focus2Y) && !Double.IsNaN(constant))
                CurvesBuilder.CreateHyperbola(focus1X, focus1Y, focus2X, focus2Y, constant);
        }
    }
}
