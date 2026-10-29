using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Three settings that really do something. The game has no sound, so there is no sound
/// row (C.20): a dead toggle is worse than no toggle.
/// </summary>
public sealed class _0xd3b998c3 : MonoBehaviour
{
    private void _0x9468b324(RectTransform _0x1152ddd1, float _0x64bea1f2)
    {
        RectTransform _0x0354f39a = this._0xee97789f(_0x1152ddd1, _0x64bea1f2, _0x66215ca6._0xcc87b504(new byte[10] { 207, 236, 236, 239, 233, 254, 249, 216, 229, 253 }, 138), _0x66215ca6._0xcc87b504(new byte[15] { 71, 80, 81, 64, 86, 80, 81, 53, 80, 83, 83, 80, 86, 65, 70 }, 21), 26f);
        RectTransform _0x31f251da = _0xed2439e2.Node(_0x0354f39a, _0x66215ca6._0xcc87b504(new byte[9] { 251, 197, 237, 207, 216, 203, 212, 216, 202 }, 189), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(160f, -44f), new Vector2(180f, 36f));
        this._0x27ddc851 = _0xed2439e2.Plate(_0x31f251da, _0x66215ca6._0xcc87b504(new byte[3] { 180, 138, 179 }, 242), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(30f, 0f), new Vector2(52f, 30f), _0xda5d4a35._0x41b9a3a1, null, false, 1f);
        this._0x9f389bf0 = _0xed2439e2.Plate(_0x31f251da, _0x66215ca6._0xcc87b504(new byte[3] { 217, 231, 221 }, 159), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(90f, 0f), new Vector2(52f, 30f), _0xda5d4a35._0x16aaa4b1, null, false, 1f);
        this._0xf62f76d3 = _0xed2439e2.Plate(_0x31f251da, _0x66215ca6._0xcc87b504(new byte[3] { 183, 137, 178 }, 241), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(150f, 0f), new Vector2(52f, 30f), _0xda5d4a35._0x872a7f7e, null, false, 1f);
        TextMeshProUGUI _0xaa69360c;
        Image _0xc21a68d1;
        Button _0xde2278f8 = _0xed2439e2.Cta(_0x0354f39a, _0x66215ca6._0xcc87b504(new byte[13] { 97, 66, 66, 65, 71, 80, 87, 112, 75, 67, 67, 72, 65 }, 36), new Vector2(1f, 0.5f), new Vector2(1f, 0.5f), new Vector2(-130f, 0f), new Vector2(180f, 84f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.6f), _0xda5d4a35._0x64f656bb, this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, string.Empty, 36f, out _0xaa69360c, out _0xc21a68d1);
        _0xaa69360c.gameObject.SetActive(false);
        this._0x0bd7f97c = _0xc21a68d1;
        this._0x5b9f639b = _0xed2439e2.Plate(_0xde2278f8.transform as RectTransform, _0x66215ca6._0xcc87b504(new byte[4] { 223, 250, 251, 246 }, 148), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(44f, 0f), new Vector2(64f, 64f), _0xda5d4a35._0x64f656bb, null, false, 1f).rectTransform;
        this._0x40b7e283 = _0xed2439e2.Label(_0x0354f39a, _0x66215ca6._0xcc87b504(new byte[11] { 132, 167, 167, 164, 162, 181, 178, 130, 169, 168, 177 }, 193), this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, _0x66215ca6._0xcc87b504(new byte[3] { 57, 48, 48 }, 118), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Right, new Vector2(1f, 0.5f), new Vector2(1f, 0.5f), new Vector2(-250f, 0f), new Vector2(140f, 44f));
        _0xde2278f8.onClick.AddListener(() => this._0x5eacc5d1());
    }

