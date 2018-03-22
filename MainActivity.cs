using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace BTChat
{
    /// <summary>
    /// This is the main Activity that displays the current chat session.
    /// </summary>
    [Activity(Label = "@string/app_name", MainLauncher = true,
               ConfigurationChanges = Android.Content.PM.ConfigChanges.KeyboardHidden | Android.Content.PM.ConfigChanges.Orientation)]
    public class MainActivity : AppCompatActivity
    {
        new const string TAG = "BluetoothChat.MainActivity";
        bool logShown;
        BluetoothChatFragment chatFrag; 
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            if (savedInstanceState == null)
            {
                var tx = FragmentManager.BeginTransaction();
                chatFrag = new BluetoothChatFragment();
                tx.Replace(Resource.Id.sample_content_fragment, chatFrag);
                tx.Commit();

            }
        }

        public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.main, menu);
            return true;
        }
    }
}


