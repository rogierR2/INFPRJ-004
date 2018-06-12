using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;

namespace QuickMath
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        //FrameLayout btnStart, btnGallery, btnInstellingen;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btnStart = FindViewById<Button>(Resource.Id.btnstart);
            var btnGallery = FindViewById<Button>(Resource.Id.btngallery);
            var btnInstellingen = FindViewById<Button>(Resource.Id.btninstellingen);

            btnStart.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(selectdiff));
                StartActivity(nextActivity);
            };

            btnGallery.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(Gallery));
                StartActivity(nextActivity);
            };
        }
    }
}

