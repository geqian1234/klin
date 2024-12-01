using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netmusiclib.Model
{
    public class Items
    { 
       public string Resulttype { get; set; }=string.Empty;
       public List<ItemData> ItemDatas { get; set; } = new List<ItemData>();
    }
    public class ItemData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }=string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public UInt64 Id { get; set; }=uint.MaxValue;
        /// <summary>
        /// 中江路押尾
        /// </summary>
        public string Author { get; set; }=string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public UInt64 Mid { get; set; } = uint.MinValue;
        /// <summary>
        /// 
        /// </summary>
        public string Typeid { get; set; }=string.Empty;
        /// <summary>
        /// 演奏
        /// </summary>
        public string Typename { get; set; }=string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Arcurl { get; set; }=string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public UInt64 Aid { get; set; } = uint.MinValue;
        /// <summary>
        /// 
        /// </summary>
        public string Bvid { get; set; }=string.Empty;
        /// <summary>
        /// [附谱] “带来最后一首歌， Gui Ji ，谢谢!”  (周杰伦 轨迹 Ryan指弹改编) 为了市场，这次附上了谱子和段子，太卷了！
        /// </summary>
        public string Title { get; set; }=string.Empty;
        /// <summary>
        /// [附谱] “带来最后一首歌， Gui Ji ，谢谢!” ( 周杰伦 轨迹 Ryan指弹改编) 为了市场，这次附上了谱子和段子，太卷了！
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Arcrank { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Pic { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int Play { get; set; }=int.MinValue;
        /// <summary>
        /// 
        /// </summary>
        public int Video_review { get; set; }= int.MinValue;
        /// <summary>
        /// 
        /// </summary>
        public int Favorites { get; set; } = int.MinValue;
        /// <summary>
        /// 全能音乐挑战赛5.0,全能音乐挑战赛,周杰伦,周董,指弹,吉他,改编
        /// </summary>
        public string Tag { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int Review { get; set; } = int.MinValue;
        /// <summary>
        /// 
        /// </summary>
        public int Pubdate { get; set; } = int.MinValue;
        /// <summary>
        /// 
        /// </summary>
        public int Senddate { get; set; } = int.MinValue;
        /// <summary>
        /// 
        /// </summary>
        public string Duration { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public bool Badgepay { get; set; }=false;
        /// <summary>
        /// 
        /// </summary>
        public List<string> Hit_columns { get; set; }=new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public string View_type { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int Is_pay { get; set; } = int.MinValue ;
        /// <summary>
        /// 
        /// </summary>
        public int Is_union_video { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public string Rec_tags { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public List<string> New_rec_tags { get; set; } = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public int Rank_score { get; set; } = default;
        /// <summary>
        /// 
        /// </summary>
        public int Like { get; set; }=default;
        /// <summary>
        /// 
        /// </summary>
        public string Upic { get; set; }=string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Corner { get; set; }=string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Cover { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Desc { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Rec_reason { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int Danmaku { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public string Biz_data { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int Is_charge_video { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Vt { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Enable_vt { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public string Vt_display { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Subtitle { get; set; }=string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Episode_count_text { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int Release_status { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Is_intervene { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Area { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Style { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public string Cate_name { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int Is_live_room_inline { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Live_status { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public string Live_time { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int Online { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Rank_index { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Rank_offset { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Roomid { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Short_id { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public int Spread_id { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public string Tags { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Uface { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int Uid { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public string Uname { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string User_cover { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public int Parent_area_id { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public string Parent_area_name { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Watched_show { get; set; } = string.Empty;
    }
    public class FilteredSearchResultModel
    {
        public FilteredSearchResultModel() {
            Items = new();
            PageInfo = new();
        }

        public List<Items> Items { get; set; }

        public Pageinfo PageInfo { get; set; }

    }
}
