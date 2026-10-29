using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The three menu surfaces the brief asks for - daily chest, symbol album and settings -
/// as one overlay with three tabs, addressed by our own references rather than by an
/// undocumented template panel index.
/// </summary>
public sealed class _0x13f6594a : MonoBehaviour
{
    private void _0x9159f107(Button _0x9c05ba84)
    {
        _0xed2439e2.Press(_0x9c05ba84.transform as RectTransform);
        this._0x64998dd0();
    }

    public const float PrimaryCtaY = 900f;
    private void _0xe033a745(Button _0x60e05e8e)
    {
        _0xed2439e2.Press(_0x60e05e8e.transform as RectTransform);
        _0x8758f65d.Instance._0x927dfea1(_0x20971818._0xb6bbf20c.SCENE_1);
    }

    public void _0x4037d027()
    {
        if (this._0xdfb9e3f5 != null)
        {
            this._0xdfb9e3f5._0x3ca9b54d();
        }

        if (this._0x0bb70f38 != null)
        {
            this._0x0bb70f38._0x6833cc74();
        }

        if (this._0x4739457e != null)
        {
            this._0x4739457e._0x247e87a3();
        }
    }

    public const float TabSpacing = 360f;
    private _0x6759e2cf _0x9ebe9ae4;
    public void _0x3e8282a5(int _0xf1f741f4)
    {
        if (this._0x8053e0a4 == null)
        {
            return;
        }

        this._0x8053e0a4.gameObject.SetActive(true);
        this._0x8053e0a4.localScale = Vector3.one * 0.92f;
        this._0x8053e0a4.DOScale(1f, 0.22f).SetEase(Ease.OutCubic).SetLink(this._0x8053e0a4.gameObject);
        this._0x7a8a8fe3.alpha = 0f;
        this._0x7a8a8fe3.DOFade(1f, 0.22f).SetLink(this._0x8053e0a4.gameObject);
        this._0x71c60c5d(_0xf1f741f4);
    }

