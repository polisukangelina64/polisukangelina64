using UnityEngine;

/// <summary>
/// Royal-salon palette. Values are exposed as properties, never as static readonly
/// fields, so no type initializer can depend on another one's order.
/// Text colours are only Cream / Mist / Gold / GoldDeep / Amber / JadeLite.
/// </summary>
public static class _0xda5d4a35
{
    public static Color _0x95ae19d8 => Rgb(0x1B, 0x13, 0x20, 1f);
    public static Color _0x872a7f7e => Rgb(0xF5, 0xD7, 0x7A, 1f);
    public static Color _0x41b9a3a1 => Rgb(0x7E, 0x22, 0xCE, 1f);
    public static Color _0xfff4ad6c => Rgb(0x3A, 0x26, 0x50, 1f);
    public static Color _0x5484003b => Rgb(0xD4, 0xAF, 0x37, 1f);
    public static Color _0x64f656bb => Rgb(0xFF, 0xF7, 0xED, 1f);

    public static Color Fade(Color _0x1712378b, float _0x044c4fed)
    {
        _0x1712378b.a = _0x044c4fed;
        return _0x1712378b;
    }

    public static Color _0xaa4124d5 => Rgb(0xFD, 0xBA, 0x74, 1f);
    public static Color _0x66b7573e => Rgb(0x2A, 0x1B, 0x36, 1f);
    public static Color _0xd4e968dd => Rgb(0x14, 0x0C, 0x1A, 1f);

    private static Color Rgb(int _0x5341e0c2, int _0x7da088be, int _0x71904d61, float _0x8496c6b8)
    {
        return new Color(_0x5341e0c2 / 255f, _0x7da088be / 255f, _0x71904d61 / 255f, _0x8496c6b8);
    }

    public static Color _0x048a938e => Rgb(0x4A, 0xDE, 0x80, 1f);
    public static Color _0x8a0e3d68 => Rgb(0xA8, 0x55, 0xF7, 1f);
    public static Color _0x16aaa4b1 => Rgb(0xFB, 0x92, 0x3C, 1f);
    public static Color _0x31eee6c9 => Rgb(0x16, 0xA3, 0x4A, 1f);
    public static Color _0x87d061a4 => Rgb(0xD8, 0xC8, 0xE6, 1f);
}