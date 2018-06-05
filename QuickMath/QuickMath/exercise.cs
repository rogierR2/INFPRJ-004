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
    public class exercise : Activity
    {
        Timer timer;
        private TextView txtTimer;
        private int count = 10;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.exercise);

            // Create your application here

            var btnStop = FindViewById<Button>(Resource.Id.btnstop);

            btnStop.Click += delegate
            {
                Toast.MakeText(this, "Spel beëindigd.", ToastLength.Short).Show();
                timer.Stop();
                Finish();
            };

            txtTimer = FindViewById<TextView>(Resource.Id.txttimer);



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