using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The in-game payout list. Multipliers are read from <see cref = "ReelMath"/> so the sheet
/// can never drift from what the game actually pays.
/// </summary>
public sealed class _0x2ea6a731 : MonoBehaviour
{
    private _0x06bd04c5 _0xcf5f03f1;
    private RectTransform _0x3af2a140;
    private const float TextWidth = 240f;
    private void _0x2654b788(RectTransform _0x8dd4cc13, string _0xafbaa6a7, float _0x8b4f626c, int _0x3bb94652, _0x06bd04c5 _0x8848daab)
    {
        _0xed2439e2.Label(_0x8dd4cc13, _0xafbaa6a7, _0x8848daab != null ? _0x8848daab._0x533877f5 : null, _0x3bb94652 > 0 ? _0x3bb94652.ToString() + _0xb215fed2._0xf96b0afd(new byte[1] { 31 }, 103) : _0xb215fed2._0xf96b0afd(new byte[1] { 3 }, 46), 44f, _0x3bb94652 > 0 ? _0xda5d4a35._0x872a7f7e : _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(_0x8b4f626c, 0f), new Vector2(150f, 50f));
    }

    public void _0x9fcd27d9(RectTransform _0x09fc9f3b, _0xc19b7c1c _0x69773605, _0x06bd04c5 _0xcb912e35)
    {
        this._0xcf5f03f1 = _0xcb912e35;
        this._0x3af2a140 = _0xed2439e2.Stretch(_0x09fc9f3b, _0xb215fed2._0xf96b0afd(new byte[13] { 173, 156, 132, 137, 156, 159, 145, 152, 174, 149, 152, 152, 137 }, 253));
        _0xed2439e2.Fill(this._0x3af2a140, _0xb215fed2._0xf96b0afd(new byte[13] { 26, 43, 51, 62, 43, 40, 38, 47, 25, 41, 56, 35, 39 }, 74), _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.9f)).raycastTarget = true;
        RectTransform _0x8bb89ac2 = _0xed2439e2.Node(this._0x3af2a140, _0xb215fed2._0xf96b0afd(new byte[12] { 56, 9, 17, 28, 9, 10, 4, 13, 43, 9, 26, 12 }, 104), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, 60f), new Vector2(1120f, 1860f));
        _0xed2439e2.Plate(_0x8bb89ac2, _0xb215fed2._0xf96b0afd(new byte[8] { 227, 193, 210, 196, 229, 196, 199, 197 }, 160), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.95f), null, false, 1f);
        _0xed2439e2.Plate(_0x8bb89ac2, _0xb215fed2._0xf96b0afd(new byte[8] { 27, 57, 42, 60, 26, 55, 60, 33 }, 88), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.98f), null, false, 1f);
        _0xed2439e2.Label(_0x8bb89ac2, _0xb215fed2._0xf96b0afd(new byte[13] { 131, 178, 170, 167, 178, 177, 191, 182, 135, 186, 167, 191, 182 }, 211), _0xcb912e35 != null ? _0xcb912e35._0x533877f5 : null, _0xb215fed2._0xf96b0afd(new byte[19] { 252, 237, 245, 255, 140, 252, 233, 254, 140, 224, 229, 226, 233, 140, 255, 248, 237, 231, 233 }, 172), 56f, _0xda5d4a35._0x872a7f7e, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -70f), new Vector2(980f, 70f));
        RectTransform _0xf99bdf5c = _0xed2439e2.Node(_0x8bb89ac2, _0xb215fed2._0xf96b0afd(new byte[12] { 100, 85, 77, 64, 85, 86, 88, 81, 124, 81, 85, 80 }, 52), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -136f), new Vector2(980f, 46f));
        _0xed2439e2.Label(_0xf99bdf5c, _0xb215fed2._0xf96b0afd(new byte[10] { 180, 153, 157, 152, 175, 133, 145, 158, 147, 144 }, 252), _0xcb912e35 != null ? _0xcb912e35._0x533877f5 : null, _0xb215fed2._0xf96b0afd(new byte[6] { 208, 218, 206, 193, 204, 207 }, 131), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Left, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(TextLeft + (TextWidth * 0.5f), 0f), new Vector2(TextWidth, 44f));
        _0xed2439e2.Label(_0xf99bdf5c, _0xb215fed2._0xf96b0afd(new byte[5] { 157, 176, 180, 177, 230 }, 213), _0xcb912e35 != null ? _0xcb912e35._0x533877f5 : null, _0xb215fed2._0xf96b0afd(new byte[1] { 66 }, 113), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(60f, 0f), new Vector2(150f, 44f));
        _0xed2439e2.Label(_0xf99bdf5c, _0xb215fed2._0xf96b0afd(new byte[5] { 175, 130, 134, 131, 211 }, 231), _0xcb912e35 != null ? _0xcb912e35._0x533877f5 : null, _0xb215fed2._0xf96b0afd(new byte[1] { 6 }, 50), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(230f, 0f), new Vector2(150f, 44f));
        _0xed2439e2.Label(_0xf99bdf5c, _0xb215fed2._0xf96b0afd(new byte[5] { 120, 85, 81, 84, 5 }, 48), _0xcb912e35 != null ? _0xcb912e35._0x533877f5 : null, _0xb215fed2._0xf96b0afd(new byte[1] { 58 }, 15), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(400f, 0f), new Vector2(150f, 44f));
        for (int _0x49ab957e = 0; _0x49ab957e < 9; _0x49ab957e++)
        {
            float _0x90b1770e = -208f - (_0x49ab957e * 148f);
            RectTransform _0x04d8e5b5 = _0xed2439e2.Node(_0x8bb89ac2, _0xb215fed2._0xf96b0afd(new byte[6] { 178, 131, 155, 176, 141, 149 }, 226) + _0x49ab957e.ToString(), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, _0x90b1770e), new Vector2(980f, 132f));
            _0xed2439e2.Plate(_0x04d8e5b5, _0xb215fed2._0xf96b0afd(new byte[8] { 18, 35, 59, 18, 46, 35, 54, 39 }, 66), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, (_0x49ab957e % 2) == 0 ? 0.55f : 0.35f), null, false, 1f);
            _0xed2439e2.Icon(_0x04d8e5b5, _0xb215fed2._0xf96b0afd(new byte[9] { 7, 54, 46, 4, 46, 58, 53, 56, 59 }, 87), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(GutterCentre, 0f), 96f, _0xcb912e35 != null ? _0xcb912e35._0xe0c1eb60(_0x49ab957e) : null, Color.white);
            _0xed2439e2.Label(_0x04d8e5b5, _0xb215fed2._0xf96b0afd(new byte[7] { 28, 45, 53, 2, 45, 33, 41 }, 76), _0xcb912e35 != null ? _0xcb912e35._0x533877f5 : null, _0x69773605._0xa425c351(_0x49ab957e), 44f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Left, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(TextLeft + (TextWidth * 0.5f), 0f), new Vector2(TextWidth, 50f));
            this._0x2654b788(_0x04d8e5b5, _0xb215fed2._0xf96b0afd(new byte[4] { 37, 20, 12, 70 }, 117), 60f, _0x69773605._0x0f243b20(_0x49ab957e, 3), _0xcb912e35);
            this._0x2654b788(_0x04d8e5b5, _0xb215fed2._0xf96b0afd(new byte[4] { 161, 144, 136, 197 }, 241), 230f, _0x69773605._0x0f243b20(_0x49ab957e, 4), _0xcb912e35);
            this._0x2654b788(_0x04d8e5b5, _0xb215fed2._0xf96b0afd(new byte[4] { 165, 148, 140, 192 }, 245), 400f, _0x69773605._0x0f243b20(_0x49ab957e, 5), _0xcb912e35);
        }

        _0xed2439e2.Label(_0x8bb89ac2, _0xb215fed2._0xf96b0afd(new byte[12] { 8, 57, 33, 44, 57, 58, 52, 61, 15, 49, 52, 60 }, 88), _0xcb912e35 != null ? _0xcb912e35._0x533877f5 : null, _0xb215fed2._0xf96b0afd(new byte[79] { 27, 20, 23, 14, 29, 10, 120, 17, 11, 120, 15, 17, 20, 28, 120, 25, 22, 28, 120, 10, 29, 8, 20, 25, 27, 29, 11, 120, 29, 14, 29, 10, 1, 120, 11, 1, 21, 26, 23, 20, 120, 26, 13, 12, 120, 12, 16, 29, 120, 27, 23, 17, 22, 82, 12, 16, 10, 29, 29, 120, 27, 23, 17, 22, 11, 120, 25, 22, 1, 15, 16, 29, 10, 29, 120, 8, 25, 1, 120 }, 88) + _0xc19b7c1c.ScatterPay.ToString() + _0xb215fed2._0xf96b0afd(new byte[15] { 145, 201, 189, 161, 172, 201, 189, 166, 189, 168, 165, 201, 171, 172, 189 }, 233), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, 190f), new Vector2(1000f, 110f));
        TextMeshProUGUI _0x6d246f06;
        Image _0xf673e25c;
        Button _0xe7938451 = _0xed2439e2.Cta(_0x8bb89ac2, _0xb215fed2._0xf96b0afd(new byte[13] { 41, 24, 0, 13, 24, 27, 21, 28, 58, 21, 22, 10, 28 }, 121), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, 80f), new Vector2(520f, 130f), null, _0xda5d4a35._0x16aaa4b1, _0xda5d4a35._0x64f656bb, _0xcb912e35 != null ? _0xcb912e35._0x533877f5 : null, _0xb215fed2._0xf96b0afd(new byte[13] { 164, 167, 165, 173, 198, 178, 169, 198, 180, 163, 163, 170, 181 }, 230), 44f, out _0x6d246f06, out _0xf673e25c);
        _0xe7938451.onClick.AddListener(() => this._0x0f233415());
        this._0x3af2a140.gameObject.SetActive(false);
    }

    public void Show()
    {
        if (this._0x3af2a140 == null)
        {
            return;
        }

        this._0x3af2a140.gameObject.SetActive(true);
        this._0x3af2a140.localScale = Vector3.one * 0.94f;
        this._0x3af2a140.DOScale(1f, 0.2f).SetEase(Ease.OutCubic).SetLink(this._0x3af2a140.gameObject);
    }

    private const float GutterWidth = 110f;
    private const float GutterCentre = -420f;
    private const float TextLeft = GutterCentre + (GutterWidth * 0.5f) + 28f;
    public bool _0x127b1a2b => this._0x3af2a140 != null && this._0x3af2a140.gameObject.activeSelf;

    private void OnDestroy()
    {
        if (this._0x3af2a140 != null)
        {
            DOTween.Kill(this._0x3af2a140);
        }
    }

    public void _0x0f233415()
    {
        if (this._0x3af2a140 != null)
        {
            this._0x3af2a140.gameObject.SetActive(false);
        }
    }
}

internal static class _0xb215fed2
{
    internal static string _0xf96b0afd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}