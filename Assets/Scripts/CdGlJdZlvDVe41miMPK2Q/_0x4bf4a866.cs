using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The three daily objectives on the lobby card. The icon gutter and the text column
/// never share an x-band (C.25).
/// </summary>
public sealed class _0x4bf4a866 : MonoBehaviour
{
    private void OnDestroy()
    {
        if (this._0x374ce928 != null)
        {
            DOTween.Kill(this._0x374ce928);
        }
    }

    private _0x6759e2cf _0x158acc2f;
    private void _0x4e6d1a0c()
    {
        if (this._0x374ce928 != null)
        {
            this._0x374ce928.gameObject.SetActive(false);
        }
    }

    private const float GutterCentre = -458f;
    private RectTransform _0x374ce928;
    private _0x06bd04c5 _0xf8a5154c;
    private const float GutterWidth = 56f;
    public void _0x36fa9a8d(RectTransform _0xbfacd84a, _0x6759e2cf _0x1ba6fe10, _0x06bd04c5 _0x57385387)
    {
        this._0x158acc2f = _0x1ba6fe10;
        this._0xf8a5154c = _0x57385387;
        _0xed2439e2.Label(_0xbfacd84a, _0x0d22dc8d._0x8d9ba09c(new byte[12] { 195, 231, 253, 253, 231, 225, 224, 218, 231, 250, 226, 235 }, 142), _0x57385387 != null ? _0x57385387._0x533877f5 : null, _0x0d22dc8d._0x8d9ba09c(new byte[16] { 16, 11, 0, 5, 29, 99, 23, 100, 9, 13, 23, 23, 13, 11, 10, 23 }, 68), 64f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Left, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(-180f, -56f), new Vector2(660f, 72f));
        _0xed2439e2.Plate(_0xbfacd84a, _0x0d22dc8d._0x8d9ba09c(new byte[9] { 6, 59, 38, 62, 55, 0, 39, 62, 55 }, 82), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -104f), new Vector2(960f, 3f), _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.65f), null, false, 1f);
        for (int _0xb864f19f = 0; _0xb864f19f < _0x6759e2cf.MissionCount; _0xb864f19f++)
        {
            float _0xe9dfaed6 = -148f - (_0xb864f19f * 62f);
            RectTransform _0x1fe88a1f = _0xed2439e2.Node(_0xbfacd84a, _0x0d22dc8d._0x8d9ba09c(new byte[10] { 12, 40, 50, 50, 40, 46, 47, 19, 46, 54 }, 65) + _0xb864f19f.ToString(), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, _0xe9dfaed6), new Vector2(1000f, 56f));
            _0xed2439e2.Plate(_0x1fe88a1f, _0x0d22dc8d._0x8d9ba09c(new byte[8] { 69, 120, 96, 71, 123, 118, 99, 114 }, 23), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.45f), null, false, 1f);
            this._0x00a689f9[_0xb864f19f] = _0xed2439e2.Icon(_0x1fe88a1f, _0x0d22dc8d._0x8d9ba09c(new byte[4] { 255, 211, 192, 217 }, 178), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(GutterCentre, 0f), 44f, _0x57385387 != null ? _0x57385387._0x763ef5b3 : null, _0xda5d4a35._0x872a7f7e);
            _0xed2439e2.Label(_0x1fe88a1f, _0x0d22dc8d._0x8d9ba09c(new byte[11] { 167, 131, 153, 153, 131, 133, 132, 190, 143, 146, 158 }, 234), _0x57385387 != null ? _0x57385387._0x533877f5 : null, _0x1ba6fe10._0x6d01ec7a(_0xb864f19f), 44f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Left, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(TextLeft + (TextWidth * 0.5f), 0f), new Vector2(TextWidth, 50f));
            this._0x2cafeb52[_0xb864f19f] = _0xed2439e2.Label(_0x1fe88a1f, _0x0d22dc8d._0x8d9ba09c(new byte[12] { 27, 63, 37, 37, 63, 57, 56, 21, 57, 35, 56, 34 }, 86), _0x57385387 != null ? _0x57385387._0x533877f5 : null, _0x0d22dc8d._0x8d9ba09c(new byte[3] { 10, 21, 10 }, 58), 44f, _0xda5d4a35._0x16aaa4b1, TextAlignmentOptions.Right, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(390f, 0f), new Vector2(180f, 50f));
        }

        this._0x095e2b94 = _0xed2439e2.Node(_0xbfacd84a, _0x0d22dc8d._0x8d9ba09c(new byte[12] { 136, 172, 182, 182, 172, 170, 171, 128, 168, 181, 177, 188 }, 197), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(960f, 70f));
        _0xed2439e2.Label(this._0x095e2b94, _0x0d22dc8d._0x8d9ba09c(new byte[9] { 151, 191, 162, 166, 171, 134, 183, 170, 166 }, 210), _0x57385387 != null ? _0x57385387._0x533877f5 : null, _0x0d22dc8d._0x8d9ba09c(new byte[38] { 166, 167, 200, 165, 161, 187, 187, 161, 167, 166, 187, 200, 188, 167, 172, 169, 177, 200, 197, 200, 187, 184, 161, 166, 200, 188, 167, 200, 173, 169, 186, 166, 200, 171, 167, 161, 166, 187 }, 232), 44f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
        this._0x095e2b94.gameObject.SetActive(false);
        this._0x374ce928 = _0xed2439e2.Node(_0xbfacd84a, _0x0d22dc8d._0x8d9ba09c(new byte[12] { 51, 23, 13, 13, 23, 17, 16, 42, 17, 31, 13, 10 }, 126), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -350f), new Vector2(620f, 64f));
        _0xed2439e2.Plate(this._0x374ce928, _0x0d22dc8d._0x8d9ba09c(new byte[10] { 154, 161, 175, 189, 186, 158, 162, 175, 186, 171 }, 206), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.9f), null, false, 1f);
        _0xed2439e2.Label(this._0x374ce928, _0x0d22dc8d._0x8d9ba09c(new byte[9] { 177, 138, 132, 150, 145, 177, 128, 157, 145 }, 229), _0x57385387 != null ? _0x57385387._0x533877f5 : null, _0x0d22dc8d._0x8d9ba09c(new byte[21] { 187, 191, 165, 165, 191, 185, 184, 214, 181, 185, 187, 166, 186, 179, 162, 179, 214, 221, 196, 195, 198 }, 246), 44f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
        this._0x374ce928.gameObject.SetActive(false);
        this._0xd8fc0921();
    }

    public void _0x0786c841()
    {
        if (this._0x374ce928 == null)
        {
            return;
        }

        this._0x374ce928.gameObject.SetActive(true);
        this._0x374ce928.localScale = Vector3.one;
        this._0x374ce928.DOPunchScale(new Vector3(0.06f, 0.06f, 0f), 0.45f, 1, 0.5f).SetLink(this._0x374ce928.gameObject);
        DOVirtual.DelayedCall(1.0f, () => this._0x4e6d1a0c()).SetLink(this.gameObject);
    }

    private readonly TextMeshProUGUI[] _0x2cafeb52 = new TextMeshProUGUI[_0x6759e2cf.MissionCount];
    public void _0xd8fc0921()
    {
        if (this._0x158acc2f == null)
        {
            return;
        }

        int _0x0ea0b949 = 0;
        for (int _0xc4209c02 = 0; _0xc4209c02 < _0x6759e2cf.MissionCount; _0xc4209c02++)
        {
            int _0x27000a9a = Mathf.Min(this._0x158acc2f._0x20b3c391(_0xc4209c02), this._0x158acc2f._0x626f4d0c(_0xc4209c02));
            int _0x10f1c69e = this._0x158acc2f._0x626f4d0c(_0xc4209c02);
            if (this._0x2cafeb52[_0xc4209c02] != null)
            {
                this._0x2cafeb52[_0xc4209c02].text = _0x27000a9a.ToString() + _0x0d22dc8d._0x8d9ba09c(new byte[1] { 228 }, 203) + _0x10f1c69e.ToString();
                this._0x2cafeb52[_0xc4209c02].color = _0x27000a9a >= _0x10f1c69e ? _0xda5d4a35._0x048a938e : _0xda5d4a35._0x16aaa4b1;
            }

            if (this._0x00a689f9[_0xc4209c02] != null)
            {
                this._0x00a689f9[_0xc4209c02].color = _0x27000a9a >= _0x10f1c69e ? _0xda5d4a35._0x048a938e : _0xda5d4a35.Fade(_0xda5d4a35._0x872a7f7e, 0.3f);
            }

            _0x0ea0b949++;
        }

        if (this._0x095e2b94 != null)
        {
            this._0x095e2b94.gameObject.SetActive(_0x0ea0b949 == 0);
        }
    }

    private const float TextWidth = 560f;
    private RectTransform _0x095e2b94;
    private const float TextLeft = GutterCentre + (GutterWidth * 0.5f) + 28f;
    private readonly Image[] _0x00a689f9 = new Image[_0x6759e2cf.MissionCount];
}

internal static class _0x0d22dc8d
{
    internal static string _0x8d9ba09c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}