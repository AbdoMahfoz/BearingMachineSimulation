namespace BearingMachineSimulation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExportToFileButton = new System.Windows.Forms.Button();
            this.LoadFromFileButton = new System.Windows.Forms.Button();
            this.AutomaticTestingButton = new System.Windows.Forms.Button();
            this.StartSimulationButton = new System.Windows.Forms.Button();
            this.DownTimeCost = new System.Windows.Forms.NumericUpDown();
            this.RepairPersonCost = new System.Windows.Forms.NumericUpDown();
            this.BearingCost = new System.Windows.Forms.NumericUpDown();
            this.NumberOfHours = new System.Windows.Forms.NumericUpDown();
            this.NumberOfBearings = new System.Windows.Forms.NumericUpDown();
            this.RepairTimeForOneBearing = new System.Windows.Forms.NumericUpDown();
            this.RepairTimeForAllBearing = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DelayTimeDistribution = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.BearingLifeDistribution = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DownTimeCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairPersonCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BearingCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBearings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairTimeForOneBearing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairTimeForAllBearing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTimeDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BearingLifeDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(452, 223);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(134, 28);
            this.ClearButton.TabIndex = 27;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExportToFileButton
            // 
            this.ExportToFileButton.Location = new System.Drawing.Point(452, 192);
            this.ExportToFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExportToFileButton.Name = "ExportToFileButton";
            this.ExportToFileButton.Size = new System.Drawing.Size(134, 28);
            this.ExportToFileButton.TabIndex = 26;
            this.ExportToFileButton.Text = "Export To File";
            this.ExportToFileButton.UseVisualStyleBackColor = true;
            this.ExportToFileButton.Click += new System.EventHandler(this.ExportToFileButton_Click);
            // 
            // LoadFromFileButton
            // 
            this.LoadFromFileButton.Location = new System.Drawing.Point(452, 161);
            this.LoadFromFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadFromFileButton.Name = "LoadFromFileButton";
            this.LoadFromFileButton.Size = new System.Drawing.Size(134, 28);
            this.LoadFromFileButton.TabIndex = 25;
            this.LoadFromFileButton.Text = "Load From File";
            this.LoadFromFileButton.UseVisualStyleBackColor = true;
            this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButton_Click);
            // 
            // AutomaticTestingButton
            // 
            this.AutomaticTestingButton.Location = new System.Drawing.Point(452, 130);
            this.AutomaticTestingButton.Margin = new System.Windows.Forms.Padding(2);
            this.AutomaticTestingButton.Name = "AutomaticTestingButton";
            this.AutomaticTestingButton.Size = new System.Drawing.Size(134, 28);
            this.AutomaticTestingButton.TabIndex = 24;
            this.AutomaticTestingButton.Text = "Automatic Testing";
            this.AutomaticTestingButton.UseVisualStyleBackColor = true;
            this.AutomaticTestingButton.Click += new System.EventHandler(this.AutomaticTestingButton_Click);
            // 
            // StartSimulationButton
            // 
            this.StartSimulationButton.Location = new System.Drawing.Point(452, 99);
            this.StartSimulationButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartSimulationButton.Name = "StartSimulationButton";
            this.StartSimulationButton.Size = new System.Drawing.Size(134, 28);
            this.StartSimulationButton.TabIndex = 23;
            this.StartSimulationButton.Text = "Start Simulation";
            this.StartSimulationButton.UseVisualStyleBackColor = true;
            this.StartSimulationButton.Click += new System.EventHandler(this.StartSimulationButton_Click);
            // 
            // DownTimeCost
            // 
            this.DownTimeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownTimeCost.Location = new System.Drawing.Point(225, 30);
            this.DownTimeCost.Margin = new System.Windows.Forms.Padding(2);
            this.DownTimeCost.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.DownTimeCost.Name = "DownTimeCost";
            this.DownTimeCost.Size = new System.Drawing.Size(51, 23);
            this.DownTimeCost.TabIndex = 28;
            // 
            // RepairPersonCost
            // 
            this.RepairPersonCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairPersonCost.Location = new System.Drawing.Point(225, 69);
            this.RepairPersonCost.Margin = new System.Windows.Forms.Padding(2);
            this.RepairPersonCost.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.RepairPersonCost.Name = "RepairPersonCost";
            this.RepairPersonCost.Size = new System.Drawing.Size(51, 23);
            this.RepairPersonCost.TabIndex = 29;
            // 
            // BearingCost
            // 
            this.BearingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BearingCost.Location = new System.Drawing.Point(225, 110);
            this.BearingCost.Margin = new System.Windows.Forms.Padding(2);
            this.BearingCost.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.BearingCost.Name = "BearingCost";
            this.BearingCost.Size = new System.Drawing.Size(51, 23);
            this.BearingCost.TabIndex = 30;
            // 
            // NumberOfHours
            // 
            this.NumberOfHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfHours.Location = new System.Drawing.Point(225, 147);
            this.NumberOfHours.Margin = new System.Windows.Forms.Padding(2);
            this.NumberOfHours.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumberOfHours.Name = "NumberOfHours";
            this.NumberOfHours.Size = new System.Drawing.Size(51, 23);
            this.NumberOfHours.TabIndex = 31;
            // 
            // NumberOfBearings
            // 
            this.NumberOfBearings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfBearings.Location = new System.Drawing.Point(225, 188);
            this.NumberOfBearings.Margin = new System.Windows.Forms.Padding(2);
            this.NumberOfBearings.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumberOfBearings.Name = "NumberOfBearings";
            this.NumberOfBearings.Size = new System.Drawing.Size(51, 23);
            this.NumberOfBearings.TabIndex = 32;
            // 
            // RepairTimeForOneBearing
            // 
            this.RepairTimeForOneBearing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairTimeForOneBearing.Location = new System.Drawing.Point(225, 233);
            this.RepairTimeForOneBearing.Margin = new System.Windows.Forms.Padding(2);
            this.RepairTimeForOneBearing.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.RepairTimeForOneBearing.Name = "RepairTimeForOneBearing";
            this.RepairTimeForOneBearing.Size = new System.Drawing.Size(51, 23);
            this.RepairTimeForOneBearing.TabIndex = 33;
            // 
            // RepairTimeForAllBearing
            // 
            this.RepairTimeForAllBearing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairTimeForAllBearing.Location = new System.Drawing.Point(225, 275);
            this.RepairTimeForAllBearing.Margin = new System.Windows.Forms.Padding(2);
            this.RepairTimeForAllBearing.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.RepairTimeForAllBearing.Name = "RepairTimeForAllBearing";
            this.RepairTimeForAllBearing.Size = new System.Drawing.Size(51, 23);
            this.RepairTimeForAllBearing.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "DowntimeCost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "RepairPersonCost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "BearingCost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = " NumberOfHours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "NumberOfBearings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "RepairTimeForOneBearing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "RepairTimeForAllBearings";
            // 
            // DelayTimeDistribution
            // 
            this.DelayTimeDistribution.AllowUserToResizeColumns = false;
            this.DelayTimeDistribution.AllowUserToResizeRows = false;
            this.DelayTimeDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DelayTimeDistribution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Probability});
            this.DelayTimeDistribution.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DelayTimeDistribution.Location = new System.Drawing.Point(288, 46);
            this.DelayTimeDistribution.Margin = new System.Windows.Forms.Padding(2);
            this.DelayTimeDistribution.Name = "DelayTimeDistribution";
            this.DelayTimeDistribution.RowTemplate.Height = 28;
            this.DelayTimeDistribution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DelayTimeDistribution.Size = new System.Drawing.Size(160, 114);
            this.DelayTimeDistribution.TabIndex = 42;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(291, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "DelayTimeDistribution";
            // 
            // BearingLifeDistribution
            // 
            this.BearingLifeDistribution.AllowUserToResizeColumns = false;
            this.BearingLifeDistribution.AllowUserToResizeRows = false;
            this.BearingLifeDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BearingLifeDistribution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.BearingLifeDistribution.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BearingLifeDistribution.Location = new System.Drawing.Point(288, 193);
            this.BearingLifeDistribution.Margin = new System.Windows.Forms.Padding(2);
            this.BearingLifeDistribution.Name = "BearingLifeDistribution";
            this.BearingLifeDistribution.RowTemplate.Height = 28;
            this.BearingLifeDistribution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BearingLifeDistribution.Size = new System.Drawing.Size(160, 114);
            this.BearingLifeDistribution.TabIndex = 44;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Life Time";
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Probability";
            this.Column3.Name = "Column3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(291, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "BearingLifeDistribution";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 324);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BearingLifeDistribution);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DelayTimeDistribution);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepairTimeForAllBearing);
            this.Controls.Add(this.RepairTimeForOneBearing);
            this.Controls.Add(this.NumberOfBearings);
            this.Controls.Add(this.NumberOfHours);
            this.Controls.Add(this.BearingCost);
            this.Controls.Add(this.RepairPersonCost);
            this.Controls.Add(this.DownTimeCost);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ExportToFileButton);
            this.Controls.Add(this.LoadFromFileButton);
            this.Controls.Add(this.AutomaticTestingButton);
            this.Controls.Add(this.StartSimulationButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Bearingzz";
            ((System.ComponentModel.ISupportInitialize)(this.DownTimeCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairPersonCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BearingCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBearings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairTimeForOneBearing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairTimeForAllBearing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayTimeDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BearingLifeDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExportToFileButton;
        private System.Windows.Forms.Button LoadFromFileButton;
        private System.Windows.Forms.Button AutomaticTestingButton;
        private System.Windows.Forms.Button StartSimulationButton;
        private System.Windows.Forms.NumericUpDown DownTimeCost;
        private System.Windows.Forms.NumericUpDown RepairPersonCost;
        private System.Windows.Forms.NumericUpDown BearingCost;
        private System.Windows.Forms.NumericUpDown NumberOfHours;
        private System.Windows.Forms.NumericUpDown NumberOfBearings;
        private System.Windows.Forms.NumericUpDown RepairTimeForOneBearing;
        private System.Windows.Forms.NumericUpDown RepairTimeForAllBearing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DelayTimeDistribution;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView BearingLifeDistribution;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}