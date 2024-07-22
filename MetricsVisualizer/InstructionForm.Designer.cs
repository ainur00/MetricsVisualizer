namespace MetricsVisualizer
{
    partial class InstructionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.instructionReadOnlyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionReadOnlyTextBox
            // 
            this.instructionReadOnlyTextBox.Location = new System.Drawing.Point(12, 12);
            this.instructionReadOnlyTextBox.Multiline = true;
            this.instructionReadOnlyTextBox.Name = "instructionReadOnlyTextBox";
            this.instructionReadOnlyTextBox.ReadOnly = true;
            this.instructionReadOnlyTextBox.Size = new System.Drawing.Size(312, 242);
            this.instructionReadOnlyTextBox.TabIndex = 0;
            this.instructionReadOnlyTextBox.TabStop = false;
            this.instructionReadOnlyTextBox.Text = resources.GetString("instructionReadOnlyTextBox.Text");
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 266);
            this.Controls.Add(this.instructionReadOnlyTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(352, 305);
            this.MinimumSize = new System.Drawing.Size(352, 305);
            this.Name = "InstructionForm";
            this.Text = "Инструкция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox instructionReadOnlyTextBox;
    }
}