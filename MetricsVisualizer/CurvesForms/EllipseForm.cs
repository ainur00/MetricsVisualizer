using System;
using System.Globalization;
using System.Windows.Forms;

namespace MetricsVisualizer
{
    public partial class EllipseForm : Form
    {
        public Double focus1X = Double.NaN;
        public Double focus1Y = Double.NaN;
        public Double focus2X = Double.NaN;
        public Double focus2Y = Double.NaN;
        public Double constant = Double.NaN;

        public EllipseForm()
        {
            InitializeComponent();
        }

        private void updateEllipseOptions()
        {
            if (ellipseFirstFocusXTextBox.Text != "")
                focus1X = Convert.ToDouble(ellipseFirstFocusXTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (ellipseFirstFocusYTextBox.Text != "")
                focus1Y = Convert.ToDouble(ellipseFirstFocusYTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (ellipseSecondFocusXTextBox.Text != "")
                focus2X = Convert.ToDouble(ellipseSecondFocusXTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (ellipseSecondFocusYTextBox.Text != "")
                focus2Y = Convert.ToDouble(ellipseSecondFocusYTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
            if (ellipseConstantTextBox.Text != "")
                constant = Convert.ToDouble(ellipseConstantTextBox.Text, new NumberFormatInfo { NumberDecimalSeparator = "." });
        }

        private void ellipseBuildButtonClick(object sender, EventArgs e)
        {
            updateEllipseOptions();
            if (!Double.IsNaN(focus1X) && !Double.IsNaN(focus1Y) && !Double.IsNaN(focus2X) && !Double.IsNaN(focus2Y) && !Double.IsNaN(constant))
                CurvesBuilder.CreateEllipse(focus1X, focus1Y, focus2X, focus2Y, constant);
        }
    }
}
