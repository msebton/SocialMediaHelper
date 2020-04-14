using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaHelper.Data
{
    public class YouTubeInputs
    {
        public string part { get; set; }
        public int maxResults { get; set; }
        public string q { get; set; }
        public string order { get; set; }
        //public string order { get; set; }
        public string baseUrl { get; set; }
        public string key { get; set; }
    }
}
