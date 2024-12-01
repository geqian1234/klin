using Netmusiclib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netmusiclib.Model
{
    public class Cost_time
    {
        /// <summary>
        /// 
        /// </summary>
        public string total { get; set; }=string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string fetch_lexicon { get; set; }=string.Empty ;
        /// <summary>
        /// 
        /// </summary>
        public string params_check { get; set; }=string.Empty ;
        /// <summary>
        /// 
        /// </summary>
        public string is_risk_query { get; set; }=string.Empty ;
        /// <summary>
        /// 
        /// </summary>
        public string illegal_handler { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string main_handler { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string as_request_format { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string as_request { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string deserialize_response { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string as_response_format { get; set; }
    }

   

public class Video
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Bangumi
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Special
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Topic
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Upuser
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Tv
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Movie
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Media_bangumi
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Media_ft
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Related_search
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class User
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Activity
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Operation_card
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Pgc
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Live
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Live_all
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Live_master
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Live_user
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Live_room
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Article
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Bili_user
{
    /// <summary>
    /// 
    /// </summary>
    public int total { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pages { get; set; }
}

public class Pageinfo
{
    /// <summary>
    /// 
    /// </summary>
    public Video video { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Bangumi bangumi { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Special special { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Topic topic { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Upuser upuser { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Tv tv { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Movie movie { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Media_bangumi media_bangumi { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Media_ft media_ft { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Related_search related_search { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public User user { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Activity activity { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Operation_card operation_card { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Pgc pgc { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Live live { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Live_all live_all { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Live_master live_master { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Live_user live_user { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Live_room live_room { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Article article { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Bili_user bili_user { get; set; }
}

public class Top_tlist
{
    /// <summary>
    /// 
    /// </summary>
    public int video { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int bangumi { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int special { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int topic { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int upuser { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int tv { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int movie { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int card { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int media_bangumi { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int media_ft { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pgc { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int live { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int user { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int activity { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int operation_card { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int live_master { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int live_user { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int live_room { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int article { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int bili_user { get; set; }
}

public class App_display_option
{
    /// <summary>
    /// 
    /// </summary>
    public int is_search_page_grayed { get; set; }
}

public class ResultItem
{
    /// <summary>
    /// 
    /// </summary>
    public string result_type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<data> data { get; set; }
}

public class Data
{
    /// <summary>
    /// 
    /// </summary>
    public string seid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int page { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pagesize { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numResults { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int numPages { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string suggest_keyword { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string rqt_type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Cost_time cost_time { get; set; }
    /// <summary>
    /// 
    /// </summary>
    //public Exp_list exp_list { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int egg_hit { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Pageinfo pageinfo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Top_tlist top_tlist { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int show_column { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> show_module_list { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public App_display_option app_display_option { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int in_black_key { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int in_white_key { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<ResultItem> result { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int is_search_page_grayed { get; set; }
}

public class SearchRet
{
    /// <summary>
    /// 
    /// </summary>
    public int code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string message { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int ttl { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Data data { get; set; }
}

 public class data
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public uint id { get; set; }
        /// <summary>
        /// 中江路押尾
        /// </summary>
        public string author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int mid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string typeid { get; set; }
        /// <summary>
        /// 演奏
        /// </summary>
        public string typename { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string arcurl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int aid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bvid { get; set; }
        /// <summary>
        /// [附谱] “带来最后一首歌， Gui Ji ，谢谢!”  (周杰伦 轨迹 Ryan指弹改编) 为了市场，这次附上了谱子和段子，太卷了！
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// [附谱] “带来最后一首歌， Gui Ji ，谢谢!” ( 周杰伦 轨迹 Ryan指弹改编) 为了市场，这次附上了谱子和段子，太卷了！
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string arcrank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int play { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int video_review { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int favorites { get; set; }
        /// <summary>
        /// 全能音乐挑战赛5.0,全能音乐挑战赛,周杰伦,周董,指弹,吉他,改编
        /// </summary>
        public string tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int review { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int pubdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int senddate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string duration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool badgepay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> hit_columns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string view_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_pay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_union_video { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rec_tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> new_rec_tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int rank_score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int like { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string upic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string corner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rec_reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int danmaku { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string biz_data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_charge_video { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int vt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int enable_vt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string vt_display { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string subtitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string episode_count_text { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int release_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_intervene { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int style { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cate_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_live_room_inline { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int live_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string live_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int online { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int rank_index { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int rank_offset { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int roomid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int short_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int spread_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string uface { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int uid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string uname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string user_cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int parent_area_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string parent_area_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string watched_show { get; set; }
    }



}
