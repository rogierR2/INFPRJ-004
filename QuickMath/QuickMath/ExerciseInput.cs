using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace QuickMath
{
    [Activity(Label = "exercise")]
    public class ExerciseInput : Activity
    {
        Timer timer;
        Random r = new Random();
        private TextView txtTimer;
        private TextView txtScore;
        private TextView txtnumber1;
        private TextView txtnumber2;
        private EditText input;
        private int count = 60;

        private int score = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.exerciseuserinput);

            // Create your application here

            var btnStop = FindViewById<Button>(Resource.Id.btnstop);

            btnStop.Click += delegate
            {
                Toast.MakeText(this, "Spel beëindigd.", ToastLength.Short).Show();
                timer.Stop();
                Finish();
            };

            txtTimer = FindViewById<TextView>(Resource.Id.txttimer);
            txtScore = FindViewById<TextView>(Resource.Id.txtstreak);
            txtnumber1 = FindViewById<TextView>(Resource.Id.txtnumber1);
            txtnumber2 = FindViewById<TextView>(Resource.Id.txtnumber2);
            input = FindViewById<EditText>(Resource.Id.input);
            /*var correctAns = FindViewById<Button>(Resource.Id.btnanswer1);
            var wrongAns = FindViewById<Button>(Resource.Id.btnanswer2);*/
            txtnumber1.Text = r.Next(100).ToString();
            txtnumber2.Text = r.Next(100).ToString();
            int txtnum1 = Int32.Parse(txtnumber1.Text);
            int txtnum2 = Int32.Parse(txtnumber2.Text);
            int textnumbersum = txtnum1 + txtnum2;

            if (input.Text == textnumbersum.ToString())
            {
                Intent nextActivity = new Intent(this, typeof(ExerciseInput));
                StartActivity(nextActivity);
            }
            
        }

        protected override void OnResume()
        {
            base.OnResume();
            timer = new Timer();
            timer.Interval = 1000; // 1 sec
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        
        
        public override void OnBackPressed()
        {
            Toast.MakeText(this, "Spel beëindigd.", ToastLength.Short).Show();
            timer.Stop();
            Finish();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (count > 0)
            {
                count--;
                RunOnUiThread(() =>
                {
                    txtTimer.Text = "Tijd: " + count;
                });
            }
            else
            {
                RunOnUiThread(() => 
                {
                    Toast.MakeText(this, "Spel beëindigd. Goed gerekend!", ToastLength.Short).Show();
                    timer.Stop();
                    Finish();
                });
            }
        }
    }
}