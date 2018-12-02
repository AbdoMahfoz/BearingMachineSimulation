namespace BearingMachineSimulation
{
    partial class Form2
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
            this.CurrentTable = new System.Windows.Forms.DataGridView();
            this.PropsedTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentBearingCost = new System.Windows.Forms.Label();
            this.CurrentTotalCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CurrentRepairPersonCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CurrentDownTimeCost = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CurrentDelayCost = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ProposedDelayCost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProposedDowntimeCost = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ProposedRepairPersonCost = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ProposedTotalCost = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ProposedBearingCost = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LifeHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccumulatedLifeHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RD2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropsedTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentTable
            // 
            this.CurrentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.RD,
            this.LifeHours,
            this.AccumulatedLifeHours,
            this.RD2,
            this.Delay});
            this.CurrentTable.Location = new System.Drawing.Point(42, 40);
            this.CurrentTable.Name = "CurrentTable";
            this.CurrentTable.Size = new System.Drawing.Size(368, 328);
            this.CurrentTable.TabIndex = 0;
            // 
            // PropsedTable
            // 
            this.PropsedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropsedTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.Column1});
            this.PropsedTable.Location = new System.Drawing.Point(454, 40);
            this.PropsedTable.Name = "PropsedTable";
            this.PropsedTable.Size = new System.Drawing.Size(307, 328);
            this.PropsedTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "First Faliure";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Accumulated life hours";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "RD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delay";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Policy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proposed Policy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bearing cost = ";
            // 
            // CurrentBearingCost
            // 
            this.CurrentBearingCost.AutoSize = true;
            this.CurrentBearingCost.Location = new System.Drawing.Point(250, 380);
            this.CurrentBearingCost.Name = "CurrentBearingCost";
            this.CurrentBearingCost.Size = new System.Drawing.Size(35, 13);
            this.CurrentBearingCost.TabIndex = 5;
            this.CurrentBearingCost.Text = "label4";
            // 
            // CurrentTotalCost
            // 
            this.CurrentTotalCost.AutoSize = true;
            this.CurrentTotalCost.Location = new System.Drawing.Point(250, 432);
            this.CurrentTotalCost.Name = "CurrentTotalCost";
            this.CurrentTotalCost.Size = new System.Drawing.Size(35, 13);
            this.CurrentTotalCost.TabIndex = 9;
            this.CurrentTotalCost.Text = "label4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total cost = ";
            // 
            // CurrentRepairPersonCost
            // 
            this.CurrentRepairPersonCost.AutoSize = true;
            this.CurrentRepairPersonCost.Location = new System.Drawing.Point(250, 419);
            this.CurrentRepairPersonCost.Name = "CurrentRepairPersonCost";
            this.CurrentRepairPersonCost.Size = new System.Drawing.Size(35, 13);
            this.CurrentRepairPersonCost.TabIndex = 11;
            this.CurrentRepairPersonCost.Text = "label4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Repair person cost = ";
            // 
            // CurrentDownTimeCost
            // 
            this.CurrentDownTimeCost.AutoSize = true;
            this.CurrentDownTimeCost.Location = new System.Drawing.Point(250, 406);
            this.CurrentDownTimeCost.Name = "CurrentDownTimeCost";
            this.CurrentDownTimeCost.Size = new System.Drawing.Size(35, 13);
            this.CurrentDownTimeCost.TabIndex = 13;
            this.CurrentDownTimeCost.Text = "label4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(155, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Downtime cost = ";
            // 
            // CurrentDelayCost
            // 
            this.CurrentDelayCost.AutoSize = true;
            this.CurrentDelayCost.Location = new System.Drawing.Point(250, 393);
            this.CurrentDelayCost.Name = "CurrentDelayCost";
            this.CurrentDelayCost.Size = new System.Drawing.Size(35, 13);
            this.CurrentDelayCost.TabIndex = 15;
            this.CurrentDelayCost.Text = "label4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(175, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Delay cost = ";
            // 
            // ProposedDelayCost
            // 
            this.ProposedDelayCost.AutoSize = true;
            this.ProposedDelayCost.Location = new System.Drawing.Point(632, 393);
            this.ProposedDelayCost.Name = "ProposedDelayCost";
            this.ProposedDelayCost.Size = new System.Drawing.Size(35, 13);
            this.ProposedDelayCost.TabIndex = 25;
            this.ProposedDelayCost.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Delay cost = ";
            // 
            // ProposedDowntimeCost
            // 
            this.ProposedDowntimeCost.AutoSize = true;
            this.ProposedDowntimeCost.Location = new System.Drawing.Point(632, 406);
            this.ProposedDowntimeCost.Name = "ProposedDowntimeCost";
            this.ProposedDowntimeCost.Size = new System.Drawing.Size(35, 13);
            this.ProposedDowntimeCost.TabIndex = 23;
            this.ProposedDowntimeCost.Text = "label4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(537, 406);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Downtime cost = ";
            // 
            // ProposedRepairPersonCost
            // 
            this.ProposedRepairPersonCost.AutoSize = true;
            this.ProposedRepairPersonCost.Location = new System.Drawing.Point(632, 419);
            this.ProposedRepairPersonCost.Name = "ProposedRepairPersonCost";
            this.ProposedRepairPersonCost.Size = new System.Drawing.Size(35, 13);
            this.ProposedRepairPersonCost.TabIndex = 21;
            this.ProposedRepairPersonCost.Text = "label4";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(518, 419);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Repair person cost = ";
            // 
            // ProposedTotalCost
            // 
            this.ProposedTotalCost.AutoSize = true;
            this.ProposedTotalCost.Location = new System.Drawing.Point(632, 432);
            this.ProposedTotalCost.Name = "ProposedTotalCost";
            this.ProposedTotalCost.Size = new System.Drawing.Size(35, 13);
            this.ProposedTotalCost.TabIndex = 19;
            this.ProposedTotalCost.Text = "label4";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(560, 432);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Total cost = ";
            // 
            // ProposedBearingCost
            // 
            this.ProposedBearingCost.AutoSize = true;
            this.ProposedBearingCost.Location = new System.Drawing.Point(632, 380);
            this.ProposedBearingCost.Name = "ProposedBearingCost";
            this.ProposedBearingCost.Size = new System.Drawing.Size(35, 13);
            this.ProposedBearingCost.TabIndex = 17;
            this.ProposedBearingCost.Text = "label4";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(548, 380);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Bearing cost = ";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "#";
            this.Column2.Name = "Column2";
            this.Column2.Width = 20;
            // 
            // RD
            // 
            this.RD.HeaderText = "RD";
            this.RD.Name = "RD";
            this.RD.Width = 40;
            // 
            // LifeHours
            // 
            this.LifeHours.HeaderText = "Life Hours";
            this.LifeHours.Name = "LifeHours";
            this.LifeHours.Width = 60;
            // 
            // AccumulatedLifeHours
            // 
            this.AccumulatedLifeHours.HeaderText = "Accumulated life hours";
            this.AccumulatedLifeHours.Name = "AccumulatedLifeHours";
            // 
            // RD2
            // 
            this.RD2.HeaderText = "RD";
            this.RD2.Name = "RD2";
            this.RD2.Width = 40;
            // 
            // Delay
            // 
            this.Delay.HeaderText = "Delay";
            this.Delay.Name = "Delay";
            this.Delay.Width = 40;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProposedDelayCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProposedDowntimeCost);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ProposedRepairPersonCost);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ProposedTotalCost);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ProposedBearingCost);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.CurrentDelayCost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CurrentDownTimeCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CurrentRepairPersonCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CurrentTotalCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CurrentBearingCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PropsedTable);
            this.Controls.Add(this.CurrentTable);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropsedTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CurrentTable;
        private System.Windows.Forms.DataGridView PropsedTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentBearingCost;
        private System.Windows.Forms.Label CurrentTotalCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CurrentRepairPersonCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CurrentDownTimeCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label CurrentDelayCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ProposedDelayCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProposedDowntimeCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label ProposedRepairPersonCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label ProposedTotalCost;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label ProposedBearingCost;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LifeHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccumulatedLifeHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn RD2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
    }
}