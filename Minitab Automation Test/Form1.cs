using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minitab_Automation_Test
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Mtb.Application MtbApp = new Mtb.Application();
            Mtb.Project MtbProject = MtbApp.ActiveProject;
            Mtb.Worksheet MtbWorksheet = MtbProject.ActiveWorksheet;

            MtbApp.UserInterface.Visible = false;
            MtbApp.UserInterface.DisplayAlerts = false;
            try
            {
             //need to exe like %'c:\...\...\xx.mac' "99000R99" "1"
                string macro = "c:\\vm\\test.mac";
                string robotname = "24010R01";
                string appl = "Hand";
                string subgroup = "Clamp";

                MtbProject.ExecuteCommand("%'" + macro + "' \"" + robotname + "%\" \"" + appl + "%\" \"" + subgroup + "%\"");
                //MtbProject.ExecuteCommand("%'" + textBoxMacro.Text + "' \"" + textBoxRobot.Text + "\"");
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxOutput.Text = "Commands count: " + MtbProject.Commands.Count + Environment.NewLine;
            for (int i = 1; i <= MtbProject.Commands.Count; i++)
            {
                textBoxOutput.Text += "*******************************************************************************" + Environment.NewLine;
                textBoxOutput.Text += "*******************************************************************************" + Environment.NewLine;
                textBoxOutput.Text += "Command " + i + Environment.NewLine;
                textBoxOutput.Text += "Command name: " + MtbProject.Commands.Item(i).Name + Environment.NewLine;
                textBoxOutput.Text += "Outputs count: " + MtbProject.Commands.Item(i).Outputs.Count + Environment.NewLine;
                for (int j = 1; j <= MtbProject.Commands.Item(i).Outputs.Count; j++)
                {
                    textBoxOutput.Text += "-------------------------------------------------------------------------------" + Environment.NewLine;
                    textBoxOutput.Text += "Output " + j + Environment.NewLine;
                    textBoxOutput.Text += "Output type: " + MtbProject.Commands.Item(i).Outputs.Item(j).OutputType + Environment.NewLine;
                    textBoxOutput.Text += "Output text: " + MtbProject.Commands.Item(i).Outputs.Item(j).Text + Environment.NewLine;
                    if (MtbProject.Commands.Item(i).Outputs.Item(j).OutputType == Mtb.MtbOutputTypes.OTGraph)
                    {
                        MtbProject.Commands.Item(i).Outputs.Item(j).Graph.CopyToClipboard();
                        pictureBoxChart.Image = Clipboard.GetImage();
                    }
                }
            }
            while (MtbProject.Commands.Count > 0)
            {
                MtbProject.Commands.Remove(1);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialogMacro.ShowDialog();
            textBoxMacro.Text = openFileDialogMacro.FileName;
        }
    }
}
