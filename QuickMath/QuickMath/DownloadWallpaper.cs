using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.IO;
using Java.Net;

namespace QuickMath
{
    [Activity(Label = "DownloadWallpaper")]
    public class DownloadWallpaper : AsyncTask<string, string, string>
    {
        private ProgressDialog pDialog;
        private ImageView imgView;
        private Context context;
               
        public DownloadWallpaper(Context context, ImageView imgView)
        {
            this.context = context;
            this.imgView = imgView;
        }

        protected override void OnPostExecute(string result)
        {
            string storagePath = Android.OS.Environment.ExternalStorageDirectory.Path;
            string filePath = System.IO.Path.Combine(storagePath, "QuickMath_Wallpaper.jpg");

            pDialog.Dismiss();
            imgView.SetImageDrawable(Drawable.CreateFromPath(filePath));
            //base.OnPostExecute(result);
        }

        protected override void OnPreExecute()
        {
            pDialog = new ProgressDialog(context);
            pDialog.SetMessage("Wallpaper wordt gedownload...");
            pDialog.Indeterminate = false;
            pDialog.Max = 100;
            pDialog.SetProgressStyle(ProgressDialogStyle.Horizontal);
            pDialog.SetCancelable(true);
            pDialog.Show();

            base.OnPreExecute();
        }

        protected override void OnProgressUpdate(params string[] values)
        {
            pDialog.SetProgressNumberFormat(values[0]);
            pDialog.Progress = int.Parse(values[0]);
            base.OnProgressUpdate(values);
        }

        protected override string RunInBackground(params string[] @params)
        {
            string storagePath = Android.OS.Environment.ExternalStorageDirectory.Path;
            string filePath = System.IO.Path.Combine(storagePath, "QuickMath_Wallpaper.jpg");
            int count = 0;

            try
            {
                URL url = new URL(@params[0]);
                URLConnection connection = url.OpenConnection();
                connection.Connect();
                int LengthOfFile = connection.ContentLength;
                InputStream input = new BufferedInputStream(url.OpenStream(), LengthOfFile);
                OutputStream output = new FileOutputStream(filePath);

                byte[] data = new byte[1024];
                long total = 0;
                while((count = input.Read(data)) != -1)
                {
                    total += count;
                    float sum = total / (float)LengthOfFile;
                    PublishProgress("" + ((int)(sum * 100)).ToString());
                    output.Write(data, 0, count);
                }

                output.Flush();
                output.Close();
                input.Close();
            }
            catch (Exception e)
            {

                throw;
            }

            return null;
        }
    }
}