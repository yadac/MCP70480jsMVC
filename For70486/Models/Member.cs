using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace For70486.Models
{
    public class Member
    {
        public int Id { get; set; }
        [DisplayName("氏名")]
        public string Name { get; set; }
        [DisplayName("メールアドレス")]
        public string Email { get; set; }
        [DisplayName("誕生日")]
        public DateTime Birth { get; set; }
        [DisplayName("既婚")]
        public bool Married { get; set; }
        // [DisplayName("備考")]
        // resourceファイルの設定で表示する
        [Display(Name = "Memo", ResourceType = typeof(For70486.Resources.MyResource))]
        public string Memo { get; set; }
    }
}