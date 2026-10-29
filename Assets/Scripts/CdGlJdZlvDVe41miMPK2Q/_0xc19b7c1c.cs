using UnityEngine;

/// <summary>
/// Reel strips, paylines and payouts. Plain C#: no UnityEngine.Random (global state),
/// no constructor - build with <c>new ReelMath().Init(seed)</c>.
/// Symbol ids: 0 cherry, 1 lemon, 2 plum, 3 watermelon, 4 grapes, 5 bell, 6 crown,
/// 7 royal seven, 8 clover WILD, 9 coin SCATTER.
/// </summary>
public sealed class _0xc19b7c1c
{
    /// <summary>Offsets that place the scripted welcome win on the centre row.</summary>
    public int[] _0x03db6a7a()
    {
        int[] _0xb70b7ad0 = new int[Reels];
        int[] _0x80d90f3e =
        {
            4,
            4,
            4,
            Wild,
            4
        };
        for (int _0x43d98417 = 0; _0x43d98417 < Reels; _0x43d98417++)
        {
            _0xb70b7ad0[_0x43d98417] = this._0xde4b6fed(_0x43d98417, _0x80d90f3e[_0x43d98417]);
        }

        return _0xb70b7ad0;
    }

    /// <summary>Payout of <paramref name = "count"/> of <paramref name = "symbol"/>, in line stakes.</summary>
    public int _0x0f243b20(int _0x4d0aeb04, int _0x49bcad3c)
    {
        if (_0x49bcad3c < 3)
        {
            return 0;
        }

        if (_0x4d0aeb04 == Wild)
        {
            return _0x49bcad3c >= 5 ? 1900 : 0;
        }

        int _0x4a51198f = _0x49bcad3c - 3;
        switch (_0x4d0aeb04)
        {
            case 0:
            case 1:
            case 2:
                return _0x4a51198f == 0 ? 8 : (_0x4a51198f == 1 ? 24 : 75);
            case 3:
            case 4:
                return _0x4a51198f == 0 ? 15 : (_0x4a51198f == 1 ? 48 : 150);
            case 5:
            case 6:
                return _0x4a51198f == 0 ? 30 : (_0x4a51198f == 1 ? 95 : 300);
            case 7:
                return _0x4a51198f == 0 ? 56 : (_0x4a51198f == 1 ? 190 : 750);
            default:
                return 0;
        }
    }

    private int _0xf19579c5(System.Random _0x7c4d5000, int _0xeb972ba3)
    {
        int _0x079c2c78 = _0x7c4d5000.Next(0, _0xeb972ba3);
        for (int _0x8d7dba40 = 0; _0x8d7dba40 < this._0x2492ee5c.Length; _0x8d7dba40++)
        {
            _0x079c2c78 -= this._0x2492ee5c[_0x8d7dba40];
            if (_0x079c2c78 < 0)
            {
                return _0x8d7dba40;
            }
        }

        return 0;
    }

    /// <summary>
    /// Avalanche-mixes the session seed with the attempt number. A plain
    /// <c>seed + attempt * 7919</c> aliases against the session seed itself
    /// (<c>session * 7919</c>), so neighbouring sessions landed on the very same strips.
    /// The result is masked non-negative: System.Random rejects int.MinValue.
    /// </summary>
    private static int Mix(int _0x3f274192, int _0xd53869e6)
    {
        unchecked
        {
            int _0xcf8b5606 = _0x3f274192 * 486187739;
            _0xcf8b5606 ^= (_0xd53869e6 + 1) * 668265263;
            _0xcf8b5606 ^= _0xcf8b5606 >> 13;
            _0xcf8b5606 *= 1274126177;
            _0xcf8b5606 ^= _0xcf8b5606 >> 16;
            return _0xcf8b5606 & 0x7FFFFFFF;
        }
    }

