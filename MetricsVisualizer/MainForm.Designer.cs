namespace MetricsVisualizer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metricsReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.metricsTextBox = new System.Windows.Forms.TextBox();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.hyperbolaButton = new System.Windows.Forms.Button();
            this.faqButton = new System.Windows.Forms.Button();
            this.lemniscateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metricsReadOnlyTextBox
            // 
            this.metricsReadOnlyTextBox.Location = new System.Drawing.Point(12, 12);
            this.metricsReadOnlyTextBox.Name = "metricsReadOnlyTextBox";
            this.metricsReadOnlyTextBox.ReadOnly = true;
            this.metricsReadOnlyTextBox.Size = new System.Drawing.Size(54, 20);
            this.metricsReadOnlyTextBox.TabIndex = 0;
            this.metricsReadOnlyTextBox.TabStop = false;
            this.metricsReadOnlyTextBox.Text = "Метрика";
            this.metricsReadOnlyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metricsTextBox
            // 
            this.metricsTextBox.Location = new System.Drawing.Point(72, 12);
            this.metricsTextBox.Name = "metricsTextBox";
            this.metricsTextBox.Size = new System.Drawing.Size(252, 20);
            this.metricsTextBox.TabIndex = 0;
            // 
            // ellipseButton
            // 
            this.ellipseButton.Location = new System.Drawing.Point(12, 38);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(100, 20);
            this.ellipseButton.TabIndex = 1;
            this.ellipseButton.Text = "Эллипс";
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButtonClick);
            // 
            // hyperbolaButton
            // 
            this.hyperbolaButton.Location = new System.Drawing.Point(224, 38);
            this.hyperbolaButton.Name = "hyperbolaButton";
            this.hyperbolaButton.Size = new System.Drawing.Size(100, 20);
            this.hyperbolaButton.TabIndex = 3;
            this.hyperbolaButton.Text = "Гипербола";
            this.hyperbolaButton.UseVisualStyleBackColor = true;
            this.hyperbolaButton.Click += new System.EventHandler(this.hyperbolaButtonClick);
            // 
            // faqButton
            // 
            this.faqButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.faqButton.Location = new System.Drawing.Point(118, 64);
            this.faqButton.Name = "faqButton";
            this.faqButton.Size = new System.Drawing.Size(100, 20);
            this.faqButton.TabIndex = 4;
            this.faqButton.Text = "Инструкция";
            this.faqButton.UseVisualStyleBackColor = false;
            this.faqButton.Click += new System.EventHandler(this.faqButtonClick);
            // 
            // lemniscateButton
            // 
            this.lemniscateButton.Location = new System.Drawing.Point(118, 38);
            this.lemniscateButton.Name = "lemniscateButton";
            this.lemniscateButton.Size = new System.Drawing.Size(100, 20);
            this.lemniscateButton.TabIndex = 2;
            this.lemniscateButton.Text = "Лемниската";
            this.lemniscateButton.UseVisualStyleBackColor = true;
            this.lemniscateButton.Click += new System.EventHandler(this.lemniscateButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 95);
            this.Controls.Add(this.lemniscateButton);
            this.Controls.Add(this.faqButton);
            this.Controls.Add(this.hyperbolaButton);
            this.Controls.Add(this.ellipseButton);
            this.Controls.Add(this.metricsTextBox);
            this.Controls.Add(this.metricsReadOnlyTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(352, 134);
            this.MinimumSize = new System.Drawing.Size(352, 134);
            this.Name = "MainForm";
            this.Text = "Визуализатор метрик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox metricsReadOnlyTextBox;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button hyperbolaButton;
        private System.Windows.Forms.Button faqButton;
        public System.Windows.Forms.TextBox metricsTextBox;
        private System.Windows.Forms.Button lemniscateButton;
    }
}

