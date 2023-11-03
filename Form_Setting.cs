namespace SoundRecorder
{
    public partial class Form_Setting : Form
    {
        SettingManager.Editor Editor;
        public Form_Setting()
        {
            InitializeComponent();
            Editor = SettingManager.Instance.Edit();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Editor.Commit();
            this.Close();
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            string format = SettingManager.Instance.Get("saveformat", "wav");
            if (format == "wav")
                comboBox1.SelectedIndex = (int)SettingManager.SaveFormat.Wav;
            else if (format == "mp3")
                comboBox1.SelectedIndex = (int)SettingManager.SaveFormat.Mp3;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingManager.SaveFormat format = (SettingManager.SaveFormat)((ComboBox)sender).SelectedIndex;
            switch (format)
            {
                case SettingManager.SaveFormat.Wav:
                    Editor.Set("saveformat", "wav");
                    break;
                case SettingManager.SaveFormat.Mp3:
                    Editor.Set("saveformat", "mp3");
                    break;
                default:
                    break;
            }

        }
    }
}
