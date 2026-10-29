using DG.Tweening;
using UnityEngine;

/// <summary>
/// Runs the spin: stake, seeded outcome, staggered stops, payline evaluation and the win
/// presentation. The first spin of a launch is a scripted welcome win so a review album
/// always contains a real result card.
/// </summary>
public sealed class _0x5de4a448 : MonoBehaviour
{
    private _0x6759e2cf _0xb4f39d9c;
    private _0xc67ab774 _0xab75c8ba;
    private bool _0x92c83d77(int _0x31f65670, int _0xc016eba7)
    {
        if (_0xc016eba7 <= 0)
        {
            return false;
        }

        int _0xb3aab0bd = this._0xb4f39d9c._0x626f4d0c(_0x31f65670);
        int _0xffca9641 = this._0xb4f39d9c._0x20b3c391(_0x31f65670);
        if (_0xffca9641 >= _0xb3aab0bd)
        {
            return false;
        }

        this._0xb4f39d9c._0xb44bb737(_0x31f65670, _0xc016eba7);
        if (this._0xb4f39d9c._0x20b3c391(_0x31f65670) < _0xb3aab0bd)
        {
            return false;
        }

        this._0xb4f39d9c._0x5476a7f6 = this._0xb4f39d9c._0x5476a7f6 + _0x6759e2cf.MissionReward;
        if (this._0x802b1da8 != null)
        {
            this._0x802b1da8._0x7d148cfa(this._0xb4f39d9c._0x5476a7f6);
        }

        return true;
    }

    public const float StopBase = 0.90f;
    private void _0x1b6b3c5d(_0xa6508d30 _0x57052a8d)
    {
        bool _0x9cb4cc50 = false;
        _0x9cb4cc50 |= this._0x92c83d77(0, _0x57052a8d._0xcdd7123f);
        _0x9cb4cc50 |= this._0x92c83d77(1, _0x57052a8d._0xb0ce819b);
        _0x9cb4cc50 |= this._0x92c83d77(2, _0x57052a8d._0x0e91fe9d > 0 ? 1 : 0);
        if (_0x9cb4cc50 && this._0x802b1da8 != null)
        {
            this._0x802b1da8._0xc8d35df5();
        }

        if (this._0x802b1da8 != null)
        {
            this._0x802b1da8._0x0afdf0a3(this._0xb4f39d9c);
        }

        if (_0x57052a8d._0x95f91afd)
        {
            this._0xb4f39d9c._0x639f091c(_0xc19b7c1c.Scatter);
        }

        if (this._0xdbbc42cd % StampEverySpins == 0)
        {
            this._0xb4f39d9c._0x639f091c((this._0xdbbc42cd / StampEverySpins) % _0x6759e2cf.SymbolCount);
        }

        if (_0x57052a8d._0xb4d62cb9 >= 0 && _0x57052a8d._0xdb2f4461 >= 4)
        {
            this._0xb4f39d9c._0x639f091c(_0x57052a8d._0xb4d62cb9);
        }
    }

    private void _0x5ad75f2b()
    {
        if (!this._0x3fab1742)
        {
            this._0x3fab1742 = true;
            int[] _0x4dfe7659 = this._0x6c6c3e6d._0x03db6a7a();
            for (int _0xd8a4e2b2 = 0; _0xd8a4e2b2 < _0xc19b7c1c.Reels; _0xd8a4e2b2++)
            {
                this._0x376b1e65[_0xd8a4e2b2] = _0x4dfe7659[_0xd8a4e2b2];
            }

            return;
        }

        int _0xba26dae2 = (this._0xb4f39d9c._0x533c17db * 7919) ^ (this._0xdbbc42cd * 104729);
        System.Random _0x6b8a64ca = new System.Random(_0xba26dae2);
        for (int _0x66e74fd5 = 0; _0x66e74fd5 < _0xc19b7c1c.Reels; _0x66e74fd5++)
        {
            this._0x376b1e65[_0x66e74fd5] = _0x6b8a64ca.Next(0, _0xc19b7c1c.StripLength);
        }

        {
#if B_LOGS
            {
                Debug.Log($"[reels] spin={this._0xdbbc42cd} seed={_0xba26dae2}");
            }
#endif
        }
    }

    private void Update()
    {
        if (this._0x57c2face || this._0xb4f39d9c == null)
        {
            return;
        }

        if (this._0xab75c8ba != null && this._0xab75c8ba._0x4300da7d)
        {
            this._0x9ef314a3 = Time.time;
            return;
        }

        if (Time.time - this._0x9ef314a3 < IdleBackstop)
        {
            return;
        }

        if (this._0xb4f39d9c._0x5476a7f6 < this._0xb4f39d9c._0xfbdf25e9)
        {
            this._0x9ef314a3 = Time.time;
            return;
        }

        this._0x58f3aa17();
    }

