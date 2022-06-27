using System;
using System.IO;
using NAudio.Wave;
using System.Windows.Forms;

namespace MusicCreater
{
    public partial class Form1 : Form
    {
        // Class Fild to Play:
        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;

        // Class Fild to Record:
        private WaveFileWriter RecordedAudioWriter;
        private WasapiLoopbackCapture CaptureInstance;

        public Form1()
        {
            InitializeComponent();
        }

        // Nota Player:
        public void musicPlayer(string music_name)
        {
            if (File.Exists(music_name)) {
                this.outputDevice = new WaveOutEvent();
                this.audioFile = new AudioFileReader(music_name);
                this.outputDevice.Init(this.audioFile);
                this.outputDevice.Volume = ((float)this.audio_volume.Value / 100);
                this.outputDevice.Play();
            } else
            {
                MessageBox.Show("Файлы звучание клавиш не найден");
            }

        }

        // Nota DO:
        private void button_do_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/nota-do.mp3");
        }

        // Nota RE:
        private void button_re_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/re.mp3");
        }

        // Nota MI:
        private void button_mi_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/mi.mp3");
        }

        // Nota FA:
        private void button_fa_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/nota-fa.mp3");
        }

        // Nota SOL:
        private void button_sol_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/sol.mp3");
        }

        // Nota LYA:
        private void button_lya_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/lja.mp3");
        }

        // Nota SI:
        private void button_si_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/si.mp3");
        }
        
        // Note C# Db:
        private void button_Dob_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/c#.mp3");
        }

        // Note D# Eb:
        private void button_Eb_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/d#.mp3");
        }

        // Note F# Gb:
        private void button_Gb_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/f#.mp3");
        }

        // Note G# Ab:
        private void button_Ab_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/g#.mp3");
        }

        // Note A# Bb:
        private void button_Bb_Click(object sender, EventArgs e)
        {
            this.musicPlayer(@"lib_music/a#.mp3");
        }

        // Button Play recorded audio:
        private void play_btn_Click(object sender, EventArgs e)
        {
            if (this.play_btn.Text == "Воспроизвести")
            {
                this.play_btn.Text = "Останвить";
                this.musicPlayer((string)AppDomain.CurrentDomain.BaseDirectory + "/RecordAudio/system_recorded_audio.wav");
            }
            else
            {
                this.play_btn.Text = "Воспроизвести";
                this.outputDevice.Stop();
            }
        }

        // Ricording audio
        private void record_btn_Click(object sender, EventArgs e)
        {
            if (this.record_btn.Text == "Записать") // Start Record:
            {
                this.record_btn.Text = "Остановить";

                // Define the output wav file of the recorded audio
                string outputFilePath = "/RecordAudio/system_recorded_audio.wav";

                if (!Directory.Exists("/RecordAudio"))
                {
                    Directory.CreateDirectory("/RecordAudio");
                }

                // Redefine the capturer instance with a new instance of the LoopbackCapture class
                this.CaptureInstance = new WasapiLoopbackCapture();

                // Redefine the audio writer instance with the given configuration
                this.RecordedAudioWriter = new WaveFileWriter(outputFilePath, CaptureInstance.WaveFormat);

                // When the capturer receives audio, start writing the buffer into the mentioned file
                this.CaptureInstance.DataAvailable += (s, a) =>
                {
                    this.RecordedAudioWriter.Write(a.Buffer, 0, a.BytesRecorded);
                };

                // When the Capturer Stops
                this.CaptureInstance.RecordingStopped += (s, a) =>
                {
                    this.RecordedAudioWriter.Dispose();
                    this.RecordedAudioWriter = null;
                    this.CaptureInstance.Dispose();
                };

                // Start recording:
                this.CaptureInstance.StartRecording();
            }
            else // Stop Record:
            {
                this.record_btn.Text = "Записать";

                // Stop Record:
                this.CaptureInstance.StopRecording();
            }
        }

        // Hot Key:
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Nota Do:
                case Keys.A:
                    this.musicPlayer(@"lib_music/nota-do.mp3");
                    break;

                // Nota Re:
                case Keys.S:
                    this.musicPlayer(@"lib_music/re.mp3");
                    break;

                // Nota Mi:
                case Keys.D:
                    this.musicPlayer(@"lib_music/mi.mp3");
                    break;

                // Nota Fa:
                case Keys.F:
                    this.musicPlayer(@"lib_music/nota-fa.mp3");
                    break;

                // Nota Sol:
                case Keys.G:
                    this.musicPlayer(@"lib_music/sol.mp3");
                    break;

                // Nota Lya:
                case Keys.H:
                    this.musicPlayer(@"lib_music/lja.mp3");
                    break;

                // Nota Si:
                case Keys.J:
                    this.musicPlayer(@"lib_music/si.mp3");
                    break;

                // Nota C#:
                case Keys.W:
                    this.musicPlayer(@"lib_music/c#.mp3");
                    break;

                // Nota D#:
                case Keys.R:
                    this.musicPlayer(@"lib_music/d#.mp3");
                    break;

                // Nota F#:
                case Keys.U:
                    this.musicPlayer(@"lib_music/f#.mp3");
                    break;

                // Nota G#:
                case Keys.I:
                    this.musicPlayer(@"lib_music/g#.mp3");
                    break;

                // Nota A#:
                case Keys.O:
                    this.musicPlayer(@"lib_music/a#.mp3");
                    break;
            }
        }
    }
}
