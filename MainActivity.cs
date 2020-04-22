using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Xamarin.Essentials;
using Plugin.Connectivity;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Globalization;
using Android.Icu.Text;
using Android.Support.V4.Widget;
using System.ComponentModel;
using static Android.Resource;
using System.Linq;
using CoordinateSharp;
using Innovative.SolarCalculator;
using Android.Locations;
using System.Collections.Generic;
using Android.Util;

namespace UIDESIGN
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button current;
        private Button prevision;
        public static string height;
        public static string height0;
        public static string height1;
        public static string height2;
        public static string height3;
        public static string height4;
        public static string height5;
        public static string height6;
        public static string height7;
        public static string height8;
        public static string height9;
        public static string height10;
        public static string height11;
        public static string height12;
        public static string height13;
        public static string height14;
        public static string height15;
        public static string height16;
        public static string height17;
        public static string height18;
        public static string height19;
        public static string height20;
        public static string hour0;
        public static string hour1;
        public static string hour2;
        public static string hour3;
        public static string hour4;
        public static string hour5;
        public static string hour6;
        public static string hour7;
        public static string hour8;
        public static string hour9;
        public static string hour10;
        public static string hour11;
        public static string hour12;
        public static string hour13;
        public static string hour14;
        public static string hour15;
        public static string hour16;
        public static string hour17;
        public static string hour18;
        public static string hour19;
        public static string hour20;
        public static string hourform0;
        public static string hourform1;
        public static string hourform2;
        public static string hourform3;
        public static string hourform4;
        public static string hourform5;
        public static string hourform6;
        public static string hourform7;
        public static string hourform8;
        public static string hourform9;
        public static string hourform10;
        public static string hourform11;
        public static string hourform12;
        public static string hourform13;
        public static string hourform14;
        public static string hourform15;
        public static string hourform16;
        public static string hourform17;
        public static string hourform18;
        public static string hourform19;
        public static string hourform20;
        public static string date;
        public static string date1;
        public static string sunrise;
        public static string sunset;
        public static string sit;
        public static string atlas;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //initialize all the component that we gonna use
            current = FindViewById<Button>(Resource.Id.current);
            TextView StationText = (TextView)FindViewById<TextView>(Resource.Id.cityVal_id);
            TextView HeightsText = FindViewById<TextView>(Resource.Id.heightVal_id);
            TextView dateText = FindViewById<TextView>(Resource.Id.date_id);
            TextView atlasText = FindViewById<TextView>(Resource.Id.atlasVal_id);
            TextView prev1 = FindViewById<TextView>(Resource.Id.textView1);
            TextView prev2 = FindViewById<TextView>(Resource.Id.textView2);
            TextView prev3 = FindViewById<TextView>(Resource.Id.textView3);
            TextView prev4 = FindViewById<TextView>(Resource.Id.textView4);
            TextView prev5 = FindViewById<TextView>(Resource.Id.textView5);
            TextView prev6 = FindViewById<TextView>(Resource.Id.textView6);
            TextView prev7 = FindViewById<TextView>(Resource.Id.textView7);
            TextView prev8 = FindViewById<TextView>(Resource.Id.textView8);
            TextView prev9 = FindViewById<TextView>(Resource.Id.textView9);
            TextView prev10 = FindViewById<TextView>(Resource.Id.textView10);
            TextView prev11 = FindViewById<TextView>(Resource.Id.textView11);
            TextView prev12 = FindViewById<TextView>(Resource.Id.textView12);
            TextView prev13 = FindViewById<TextView>(Resource.Id.textView13);
            TextView prev14 = FindViewById<TextView>(Resource.Id.textView14);
            TextView prev15 = FindViewById<TextView>(Resource.Id.textView15);
            TextView prev16 = FindViewById<TextView>(Resource.Id.textView16);
            TextView prev17 = FindViewById<TextView>(Resource.Id.textView17);
            TextView rise = FindViewById<TextView>(Resource.Id.sunriseVal_id);
            TextView set = FindViewById<TextView>(Resource.Id.sunsetVal_id);
            //handle event management on the currentdata button 
            current.Click += async (object sender, EventArgs args) =>
            {              
                    FragmentTransaction transaction = FragmentManager.BeginTransaction();
                CurrentData sign = new CurrentData();
                sign.Show(transaction, "dialog fragment");
                //Set url and apikey  and location to access the api
                string apiKey = "9bd81129-3c82-439e-84c1-230ab7417852";
                string apiBase = "https://www.worldtides.info/api?heights";
                var location = await Geolocation.GetLocationAsync();
                // Asynchronous API call using HttpClient
                string url = apiBase + "&lat=" + location.Latitude.ToString() + "&lon=" + location.Longitude.ToString() + "&key=" + apiKey;
                // handle no internet connection event
                if (!CrossConnectivity.Current.IsConnected)
                {
                    Toast.MakeText(this, "No internet connection", ToastLength.Short).Show();
                    return;
                }
                var handler = new HttpClientHandler();
                HttpClient client = new HttpClient(handler);
                string result = await client.GetStringAsync(url);
                var resultObject = JObject.Parse(result);
                // fetch and retrieve height,date,atlas data from the api
                height = resultObject["heights"][0]["height"].ToString();
                date = resultObject["heights"][0]["date"].ToString();
                atlas = resultObject["atlas"].ToString();
                date1 = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local).ToString();
                // Using geocoding and location to get corresponding city name.
                var placemarks = await Geocoding.GetPlacemarksAsync(location.Latitude, location.Longitude);
                var placemark = placemarks?.FirstOrDefault();
                if (placemark != null)
                {
                    sit = placemark.Locality;

                }
                // Using SolarTimes packages to get sunriseTime and sunsetTime and convert it to localtimezone.
                SolarTimes solarTimes = new SolarTimes(TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local), location.Latitude, location.Longitude);
                DateTime sr = solarTimes.Sunrise;
                DateTime dt = Convert.ToDateTime(sr);
                sunrise = dt.ToString("hh:mm");
                SolarTimes solarTimes1 = new SolarTimes(TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local), location.Latitude, location.Longitude);
                DateTime sr1 = solarTimes1.Sunset;
                DateTime dt1 = Convert.ToDateTime(sr1);
                sunset = dt1.ToString("hh:mm");
                //Refresh the layout
                this.Recreate();
            };

           //initialize prevision button
            prevision = FindViewById<Button>(Resource.Id.prevision);
            //handle event management on the Prevision button 
            prevision.Click += async (object sender, EventArgs args) =>
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                PrevisionData sign = new PrevisionData();
                sign.Show(transaction, "dialog fragment");
                //Set url and apikey  and location to access the api
                string apiKey = "9bd81129-3c82-439e-84c1-230ab7417852";
                string apiBase = "https://www.worldtides.info/api?heights";
                var location = await Geolocation.GetLocationAsync();
                // Asynchronous API call using HttpClient
                string url = apiBase + "&lat=" + location.Latitude.ToString() + "&lon=" + location.Longitude.ToString() + "&key=" + apiKey;
                // handle no internet connection event
                if (!CrossConnectivity.Current.IsConnected)
                {
                    Toast.MakeText(this, "No internet connection", ToastLength.Short).Show();
                    return;
                }
                var handler = new HttpClientHandler();
                HttpClient client = new HttpClient(handler);
                string result = await client.GetStringAsync(url);
                var resultObject = JObject.Parse(result);
                // fetch and retrieve height,date and converted to local timezone  data from the api
                // date and height for past 6hours and next 4 hours within every 30 minutes
                height0 = resultObject["heights"][0]["height"].ToString();
                height1 = resultObject["heights"][1]["height"].ToString();
                height2 = resultObject["heights"][2]["height"].ToString();
                height3 = resultObject["heights"][3]["height"].ToString();
                height4 = resultObject["heights"][4]["height"].ToString();
                height5 = resultObject["heights"][5]["height"].ToString();
                height6 = resultObject["heights"][6]["height"].ToString();
                height7 = resultObject["heights"][7]["height"].ToString();
                height8 = resultObject["heights"][8]["height"].ToString();
                height9 = resultObject["heights"][9]["height"].ToString();
                height10= resultObject["heights"][10]["height"].ToString();
                height11 = resultObject["heights"][11]["height"].ToString();
                height12 = resultObject["heights"][12]["height"].ToString();
                height13 = resultObject["heights"][13]["height"].ToString();
                height14 = resultObject["heights"][11]["height"].ToString();
                height15 = resultObject["heights"][12]["height"].ToString();
                height16 = resultObject["heights"][16]["height"].ToString();
                height17 = resultObject["heights"][17]["height"].ToString();
                height18 = resultObject["heights"][18]["height"].ToString();
                height19 = resultObject["heights"][19]["height"].ToString();
                height20 = resultObject["heights"][20]["height"].ToString();
                hour0 = resultObject["heights"][0]["date"].ToString();
                DateTime s1 = DateTime.Parse(hour0);
                hourform0 = TimeZoneInfo.ConvertTime(s1, TimeZoneInfo.Local).ToString();
                hour1 = resultObject["heights"][1]["date"].ToString();
                DateTime s2 = DateTime.Parse(hour1);
                hourform1 = TimeZoneInfo.ConvertTime(s2, TimeZoneInfo.Local).ToString();
                hour2 = resultObject["heights"][2]["date"].ToString();
                DateTime s3 = DateTime.Parse(hour2);
                hourform2 = TimeZoneInfo.ConvertTime(s3, TimeZoneInfo.Local).ToString();
                hour3 = resultObject["heights"][3]["date"].ToString();
                DateTime s4 = DateTime.Parse(hour3);
                hourform3 = TimeZoneInfo.ConvertTime(s4, TimeZoneInfo.Local).ToString();
                hour4 = resultObject["heights"][4]["date"].ToString();
                DateTime s5 = DateTime.Parse(hour4);
                hourform4 = TimeZoneInfo.ConvertTime(s5, TimeZoneInfo.Local).ToString();
                hour5 = resultObject["heights"][5]["date"].ToString();
                DateTime s6 = DateTime.Parse(hour5);
                hourform5 = TimeZoneInfo.ConvertTime(s6, TimeZoneInfo.Local).ToString();
                hour6 = resultObject["heights"][6]["date"].ToString();
                DateTime s7 = DateTime.Parse(hour6);
                hourform6 = TimeZoneInfo.ConvertTime(s7, TimeZoneInfo.Local).ToString();
                hour7 = resultObject["heights"][7]["date"].ToString();
                DateTime s8 = DateTime.Parse(hour7);
                hourform7 = TimeZoneInfo.ConvertTime(s8, TimeZoneInfo.Local).ToString();
                hour8 = resultObject["heights"][8]["date"].ToString();
                DateTime s9 = DateTime.Parse(hour8);
                hourform8 = TimeZoneInfo.ConvertTime(s9, TimeZoneInfo.Local).ToString();
                hour9 = resultObject["heights"][9]["date"].ToString();
                DateTime s10 = DateTime.Parse(hour9);
                hourform9 = TimeZoneInfo.ConvertTime(s10, TimeZoneInfo.Local).ToString();
                hour10 = resultObject["heights"][10]["date"].ToString();
                DateTime s11 = DateTime.Parse(hour10);
                hourform10 = TimeZoneInfo.ConvertTime(s11, TimeZoneInfo.Local).ToString();
                hour11 = resultObject["heights"][11]["date"].ToString();
                DateTime s12 = DateTime.Parse(hour11);
                hourform11 = TimeZoneInfo.ConvertTime(s12, TimeZoneInfo.Local).ToString();
                hour12 = resultObject["heights"][12]["date"].ToString();
                DateTime s13 = DateTime.Parse(hour12);
                hourform12 = TimeZoneInfo.ConvertTime(s13, TimeZoneInfo.Local).ToString();
                hour13 = resultObject["heights"][13]["date"].ToString();
                DateTime s14 = DateTime.Parse(hour13);
                hourform13 = TimeZoneInfo.ConvertTime(s14, TimeZoneInfo.Local).ToString();
                hour14 = resultObject["heights"][14]["date"].ToString();
                DateTime s15 = DateTime.Parse(hour14);
                hourform14 = TimeZoneInfo.ConvertTime(s15, TimeZoneInfo.Local).ToString();
                hour15 = resultObject["heights"][15]["date"].ToString();
                DateTime s16 = DateTime.Parse(hour15);
                hourform15 = TimeZoneInfo.ConvertTime(s16, TimeZoneInfo.Local).ToString();
                hour16 = resultObject["heights"][16]["date"].ToString();
                DateTime s17 = DateTime.Parse(hour16);
                hourform16 = TimeZoneInfo.ConvertTime(s17, TimeZoneInfo.Local).ToString();
                hour17 = resultObject["heights"][17]["date"].ToString();
                DateTime s18 = DateTime.Parse(hour17);
                hourform17 = TimeZoneInfo.ConvertTime(s18, TimeZoneInfo.Local).ToString();
                hour18 = resultObject["heights"][18]["date"].ToString();
                DateTime s19 = DateTime.Parse(hour18);
                hourform18 = TimeZoneInfo.ConvertTime(s19, TimeZoneInfo.Local).ToString();
                hour19 = resultObject["heights"][19]["date"].ToString();
                DateTime s20 = DateTime.Parse(hour19);
                hourform19 = TimeZoneInfo.ConvertTime(s20, TimeZoneInfo.Local).ToString();
                hour20 = resultObject["heights"][20]["date"].ToString();
                DateTime s21 = DateTime.Parse(hour20);
                hourform20 = TimeZoneInfo.ConvertTime(s21, TimeZoneInfo.Local).ToString();
                //Refresh layout
                this.Recreate();
            };
            }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}