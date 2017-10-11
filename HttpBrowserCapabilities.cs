﻿namespace WebMotors.BrowserCaps.AWS.CloudFront
{
	public class HttpBrowserCapabilities : System.Web.Mobile.MobileCapabilities
	{
		public override bool IsMobileDevice
		{
			get
			{
				if ("true".Equals(System.Web.HttpContext.Current.Request.Headers["CloudFront-Is-Mobile-Viewer"]))
					return true;
				return base.IsMobileDevice;
			}
		}
	}
}
