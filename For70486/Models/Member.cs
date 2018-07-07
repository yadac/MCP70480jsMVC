using System;
using System.ComponentModel;

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
        [DisplayName("備考")]
        public string Memo { get; set; }
    }
}