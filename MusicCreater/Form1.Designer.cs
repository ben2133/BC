
namespace MusicCreater
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_do = new System.Windows.Forms.Button();
            this.button_re = new System.Windows.Forms.Button();
            this.button_mi = new System.Windows.Forms.Button();
            this.button_fa = new System.Windows.Forms.Button();
            this.button_sol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.record_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.audio_volume = new System.Windows.Forms.TrackBar();
            this.button_lya = new System.Windows.Forms.Button();
            this.button_si = new System.Windows.Forms.Button();
            this.button_Dob = new System.Windows.Forms.Button();
            this.button_Eb = new System.Windows.Forms.Button();
            this.button_Gb = new System.Windows.Forms.Button();
            this.button_Ab = new System.Windows.Forms.Button();
            this.button_Bb = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audio_volume)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_do
            // 
            this.button_do.BackColor = System.Drawing.Color.White;
            this.button_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_do.Location = new System.Drawing.Point(32, 113);
            this.button_do.Name = "button_do";
            this.button_do.Size = new System.Drawing.Size(45, 229);
            this.button_do.TabIndex = 0;
            this.button_do.Text = "do";
            this.button_do.UseVisualStyleBackColor = false;
            this.button_do.Click += new System.EventHandler(this.button_do_Click);
            // 
            // button_re
            // 
            this.button_re.BackColor = System.Drawing.Color.White;
            this.button_re.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_re.Location = new System.Drawing.Point(135, 113);
            this.button_re.Name = "button_re";
            this.button_re.Size = new System.Drawing.Size(45, 229);
            this.button_re.TabIndex = 1;
            this.button_re.Text = "re";
            this.button_re.UseVisualStyleBackColor = false;
            this.button_re.Click += new System.EventHandler(this.button_re_Click);
            // 
            // button_mi
            // 
            this.button_mi.BackColor = System.Drawing.Color.White;
            this.button_mi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mi.Location = new System.Drawing.Point(235, 113);
            this.button_mi.Name = "button_mi";
            this.button_mi.Size = new System.Drawing.Size(45, 229);
            this.button_mi.TabIndex = 2;
            this.button_mi.Text = "mi";
            this.button_mi.UseVisualStyleBackColor = false;
            this.button_mi.Click += new System.EventHandler(this.button_mi_Click);
            // 
            // button_fa
            // 
            this.button_fa.BackColor = System.Drawing.Color.White;
            this.button_fa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_fa.Location = new System.Drawing.Point(295, 113);
            this.button_fa.Name = "button_fa";
            this.button_fa.Size = new System.Drawing.Size(45, 229);
            this.button_fa.TabIndex = 3;
            this.button_fa.Text = "fa";
            this.button_fa.UseVisualStyleBackColor = false;
            this.button_fa.Click += new System.EventHandler(this.button_fa_Click);
            // 
            // button_sol
            // 
            this.button_sol.BackColor = System.Drawing.Color.White;
            this.button_sol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sol.Location = new System.Drawing.Point(397, 113);
            this.button_sol.Name = "button_sol";
            this.button_sol.Size = new System.Drawing.Size(45, 229);
            this.button_sol.TabIndex = 4;
            this.button_sol.Text = "sol";
            this.button_sol.UseVisualStyleBackColor = false;
            this.button_sol.Click += new System.EventHandler(this.button_sol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.record_btn);
            this.groupBox1.Controls.Add(this.play_btn);
            this.groupBox1.Location = new System.Drawing.Point(430, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запись звука";
            // 
            // record_btn
            // 
            this.record_btn.Location = new System.Drawing.Point(110, 30);
            this.record_btn.Name = "record_btn";
            this.record_btn.Size = new System.Drawing.Size(75, 30);
            this.record_btn.TabIndex = 1;
            this.record_btn.Text = "Записать";
            this.record_btn.UseVisualStyleBackColor = true;
            this.record_btn.Click += new System.EventHandler(this.record_btn_Click);
            // 
            // play_btn
            // 
            this.play_btn.Location = new System.Drawing.Point(6, 30);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(98, 30);
            this.play_btn.TabIndex = 0;
            this.play_btn.Text = "Воспроизвести";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.audio_volume);
            this.groupBox2.Location = new System.Drawing.Point(71, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 75);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Громкость";
            // 
            // audio_volume
            // 
            this.audio_volume.Location = new System.Drawing.Point(6, 20);
            this.audio_volume.Name = "audio_volume";
            this.audio_volume.Size = new System.Drawing.Size(300, 45);
            this.audio_volume.TabIndex = 0;
            this.audio_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.audio_volume.Value = 2;
            // 
            // button_lya
            // 
            this.button_lya.BackColor = System.Drawing.Color.White;
            this.button_lya.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_lya.Location = new System.Drawing.Point(499, 113);
            this.button_lya.Name = "button_lya";
            this.button_lya.Size = new System.Drawing.Size(45, 229);
            this.button_lya.TabIndex = 7;
            this.button_lya.Text = "lya";
            this.button_lya.UseVisualStyleBackColor = false;
            this.button_lya.Click += new System.EventHandler(this.button_lya_Click);
            // 
            // button_si
            // 
            this.button_si.BackColor = System.Drawing.Color.White;
            this.button_si.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_si.Location = new System.Drawing.Point(601, 113);
            this.button_si.Name = "button_si";
            this.button_si.Size = new System.Drawing.Size(45, 229);
            this.button_si.TabIndex = 8;
            this.button_si.Text = "si";
            this.button_si.UseVisualStyleBackColor = false;
            this.button_si.Click += new System.EventHandler(this.button_si_Click);
            // 
            // button_Dob
            // 
            this.button_Dob.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Dob.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Dob.Location = new System.Drawing.Point(83, 19);
            this.button_Dob.Name = "button_Dob";
            this.button_Dob.Size = new System.Drawing.Size(45, 229);
            this.button_Dob.TabIndex = 9;
            this.button_Dob.Text = "C#Dob";
            this.button_Dob.UseVisualStyleBackColor = false;
            this.button_Dob.Click += new System.EventHandler(this.button_Dob_Click);
            // 
            // button_Eb
            // 
            this.button_Eb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Eb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Eb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Eb.Location = new System.Drawing.Point(186, 19);
            this.button_Eb.Name = "button_Eb";
            this.button_Eb.Size = new System.Drawing.Size(45, 229);
            this.button_Eb.TabIndex = 10;
            this.button_Eb.Text = "D# Eb";
            this.button_Eb.UseVisualStyleBackColor = false;
            this.button_Eb.Click += new System.EventHandler(this.button_Eb_Click);
            // 
            // button_Gb
            // 
            this.button_Gb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Gb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Gb.Location = new System.Drawing.Point(346, 19);
            this.button_Gb.Name = "button_Gb";
            this.button_Gb.Size = new System.Drawing.Size(45, 229);
            this.button_Gb.TabIndex = 11;
            this.button_Gb.Text = "F# Gb";
            this.button_Gb.UseVisualStyleBackColor = false;
            this.button_Gb.Click += new System.EventHandler(this.button_Gb_Click);
            // 
            // button_Ab
            // 
            this.button_Ab.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Ab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Ab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Ab.Location = new System.Drawing.Point(448, 19);
            this.button_Ab.Name = "button_Ab";
            this.button_Ab.Size = new System.Drawing.Size(45, 229);
            this.button_Ab.TabIndex = 12;
            this.button_Ab.Text = "G# Ab";
            this.button_Ab.UseVisualStyleBackColor = false;
            this.button_Ab.Click += new System.EventHandler(this.button_Ab_Click);
            // 
            // button_Bb
            // 
            this.button_Bb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Bb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Bb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Bb.Location = new System.Drawing.Point(550, 19);
            this.button_Bb.Name = "button_Bb";
            this.button_Bb.Size = new System.Drawing.Size(45, 229);
            this.button_Bb.TabIndex = 13;
            this.button_Bb.Text = "A# Bb";
            this.button_Bb.UseVisualStyleBackColor = false;
            this.button_Bb.Click += new System.EventHandler(this.button_Bb_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.button_Bb);
            this.groupBox3.Controls.Add(this.button_do);
            this.groupBox3.Controls.Add(this.button_Ab);
            this.groupBox3.Controls.Add(this.button_re);
            this.groupBox3.Controls.Add(this.button_Gb);
            this.groupBox3.Controls.Add(this.button_mi);
            this.groupBox3.Controls.Add(this.button_Eb);
            this.groupBox3.Controls.Add(this.button_fa);
            this.groupBox3.Controls.Add(this.button_Dob);
            this.groupBox3.Controls.Add(this.button_sol);
            this.groupBox3.Controls.Add(this.button_si);
            this.groupBox3.Controls.Add(this.button_lya);
            this.groupBox3.Location = new System.Drawing.Point(12, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 356);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Клавиши";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audio_volume)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_do;
        private System.Windows.Forms.Button button_re;
        private System.Windows.Forms.Button button_mi;
        private System.Windows.Forms.Button button_fa;
        private System.Windows.Forms.Button button_sol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button record_btn;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar audio_volume;
        private System.Windows.Forms.Button button_lya;
        private System.Windows.Forms.Button button_si;
        private System.Windows.Forms.Button button_Dob;
        private System.Windows.Forms.Button button_Eb;
        private System.Windows.Forms.Button button_Gb;
        private System.Windows.Forms.Button button_Ab;
        private System.Windows.Forms.Button button_Bb;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

