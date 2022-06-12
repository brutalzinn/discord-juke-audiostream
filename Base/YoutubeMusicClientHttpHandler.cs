using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class YoutubeMusicClientHttpHandler
    {
        public static IYoutubeMusicApi YoutubeMusic { get; set; }

        public YoutubeMusicClientHttpHandler()
        {
            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = { new StringEnumConverter() }
            };

            YoutubeMusic = new RestClient("http://localhost:9863")
            {
                JsonSerializerSettings = settings
            }.For<IYoutubeMusicApi>();
        }

        public IYoutubeMusicApi ApiClient()
        {
            return YoutubeMusic;
        }
    }
}