    private _0x16323ba0 _0x55896119;
    private void _0xd52649c7(_0xa6508d30 _0x2f7ae65c)
    {
        if (this._0xab75c8ba == null)
        {
            return;
        }

        string _0x0b0f370f = _0x2f7ae65c._0xb4d62cb9 >= 0 ? this._0x6c6c3e6d._0xa425c351(_0x2f7ae65c._0xb4d62cb9) + _0x3f7a8115._0x4404749e(new byte[2] { 93, 5 }, 125) + _0x2f7ae65c._0xdb2f4461.ToString() : _0x3f7a8115._0x4404749e(new byte[16] { 196, 200, 206, 201, 212, 167, 194, 209, 194, 213, 222, 208, 207, 194, 213, 194 }, 135);
        this._0xab75c8ba._0x6d1218f1(_0x2f7ae65c._0x0e91fe9d, _0x0b0f370f, this._0xb4f39d9c._0x5476a7f6);
    }

    private void _0xc520c1ac()
    {
        this._0x4ea6819a++;
        if (this._0x4ea6819a < _0xc19b7c1c.Reels)
        {
            return;
        }

        this._0x57c2face = false;
        this._0x4ea6819a = 0;
        this._0x85547663();
    }

    public void _0x4ccb2d1d(_0xc3ef787a _0x5e951d48, _0x2da42efb[] _0x4f80c50f, _0xc19b7c1c _0x2381fb8b, _0x6759e2cf _0xa652d396, _0x16323ba0 _0xc0d28f30, _0xc67ab774 _0x4f955d69)
    {
        this._0x802b1da8 = _0x5e951d48;
        this._0xded77319 = _0x4f80c50f;
        this._0x6c6c3e6d = _0x2381fb8b;
        this._0xb4f39d9c = _0xa652d396;
        this._0x55896119 = _0xc0d28f30;
        this._0xab75c8ba = _0x4f955d69;
        this._0x9ef314a3 = Time.time;
        System.Random _0x5738f994 = new System.Random(_0x2381fb8b._0x0d7fabf0);
        for (int _0xf7443b3b = 0; _0xf7443b3b < _0xc19b7c1c.Reels; _0xf7443b3b++)
        {
            this._0x376b1e65[_0xf7443b3b] = _0x5738f994.Next(0, _0xc19b7c1c.StripLength);
            this._0xded77319[_0xf7443b3b].Show(this._0x376b1e65[_0xf7443b3b]);
        }
    }

    private _0x2da42efb[] _0xded77319;
    private void _0x85547663()
    {
        _0xa6508d30 _0xb60675c4 = this._0x6c6c3e6d._0x5e6d7a5c(this._0x376b1e65, this._0xb4f39d9c._0xfbdf25e9);
        if (this._0x802b1da8 != null)
        {
            this._0x802b1da8._0x0c7e1272(false);
        }

        for (int _0x6970fd86 = 0; _0x6970fd86 < _0xb60675c4._0xc99c4500; _0x6970fd86++)
        {
            int _0x673327ff = _0xb60675c4._0xc59ca783(_0x6970fd86);
            if (this._0x55896119 != null)
            {
                this._0x55896119._0x0411ec3f(_0x673327ff);
            }

            int[] _0xa6ca81ea = this._0x6c6c3e6d._0x385c953f(_0x673327ff);
            int _0xa4578171 = _0xb60675c4._0x21403627(_0x6970fd86);
            for (int _0x284e3363 = 0; _0x284e3363 < _0xa4578171 && _0x284e3363 < _0xc19b7c1c.Reels; _0x284e3363++)
            {
                this._0xded77319[_0x284e3363]._0xea32e99b(_0xa6ca81ea[_0x284e3363]);
            }
        }

        this._0x1b6b3c5d(_0xb60675c4);
        if (this._0x802b1da8 != null)
        {
            this._0x802b1da8._0xee1aa78e(_0xb60675c4._0x0e91fe9d);
        }

        if (_0xb60675c4._0x0e91fe9d > 0)
        {
            this._0xb4f39d9c._0x5476a7f6 = this._0xb4f39d9c._0x5476a7f6 + _0xb60675c4._0x0e91fe9d;
            if (this._0x802b1da8 != null)
            {
                this._0x802b1da8._0x7d148cfa(this._0xb4f39d9c._0x5476a7f6);
                this._0x802b1da8._0x3dce6d09(_0x3f7a8115._0x4404749e(new byte[4] { 244, 234, 237, 131 }, 163) + _0xed2439e2.Money(_0xb60675c4._0x0e91fe9d), _0xda5d4a35._0x872a7f7e, 72f);
                this._0x802b1da8._0x203085ad();
            }
        }
        else if (this._0x802b1da8 != null)
        {
            DOVirtual.DelayedCall(0.8f, () => this._0x93ca4b3e()).SetLink(this.gameObject);
        }

        bool _0x7989cead = _0xb60675c4._0x0e91fe9d >= this._0xb4f39d9c._0xfbdf25e9 * BigWinBets;
        if (this._0xdbbc42cd == 1 || _0x7989cead)
        {
            this._0xd52649c7(_0xb60675c4);
        }
        else if (this._0xb4f39d9c._0x5476a7f6 < this._0xb4f39d9c._0xfbdf25e9)
        {
            this._0x5a7499c9();
        }

        this._0xfce5180e();
    }

