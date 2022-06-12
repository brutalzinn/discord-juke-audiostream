using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace TEASLibrary
{
    public static class Message
    {
        public enum MessageEnum
        {
            [Description("Bot não está conectado ao canal de voz.")]
            BotNotConnected,
            [Description("Sem dispositivo de áudio selecionado.")]
            NoAudioDevices,
            [Description("Bot já está conectado ao canal de voz.")]
            BotAlreadyConnected,
            [Description("Você não está em um canal de voz.")]
            UserNotInVoiceChannel,
            [Description("Bot conectado ao **{0}** em '{1}'.")]
            BotConnectedToIn,
            [Description("Bot conectado ao **{0}**.")]
            BotConnectedTo,
            [Description("Capturando e transmitindo do dispositivo **{0}**.")]
            CaptureAndStreming,
            [Description("Já capturando do dispositivo.")]
            AlreadyStreaming,
            [Description("Bot não está transmitindo")]
            BotStoppedStreaming,
            [Description("Bot parou de transmitir")]
            StopStreaming,


            [Description("** Tocando agora **.. \n **{0}** \n Por {1} \n Álbum: {2} \n Url {3}")]
            SongInfo,

            [Description("** Reproduzindo..**\n {0}")]
            Play,

            [Description("** Pulando músicaaa chata **")]
            SkipMusic,
            [Description("** Voltando a música anterior. Parece que aquela música não era tão chata assim.. **")]
            PrevMusic,
            [Description("** Pausando música. **")]
            PauseMusic,

            [Description("Girando a gibimboca da parafuseta")]
            ActionRestared,

        }

        public static string GetDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        public static string GetDescription(this Enum value, params object?[] args)
        {
            var message = value.GetDescription();
            return string.Format(message, args);
        }


    }
}
