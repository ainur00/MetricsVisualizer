using System;
using System.Globalization;
using System.Windows.Forms;

namespace MetricsVisualizer.CurvesForms
{
    public partial class LemniscateForm : Form
    {
        public Double focus1X = Double.NaN;
        public Double focus1Y = Double.NaN;
        public Double focus2X = Double.NaN;
        public Double focus2Y = Double.NaN;
        public Double constant = Double.NaN;

        public LemniscateForm()
        {
            InitializeComponent();
        }

        private void updateLemniscateOptions()
        {
            if (lemniscateFirstFocusXTextBox.Text != "")
                focus1X = Convert.ToDouble(lemniscateFirstFocusXTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (lemniscateFirstFocusYTextBox.Text != "")
                focus1Y = Convert.ToDouble(lemniscateFirstFocusYTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (lemniscateSecondFocusXTextBox.Text != "")
                focus2X = Convert.ToDouble(lemniscateSecondFocusXTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (lemniscateSecondFocusYTextBox.Text != "")
                focus2Y = Convert.ToDouble(lemniscateSecondFocusYTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (lemniscateConstantTextBox.Text != "")
                constant = Convert.ToDouble(lemniscateConstantTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
        }

        private void lemniscateBuildButtonClick(object sender, EventArgs e)
        {
            updateLemniscateOptions();
            if (!Double.IsNaN(focus1X) && !Double.IsNaN(focus1Y) && !Double.IsNaN(focus2X) && !Double.IsNaN(focus2Y) && !Double.IsNaN(constant))
                CurvesBuilder.CreateLemniscate(focus1X, focus1Y, focus2X, focus2Y, constant);
        }
    }
}
