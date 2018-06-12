﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace QuickMath
{
    [Activity(Label = "Gallery")]
    public class Gallery : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.gallery);

            var btnDownloadWallpaper1 = FindViewById<Button>(Resource.Id.btnDownloadWP1);
            var btnDownloadWallpaper2 = FindViewById<Button>(Resource.Id.btnDownloadWP2);
            var btnDownloadWallpaper3 = FindViewById<Button>(Resource.Id.btnDownloadWP3);
            var imgWallpaper1 = FindViewById<ImageView>(Resource.Id.imgWallpaper1);
            var imgWallpaper2 = FindViewById<ImageView>(Resource.Id.imgWallpaper2);
            var imgWallpaper3 = FindViewById<ImageView>(Resource.Id.imgWallpaper3);



            btnDownloadWallpaper1.Click += delegate
            {
                DownloadWallpaper download = new DownloadWallpaper(this, imgWallpaper1);
                download.Execute("https://i.imgur.com/XsSVnAT.png");
            };

            btnDownloadWallpaper2.Click += delegate
            {
                DownloadWallpaper download = new DownloadWallpaper(this, imgWallpaper2);
                download.Execute("https://i.imgur.com/c9dJWnq.png");
            };

            btnDownloadWallpaper3.Click += delegate
            {
                DownloadWallpaper download = new DownloadWallpaper(this, imgWallpaper3);
                download.Execute("https://i.imgur.com/GLlaRLf.png");
            };
        }
    }
}