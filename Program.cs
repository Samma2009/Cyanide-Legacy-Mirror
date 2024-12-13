using System.Net;
using System.Reflection;

namespace Cyanide
{
    internal static class Program
    {
        public static string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Cyanide";
        public static string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        static Form cyanide = new LoadingSplashscreen();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(cyanide);
        }

        public static void LoadProgram()
        {
            var w = new CyanideWindow();
            w.Show();
            cyanide.Hide();
            w.FormClosed += (a, b) => cyanide.Close();
        }

        public static void SetupCyanide()
        {
            MessageBox.Show("Cyanide is being setup.", "Cyanide", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Directory.CreateDirectory(dir + @"\Projects");
            Directory.CreateDirectory(appData);
            Directory.CreateDirectory(appData + @"\ProjectTemplate");
            //Directory.CreateDirectory(appData + @"\Editor");
            //Directory.CreateDirectory(dir + @"\CyanideDevelopmentEnvironment");
            //Directory.CreateDirectory(dir + @"\CyanideDevelopmentEnvironment\Blocks");
            //Directory.CreateDirectory(dir + @"\CyanideDevelopmentEnvironment\Blocks\Categories");
            //Directory.CreateDirectory(dir + @"\CyanideDevelopmentEnvironment\Blocks\BlockScripts");
            using (WebClient webcli = new())
            {
                try
                {
                    webcli.DownloadFile("https://raw.githubusercontent.com/ThatGuyAstral/cyanide-template-project/main/kernel.cpp", appData + @"\ProjectTemplate\kernel.cpp");
                    webcli.DownloadFile("https://raw.githubusercontent.com/ThatGuyAstral/cyanide-template-project/main/boot.s", appData + @"\ProjectTemplate\boot.s");
                    webcli.DownloadFile("https://raw.githubusercontent.com/ThatGuyAstral/cyanide-template-project/main/link.ld", appData + @"\ProjectTemplate\link.ld");
                    //webcli.DownloadFile("https://raw.githubusercontent.com/ThatGuyAstral/Cyanide/main/CyanideDevelopmentEnvironment/UI.html", appData + @"\Editor\UI.html");
                    //webcli.DownloadFile("https://raw.githubusercontent.com/ThatGuyAstral/Cyanide/main/CyanideDevelopmentEnvironment/index.js", appData + @"\Editor\index.js");
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show($"ERROR: {ex.Message}", "Cyanide", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) == DialogResult.Ignore)
                    {
                        MessageBox.Show("Cyanide failed to install a critical component. If you continue, functionality will be limited.");
                    }
                    if (MessageBox.Show($"ERROR: {ex.Message}", "Cyanide", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) == DialogResult.Abort)
                    {
                        MessageBox.Show("Cyanide failed to install a critical component.");
                        cyanide.Close();
                    }
                    if (MessageBox.Show($"ERROR: {ex.Message}", "Cyanide", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        webcli.DownloadFile("https://raw.githubusercontent.com/ThatGuyAstral/cyanide-template-project/main/kernel.cpp", appData + @"\ProjectTemplate\kernel.cpp");
                        webcli.DownloadFile("https://raw.githubusercontent.com/ThatGuyAstral/cyanide-template-project/main/boot.s", appData + @"\ProjectTemplate\boot.s");
                        webcli.DownloadFile("https://raw.githubusercontent.com/ThatGuyAstral/cyanide-template-project/main/link.ld", appData + @"\ProjectTemplate\link.ld");
                        //webcli.DownloadFile("https://raw.githubusercontent.com/ThatGuyAstral/Cyanide/main/CyanideDevelopmentEnvironment/UI.html", appData + @"\Editor\UI.html");
                        //webcli.DownloadFile("https://raw.githubusercontent.com/ThatGuyAstral/Cyanide/main/CyanideDevelopmentEnvironment/index.js", appData + @"\Editor\index.js");
                    }
                }
            }
        }
    }
}
