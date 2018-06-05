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
    [Activity(Label = "exercise")]
    public class exercise : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.exercise);

            // Create your application here

            var btnStop = FindViewById<Button>(Resource.Id.btnstop);

            btnStop.Click += delegate
            {
                Finish();
            };
        }
    }
}