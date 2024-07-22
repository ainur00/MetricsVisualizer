namespace MetricsVisualizer
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.moveChartLeftButton = new System.Windows.Forms.Button();
            this.moveChartRightButton = new System.Windows.Forms.Button();
            this.moveChartUpButton = new System.Windows.Forms.Button();
            this.moveChartDownButton = new System.Windows.Forms.Button();
            this.zoomInChartButton = new System.Windows.Forms.Button();
            this.zoomOutChartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 7;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 7;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.Maximum = 2D;
            chartArea1.AxisX.Minimum = -2D;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 7;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 7;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.Maximum = 2D;
            chartArea1.AxisY.Minimum = -2D;
            chartArea1.Name = "mainChartArea";
            this.mainChart.ChartAreas.Add(chartArea1);
            this.mainChart.Location = new System.Drawing.Point(12, 12);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "mainChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Name = "mainSeries";
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(472, 449);
            this.mainChart.TabIndex = 0;
            this.mainChart.TabStop = false;
            this.mainChart.Text = "Chart";
            // 
            // moveChartLeftButton
            // 
            this.moveChartLeftButton.Location = new System.Drawing.Point(12, 467);
            this.moveChartLeftButton.Name = "moveChartLeftButton";
            this.moveChartLeftButton.Size = new System.Drawing.Size(113, 23);
            this.moveChartLeftButton.TabIndex = 0;
            this.moveChartLeftButton.Text = "Левее";
            this.moveChartLeftButton.UseVisualStyleBackColor = true;
            this.moveChartLeftButton.Click += new System.EventHandler(CurvesBuilder.MoveChartLeftButtonClick);
            // 
            // moveChartRightButton
            // 
            this.moveChartRightButton.Location = new System.Drawing.Point(131, 467);
            this.moveChartRightButton.Name = "moveChartRightButton";
            this.moveChartRightButton.Size = new System.Drawing.Size(113, 23);
            this.moveChartRightButton.TabIndex = 1;
            this.moveChartRightButton.Text = "Правее";
            this.moveChartRightButton.UseVisualStyleBackColor = true;
            this.moveChartRightButton.Click += new System.EventHandler(CurvesBuilder.MoveChartRightButtonClick);
            // 
            // moveChartUpButton
            // 
            this.moveChartUpButton.Location = new System.Drawing.Point(252, 467);
            this.moveChartUpButton.Name = "moveChartUpButton";
            this.moveChartUpButton.Size = new System.Drawing.Size(113, 23);
            this.moveChartUpButton.TabIndex = 2;
            this.moveChartUpButton.Text = "Выше";
            this.moveChartUpButton.UseVisualStyleBackColor = true;
            this.moveChartUpButton.Click += new System.EventHandler(CurvesBuilder.MoveChartUpButtonClick);
            // 
            // moveChartDownButton
            // 
            this.moveChartDownButton.Location = new System.Drawing.Point(371, 467);
            this.moveChartDownButton.Name = "moveChartDownButton";
            this.moveChartDownButton.Size = new System.Drawing.Size(113, 23);
            this.moveChartDownButton.TabIndex = 3;
            this.moveChartDownButton.Text = "Ниже";
            this.moveChartDownButton.UseVisualStyleBackColor = true;
            this.moveChartDownButton.Click += new System.EventHandler(CurvesBuilder.MoveChartDownButtonClick);
            // 
            // zoomInChartButton
            // 
            this.zoomInChartButton.Location = new System.Drawing.Point(12, 496);
            this.zoomInChartButton.Name = "zoomInChartButton";
            this.zoomInChartButton.Size = new System.Drawing.Size(232, 23);
            this.zoomInChartButton.TabIndex = 4;
            this.zoomInChartButton.Text = "Крупнее";
            this.zoomInChartButton.UseVisualStyleBackColor = true;
            this.zoomInChartButton.Click += new System.EventHandler(CurvesBuilder.ZoomInChartButtonClick);
            // 
            // zoomOutChartButton
            // 
            this.zoomOutChartButton.Location = new System.Drawing.Point(252, 496);
            this.zoomOutChartButton.Name = "zoomOutChartButton";
            this.zoomOutChartButton.Size = new System.Drawing.Size(232, 23);
            this.zoomOutChartButton.TabIndex = 5;
            this.zoomOutChartButton.Text = "Мельче";
            this.zoomOutChartButton.UseVisualStyleBackColor = true;
            this.zoomOutChartButton.Click += new System.EventHandler(CurvesBuilder.ZoomOutChartButtonClick);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 529);
            this.Controls.Add(this.zoomOutChartButton);
            this.Controls.Add(this.zoomInChartButton);
            this.Controls.Add(this.moveChartDownButton);
            this.Controls.Add(this.moveChartUpButton);
            this.Controls.Add(this.moveChartRightButton);
            this.Controls.Add(this.moveChartLeftButton);
            this.Controls.Add(this.mainChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(512, 568);
            this.MinimumSize = new System.Drawing.Size(512, 568);
            this.Name = "ChartForm";
            this.Text = "Отображение кривой";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Button moveChartLeftButton;
        private System.Windows.Forms.Button moveChartRightButton;
        private System.Windows.Forms.Button moveChartUpButton;
        private System.Windows.Forms.Button moveChartDownButton;
        private System.Windows.Forms.Button zoomInChartButton;
        private System.Windows.Forms.Button zoomOutChartButton;
    }
}