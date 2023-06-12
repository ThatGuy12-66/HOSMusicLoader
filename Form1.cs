using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Diagnostics;
using Microsoft.Win32;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
// DISCLAIMER: I want to express my reservation regarding the requirement to act in accordance with the author's political statements.
// This requirement raises concerns related to the protection of freedom of thought, conscience, and expression, which are fundamental rights safeguarded by international human rights standards, including the Universal Declaration of Human Rights and the International Covenant on Civil and Political Rights.
// I support an environment that fosters inclusivity and respects diverse perspectives. However, I believe it is essential to separate personal opinions from technical endeavors to ensure neutrality and avoid potential coercion in matters of belief.
// I respectfully request the project's developers to reconsider this requirement and explore alternative approaches that promote collaboration and open exchange of ideas, while respecting individuals' autonomy and their right to hold independent opinions.


namespace HOSMusicLoader
{
    public partial class Form1 : Form
    {
        public static string path = "";
        public static string path2 = "";
        public static string userpath = "";
        public static int language = 0;
        public static string mp3path = "";
        public static string wavpath = "";
        public static int SampleRate = 44100;

        public Form1()
        {
            InitializeComponent();
            Process process = new Process();
            process.StartInfo.FileName = "ffmpeg";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            if (process.StandardOutput.ReadToEnd().Contains("not recognized"))
            {
                MessageBox.Show("FFMPEG not found. Please install it and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            language = 0; //0 english, 1 french, 2 german, 3 russian
            userpath = "";
            userpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            path = userpath + @"\AppData\LocalLow\Valentin's studios\Hex of Steel\MODS\Music Mod";
            path2 = path + @"\Musics";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!Directory.Exists(path2))
            {
                Directory.CreateDirectory(path2);
            }
            if (!File.Exists(path + @"\Thumbnail.jpg"))
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://cdn.wallpapersafari.com/43/76/z7HuRl.jpg", path + @"\Thumbnail.jpg");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void English_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Text = "Tronren's Hex Of Steel Music Loader";
            author.Text = "Author: TronrenGuy / Suziki5000";
            DownloadButton.Text = "Download";
            Add.Text = "Add To List";
            clearList.Text = "Clear List";
            language = 0;
        }

        private void French_Click(object sender, EventArgs e)
        {
            author.Text = "Auteur: TronrenGuy / Suziki5000";
            Form1.ActiveForm.Text = "Tronren's Hex Of Steel Changeur de musique";
            DownloadButton.Text = "Télécharger";
            Add.Text = "Ajouter à la liste";
            clearList.Text = "Effacer la liste";
            language = 1;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string url = urlbox.Text;
            if (url.StartsWith("https://www.youtube.com/watch?v=") == true)
            {
                URLList.Items.Add(url);
            }
        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            foreach (string url in URLList.Items)
            {
                try
                {
                    var client = new YoutubeClient();
                    var video = await client.Videos.GetAsync(url);
                    var streamManifest = await client.Videos.Streams.GetManifestAsync(video.Id);
                    var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                    if (streamInfo != null)
                    {
                        string title = video.Title;
                        title = title.Replace(":", "");
                        title = title.Replace("?", "");
                        title = title.Replace("/", "");
                        title = title.Replace("\\", "");
                        title = title.Replace("*", "");
                        title = title.Replace("\"", "");
                        title = title.Replace("<", "");
                        title = title.Replace(">", "");
                        title = title.Replace("|", "");
                        mp3path = path2 + @"\" + title + ".mp3";
                        wavpath = path2 + @"\" + title + ".wav";
                        await client.Videos.Streams.DownloadAsync(streamInfo, mp3path);
                    }
                    else
                    {
                        throw new Exception("StreamInfo was null");
                    }
                    Process process = new Process();
                    process.StartInfo.FileName = "ffmpeg";
                    process.StartInfo.Arguments = $"-i \"{mp3path}\" \"{wavpath}\"";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.WaitForExit();
                    File.Delete(mp3path);
                    progressBar1.Increment(100 / URLList.Items.Count);
                    if (language == 0)
                    {
                        MessageBox.Show("Success!");
                    }
                    else if (language == 1)
                    {
                        MessageBox.Show("Succès !");
                    }
                    else if (language == 2)
                    {
                        MessageBox.Show("Erfolgreich!");
                    }
                    else
                    {
                        MessageBox.Show("Успех!");
                    }
                }
                catch (Exception ex)
                {
                    if (language == 0)
                    {
                        MessageBox.Show("An error has occured: " + ex.Message);
                    }
                    else if (language == 1)
                    {
                        MessageBox.Show("Une erreur s'est produite: " + ex.Message);
                    }
                    else if (language == 2)
                    {
                        MessageBox.Show("Es ist ein Fehler aufgetreten: " + ex.Message);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка: " + ex.Message);
                    }
                }
            }
        }

        private void German_Click(object sender, EventArgs e)
        {
            author.Text = "Autor: TronrenGuy / Suziki5000";
            Form1.ActiveForm.Text = "Tronren's Hex Of Steel Musik-Lader";
            DownloadButton.Text = "Herunterladen";
            Add.Text = "Zur Liste hinzufügen";
            clearList.Text = "Liste löschen";
            language = 2;
        }

        private void Russian_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Text = "Tronren's Hex Of Steel музыкальный загрузчик";
            DownloadButton.Text = "скачать";
            author.Text = "Автор: TronrenGuy / Suziki5000";
            Add.Text = "Добавить в список";
            clearList.Text = "Очистить список";
            language = 3;
        }

        private void clearList_Click(object sender, EventArgs e)
        {
            URLList.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", 0) != null)
            {
                string ssteamPath = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", 0);
                Process.Start(ssteamPath + @"\steam.exe", "-applaunch 1240630");
            }
            else if (Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam", "InstallPath", 0) != null)
            {
                string ssteamPath = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam", "InstallPath", 0);
                Process.Start(ssteamPath + @"\steam.exe", "-applaunch 1240630");
            }
        }
        private bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsProcessOpen("ffmpeg") == false)
            {
                foreach (Process proc in Process.GetProcessesByName("ffmpeg"))
                {
                    proc.Kill();
                }
            }
        }
    }
}