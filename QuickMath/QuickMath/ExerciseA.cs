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
    [Activity(Label = "exerciseinputA")]
    public class ExerciseA : Activity 
    {
        Timer timer;
        Random r = new Random();
        private TextView txtTimer;
        private TextView txtScore;
        private TextView txtnumber1;
        private TextView txtnumber2;
        private TextView txtnumber3;
        private EditText input;
        private int count = 60;

        private int score = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.exercise);

            // Create your application here

            var btnStop = FindViewById<Button>(Resource.Id.btnstop);
            var btnCheck = FindViewById<Button>(Resource.Id.check);

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
            txtnumber3 = FindViewById<TextView>(Resource.Id.editText1);
            input = FindViewById<EditText>(Resource.Id.input);
            /*var correctAns = FindViewById<Button>(Resource.Id.btnanswer1);
            var wrongAns = FindViewById<Button>(Resource.Id.btnanswer2);*/
            int txtnum1 = r.Next(100);
            int txtnum2 = r.Next(100);

            if (Instelling.game == "Normaal")
            {
                txtnum1 = r.Next(50);
                txtnum2 = r.Next(50);
            }

            if (Instelling.game == "Makkelijk")
            {
            txtnum1 = r.Next(20);
            txtnum2 = r.Next(20);
            }
            
            txtnumber1.Text = txtnum1.ToString();
            txtnumber2.Text = txtnum2.ToString();
            int textnumbersum = txtnum1 + txtnum2;
            
           
            btnCheck.Click += delegate
            {

                if (input.Text == textnumbersum.ToString())
                {
                    score += 1;
                    if (score > selectdiff.cntAreeks)
                    {
                        selectdiff.cntAreeks = score;
                    }
                    if (score > 2)
                    {
                        txtScore.Text = "Reeks:" + score + "🔥";
                    }
                    else
                    {
                        txtScore.Text = "Reeks:" + score;
                    }
                    txtnumber3.Text = "Correct";


                    if (Instelling.game == "Moeilijk")
                    {
                        txtnum1 = r.Next(100);
                        txtnum2 = r.Next(100);
                    }

                    if (Instelling.game == "Normaal")
                    {
                        txtnum1 = r.Next(50);
                        txtnum2 = r.Next(50);
                    }

                    if (Instelling.game == "Makkelijk")
                    {
                        txtnum1 = r.Next(20);
                        txtnum2 = r.Next(20);
                    }
                    txtnumber1.Text = txtnum1.ToString();
                    txtnumber2.Text = txtnum2.ToString();

                    textnumbersum = txtnum1 + txtnum2;
                    input.Text = "";
                }
                else
                {
                    score = 0;
                    count -= 5;
                    txtScore.Text = "Reeks:" + score;
                    txtnumber3.Text = "Verkeerd: het antwoord is " + textnumbersum.ToString() + " hierbij -5 tijd";
                    input.Text = "";

                    if (count <= 0)
                    {
                        Toast.MakeText(this, "Goed gerekend", ToastLength.Short).Show();
                        timer.Stop();
                        Finish();
                    }
                }

            };            

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
                    count = 60;
                    Finish();
                });
            }
        }
    }
}