using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The seven-day chest ladder. The main button is never dead: when today's chest is due
/// it collects, otherwise it flips the preview to the next chest, which is a real and
/// repeatable change on screen (C.7).
/// </summary>
public sealed class _0x52b00859 : MonoBehaviour
{
    private void _0x2bb130cb()
    {
        if (this._0xc70749b4 == null)
        {
            return;
        }

        int _0xb66bc8d2 = this._0x8008af53 != null && this._0x8008af53._0x8b476d41 ? 12 : 24;
        for (int _0x474e6c75 = 0; _0x474e6c75 < _0xb66bc8d2; _0x474e6c75++)
        {
            float _0x43586e41 = (_0x474e6c75 / (float)_0xb66bc8d2) * Mathf.PI * 2f;
            Image _0x8b60bf48 = _0xed2439e2.Icon(this._0xc70749b4, _0xa62b1bce._0x24d9284b(new byte[9] { 203, 252, 251, 250, 253, 202, 230, 224, 231 }, 137) + _0x474e6c75.ToString(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, 56f, this._0x777bded7 != null ? this._0x777bded7._0xef40aae3 : null, Color.white);
            RectTransform _0x06ba791a = _0x8b60bf48.rectTransform;
            Vector2 _0xa8f0eacf = new Vector2(Mathf.Cos(_0x43586e41) * 320f, (Mathf.Sin(_0x43586e41) * 260f) + 140f);
            _0x06ba791a.DOAnchorPos(_0xa8f0eacf, 0.9f).SetEase(Ease.OutCubic).SetLink(_0x06ba791a.gameObject);
            _0x8b60bf48.DOFade(0f, 0.9f).SetDelay(_0x474e6c75 * 0.02f).OnComplete(() => this._0xdf7a4dd7(_0x06ba791a)).SetLink(_0x06ba791a.gameObject);
        }
    }

    private void _0xfebf1c7e(int _0xf37c64b3)
    {
        if (_0xf37c64b3 < 0 || _0xf37c64b3 >= Days || this._0x341d0e2f[_0xf37c64b3] == null)
        {
            return;
        }

        RectTransform _0x8f09d8d9 = this._0x341d0e2f[_0xf37c64b3];
        _0x8f09d8d9.localScale = Vector3.one;
        _0x8f09d8d9.DOPunchScale(new Vector3(0.09f, 0.09f, 0f), 0.4f, 1, 0.5f).SetLink(_0x8f09d8d9.gameObject);
    }

    private RectTransform _0xc70749b4;
    private void _0x9f573076(RectTransform _0x53990491, int _0x9d2af757, float _0xccca5ff4, float _0xedf5ee3b)
    {
        int _0x9fab1270 = _0x9d2af757 + 1;
        RectTransform _0x7bbb1d8c = _0xed2439e2.Node(_0x53990491, _0xa62b1bce._0x24d9284b(new byte[9] { 23, 60, 49, 39, 32, 23, 53, 38, 48 }, 84) + _0x9fab1270.ToString(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(_0xccca5ff4, _0xedf5ee3b), new Vector2(240f, 300f));
        this._0x93ab47cf[_0x9d2af757] = _0xed2439e2.Plate(_0x7bbb1d8c, _0xa62b1bce._0x24d9284b(new byte[8] { 76, 110, 125, 107, 74, 107, 104, 106 }, 15), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.35f), null, false, 1f);
        _0xed2439e2.Plate(_0x7bbb1d8c, _0xa62b1bce._0x24d9284b(new byte[8] { 95, 125, 110, 120, 94, 115, 120, 101 }, 28), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-6f, -6f), _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), null, false, 1f);
        _0xed2439e2.Label(_0x7bbb1d8c, _0xa62b1bce._0x24d9284b(new byte[7] { 104, 74, 89, 79, 111, 74, 82 }, 43), this._0x777bded7 != null ? this._0x777bded7._0x533877f5 : null, _0xa62b1bce._0x24d9284b(new byte[4] { 70, 67, 91, 34 }, 2) + _0x9fab1270.ToString(), 44f, _0xda5d4a35._0x872a7f7e, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -40f), new Vector2(200f, 48f));
        _0xed2439e2.Icon(_0x7bbb1d8c, _0xa62b1bce._0x24d9284b(new byte[8] { 43, 9, 26, 12, 43, 7, 1, 6 }, 104), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, 24f), 84f, this._0x777bded7 != null ? this._0x777bded7._0xef40aae3 : null, Color.white);
        this._0x345fa989[_0x9d2af757] = _0xed2439e2.Label(_0x7bbb1d8c, _0xa62b1bce._0x24d9284b(new byte[10] { 149, 183, 164, 178, 132, 179, 161, 183, 164, 178 }, 214), this._0x777bded7 != null ? this._0x777bded7._0x533877f5 : null, _0xa62b1bce._0x24d9284b(new byte[4] { 50, 43, 44, 41 }, 25), 56f, _0xda5d4a35._0x16aaa4b1, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -52f), new Vector2(210f, 58f));
        RectTransform _0x3850d6a0 = _0xed2439e2.Node(_0x7bbb1d8c, _0xa62b1bce._0x24d9284b(new byte[8] { 70, 100, 119, 97, 70, 109, 108, 117 }, 5), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, 36f), new Vector2(200f, 48f));
        _0xed2439e2.Plate(_0x3850d6a0, _0xa62b1bce._0x24d9284b(new byte[9] { 195, 232, 233, 240, 208, 236, 225, 244, 229 }, 128), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.55f), null, false, 1f);
        this._0xbab30acd[_0x9d2af757] = _0xed2439e2.Label(_0x3850d6a0, _0xa62b1bce._0x24d9284b(new byte[8] { 97, 74, 75, 82, 118, 71, 90, 86 }, 34), this._0x777bded7 != null ? this._0x777bded7._0x533877f5 : null, _0xa62b1bce._0x24d9284b(new byte[6] { 3, 0, 12, 4, 10, 11 }, 79), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
        this._0x341d0e2f[_0x9d2af757] = _0x7bbb1d8c;
    }

    private TextMeshProUGUI _0x4aee0ef5;
    private _0x13f6594a _0xe67d46e3;
    private _0x06bd04c5 _0x777bded7;
    private const int Days = 7;
    private void _0xdf5cdde6()
    {
        _0xed2439e2.Press(this._0x1c462cda);
        if (this._0x8008af53 == null)
        {
            return;
        }

        if (this._0x8008af53._0x2ba4c30d())
        {
            int _0x41a973f3 = this._0x8008af53._0xceabc84a;
            int _0xf6c4eee8 = this._0x8008af53._0x7c845983(_0x41a973f3);
            this._0x8008af53._0x5476a7f6 = this._0x8008af53._0x5476a7f6 + _0xf6c4eee8;
            this._0x8008af53._0xce549678();
            this._0x2bb130cb();
            this._0xfebf1c7e(_0x41a973f3 - 1);
            this._0x360d9b09 = this._0x8008af53._0xceabc84a;
        }
        else
        {
            this._0x360d9b09 = this._0x360d9b09 >= Days ? 1 : this._0x360d9b09 + 1;
            this._0xfebf1c7e(this._0x360d9b09 - 1);
        }

        this._0x247e87a3();
        if (this._0xe67d46e3 != null)
        {
            this._0xe67d46e3._0x4037d027();
        }
    }

    private TextMeshProUGUI _0xf7cdb3fb;
    private void OnDestroy()
    {
        if (this._0xc70749b4 != null)
        {
            DOTween.Kill(this._0xc70749b4);
        }
    }

    private void _0xdf7a4dd7(RectTransform _0xcfeab70d)
    {
        if (_0xcfeab70d != null)
        {
            Destroy(_0xcfeab70d.gameObject);
        }
    }

    private _0x6759e2cf _0x8008af53;
    private readonly RectTransform[] _0x341d0e2f = new RectTransform[Days];
    private int _0x360d9b09 = 1;
    private TextMeshProUGUI _0xf252eb90;
    private readonly Image[] _0x93ab47cf = new Image[Days];
    public void _0x8c0d2bf2(RectTransform _0x6b1c8287, RectTransform _0x3d932dad, _0x6759e2cf _0x0b221df3, _0x06bd04c5 _0xb893ac74, _0x13f6594a _0x478f4e0e)
    {
        this._0x8008af53 = _0x0b221df3;
        this._0x777bded7 = _0xb893ac74;
        this._0xe67d46e3 = _0x478f4e0e;
        this._0x360d9b09 = _0x0b221df3 != null ? _0x0b221df3._0xceabc84a : 1;
        _0xed2439e2.Label(_0x6b1c8287, _0xa62b1bce._0x24d9284b(new byte[10] { 85, 126, 115, 101, 98, 66, 127, 98, 122, 115 }, 22), _0xb893ac74 != null ? _0xb893ac74._0x533877f5 : null, _0xa62b1bce._0x24d9284b(new byte[11] { 47, 42, 34, 39, 50, 75, 40, 35, 46, 56, 63 }, 107), 64f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -56f), new Vector2(900f, 72f));
        float[] _0x4d7c8c04 =
        {
            -405f,
            -135f,
            135f,
            405f,
            -270f,
            0f,
            270f
        };
        float[] _0xbc7126a1 =
        {
            180f,
            180f,
            180f,
            180f,
            -170f,
            -170f,
            -170f
        };
        for (int _0x68aa2d70 = 0; _0x68aa2d70 < Days; _0x68aa2d70++)
        {
            this._0x9f573076(_0x6b1c8287, _0x68aa2d70, _0x4d7c8c04[_0x68aa2d70], _0xbc7126a1[_0x68aa2d70]);
        }

        this._0xf252eb90 = _0xed2439e2.Label(_0x6b1c8287, _0xa62b1bce._0x24d9284b(new byte[10] { 129, 166, 160, 183, 179, 185, 158, 187, 188, 183 }, 210), _0xb893ac74 != null ? _0xb893ac74._0x533877f5 : null, _0xa62b1bce._0x24d9284b(new byte[25] { 17, 22, 16, 7, 3, 9, 98, 115, 98, 6, 3, 27, 98, 111, 98, 9, 7, 7, 18, 98, 11, 22, 98, 23, 18 }, 66), 44f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, 70f), new Vector2(1000f, 50f));
        this._0xf7cdb3fb = _0xed2439e2.Label(_0x3d932dad, _0xa62b1bce._0x24d9284b(new byte[12] { 32, 27, 22, 22, 7, 49, 18, 31, 18, 29, 16, 22 }, 115), _0xb893ac74 != null ? _0xb893ac74._0x533877f5 : null, _0xa62b1bce._0x24d9284b(new byte[1] { 52 }, 4), 56f, _0xda5d4a35._0x872a7f7e, TextAlignmentOptions.Left, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(-300f, -210f), new Vector2(520f, 64f));
        _0xed2439e2.Icon(_0x3d932dad, _0xa62b1bce._0x24d9284b(new byte[16] { 57, 2, 15, 15, 30, 40, 11, 6, 11, 4, 9, 15, 41, 5, 3, 4 }, 106), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(-500f, -210f), 60f, _0xb893ac74 != null ? _0xb893ac74._0xef40aae3 : null, Color.white);
        TextMeshProUGUI _0x0d84f43c;
        Image _0x4f8e1e48;
        Button _0x1f17d0c7 = _0xed2439e2.Cta(_0x3d932dad, _0xa62b1bce._0x24d9284b(new byte[8] { 0, 43, 38, 48, 55, 0, 55, 34 }, 67), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, _0x13f6594a.PrimaryCtaY), new Vector2(640f, 160f), null, _0xda5d4a35._0x16aaa4b1, _0xda5d4a35._0x64f656bb, _0xb893ac74 != null ? _0xb893ac74._0x533877f5 : null, _0xa62b1bce._0x24d9284b(new byte[13] { 41, 37, 38, 38, 47, 41, 62, 74, 46, 43, 51, 74, 91 }, 106), 56f, out _0x0d84f43c, out _0x4f8e1e48);
        this._0x4aee0ef5 = _0x0d84f43c;
        this._0x1c462cda = _0x1f17d0c7.transform as RectTransform;
        _0x1f17d0c7.onClick.AddListener(() => this._0xdf5cdde6());
        this._0xc70749b4 = _0xed2439e2.Node(_0x3d932dad, _0xa62b1bce._0x24d9284b(new byte[9] { 64, 108, 106, 109, 65, 118, 113, 112, 119 }, 3), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, _0x13f6594a.PrimaryCtaY), new Vector2(10f, 10f));
        this._0x247e87a3();
    }

    private RectTransform _0x1c462cda;
    private readonly TextMeshProUGUI[] _0x345fa989 = new TextMeshProUGUI[Days];
    public void _0x7035c04f(bool _0x0053d5d0)
    {
        if (this._0x1c462cda != null)
        {
            this._0x1c462cda.gameObject.SetActive(_0x0053d5d0);
        }
    }

    private readonly TextMeshProUGUI[] _0xbab30acd = new TextMeshProUGUI[Days];
    public void _0x247e87a3()
    {
        if (this._0x8008af53 == null)
        {
            return;
        }

        int _0xdc2e69ba = this._0x8008af53._0xceabc84a;
        bool _0xca79b7ae = this._0x8008af53._0x2ba4c30d();
        for (int _0x526a2a45 = 0; _0x526a2a45 < Days; _0x526a2a45++)
        {
            int _0xbbd4289a = _0x526a2a45 + 1;
            bool _0x0a1a7131 = _0xbbd4289a < _0xdc2e69ba;
            bool _0xf40e8df5 = _0xbbd4289a == _0xdc2e69ba;
            string _0x431fa9be = _0x0a1a7131 ? _0xa62b1bce._0x24d9284b(new byte[7] { 70, 73, 68, 76, 72, 64, 65 }, 5) : (_0xf40e8df5 && _0xca79b7ae ? _0xa62b1bce._0x24d9284b(new byte[5] { 240, 235, 224, 229, 253 }, 164) : _0xa62b1bce._0x24d9284b(new byte[6] { 125, 126, 114, 122, 116, 117 }, 49));
            Color _0x17b5511d = _0x0a1a7131 ? _0xda5d4a35._0x048a938e : (_0xf40e8df5 && _0xca79b7ae ? _0xda5d4a35._0x16aaa4b1 : _0xda5d4a35._0x87d061a4);
            if (this._0xbab30acd[_0x526a2a45] != null)
            {
                this._0xbab30acd[_0x526a2a45].text = _0x431fa9be;
                this._0xbab30acd[_0x526a2a45].color = _0x17b5511d;
            }

            if (this._0x345fa989[_0x526a2a45] != null)
            {
                this._0x345fa989[_0x526a2a45].text = _0xa62b1bce._0x24d9284b(new byte[1] { 163 }, 136) + _0xed2439e2.Money(this._0x8008af53._0x7c845983(_0xbbd4289a));
            }

            if (this._0x93ab47cf[_0x526a2a45] != null)
            {
                bool _0xa72af9fe = _0xbbd4289a == this._0x360d9b09 || (_0xf40e8df5 && _0xca79b7ae);
                this._0x93ab47cf[_0x526a2a45].color = _0xa72af9fe ? _0xda5d4a35.Fade(_0xda5d4a35._0x872a7f7e, 0.95f) : _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.35f);
            }
        }

        if (this._0xf252eb90 != null)
        {
            this._0xf252eb90.text = _0xa62b1bce._0x24d9284b(new byte[7] { 192, 199, 193, 214, 210, 216, 179 }, 147) + _0xdc2e69ba.ToString() + (_0xdc2e69ba == 1 ? _0xa62b1bce._0x24d9284b(new byte[4] { 172, 200, 205, 213 }, 140) : _0xa62b1bce._0x24d9284b(new byte[5] { 148, 240, 245, 237, 231 }, 180)) + _0xa62b1bce._0x24d9284b(new byte[13] { 225, 236, 225, 138, 132, 132, 145, 225, 136, 149, 225, 148, 145 }, 193);
        }

        if (this._0x4aee0ef5 != null)
        {
            this._0x4aee0ef5.text = _0xca79b7ae ? _0xa62b1bce._0x24d9284b(new byte[12] { 94, 82, 81, 81, 88, 94, 73, 61, 89, 92, 68, 61 }, 29) + _0xdc2e69ba.ToString() : _0xa62b1bce._0x24d9284b(new byte[12] { 74, 72, 95, 76, 83, 95, 77, 58, 84, 95, 66, 78 }, 26);
        }

        if (this._0xf7cdb3fb != null)
        {
            this._0xf7cdb3fb.text = _0xed2439e2.Money(this._0x8008af53._0x5476a7f6);
        }
    }
}

internal static class _0xa62b1bce
{
    internal static string _0x24d9284b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}