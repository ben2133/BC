using System;
using System.IO;
using NAudio.Wave;
using System.Windows.Forms;

namespace MusicCreater
{
    public class Nota_Play_Class
    {
        // Class Fild to Play:
        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;

        // Class Fild to Record:
        private WaveFileWriter RecordedAudioWriter;
        private WasapiLoopbackCapture CaptureInstance;

        // Nota Player:
        private void musicPlayer(string music_name, float audio_volume)
        {
            if (File.Exists(music_name))
            {
                this.outputDevice = new WaveOutEvent();
                this.audioFile = new AudioFileReader(music_name);
                this.outputDevice.Init(this.audioFile);
                this.outputDevice.Volume = (audio_volume / 100);
                this.outputDevice.Play();
            }
            else
            {
                MessageBox.Show("Файлы звучание клавиш не найден");
            }
        }

        // Nota DO:
        public void do_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/nota-do.mp3", ad_volume);
        }

        // Nota RE:
        public void re_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/re.mp3", ad_volume);
        }

        // Nota MI:
        public void mi_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/mi.mp3", ad_volume);
        }

        // Nota FA:
        public void fa_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/nota-fa.mp3", ad_volume);
        }

        // Nota SOL:
        public void sol_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/sol.mp3", ad_volume);
        }

        // Nota LYA:
        public void lya_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/lja.mp3", ad_volume);
        }

        // Nota SI:
        public void si_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/si.mp3", ad_volume);
        }

        // Nota C# Db:
        public void c_db_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/c#.mp3", ad_volume);
        }

        // Nota D# Eb:
        public void d_eb_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/d#.mp3", ad_volume);
        }

        // Nota F# Gb:
        public void f_gb_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/f#.mp3", ad_volume);
        }

        // Nota G# Ab:
        public void g_ab_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/g#.mp3", ad_volume);
        }

        // Nota A# Bb:
        public void a_bb_Play(float ad_volume)
        {
            this.musicPlayer(@"lib_music/mi.mp3", ad_volume);
        }

        // Play Recording Audio
        public void Play_M(bool Start, float ad_volume)
        {
            if (Start == true)
            {
                this.musicPlayer((string)AppDomain.CurrentDomain.BaseDirectory + "/RecordAudio/system_recorded_audio.wav", ad_volume);
            } else
            {
                this.outputDevice.Stop();
            }
        }

        // Recordin Audio
        public void rec_Audio(bool Start)
        {
            if (Start == true)
            {
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
            } else
            {
                // Stop Record:
                this.CaptureInstance.StopRecording();
            }
        }
    }
}
