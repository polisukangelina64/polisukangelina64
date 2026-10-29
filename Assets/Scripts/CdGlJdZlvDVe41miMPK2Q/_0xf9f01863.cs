using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The decorative room the player has unlocked: it retints the lobby wash, the curtains
/// and the trim, so completing an album set is visible on the lobby itself.
/// </summary>
public sealed class _0xf9f01863 : MonoBehaviour
{
    private Image _0x25552139;
    public void _0x12c19f6c(int _0x414884bf)
    {
        Color _0x6edeb323 = this._0xbc330d2d(_0x414884bf);
        Color _0x8554c6a5 = this._0xa33d3c97(_0x414884bf);
        Color _0xea49df85 = _0x414884bf <= 1 ? _0xda5d4a35._0x5484003b : _0xda5d4a35._0x872a7f7e;
        if (this._0x25552139 != null)
        {
            this._0x25552139.color = _0xda5d4a35.Fade(_0x6edeb323, 0.42f);
        }

        if (this._0x0f804786 != null)
        {
            this._0x0f804786.color = _0x8554c6a5;
        }

        if (this._0x87f03ec1 != null)
        {
            this._0x87f03ec1.color = _0x8554c6a5;
        }

        if (this._0x5e042d03 != null)
        {
            this._0x5e042d03.color = _0xda5d4a35.Fade(_0xea49df85, 0.9f);
        }
    }

    private Image _0x0f804786;
    private Image _0x87f03ec1;
    private Color _0xa33d3c97(int _0x1957acb1)
    {
        switch (Mathf.Clamp(_0x1957acb1, 1, _0x6759e2cf.RoomCount))
        {
            case 1:
                return _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f);
            case 2:
                return _0xda5d4a35.Fade(_0xda5d4a35._0xaa4124d5, 0.9f);
            case 3:
                return _0xda5d4a35.Fade(_0xda5d4a35._0x048a938e, 0.85f);
            default:
                return _0xda5d4a35.Fade(_0xda5d4a35._0x8a0e3d68, 0.9f);
        }
    }

    public void _0x62bfb063(Image _0x4bc4acd8, Image _0x529c2068, Image _0xa8debbe1, Image _0x8fa189f8)
    {
        this._0x25552139 = _0x4bc4acd8;
        this._0x0f804786 = _0x529c2068;
        this._0x87f03ec1 = _0xa8debbe1;
        this._0x5e042d03 = _0x8fa189f8;
    }

    private Image _0x5e042d03;
    private Color _0xbc330d2d(int _0xd4555c78)
    {
        switch (Mathf.Clamp(_0xd4555c78, 1, _0x6759e2cf.RoomCount))
        {
            case 1:
                return _0xda5d4a35._0x66b7573e;
            case 2:
                return _0xda5d4a35._0x16aaa4b1;
            case 3:
                return _0xda5d4a35._0x31eee6c9;
            default:
                return _0xda5d4a35._0x41b9a3a1;
        }
    }
}