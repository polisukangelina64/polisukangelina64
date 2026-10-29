using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x20971818
{
    public static class _0x9d65fd4d
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0x7abde01f
    {
        private static readonly _0x7abde01f _0xf2210391 = new();
        public static readonly _0x7abde01f[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xf2210391,
            _0xf2210391,
            _0xf2210391,
        };
        private int _0xb84c97ba => 0;
        private int _0xe0de271b => 10;
        private string _0x8952204f => _0x665e4418._0x5b73bcf0(new byte[4] { 144, 184, 179, 168 }, 221);
        private string _0xa68dd35a => _0x665e4418._0x5b73bcf0(new byte[8] { 182, 191, 172, 191, 182, 129, 202, 135 }, 250);

        private int _0x4683fedd
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x665e4418._0x5b73bcf0(new byte[25] { 1, 55, 48, 48, 39, 44, 54, 5, 46, 45, 32, 35, 46, 1, 42, 35, 50, 54, 39, 48, 11, 44, 38, 39, 58 }, 66)))
                    PlayerPrefs.SetInt(_0x665e4418._0x5b73bcf0(new byte[25] { 197, 243, 244, 244, 227, 232, 242, 193, 234, 233, 228, 231, 234, 197, 238, 231, 246, 242, 227, 244, 207, 232, 226, 227, 254 }, 134), 0);
                return PlayerPrefs.GetInt(_0x665e4418._0x5b73bcf0(new byte[25] { 95, 105, 110, 110, 121, 114, 104, 91, 112, 115, 126, 125, 112, 95, 116, 125, 108, 104, 121, 110, 85, 114, 120, 121, 100 }, 28));
            }

            set => PlayerPrefs.SetInt(_0x665e4418._0x5b73bcf0(new byte[25] { 88, 110, 105, 105, 126, 117, 111, 92, 119, 116, 121, 122, 119, 88, 115, 122, 107, 111, 126, 105, 82, 117, 127, 126, 99 }, 27), value);
        }

        public int _0x899e1e81
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x8952204f}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x8952204f}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x8952204f}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x8952204f}CurrentLevelIndex", value);
        }

        public int _0xca10d2a4
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x8952204f}BestScore"))
                    this._0xca10d2a4 = 0;
                return PlayerPrefs.GetInt($"{this._0x8952204f}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x8952204f}BestScore", value);
        }

        public bool _0xefbe9654
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x8952204f}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x8952204f}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x8952204f}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x8952204f}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xb6bbf20c
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x30583839
    {
        public static int _0xf4c009a3
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x665e4418._0x5b73bcf0(new byte[5] { 85, 121, 127, 120, 101 }, 22)))
                    PlayerPrefs.SetInt(_0x665e4418._0x5b73bcf0(new byte[5] { 96, 76, 74, 77, 80 }, 35), 0);
                return PlayerPrefs.GetInt(_0x665e4418._0x5b73bcf0(new byte[5] { 128, 172, 170, 173, 176 }, 195));
            }

            set
            {
                PlayerPrefs.SetInt(_0x665e4418._0x5b73bcf0(new byte[5] { 38, 10, 12, 11, 22 }, 101), value);
                _0x8758f65d.Instance._0xca700ec1();
            }
        }
    }

    public static class _0xde5e3e30
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }
}

internal static class _0x665e4418
{
    internal static string _0x5b73bcf0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}