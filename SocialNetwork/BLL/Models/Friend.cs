using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public int Friend_id { get; set; }
    }
}
