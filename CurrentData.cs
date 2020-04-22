using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace UIDESIGN
{
    class CurrentData : DialogFragment

    {
        //Override Method Called to have the fragment instantiate its user interface view.
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)

        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.CurrentDataUI, container, false);
            //initialize TextView used in the layout CurrentDataUI
            TextView StationText = view.FindViewById<TextView>(Resource.Id.cityVal_id);
            TextView HeightsText = view.FindViewById<TextView>(Resource.Id.heightVal_id);
            TextView dateText = view.FindViewById<TextView>(Resource.Id.date_id);
            TextView atlasText = view.FindViewById<TextView>(Resource.Id.atlasVal_id);
            TextView rise =view. FindViewById<TextView>(Resource.Id.sunriseVal_id);
            TextView set = view.FindViewById<TextView>(Resource.Id.sunsetVal_id);
            //Getting values from the static variable on mainactivity that contains api data.
            StationText.Text = MainActivity.sit;
            HeightsText.Text = MainActivity.height;
            dateText.Text = MainActivity.date1;
            atlasText.Text = MainActivity.atlas;
            rise.Text = MainActivity.sunrise+" "+"AM";
            set.Text = MainActivity.sunset+" "+"PM";
            return view;
        }
    }
}