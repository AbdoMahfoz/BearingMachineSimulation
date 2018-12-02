using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearingMachineModels;
using System.IO;

namespace BearingMachineSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SimulationSystem ExtractFromUI()
        {
            SimulationSystem system = new SimulationSystem
            {
                DowntimeCost = (int)DownTimeCost.Value,
                RepairPersonCost = (int)RepairPersonCost.Value,
                BearingCost = (int)BearingCost.Value,
                NumberOfHours = (int)NumberOfHours.Value,
                NumberOfBearings = (int)NumberOfBearings.Value,
                RepairTimeForOneBearing = (int)RepairTimeForOneBearing.Value,
                RepairTimeForAllBearings = (int)RepairTimeForAllBearing.Value
            };
            foreach (DataGridViewRow c in DelayTimeDistribution.Rows)
            {
                system.DelayTimeDistribution.Add(new TimeDistribution()
                {
                    Time = (int)c.Cells[0].Value,
                    Probability = (decimal)c.Cells[1].Value
                });
            }
            foreach (DataGridViewRow c in BearingLifeDistribution.Rows)
            {
                system.BearingLifeDistribution.Add(new TimeDistribution()
                {
                    Time = (int)c.Cells[0].Value,
                    Probability = (decimal)c.Cells[1].Value
                });
            }
            return system;
        }
        private void PutSystemOnUI(SimulationSystem system)
        {
            DownTimeCost.Value = system.DowntimeCost;
            RepairPersonCost.Value = system.RepairPersonCost;
            BearingCost.Value = system.BearingCost;
            NumberOfHours.Value = system.NumberOfHours;
            NumberOfBearings.Value = system.NumberOfBearings;
            RepairTimeForOneBearing.Value = system.RepairTimeForOneBearing;
            RepairTimeForAllBearing.Value = system.RepairTimeForAllBearings;
            foreach(TimeDistribution t in system.DelayTimeDistribution)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.Time.ToString()  
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.Probability.ToString()
                });
                DelayTimeDistribution.Rows.Add(row);
            }
            foreach (TimeDistribution t in system.BearingLifeDistribution)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.Time.ToString()
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = t.Probability.ToString()
                });
                BearingLifeDistribution.Rows.Add(row);
            }
        }
        private void Clear()
        {
            foreach(Control c in Controls)
            {
                if(c.GetType() == typeof(NumericUpDown))
                {
                    ((NumericUpDown)c).Value = 0;
                }
                if(c.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)c).Rows.Clear();
                }
            }
        }
        private void DisableAllControls()
        {
            foreach(Control c in Controls)
            {
                c.Enabled = false;
            }
        }
        private void EnableAllControls()
        {
            foreach(Control c in Controls)
            {
                c.Enabled = true;
            }
        }
        private void StartSimulationButton_Click(object sender, EventArgs e)
        {
            SimulationSystem system = ExtractFromUI();

        }
        private async void AutomaticTestingButton_Click(object sender, EventArgs e)
        {
            DisableAllControls();
            await Task.Run(() => MessageBox.Show(TestCaseManager.RunAllTestCases()));
            EnableAllControls();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void LoadFromFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = false,
                InitialDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\TestCases\\",
                Filter = "Text File|*.txt"
            };
            dialog.ShowDialog();
            SimulationSystem system;
            try
            {
                system = TestCaseManager.FromFile(dialog.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid File");
                return;
            }
            Clear();
            PutSystemOnUI(system);
        }
        private void ExportToFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to write this to a file?\n" + TestCaseManager.ToString(ExtractFromUI()), "Export confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog
            {
                InitialDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\TestCases\\",
                Filter = "Text File|*.txt"
            };
            dialog.ShowDialog();
            try
            {
                TestCaseManager.ToFile(ExtractFromUI(), dialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to file\nReason: " + ex.Message);
                return;
            }
            MessageBox.Show("Successfully exported to file");
        }
    }
}
