using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace TecNMNetwork
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            Button accion1 = FindViewById<Button>(Resource.Id.iniciar);
            Button accion2 = FindViewById<Button>(Resource.Id.registrar);
            Button accion3 = FindViewById<Button>(Resource.Id.ingresar);
            Button accion4 = FindViewById<Button>(Resource.Id.registro);
            Button accion5 = FindViewById<Button>(Resource.Id.reticula);

            accion1.Click += delegate
            {
                SetContentView(Resource.Layout.layout1);
            };
            accion2.Click += delegate
            {
                SetContentView(Resource.Layout.registro);
            };

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
