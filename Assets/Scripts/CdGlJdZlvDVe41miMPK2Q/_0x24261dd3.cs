using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The symbol album: ten tiles, three sets and the decorative rooms they unlock.
/// Sprite gutter and text column never share an x-band (C.25).
/// </summary>
public sealed class _0x24261dd3 : MonoBehaviour
{
    private readonly Image[] _0x71202916 = new Image[_0x6759e2cf.SymbolCount];
    private int _0xb1799503(int _0xd9563881)
    {
        return _0xd9563881 == 0 ? 4 : (_0xd9563881 == 1 ? 7 : 9);
    }

    private const float TextLeft = GutterCentre + (GutterWidth * 0.5f) + 28f;
    public void _0x6833cc74()
    {
        if (this._0x75c99487 == null)
        {
            return;
        }

        for (int _0xdaf16e9a = 0; _0xdaf16e9a < _0x6759e2cf.SymbolCount; _0xdaf16e9a++)
        {
            int _0x4ca52f35 = this._0x75c99487._0x072875f9(_0xdaf16e9a);
            if (this._0xd43c96c2[_0xdaf16e9a] != null)
            {
                this._0xd43c96c2[_0xdaf16e9a].text = _0x4ca52f35.ToString() + _0xafe4888a._0x6c82a445(new byte[2] { 126, 98 }, 81);
                this._0xd43c96c2[_0xdaf16e9a].color = _0x4ca52f35 >= 3 ? _0xda5d4a35._0x048a938e : _0xda5d4a35._0x16aaa4b1;
            }

            if (this._0x71202916[_0xdaf16e9a] != null)
            {
                this._0x71202916[_0xdaf16e9a].color = _0x4ca52f35 >= 3 ? _0xda5d4a35._0x048a938e : _0xda5d4a35.Fade(_0xda5d4a35._0x872a7f7e, 0.22f);
            }

            if (this._0xb04651b4[_0xdaf16e9a] != null)
            {
                this._0xb04651b4[_0xdaf16e9a].color = _0x4ca52f35 >= 3 ? _0xda5d4a35.Fade(_0xda5d4a35._0x048a938e, 0.8f) : _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.4f);
            }
        }

        if (this._0x4fc8f6f4 != null)
        {
            this._0x4fc8f6f4.gameObject.SetActive(this._0x75c99487._0x699c56a8() == 0);
        }

