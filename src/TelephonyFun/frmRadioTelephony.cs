﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TelephonyFun
{
    public partial class frmRadioTelephony : Form
    {
        private TelephonyTranslator _telephonyTranslator = new TelephonyTranslator();
        private bool _firstEnter = true;
        public frmRadioTelephony()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            TranslatePnr();
        }

        private void TranslatePnr()
        {
            if (_firstEnter) return;

            var pnr = txtPnr.Text;

            if (string.IsNullOrEmpty(pnr))
            {
                txtTranslation.ResetText();
            }

            var result = _telephonyTranslator.Translate(pnr);

            var sb = new StringBuilder();
            foreach (var telephoneTranslation in result)
            {
                sb.AppendLine(string.Format("{0} => {1}", telephoneTranslation.Letter, telephoneTranslation.Telephony));
            }

            txtTranslation.Text = sb.ToString();
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            TranslatePnr();

            if (_firstEnter) return;
            var pnr = txtPnr.Text;
            var result = _telephonyTranslator.Translate(pnr);
            var sb = new StringBuilder();

            foreach (var telephoneTranslation in result)
            {
                sb.Append(string.Format("{0}  ", telephoneTranslation.Telephony));
            }

            var rate = int.Parse(numSpeed.Value.ToString(CultureInfo.InvariantCulture));
            if (rate < -10) rate = -10;
            if (rate > 10) rate = 10;

            var volume = int.Parse(numVolume.Value.ToString(CultureInfo.InvariantCulture));
            if (volume < 0) volume = 0;
            if (volume > 100) volume = 100;

            var speaker = new SpeechSynthesizer
            {
                Rate = rate,
                Volume = volume
            };
            speaker.SpeakProgress += speaker_SpeakProgress;
            speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            speaker.Speak(sb.ToString());
        }

        void speaker_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
        }

        private void txtPnr_Enter(object sender, EventArgs e)
        {
            if (_firstEnter)
            {
                txtPnr.Text = "";
                _firstEnter = false;
            }
        }
    }
}
