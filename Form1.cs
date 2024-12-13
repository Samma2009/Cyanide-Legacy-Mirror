using System.Diagnostics;
using System.Net;
using System.Reflection;

namespace Cyanide
{
    public partial class CyanideWindow : Form
    {
        private bool isDragging;
        private Point lastcurpos;

        public CyanideWindow()
        {
            if (!Directory.Exists(Program.dir + @"\Projects") && !Directory.Exists(Program.appData))
            {
                Program.SetupCyanide();
            }
            InitializeComponent();
            BlocklyWindow.Hide();
        }

        private void DragBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastcurpos = e.Location;
        }

        private void DragBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void DragBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastcurpos.X;
                int deltaY = e.Y - lastcurpos.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewProjectBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {

            }
        }

        private async void OpenProjectBtn_Click(object sender, EventArgs e)
        {

            var dir = Program.dir;

            NewProjectBtn.Hide();
            OpenProjectBtn.Hide();
            ProjectsLabel.Hide();
            ProjectList.Hide();
            WindowTitle.Text = "Untitled project - Cyanide";
            this.Controls.Add(BlocklyWindow);
            await BlocklyWindow.EnsureCoreWebView2Async(null);
            string Blocks = "",ToolBox = "",Impl = "";
            Dictionary<string, List<string>> CustomToolbox = new();

            foreach (var block in Directory.GetFiles(dir + @"\CyanideDevelopmentEnvironment\Blocks\Blocks"))
            {
                Blocks += $"Blockly.defineBlocksWithJsonArray([{File.ReadAllText(block)}]);\n";
            }

            foreach (var category in Directory.GetDirectories(dir + @"\CyanideDevelopmentEnvironment\Blocks\Blocks"))
            {

                CustomToolbox.Add(Path.GetFileNameWithoutExtension(category),new());

                foreach (var block in Directory.GetFiles(category))
                {
                    Blocks += $"Blockly.defineBlocksWithJsonArray([{File.ReadAllText(block)}]);\n";

                    CustomToolbox[Path.GetFileNameWithoutExtension(category)].Add(Path.GetFileNameWithoutExtension(block));

                }
            }

            foreach (var impl in Directory.GetFiles(dir + @"\CyanideDevelopmentEnvironment\Blocks\JS"))
            {
                Impl += $"Gen.forBlock['{Path.GetFileNameWithoutExtension(impl)}'] = {File.ReadAllText(dir + $@"\CyanideDevelopmentEnvironment\Blocks\JS\{Path.GetFileNameWithoutExtension(impl)}.js")}\n";
            }

            foreach (var category in CustomToolbox)
            {
                ToolBox += $"<category name=\"{category.Key}\" colour=\"#5b80a5\">\n";
                foreach (var block  in category.Value)
                {
                    ToolBox += $"<block type=\"{block}\"></block>\n";
                }
                ToolBox += $"</category>\n";

            }
            BlocklyWindow.CoreWebView2.NavigateToString(File.ReadAllText(dir + @"\CyanideDevelopmentEnvironment\UI.html").Replace("%BlocksLoader%",Blocks).Replace("%ToolBoxLoader%", ToolBox).Replace("%ImplLoader%", Impl));
            BlocklyWindow.Show();
        }
    }
}
