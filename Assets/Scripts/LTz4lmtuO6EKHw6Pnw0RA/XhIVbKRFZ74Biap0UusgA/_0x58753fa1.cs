using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x58753fa1 : MonoBehaviour
{
    private void OnDestroy()
    {
        if (_0xbfd877a6 != null && _0xbfd877a6.Contains(this))
            _0xbfd877a6.Remove(this);
    }

    private void _0x84480097()
    {
        if (this._0x5cfbc1cd == null)
            return;
        Rect _0xdfa1a4e4 = Screen.safeArea;
        Vector2 _0x1d9e6090 = _0xdfa1a4e4.position;
        Vector2 _0x4b90ba54 = _0xdfa1a4e4.position + _0xdfa1a4e4.size;
        _0x1d9e6090.x /= this._0xb09c2a4c.pixelRect.width;
        _0x1d9e6090.y /= this._0xb09c2a4c.pixelRect.height;
        _0x4b90ba54.x /= this._0xb09c2a4c.pixelRect.width;
        _0x4b90ba54.y /= this._0xb09c2a4c.pixelRect.height;
        this._0x5cfbc1cd.anchorMin = _0x1d9e6090;
        this._0x5cfbc1cd.anchorMax = _0x4b90ba54;
    }

    private RectTransform _0x5cfbc1cd;
    private Canvas _0xb09c2a4c;
    private static ScreenOrientation _0xef48b8a4 = ScreenOrientation.LandscapeLeft;
    private void Awake()
    {
        if (!_0xbfd877a6.Contains(this))
            _0xbfd877a6.Add(this);
        this._0xb09c2a4c = this.GetComponent<Canvas>();
        this._0x9451ec46 = this.GetComponent<RectTransform>();
        this._0x5cfbc1cd = this.transform.Find(_0xec72cb5a._0x1c0cd9eb(new byte[8] { 132, 182, 177, 178, 150, 165, 178, 182 }, 215)) as RectTransform;
        if (!_0x81b40903)
        {
            _0xef48b8a4 = Screen.orientation;
            _0xcf23a411.x = Screen.width;
            _0xcf23a411.y = Screen.height;
            _0xc262885c = Screen.safeArea;
            _0x81b40903 = true;
        }

        this._0x84480097();
    }

    private static void SafeAreaChanged()
    {
        _0xc262885c = Screen.safeArea;
        for (int _0x8972855d = 0; _0x8972855d < _0xbfd877a6.Count; _0x8972855d++)
            _0xbfd877a6[_0x8972855d]._0x84480097();
    }

    private static Rect _0xc262885c = Rect.zero;
    private static void OrientationChanged()
    {
        _0xef48b8a4 = Screen.orientation;
        _0xcf23a411.x = Screen.width;
        _0xcf23a411.y = Screen.height;
        _0x457114be.Invoke();
    }

    private static Vector2 _0xcf23a411 = Vector2.zero;
    private RectTransform _0x9451ec46;
    private void Update()
    {
        if (_0xbfd877a6[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xef48b8a4)
            OrientationChanged();
        if (Screen.safeArea != _0xc262885c)
            SafeAreaChanged();
        if (Screen.width != _0xcf23a411.x || Screen.height != _0xcf23a411.y)
            ResolutionChanged();
    }

    private static readonly List<_0x58753fa1> _0xbfd877a6 = new();
    private static UnityEvent _0x457114be = new();
    private static void ResolutionChanged()
    {
        _0xcf23a411.x = Screen.width;
        _0xcf23a411.y = Screen.height;
        _0x457114be.Invoke();
    }

    private static bool _0x81b40903;
}

internal static class _0xec72cb5a
{
    internal static string _0x1c0cd9eb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}