    public void _0x58f3aa17()
    {
        this._0xfce5180e();
        if (this._0x57c2face || this._0xb4f39d9c == null || this._0x6c6c3e6d == null)
        {
            return;
        }

        if (this._0xab75c8ba != null && this._0xab75c8ba._0x4300da7d)
        {
            return;
        }

        int _0x0f87b92c = this._0xb4f39d9c._0xfbdf25e9;
        if (this._0xb4f39d9c._0x5476a7f6 < _0x0f87b92c)
        {
            this._0x5a7499c9();
            return;
        }

        this._0xb4f39d9c._0x5476a7f6 = this._0xb4f39d9c._0x5476a7f6 - _0x0f87b92c;
        this._0x57c2face = true;
        this._0x4ea6819a = 0;
        this._0xdbbc42cd++;
        if (this._0x55896119 != null)
        {
            this._0x55896119._0xeb5d11c2();
        }

        if (this._0x802b1da8 != null)
        {
            this._0x802b1da8._0x7d148cfa(this._0xb4f39d9c._0x5476a7f6);
            this._0x802b1da8._0x0c7e1272(true);
            this._0x802b1da8._0x3dce6d09(_0x3f7a8115._0x4404749e(new byte[8] { 175, 172, 181, 178, 178, 181, 178, 187 }, 252), _0xda5d4a35._0x87d061a4, 44f);
        }

        this._0x5ad75f2b();
        for (int _0x1846fcbd = 0; _0x1846fcbd < _0xc19b7c1c.Reels; _0x1846fcbd++)
        {
            this._0xded77319[_0x1846fcbd]._0x37310adb();
            this._0xded77319[_0x1846fcbd]._0x10d985be(this._0x376b1e65[_0x1846fcbd], StopBase + (_0x1846fcbd * StopStep), () => this._0xc520c1ac());
        }
    }

    private int _0xdbbc42cd;
    public const int BigWinBets = 10;
    public void _0xa17abe06(int _0xa661ab0e)
    {
        this._0xfce5180e();
        if (this._0x57c2face || this._0xb4f39d9c == null)
        {
            return;
        }

        int _0x14ca4972 = Mathf.Clamp(this._0xb4f39d9c._0x0da92f34() + _0xa661ab0e, 0, this._0xb4f39d9c._0x4e306765 - 1);
        this._0xb4f39d9c._0xfbdf25e9 = this._0xb4f39d9c._0x4fe6a6ff(_0x14ca4972);
        if (this._0x802b1da8 != null)
        {
            this._0x802b1da8._0x34cfb619(this._0xb4f39d9c._0xfbdf25e9);
        }
    }

    private void _0x5a7499c9()
    {
        if (this._0xab75c8ba != null)
        {
            this._0xab75c8ba._0xdf6ad50c(this._0xb4f39d9c._0x5476a7f6);
        }
    }

    public bool _0x3a51f164 => this._0x57c2face;

    private _0xc3ef787a _0x802b1da8;
    private float _0x9ef314a3;
    private bool _0x3fab1742;
    public const float StopStep = 0.28f;
    private void _0x93ca4b3e()
    {
        if (this._0x802b1da8 != null && !this._0x57c2face)
        {
            this._0x802b1da8._0x3dce6d09(_0x3f7a8115._0x4404749e(new byte[26] { 6, 19, 2, 114, 1, 2, 27, 28, 114, 6, 29, 114, 2, 30, 19, 11, 114, 127, 114, 103, 114, 30, 27, 28, 23, 1 }, 82), _0xda5d4a35._0x87d061a4, 44f);
        }
    }

    public void _0xfce5180e()
    {
        this._0x9ef314a3 = Time.time;
    }

    public const int StampEverySpins = 10;
    private readonly int[] _0x376b1e65 = new int[_0xc19b7c1c.Reels];
    public const float IdleBackstop = 12f;
    private _0xc19b7c1c _0x6c6c3e6d;
    private int _0x4ea6819a;
    private bool _0x57c2face;
}

internal static class _0x3f7a8115
{
    internal static string _0x4404749e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}