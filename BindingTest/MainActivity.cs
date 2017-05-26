using Android.App;
using Android.Widget;
using Android.OS;


namespace BindingTest
{
    [Activity(Label = "BindingTest", MainLauncher = true, Icon = "@drawable/icon")]
        public class MainActivity : Activity
    {

        BeacappResponceCode responsecode;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            Button button_test = FindViewById<Button>(Resource.Id.button_test);
            string tag = "myapp";

            Android.Util.Log.Info(tag, "this is an info message");
            Android.Util.Log.Warn(tag, "this is a warning message");
            Android.Util.Log.Error(tag, "this is an error message");

            button_test.Click += (sender, e) => {
                // Perform action on click
                Beacapp_Droid.Becapp_Droid becap = new Beacapp_Droid.Becapp_Droid();
                //becap.InitializeBeacapp("G4SSV4TZQ1HJV4G7FYXJ", "DDy5Kv7lLUzfuU39RywZMPYIIgg=");
                responsecode = becap.InitializeBeacapp("G4SSV4TZQ1HJV4G7FYXJ", "DDy5Kv7lLUzfuU39RywZMPYIIgg=");
                Toast.MakeText(this,"Initilized sdk"+ " "+responsecode.ToString(), ToastLength.Long).Show();


            };

        }
    }
    }


