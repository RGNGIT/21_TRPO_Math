namespace _21_TRPO_Math
{
    partial class App
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartNormal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResultNormal = new System.Windows.Forms.DataGridView();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chartExp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResultExp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultExp)).BeginInit();
            this.SuspendLayout();
            // 
            // chartNormal
            // 
            chartArea3.Name = "ChartArea1";
            this.chartNormal.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartNormal.Legends.Add(legend3);
            this.chartNormal.Location = new System.Drawing.Point(12, 12);
            this.chartNormal.Name = "chartNormal";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartNormal.Series.Add(series3);
            this.chartNormal.Size = new System.Drawing.Size(547, 426);
            this.chartNormal.TabIndex = 0;
            this.chartNormal.Text = "chart1";
            // 
            // dataGridViewResultNormal
            // 
            this.dataGridViewResultNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultNormal.Location = new System.Drawing.Point(565, 11);
            this.dataGridViewResultNormal.Name = "dataGridViewResultNormal";
            this.dataGridViewResultNormal.Size = new System.Drawing.Size(317, 426);
            this.dataGridViewResultNormal.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(565, 847);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(317, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "button1";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chartExp
            // 
            chartArea4.Name = "ChartArea1";
            this.chartExp.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartExp.Legends.Add(legend4);
            this.chartExp.Location = new System.Drawing.Point(12, 444);
            this.chartExp.Name = "chartExp";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartExp.Series.Add(series4);
            this.chartExp.Size = new System.Drawing.Size(547, 426);
            this.chartExp.TabIndex = 3;
            this.chartExp.Text = "chart1";
            // 
            // dataGridViewResultExp
            // 
            this.dataGridViewResultExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultExp.Location = new System.Drawing.Point(565, 443);
            this.dataGridViewResultExp.Name = "dataGridViewResultExp";
            this.dataGridViewResultExp.Size = new System.Drawing.Size(317, 398);
            this.dataGridViewResultExp.TabIndex = 4;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 884);
            this.Controls.Add(this.dataGridViewResultExp);
            this.Controls.Add(this.chartExp);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.dataGridViewResultNormal);
            this.Controls.Add(this.chartNormal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "App";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultExp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartNormal;
        private System.Windows.Forms.DataGridView dataGridViewResultNormal;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExp;
        private System.Windows.Forms.DataGridView dataGridViewResultExp;
    }
}

