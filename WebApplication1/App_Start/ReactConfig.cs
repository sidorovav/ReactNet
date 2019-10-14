using React;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.ChakraCore;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebApplication1.ReactConfig), "Configure")]

namespace WebApplication1
{
	public static class ReactConfig
	{
		public static void Configure()
		{
            // If you want to use server-side rendering of React components, 
            // add all the necessary JavaScript files here. This includes 
            // your components as well as all of their dependencies.
            // See http://reactjs.net/ for more information. Example:
            ReactSiteConfiguration.Configuration
                .AddScript("~/Content/Hello.jsx");

            // If you use an external build too (for example, Babel, Webpack,
            // Browserify or Gulp), you can improve performance by disabling 
            // ReactJS.NET's version of Babel and loading the pre-transpiled 
            // scripts. Example:
            //ReactSiteConfiguration.Configuration
            //    .SetLoadBabel(false)
            //    .AddScriptWithoutTransform("~/Scripts/bundle.server.js");
            //ReactSiteConfiguration.Configuration
            //    .AddScript("~/Content/Hello.jsx");

            JsEngineSwitcher.Current.DefaultEngineName = ChakraCoreJsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddChakraCore();
        }
	}
}