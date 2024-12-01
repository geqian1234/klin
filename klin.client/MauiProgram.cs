using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using MudBlazor.Services;
using Netmusiclib;
using System.Net.Http;

namespace klin.client
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddNetMusiclib();
            builder.Services.AddMudServices();
            builder.Services.AddHttpClient("bilibili", httpClient =>
            {
                //  httpClient.BaseAddress = new Uri("https://api.bilibili.com/");

                // using Microsoft.Net.Http.Headers;

                httpClient.DefaultRequestHeaders.Add(
                    HeaderNames.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
                httpClient.DefaultRequestHeaders.Add(
                    HeaderNames.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36 Edg/131.0.0.0");

                httpClient.DefaultRequestHeaders.Add(
                    HeaderNames.AcceptEncoding, "gzip,deflate,br,zstd"
                    );
                httpClient.DefaultRequestHeaders.Add(
                    HeaderNames.AcceptLanguage, "zh-CN,zh;q=0.9,en;q=0.8,en-GB;q=0.7,en-US;q=0.6"
                    );
            }).ConfigurePrimaryHttpMessageHandler(
                () =>
                {
                    return new HttpClientHandler()
                    {
                        AutomaticDecompression = System.Net.DecompressionMethods.GZip
                    };
                }
                );




            builder.Services.AddLogging();
#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
