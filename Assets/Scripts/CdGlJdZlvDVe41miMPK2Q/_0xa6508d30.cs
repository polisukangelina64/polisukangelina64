using System.Collections.Generic;

/// <summary>
/// Result of one spin: winning lines, board tallies and the total payout.
/// No constructor (C.59) - build with <c>new SpinOutcome().Init(bet)</c>.
/// </summary>
public sealed class _0xa6508d30
{
    public void _0xdcb4c272(int _0xe891bddc, int _0x19cdd70b, int _0x646af2e6, int payout)
    {
        this._0xb70a68fb.Add(_0xe891bddc);
        this._0x4204aef3.Add(_0x19cdd70b);
        this._0xa6e30720.Add(_0x646af2e6);
        this._0x0e91fe9d += payout;
        if (_0x646af2e6 > this._0xdb2f4461)
        {
            this._0xdb2f4461 = _0x646af2e6;
            this._0xb4d62cb9 = _0x19cdd70b;
        }
    }

    private readonly List<int> _0xa6e30720 = new List<int>();
    public int _0x21403627(int _0x3e26992e)
    {
        return this._0xa6e30720[_0x3e26992e];
    }

    private readonly List<int> _0x4204aef3 = new List<int>();
    public int _0xc99c4500 => this._0xb70a68fb.Count;
    public int _0xcdd7123f { get; private set; }

    public void _0x6a7167e5(int _0x4ed6b293, int _0x417d1f0a, int _0x2cf70247)
    {
        this._0x1c2e8868 = _0x4ed6b293;
        this._0xcdd7123f = _0x417d1f0a;
        this._0xb0ce819b = _0x2cf70247;
    }

    public _0xa6508d30 _0xef2394ec(int _0x89435e41)
    {
        this._0x66e13568 = _0x89435e41;
        this._0x0e91fe9d = 0;
        this._0xdb2f4461 = 0;
        this._0xb4d62cb9 = -1;
        this._0xb70a68fb.Clear();
        this._0x4204aef3.Clear();
        this._0xa6e30720.Clear();
        return this;
    }

    private readonly List<int> _0xb70a68fb = new List<int>();
    public int _0xc59ca783(int _0x64001f1c)
    {
        return this._0xb70a68fb[_0x64001f1c];
    }

    public int _0x66e13568 { get; private set; }
    public int _0xdb2f4461 { get; private set; }

    public void _0x19fa46b3(int payout)
    {
        this._0x0e91fe9d += payout;
        this._0x95f91afd = true;
    }

    public bool _0x95f91afd { get; private set; }
    public int _0x1c2e8868 { get; private set; }

    public int _0x22a32790(int _0x37832fdc)
    {
        return this._0x4204aef3[_0x37832fdc];
    }

    public int _0xb4d62cb9 { get; private set; }
    public int _0x0e91fe9d { get; private set; }
    public int _0xb0ce819b { get; private set; }
}