    private int[][] _0x96ed62f6;
    public const int StripLength = 32;
    private readonly int[] _0x2492ee5c =
    {
        7,
        7,
        7,
        5,
        5,
        4,
        4,
        2,
        2,
        1
    };
    public string _0xa425c351(int _0x0f24f2c4)
    {
        switch (_0x0f24f2c4)
        {
            case 0:
                return _0xbc1b8730._0xb5df5c41(new byte[6] { 151, 156, 145, 134, 134, 141 }, 212);
            case 1:
                return _0xbc1b8730._0xb5df5c41(new byte[5] { 173, 164, 172, 174, 175 }, 225);
            case 2:
                return _0xbc1b8730._0xb5df5c41(new byte[4] { 168, 180, 173, 181 }, 248);
            case 3:
                return _0xbc1b8730._0xb5df5c41(new byte[5] { 78, 70, 79, 76, 77 }, 3);
            case 4:
                return _0xbc1b8730._0xb5df5c41(new byte[6] { 105, 124, 111, 126, 107, 125 }, 46);
            case 5:
                return _0xbc1b8730._0xb5df5c41(new byte[4] { 23, 16, 25, 25 }, 85);
            case 6:
                return _0xbc1b8730._0xb5df5c41(new byte[5] { 254, 239, 242, 234, 243 }, 189);
            case 7:
                return _0xbc1b8730._0xb5df5c41(new byte[5] { 141, 155, 136, 155, 144 }, 222);
            case 8:
                return _0xbc1b8730._0xb5df5c41(new byte[6] { 89, 86, 85, 76, 95, 72 }, 26);
            default:
                return _0xbc1b8730._0xb5df5c41(new byte[4] { 0, 12, 10, 13 }, 67);
        }
    }

    public const int Reels = 5;
    public const int Rows = 3;
    public const int LineCount = 5;
    public int[] _0x385c953f(int _0x5b81e9e5)
    {
        return this._0xe257bc73[Mathf.Clamp(_0x5b81e9e5, 0, LineCount - 1)];
    }

    public _0xa6508d30 _0x5e6d7a5c(int[] _0x5fa30a95, int _0x0aa3241b)
    {
        _0xa6508d30 _0xd464687b = new _0xa6508d30()._0xef2394ec(_0x0aa3241b);
        int _0x8a6ee429 = Mathf.Max(1, _0x0aa3241b / LineCount);
        for (int _0x80a72bbf = 0; _0x80a72bbf < LineCount; _0x80a72bbf++)
        {
            int[] _0xf6df22ba = this._0xe257bc73[_0x80a72bbf];
            int _0x649eea06 = -1;
            for (int _0x294fd516 = 0; _0x294fd516 < Reels; _0x294fd516++)
            {
                int _0x2a4c443c = this._0x852ef24d(_0x294fd516, _0x5fa30a95[_0x294fd516], _0xf6df22ba[_0x294fd516]);
                if (_0x2a4c443c == Scatter)
                {
                    break;
                }

                if (_0x2a4c443c != Wild)
                {
                    _0x649eea06 = _0x2a4c443c;
                    break;
                }

                _0x649eea06 = Wild;
            }

            if (_0x649eea06 < 0)
            {
                continue;
            }

            int _0x21d9422f = 0;
            for (int _0x95124d67 = 0; _0x95124d67 < Reels; _0x95124d67++)
            {
                int _0x9ef206b4 = this._0x852ef24d(_0x95124d67, _0x5fa30a95[_0x95124d67], _0xf6df22ba[_0x95124d67]);
                if (_0x9ef206b4 == _0x649eea06 || (_0x9ef206b4 == Wild && _0x649eea06 != Scatter))
                {
                    _0x21d9422f++;
                }
                else
                {
                    break;
                }
            }

            int _0xf262890c = this._0x0f243b20(_0x649eea06, _0x21d9422f);
            if (_0xf262890c > 0)
            {
                _0xd464687b._0xdcb4c272(_0x80a72bbf, _0x649eea06, _0x21d9422f, _0xf262890c * _0x8a6ee429);
            }
        }

        int _0xb74651c9 = 0;
        int _0x0f03d8be = 0;
        int _0xe6c0fa56 = 0;
        for (int _0xf43b5a09 = 0; _0xf43b5a09 < Reels; _0xf43b5a09++)
        {
            for (int _0xdd164ab2 = 0; _0xdd164ab2 < Rows; _0xdd164ab2++)
            {
                int _0xbfbbf200 = this._0x852ef24d(_0xf43b5a09, _0x5fa30a95[_0xf43b5a09], _0xdd164ab2);
                if (_0xbfbbf200 == Scatter)
                {
                    _0xb74651c9++;
                }
                else if (_0xbfbbf200 == Wild)
                {
                    _0xe6c0fa56++;
                }
                else if (_0xbfbbf200 <= 4)
                {
                    _0x0f03d8be++;
                }
            }
        }

        _0xd464687b._0x6a7167e5(_0xb74651c9, _0x0f03d8be, _0xe6c0fa56);
        if (_0xb74651c9 >= 3)
        {
            _0xd464687b._0x19fa46b3(ScatterPay * _0x0aa3241b);
        }

        return _0xd464687b;
    }