    private void _0xee62971b()
    {
        _0xed2439e2.Label(this._0x8053e0a4, _0x68db992e._0x754cdd83(new byte[15] { 141, 182, 187, 187, 170, 157, 177, 179, 174, 178, 183, 191, 176, 189, 187 }, 222), this._0x3b049818 != null ? this._0x3b049818._0x533877f5 : null, _0x68db992e._0x754cdd83(new byte[59] { 33, 62, 37, 35, 34, 54, 59, 87, 52, 56, 62, 57, 36, 87, 63, 54, 33, 50, 87, 57, 56, 87, 37, 50, 54, 59, 90, 32, 56, 37, 59, 51, 87, 33, 54, 59, 34, 50, 87, 90, 87, 50, 57, 35, 50, 37, 35, 54, 62, 57, 58, 50, 57, 35, 87, 56, 57, 59, 46 }, 119), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, 420f), new Vector2(1080f, 44f));
        _0xed2439e2.Label(this._0x8053e0a4, _0x68db992e._0x754cdd83(new byte[12] { 115, 72, 69, 69, 84, 118, 69, 82, 83, 73, 79, 78 }, 32), this._0x3b049818 != null ? this._0x3b049818._0x533877f5 : null, _0x68db992e._0x754cdd83(new byte[2] { 192, 182 }, 150) + Application.version, 36f, _0xda5d4a35.Fade(_0xda5d4a35._0x87d061a4, 0.7f), TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, 90f), new Vector2(400f, 42f));
        TextMeshProUGUI _0x97b8b0c6;
        Image _0x60026870;
        Button _0x49730741 = _0xed2439e2.Cta(this._0x8053e0a4, _0x68db992e._0x754cdd83(new byte[12] { 180, 143, 130, 130, 147, 180, 151, 142, 137, 169, 136, 144 }, 231), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, FooterCtaY), new Vector2(700f, 160f), null, _0xda5d4a35._0x16aaa4b1, _0xda5d4a35._0x64f656bb, this._0x3b049818 != null ? this._0x3b049818._0x533877f5 : null, _0x68db992e._0x754cdd83(new byte[8] { 150, 149, 140, 139, 229, 139, 138, 146 }, 197), 56f, out _0x97b8b0c6, out _0x60026870);
        _0x49730741.onClick.AddListener(() => this._0xe033a745(_0x49730741));
    }

    private void _0x28fc78e8()
    {
        string[] _0x9786bc71 =
        {
            _0x68db992e._0x754cdd83(new byte[5] { 211, 216, 213, 195, 196 }, 144),
            _0x68db992e._0x754cdd83(new byte[5] { 61, 48, 62, 41, 49 }, 124),
            _0x68db992e._0x754cdd83(new byte[8] { 238, 248, 233, 233, 244, 243, 250, 238 }, 189)
        };
        for (int _0x6ddad8fa = 0; _0x6ddad8fa < 3; _0x6ddad8fa++)
        {
            int _0x55407ae8 = _0x6ddad8fa;
            TextMeshProUGUI _0x3ca96dbb;
            Image _0xe6913366;
            Button _0xf8866703 = _0xed2439e2.Cta(this._0x8053e0a4, _0x68db992e._0x754cdd83(new byte[3] { 147, 166, 165 }, 199) + _0x6ddad8fa.ToString(), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2((_0x6ddad8fa - 1) * TabSpacing, -TabY), new Vector2(340f, 96f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), _0xda5d4a35._0x87d061a4, this._0x3b049818 != null ? this._0x3b049818._0x533877f5 : null, _0x9786bc71[_0x6ddad8fa], 44f, out _0x3ca96dbb, out _0xe6913366);
            this._0x245ab222[_0x6ddad8fa] = _0x3ca96dbb;
            this._0xb5109365[_0x6ddad8fa] = _0xe6913366;
            _0xf8866703.onClick.AddListener(() => this._0x71c60c5d(_0x55407ae8));
        }
    }

    public const float CloseY = 210f;
    public const float TabY = 380f;
    private CanvasGroup _0x7a8a8fe3;
    private int _0x3a62dd0f;
    private RectTransform _0x8053e0a4;
    private _0x6e321f0b _0xdfb9e3f5;
    public void _0x64998dd0()
    {
        if (this._0x8053e0a4 == null)
        {
            return;
        }

        this._0x8053e0a4.gameObject.SetActive(false);
        if (this._0xdfb9e3f5 != null)
        {
            this._0xdfb9e3f5._0x3ca9b54d();
        }
    }

    private readonly RectTransform[] _0x0689f8c3 = new RectTransform[3];
    private readonly TextMeshProUGUI[] _0x245ab222 = new TextMeshProUGUI[3];
    private _0x06bd04c5 _0x3b049818;
    private _0x24261dd3 _0x0bb70f38;
    private _0x52b00859 _0x4739457e;
    public const float FooterCtaY = 240f;
    private void _0x3d1ce7b9()
    {
        for (int _0x49e8c742 = 0; _0x49e8c742 < 3; _0x49e8c742++)
        {
            this._0x0689f8c3[_0x49e8c742] = _0xed2439e2.Node(this._0x8053e0a4, _0x68db992e._0x754cdd83(new byte[7] { 237, 216, 219, 251, 214, 221, 192 }, 185) + _0x49e8c742.ToString(), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -1040f), new Vector2(1100f, 1120f));
        }

        this._0x4739457e = this.gameObject.AddComponent<_0x52b00859>();
        this._0x4739457e._0x8c0d2bf2(this._0x0689f8c3[0], this._0x8053e0a4, this._0x9ebe9ae4, this._0x3b049818, this);
        this._0x0bb70f38 = this.gameObject.AddComponent<_0x24261dd3>();
        this._0x0bb70f38._0xdff5bc19(this._0x0689f8c3[1], this._0x9ebe9ae4, this._0x3b049818, this);
        this._0xea9c9058 = this.gameObject.AddComponent<_0xd3b998c3>();
        this._0xea9c9058._0xc1f2bdaa(this._0x0689f8c3[2], this._0x9ebe9ae4, this._0x3b049818, this);
    }

    private _0xd3b998c3 _0xea9c9058;
    private void OnDestroy()
    {
        if (this._0x8053e0a4 != null)
        {
            DOTween.Kill(this._0x8053e0a4);
        }
    }

    private readonly Image[] _0xb5109365 = new Image[3];
    private void _0xc5c7d946()
    {
        TextMeshProUGUI _0x3eee2a84;
        Image _0x2b233e5d;
        Button _0x91728c19 = _0xed2439e2.Cta(this._0x8053e0a4, _0x68db992e._0x754cdd83(new byte[10] { 25, 34, 47, 47, 62, 9, 38, 37, 57, 47 }, 74), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(CloseX, -CloseY), new Vector2(108f, 108f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), _0xda5d4a35._0x64f656bb, this._0x3b049818 != null ? this._0x3b049818._0x533877f5 : null, string.Empty, 44f, out _0x3eee2a84, out _0x2b233e5d);
        _0x3eee2a84.gameObject.SetActive(false);
        _0xed2439e2.Icon(_0x91728c19.transform as RectTransform, _0x68db992e._0x754cdd83(new byte[9] { 208, 255, 252, 224, 246, 218, 240, 252, 253 }, 147), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, 56f, this._0x3b049818 != null ? this._0x3b049818._0xfcd03d27 : null, _0xda5d4a35._0x872a7f7e);
        _0x91728c19.onClick.AddListener(() => this._0x9159f107(_0x91728c19));
    }

    private void _0x71c60c5d(int _0xff79a85b)
    {
        this._0x3a62dd0f = Mathf.Clamp(_0xff79a85b, 0, 2);
        for (int _0xe3446258 = 0; _0xe3446258 < 3; _0xe3446258++)
        {
            bool _0x65504151 = _0xe3446258 == this._0x3a62dd0f;
            if (this._0x0689f8c3[_0xe3446258] != null)
            {
                this._0x0689f8c3[_0xe3446258].gameObject.SetActive(_0x65504151);
            }

            if (this._0xb5109365[_0xe3446258] != null)
            {
                this._0xb5109365[_0xe3446258].color = _0x65504151 ? _0xda5d4a35._0x16aaa4b1 : _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f);
            }

            if (this._0x245ab222[_0xe3446258] != null)
            {
                this._0x245ab222[_0xe3446258].color = _0x65504151 ? _0xda5d4a35._0x64f656bb : _0xda5d4a35._0x87d061a4;
            }
        }

        if (this._0x0689f8c3[this._0x3a62dd0f] != null)
        {
            CanvasGroup _0xb35958ab = this._0x0689f8c3[this._0x3a62dd0f].GetComponent<CanvasGroup>();
            if (_0xb35958ab == null)
            {
                _0xb35958ab = this._0x0689f8c3[this._0x3a62dd0f].gameObject.AddComponent<CanvasGroup>();
            }

            _0xb35958ab.alpha = 0f;
            _0xb35958ab.DOFade(1f, 0.18f).SetLink(this._0x0689f8c3[this._0x3a62dd0f].gameObject);
        }

        if (this._0x4739457e != null)
        {
            this._0x4739457e._0x7035c04f(this._0x3a62dd0f == 0);
        }
    }

    public void _0x20d43166(RectTransform _0x21eeb7d5, _0x6759e2cf _0x7be6e9e0, _0x06bd04c5 _0x7dee3879, _0x6e321f0b _0xf2865b66)
    {
        this._0x9ebe9ae4 = _0x7be6e9e0;
        this._0x3b049818 = _0x7dee3879;
        this._0xdfb9e3f5 = _0xf2865b66;
        this._0x8053e0a4 = _0xed2439e2.Stretch(_0x21eeb7d5, _0x68db992e._0x754cdd83(new byte[9] { 95, 100, 105, 105, 120, 90, 101, 105, 123 }, 12));
        this._0x7a8a8fe3 = this._0x8053e0a4.gameObject.AddComponent<CanvasGroup>();
        Image _0x0ff5bc13 = _0xed2439e2.Fill(this._0x8053e0a4, _0x68db992e._0x754cdd83(new byte[10] { 195, 248, 245, 245, 228, 195, 243, 226, 249, 253 }, 144), _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.88f));
        _0x0ff5bc13.raycastTarget = true;
        RectTransform _0xd3935872 = _0xed2439e2.Stretch(this._0x8053e0a4, _0x68db992e._0x754cdd83(new byte[9] { 7, 60, 49, 49, 32, 22, 59, 48, 45 }, 84));
        _0xd3935872.offsetMin = new Vector2(60f, 60f);
        _0xd3935872.offsetMax = new Vector2(-60f, -60f);
        _0xed2439e2.Fill(_0xd3935872, _0x68db992e._0x754cdd83(new byte[8] { 228, 201, 194, 223, 227, 194, 193, 195 }, 166), _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.95f));
        RectTransform _0xc76fe3e4 = _0xed2439e2.Stretch(_0xd3935872, _0x68db992e._0x754cdd83(new byte[9] { 22, 59, 48, 45, 29, 58, 58, 49, 38 }, 84));
        _0xc76fe3e4.offsetMin = new Vector2(6f, 6f);
        _0xc76fe3e4.offsetMax = new Vector2(-6f, -6f);
        _0xed2439e2.Fill(_0xc76fe3e4, _0x68db992e._0x754cdd83(new byte[8] { 196, 233, 226, 255, 192, 239, 234, 234 }, 134), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.98f));
        _0xed2439e2.Plate(_0xc76fe3e4, _0x68db992e._0x754cdd83(new byte[9] { 187, 150, 157, 128, 170, 145, 156, 156, 151 }, 249), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0f, -140f), new Vector2(0f, 280f), _0xda5d4a35.Fade(_0xda5d4a35._0x8a0e3d68, 0.14f), null, false, 1f);
        this._0xc5c7d946();
        this._0x28fc78e8();
        this._0x3d1ce7b9();
        this._0xee62971b();
        this._0x8053e0a4.gameObject.SetActive(false);
    }

    public const float CloseX = 500f;
}

internal static class _0x68db992e
{
    internal static string _0x754cdd83(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}