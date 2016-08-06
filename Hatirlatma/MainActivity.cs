using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;


namespace Hatirlatma
{
    [Activity(Label = "Hatirlatma", MainLauncher = true, Icon = "@drawable/reminder")]
    public class MainActivity : Activity
    {

        EditText edtHatırlatma;
        Button btnHatırlat;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            DateTime now = DateTime.Now.ToLocalTime();
            string currentTime = (string.Format(" {0}", now));

            edtHatırlatma = FindViewById<EditText>(Resource.Id.edtHatırlatma);
            btnHatırlat = FindViewById<Button>(Resource.Id.btnHatırlat);
            
            btnHatırlat.Click += delegate
            {
                if (int.Parse(currentTime) != int.Parse(currentTime))
                {
                    Notification.Builder builder = new Notification.Builder(this)
            .SetContentTitle("Sample Notification")
            .SetContentText("Message:" + edtHatırlatma.Text)
             .SetDefaults(NotificationDefaults.Sound)
            .SetSmallIcon(Resource.Drawable.reminder);

                    // Build the notification:
                    Notification notification = builder.Build();

                    // Get the notification manager:
                    NotificationManager notificationManager =
                        GetSystemService(Context.NotificationService) as NotificationManager;

                    // Publish the notification:
                    const int notificationId = 12;
                    notificationManager.Notify(notificationId, notification);
                }
            };

          

        }

       
    }
}