    private int _0xde4b6fed(int _0x11563a5b, int _0xa5c9d09b)
    {
        int[] _0xab0c57b0 = this._0x96ed62f6[_0x11563a5b];
        for (int _0x0363fe33 = 0; _0x0363fe33 < StripLength; _0x0363fe33++)
        {
            if (_0xab0c57b0[(_0x0363fe33 + 1) % StripLength] == _0xa5c9d09b)
            {
                return _0x0363fe33;
            }
        }

        // The symbol is absent from this strip: plant it so the welcome win is honest.
        _0xab0c57b0[1] = _0xa5c9d09b;
        return 0;
    }

    /// <summary>Three or more coins anywhere pay this many TOTAL bets.</summary>
    public const int ScatterPay = 19;
    public const int Scatter = 9;
    /// <summary>
    /// Exact expected payout per unit staked. Reels are independent once the offsets are
    /// uniform, so one enumeration of the ten-symbol product space gives the line term,
    /// and a small convolution gives the scatter term.
    /// </summary>
    private double _0x5806dd7f(float[][] _0xf373574a, int _0xa0870ffa)
    {
        double _0xd4037b3a = 0d;
        int[] _0x075e0aae = new int[Reels];
        for (_0x075e0aae[0] = 0; _0x075e0aae[0] < _0xa0870ffa; _0x075e0aae[0]++)
        {
            if (_0x075e0aae[0] == Scatter)
            {
                continue;
            }

            for (_0x075e0aae[1] = 0; _0x075e0aae[1] < _0xa0870ffa; _0x075e0aae[1]++)
            {
                for (_0x075e0aae[2] = 0; _0x075e0aae[2] < _0xa0870ffa; _0x075e0aae[2]++)
                {
                    for (_0x075e0aae[3] = 0; _0x075e0aae[3] < _0xa0870ffa; _0x075e0aae[3]++)
                    {
                        for (_0x075e0aae[4] = 0; _0x075e0aae[4] < _0xa0870ffa; _0x075e0aae[4]++)
                        {
                            double _0x095d22c0 = 1d;
                            for (int _0xec22c6b0 = 0; _0xec22c6b0 < Reels; _0xec22c6b0++)
                            {
                                _0x095d22c0 *= _0xf373574a[_0xec22c6b0][_0x075e0aae[_0xec22c6b0]];
                            }

                            if (_0x095d22c0 <= 0d)
                            {
                                continue;
                            }

                            int _0x30248d1e = -1;
                            for (int _0xa7c8b04a = 0; _0xa7c8b04a < Reels; _0xa7c8b04a++)
                            {
                                int _0xf5114a25 = _0x075e0aae[_0xa7c8b04a];
                                if (_0xf5114a25 == Scatter)
                                {
                                    break;
                                }

                                if (_0xf5114a25 != Wild)
                                {
                                    _0x30248d1e = _0xf5114a25;
                                    break;
                                }

                                _0x30248d1e = Wild;
                            }

                            if (_0x30248d1e < 0)
                            {
                                continue;
                            }

                            int _0x19f53a83 = 0;
                            for (int _0x5f3a2fdc = 0; _0x5f3a2fdc < Reels; _0x5f3a2fdc++)
                            {
                                int _0x11e5fdd7 = _0x075e0aae[_0x5f3a2fdc];
                                if (_0x11e5fdd7 == _0x30248d1e || _0x11e5fdd7 == Wild)
                                {
                                    _0x19f53a83++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            _0xd4037b3a += _0x095d22c0 * this._0x0f243b20(_0x30248d1e, _0x19f53a83);
                        }
                    }
                }
            }
        }

        double[] _0x22c0f452 =
        {
            1d,
            0d,
            0d,
            0d,
            0d,
            0d,
            0d,
            0d,
            0d,
            0d,
            0d,
            0d,
            0d,
            0d,
            0d,
            0d
        };
        for (int _0x76c8864a = 0; _0x76c8864a < Reels; _0x76c8864a++)
        {
            double _0x92c66329 = _0xf373574a[_0x76c8864a][Scatter];
            double[] _0x0d9e67fe = new double[4];
            for (int _0x42ea71da = 0; _0x42ea71da < 4; _0x42ea71da++)
            {
                double _0x3bc5e0e5 = _0x42ea71da == 0 || _0x42ea71da == 3 ? 1d : 3d;
                _0x0d9e67fe[_0x42ea71da] = _0x3bc5e0e5 * System.Math.Pow(_0x92c66329, _0x42ea71da) * System.Math.Pow(1d - _0x92c66329, 3 - _0x42ea71da);
            }

            double[] _0x7e67b2a8 = new double[_0x22c0f452.Length];
            for (int _0xac9b525a = 0; _0xac9b525a < _0x22c0f452.Length; _0xac9b525a++)
            {
                if (_0x22c0f452[_0xac9b525a] <= 0d)
                {
                    continue;
                }

                for (int _0x08ef33c1 = 0; _0x08ef33c1 < 4 && _0xac9b525a + _0x08ef33c1 < _0x7e67b2a8.Length; _0x08ef33c1++)
                {
                    _0x7e67b2a8[_0xac9b525a + _0x08ef33c1] += _0x22c0f452[_0xac9b525a] * _0x0d9e67fe[_0x08ef33c1];
                }
            }

            _0x22c0f452 = _0x7e67b2a8;
        }

        double _0xdbc5166a = 0d;
        for (int _0xadf3a2bb = 3; _0xadf3a2bb < _0x22c0f452.Length; _0xadf3a2bb++)
        {
            _0xdbc5166a += _0x22c0f452[_0xadf3a2bb];
        }

        // A spin stakes five line stakes; line payouts are already in line stakes and the
        // scatter pays in total bets.
        return ((LineCount * _0xd4037b3a) + (_0xdbc5166a * ScatterPay * LineCount)) / LineCount;
    }

    /// <summary>
    /// Four acceptance conditions: no symbol more than 8 times on a reel, an EXACT
    /// return-to-player inside [0.82, 0.94], a winning spin inside the first six and a
    /// four-of-a-kind inside sixty. The return is computed, not sampled: sixty spins of a
    /// slot are far too noisy to decide a strip set by.
    /// </summary>
    private bool _0xfd13d113(int[][] _0xc05deb0d, System.Random _0x10d9a9c5)
    {
        int _0xf5f12cdc = this._0x2492ee5c.Length;
        float[][] _0x131e31f9 = new float[Reels][];
        for (int _0xf09c0257 = 0; _0xf09c0257 < Reels; _0xf09c0257++)
        {
            int[] _0x726555ff = new int[_0xf5f12cdc];
            for (int _0xc5e2baaa = 0; _0xc5e2baaa < StripLength; _0xc5e2baaa++)
            {
                _0x726555ff[_0xc05deb0d[_0xf09c0257][_0xc5e2baaa]]++;
            }

            _0x131e31f9[_0xf09c0257] = new float[_0xf5f12cdc];
            for (int _0xb2733c59 = 0; _0xb2733c59 < _0xf5f12cdc; _0xb2733c59++)
            {
                if (_0x726555ff[_0xb2733c59] > 8)
                {
                    return false;
                }

                _0x131e31f9[_0xf09c0257][_0xb2733c59] = _0x726555ff[_0xb2733c59] / (float)StripLength;
            }
        }

        double _0xbf3499d7 = this._0x5806dd7f(_0x131e31f9, _0xf5f12cdc);
        if (_0xbf3499d7 < 0.82d || _0xbf3499d7 > 0.94d)
        {
            return false;
        }

        int[][] _0xa13af316 = this._0x96ed62f6;
        this._0x96ed62f6 = _0xc05deb0d;
        const int _0xebb7e67f = 50;
        bool _0xf9b84bd5 = false;
        bool _0x7640b5fe = false;
        int[] _0x00231a41 = new int[Reels];
        for (int _0xbb01b76d = 0; _0xbb01b76d < 60; _0xbb01b76d++)
        {
            for (int _0x1dda70c8 = 0; _0x1dda70c8 < Reels; _0x1dda70c8++)
            {
                _0x00231a41[_0x1dda70c8] = _0x10d9a9c5.Next(0, StripLength);
            }

            _0xa6508d30 _0xe7c28a42 = this._0x5e6d7a5c(_0x00231a41, _0xebb7e67f);
            if (_0xbb01b76d < 6 && _0xe7c28a42._0x0e91fe9d > 0)
            {
                _0xf9b84bd5 = true;
            }

            if (_0xe7c28a42._0xdb2f4461 >= 4)
            {
                _0x7640b5fe = true;
            }
        }

        this._0x96ed62f6 = _0xa13af316;
        {
#if B_LOGS
            {
                Debug.Log($"[reels] seed={this._0xf7bd773c} rtp={_0xbf3499d7:F3} early={_0xf9b84bd5} big={_0x7640b5fe}");
            }
#endif
        }

        return _0xf9b84bd5 && _0x7640b5fe;
    }

    public int _0x852ef24d(int _0x1780893b, int _0x6b05d3a0, int _0xf8d5b513)
    {
        int[] _0x8ef13f0c = this._0x96ed62f6[Mathf.Clamp(_0x1780893b, 0, Reels - 1)];
        int _0xfef8a5dd = ((_0x6b05d3a0 + _0xf8d5b513) % StripLength + StripLength) % StripLength;
        return _0x8ef13f0c[_0xfef8a5dd];
    }

    private readonly int[][] _0xe257bc73 =
    {
        new[]
        {
            0,
            0,
            0,
            0,
            0
        },
        new[]
        {
            1,
            1,
            1,
            1,
            1
        },
        new[]
        {
            2,
            2,
            2,
            2,
            2
        },
        new[]
        {
            0,
            1,
            2,
            1,
            0
        },
        new[]
        {
            2,
            1,
            0,
            1,
            2
        },
    };
    private int[][] _0xea293634(System.Random _0x8e9e2138)
    {
        int _0xe3b59a23 = 0;
        for (int _0xfd0aeb57 = 0; _0xfd0aeb57 < this._0x2492ee5c.Length; _0xfd0aeb57++)
        {
            _0xe3b59a23 += this._0x2492ee5c[_0xfd0aeb57];
        }

        int[][] _0xb36e7a1d = new int[Reels][];
        for (int _0x16d17888 = 0; _0x16d17888 < Reels; _0x16d17888++)
        {
            int[] _0xa806b83c = new int[StripLength];
            int[] _0x193ff206 = new int[this._0x2492ee5c.Length];
            for (int _0x2cb85fae = 0; _0x2cb85fae < StripLength; _0x2cb85fae++)
            {
                int _0xb7ee6b51 = 0;
                for (int _0xf2af595e = 0; _0xf2af595e < 24; _0xf2af595e++)
                {
                    _0xb7ee6b51 = this._0xf19579c5(_0x8e9e2138, _0xe3b59a23);
                    bool _0x93680c89 = _0x2cb85fae > 0 && _0xa806b83c[_0x2cb85fae - 1] == _0xb7ee6b51;
                    if (_0x193ff206[_0xb7ee6b51] < 8 && !_0x93680c89)
                    {
                        break;
                    }
                }

                _0x193ff206[_0xb7ee6b51]++;
                _0xa806b83c[_0x2cb85fae] = _0xb7ee6b51;
            }

            _0xb36e7a1d[_0x16d17888] = _0xa806b83c;
        }

        return _0xb36e7a1d;
    }

    public _0xc19b7c1c _0xf1b18ae5(int _0x9fbdeb26)
    {
        this._0xf7bd773c = _0x9fbdeb26;
        for (int _0x4a1769cc = 0; _0x4a1769cc < 40; _0x4a1769cc++)
        {
            int[][] _0xec92d017 = this._0xea293634(new System.Random(Mix(_0x9fbdeb26, _0x4a1769cc)));
            if (this._0xfd13d113(_0xec92d017, new System.Random(Mix(_0x9fbdeb26, _0x4a1769cc + 97))))
            {
                this._0x96ed62f6 = _0xec92d017;
                return this;
            }
        }

        this._0x96ed62f6 = this._0x0f9298cc;
        return this;
    }

    /// <summary>
    /// Last-resort strips, measured offline against the same four acceptance conditions
    /// (exact return 0.898, a win inside the first six spins, a four-of-a-kind inside
    /// sixty, no symbol more than eight times on a reel). Used only when forty generated
    /// candidates in a row are rejected.
    /// </summary>
    private readonly int[][] _0x0f9298cc =
    {
        new[]
        {
            4,
            0,
            2,
            6,
            8,
            4,
            2,
            0,
            7,
            0,
            7,
            6,
            1,
            2,
            0,
            2,
            3,
            0,
            1,
            0,
            6,
            2,
            3,
            6,
            2,
            0,
            2,
            3,
            4,
            3,
            0,
            5
        },
        new[]
        {
            4,
            5,
            1,
            2,
            0,
            2,
            4,
            2,
            1,
            5,
            6,
            1,
            8,
            1,
            2,
            4,
            8,
            0,
            3,
            2,
            5,
            0,
            1,
            4,
            2,
            6,
            2,
            5,
            2,
            4,
            1,
            3
        },
        new[]
        {
            4,
            3,
            4,
            3,
            4,
            5,
            3,
            0,
            5,
            1,
            3,
            1,
            2,
            5,
            3,
            1,
            7,
            4,
            8,
            0,
            9,
            6,
            2,
            9,
            6,
            2,
            8,
            3,
            5,
            0,
            7,
            8
        },
        new[]
        {
            2,
            0,
            7,
            4,
            1,
            8,
            3,
            7,
            0,
            1,
            2,
            4,
            1,
            0,
            2,
            1,
            3,
            4,
            3,
            4,
            5,
            1,
            5,
            4,
            6,
            4,
            5,
            0,
            1,
            2,
            0,
            1
        },
        new[]
        {
            2,
            1,
            2,
            9,
            3,
            2,
            0,
            4,
            1,
            3,
            0,
            1,
            6,
            0,
            3,
            2,
            7,
            6,
            2,
            4,
            6,
            2,
            1,
            4,
            6,
            0,
            6,
            0,
            2,
            0,
            8,
            0
        },
    };
    public const int Wild = 8;
    private int _0xf7bd773c;
    public int _0x0d7fabf0 => this._0xf7bd773c;
}

internal static class _0xbc1b8730
{
    internal static string _0xb5df5c41(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}