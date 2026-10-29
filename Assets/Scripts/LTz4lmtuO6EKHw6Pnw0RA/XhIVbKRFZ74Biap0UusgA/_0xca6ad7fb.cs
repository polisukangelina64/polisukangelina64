using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xca6ad7fb : MonoBehaviour
{
    private static bool _0x326587cc;
    private static void ApplySafeAreaToAll()
    {
        for (int _0xb2717bfc = 0; _0xb2717bfc < _0xe5c7279b.Count; _0xb2717bfc++)
            _0xe5c7279b[_0xb2717bfc]._0x4cef0641();
    }

    private void Start()
    {
    }

    private RectTransform _0x2e1e5d38;
    private Vector2 _0xba40dd50;
    private RectTransform _0x02f1b348;
    private static void SafeAreaChanged()
    {
        _0x503f89da = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private void OnDestroy()
    {
        if (_0xe5c7279b != null && _0xe5c7279b.Contains(this))
            _0xe5c7279b.Remove(this);
    }

    private void Awake()
    {
        if (!_0xe5c7279b.Contains(this))
            _0xe5c7279b.Add(this);
        this._0xacf577fa = this.GetComponent<Canvas>();
        this._0xf18ea959 = this.GetComponent<CanvasScaler>();
        if (this._0xf18ea959 != null)
            this._0xba40dd50 = this._0xf18ea959.referenceResolution;
        this._0x2e1e5d38 = this.GetComponent<RectTransform>();
        this._0x02f1b348 = this.transform.Find(_0x40e0486f._0xbab745b1(new byte[8] { 69, 119, 112, 115, 87, 100, 115, 119 }, 22)) as RectTransform;
        if (!_0x326587cc)
        {
            _0xa417c74d = Screen.orientation;
            _0x897534a3.x = Screen.width;
            _0x897534a3.y = Screen.height;
            _0x503f89da = Screen.safeArea;
            _0x326587cc = true;
        }

        this._0x4cef0641();
    }

    private static void ResolutionChanged()
    {
        _0x897534a3.x = Screen.width;
        _0x897534a3.y = Screen.height;
        _0x503f89da = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x9184f977.Invoke();
    }

    private static void OrientationChanged()
    {
        _0xa417c74d = Screen.orientation;
        _0x897534a3.x = Screen.width;
        _0x897534a3.y = Screen.height;
        _0x503f89da = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x9184f977.Invoke();
    }

    private static Rect _0x503f89da = Rect.zero;
    private static ScreenOrientation _0xa417c74d = ScreenOrientation.LandscapeLeft;
    private Canvas _0xacf577fa;
    private static UnityEvent _0x9184f977 = new();
    private static Vector2 _0x897534a3 = Vector2.zero;
    private void _0x4cef0641()
    {
        if (this._0x02f1b348 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x25b648c6 = Screen.safeArea;
        Vector2 _0x57586fdb = _0x25b648c6.position;
        Vector2 _0xdf741063 = _0x25b648c6.position + _0x25b648c6.size;
        _0x57586fdb.x /= screenWidth;
        _0x57586fdb.y /= screenHeight;
        _0xdf741063.x /= screenWidth;
        _0xdf741063.y /= screenHeight;
        this._0x02f1b348.anchorMin = _0x57586fdb;
        this._0x02f1b348.anchorMax = _0xdf741063;
        this._0x02f1b348.offsetMin = Vector2.zero;
        this._0x02f1b348.offsetMax = Vector2.zero;
        if (this._0xf18ea959 == null)
            return;
        Vector2 _0xf108ddda = _0xdf741063 - _0x57586fdb;
        float _0x00645876 = 2f - _0xf108ddda.x;
        float _0xb133762d = 2f - _0xf108ddda.y;
        this._0xf18ea959.referenceResolution = this._0xba40dd50 * new Vector2(_0x00645876, _0xb133762d);
    }

    private static readonly List<_0xca6ad7fb> _0xe5c7279b = new();
    private CanvasScaler _0xf18ea959;
    private void Update()
    {
        if (_0xe5c7279b.Count == 0 || _0xe5c7279b[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xa417c74d)
            OrientationChanged();
        if (Screen.safeArea != _0x503f89da)
            SafeAreaChanged();
        if (Screen.width != _0x897534a3.x || Screen.height != _0x897534a3.y)
            ResolutionChanged();
    }
}

internal static class _0x40e0486f
{
    internal static string _0xbab745b1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}