using System.Globalization;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Shared UGUI builders for the royal-salon chrome. Everything is created under an
/// existing template Canvas, so no component here ever touches sorting order.
/// </summary>
public static class _0xed2439e2
{
    public static string Money(long _0x7f8caf16)
    {
        return _0x7f8caf16.ToString(_0x33d388e2._0xe450d17e(new byte[2] { 147, 237 }, 221), CultureInfo.InvariantCulture);
    }

    public static TextMeshProUGUI Label(Transform _0xa76504a5, string _0xbf7482ba, TMP_FontAsset _0xfa9bd4e9, string _0x45be4fdc, float _0xd4602b38, Color _0x1d11326a, TextAlignmentOptions _0xae0a6d10, Vector2 _0x46a426a6, Vector2 _0xb40e642d, Vector2 _0x1b4ac50b, Vector2 _0x8be09e0a)
    {
        RectTransform _0xef55a9f4 = Node(_0xa76504a5, _0xbf7482ba, _0x46a426a6, _0xb40e642d, _0x1b4ac50b, _0x8be09e0a);
        TextMeshProUGUI _0xd508c3df = _0xef55a9f4.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0xfa9bd4e9 != null)
        {
            _0xd508c3df.font = _0xfa9bd4e9;
        }

        _0xd508c3df.text = _0x45be4fdc;
        _0xd508c3df.color = _0x1d11326a;
        _0xd508c3df.alignment = _0xae0a6d10;
        _0xd508c3df.enableWordWrapping = false;
        _0xd508c3df.overflowMode = TextOverflowModes.Overflow;
        _0xd508c3df.enableAutoSizing = true;
        _0xd508c3df.fontSizeMin = FontFloor;
        _0xd508c3df.fontSizeMax = Mathf.Max(_0xd4602b38, FontFloor);
        _0xd508c3df.fontSize = Mathf.Max(_0xd4602b38, FontFloor);
        _0xd508c3df.raycastTarget = false;
        _0x327dba82.ApplyOutline(_0xd508c3df);
        return _0xd508c3df;
    }

    public static RectTransform Pill(Transform _0x03f3f2de, string _0x0d36d1cd, Vector2 _0x2ff0c593, Vector2 _0x35a5f362, Vector2 _0xf9c33119, Vector2 _0x1944c775, Color _0x54f3ad05, Color _0x35932387)
    {
        RectTransform _0x2b1df25a = Node(_0x03f3f2de, _0x0d36d1cd, _0x2ff0c593, _0x35a5f362, _0xf9c33119, _0x1944c775);
        Plate(_0x2b1df25a, _0x33d388e2._0xe450d17e(new byte[4] { 239, 206, 205, 207 }, 170), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0x35932387, null, false, 1f);
        Plate(_0x2b1df25a, _0x33d388e2._0xe450d17e(new byte[4] { 161, 140, 135, 154 }, 227), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-4f, -4f), _0x54f3ad05, null, false, 1f);
        return _0x2b1df25a;
    }

    /// <summary>
    /// A framed action button: shadow -> plate -> rim -> caption (caption last, C.13).
    /// The hit layer is the plate itself; children above it do not take raycasts.
    /// </summary>
    public static Button Cta(Transform _0x4b3431e8, string _0xf8513477, Vector2 _0xe0a096e1, Vector2 _0x6a61d29f, Vector2 _0x68573605, Vector2 _0xc70ce7b3, Sprite _0x83562708, Color _0x7c825637, Color _0x9f5589e1, TMP_FontAsset _0x9ddc0be8, string _0x9c256c78, float _0x17a177af, out TextMeshProUGUI _0xe2c8cf58, out Image _0xfe7d3d15)
    {
        RectTransform _0x8a32e8a7 = Node(_0x4b3431e8, _0xf8513477, _0xe0a096e1, _0x6a61d29f, _0x68573605, _0xc70ce7b3);
        Image _0x26ea953b = _0x8a32e8a7.gameObject.AddComponent<Image>();
        _0x26ea953b.color = new Color(0f, 0f, 0f, 0.004f);
        _0x26ea953b.raycastTarget = true;
        Plate(_0x8a32e8a7, _0x33d388e2._0xe450d17e(new byte[6] { 197, 254, 247, 242, 249, 225 }, 150), Vector2.zero, Vector2.one, new Vector2(0f, -8f), new Vector2(14f, 6f), _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.45f), null, false, 1f);
        _0xfe7d3d15 = Plate(_0x8a32e8a7, _0x33d388e2._0xe450d17e(new byte[4] { 166, 129, 131, 133 }, 224), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0x7c825637, _0x83562708, _0x83562708 != null, 2.2f);
        if (_0x83562708 != null)
        {
            _0xfe7d3d15.preserveAspect = false;
        }

        Plate(_0x8a32e8a7, _0x33d388e2._0xe450d17e(new byte[3] { 93, 102, 98 }, 15), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f), _0xda5d4a35.Fade(_0xda5d4a35._0x872a7f7e, 0.35f), null, false, 1f);
        _0xe2c8cf58 = Label(_0x8a32e8a7, _0x33d388e2._0xe450d17e(new byte[7] { 173, 143, 158, 154, 135, 129, 128 }, 238), _0x9ddc0be8, _0x9c256c78, _0x17a177af, _0x9f5589e1, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
        Button _0xe8979f53 = _0x8a32e8a7.gameObject.AddComponent<Button>();
        _0xe8979f53.targetGraphic = _0x26ea953b;
        _0xe8979f53.transition = Selectable.Transition.None;
        return _0xe8979f53;
    }

    public static Image Icon(Transform _0x2e419c0f, string _0x787442c3, Vector2 _0x98037cd9, Vector2 _0xbc8c37f0, Vector2 _0x4c56fdfd, float _0xdca23fca, Sprite _0x0805f8af, Color _0x9406ed6a)
    {
        RectTransform _0x21a270e5 = Node(_0x2e419c0f, _0x787442c3, _0x98037cd9, _0xbc8c37f0, _0x4c56fdfd, new Vector2(_0xdca23fca, _0xdca23fca));
        Image _0x3bd5b606 = _0x21a270e5.gameObject.AddComponent<Image>();
        _0x3bd5b606.sprite = _0x0805f8af;
        _0x3bd5b606.color = _0x9406ed6a;
        _0x3bd5b606.type = Image.Type.Simple;
        _0x3bd5b606.preserveAspect = true;
        _0x3bd5b606.raycastTarget = false;
        return _0x3bd5b606;
    }

    public const float FontFloor = 34f;
    public static void Press(RectTransform _0x8d94ec1a)
    {
        if (_0x8d94ec1a == null)
        {
            return;
        }

        DOTween.Kill(_0x8d94ec1a, true);
        _0x8d94ec1a.localScale = Vector3.one;
        _0x8d94ec1a.DOPunchScale(new Vector3(-0.045f, -0.045f, 0f), 0.16f, 1, 0.4f).SetLink(_0x8d94ec1a.gameObject);
    }

    public static RectTransform Node(Transform _0x31864a19, string _0x2d34c12d, Vector2 _0xb9c5c958, Vector2 _0x168375d9, Vector2 _0xfa575ccb, Vector2 _0x9b405616)
    {
        GameObject _0x5e2472f3 = new GameObject(_0x2d34c12d, typeof(RectTransform));
        RectTransform _0x59d7b7c6 = _0x5e2472f3.GetComponent<RectTransform>();
        _0x59d7b7c6.SetParent(_0x31864a19, false);
        _0x59d7b7c6.anchorMin = _0xb9c5c958;
        _0x59d7b7c6.anchorMax = _0x168375d9;
        _0x59d7b7c6.pivot = new Vector2(0.5f, 0.5f);
        _0x59d7b7c6.anchoredPosition = _0xfa575ccb;
        _0x59d7b7c6.sizeDelta = _0x9b405616;
        _0x59d7b7c6.localScale = Vector3.one;
        return _0x59d7b7c6;
    }

    public static Image Plate(Transform _0x4bb68d9b, string _0x870c0faa, Vector2 _0x43765dd0, Vector2 _0x632a9230, Vector2 _0x020536a2, Vector2 _0xb5c18ad9, Color _0xb7936fb0, Sprite _0x649f69b0, bool _0xda588f07, float _0x2f5ac626)
    {
        RectTransform _0xd29b393a = Node(_0x4bb68d9b, _0x870c0faa, _0x43765dd0, _0x632a9230, _0x020536a2, _0xb5c18ad9);
        Image _0x0a89755c = _0xd29b393a.gameObject.AddComponent<Image>();
        _0x0a89755c.color = _0xb7936fb0;
        _0x0a89755c.raycastTarget = false;
        if (_0x649f69b0 != null)
        {
            _0x0a89755c.sprite = _0x649f69b0;
            if (_0xda588f07)
            {
                _0x0a89755c.type = Image.Type.Sliced;
                _0x0a89755c.pixelsPerUnitMultiplier = _0x2f5ac626;
            }
            else
            {
                _0x0a89755c.type = Image.Type.Simple;
                _0x0a89755c.preserveAspect = true;
            }
        }

        return _0x0a89755c;
    }

    public static Image Fill(Transform _0x36e7dfa5, string _0x1ba14ae9, Color _0xbcae9a6d)
    {
        RectTransform _0x141811a7 = Stretch(_0x36e7dfa5, _0x1ba14ae9);
        Image _0x32103528 = _0x141811a7.gameObject.AddComponent<Image>();
        _0x32103528.color = _0xbcae9a6d;
        _0x32103528.raycastTarget = false;
        return _0x32103528;
    }

    public static RectTransform Stretch(Transform _0xa3fb6528, string _0x7a6bfdc5)
    {
        RectTransform _0xfb83e3c7 = Node(_0xa3fb6528, _0x7a6bfdc5, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
        _0xfb83e3c7.offsetMin = Vector2.zero;
        _0xfb83e3c7.offsetMax = Vector2.zero;
        return _0xfb83e3c7;
    }
}

internal static class _0x33d388e2
{
    internal static string _0xe450d17e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}