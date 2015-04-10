namespace Minitab_Automation_Test
{
    partial class FormMain
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
            this.buttonTest = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelRobot = new System.Windows.Forms.Label();
            this.textBoxRobot = new System.Windows.Forms.TextBox();
            this.labelChart = new System.Windows.Forms.Label();
            this.pictureBoxChart = new System.Windows.Forms.PictureBox();
            this.labelMacro = new System.Windows.Forms.Label();
            this.textBoxMacro = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialogMacro = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(169, 25);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(171, 54);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "TEST";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(692, 25);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(580, 591);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.WordWrap = false;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(689, 9);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(42, 13);
            this.labelOutput.TabIndex = 2;
            this.labelOutput.Text = "Output:";
            // 
            // labelRobot
            // 
            this.labelRobot.AutoSize = true;
            this.labelRobot.Location = new System.Drawing.Point(12, 108);
            this.labelRobot.Name = "labelRobot";
            this.labelRobot.Size = new System.Drawing.Size(39, 13);
            this.labelRobot.TabIndex = 3;
            this.labelRobot.Text = "Robot:";
            // 
            // textBoxRobot
            // 
            this.textBoxRobot.Location = new System.Drawing.Point(57, 105);
            this.textBoxRobot.Name = "textBoxRobot";
            this.textBoxRobot.Size = new System.Drawing.Size(72, 20);
            this.textBoxRobot.TabIndex = 4;
            this.textBoxRobot.Text = "53110R01";
            // 
            // labelChart
            // 
            this.labelChart.AutoSize = true;
            this.labelChart.Location = new System.Drawing.Point(12, 143);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(35, 13);
            this.labelChart.TabIndex = 5;
            this.labelChart.Text = "Chart:";
            // 
            // pictureBoxChart
            // 
            this.pictureBoxChart.Location = new System.Drawing.Point(12, 159);
            this.pictureBoxChart.Name = "pictureBoxChart";
            this.pictureBoxChart.Size = new System.Drawing.Size(674, 457);
            this.pictureBoxChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChart.TabIndex = 6;
            this.pictureBoxChart.TabStop = false;
            // 
            // labelMacro
            // 
            this.labelMacro.AutoSize = true;
            this.labelMacro.Location = new System.Drawing.Point(135, 108);
            this.labelMacro.Name = "labelMacro";
            this.labelMacro.Size = new System.Drawing.Size(80, 13);
            this.labelMacro.TabIndex = 7;
            this.labelMacro.Text = "Macro location:";
            // 
            // textBoxMacro
            // 
            this.textBoxMacro.Location = new System.Drawing.Point(221, 105);
            this.textBoxMacro.Name = "textBoxMacro";
            this.textBoxMacro.Size = new System.Drawing.Size(389, 20);
            this.textBoxMacro.TabIndex = 8;
            this.textBoxMacro.Text = "C:\\Users\\SDEBEUL\\Documents\\Visual Studio 2013\\Projects\\Minitab Automation Test\\Mi" +
    "nitab automation test.mac";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(616, 99);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(68, 31);
            this.buttonBrowse.TabIndex = 9;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialogMacro
            // 
            this.openFileDialogMacro.Filter = "Macro Files(*.MAC;*.MTB)|*.MAC;*.MTB|All files (*.*)|*.* ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 628);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxMacro);
            this.Controls.Add(this.labelMacro);
            this.Controls.Add(this.pictureBoxChart);
            this.Controls.Add(this.labelChart);
            this.Controls.Add(this.textBoxRobot);
            this.Controls.Add(this.labelRobot);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonTest);
            this.Name = "FormMain";
            this.Text = "Minitab Automation Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelRobot;
        private System.Windows.Forms.TextBox textBoxRobot;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.PictureBox pictureBoxChart;
        private System.Windows.Forms.Label labelMacro;
        private System.Windows.Forms.TextBox textBoxMacro;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialogMacro;
    }
}

