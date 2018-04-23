using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace UseScaleBreaks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Cast your diagram object to an appropriate diagram type,
            // to access its axes.
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;

            // Enable automatic scale breaks creation, 
            // and define their maximum number.
            diagram.AxisY.AutoScaleBreaks.Enabled = true;
            diagram.AxisY.AutoScaleBreaks.MaxCount = 5;

            // Define the scale breaks' options, which are common
            // for both manual and automatic scale breaks.
            diagram.AxisY.ScaleBreakOptions.Style = ScaleBreakStyle.Waved;
            diagram.AxisY.ScaleBreakOptions.SizeInPixels = 30;
            diagram.AxisY.ScaleBreakOptions.Color = Color.Turquoise;
        }
    }
}
