namespace Supermodel.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            buttonBrowseAppPath = new Button();
            textBoxAppPath = new TextBox();
            labelAppPath = new Label();
            labelRomDescription = new Label();
            labelSettings = new Label();
            buttonSaveSettings = new Button();
            checkBoxFullscreen = new CheckBox();
            comboBoxResolution = new ComboBox();
            labelResolution = new Label();
            buttonRunRom = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 5, 4, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(buttonBrowseAppPath);
            splitContainer1.Panel2.Controls.Add(textBoxAppPath);
            splitContainer1.Panel2.Controls.Add(labelAppPath);
            splitContainer1.Panel2.Controls.Add(labelRomDescription);
            splitContainer1.Panel2.Controls.Add(labelSettings);
            splitContainer1.Panel2.Controls.Add(buttonSaveSettings);
            splitContainer1.Panel2.Controls.Add(checkBoxFullscreen);
            splitContainer1.Panel2.Controls.Add(comboBoxResolution);
            splitContainer1.Panel2.Controls.Add(labelResolution);
            splitContainer1.Panel2.Controls.Add(buttonRunRom);
            splitContainer1.Size = new Size(861, 739);
            splitContainer1.SplitterDistance = 283;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(0, 0);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(283, 739);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Rom Name";
            // 
            // buttonBrowseAppPath
            // 
            buttonBrowseAppPath.Location = new Point(411, 55);
            buttonBrowseAppPath.Name = "buttonBrowseAppPath";
            buttonBrowseAppPath.Size = new Size(124, 34);
            buttonBrowseAppPath.TabIndex = 1;
            buttonBrowseAppPath.Text = "App Path...";
            buttonBrowseAppPath.UseVisualStyleBackColor = true;
            buttonBrowseAppPath.Click += ButtonBrowseAppPathClick;
            // 
            // textBoxAppPath
            // 
            textBoxAppPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAppPath.Location = new Point(139, 58);
            textBoxAppPath.Margin = new Padding(4, 5, 4, 5);
            textBoxAppPath.Name = "textBoxAppPath";
            textBoxAppPath.Size = new Size(265, 31);
            textBoxAppPath.TabIndex = 0;
            // 
            // labelAppPath
            // 
            labelAppPath.AutoSize = true;
            labelAppPath.Location = new Point(33, 61);
            labelAppPath.Margin = new Padding(4, 0, 4, 0);
            labelAppPath.Name = "labelAppPath";
            labelAppPath.Size = new Size(89, 25);
            labelAppPath.TabIndex = 7;
            labelAppPath.Text = "App Path:";
            // 
            // labelRomDescription
            // 
            labelRomDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRomDescription.BorderStyle = BorderStyle.FixedSingle;
            labelRomDescription.Location = new Point(33, 204);
            labelRomDescription.Name = "labelRomDescription";
            labelRomDescription.Size = new Size(531, 277);
            labelRomDescription.TabIndex = 6;
            labelRomDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSettings
            // 
            labelSettings.AutoSize = true;
            labelSettings.Location = new Point(25, 19);
            labelSettings.Name = "labelSettings";
            labelSettings.Size = new Size(76, 25);
            labelSettings.TabIndex = 5;
            labelSettings.Text = "Settings";
            // 
            // buttonSaveSettings
            // 
            buttonSaveSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSaveSettings.Location = new Point(370, 143);
            buttonSaveSettings.Name = "buttonSaveSettings";
            buttonSaveSettings.Size = new Size(165, 34);
            buttonSaveSettings.TabIndex = 4;
            buttonSaveSettings.Text = "Save as Default";
            buttonSaveSettings.UseVisualStyleBackColor = true;
            buttonSaveSettings.Click += ButtonSaveSettingsClick;
            // 
            // checkBoxFullscreen
            // 
            checkBoxFullscreen.AutoSize = true;
            checkBoxFullscreen.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxFullscreen.Location = new Point(33, 148);
            checkBoxFullscreen.Name = "checkBoxFullscreen";
            checkBoxFullscreen.Size = new Size(119, 29);
            checkBoxFullscreen.TabIndex = 3;
            checkBoxFullscreen.Text = "Fullscreen:";
            checkBoxFullscreen.UseVisualStyleBackColor = true;
            // 
            // comboBoxResolution
            // 
            comboBoxResolution.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxResolution.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxResolution.FormattingEnabled = true;
            comboBoxResolution.Location = new Point(138, 101);
            comboBoxResolution.Name = "comboBoxResolution";
            comboBoxResolution.Size = new Size(118, 33);
            comboBoxResolution.TabIndex = 2;
            // 
            // labelResolution
            // 
            labelResolution.AutoSize = true;
            labelResolution.Location = new Point(33, 101);
            labelResolution.Name = "labelResolution";
            labelResolution.Size = new Size(99, 25);
            labelResolution.TabIndex = 1;
            labelResolution.Text = "Resolution:";
            // 
            // buttonRunRom
            // 
            buttonRunRom.Anchor = AnchorStyles.Bottom;
            buttonRunRom.Location = new Point(231, 543);
            buttonRunRom.Margin = new Padding(4, 5, 4, 5);
            buttonRunRom.Name = "buttonRunRom";
            buttonRunRom.Size = new Size(124, 97);
            buttonRunRom.TabIndex = 5;
            buttonRunRom.Text = "Run Rom";
            buttonRunRom.UseVisualStyleBackColor = true;
            buttonRunRom.Click += ButtonRunRomClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 739);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(883, 795);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuperModel UI";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Button buttonBrowseAppPath;
        private TextBox textBoxAppPath;
        private Label labelAppPath;
        private Label labelRomDescription;
        private Label labelSettings;
        private Button buttonSaveSettings;
        private CheckBox checkBoxFullscreen;
        private ComboBox comboBoxResolution;
        private Label labelResolution;
        private Button buttonRunRom;
    }
}