        for (int _0x876b6c20 = 0; _0x876b6c20 < 3; _0x876b6c20++)
        {
            int _0x6b2c42de = 0;
            int _0x5f133810 = 0;
            for (int _0xb4c8e8a1 = this._0xabc00c4f(_0x876b6c20); _0xb4c8e8a1 <= this._0xb1799503(_0x876b6c20); _0xb4c8e8a1++)
            {
                _0x6b2c42de += this._0x75c99487._0x072875f9(_0xb4c8e8a1);
                _0x5f133810 += 3;
            }

            if (this._0xd11ac93d[_0x876b6c20] != null)
            {
                this._0xd11ac93d[_0x876b6c20].text = this._0xf60db356(_0x876b6c20) + _0xafe4888a._0x6c82a445(new byte[1] { 139 }, 129) + _0x6b2c42de.ToString() + _0xafe4888a._0x6c82a445(new byte[1] { 200 }, 231) + _0x5f133810.ToString();
            }

            if (this._0x33a9425d[_0x876b6c20] != null)
            {
                float _0xf75f058b = _0x5f133810 <= 0 ? 0f : _0x6b2c42de / (float)_0x5f133810;
                this._0x33a9425d[_0x876b6c20].rectTransform.anchorMin = new Vector2(0f, 0f);
                this._0x33a9425d[_0x876b6c20].rectTransform.anchorMax = new Vector2(Mathf.Clamp01(_0xf75f058b), 1f);
                this._0x33a9425d[_0x876b6c20].rectTransform.offsetMin = Vector2.zero;
                this._0x33a9425d[_0x876b6c20].rectTransform.offsetMax = Vector2.zero;
            }

            if (_0x6b2c42de >= _0x5f133810 && _0x5f133810 > 0)
            {
                this._0x295446fc(_0x876b6c20);
            }
        }
    }

    private void OnDestroy()
    {
        for (int _0x6af41bfd = 0; _0x6af41bfd < 3; _0x6af41bfd++)
        {
            if (this._0x2776f584[_0x6af41bfd] != null)
            {
                DOTween.Kill(this._0x2776f584[_0x6af41bfd]);
            }
        }
    }

    public void _0xdff5bc19(RectTransform _0x382bad9d, _0x6759e2cf _0x5bb83448, _0x06bd04c5 _0xb7be7e2a, _0x13f6594a _0xbd4a801a)
    {
        this._0x75c99487 = _0x5bb83448;
        this._0x38205e8d = _0xb7be7e2a;
        this._0x6eba213b = _0xbd4a801a;
        this._0x70e74ff8 = new _0xc19b7c1c();
        _0xed2439e2.Label(_0x382bad9d, _0xafe4888a._0x6c82a445(new byte[10] { 209, 252, 242, 229, 253, 196, 249, 228, 252, 245 }, 144), _0xb7be7e2a != null ? _0xb7be7e2a._0x533877f5 : null, _0xafe4888a._0x6c82a445(new byte[12] { 247, 253, 233, 230, 235, 232, 132, 229, 232, 230, 241, 233 }, 164), 64f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -56f), new Vector2(900f, 72f));
        this._0x4fc8f6f4 = _0xed2439e2.Label(_0x382bad9d, _0xafe4888a._0x6c82a445(new byte[10] { 27, 54, 56, 47, 55, 31, 55, 42, 46, 35 }, 90), _0xb7be7e2a != null ? _0xb7be7e2a._0x533877f5 : null, _0xafe4888a._0x6c82a445(new byte[31] { 64, 65, 46, 93, 90, 79, 67, 94, 93, 46, 87, 75, 90, 46, 35, 46, 93, 94, 71, 64, 46, 90, 65, 46, 77, 65, 66, 66, 75, 77, 90 }, 14), 44f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -118f), new Vector2(1000f, 48f));
        for (int _0xe620d2be = 0; _0xe620d2be < _0x6759e2cf.SymbolCount; _0xe620d2be++)
        {
            float _0x4dbfc094 = (_0xe620d2be % 2) == 0 ? -265f : 265f;
            float _0x404dbeb0 = 225f - ((_0xe620d2be / 2) * 142f);
            this._0x0fb3e75d(_0x382bad9d, _0xe620d2be, _0x4dbfc094, _0x404dbeb0);
        }

        string[] _0x02a648fd =
        {
            _0xafe4888a._0x6c82a445(new byte[7] { 15, 18, 3, 8, 1, 18, 4 }, 64),
            _0xafe4888a._0x6c82a445(new byte[5] { 79, 82, 68, 92, 81 }, 29),
            _0xafe4888a._0x6c82a445(new byte[7] { 65, 72, 85, 83, 82, 73, 66 }, 7)
        };
        for (int _0x3b47bd42 = 0; _0x3b47bd42 < 3; _0x3b47bd42++)
        {
            this._0x12cb97e3(_0x382bad9d, _0x3b47bd42, (_0x3b47bd42 - 1) * 356f, _0x02a648fd[_0x3b47bd42]);
        }

        this._0x6833cc74();
    }

    private _0x13f6594a _0x6eba213b;
    private int _0xabc00c4f(int _0x7636a8f0)
    {
        return _0x7636a8f0 == 0 ? 0 : (_0x7636a8f0 == 1 ? 5 : 8);
    }

    private readonly Image[] _0x33a9425d = new Image[3];
    private string _0xf60db356(int _0x17785100)
    {
        return _0x17785100 == 0 ? _0xafe4888a._0x6c82a445(new byte[7] { 118, 107, 122, 113, 120, 107, 125 }, 57) : (_0x17785100 == 1 ? _0xafe4888a._0x6c82a445(new byte[5] { 145, 140, 154, 130, 143 }, 195) : _0xafe4888a._0x6c82a445(new byte[7] { 60, 53, 40, 46, 47, 52, 63 }, 122));
    }

    private _0x6759e2cf _0x75c99487;
    private void _0x0fb3e75d(RectTransform _0xd9a1783f, int _0x45aa56b8, float _0x673392f9, float _0x8b618261)
    {
        RectTransform _0x357b25ac = _0xed2439e2.Node(_0xd9a1783f, _0xafe4888a._0x6c82a445(new byte[9] { 55, 26, 20, 3, 27, 34, 31, 26, 19 }, 118) + _0x45aa56b8.ToString(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(_0x673392f9, _0x8b618261), new Vector2(520f, 130f));
        this._0xb04651b4[_0x45aa56b8] = _0xed2439e2.Plate(_0x357b25ac, _0xafe4888a._0x6c82a445(new byte[8] { 75, 118, 115, 122, 90, 123, 120, 122 }, 31), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.4f), null, false, 1f);
        _0xed2439e2.Plate(_0x357b25ac, _0xafe4888a._0x6c82a445(new byte[8] { 158, 163, 166, 175, 136, 165, 174, 179 }, 202), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-5f, -5f), _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.92f), null, false, 1f);
        _0xed2439e2.Icon(_0x357b25ac, _0xafe4888a._0x6c82a445(new byte[10] { 53, 8, 13, 4, 50, 24, 12, 3, 14, 13 }, 97), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(GutterCentre, 0f), 100f, this._0x38205e8d != null ? this._0x38205e8d._0xe0c1eb60(_0x45aa56b8) : null, Color.white);
        _0xed2439e2.Label(_0x357b25ac, _0xafe4888a._0x6c82a445(new byte[8] { 95, 98, 103, 110, 69, 106, 102, 110 }, 11), this._0x38205e8d != null ? this._0x38205e8d._0x533877f5 : null, this._0x70e74ff8._0xa425c351(_0x45aa56b8), 44f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Left, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(TextLeft + (TextWidth * 0.5f), 0f), new Vector2(TextWidth, 50f));
        this._0x71202916[_0x45aa56b8] = _0xed2439e2.Icon(_0x357b25ac, _0xafe4888a._0x6c82a445(new byte[8] { 21, 40, 45, 36, 12, 32, 51, 42 }, 65), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(150f, 0f), 44f, this._0x38205e8d != null ? this._0x38205e8d._0x763ef5b3 : null, _0xda5d4a35._0x872a7f7e);
        this._0xd43c96c2[_0x45aa56b8] = _0xed2439e2.Label(_0x357b25ac, _0xafe4888a._0x6c82a445(new byte[9] { 129, 188, 185, 176, 150, 186, 160, 187, 161 }, 213), this._0x38205e8d != null ? this._0x38205e8d._0x533877f5 : null, _0xafe4888a._0x6c82a445(new byte[3] { 151, 136, 148 }, 167), 44f, _0xda5d4a35._0x16aaa4b1, TextAlignmentOptions.Right, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(213f, 0f), new Vector2(80f, 50f));
    }

    private readonly TextMeshProUGUI[] _0xd11ac93d = new TextMeshProUGUI[3];
    private void _0x295446fc(int _0x86ac79c9)
    {
        int _0xff9ca3c8 = _0x86ac79c9 + 2;
        if (this._0x75c99487._0xcb5f5c39 >= _0xff9ca3c8)
        {
            return;
        }

        this._0x75c99487._0xcb5f5c39 = _0xff9ca3c8;
        if (this._0x2776f584[_0x86ac79c9] != null)
        {
            RectTransform _0xab777979 = this._0x2776f584[_0x86ac79c9];
            _0xab777979.gameObject.SetActive(true);
            _0xab777979.anchoredPosition = new Vector2(-200f, 0f);
            _0xab777979.DOAnchorPosX(200f, 1.2f).SetEase(Ease.InOutSine).SetLink(_0xab777979.gameObject);
        }

        if (this._0x6eba213b != null)
        {
            this._0x6eba213b._0x4037d027();
        }
    }

    private _0xc19b7c1c _0x70e74ff8;
    private TextMeshProUGUI _0x4fc8f6f4;
    private readonly TextMeshProUGUI[] _0xd43c96c2 = new TextMeshProUGUI[_0x6759e2cf.SymbolCount];
    private void _0x12cb97e3(RectTransform _0xde70ecf5, int _0x4b35bc1b, float _0x920a89fa, string _0x60b0feab)
    {
        RectTransform _0x8cc55fe1 = _0xed2439e2.Node(_0xde70ecf5, _0xafe4888a._0x6c82a445(new byte[6] { 30, 40, 57, 15, 44, 63 }, 77) + _0x4b35bc1b.ToString(), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(_0x920a89fa, 62f), new Vector2(340f, 100f));
        _0xed2439e2.Plate(_0x8cc55fe1, _0xafe4888a._0x6c82a445(new byte[7] { 82, 100, 117, 68, 101, 102, 100 }, 1), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.5f), null, false, 1f);
        _0xed2439e2.Plate(_0x8cc55fe1, _0xafe4888a._0x6c82a445(new byte[7] { 149, 163, 178, 132, 169, 162, 191 }, 198), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-5f, -5f), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.95f), null, false, 1f);
        this._0xd11ac93d[_0x4b35bc1b] = _0xed2439e2.Label(_0x8cc55fe1, _0xafe4888a._0x6c82a445(new byte[7] { 18, 36, 53, 21, 36, 57, 53 }, 65), this._0x38205e8d != null ? this._0x38205e8d._0x533877f5 : null, _0x60b0feab + _0xafe4888a._0x6c82a445(new byte[4] { 133, 191, 160, 191 }, 143), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -34f), new Vector2(300f, 60f));
        RectTransform _0xfc01cdaf = _0xed2439e2.Node(_0x8cc55fe1, _0xafe4888a._0x6c82a445(new byte[8] { 189, 139, 154, 186, 156, 143, 141, 133 }, 238), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, 20f), new Vector2(290f, 14f));
        _0xed2439e2.Plate(_0xfc01cdaf, _0xafe4888a._0x6c82a445(new byte[10] { 111, 73, 90, 88, 80, 107, 87, 90, 79, 94 }, 59), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.6f), null, false, 1f);
        this._0x33a9425d[_0x4b35bc1b] = _0xed2439e2.Plate(_0xfc01cdaf, _0xafe4888a._0x6c82a445(new byte[9] { 169, 143, 156, 158, 150, 187, 148, 145, 145 }, 253), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35._0x872a7f7e, null, false, 1f);
        this._0x2776f584[_0x4b35bc1b] = _0xed2439e2.Plate(_0x8cc55fe1, _0xafe4888a._0x6c82a445(new byte[8] { 250, 204, 221, 250, 222, 204, 204, 217 }, 169), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(-200f, 0f), new Vector2(90f, 100f), _0xda5d4a35.Fade(_0xda5d4a35._0x872a7f7e, 0.4f), null, false, 1f).rectTransform;
        this._0x2776f584[_0x4b35bc1b].gameObject.SetActive(false);
    }

    private readonly RectTransform[] _0x2776f584 = new RectTransform[3];
    private _0x06bd04c5 _0x38205e8d;
    private const float GutterWidth = 140f;
    private readonly Image[] _0xb04651b4 = new Image[_0x6759e2cf.SymbolCount];
    private const float TextWidth = 190f;
    private const float GutterCentre = -185f;
}

internal static class _0xafe4888a
{
    internal static string _0x6c82a445(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}