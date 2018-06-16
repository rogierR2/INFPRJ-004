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
    [Activity(Label = "Instelling")]
    public class Instelling : Activity
    {
        public static string game = "Makkelijk";
        private TextView mode;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Instelling);
            var btnMakkelijk = FindViewById<Button>(Resource.Id.btnMakkelijk);
            var btnNormaal = FindViewById<Button>(Resource.Id.btnNormaal);
            var btnMoeilijk = FindViewById<Button>(Resource.Id.btnMoeilijk);
            var btnBack = FindViewById<Button>(Resource.Id.btnback);
            mode = FindViewById<TextView>(Resource.Id.mode);
            mode.Text = "Makkelijk";


            btnMakkelijk.Click += delegate
            {
                game = "Makkelijk";
                mode.Text = game;
            };

            btnNormaal.Click += delegate
            {
                game = "Normaal";
                mode.Text = game;
            };

            btnMoeilijk.Click += delegate
            {
                game = "Moeilijk";
                mode.Text = game;
            };

            btnBack.Click += delegate
            {
                Finish();
            };
        }
    }
}