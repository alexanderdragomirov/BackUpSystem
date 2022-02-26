using System.Text.RegularExpressions;

namespace BackUpSystem
{
    public partial class BackUpSystem : Form
    {
        int changeCount = 0;

        public BackUpSystem()
        {
            InitializeComponent();
        }

        public void BackUpSystem_Load(object sender, EventArgs e)
        {

        }

        public void File_watch_Changed(object sender, FileSystemEventArgs e)
        {
            string change = $"{changeCount}_";
            string path = PathBackUpFolderTextBox.Text + "\\" + change + e.Name;
            File.Copy(e.FullPath, path, false);
            changeCount++;
        }

        public void File_watch_Created(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("Файл создан", "Back Up System",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information,
              MessageBoxDefaultButton.Button1,
              MessageBoxOptions.ServiceNotification);
        }


        public void File_watch_Deleted(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("Файл удалён", "Back Up System",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.ServiceNotification);
        }

        private void File_watch_Renamed(object sender, RenamedEventArgs e)
        {
            string path = PathBackUpFolderTextBox.Text + e.Name;
            File.Copy(e.FullPath, path, true);

        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            file_watch.Path = PathFolderTextBox.Text;
            DialogResult result = MessageBox.Show(
                "Начали следить за вашей папкой",
                "Успешно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void PathFolder_TextChanged(object sender, EventArgs e)
        {
            char temp = '"';
            if (PathFolderTextBox.Text.Contains(temp))
            {
                Regex regex = new($"{temp}");
                PathFolderTextBox.Text = regex.Replace(PathFolderTextBox.Text, "");
            }

        }

        private void PathBackUpFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            char temp = '"';
            if (PathBackUpFolderTextBox.Text.Contains(temp))
            {
                Regex regex = new($"{temp}");
                PathBackUpFolderTextBox.Text = regex.Replace(PathBackUpFolderTextBox.Text, "");

            }
        }
    }
}