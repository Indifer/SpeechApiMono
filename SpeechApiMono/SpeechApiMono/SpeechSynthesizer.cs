using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeechLib
{
    public static class SpeechSynthesizer
    {
        public const string TTS_ENGINE_TYPE_LOCAL = "local";
        public const string TTS_ENGINE_TYPE_CLOUD = "cloud";
        public const string TTS_ENGINE_TYPE_AUTO = "auto";
        public const string CLOUD_TTS_ROLE_XIAOYAN = "xiaoyan";
        public const string CLOUD_TTS_ROLE_XIAOYU = "xiaoyu";
        public const string CLOUD_TTS_ROLE_CATHERINE = "Catherine";
        public const string CLOUD_TTS_ROLE_HENRY = "henry";
        public const string CLOUD_TTS_ROLE_VIXM = "vixm";
        public const string CLOUD_TTS_ROLE_VIXL = "vixl";
        public const string CLOUD_TTS_ROLE_VIXR = "vixr";
        public const string CLOUD_TTS_ROLE_VIXYUN = "vixyun";
        public const string CLOUD_TTS_ROLE_VIMRJIA = "vimrjia";
        public const string LOCAL_TTS_ROLE_XIAOYAN = "xiaoyan";
        public const string LOCAL_SPEAKERS = "local_speakers";
        public const string LOCAL_TTS_SELECTED_ROLE = "selected_role";
        public const string CLOUD_TTS_AUDIO_FORMAT_L16_8000 = "audio/L16;rate=8000";
        public const string CLOUD_TTS_AUDIO_FORMAT_L16_16000 = "audio/L16;rate=16000";
        public const string KEY_TTS_ENGINE_TYPE = "com.iflytek.speech.EXTRA_TTS_ENGINE_TYPE";
        public const string AUDIO_FORMAT = "audio_format";
        public const string VOICE_NAME = "voice_name";
        public const string SPEED = "speed";
        public const string PITCH = "pitch";
        public const string VOLUME = "volume";
        public const string STREAM_TYPE = "stream_type";
        public const string TEXT = "text";
    }
}
