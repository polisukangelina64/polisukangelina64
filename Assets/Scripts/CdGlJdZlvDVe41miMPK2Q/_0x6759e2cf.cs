using System;
using UnityEngine;

/// <summary>
/// Local progress. Keys are instance fields read only from instance methods, so no
/// type initializer can run before them. Coins live in the template wallet so the
/// template MoneyCount containers stay correct.
/// </summary>
public sealed class _0x6759e2cf
{
    public int _0x072875f9(int _0x53ec2efc)
    {
        return Mathf.Clamp(this._0x552c4528(this._0xbd661890, _0x53ec2efc, SymbolCount), 0, 3);
    }

    public int _0xceabc84a
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(this._0x1d3c4a7b, 1), 1, 7);
        }

        set
        {
            PlayerPrefs.SetInt(this._0x1d3c4a7b, Mathf.Clamp(value, 1, 7));
        }
    }

    public void _0x639f091c(int _0xdc347bb7)
    {
        int _0xb9b6edcb = this._0x072875f9(_0xdc347bb7);
        if (_0xb9b6edcb >= 3)
        {
            return;
        }

        this._0x1e4978f9(this._0xbd661890, _0xdc347bb7, SymbolCount, _0xb9b6edcb + 1);
    }

    public const int MissionCount = 3;
    public const int StartingCoins = 5000;
    public void _0xb44bb737(int _0xe4f6409a, int _0x7f4f506f)
    {
        this._0x1e4978f9(this._0xeb65e188, _0xe4f6409a, MissionCount, this._0x20b3c391(_0xe4f6409a) + _0x7f4f506f);
    }

    public int _0xfbdf25e9
    {
        get
        {
            int _0x33cbcc27 = PlayerPrefs.GetInt(this._0x8ceed07e, 50);
            for (int _0xb2909c28 = 0; _0xb2909c28 < this._0xf7a39607.Length; _0xb2909c28++)
            {
                if (this._0xf7a39607[_0xb2909c28] == _0x33cbcc27)
                {
                    return _0x33cbcc27;
                }
            }

            return 50;
        }

        set
        {
            PlayerPrefs.SetInt(this._0x8ceed07e, value);
            PlayerPrefs.Save();
        }
    }

    private readonly string _0xeb65e188 = _0xff0497df._0x01e3ace6(new byte[11] { 202, 206, 242, 192, 196, 222, 222, 196, 194, 195, 222 }, 173);
    public int _0x699c56a8()
    {
        int _0x96aeed51 = 0;
        for (int _0x0045c5b4 = 0; _0x0045c5b4 < SymbolCount; _0x0045c5b4++)
        {
            _0x96aeed51 += this._0x072875f9(_0x0045c5b4);
        }

        return _0x96aeed51;
    }

    private int _0xf9f0d31c;
    private readonly string _0x1d3c4a7b = _0xff0497df._0x01e3ace6(new byte[12] { 128, 132, 184, 131, 134, 142, 139, 158, 184, 131, 134, 158 }, 231);
    public const int MissionReward = 250;
    private readonly string _0xbd661890 = _0xff0497df._0x01e3ace6(new byte[9] { 113, 117, 73, 101, 98, 119, 123, 102, 101 }, 22);
    private void _0x1e4978f9(string _0xd839ef7c, int _0xe6d1e0de, int _0x1cd4aa48, int _0x0061fd47)
    {
        int[] _0x2b3b5d29 = new int[_0x1cd4aa48];
        for (int _0xbc0e97cb = 0; _0xbc0e97cb < _0x1cd4aa48; _0xbc0e97cb++)
        {
            _0x2b3b5d29[_0xbc0e97cb] = this._0x552c4528(_0xd839ef7c, _0xbc0e97cb, _0x1cd4aa48);
        }

        if (_0xe6d1e0de >= 0 && _0xe6d1e0de < _0x1cd4aa48)
        {
            _0x2b3b5d29[_0xe6d1e0de] = _0x0061fd47;
        }

        string[] _0x8124359e = new string[_0x1cd4aa48];
        for (int _0xe4362f78 = 0; _0xe4362f78 < _0x1cd4aa48; _0xe4362f78++)
        {
            _0x8124359e[_0xe4362f78] = _0x2b3b5d29[_0xe4362f78].ToString();
        }

        PlayerPrefs.SetString(_0xd839ef7c, string.Join(_0xff0497df._0x01e3ace6(new byte[1] { 186 }, 150), _0x8124359e));
        PlayerPrefs.Save();
    }

    private int _0x552c4528(string _0xf8254a42, int _0xb1d9ffdd, int _0x25843f44)
    {
        string _0xc46d59d1 = PlayerPrefs.GetString(_0xf8254a42, string.Empty);
        if (string.IsNullOrEmpty(_0xc46d59d1))
        {
            return 0;
        }

        string[] _0x57b79dd6 = _0xc46d59d1.Split(',');
        if (_0xb1d9ffdd < 0 || _0xb1d9ffdd >= _0x57b79dd6.Length || _0xb1d9ffdd >= _0x25843f44)
        {
            return 0;
        }

        int _0xf9f39edf;
        return int.TryParse(_0x57b79dd6[_0xb1d9ffdd], out _0xf9f39edf) ? _0xf9f39edf : 0;
    }

    public int _0x20b3c391(int _0x1731ad01)
    {
        return Mathf.Max(0, this._0x552c4528(this._0xeb65e188, _0x1731ad01, MissionCount));
    }

    private readonly string _0xdbca4b67 = _0xff0497df._0x01e3ace6(new byte[12] { 138, 142, 178, 155, 132, 143, 159, 140, 153, 132, 130, 131 }, 237);
    public const int RoomCount = 4;
    public void _0xce549678()
    {
        long _0x95c245e9 = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        this._0x2c5b3e33 = _0x95c245e9;
        this._0xceabc84a = this._0xceabc84a >= 7 ? 1 : this._0xceabc84a + 1;
        PlayerPrefs.Save();
    }

    private readonly string _0xf7cf13fe = _0xff0497df._0x01e3ace6(new byte[5] { 52, 48, 12, 53, 43 }, 83);
    public bool _0x8b476d41
    {
        get
        {
            return PlayerPrefs.GetInt(this._0xf7cf13fe, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(this._0xf7cf13fe, value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

    private readonly string _0x678c9c68 = _0xff0497df._0x01e3ace6(new byte[10] { 67, 71, 123, 87, 65, 87, 87, 77, 75, 74 }, 36);
    public int _0x4e306765 => this._0xf7a39607.Length;

    public int _0x4fe6a6ff(int _0x6dfc99a8)
    {
        return this._0xf7a39607[Mathf.Clamp(_0x6dfc99a8, 0, this._0xf7a39607.Length - 1)];
    }

    public int _0xcb5f5c39
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(this._0xac792ebc, 1), 1, RoomCount);
        }

        set
        {
            PlayerPrefs.SetInt(this._0xac792ebc, Mathf.Clamp(value, 1, RoomCount));
        }
    }

    public void _0x6921adc4()
    {
        PlayerPrefs.DeleteKey(this._0x8ceed07e);
        PlayerPrefs.DeleteKey(this._0x5fec2d27);
        PlayerPrefs.DeleteKey(this._0x1d3c4a7b);
        PlayerPrefs.DeleteKey(this._0xbd661890);
        PlayerPrefs.DeleteKey(this._0xac792ebc);
        PlayerPrefs.DeleteKey(this._0xeb65e188);
        PlayerPrefs.DeleteKey(this._0xdbca4b67);
        PlayerPrefs.DeleteKey(this._0xf7cf13fe);
        PlayerPrefs.DeleteKey(this._0xe192ec83);
        this._0x0841ba1c = false;
        this._0x2cbba19e();
    }

    public _0x6759e2cf _0x2cbba19e()
    {
        if (this._0x0841ba1c)
        {
            return this;
        }

        this._0x0841ba1c = true;
        if (PlayerPrefs.GetInt(this._0xe192ec83, 0) == 0)
        {
            PlayerPrefs.SetInt(this._0xe192ec83, 1);
            _0x20971818._0x30583839._0xf4c009a3 = StartingCoins;
            PlayerPrefs.SetInt(this._0x8ceed07e, 50);
            PlayerPrefs.SetInt(this._0x1d3c4a7b, 1);
            PlayerPrefs.SetString(this._0x5fec2d27, _0xff0497df._0x01e3ace6(new byte[1] { 32 }, 16));
            PlayerPrefs.SetInt(this._0xac792ebc, 1);
            PlayerPrefs.SetInt(this._0xdbca4b67, 1);
            PlayerPrefs.SetInt(this._0xf7cf13fe, 0);
        }

        this._0xf9f0d31c = PlayerPrefs.GetInt(this._0x678c9c68, 0) + 1;
        PlayerPrefs.SetInt(this._0x678c9c68, this._0xf9f0d31c);
        PlayerPrefs.Save();
        return this;
    }

    public string _0x6d01ec7a(int _0x72353b64)
    {
        switch (_0x72353b64)
        {
            case 0:
                return _0xff0497df._0x01e3ace6(new byte[21] { 160, 173, 162, 168, 204, 221, 222, 204, 170, 190, 185, 165, 184, 204, 191, 181, 161, 174, 163, 160, 191 }, 236);
            case 1:
                return _0xff0497df._0x01e3ace6(new byte[18] { 84, 85, 72, 60, 47, 60, 95, 80, 83, 74, 89, 78, 60, 75, 85, 80, 88, 79 }, 28);
            default:
                return _0xff0497df._0x01e3ace6(new byte[11] { 239, 241, 246, 152, 141, 152, 235, 232, 241, 246, 235 }, 184);
        }
    }

    private bool _0x0841ba1c;
    public int _0x626f4d0c(int _0xac31a924)
    {
        switch (_0xac31a924)
        {
            case 0:
                return 12;
            case 1:
                return 3;
            default:
                return 5;
        }
    }

    public const int RefillCoins = 500;
    private readonly string _0xe192ec83 = _0xff0497df._0x01e3ace6(new byte[9] { 107, 111, 83, 127, 105, 105, 104, 105, 104 }, 12);
    private readonly int[] _0xf7a39607 =
    {
        20,
        50,
        100,
        250,
        500
    };
    public int _0x533c17db => this._0xf9f0d31c;

    private readonly string _0x8ceed07e = _0xff0497df._0x01e3ace6(new byte[6] { 51, 55, 11, 54, 49, 32 }, 84);
    public int _0x0da92f34()
    {
        int _0xd774350f = this._0xfbdf25e9;
        for (int _0x3e14dec7 = 0; _0x3e14dec7 < this._0xf7a39607.Length; _0x3e14dec7++)
        {
            if (this._0xf7a39607[_0x3e14dec7] == _0xd774350f)
            {
                return _0x3e14dec7;
            }
        }

        return 1;
    }

    public const int SymbolCount = 10;
    private readonly string _0x5fec2d27 = _0xff0497df._0x01e3ace6(new byte[11] { 119, 115, 79, 116, 113, 121, 124, 105, 79, 100, 99 }, 16);
    public bool _0x2ba4c30d()
    {
        long _0x631e845a = this._0x2c5b3e33;
        if (_0x631e845a <= 0L)
        {
            return true;
        }

        long _0x89362f4c = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        return _0x89362f4c - _0x631e845a >= 72000L;
    }

    public int _0x7c845983(int _0xbf867c4c)
    {
        switch (Mathf.Clamp(_0xbf867c4c, 1, 7))
        {
            case 1:
                return 250;
            case 2:
                return 350;
            case 3:
                return 500;
            case 4:
                return 650;
            case 5:
                return 800;
            case 6:
                return 1000;
            default:
                return 1500;
        }
    }

    public string _0x8ff2adc8(int _0xee6162a8)
    {
        switch (Mathf.Clamp(_0xee6162a8, 1, RoomCount))
        {
            case 1:
                return _0xff0497df._0x01e3ace6(new byte[19] { 27, 6, 6, 4, 105, 120, 105, 100, 105, 25, 5, 28, 4, 105, 26, 8, 5, 6, 7 }, 73);
            case 2:
                return _0xff0497df._0x01e3ace6(new byte[22] { 63, 34, 34, 32, 77, 95, 77, 64, 77, 44, 32, 47, 40, 63, 77, 61, 44, 63, 33, 34, 56, 63 }, 109);
            case 3:
                return _0xff0497df._0x01e3ace6(new byte[21] { 9, 20, 20, 22, 123, 104, 123, 118, 123, 17, 26, 31, 30, 123, 28, 26, 23, 23, 30, 9, 2 }, 91);
            default:
                return _0xff0497df._0x01e3ace6(new byte[20] { 150, 139, 139, 137, 228, 240, 228, 233, 228, 150, 139, 157, 133, 136, 228, 146, 133, 145, 136, 144 }, 196);
        }
    }

    public long _0x5476a7f6
    {
        get
        {
            return _0x20971818._0x30583839._0xf4c009a3;
        }

        set
        {
            _0x20971818._0x30583839._0xf4c009a3 = Mathf.Max(0, (int)value);
        }
    }

    public bool _0x042ed8f8
    {
        get
        {
            return PlayerPrefs.GetInt(this._0xdbca4b67, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(this._0xdbca4b67, value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

    public long _0x2c5b3e33
    {
        get
        {
            long _0xd7f7608c;
            if (long.TryParse(PlayerPrefs.GetString(this._0x5fec2d27, _0xff0497df._0x01e3ace6(new byte[1] { 237 }, 221)), out _0xd7f7608c))
            {
                return _0xd7f7608c;
            }

            return 0L;
        }

        set
        {
            PlayerPrefs.SetString(this._0x5fec2d27, value.ToString());
        }
    }

    private readonly string _0xac792ebc = _0xff0497df._0x01e3ace6(new byte[8] { 204, 200, 244, 217, 196, 196, 198, 216 }, 171);
}

internal static class _0xff0497df
{
    internal static string _0x01e3ace6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}