using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace SimpleBlazorTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
    
    public static class FileUtil
    {
        public static Task SaveAs(string filename, byte[] data)
            => JSRuntime.Current.InvokeAsync<object>("saveAsFile",filename, Convert.ToBase64String(data));
    }
}
