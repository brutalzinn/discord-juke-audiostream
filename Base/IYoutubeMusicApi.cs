using Base.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public interface IYoutubeMusicApi
    {
        [Get("query/track")]
        Task<TrackModel> GetCurrentTrack();

        [Post("query")]
        Task<CommandModel> ExecuteCommand([Body] CommandModel comando);

        [Get("query/queue")]
        Task<QueueModel> GetQueue();
    }
}
