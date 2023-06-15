using System;
using System.Windows.Forms;

namespace MusicCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        // My Nota_Play_Class
        public Nota_Play_Class Nota_PLay = new Nota_Play_Class();


        // Nota DO:
        private void button_do_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.do_Play((float)this.audio_volume.Value);
        }

        // Nota RE:
        private void button_re_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.re_Play((float)this.audio_volume.Value);
        }

        // Nota MI:
        private void button_mi_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.mi_Play((float)this.audio_volume.Value);
        }

        // Nota FA:
        private void button_fa_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.fa_Play((float)this.audio_volume.Value);
        }

        // Nota SOL:
        private void button_sol_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.sol_Play((float)this.audio_volume.Value);
        }

        // Nota LYA:
        private void button_lya_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.lya_Play((float)this.audio_volume.Value);
        }

        // Nota SI:
        private void button_si_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.si_Play((float)this.audio_volume.Value);
        }
        
        // Note C# Db:
        private void button_Dob_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.c_db_Play((float)this.audio_volume.Value);
        }

        // Note D# Eb:
        private void button_Eb_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.d_eb_Play((float)this.audio_volume.Value);
        }

        // Note F# Gb:
        private void button_Gb_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.f_gb_Play((float)this.audio_volume.Value);
        }

        // Note G# Ab:
        private void button_Ab_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.g_ab_Play((float)this.audio_volume.Value);
        }

        // Note A# Bb:
        private void button_Bb_Click(object sender, EventArgs e)
        {
            this.Nota_PLay.a_bb_Play((float)this.audio_volume.Value);
        }

        // Button Play recorded audio:
        private void play_btn_Click(object sender, EventArgs e)
        {
            if (this.play_btn.Text == "Воспроизвести")
            {
                this.play_btn.Text = "Останвить";
                this.Nota_PLay.Play_M(true, this.audio_volume.Value);
            }
            else
            {
                this.play_btn.Text = "Воспроизвести";
                this.Nota_PLay.Play_M(false, this.audio_volume.Value);
            }
        }

        // Ricording audio
        private void record_btn_Click(object sender, EventArgs e)
        {
            if (this.record_btn.Text == "Записать") // Start Record:
            {
                this.record_btn.Text = "Остановить";
                this.Nota_PLay.rec_Audio(true);                
            }
            else // Stop Record:
            {
                this.record_btn.Text = "Записать";
                this.Nota_PLay.rec_Audio(false);               
            }
        }

        // Hot Key:
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Nota Do:
                case Keys.A:
                    this.Nota_PLay.do_Play((float)this.audio_volume.Value);
                    break;

                // Nota Re:
                case Keys.S:
                    this.Nota_PLay.re_Play((float)this.audio_volume.Value);
                    break;

                // Nota Mi:
                case Keys.D:
                    this.Nota_PLay.mi_Play((float)this.audio_volume.Value);
                    break;

                // Nota Fa:
                case Keys.F:
                    this.Nota_PLay.fa_Play((float)this.audio_volume.Value);
                    break;

                // Nota Sol:
                case Keys.G:
                    this.Nota_PLay.sol_Play((float)this.audio_volume.Value);
                    break;

                // Nota Lya:
                case Keys.H:
                    this.Nota_PLay.lya_Play((float)this.audio_volume.Value);
                    break;

                // Nota Si:
                case Keys.J:
                    this.Nota_PLay.si_Play((float)this.audio_volume.Value);
                    break;

                // Nota C#:
                case Keys.W:
                    this.Nota_PLay.c_db_Play((float)this.audio_volume.Value);
                    break;

                // Nota D#:
                case Keys.R:
                    this.Nota_PLay.d_eb_Play((float)this.audio_volume.Value);
                    break;

                // Nota F#:
                case Keys.U:
                    this.Nota_PLay.f_gb_Play((float)this.audio_volume.Value);
                    break;

                // Nota G#:
                case Keys.I:
                    this.Nota_PLay.g_ab_Play((float)this.audio_volume.Value);
                    break;

                // Nota A#:
                case Keys.O:
                    this.Nota_PLay.a_bb_Play((float)this.audio_volume.Value);
                    break;
            }
        }
    }
}
