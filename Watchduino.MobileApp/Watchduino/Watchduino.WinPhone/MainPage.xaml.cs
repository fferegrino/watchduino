﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Watchduino.WinPhone
{
    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new Watchduino.App());

            Parse.ParsePush.ParsePushNotificationReceived += ParsePush_ParsePushNotificationReceived;
        }

        private void ParsePush_ParsePushNotificationReceived(object sender, Parse.ParsePushNotificationEventArgs e)
        {
            ;
        }
    }
}
