using System;
using System.Windows.Forms;
using BearingMachineModels;

namespace BearingMachineSimulation
{
    public partial class Form2 : Form
    {
        SimulationSystem system;
        public Form2(SimulationSystem system)
        {
            this.system = system;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(CurrentSimulationCase t in system.CurrentSimulationTable)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.Bearing.Index.ToString()
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.Bearing.RandomHours.ToString()
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.Bearing.Hours.ToString()
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.AccumulatedHours.ToString()
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.RandomDelay.ToString()
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.Delay.ToString()
                });
                CurrentTable.Rows.Add(row);
            }
            foreach (ProposedSimulationCase t in system.ProposedSimulationTable)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.FirstFailure.ToString()
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.AccumulatedHours.ToString()
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.RandomDelay.ToString()
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.Delay.ToString()
                });
                PropsedTable.Rows.Add(row);
            }
            CurrentBearingCost.Text = system.CurrentPerformanceMeasures.BearingCost.ToString();
            CurrentDelayCost.Text = system.CurrentPerformanceMeasures.DelayCost.ToString();
            CurrentDownTimeCost.Text = system.CurrentPerformanceMeasures.DowntimeCost.ToString();
            CurrentRepairPersonCost.Text = system.CurrentPerformanceMeasures.RepairPersonCost.ToString();
            CurrentTotalCost.Text = system.CurrentPerformanceMeasures.TotalCost.ToString();
            ProposedDelayCost.Text = system.ProposedPerformanceMeasures.DelayCost.ToString();
            ProposedBearingCost.Text = system.ProposedPerformanceMeasures.BearingCost.ToString();
            ProposedDowntimeCost.Text = system.ProposedPerformanceMeasures.DowntimeCost.ToString();
            ProposedRepairPersonCost.Text = system.ProposedPerformanceMeasures.RepairPersonCost.ToString();
            ProposedTotalCost.Text = system.ProposedPerformanceMeasures.TotalCost.ToString();
        }
    }
}
