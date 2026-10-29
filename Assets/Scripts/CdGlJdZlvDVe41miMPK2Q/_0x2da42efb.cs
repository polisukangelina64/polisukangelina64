using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One reel column: a masked window over a seven-cell strip. The mask is added here at
/// runtime because the template ships no RectMask2D to reference from a generated file.
/// </summary>
public sealed class _0x2da42efb : MonoBehaviour
{
    private RectTransform _0xc92eb263;
    private int _0xae59dfc6;
    private readonly Image[] _0xe1d3f3bc = new Image[Cells];
    private void OnDestroy()
    {
        this._0x32f85d11();
        if (this._0xc92eb263 != null)
        {
            DOTween.Kill(this._0xc92eb263);
        }
    }

    public const int Cells = 7;
    public void _0x37310adb()
    {
        this._0x32f85d11();
        this._0xc92eb263.anchoredPosition = Vector2.zero;
        this._0x7152c28a(0.85f);
        if (this._0x66f1336f != null)
        {
            this._0x66f1336f.color = _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.3f);
        }

        this._0x7b4355d3 = this._0xc92eb263.DOAnchorPosY(-this._0xb300b7b2 * Cells, 0.42f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart).OnStepComplete(() => this._0x93c2b0ce()).SetLink(this.gameObject);
    }

    public void _0x0bdfc8cd(RectTransform _0xaf2a0d1e, _0xc19b7c1c _0x08a0cb98, _0x06bd04c5 _0x6c7d228b, int _0x6adf117c, float _0xcb25ab4e, float _0x77e3c88d, float _0xb02aa752, float _0x00d09b59)
    {
        this._0x316adcc6 = _0x08a0cb98;
        this._0x5aca20b0 = _0x6c7d228b;
        this._0xafe736a8 = _0x6adf117c;
        this._0xb300b7b2 = _0xb02aa752 + _0x00d09b59;
        float _0xb7db3d75 = (_0xc19b7c1c.Rows * _0xb02aa752) + ((_0xc19b7c1c.Rows - 1) * _0x00d09b59);
        this._0x2631a005 = _0xed2439e2.Node(_0xaf2a0d1e, _0xafc6ddd2._0x421a5b55(new byte[10] { 175, 152, 152, 145, 190, 146, 145, 136, 144, 147 }, 253) + _0x6adf117c.ToString(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(_0xcb25ab4e, 0f), new Vector2(_0x77e3c88d, _0xb7db3d75));
        this._0x2631a005.gameObject.AddComponent<RectMask2D>();
        this._0xc92eb263 = _0xed2439e2.Node(this._0x2631a005, _0xafc6ddd2._0x421a5b55(new byte[5] { 103, 64, 70, 93, 68 }, 52), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x77e3c88d, this._0xb300b7b2 * Cells));
        for (int _0x1304dd97 = 0; _0x1304dd97 < Cells; _0x1304dd97++)
        {
            float _0xbaea87bd = (Centre - _0x1304dd97) * this._0xb300b7b2;
            RectTransform _0xf9f37de6 = _0xed2439e2.Node(this._0xc92eb263, _0xafc6ddd2._0x421a5b55(new byte[4] { 150, 176, 185, 185 }, 213) + _0x1304dd97.ToString(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, _0xbaea87bd), new Vector2(_0x77e3c88d, _0xb02aa752));
            this._0xe1d3f3bc[_0x1304dd97] = _0xed2439e2.Plate(_0xf9f37de6, _0xafc6ddd2._0x421a5b55(new byte[9] { 36, 2, 11, 11, 55, 11, 6, 19, 2 }, 103), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.92f), null, false, 1f);
            _0xed2439e2.Plate(_0xf9f37de6, _0xafc6ddd2._0x421a5b55(new byte[9] { 14, 40, 33, 33, 4, 35, 35, 40, 63 }, 77), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.9f), null, false, 1f);
            this._0xb69949e4[_0x1304dd97] = _0xed2439e2.Icon(_0xf9f37de6, _0xafc6ddd2._0x421a5b55(new byte[10] { 107, 77, 68, 68, 123, 81, 69, 74, 71, 68 }, 40), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, Mathf.Min(_0x77e3c88d, _0xb02aa752) - 48f, null, Color.white);
        }

        this._0x66f1336f = _0xed2439e2.Plate(this._0x2631a005, _0xafc6ddd2._0x421a5b55(new byte[6] { 55, 16, 22, 1, 5, 15 }, 100), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0f), null, false, 1f);
    }

    private Tween _0x7b4355d3;
    private _0x06bd04c5 _0x5aca20b0;
    private Action _0x83aced67;
    private readonly Image[] _0xb69949e4 = new Image[Cells];
    private int _0xafe736a8;
    public void Show(int _0xbd2f3747)
    {
        this._0xae59dfc6 = ((_0xbd2f3747 % _0xc19b7c1c.StripLength) + _0xc19b7c1c.StripLength) % _0xc19b7c1c.StripLength;
        this._0xc92eb263.anchoredPosition = Vector2.zero;
        this._0x8fe94fee(this._0xae59dfc6);
    }

    private _0xc19b7c1c _0x316adcc6;
    private void _0xed33bb8f()
    {
        Action _0x90b61df7 = this._0x83aced67;
        this._0x83aced67 = null;
        if (_0x90b61df7 != null)
        {
            _0x90b61df7();
        }
    }

    private void _0x4ec19d70()
    {
        if (this._0x7b4355d3 != null)
        {
            this._0x7b4355d3.Kill(false);
            this._0x7b4355d3 = null;
        }

        this._0x7152c28a(1f);
        if (this._0x66f1336f != null)
        {
            this._0x66f1336f.color = _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0f);
        }

        this._0x8fe94fee(this._0xae59dfc6);
        this._0xc92eb263.anchoredPosition = new Vector2(0f, this._0xb300b7b2);
        this._0xc92eb263.DOAnchorPosY(0f, 0.22f).SetEase(Ease.OutBack).OnComplete(() => this._0xed33bb8f()).SetLink(this.gameObject);
    }

    private RectTransform _0x2631a005;
    /// <summary>Punches the symbol sitting on the given row of the visible window.</summary>
    public void _0xea32e99b(int _0xc085b0eb)
    {
        int _0x6c61a3cd = Centre - 1 + _0xc085b0eb;
        if (_0x6c61a3cd < 0 || _0x6c61a3cd >= Cells || this._0xb69949e4[_0x6c61a3cd] == null)
        {
            return;
        }

        RectTransform _0x0cb82b70 = this._0xb69949e4[_0x6c61a3cd].rectTransform;
        _0x0cb82b70.localScale = Vector3.one;
        _0x0cb82b70.DOPunchScale(new Vector3(0.12f, 0.12f, 0f), 0.35f, 1, 0.5f).SetLink(_0x0cb82b70.gameObject);
    }

    private Tween _0x330ac0d8;
    public void _0x10d985be(int _0x59538e7e, float _0xf43963ed, Action _0xff1bd47d)
    {
        this._0xae59dfc6 = ((_0x59538e7e % _0xc19b7c1c.StripLength) + _0xc19b7c1c.StripLength) % _0xc19b7c1c.StripLength;
        this._0x83aced67 = _0xff1bd47d;
        this._0x330ac0d8 = DOVirtual.DelayedCall(_0xf43963ed, () => this._0x4ec19d70()).SetLink(this.gameObject);
    }

    public int _0x49e5b0a9 => this._0xae59dfc6;

    private Image _0x66f1336f;
    private void _0x7152c28a(float _0x24bfebde)
    {
        for (int _0x91b30218 = 0; _0x91b30218 < Cells; _0x91b30218++)
        {
            if (this._0xb69949e4[_0x91b30218] != null)
            {
                this._0xb69949e4[_0x91b30218].color = new Color(1f, 1f, 1f, _0x24bfebde);
            }
        }
    }

    private float _0xb300b7b2;
    private const int Centre = 3;
    private void _0x32f85d11()
    {
        if (this._0x7b4355d3 != null)
        {
            this._0x7b4355d3.Kill(false);
            this._0x7b4355d3 = null;
        }

        if (this._0x330ac0d8 != null)
        {
            this._0x330ac0d8.Kill(false);
            this._0x330ac0d8 = null;
        }
    }

    private void _0x93c2b0ce()
    {
        this._0xc92eb263.anchoredPosition = Vector2.zero;
        this._0x8fe94fee(this._0xae59dfc6 + (this._0xafe736a8 * 3) + Mathf.RoundToInt(Time.time * 7f));
    }

    private void _0x8fe94fee(int _0xf215ced3)
    {
        for (int _0xca9f2763 = 0; _0xca9f2763 < Cells; _0xca9f2763++)
        {
            int _0x8dbb8b2a = _0xca9f2763 - (Centre - 1);
            int _0x3275cd01 = this._0x316adcc6._0x852ef24d(this._0xafe736a8, _0xf215ced3, _0x8dbb8b2a);
            if (this._0xb69949e4[_0xca9f2763] != null)
            {
                this._0xb69949e4[_0xca9f2763].sprite = this._0x5aca20b0 != null ? this._0x5aca20b0._0xe0c1eb60(_0x3275cd01) : null;
                this._0xb69949e4[_0xca9f2763].preserveAspect = true;
            }

            if (this._0xe1d3f3bc[_0xca9f2763] != null)
            {
                this._0xe1d3f3bc[_0xca9f2763].color = _0x3275cd01 == _0xc19b7c1c.Wild ? _0xda5d4a35.Fade(_0xda5d4a35._0x41b9a3a1, 0.55f) : _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.92f);
            }
        }
    }
}

internal static class _0xafc6ddd2
{
    internal static string _0x421a5b55(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}