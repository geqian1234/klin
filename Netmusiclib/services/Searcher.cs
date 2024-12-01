using Netmusiclib.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using System.Net.Http.Json;
using System.Net.Http;
namespace Netmusiclib.services
{
    public class Searcher : ServiceBase,ISearcher
    {
        private readonly ILogger _logger;

        public IHttpClientFactory _httpClientFactory { get; private set; }

        public Searcher(ILogger<Searcher> logger,IHttpClientFactory httpClientFactory) 
        { 
           _logger = logger;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ServiceResponse<string>> Search(string query,int page=1)
        {
            var api = GetApi();

            if (api != null)
            {
                Web_search websearch = api.search.web_search;
                Params_web_search params_Websearch = new Params_web_search()
                {
                    keyword = query,
                    page = page
                };
                string ret = await GetSearchResult(websearch, params_Websearch);
                return new ServiceResponse<string>
                {
                    Status =true,
                    Value = ret,
                };
            }
            else return new ServiceResponse<string>
            {
                Status = false
            };
            
        }
        public async Task<string> GetSearchResult(Web_search web_Search, Params_web_search params_Web_Search)
        { 
          var httpclient=_httpClientFactory.CreateClient();
          string url=web_Search.url;
            Uri.TryCreate(url, UriKind.Absolute, out var uri);
            if (uri == null)
            {
                throw new ArgumentException("invalid url");
            }
            UriBuilder builder = new(uri);
            builder.Query = nameof(params_Web_Search.keyword) + $"={params_Web_Search.keyword}" + nameof(params_Web_Search.page) + $"=&{params_Web_Search.page}";
            HttpResponseMessage httpResponseMessage= await httpclient.GetAsync(builder.Uri);
            return await httpResponseMessage.Content.ReadAsStringAsync();
        }

        public Task<ServiceResponse<string>> Search(string query)
        {
            throw new NotImplementedException();
        }
    }
}
