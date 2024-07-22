using System;
using System.Collections.Generic;

namespace MetricsVisualizer
{
    internal class CurvesBuilder
    {
        private static ChartForm chartForm;
        private static List<String> distanceFunction;
        private static String curveBuilt;

        private static Double minX;
        private static Double maxX;
        private static Double minY;
        private static Double maxY;

        // Help functions
        private static void CreateChartForm()
        {
            chartForm = new ChartForm();
            chartForm.Show();
        }
        private static void UpdateMainChartLimits()
        {
            minX = chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisX.Minimum;
            maxX = chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisX.Maximum;
            minY = chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisY.Minimum;
            maxY = chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisY.Maximum;
        }
        private static void UpdateDistanceFunction()
        {
            distanceFunction = FunctionsHandler.GetDistanceFunction(Program.mainForm.metricsTextBox.Text);
        }

        // Main
        private static void UpdateCurve()
        {
            if (curveBuilt == "Ellipse")
                UpdateEllipse(MainForm.ellipseForm.focus1X, MainForm.ellipseForm.focus1Y, MainForm.ellipseForm.focus2X, MainForm.ellipseForm.focus2Y, MainForm.ellipseForm.constant);
            if (curveBuilt == "Lemniscate")
                UpdateLemniscate(MainForm.lemniscateForm.focus1X, MainForm.lemniscateForm.focus1Y, MainForm.lemniscateForm.focus2X, MainForm.lemniscateForm.focus2Y, MainForm.lemniscateForm.constant);
            if (curveBuilt == "Hyperbola")
                UpdateHyperbola(MainForm.hyperbolaForm.focus1X, MainForm.hyperbolaForm.focus1Y, MainForm.hyperbolaForm.focus2X, MainForm.hyperbolaForm.focus2Y, MainForm.hyperbolaForm.constant);
        }

        // Ellipse
        public static void CreateEllipse(Double focus1X, Double focus1Y, Double focus2X, Double focus2y, Double constant)
        {
            curveBuilt = "Ellipse";
            UpdateDistanceFunction();
            CreateChartForm();
            UpdateEllipse(focus1X, focus1Y, focus2X, focus2y, constant);
        }
        private static void UpdateEllipse(Double focus1X, Double focus1Y, Double focus2X, Double focus2y, Double constant)
        {
            chartForm.mainChart.Series.FindByName("mainSeries").Points.Clear();
            UpdateMainChartLimits();
            for (Double x = minX; x <= maxX; x += 0.01d)
                for (Double y = minY; y <= maxY; y += 0.01d)
                    if (Math.Abs(FunctionsHandler.GetDistance(distanceFunction, x, y, focus1X, focus1Y) + FunctionsHandler.GetDistance(distanceFunction, x, y, focus2X, focus2y) - constant) <= 0.01d)
                        chartForm.mainChart.Series.FindByName("mainSeries").Points.AddXY(x, y);
        }

        // Lemniscate
        public static void CreateLemniscate(Double focus1X, Double focus1Y, Double focus2X, Double focus2y, Double constant)
        {
            curveBuilt = "Lemniscate";
            UpdateDistanceFunction();
            CreateChartForm();
            UpdateLemniscate(focus1X, focus1Y, focus2X, focus2y, constant);
        }
        private static void UpdateLemniscate(Double focus1X, Double focus1Y, Double focus2X, Double focus2y, Double constant)
        {
            chartForm.mainChart.Series.FindByName("mainSeries").Points.Clear();
            UpdateMainChartLimits();
            for (Double x = minX; x <= maxX; x += 0.01d)
                for (Double y = minY; y <= maxY; y += 0.01d)
                    if (Math.Abs(FunctionsHandler.GetDistance(distanceFunction, x, y, focus1X, focus1Y) * FunctionsHandler.GetDistance(distanceFunction, x, y, focus2X, focus2y) - constant) <= 0.01d)
                        chartForm.mainChart.Series.FindByName("mainSeries").Points.AddXY(x, y);
        }

        // Hyperbola
        public static void CreateHyperbola(Double focus1X, Double focus1Y, Double focus2X, Double focus2y, Double constant)
        {
            curveBuilt = "Hyperbola";
            UpdateDistanceFunction();
            CreateChartForm();
            UpdateHyperbola(focus1X, focus1Y, focus2X, focus2y, constant);
        }
        private static void UpdateHyperbola(Double focus1X, Double focus1Y, Double focus2X, Double focus2y, Double constant)
        {
            chartForm.mainChart.Series.FindByName("mainSeries").Points.Clear();
            UpdateMainChartLimits();
            for (Double x = minX; x <= maxX; x += 0.01d)
                for (Double y = minY; y <= maxY; y += 0.01d)
                    if (Math.Abs(Math.Abs(FunctionsHandler.GetDistance(distanceFunction, x, y, focus1X, focus1Y) - FunctionsHandler.GetDistance(distanceFunction, x, y, focus2X, focus2y)) - constant) <= 0.01d)
                        chartForm.mainChart.Series.FindByName("mainSeries").Points.AddXY(x, y);
        }

        // Chart moving functions
        public static void MoveChartLeftButtonClick(object sender, EventArgs e)
        {
            --chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisX.Minimum;
            --chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisX.Maximum;
            UpdateCurve();
        }
        public static void MoveChartRightButtonClick(object sender, EventArgs e)
        {
            ++chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisX.Minimum;
            ++chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisX.Maximum;
            UpdateCurve();
        }
        public static void MoveChartDownButtonClick(object sender, EventArgs e)
        {
            --chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisY.Minimum;
            --chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisY.Maximum;
            UpdateCurve();
        }
        public static void MoveChartUpButtonClick(object sender, EventArgs e)
        {
            ++chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisY.Minimum;
            ++chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisY.Maximum;
            UpdateCurve();
        }
        public static void ZoomInChartButtonClick(object sender, EventArgs e)
        {
            ++chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisX.Minimum;
            --chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisX.Maximum;
            ++chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisY.Minimum;
            --chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisY.Maximum;
            UpdateCurve();
        }
        public static void ZoomOutChartButtonClick(object sender, EventArgs e)
        {
            --chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisX.Minimum;
            ++chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisX.Maximum;
            --chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisY.Minimum;
            ++chartForm.mainChart.ChartAreas.FindByName("mainChartArea").AxisY.Maximum;
            UpdateCurve();
        }
    }
}
