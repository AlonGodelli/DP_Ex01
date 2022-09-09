using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public struct PostParameters
    {
        public ePostType PostType;
        public string Text;
        public string ImgUrl;
        public string LinkUrl;
    }
    public enum ePostType
    {
        Text,
        Image,
        Link
    }
}
