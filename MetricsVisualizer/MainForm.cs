using MetricsVisualizer.CurvesForms;
using System.Windows.Forms;

namespace MetricsVisualizer
{
    public partial class MainForm : Form
    {
        public static EllipseForm ellipseForm;
        public static LemniscateForm lemniscateForm;
        public static HyperbolaForm hyperbolaForm;
        public static InstructionForm instructionForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ellipseButtonClick(object sender, System.EventArgs e)
        {
            ellipseForm = new EllipseForm();
            ellipseForm.Show();
        }

        private void lemniscateButtonClick(object sender, System.EventArgs e)
        {
            lemniscateForm = new LemniscateForm();
            lemniscateForm.Show();
        }

        private void hyperbolaButtonClick(object sender, System.EventArgs e)
        {
            hyperbolaForm = new HyperbolaForm();
            hyperbolaForm.Show();
        }

        private void faqButtonClick(object sender, System.EventArgs e)
        {
            instructionForm = new InstructionForm();
            instructionForm.Show();
        }
    }
}
