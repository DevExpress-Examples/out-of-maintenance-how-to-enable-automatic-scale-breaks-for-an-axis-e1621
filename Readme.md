<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/UseScaleBreaks/Form1.cs) (VB: [Form1.vb](./VB/UseScaleBreaks/Form1.vb))
<!-- default file list end -->
# How to enable automatic scale breaks for an axis


<p>This example demonstrates how an <a href="http://www.devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5803.htm">axis range</a> can be automatically split by <a href="http://www.devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument6232.htm">scale breaks</a>, if the chart's data suggests their use. To learn about an alternative approach - manual scale breaks creation, refer to <a href="https://www.devexpress.com/Support/Center/p/E1493">How to insert a scale break into an axis</a>.</p><p>Note that both auto-created and manual scale breaks on an axis can co-exist, without affecting the chart's output, in cases where their ranges interfere.</p><p>See also: <a href="https://www.devexpress.com/Support/Center/p/E1493">How to insert a scale break into an axis</a>.</p>


<h3>Description</h3>

<p>To enable automatic scale breaks, set the AutoScaleBreaks.Enabled property to <strong>true</strong>. To define the maximum number for automatic scale breaks, use the AutoScaleBreaks.MaxCount property.</p><p>In addition, you can use the Axis.ScaleBreakOptions property, to adjust the common appearance of both manual and auto-created scale breaks.</p>

<br/>


