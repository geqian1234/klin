using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netmusiclib
{
    public class Params_web_search
    {
        /// <summary>
        /// str: 搜索用的关键字
        /// </summary>
        public string keyword { get; set; }=string.Empty;
        /// <summary>
        /// int: 页码
        /// </summary>
        public int page { get; set; } = 1;
    }

    public class Web_search
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }=string.Empty ;
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; }=string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public bool verify { get; set; }=false;
        /// <summary>
        /// 
        /// </summary>
        public Params_web_search? params_web_search { get; set; } = default;
        /// <summary>
        /// 在首页以关键字搜索，只指定关键字，其他参数不指定
        /// </summary>
        public string comment { get; set; } = string.Empty;
    }

    public class Params_web_search_by_type
    {
        /// <summary>
        /// str: 搜索用的关键字
        /// </summary>
        public string keyword { get; set; }=string.Empty;
        /// <summary>
        /// str: 搜索时限定类型：视频(video)、番剧(media_bangumi)、影视(media_ft)、直播(live)、专栏(article)、话题(topic)、用户(bili_user)
        /// </summary>
        public string search_type { get; set; }=string.Empty;
        /// <summary>
        /// int: 页码
        /// </summary>
        public int page { get; set; }=1;
    }

    public class Web_search_by_type
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public bool verify { get; set; }=false;
        /// <summary>
        /// 
        /// </summary>
        public Params_web_search_by_type? params_web_search_by_type { get; set; }=default;
        /// <summary>
        /// 搜索关键字时限定类型,可以指定排序号
        /// </summary>
        public string comment { get; set; }=string.Empty;
    }

    public class Default_search_keyword
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public bool verify { get; set; } = false;
        /// <summary>
        /// 获取默认的搜索内容
        /// </summary>
        public string comment { get; set; } = string.Empty;
    }

    public class Hot_search_keywords
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public bool verify { get; set; } = false;
        /// <summary>
        /// 获取热搜
        /// </summary>
        public string comment { get; set; } = string.Empty;
    }

    public class Params_app_hot_search_keywords
    {
        /// <summary>
        /// int: 热搜数量
        /// </summary>
        public string limit { get; set; } = string.Empty;
    }

    public class App_hot_search_keywords
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public bool verify { get; set; } = false;
        /// <summary>
        /// 
        /// </summary>
        public Params_app_hot_search_keywords? params_app_hot_search_keywords { get; set; } = default;
        /// <summary>
        /// 获取APP接口热搜
        /// </summary>
        public string comment { get; set; } = string.Empty;
    }

    public class Suggest
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public bool verify { get; set; } = false;
        /// <summary>
        /// 获取搜索建议
        /// </summary>
        public string comment { get; set; } = string.Empty;
    }

    public class Params_game
    {
        /// <summary>
        /// str: 搜索用的关键字
        /// </summary>
        public string keyword { get; set; } = string.Empty;
    }

    public class Game
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public Params_game? params_game { get; set; } = default(Params_game?);
        /// <summary>
        /// 
        /// </summary>
        public bool verify { get; set; } = false;
        /// <summary>
        /// 搜索游戏
        /// </summary>
        public string comment { get; set; } = string.Empty;
    }

    public class Data
    {
        /// <summary>
        /// str: 搜索用的关键词
        /// </summary>
        public string key_word { get; set; } = string.Empty;
        /// <summary>
        /// int: 页码
        /// </summary>
        public string page_num { get; set; } = string.Empty;
        /// <summary>
        /// int: 每一页的数据大小
        /// </summary>
        public string page_size { get; set; } = string.Empty;
    }

    public class Manga
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public bool verify { get; set; } = false;
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
        /// <summary>
        /// 搜索漫画
        /// </summary>
        public string comment { get; set; } = string.Empty;
    }

    public class Params_cheese
    {
        /// <summary>
        /// int: 页码
        /// </summary>
        public string page { get; set; } = string.Empty;
        /// <summary>
        /// int: 每一页的数据大小
        /// </summary>
        public string page_size { get; set; } = string.Empty;
        /// <summary>
        /// str: 搜索关键词
        /// </summary>
        public string word { get; set; } = string.Empty;
        /// <summary>
        /// int: 排序方式. 综合 -1；销量最高 1；最新上架 2；售价最低 3
        /// </summary>
        public string sort_type { get; set; } = string.Empty;
    }

    public class Cheese
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public bool verify { get; set; } = false;
        /// <summary>
        /// 
        /// </summary>
        public Params_cheese? params_cheese { get; set; } = default;
        /// <summary>
        /// 搜索课程
        /// </summary>
        public string comment { get; set; } = string.Empty;
    }

    public class Params_channel
    {
        /// <summary>
        /// int: 页码
        /// </summary>
        public string page { get; set; } = string.Empty;
        /// <summary>
        /// int: 每一页的数据大小
        /// </summary>
        public string page_size { get; set; } = string.Empty;
        /// <summary>
        /// str: 搜索关键词
        /// </summary>
        public string keyword { get; set; } = string.Empty;
    }

    public class Channel
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string method { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public bool verify { get; set; } = false;
        /// <summary>
        /// 
        /// </summary>
        public Params_channel? params_channel { get; set; } = default;
        /// <summary>
        /// 搜索频道
        /// </summary>
        public string comment { get; set; } = string.Empty;
    }

    public class Search
    {
        /// <summary>
        /// 
        /// </summary>
        public Web_search web_search { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Web_search_by_type web_search_by_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Default_search_keyword default_search_keyword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Hot_search_keywords hot_search_keywords { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public App_hot_search_keywords app_hot_search_keywords { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Suggest suggest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Game game { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Manga manga { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheese cheese { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Channel channel { get; set; }
    }

    public class API
    {
        /// <summary>
        /// 
        /// </summary>
        public Search search { get; set; }
    }

}
