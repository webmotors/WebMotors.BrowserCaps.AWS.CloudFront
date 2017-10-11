# WebMotors BrowserCaps AWS CloudFront
## Este componente foi feito para validar se a aplicação está abaixo de um cloudfront com cache de header que não passa o user-agent para fazer cache.
O código apenas herda a classe de detect de mobile e valida se veio o header do cloudfront que detect mobile.
```
Exemplo
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
Mantém o comportamento atual do framework caso não tenha o header se tiver o header e for true retona true
```
web.config
<system.web>
	<browserCaps userAgentCacheKeyLength="64">
		<result type="WebMotors.BrowserCaps.AWS.CloudFront.HttpBrowserCapabilities, WebMotors.BrowserCaps.AWS.CloudFront" />
	</browserCaps>
</system.web>
```