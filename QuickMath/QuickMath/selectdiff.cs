using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace QuickMath
{
    [Activity(Label = "selectdiff")]
    public class selectdiff : Activity
    {
        public static int cntAreeks;
        public static int cntMreeks;
        public static int cntMixreeks;
        private TextView highscoreA;
        private TextView highscoreM;
        private TextView highscoreMix;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.selectdiff);

            highscoreA = FindViewById<TextView>(Resource.Id.highscoreA);
            highscoreM = FindViewById<TextView>(Resource.Id.highscoreM);
            highscoreMix = FindViewById<TextView>(Resource.Id.highscoreMix);
            var btnOptelsom = FindViewById<Button>(Resource.Id.btnoptelsom);
            var btnAftreksom = FindViewById<Button>(Resource.Id.btnaftreksom);
            var btnGemixtesom = FindViewById<Button>(Resource.Id.btngemixtesom);
            var btnBack = FindViewById<Button>(Resource.Id.btnback);

            highscoreA.Text = "Hoogste optelsommen reeks:" + cntAreeks;
            highscoreM.Text = "Hoogste aftreksommen reeks:" + cntMreeks;
            highscoreMix.Text = "Hoogste mix reeks:" + cntMixreeks;
            btnBack.Click += delegate
            {
                Finish();
            };

            btnOptelsom.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(ExerciseA));
                StartActivity(nextActivity);
            };

            btnAftreksom.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(ExerciseM));
                StartActivity(nextActivity);
            };

            btnGemixtesom.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(ExerciseMix));
                StartActivity(nextActivity);
            };
        }
    }
}