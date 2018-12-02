using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BearingMachineTesting;
using BearingMachineModels;

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
            SimulationSystem system = new SimulationSystem();

            return system;
        }
        private void StartSimulationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
