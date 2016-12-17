using Android.App;
using Android.Views;
using Android.Widget;
using ExitTest02.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;

namespace ExitTest02.Droid
{
    [Activity(Label = "ExitTest02.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class SomeActivity : MvxActivity<SomeViewModel>
    {
        private EditText _testEditText;
        private TextView _stateTextView;
        private Button _toggleButton;

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();

            SetContentView(Resource.Layout.activity_some);

            _testEditText = FindViewById<EditText>(Resource.Id.edittext_test);
            _stateTextView = FindViewById<TextView>(Resource.Id.textview_state);
            _toggleButton = FindViewById<Button>(Resource.Id.button_toggle);

            _toggleButton.Click += (sender, args) => Toogle();

            Update();
        }

        private void Update()
        {
            _stateTextView.Text = _testEditText.Enabled ? "Enabled" : "Disabled";
            _toggleButton.Text = _testEditText.Enabled ? "Disable" : "Enable";
        }

        private void Toogle()
        {
            _testEditText.Enabled = !_testEditText.Enabled;
            Update();
        }

        public override void OnBackPressed()
        {
            System.Environment.Exit(0);
        }
    }
}
