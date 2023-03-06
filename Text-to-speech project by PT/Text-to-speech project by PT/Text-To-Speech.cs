using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis; // By going to reference manager, clicking assemblies, then system speech and add statement

namespace Text_to_speech_project_by_PT // Project Title // Coded by Patrick Tricenio 
{
    public partial class Form1 : Form// this is the application itself
    {

        SpeechSynthesizer Sap = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button3_Click(object sender, EventArgs e) // Exit button//
        {

            Sap = new SpeechSynthesizer();
            Sap.SpeakAsync("Please confirm if you want to exit");// Voice message when user click the button//
            await Task.Delay(1000);

            DialogResult iExit;
            iExit = MessageBox.Show ("Please confirm if you want to exit", "Text to Speech",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)//Yes if user want to exit  // using if and else to make conditional branching like on and off

            {
                Sap = new SpeechSynthesizer();
                Sap.SpeakAsync("Exiting Application");
                Application.Exit ();// if user want to exit application will close 
            }

            else// otherwise No
            {
                
                Sap = new SpeechSynthesizer();
                Sap.SpeakAsync(rtspeak.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e) // Application 
        {

        }

        private async void button1_Click(object sender, EventArgs e) // Play button //
        {

            Sap = new SpeechSynthesizer(); // Voice message will tell user if clicked Play
            Sap.SpeakAsync("Play");
            await Task.Delay(3000);// delay of 3 seconds

            if (rtspeak.Text !="") 
            {
                Sap=new SpeechSynthesizer();
                Sap.SpeakAsync(rtspeak.Text);
            }
            else 
            {
                rtspeak.Text = ("Please enter some words");// if user did not put any words on text box, application will asked Please enter some words.
                Sap = new SpeechSynthesizer();
                Sap.SpeakAsync(rtspeak.Text);
                await Task.Delay (1000);
                rtspeak.Clear();
                rtspeak.Focus();
            }
        }

        private  void button2_Click(object sender, EventArgs e)
        {
           
            if (Sap.State == SynthesizerState.Speaking)// pause button
            {
                Sap.Pause();
            }
           
        }

        private  void button4_Click(object sender, EventArgs e) // Resume button
        {

            if(Sap !=null)
            {
                if (Sap.State ==SynthesizerState.Paused) 
                {
                    Sap.Resume();// The Paused text will resume
                }
            }
        }

        private void rtspeak_TextChanged(object sender, EventArgs e)// text Box
        {



        }
    }
}

// What i find challenging
// 1. Combining Else If to Resume button so that Pause button will function as Pause/Resume
// 2. Sap new Speech Synthesizer to some buttons cannot be combined as it will be mixed to the main message
// 3. Improved Designs

//What i can practice
//1. Conditional branching
//2. OOP Encapsulation
//3. Exception Statement


//What i can improved
//1. less line of code, more efficiency, and time management
//2. Connection to server
//3. Debugging code
