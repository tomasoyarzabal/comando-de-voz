using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voz
{
    public partial class Frmvoz : Form
        
    {
        SpeechRecognitionEngine oEscucha = new SpeechRecognitionEngine();
        public Frmvoz()
        {
            InitializeComponent();
        }

        private void Frmvoz_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            oEscucha.SetInputToDefaultAudioDevice();
            oEscucha.LoadGrammar(new DictationGrammar());
            oEscucha.SpeechRecognized += Detection;
            oEscucha.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void Detection(object sender, SpeechRecognizedEventArgs e)
        {
            textBox1.Text = e.Result.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            oEscucha.RecognizeAsyncStop();
        }
    }
}
