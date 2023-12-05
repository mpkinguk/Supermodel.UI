using Supermodel.UI.Model;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;

namespace Supermodel.UI
{
    public partial class MainForm : Form
    {
        private string _romToRun = string.Empty;

        /// <summary>
        /// Contructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            listView1.ItemSelectionChanged += ListViewItemSelectionChanged;

            SetupResolutions();

            LoadSettings();

            if (!string.IsNullOrEmpty(textBoxAppPath.Text))
            {
                ShowFiles();
            }

            FormClosing += MainFormFormClosing;
        }

        private void MainFormFormClosing(object? sender, FormClosingEventArgs e)
        {
            if (textBoxAppPath.Text != Settings1.Default.AppPath ||
            checkBoxFullscreen.Checked != Settings1.Default.Fullscreen ||
            comboBoxResolution.Text != Settings1.Default.Resolution)
            {
                var result = MessageBox.Show("Settings have changed. Do you wish to save?", "Info", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveSettings();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        /// <summary>
        /// Load the settings
        /// </summary>
        private void LoadSettings()
        {
            textBoxAppPath.Text = Settings1.Default.AppPath;
            checkBoxFullscreen.Checked = Settings1.Default.Fullscreen;
            comboBoxResolution.Text = Settings1.Default.Resolution;
        }

        /// <summary>
        /// Save the settings
        /// </summary>
        private void SaveSettings()
        {
            Settings1.Default.AppPath = textBoxAppPath.Text;
            Settings1.Default.Fullscreen = checkBoxFullscreen.Checked;
            Settings1.Default.Resolution = comboBoxResolution.Text;
            Settings1.Default.Save();
        }

        /// <summary>
        /// Setup the resolutions
        /// </summary>
        private void SetupResolutions()
        {
            comboBoxResolution.Items.Clear();
            comboBoxResolution.Items.Add("496,384");
            comboBoxResolution.Items.Add("640,480");
            comboBoxResolution.Items.Add("800,600");
            comboBoxResolution.Items.Add("960,720");
            comboBoxResolution.Items.Add("1024,768");
            comboBoxResolution.Items.Add("1280,960");
            comboBoxResolution.Items.Add("1400,1050");
            comboBoxResolution.Items.Add("1600,1200");
            comboBoxResolution.Items.Add("1856,1392");
            comboBoxResolution.Items.Add("1920,1440");
            comboBoxResolution.Items.Add("2048,1536");

            comboBoxResolution.SelectedIndex = 0;
        }


        /// <summary>
        /// Display information for the selected rom file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListViewItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                _romToRun = (string)listView1.SelectedItems[0].Text;

                labelRomDescription.Text = GetRomData();
            }
        }

        private void ButtonBrowseAppPathClick(object sender, EventArgs e)
        {
            using (var browser = new FolderBrowserDialog())
            {
                if (browser.ShowDialog() == DialogResult.OK)
                {
                    textBoxAppPath.Text = browser.SelectedPath;

                    ShowFiles();
                }
            }
        }

        /// <summary>
        /// Get all rom zip files from path and display them in the listview
        /// </summary>
        private void ShowFiles()
        {
            try
            {
                var files = Directory.GetFiles(Path.Combine(textBoxAppPath.Text, "Roms"), "*.zip", SearchOption.AllDirectories);

                listView1.Items.Clear();

                foreach (var file in files)
                {
                    var info = new FileInfo(file);

                    var item = new ListViewItem(info.Name) { Tag = file };

                    listView1.Items.Add(item);
                }

                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Run a rom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRunRomClick(object sender, EventArgs e)
        {
            try
            {
                var path = textBoxAppPath.Text;

                if (string.IsNullOrEmpty(path))
                {
                    MessageBox.Show("Please set app path for supermodel.exe");
                    return;
                }

                if (path is null || string.IsNullOrEmpty(_romToRun)) { return; }

                var fullScreen = checkBoxFullscreen.Checked ? "-fullscreen" : "";

                var resolution = comboBoxResolution.SelectedIndex == 0 ? "" : $"-res={comboBoxResolution.Text}";

                using (var process = new Process())
                {

                    var superModel = Path.Combine(path, "Supermodel.exe");

                    process.StartInfo = new ProcessStartInfo()
                    {
                        WorkingDirectory = path,
                        FileName = "Supermodel.exe",
                        Arguments = @$"roms\{_romToRun} {resolution} {fullScreen}",
                        UseShellExecute = true,
                        CreateNoWindow = true,
                        ErrorDialog = true
                    };

                    process.ErrorDataReceived += ProcessErrorDataReceived;

                    process.Start();

                    while (!process.HasExited)
                    {
                        Application.DoEvents();
                        Thread.Sleep(10);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            MessageBox.Show(e.Data);
        }

        /// <summary>
        /// Save the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveSettingsClick(object sender, EventArgs e)
        {
            SaveSettings();
        }

        /// <summary>
        /// Get rom data
        /// </summary>
        private string? GetRomData()
        {
            try
            {
                var gamesPath = Path.Combine(textBoxAppPath.Text, "Config", "Games.xml");

                var games = new Games();


                XmlSerializer serializer = new(typeof(Games));
                using (TextReader reader = new StreamReader(gamesPath))
                {
                    games = serializer.Deserialize(reader) as Games;
                }

                if (games is null)
                {
                    throw new Exception("Could not load games from xml file");
                }

                var rom = _romToRun.Replace(".zip", "");
               
                var game = games.GameList.Where(x => x.Name.Contains(rom) || x.Parent.Contains(rom)).FirstOrDefault();

                if (game != null)
                {
                    var gameInfo = $"Title:{game.Identity.Title}\nManufacturer:{game.Identity.Manufacturer}" +
                        $"\nYear:{game.Identity.Year}\nVersion:{game.Identity.Version}";

                    return gameInfo;
                }

                return "Could not retrieve rom information";

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "Could not retrieve rom information";
            }
        }
    }
}