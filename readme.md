# WebMotors BrowserCaps AWS CloudFront
When using Cache in the Cloudfront for HttpGet requests the User-Agent is not sent to the application causing the browser detection to fail to identify if the request came from a Mobile device
```
Usage Code 
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
```
```
configuration file
<system.web>
	<browserCaps userAgentCacheKeyLength="64">
		<result type="WebMotors.BrowserCaps.AWS.CloudFront.HttpBrowserCapabilities, WebMotors.BrowserCaps.AWS.CloudFront" />
	</browserCaps>
</system.web>
```
Translated by GOOGLE translate