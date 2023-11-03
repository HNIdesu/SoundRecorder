using NAudio.Lame;
using NAudio.Wave;

namespace SoundRecorder
{
    public partial class Form1 : Form
    {
        WasapiLoopbackCapture WasapiLoopbackCapture;
        int seconds = 0;
        LameConfig LameConfig = new LameConfig()
        {

        };

        public Form1()
        {
            InitializeComponent();

        }


        private void radioButton_SaveAsChipBoard_MouseClick(object sender, MouseEventArgs e)
        {
            SettingManager.Instance.Set("saveto", (int)SettingManager.SaveTo.ChipBoard);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SettingManager.Instance.Set("saveto", (int)SettingManager.SaveTo.File);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int select = SettingManager.Instance.Get("saveto", -1);
            timer1.Tick += (o, e) =>
            {
                seconds++;
                toolStripStatusLabel1.Text = string.Format("Â¼ÖÆÖÐ {0:00}:{1:00}", seconds / 60, seconds % 60);
            };
            if (select == -1)
            {
                radioButton_SaveAsFile.Checked = true;
                SettingManager.Instance.Set("saveto", (int)SettingManager.SaveTo.File);
            }
            else
            {
                switch ((SettingManager.SaveTo)select)
                {
                    case SettingManager.SaveTo.ChipBoard:
                        radioButton_SaveAsChipBoard.Checked = true;
                        break;
                    case SettingManager.SaveTo.File:
                        radioButton_SaveAsFile.Checked = true;
                        break;
                    default:
                        break;
                }
            }

        }

        private void button_StartRecord_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            WasapiLoopbackCapture = new WasapiLoopbackCapture() { WaveFormat = new WaveFormat(44100, 16, 1) };
            WasapiLoopbackCapture.DataAvailable += new EventHandler<WaveInEventArgs>((o, e) =>
            {
                byte[] buffer = e.Buffer;
                ms.Write(e.Buffer, 0, e.BytesRecorded);
            });
            WasapiLoopbackCapture.RecordingStopped += new EventHandler<StoppedEventArgs>((o, e) =>
            {
                SettingManager.SaveTo option = (SettingManager.SaveTo)SettingManager.Instance.Get("saveto", 1);
                string format = SettingManager.Instance.Get("saveformat", "wav");
                if (option == SettingManager.SaveTo.ChipBoard)
                {
                    string filepath = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), DateTime.Now.ToString("yyyyMMddHHmmss") + "." + format);
                    if (format == "wav")
                    {
                        using (FileStream fs = File.OpenWrite(filepath))
                        {
                            WaveFileWriter writer = new WaveFileWriter(fs, WasapiLoopbackCapture.WaveFormat);
                            writer.Write(ms.ToArray());
                            writer.Close();
                            writer.Dispose();
                        }
                            
                    }
                    else if (format == "mp3")
                    {
                        using (FileStream fs= File.OpenWrite(filepath))
                        {
                            LameMP3FileWriter writer = new LameMP3FileWriter(fs, WasapiLoopbackCapture.WaveFormat, LameConfig);
                            writer.Write(ms.ToArray());
                            writer.Close();
                            writer.Dispose();
                        }
                            
                        
                    }
                    Clipboard.SetFileDropList(new System.Collections.Specialized.StringCollection() { filepath });

                }
                else if (option == SettingManager.SaveTo.File)
                {
                    saveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "." + format;
                    saveFileDialog1.InitialDirectory = Environment.GetEnvironmentVariable("TEMP");
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.CheckPathExists)
                    {
                        string filepath = saveFileDialog1.FileName;
                        format = Path.GetExtension(saveFileDialog1.FileName).Substring(1);
                        if (format == "wav")
                        {
                            using (FileStream fs = File.OpenWrite(filepath))
                            {
                                WaveFileWriter writer = new WaveFileWriter(fs, WasapiLoopbackCapture.WaveFormat);
                                writer.Write(ms.ToArray());
                                writer.Close();
                                writer.Dispose();
                            }
                                
                        }
                        else if (format == "mp3")
                        {
                            using (FileStream fs = File.OpenWrite(filepath))
                            {
                                LameMP3FileWriter writer = new LameMP3FileWriter(fs, WasapiLoopbackCapture.WaveFormat, LameConfig);
                                writer.Write(ms.ToArray());
                                writer.Close();
                                writer.Dispose();
                            }
                                
                        }

                    }

                }
                ms.Close();
            });
            WasapiLoopbackCapture.StartRecording();
            seconds = 0;
            timer1.Start();



        }

        private void button_StopRecord_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            toolStripStatusLabel1.Text = "ÒÑÍ£Ö¹";
            WasapiLoopbackCapture.StopRecording();
            WasapiLoopbackCapture.Dispose();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Setting().ShowDialog();
        }

    }
}