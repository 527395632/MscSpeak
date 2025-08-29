﻿using System;
using System.Runtime.InteropServices;

namespace MscSpeak.Player.Linux
{
    internal class AsoundNative
    {
        [DllImport("libasound")]
        internal static extern IntPtr snd_strerror(int errnum);

        [DllImport("libasound")]
        internal static extern int snd_pcm_open(ref IntPtr pcm, string name, snd_pcm_stream_t stream, int mode);

        [DllImport("libasound")]
        internal static extern int snd_pcm_start(IntPtr pcm);

        [DllImport("libasound")]
        internal static extern int snd_pcm_pause(IntPtr pcm, int enable);

        [DllImport("libasound")]
        internal static extern int snd_pcm_resume(IntPtr pcm);

        [DllImport("libasound")]
        internal static extern int snd_pcm_drain(IntPtr pcm);

        [DllImport("libasound")]
        internal static extern int snd_pcm_drop(IntPtr pcm);

        [DllImport("libasound")]
        internal static extern int snd_pcm_close(IntPtr pcm);

        [DllImport("libasound")]
        internal static extern int snd_pcm_recover(IntPtr pcm, int err, int silent);

        [DllImport("libasound")]
        internal static extern int snd_pcm_writei(IntPtr pcm, IntPtr buffer, ulong size);

        [DllImport("libasound")]
        internal static extern int snd_pcm_readi(IntPtr pcm, IntPtr buffer, ulong size);

        [DllImport("libasound")]
        internal static extern int snd_pcm_set_params(IntPtr pcm, snd_pcm_format_t format, snd_pcm_access_t access, uint channels, uint rate, int soft_resample, uint latency);

        /// <param name="params">snd_pcm_hw_params_t**</param>
        [DllImport("libasound")]
        internal static extern int snd_pcm_hw_params_malloc(ref IntPtr @params);

        [DllImport("libasound")]
        internal static extern int snd_pcm_hw_params_any(IntPtr pcm, IntPtr @params);

        [DllImport("libasound")]
        internal static extern int snd_pcm_hw_params_set_access(IntPtr pcm, IntPtr @params, snd_pcm_access_t access);

        [DllImport("libasound")]
        internal static extern int snd_pcm_hw_params_set_format(IntPtr pcm, IntPtr @params, snd_pcm_format_t val);

        [DllImport("libasound")]
        internal static extern int snd_pcm_hw_params_set_channels(IntPtr pcm, IntPtr @params, uint val);

        [DllImport("libasound")]
        internal unsafe static extern int snd_pcm_hw_params_set_rate_near(IntPtr pcm, IntPtr @params, uint* val, int* dir);

        [DllImport("libasound")]
        internal static extern int snd_pcm_hw_params(IntPtr pcm, IntPtr @params);

        [DllImport("libasound")]
        internal unsafe static extern int snd_pcm_hw_params_get_period_size(IntPtr @params, ulong* frames, int* dir);

        [DllImport("libasound")]
        internal unsafe static extern int snd_pcm_hw_params_set_period_size_near(IntPtr pcm, IntPtr @params, ulong* frames, int* dir);

        [DllImport("libasound")]
        internal static extern int snd_mixer_open(ref IntPtr mixer, int mode);

        [DllImport("libasound")]
        internal static extern int snd_mixer_close(IntPtr mixer);

        [DllImport("libasound")]
        internal static extern int snd_mixer_attach(IntPtr mixer, string name);

        [DllImport("libasound")]
        internal static extern int snd_mixer_load(IntPtr mixer);

        [DllImport("libasound")]
        internal static extern int snd_mixer_selem_register(IntPtr mixer, IntPtr options, IntPtr classp);

        [DllImport("libasound")]
        internal static extern IntPtr snd_mixer_first_elem(IntPtr mixer);

        [DllImport("libasound")]
        internal static extern IntPtr snd_mixer_elem_next(IntPtr elem);

        [DllImport("libasound")]
        internal static extern string snd_mixer_selem_get_name(IntPtr elem);

        [DllImport("libasound")]
        internal static extern void snd_mixer_selem_id_alloca(IntPtr ptr);

        [DllImport("libasound")]
        internal unsafe static extern int snd_mixer_selem_get_playback_volume(IntPtr elem, snd_mixer_selem_channel_id channel, long* value);

        [DllImport("libasound")]
        internal static extern int snd_mixer_selem_set_playback_volume(IntPtr elem, snd_mixer_selem_channel_id channel, long value);

        [DllImport("libasound")]
        internal static extern int snd_mixer_selem_set_playback_volume_all(IntPtr elem, long value);

        [DllImport("libasound")]
        internal static extern int snd_mixer_selem_set_playback_switch_all(IntPtr elem, int value);

        [DllImport("libasound")]
        internal unsafe static extern int snd_mixer_selem_get_playback_volume_range(IntPtr elem, long* min, long* max);

        [DllImport("libasound")]
        internal static extern int snd_mixer_selem_set_playback_volume_range(IntPtr elem, long min, long max);

        [DllImport("libasound")]
        internal unsafe static extern int snd_mixer_selem_get_capture_volume(IntPtr elem, snd_mixer_selem_channel_id channel, long* value);

        [DllImport("libasound")]
        internal static extern int snd_mixer_selem_set_capture_volume(IntPtr elem, snd_mixer_selem_channel_id channel, long value);

        [DllImport("libasound")]
        internal static extern int snd_mixer_selem_set_capture_volume_all(IntPtr elem, long value);

