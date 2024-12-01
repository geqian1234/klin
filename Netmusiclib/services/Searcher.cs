using Netmusiclib.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using System.Net.Http.Json;
using System.Net.Http;
using Microsoft.Net.Http.Headers;
using Netmusiclib.Model;
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
        public async Task<ServiceResponse<FilteredSearchResultModel>> Search(string query,int page=1)
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
                ServiceResponse<FilteredSearchResultModel> ret = await GetSearchResult(websearch, params_Websearch);
                return ret;
            }
            else return new ServiceResponse<FilteredSearchResultModel>
            {
                Status = false
            };
            
        }
        public async Task<ServiceResponse<FilteredSearchResultModel>> GetSearchResult(Web_search web_Search, Params_web_search params_Web_Search)
        { 
          var httpclient=_httpClientFactory.CreateClient("bilibili");
          string url=web_Search.url;
            Uri.TryCreate(url, UriKind.Absolute, out var uri);
            if (uri == null)
            {
                throw new ArgumentException("invalid url");
            }
            UriBuilder builder = new(uri);
            builder.Query = nameof(params_Web_Search.keyword) + $"={params_Web_Search.keyword}" +"&"+ nameof(params_Web_Search.page) + $"={params_Web_Search.page}";
            HttpRequestMessage httpRequestMessage = new();
            httpRequestMessage.Method = HttpMethod.Get;
            httpRequestMessage.RequestUri = builder.Uri;
            //httpRequestMessage.Headers.Add("Content-Type", "application/json");
            httpRequestMessage.Headers.Add(
                    HeaderNames.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            httpRequestMessage.Headers.Add(
                HeaderNames.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36 Edg/131.0.0.0");

            httpRequestMessage.Headers.Add(
                HeaderNames.AcceptEncoding, "gzip,deflate,br,zstd"
                );
            httpRequestMessage.Headers.Add(
                HeaderNames.AcceptLanguage, "zh-CN,zh;q=0.9,en;q=0.8,en-GB;q=0.7,en-US;q=0.6"
                );
            httpRequestMessage.Headers.Add(
                HeaderNames.Cookie, "buvid3=45A8AEA0-36A9-884C-BBF6-EAA7A9A6330403971infoc; b_nut=1731770803; _uuid=B1B21324-ED66-1B2B-72B2-4251D98AFB4F02723infoc; enable_web_push=DISABLE; home_feed_column=4; buvid4=83C0702D-E5FC-8F65-B713-0E7F77683E9804687-024111615-qFP4vKTmLGCVG%2B4qxLe4MA%3D%3D; buvid_fp=914f30653e6206006d31291862467396; CURRENT_FNVAL=4048; rpdid=|(Jlk)ul~lJ~0J'u~Ju~~|)kk; DedeUserID=301929788; DedeUserID__ckMd5=3613acb65c18776f; header_theme_version=CLOSE; bili_ticket=eyJhbGciOiJIUzI1NiIsImtpZCI6InMwMyIsInR5cCI6IkpXVCJ9.eyJleHAiOjE3MzMwNjQ0NzQsImlhdCI6MTczMjgwNTIxNCwicGx0IjotMX0.OVkXs9_etVMAOermuB9qe-WLJ89LgVZW3UVpAzggndc; bili_ticket_expires=1733064414; SESSDATA=6bfa067d%2C1748357298%2C45cd5%2Ab2CjDMuOF9zzM-Yglb7PV0o3aoYIdABMtlYIUjXMWDSuEMtL4CHYMT7X6naTuxWpy_kLUSVlhESWEwY1huSDZyM0FFRjJKdkNVcl9jMmk1cm9RNi1ZckVhdVU1eXhYYjJlY19zOGZUOEpoVTZYaEF6bFpwVzRqRGhpNWRiVllMYjJGX1QtZDlCSXZRIIEC; bili_jct=7a207d52b9e7c3e5ea98184feb64c71e; bsource=search_bing; match_float_version=ENABLE; sid=fdy5k5e4; browser_resolution=717-602; b_lsid=9514523C_19381EC6C60"
                );
            
            HttpResponseMessage httpResponseMessage= await httpclient.SendAsync(httpRequestMessage);
            try
            {
                SearchRet? searchRet = await httpResponseMessage.Content.ReadFromJsonAsync<SearchRet>();
                if (searchRet != null)
                {
                    FilteredSearchResultModel searchRetModel = new FilteredSearchResultModel()
                    {
                        PageInfo = searchRet.data.pageinfo,
                    };
                    foreach (var result in searchRet.data.result)
                    {
                        if (result.data.Count > 0)
                        {
                            Items items = new Items();
                            items.Resulttype = result.result_type;
                            foreach (var data in result.data)
                            {
                                items.ItemDatas.Add(new ItemData
                                {
                                    Aid = data.aid,
                                    Arcrank = data.arcrank,
                                    Type = data.type,
                                    Id = data.id,
                                    Author = data.author,
                                    Mid = data.mid,
                                    Typeid = data.typeid,
                                    Typename=data.typename,
                                    Arcurl=data.arcurl,
                                    Bvid=data.bvid,
                                    Title=data.title,
                                    Description=data.description,
                                    Pic=data.pic,
                                    Play=data.play,
                                    Video_review=data.video_review,
                                    Favorites=data.favorites,
                                    Tag=data.tag,
                                    Review=data.review,
                                    Pubdate=data.pubdate,
                                    Senddate=data.senddate,
                                    Duration=data.duration,
                                    Badgepay=data.badgepay,
                                    Hit_columns=data.hit_columns,
                                    View_type=data.view_type,
                                    Is_pay=data.is_pay,
                                    Is_union_video=data.is_union_video,
                                    Rec_tags=data.rec_tags,
                                    New_rec_tags=data.new_rec_tags,
                                    Rank_score=data.rank_score,
                                    Like=data.like,
                                    Upic=data.upic,
                                    Corner=data.corner,
                                    Cover=data.cover,
                                    Desc=data.desc,
                                    Url=data.url,
                                    Rec_reason=data.rec_reason,
                                    Danmaku=data.danmaku,
                                    Biz_data=data.biz_data,
                                    Is_charge_video=data.is_charge_video,
                                    Vt=data.vt,
                                    Enable_vt=data.enable_vt,
                                    Vt_display=data.vt_display,
                                    Subtitle=data.subtitle,
                                    Episode_count_text=data.episode_count_text,
                                    Release_status=data.release_status,
                                    Is_intervene=data.is_intervene,
                                    Area=data.area,
                                    Style=data.style,
                                    Cate_name=data.cate_name,
                                    Is_live_room_inline=data.is_live_room_inline,
                                    Live_status=data.live_status,
                                    Live_time=data.live_time,
                                    Online=data.online,
                                    Rank_index=data.rank_index,
                                    Rank_offset=data.rank_offset,
                                    Roomid=data.roomid,
                                    Short_id=data.short_id,
                                    Spread_id=data.spread_id,
                                    Tags=data.tags,
                                    Uface=data.uface,
                                    Uid=data.uid,
                                    Uname=data.uname  ,
                                    User_cover=data.user_cover,
                                    Parent_area_id=data.parent_area_id,
                                    Parent_area_name=data.parent_area_name,
                                    Watched_show=data.watched_show,
                                });                                 
                            }
                            searchRetModel.Items.Add(items);
                        }
                    
                    }
                    return new ServiceResponse<FilteredSearchResultModel>()
                    {
                        Value = searchRetModel,
                        Status = true,
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return new ServiceResponse<FilteredSearchResultModel>() { 
               Status = false,
            };
        }

        public Task<ServiceResponse<string>> Search(string query)
        {
            throw new NotImplementedException();
        }
    }
}