    private RectTransform _0x2c6e910e;
    private TextMeshProUGUI _0xe079f492;
    public void _0xc1f2bdaa(RectTransform _0xe58554b9, _0x6759e2cf _0xc5c134ec, _0x06bd04c5 _0x2d1cb78c, _0x13f6594a _0x0abc615c)
    {
        this._0x2517cdd8 = _0xc5c134ec;
        this._0xbb3bcb1d = _0x2d1cb78c;
        this._0x4c1640ff = _0x0abc615c;
        _0xed2439e2.Label(_0xe58554b9, _0x66215ca6._0xcc87b504(new byte[13] { 6, 48, 33, 33, 60, 59, 50, 38, 1, 60, 33, 57, 48 }, 85), _0x2d1cb78c != null ? _0x2d1cb78c._0x533877f5 : null, _0x66215ca6._0xcc87b504(new byte[8] { 29, 11, 26, 26, 7, 0, 9, 29 }, 78), 64f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -56f), new Vector2(900f, 72f));
        this._0xb4f44f74(_0xe58554b9, 320f);
        this._0x9468b324(_0xe58554b9, 130f);
        this._0x2586865d(_0xe58554b9, -60f);
        this._0xe7dadadc(_0xe58554b9, -300f);
        this._0x0d2b2ed5(_0xe58554b9);
        this._0x944de053();
    }

    public void _0x944de053()
    {
        if (this._0x2517cdd8 == null)
        {
            return;
        }

        this._0xefa05f98(this._0x9d890b43, this._0x2d9fa91c, this._0x20d14bd4, this._0x2517cdd8._0x042ed8f8);
        this._0xefa05f98(this._0x0bd7f97c, this._0x5b9f639b, this._0x40b7e283, this._0x2517cdd8._0x8b476d41);
        float _0x2c6d5491 = this._0x2517cdd8._0x8b476d41 ? 0.3f : 0.85f;
        if (this._0x27ddc851 != null)
        {
            this._0x27ddc851.color = _0xda5d4a35.Fade(_0xda5d4a35._0x41b9a3a1, _0x2c6d5491);
        }

        if (this._0x9f389bf0 != null)
        {
            this._0x9f389bf0.color = _0xda5d4a35.Fade(_0xda5d4a35._0x16aaa4b1, _0x2c6d5491);
        }

        if (this._0xf62f76d3 != null)
        {
            this._0xf62f76d3.color = _0xda5d4a35.Fade(_0xda5d4a35._0x872a7f7e, _0x2c6d5491);
        }

        if (this._0xe079f492 != null)
        {
            this._0xe079f492.text = this._0x2517cdd8._0x8ff2adc8(this._0x2517cdd8._0xcb5f5c39) + _0x66215ca6._0xcc87b504(new byte[1] { 35 }, 41) + this._0x2517cdd8._0x699c56a8().ToString() + _0x66215ca6._0xcc87b504(new byte[16] { 41, 90, 93, 72, 68, 89, 90, 41, 36, 41, 95, 64, 90, 64, 93, 41 }, 9) + this._0x2517cdd8._0x533c17db.ToString();
        }
    }

    private TextMeshProUGUI _0x40b7e283;
    private _0x13f6594a _0x4c1640ff;
    private Image _0x9f389bf0;
    private void _0xb4f44f74(RectTransform _0xadb4db31, float _0x9ca56655)
    {
        RectTransform _0x85eebf64 = this._0xee97789f(_0xadb4db31, _0x9ca56655, _0x66215ca6._0xcc87b504(new byte[12] { 247, 200, 195, 211, 192, 213, 200, 206, 207, 243, 206, 214 }, 161), _0x66215ca6._0xcc87b504(new byte[9] { 75, 84, 95, 79, 92, 73, 84, 82, 83 }, 29), 0f);
        TextMeshProUGUI _0x857dc20f;
        Image _0x435d0fd4;
        Button _0x11ae57cf = _0xed2439e2.Cta(_0x85eebf64, _0x66215ca6._0xcc87b504(new byte[15] { 165, 154, 145, 129, 146, 135, 154, 156, 157, 167, 156, 148, 148, 159, 150 }, 243), new Vector2(1f, 0.5f), new Vector2(1f, 0.5f), new Vector2(-130f, 0f), new Vector2(180f, 84f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.6f), _0xda5d4a35._0x64f656bb, this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, string.Empty, 36f, out _0x857dc20f, out _0x435d0fd4);
        _0x857dc20f.gameObject.SetActive(false);
        this._0x9d890b43 = _0x435d0fd4;
        this._0x2d9fa91c = _0xed2439e2.Plate(_0x11ae57cf.transform as RectTransform, _0x66215ca6._0xcc87b504(new byte[4] { 135, 162, 163, 174 }, 204), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(44f, 0f), new Vector2(64f, 64f), _0xda5d4a35._0x64f656bb, null, false, 1f).rectTransform;
        this._0x20d14bd4 = _0xed2439e2.Label(_0x85eebf64, _0x66215ca6._0xcc87b504(new byte[13] { 206, 241, 250, 234, 249, 236, 241, 247, 246, 219, 240, 241, 232 }, 152), this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, _0x66215ca6._0xcc87b504(new byte[3] { 62, 55, 55 }, 113), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Right, new Vector2(1f, 0.5f), new Vector2(1f, 0.5f), new Vector2(-250f, 0f), new Vector2(140f, 44f));
        _0x11ae57cf.onClick.AddListener(() => this._0xd5acdc04());
    }

    private void _0xefa05f98(Image _0x0971801d, RectTransform _0x23f1c423, TextMeshProUGUI _0x27e6164b, bool _0x06bd78e9)
    {
        if (_0x0971801d != null)
        {
            _0x0971801d.color = _0x06bd78e9 ? _0xda5d4a35.Fade(_0xda5d4a35._0x31eee6c9, 0.85f) : _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.6f);
        }

        if (_0x23f1c423 != null)
        {
            DOTween.Kill(_0x23f1c423, false);
            _0x23f1c423.anchoredPosition = new Vector2(_0x06bd78e9 ? 136f : 44f, 0f);
        }

        if (_0x27e6164b != null)
        {
            _0x27e6164b.text = _0x06bd78e9 ? _0x66215ca6._0xcc87b504(new byte[2] { 229, 228 }, 170) : _0x66215ca6._0xcc87b504(new byte[3] { 76, 69, 69 }, 3);
            _0x27e6164b.color = _0x06bd78e9 ? _0xda5d4a35._0x048a938e : _0xda5d4a35._0x87d061a4;
        }
    }

    private Image _0x0bd7f97c;
    private Image _0x27ddc851;
    private void _0xd5acdc04()
    {
        if (this._0x2517cdd8 == null)
        {
            return;
        }

        bool _0x0f7971c4 = !this._0x2517cdd8._0x042ed8f8;
        this._0x2517cdd8._0x042ed8f8 = _0x0f7971c4;
        this._0xefa05f98(this._0x9d890b43, null, this._0x20d14bd4, _0x0f7971c4);
        this._0x4c6b18ba(this._0x2d9fa91c, _0x0f7971c4);
        if (_0x0f7971c4)
        {
            Handheld.Vibrate();
        }
    }

    private _0x06bd04c5 _0xbb3bcb1d;
    private RectTransform _0x2d9fa91c;
    private void _0x4c6b18ba(RectTransform _0x5f3969a2, bool _0x6088be03)
    {
        if (_0x5f3969a2 == null)
        {
            return;
        }

        _0x5f3969a2.DOAnchorPosX(_0x6088be03 ? 136f : 44f, 0.18f).SetEase(Ease.OutCubic).SetLink(_0x5f3969a2.gameObject);
    }

    private void _0x2586865d(RectTransform _0x0aea4093, float _0xc316b8d4)
    {
        RectTransform _0xe7e195cb = this._0xee97789f(_0x0aea4093, _0xc316b8d4, _0x66215ca6._0xcc87b504(new byte[8] { 132, 179, 165, 179, 162, 132, 185, 161 }, 214), _0x66215ca6._0xcc87b504(new byte[14] { 176, 167, 177, 167, 182, 194, 178, 176, 173, 165, 176, 167, 177, 177 }, 226), 0f);
        TextMeshProUGUI _0x580874e0;
        Image _0x7e355d78;
        Button _0xd80d0363 = _0xed2439e2.Cta(_0xe7e195cb, _0x66215ca6._0xcc87b504(new byte[11] { 17, 38, 48, 38, 55, 1, 54, 55, 55, 44, 45 }, 67), new Vector2(1f, 0.5f), new Vector2(1f, 0.5f), new Vector2(-150f, 0f), new Vector2(220f, 84f), null, _0xda5d4a35.Fade(_0xda5d4a35._0x41b9a3a1, 0.9f), _0xda5d4a35._0x64f656bb, this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, _0x66215ca6._0xcc87b504(new byte[5] { 162, 181, 163, 181, 164 }, 240), 44f, out _0x580874e0, out _0x7e355d78);
        _0xd80d0363.onClick.AddListener(() => this._0x5e757952());
    }

    /// <summary>A plain summary so the lower half of the tab is never a blank area.</summary>
    private void _0xe7dadadc(RectTransform _0xf25992cb, float _0x41e52293)
    {
        RectTransform _0x6a890539 = _0xed2439e2.Node(_0xf25992cb, _0x66215ca6._0xcc87b504(new byte[12] { 151, 161, 176, 176, 173, 170, 163, 183, 141, 170, 162, 171 }, 196), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, _0x41e52293), new Vector2(1000f, 200f));
        _0xed2439e2.Plate(_0x6a890539, _0x66215ca6._0xcc87b504(new byte[8] { 150, 177, 185, 176, 154, 187, 184, 186 }, 223), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.35f), null, false, 1f);
        _0xed2439e2.Plate(_0x6a890539, _0x66215ca6._0xcc87b504(new byte[8] { 3, 36, 44, 37, 8, 37, 46, 51 }, 74), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-5f, -5f), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.92f), null, false, 1f);
        _0xed2439e2.Label(_0x6a890539, _0x66215ca6._0xcc87b504(new byte[10] { 148, 179, 187, 178, 149, 184, 188, 185, 184, 175 }, 221), this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, _0x66215ca6._0xcc87b504(new byte[10] { 135, 145, 139, 140, 254, 141, 159, 146, 145, 144 }, 222), 44f, _0xda5d4a35._0x872a7f7e, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -44f), new Vector2(900f, 50f));
        this._0xe079f492 = _0xed2439e2.Label(_0x6a890539, _0x66215ca6._0xcc87b504(new byte[8] { 60, 27, 19, 26, 57, 28, 27, 16 }, 117), this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, _0x66215ca6._0xcc87b504(new byte[17] { 132, 153, 153, 155, 246, 231, 246, 251, 246, 230, 246, 133, 130, 151, 155, 134, 133 }, 214), 44f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -24f), new Vector2(900f, 56f));
    }

    private void _0xeec7ed03()
    {
        if (this._0x2517cdd8 != null)
        {
            this._0x2517cdd8._0x6921adc4();
        }

        this._0x8930ca5f();
        this._0x944de053();
        if (this._0x4c1640ff != null)
        {
            this._0x4c1640ff._0x4037d027();
        }
    }

    private _0x6759e2cf _0x2517cdd8;
    private Image _0x9d890b43;
    private void _0x5eacc5d1()
    {
        if (this._0x2517cdd8 == null)
        {
            return;
        }

        bool _0x62119f70 = !this._0x2517cdd8._0x8b476d41;
        this._0x2517cdd8._0x8b476d41 = _0x62119f70;
        this._0xefa05f98(this._0x0bd7f97c, null, this._0x40b7e283, _0x62119f70);
        this._0x4c6b18ba(this._0x5b9f639b, _0x62119f70);
        this._0x944de053();
    }

    private TextMeshProUGUI _0x20d14bd4;
    private void _0x5e757952()
    {
        if (this._0x2c6e910e != null)
        {
            this._0x2c6e910e.gameObject.SetActive(true);
        }
    }

    private RectTransform _0x5b9f639b;
    private void _0x0d2b2ed5(RectTransform _0x8bf59a52)
    {
        this._0x2c6e910e = _0xed2439e2.Stretch(_0x8bf59a52, _0x66215ca6._0xcc87b504(new byte[12] { 88, 111, 121, 111, 126, 73, 101, 100, 108, 99, 120, 103 }, 10));
        _0xed2439e2.Fill(this._0x2c6e910e, _0x66215ca6._0xcc87b504(new byte[12] { 50, 30, 31, 23, 24, 3, 28, 34, 18, 3, 24, 28 }, 113), _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.9f)).raycastTarget = true;
        RectTransform _0xfb88f298 = _0xed2439e2.Node(this._0x2c6e910e, _0x66215ca6._0xcc87b504(new byte[11] { 251, 215, 214, 222, 209, 202, 213, 251, 217, 202, 220 }, 184), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(900f, 420f));
        _0xed2439e2.Plate(_0xfb88f298, _0x66215ca6._0xcc87b504(new byte[11] { 20, 56, 57, 49, 62, 37, 58, 18, 51, 48, 50 }, 87), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.95f), null, false, 1f);
        _0xed2439e2.Plate(_0xfb88f298, _0x66215ca6._0xcc87b504(new byte[11] { 39, 11, 10, 2, 13, 22, 9, 38, 11, 0, 29 }, 100), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.98f), null, false, 1f);
        _0xed2439e2.Label(_0xfb88f298, _0x66215ca6._0xcc87b504(new byte[13] { 19, 63, 62, 54, 57, 34, 61, 24, 53, 49, 52, 53, 34 }, 80), this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, _0x66215ca6._0xcc87b504(new byte[19] { 136, 159, 137, 159, 142, 250, 155, 150, 150, 250, 138, 136, 149, 157, 136, 159, 137, 137, 229 }, 218), 56f, _0xda5d4a35._0x872a7f7e, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -80f), new Vector2(820f, 70f));
        _0xed2439e2.Label(_0xfb88f298, _0x66215ca6._0xcc87b504(new byte[15] { 235, 199, 198, 206, 193, 218, 197, 234, 199, 204, 209, 252, 205, 208, 220 }, 168), this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, _0x66215ca6._0xcc87b504(new byte[39] { 172, 160, 166, 161, 188, 207, 189, 170, 187, 186, 189, 161, 207, 187, 160, 207, 218, 195, 223, 223, 223, 229, 187, 167, 170, 207, 174, 163, 173, 186, 162, 207, 170, 162, 191, 187, 166, 170, 188 }, 239), 44f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, 10f), new Vector2(820f, 110f));
        TextMeshProUGUI _0xafeaf85b;
        Image _0xc713bc73;
        Button _0x88739b9e = _0xed2439e2.Cta(_0xfb88f298, _0x66215ca6._0xcc87b504(new byte[10] { 251, 215, 214, 222, 209, 202, 213, 225, 221, 203 }, 184), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(-210f, 80f), new Vector2(360f, 120f), null, _0xda5d4a35._0x16aaa4b1, _0xda5d4a35._0x64f656bb, this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, _0x66215ca6._0xcc87b504(new byte[7] { 0, 12, 13, 5, 10, 17, 14 }, 67), 44f, out _0xafeaf85b, out _0xc713bc73);
        _0x88739b9e.onClick.AddListener(() => this._0xeec7ed03());
        TextMeshProUGUI _0xe79f47d8;
        Image _0xd3aeadfa;
        Button _0x0e3c3b0c = _0xed2439e2.Cta(_0xfb88f298, _0x66215ca6._0xcc87b504(new byte[9] { 149, 185, 184, 176, 191, 164, 187, 152, 185 }, 214), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(210f, 80f), new Vector2(360f, 120f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), _0xda5d4a35._0x64f656bb, this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, _0x66215ca6._0xcc87b504(new byte[7] { 249, 247, 247, 226, 146, 251, 230 }, 178), 44f, out _0xe79f47d8, out _0xd3aeadfa);
        _0x0e3c3b0c.onClick.AddListener(() => this._0x8930ca5f());
        this._0x2c6e910e.gameObject.SetActive(false);
    }

    private void _0x8930ca5f()
    {
        if (this._0x2c6e910e != null)
        {
            this._0x2c6e910e.gameObject.SetActive(false);
        }
    }

    private RectTransform _0xee97789f(RectTransform _0x76d528c4, float _0x9a28a99b, string _0x2748b406, string _0xa39328fb, float _0x5d01c9a3)
    {
        RectTransform _0xabd5ca1d = _0xed2439e2.Node(_0x76d528c4, _0x2748b406, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, _0x9a28a99b), new Vector2(1000f, 150f));
        _0xed2439e2.Plate(_0xabd5ca1d, _0x66215ca6._0xcc87b504(new byte[7] { 207, 242, 234, 216, 249, 250, 248 }, 157), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.45f), null, false, 1f);
        _0xed2439e2.Plate(_0xabd5ca1d, _0x66215ca6._0xcc87b504(new byte[7] { 76, 113, 105, 92, 113, 122, 103 }, 30), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-5f, -5f), _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.92f), null, false, 1f);
        _0xed2439e2.Label(_0xabd5ca1d, _0x66215ca6._0xcc87b504(new byte[7] { 217, 228, 252, 223, 238, 243, 255 }, 139), this._0xbb3bcb1d != null ? this._0xbb3bcb1d._0x533877f5 : null, _0xa39328fb, 44f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(300f, _0x5d01c9a3), new Vector2(520f, 56f));
        return _0xabd5ca1d;
    }

    private Image _0xf62f76d3;
    private void OnDestroy()
    {
        if (this._0x2d9fa91c != null)
        {
            DOTween.Kill(this._0x2d9fa91c);
        }

        if (this._0x5b9f639b != null)
        {
            DOTween.Kill(this._0x5b9f639b);
        }
    }
}

internal static class _0x66215ca6
{
    internal static string _0xcc87b504(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}