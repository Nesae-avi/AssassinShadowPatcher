using System.Reflection;

namespace AssassinShadowPatcher
{
    public partial class Form1 : Form
    {
        private string? ExecutablePath { get; set; } = null;

        private readonly List<string> GameExecutables = new()
        {
            "ACRSP",
        };

        public Form1()
        {
            InitializeComponent();
        }

        private static DialogResult OperationSuccessfulMsg() => MessageBox.Show("SUCCESS", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        private static DialogResult OperationFailedMsg() => MessageBox.Show("FAILED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private bool SetExecutablePath(string path)
        {
            ExecutablePath = path;
            textBox_GameExecutablePath.Text = path;

            return true;
        }

        private bool VerifyAndSetPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException($"'{nameof(path)}' cannot be null or empty.", nameof(path));
            }

            if (GameExecutables.Any(g => g.Contains(Path.GetFileNameWithoutExtension(path), StringComparison.OrdinalIgnoreCase))
                && Path.GetExtension(path).Equals(".exe", StringComparison.OrdinalIgnoreCase))
            {
                return SetExecutablePath(path);
            }

            return false;
        }

        /// <summary>
        /// Backup the original executable without overwriting if a backup already exists.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private bool Backup()
        {
            if (string.IsNullOrEmpty(ExecutablePath))
            {
                throw new ArgumentException($"'{nameof(ExecutablePath)}' cannot be null or empty.", nameof(ExecutablePath));
            }

            File.Copy(ExecutablePath, $"{ExecutablePath}.aspbackup");

            return true;
        }

        private bool Patch()
        {
            if (string.IsNullOrEmpty(ExecutablePath))
            {
                return false;
            }

            Backup();

            if (BinaryIO.ReadFile(ExecutablePath, out byte[] data))
            {
                byte[]? patchedData = Array.Empty<byte>();

                switch (Path.GetFileNameWithoutExtension(ExecutablePath))
                {
                    case "ACRSP": patchedData = Patcher.PatchACRSP(data); break;
                }

                if (patchedData != null)
                    return BinaryIO.WriteFile(ExecutablePath, patchedData);
            }

            return false;
        }

        private bool Restore()
        {
            if (string.IsNullOrEmpty(ExecutablePath))
            {
                return false;
            }

            var backupFilePath = $"{ExecutablePath}.aspbackup";

            if (File.Exists(backupFilePath) == false)
            {
                return false;
            }

            File.Copy(backupFilePath, ExecutablePath, true);

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString(3);

            Text += $" v{version}";
        }

        private void Button_SelectEXE_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                VerifyAndSetPath(openFileDialog1.FileName);
            }
        }

        private void TextBox_GameExecutablePath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files != null && files.Length == 1)
            {
                VerifyAndSetPath(files[0]);
            }
        }

        private void TextBox_GameExecutablePath_DragOver(object sender, DragEventArgs e) => e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;

        private void Button_Patch_Click(object sender, EventArgs e)
        {
            if (Patch())
            {
                OperationSuccessfulMsg();
            }
            else
            {
                OperationFailedMsg();
            }
        }

        private void Button_Restore_Click(object sender, EventArgs e)
        {
            if (Restore())
            {
                OperationSuccessfulMsg();
            }
            else
            {
                OperationFailedMsg();
            }
        }

    }
}