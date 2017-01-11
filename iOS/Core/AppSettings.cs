﻿using System;
using Foundation;

namespace Drop.iOS
{
	public class AppSettings
	{
		private const string userFBID = "FBID";
		public static string UserFBID
		{
			get { return NSUserDefaults.StandardUserDefaults.StringForKey(userFBID); }
			set
			{
				NSUserDefaults.StandardUserDefaults.SetString(value, userFBID);
			}
		}

		private const string userFirstname = "userFirstname";
		public static string UserFirstname
		{
			get { return NSUserDefaults.StandardUserDefaults.StringForKey(userFirstname); }
			set
			{
				NSUserDefaults.StandardUserDefaults.SetString(value, userFirstname);
			}
		}
		private const string userLastname = "userLastname";
		public static int UserLastname
		{
			get { return (int)NSUserDefaults.StandardUserDefaults.IntForKey(userLastname); }
			set
			{
				NSUserDefaults.StandardUserDefaults.SetInt(value, userLastname);
			}
		}
		private const string userEmail = "userEmail";
		public static int UserEmail
		{
			get { return (int)NSUserDefaults.StandardUserDefaults.IntForKey(userEmail); }
			set
			{
				NSUserDefaults.StandardUserDefaults.SetInt(value, userEmail);
			}
		}
		private const string userPhotoURL = "userPhotoURL";
		public static string UserPhotoURL
		{
			get { return NSUserDefaults.StandardUserDefaults.StringForKey(userPhotoURL); }
			set
			{
				NSUserDefaults.StandardUserDefaults.SetString(value, userPhotoURL);
			}
		}
	}
}