        [DllImport("libasound")]
        internal static extern int snd_mixer_selem_set_capture_switch_all(IntPtr elem, int value);

        [DllImport("libasound")]
        internal unsafe static extern int snd_mixer_selem_get_capture_volume_range(IntPtr elem, long* min, long* max);

        [DllImport("libasound")]
        internal static extern int snd_mixer_selem_set_capture_volume_range(IntPtr elem, long min, long max);
    }

    internal enum snd_pcm_stream_t
    {
        SND_PCM_STREAM_PLAYBACK = 0,
        SND_PCM_STREAM_CAPTURE = 1,
        SND_PCM_STREAM_LAST = SND_PCM_STREAM_CAPTURE,
    }

    internal enum snd_pcm_format_t
    {
        SND_PCM_FORMAT_UNKNOWN = -1,
        SND_PCM_FORMAT_S8 = 0,
        SND_PCM_FORMAT_U8 = 1,
        SND_PCM_FORMAT_S16_LE = 2,
        SND_PCM_FORMAT_S16_BE = 3,
        SND_PCM_FORMAT_U16_LE = 4,
        SND_PCM_FORMAT_U16_BE = 5,
        SND_PCM_FORMAT_S24_LE = 6,
        SND_PCM_FORMAT_S24_BE = 7,
        SND_PCM_FORMAT_U24_LE = 8,
        SND_PCM_FORMAT_U24_BE = 9,
        SND_PCM_FORMAT_S32_LE = 10,
        SND_PCM_FORMAT_S32_BE = 11,
        SND_PCM_FORMAT_U32_LE = 12,
        SND_PCM_FORMAT_U32_BE = 13,
        SND_PCM_FORMAT_FLOAT_LE = 14,
        SND_PCM_FORMAT_FLOAT_BE = 15,
        SND_PCM_FORMAT_FLOAT64_LE = 16,
        SND_PCM_FORMAT_FLOAT64_BE = 17,
        SND_PCM_FORMAT_IEC958_SUBFRAME_LE = 18,
        SND_PCM_FORMAT_IEC958_SUBFRAME_BE = 19,
        SND_PCM_FORMAT_MU_LAW = 20,
        SND_PCM_FORMAT_A_LAW = 21,
        SND_PCM_FORMAT_IMA_ADPCM = 22,
        SND_PCM_FORMAT_MPEG = 23,
        SND_PCM_FORMAT_GSM = 24,
        SND_PCM_FORMAT_SPECIAL = 31,
        SND_PCM_FORMAT_S24_3LE = 32,
        SND_PCM_FORMAT_S24_3BE = 33,
        SND_PCM_FORMAT_U24_3LE = 34,
        SND_PCM_FORMAT_U24_3BE = 35,
        SND_PCM_FORMAT_S20_3LE = 36,
        SND_PCM_FORMAT_S20_3BE = 37,
        SND_PCM_FORMAT_U20_3LE = 38,
        SND_PCM_FORMAT_U20_3BE = 39,
        SND_PCM_FORMAT_S18_3LE = 40,
        SND_PCM_FORMAT_S18_3BE = 41,
        SND_PCM_FORMAT_U18_3LE = 42,
        SND_PCM_FORMAT_U18_3BE = 43,
        SND_PCM_FORMAT_G723_24 = 44,
        SND_PCM_FORMAT_G723_24_1B = 45,
        SND_PCM_FORMAT_G723_40 = 46,
        SND_PCM_FORMAT_G723_40_1B = 47,
        SND_PCM_FORMAT_DSD_U8 = 48,
        SND_PCM_FORMAT_DSD_U16_LE = 49,
        SND_PCM_FORMAT_DSD_U32_LE = 50,
        SND_PCM_FORMAT_DSD_U16_BE = 51,
        SND_PCM_FORMAT_DSD_U32_BE = 52,
        SND_PCM_FORMAT_LAST = SND_PCM_FORMAT_DSD_U32_BE,
    }

    internal enum snd_pcm_access_t
    {
        SND_PCM_ACCESS_MMAP_INTERLEAVED = 0,
        SND_PCM_ACCESS_MMAP_NONINTERLEAVED = 1,
        SND_PCM_ACCESS_MMAP_COMPLEX = 2,
        SND_PCM_ACCESS_RW_INTERLEAVED = 3,
        SND_PCM_ACCESS_RW_NONINTERLEAVED = 4,
        SND_PCM_ACCESS_LAST = SND_PCM_ACCESS_RW_NONINTERLEAVED,
    }

    internal enum snd_mixer_selem_channel_id
    {
        SND_MIXER_SCHN_UNKNOWN = -1,
        SND_MIXER_SCHN_FRONT_LEFT = 0,
        SND_MIXER_SCHN_FRONT_RIGHT = 1,
        SND_MIXER_SCHN_REAR_LEFT = 2,
        SND_MIXER_SCHN_REAR_RIGHT = 3,
        SND_MIXER_SCHN_FRONT_CENTER = 4,
        SND_MIXER_SCHN_WOOFER = 5,
        SND_MIXER_SCHN_SIDE_LEFT = 6,
        SND_MIXER_SCHN_SIDE_RIGHT = 7,
        SND_MIXER_SCHN_REAR_CENTER = 8,
        SND_MIXER_SCHN_LAST = 31,
        SND_MIXER_SCHN_MONO = SND_MIXER_SCHN_FRONT_LEFT
    }
}
