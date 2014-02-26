using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SpeechLib;

namespace AndroidApplication1
{
    [Activity(Label = "AndroidApplication1", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        int count = 1;
        SpeechHelper speech;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            speech = new SpeechHelper(this, "52060579");


            EditText text = FindViewById<EditText>(Resource.Id.editText1);
            text.Text = "灯，等灯等灯";

            speech.SetParameter(SpeechConstant.ENGINE_TYPE, "local");
            speech.SetParameter(SpeechSynthesizer.VOICE_NAME, "xiaoyan");
            speech.SetParameter(SpeechSynthesizer.SPEED, "40");
            speech.SetParameter(SpeechSynthesizer.PITCH, "50");
            speech.SetParameter(SpeechSynthesizer.VOLUME, "100");

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate 
            { 
                button.Text = string.Format("{0} clicks!", count++);

                EditText text2 = FindViewById<EditText>(Resource.Id.editText1);

                speech.StartSpeaking(text2.Text);
            };
        }
    }
}

