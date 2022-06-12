using Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Services
{
    public class YoutubeService : IYoutubeService
    {
        private IYoutubeMusicApi youtubeMusicApi { get; set; }

        public YoutubeService()
        {
            youtubeMusicApi = new YoutubeMusicClientHttpHandler().ApiClient();
        }

        public async Task<TrackModel> CurrentSong()
        {
            return await youtubeMusicApi.GetCurrentTrack();
        }

        public async Task<QueueModel> GetQueueList()
        {
            return await youtubeMusicApi.GetQueue();
        }

        public async Task Pause()
        {
            var command = new CommandModel()
            {
                Command = "track-pause"
            };

            await youtubeMusicApi.ExecuteCommand(command);
        }

        public async Task Play()
        {
            var command = new CommandModel()
            {
                Command = "track-play"
            };

            await youtubeMusicApi.ExecuteCommand(command);
        }

        public async Task PlayerSetQueue(int index)
        {
            var command = new CommandModel()
            {
                Command = "player-set-queue",
                Value = index.ToString()
            };

            await youtubeMusicApi.ExecuteCommand(command);
        }

        public async Task PlayUrl(string url)
        {
            var command = new CommandModel()
            {
                Command = "play-url",
                Value = url
            };

            await youtubeMusicApi.ExecuteCommand(command);
        }

        public async Task Next()
        {
            var command = new CommandModel()
            {
                Command = "track-next",
            };

            await youtubeMusicApi.ExecuteCommand(command);
        }

        public async Task Prev()
        {
            var command = new CommandModel()
            {
                Command = "track-previous",
            };

            await youtubeMusicApi.ExecuteCommand(command);
        }
    }
}
