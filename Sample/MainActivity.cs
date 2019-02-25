using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Com.Voxeet.Toolkit.Activities.Notification;
using Com.Voxeet.Toolkit.Controllers;
using EU.Codlab.Simplepromise;
using EU.Codlab.Simplepromise.Solve;
using Org.Greenrobot.Eventbus;
using Voxeet.Com.Sdk.Core;
using Voxeet.Com.Sdk.Core.Preferences;
using Voxeet.Com.Sdk.Json;

namespace Sample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            VoxeetToolkit.Initialize(this.Application, EventBus.Default);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public EU.Codlab.Simplepromise.Promise uniqueInitializeSDK()
        {
            return new Promise(new Solver(this.Application));
        }


        class Solver : PromiseSolver
        {
            Application application { get; set; }
            public Solver(Application application)
            {
                this.application = application;
            }
            public override void OnCall(EU.Codlab.Simplepromise.Solve.Solver solver)
            {
                VoxeetSdk.Initialize(this.application,
                            "NGk1MWE1aW81Z21nNg==",
                            "c2w0b2RyamNpMm1vOGY3dnZncjlqaDB1YQ==",
                            new UserInfo("Test", "123", null)); //can be null - will be removed in a later version
                onSdkInitialized();
                solver.Resolve(true);
            }

            private void onSdkInitialized()
            {
                VoxeetSdk.Instance.Register(application, application);

            }
        }
    }

    
}