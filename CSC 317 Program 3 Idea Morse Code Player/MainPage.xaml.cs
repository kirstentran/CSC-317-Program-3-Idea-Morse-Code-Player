using CommunityToolkit.Maui.Views;
using System.Threading;

namespace CSC_317_Program_3_Idea_Morse_Code_Player;
/* Program Author: Kirsten Tran - w10015360 
   Assignment: Program 3 Morse Code Player
Description: This Page cotains the back-end code of the apps running when the button Simulate is called */
public partial class MainPage : ContentPage
{
    /* This creates a class object of MorseEncoder, which
	 * is a class that accepts a message and converts it to 
	 * Morse Code. */
    MorseEncoder morseEncoder;
    public MainPage()
    {
        InitializeComponent();
        morseEncoder = new MorseEncoder();
    }

    /* This is the event function for the "Simulate" button.  
	 * You will need to set the button's Click event to this
	 * function. */
    private async void SimulateMorse(object sender, EventArgs e)
    {
        /*This is an example of playing a sound.
		 * Note that "dash" and "dot" are the Media Elements
		 * created in the front-end XAML code. 
		 * Modify this function so it translates the message
		 * correctly. */

        // Make the label blank whenever simulate a new text
        output.Text = " ";
        //Disable the button while the sounds are playing.
        btnSimulate.IsEnabled = false;
        //Disable the entry while the sounds are playing.
        input.IsReadOnly = true;

        //set Text value and start translate
        morseEncoder.Text = input.Text;


        //Play sound based on the morse code translated
        for (int i = 0; i < morseEncoder.Morse.Length; i++)
        {
            //Plays a Dot
            if (morseEncoder.Morse[i] == '.')
            {
                await PlaySound(dot);

            }
            //Plays a Dash
            else if (morseEncoder.Morse[i] == '-')
            {
                await PlaySound(dash);

            }
            else if (morseEncoder.Morse[i] == '\\') { await Task.Delay(1000); }
            output.Text += morseEncoder.Morse[i].ToString();


            //This function can be used to add a delay between the next dot/dash.
            //Delays for 1 second (measured in milliseconds).
        }

        //Once the sounds are finished, enable the button and entry to allow running again.
        btnSimulate.IsEnabled = true;
        input.IsReadOnly = false;




    }

    /* This function should be called in the Click event function
	 * above.  DO NOT MODIFY!!! */
    private async Task PlaySound(MediaElement sound)
    {
        TimeSpan duration = sound.Duration;
        sound.Play();
        await Task.Delay(duration.Milliseconds + 200);

        return;
    }

}

