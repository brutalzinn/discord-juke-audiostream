using Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public interface IYoutubeService
    {
        public Task Play();

        public Task Pause();

        public Task Next();

        public Task Prev();

        public Task PlayUrl(string url);

        public Task PlayerSetQueue(int index);

        public Task<TrackModel> CurrentSong();

        public Task<QueueModel> GetQueueList();
    }
}
