Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace UseScaleBreaks
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Cast your diagram object to an appropriate diagram type,
            ' to access its axes.
            Dim diagram As XYDiagram = CType(chartControl1.Diagram, XYDiagram)

            ' Enable automatic scale breaks creation, 
            ' and define their maximum number.
            diagram.AxisY.AutoScaleBreaks.Enabled = True
            diagram.AxisY.AutoScaleBreaks.MaxCount = 5

            ' Define the scale breaks' options, which are common
            ' for both manual and automatic scale breaks.
            diagram.AxisY.ScaleBreakOptions.Style = ScaleBreakStyle.Waved
            diagram.AxisY.ScaleBreakOptions.SizeInPixels = 30
            diagram.AxisY.ScaleBreakOptions.Color = Color.Turquoise
        End Sub
    End Class
End Namespace
