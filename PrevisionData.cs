using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;

namespace UIDESIGN
{
    class PrevisionData : DialogFragment

    {
        //Override Method Called to have the fragment instantiate its user interface view.
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.PrevisionDataUI, container, false);
            //initialize TextView used in the layout PrevisionDataUI
            TextView prev1 = view.FindViewById<TextView>(Resource.Id.textView1);
            TextView prev2 = view.FindViewById<TextView>(Resource.Id.textView2);
            TextView prev3 = view.FindViewById<TextView>(Resource.Id.textView3);
            TextView prev4 = view.FindViewById<TextView>(Resource.Id.textView4);
            TextView prev5 = view.FindViewById<TextView>(Resource.Id.textView5);
            TextView prev6 = view.FindViewById<TextView>(Resource.Id.textView6);
            TextView prev7 = view.FindViewById<TextView>(Resource.Id.textView7);
            TextView prev8 = view.FindViewById<TextView>(Resource.Id.textView8);
            TextView prev9 = view.FindViewById<TextView>(Resource.Id.textView9);
            TextView prev10 = view.FindViewById<TextView>(Resource.Id.textView10);
            TextView prev11 = view.FindViewById<TextView>(Resource.Id.textView11);
            TextView prev12 = view.FindViewById<TextView>(Resource.Id.textView12);
            TextView prev13 = view.FindViewById<TextView>(Resource.Id.textView13);
            TextView prev14 = view.FindViewById<TextView>(Resource.Id.textView14);
            TextView prev15 = view.FindViewById<TextView>(Resource.Id.textView15);
            TextView prev16 = view.FindViewById<TextView>(Resource.Id.textView16);
            TextView prev17 = view.FindViewById<TextView>(Resource.Id.textView17);
            TextView prev18 = view.FindViewById<TextView>(Resource.Id.textView18);
            TextView prev19 = view.FindViewById<TextView>(Resource.Id.textView19);
            TextView prev20 = view.FindViewById<TextView>(Resource.Id.textView20);
            TextView prev21 = view.FindViewById<TextView>(Resource.Id.textView21);
            //Getting values from the static variable on mainactivity that contains api data.
            prev1.Text = "Tide height:"+" "+MainActivity.height0+" "+"At:"+" "+MainActivity.hourform0;
             prev2.Text = "Tide height:" + " " + MainActivity.height1 + " " +  "At:" + " " + MainActivity.hourform1;
            prev3.Text = "Tide height:" + " " + MainActivity.height2 + " " + "At:" + " " + MainActivity.hourform2;
            prev4.Text = "Tide height:" + " " + MainActivity.height3 + " " + "At:" + " " + MainActivity.hourform3;
            prev5.Text = "Tide height:" + " " + MainActivity.height4 + " " + "At:" + " " + MainActivity.hourform4;
            prev6.Text = "Tide height:" + " " + MainActivity.height5 + " " + "At:" + " " + MainActivity.hourform5;
            prev7.Text = "Tide height:" + " " + MainActivity.height6 + " " + "At:" + " " + MainActivity.hourform6;
            prev8.Text = "Tide height:" + " " + MainActivity.height7 + " " + "At:" + " " + MainActivity.hourform7;
            prev9.Text = "Tide height:" + " " + MainActivity.height8 + " " + "At:" + " " + MainActivity.hourform8;
            prev10.Text = "Tide height:" + " " + MainActivity.height9 + " " + "At:" + " " + MainActivity.hourform9;
            prev11.Text = "Tide height:" + " " + MainActivity.height10 + " " + "At:" + " " + MainActivity.hourform10;
            prev12.Text = "Tide height:" + " " + MainActivity.height11 + " " + "At:" + " " + MainActivity.hourform11;
            prev13.Text = "Tide height:" + " " + MainActivity.height12 + " " + "At:" + " " + MainActivity.hourform12;
            prev14.Text = "Tide height:" + " " + MainActivity.height13 + " " + "At:" + " " + MainActivity.hourform13;
            prev15.Text = "Tide height:" + " " + MainActivity.height14 + " " + "At:" + " " + MainActivity.hourform14;
            prev16.Text = "Tide height:" + " " + MainActivity.height15 + " " + "At:" + " " + MainActivity.hourform15;
            prev17.Text = "Tide height:" + " " + MainActivity.height16 + " " + "At:" + " " + MainActivity.hourform16;
            prev18.Text = "Tide height:" + " " + MainActivity.height17 + " " + "At:" + " " + MainActivity.hourform17;
            prev19.Text = "Tide height:" + " " + MainActivity.height18 + " " + "At:" + " " + MainActivity.hourform18;
            prev20.Text = "Tide height:" + " " + MainActivity.height19 + " " + "At:" + " " + MainActivity.hourform19;
            prev21.Text = "Tide height:" + " " + MainActivity.height20 + " " + "At:" + " " + MainActivity.hourform20;
            return view;
        }
    }
}