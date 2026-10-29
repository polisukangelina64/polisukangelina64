using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The casino lobby. Everything is drawn inside DefaultPanel/Content; the only template
/// object underneath is the scene-loading PLAY slot, whose face this view supplies.
/// No image here takes raycasts except the three navigation buttons, so taps fall
/// through to that slot.
/// </summary>
public sealed class _0x6e321f0b : MonoBehaviour
{
    private void _0xd2d13a9f(RectTransform _0xe11c0a55)
    {
        RectTransform _0xe5ec99d7 = _0xed2439e2.Node(_0xe11c0a55, _0x1e70e435._0x7d5203ae(new byte[6] { 199, 232, 255, 219, 230, 254 }, 137), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, NavCentreY), new Vector2(1120f, 150f));
        this._0x7be9be59 = this._0x9366ed10(_0xe5ec99d7, _0x1e70e435._0x7d5203ae(new byte[8] { 205, 226, 245, 199, 226, 234, 239, 250 }, 131), -NavSpacing, _0x1e70e435._0x7d5203ae(new byte[5] { 210, 215, 223, 218, 207 }, 150), 0);
        this._0x9366ed10(_0xe5ec99d7, _0x1e70e435._0x7d5203ae(new byte[8] { 151, 184, 175, 152, 181, 187, 172, 180 }, 217), 0f, _0x1e70e435._0x7d5203ae(new byte[5] { 104, 101, 107, 124, 100 }, 41), 1);
        this._0x9366ed10(_0xe5ec99d7, _0x1e70e435._0x7d5203ae(new byte[11] { 67, 108, 123, 94, 104, 121, 121, 100, 99, 106, 126 }, 13), NavSpacing, _0x1e70e435._0x7d5203ae(new byte[8] { 126, 104, 121, 121, 100, 99, 106, 126 }, 45), 2);
    }

    private long _0x3e8ebb21;
    public void _0x3ca9b54d()
    {
        if (this._0xa4b6748a == null)
        {
            return;
        }

        long _0x243f65da = this._0xa4b6748a._0x5476a7f6;
        if (this._0x544f11ff != null)
        {
            if (this._0x3e8ebb21 != _0x243f65da)
            {
                this._0xdddbf826(_0x243f65da);
            }
            else
            {
                this._0x544f11ff.text = _0xed2439e2.Money(_0x243f65da);
            }
        }

        if (this._0x82717099 != null)
        {
            this._0x82717099.text = this._0xa4b6748a._0x8ff2adc8(this._0xa4b6748a._0xcb5f5c39);
        }

        if (this._0x8225c372 != null)
        {
            this._0x8225c372.text = this._0xa4b6748a._0x699c56a8().ToString() + _0x1e70e435._0x7d5203ae(new byte[3] { 27, 7, 4 }, 52);
        }

        if (this._0xb10b4883 != null)
        {
            this._0xb10b4883.text = this._0xa4b6748a._0xcb5f5c39.ToString() + _0x1e70e435._0x7d5203ae(new byte[2] { 184, 163 }, 151);
        }

        if (this._0x34f700b6 != null)
        {
            this._0x34f700b6.text = this._0xa4b6748a._0x533c17db.ToString();
        }

        if (this._0x7be9be59 != null)
        {
            this._0x7be9be59.color = this._0xa4b6748a._0x2ba4c30d() ? _0xda5d4a35._0x048a938e : _0xda5d4a35.Fade(_0xda5d4a35._0x87d061a4, 0.25f);
        }

        if (this._0xdc2fe7da != null)
        {
            this._0xdc2fe7da._0x12c19f6c(this._0xa4b6748a._0xcb5f5c39);
        }

        if (this._0x8a7f50cf != null)
        {
            this._0x8a7f50cf._0xd8fc0921();
        }
    }

    private _0x06bd04c5 _0xf01dc2d4;
    public const float NavSpacing = 366f;
    private TextMeshProUGUI _0x544f11ff;
    private void _0x8d073626(RectTransform _0xee646aac)
    {
        RectTransform _0xc81c3008 = _0xed2439e2.Node(_0xee646aac, _0x1e70e435._0x7d5203ae(new byte[11] { 82, 113, 124, 113, 126, 115, 117, 64, 121, 124, 124 }, 16), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -210f), new Vector2(620f, 120f));
        _0xed2439e2.Plate(_0xc81c3008, _0x1e70e435._0x7d5203ae(new byte[10] { 152, 161, 164, 164, 155, 160, 169, 172, 167, 191 }, 200), Vector2.zero, Vector2.one, new Vector2(0f, -8f), Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.45f), null, false, 1f);
        _0xed2439e2.Plate(_0xc81c3008, _0x1e70e435._0x7d5203ae(new byte[8] { 155, 162, 167, 167, 142, 175, 172, 174 }, 203), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.95f), null, false, 1f);
        _0xed2439e2.Plate(_0xc81c3008, _0x1e70e435._0x7d5203ae(new byte[8] { 101, 92, 89, 89, 119, 90, 81, 76 }, 53), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-6f, -6f), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.95f), null, false, 1f);
        _0xed2439e2.Icon(_0xc81c3008, _0x1e70e435._0x7d5203ae(new byte[8] { 186, 131, 134, 134, 169, 133, 131, 132 }, 234), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(72f, 0f), 72f, this._0xf01dc2d4 != null ? this._0xf01dc2d4._0xef40aae3 : null, Color.white);
        this._0x544f11ff = _0xed2439e2.Label(_0xc81c3008, _0x1e70e435._0x7d5203ae(new byte[12] { 11, 40, 37, 40, 39, 42, 44, 31, 40, 37, 60, 44 }, 73), this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x533877f5 : null, _0x1e70e435._0x7d5203ae(new byte[1] { 108 }, 92), 72f, _0xda5d4a35._0x872a7f7e, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(360f, 10f), new Vector2(400f, 76f));
        _0xed2439e2.Label(_0xc81c3008, _0x1e70e435._0x7d5203ae(new byte[14] { 241, 210, 223, 210, 221, 208, 214, 240, 210, 195, 199, 218, 220, 221 }, 179), this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x533877f5 : null, _0x1e70e435._0x7d5203ae(new byte[5] { 34, 46, 40, 47, 50 }, 97), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Left, new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(300f, -34f), new Vector2(280f, 40f));
        _0xed2439e2.Label(_0xee646aac, _0x1e70e435._0x7d5203ae(new byte[10] { 143, 163, 161, 188, 160, 165, 173, 162, 175, 169 }, 204), this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x533877f5 : null, _0x1e70e435._0x7d5203ae(new byte[40] { 78, 90, 77, 77, 40, 94, 65, 90, 92, 93, 73, 68, 40, 75, 71, 65, 70, 91, 40, 37, 40, 70, 71, 40, 90, 77, 73, 68, 40, 69, 71, 70, 77, 81, 40, 37, 40, 57, 48, 35 }, 8), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -342f), new Vector2(1100f, 48f));
    }

    private _0x6759e2cf _0xa4b6748a;
    private _0x13f6594a _0x96aa2b52;
    /// <summary>
    /// The face of the template scene-loading slot. Drawn after it and with no raycast
    /// targets, so the slot keeps the tap and exactly one PLAY caption exists.
    /// </summary>
    private void _0xd6b49cc3(RectTransform _0x431662a9)
    {
        RectTransform _0x3c615061 = _0xed2439e2.Node(_0x431662a9, _0x1e70e435._0x7d5203ae(new byte[8] { 156, 160, 173, 181, 138, 173, 175, 169 }, 204), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, PlayCentreY), new Vector2(PlayWidth, PlayHeight));
        _0xed2439e2.Plate(_0x3c615061, _0x1e70e435._0x7d5203ae(new byte[10] { 11, 55, 58, 34, 8, 51, 58, 63, 52, 44 }, 91), Vector2.zero, Vector2.one, new Vector2(0f, -10f), Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.5f), null, false, 1f);
        Image _0x7e98bdab = _0xed2439e2.Plate(_0x3c615061, _0x1e70e435._0x7d5203ae(new byte[9] { 57, 5, 8, 16, 57, 5, 8, 29, 12 }, 105), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35._0x16aaa4b1, null, false, 1f);
        _0xed2439e2.Plate(_0x3c615061, _0x1e70e435._0x7d5203ae(new byte[9] { 96, 92, 81, 73, 121, 94, 94, 85, 66 }, 48), Vector2.zero, Vector2.one, new Vector2(0f, -6f), new Vector2(-10f, -18f), _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.85f), null, false, 1f);
        _0xed2439e2.Plate(_0x3c615061, _0x1e70e435._0x7d5203ae(new byte[7] { 64, 124, 113, 105, 66, 121, 125 }, 16), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0f, -6f), new Vector2(-16f, 4f), _0xda5d4a35.Fade(_0xda5d4a35._0x872a7f7e, 0.9f), null, false, 1f);
        _0xed2439e2.Label(_0x3c615061, _0x1e70e435._0x7d5203ae(new byte[11] { 240, 204, 193, 217, 227, 193, 208, 212, 201, 207, 206 }, 160), this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x533877f5 : null, _0x1e70e435._0x7d5203ae(new byte[4] { 245, 233, 228, 252 }, 165), 72f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
        this._0xb81c81cc = _0x7e98bdab.rectTransform;
        this._0xb81c81cc.DOScale(1.02f, 1.1f).SetLoops(-1, LoopType.Yoyo).SetLink(this._0xb81c81cc.gameObject);
        _0xed2439e2.Label(_0x431662a9, _0x1e70e435._0x7d5203ae(new byte[12] { 170, 134, 135, 157, 155, 134, 133, 154, 161, 128, 135, 157 }, 233), this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x533877f5 : null, _0x1e70e435._0x7d5203ae(new byte[26] { 248, 237, 252, 140, 252, 224, 237, 245, 140, 248, 227, 140, 255, 252, 229, 226, 140, 248, 228, 233, 140, 254, 233, 233, 224, 255 }, 172), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, 170f), new Vector2(1000f, 46f));
    }

    private void _0xb39125bb(RectTransform _0x58aff0b9)
    {
        RectTransform _0x485f84ed = _0xed2439e2.Node(_0x58aff0b9, _0x1e70e435._0x7d5203ae(new byte[7] { 92, 123, 110, 123, 93, 96, 120 }, 15), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -1550f), new Vector2(1060f, 140f));
        this._0x8225c372 = this._0x6f2da0bd(_0x485f84ed, _0x1e70e435._0x7d5203ae(new byte[9] { 150, 177, 164, 168, 181, 150, 177, 164, 177 }, 197), -356f, _0x1e70e435._0x7d5203ae(new byte[6] { 207, 200, 221, 209, 204, 207 }, 156), _0xda5d4a35._0x872a7f7e);
        this._0xb10b4883 = this._0x6f2da0bd(_0x485f84ed, _0x1e70e435._0x7d5203ae(new byte[8] { 182, 139, 139, 137, 183, 144, 133, 144 }, 228), 0f, _0x1e70e435._0x7d5203ae(new byte[5] { 190, 163, 163, 161, 191 }, 236), _0xda5d4a35._0x048a938e);
        this._0x34f700b6 = this._0x6f2da0bd(_0x485f84ed, _0x1e70e435._0x7d5203ae(new byte[11] { 175, 153, 143, 143, 149, 147, 146, 175, 136, 157, 136 }, 252), 356f, _0x1e70e435._0x7d5203ae(new byte[6] { 84, 75, 81, 75, 86, 81 }, 2), _0xda5d4a35._0x16aaa4b1);
    }

    private RectTransform _0xb81c81cc;
    private TextMeshProUGUI _0x8225c372;
    private void _0x78dfaec8(RectTransform _0xa084e240)
    {
        RectTransform _0x45c6e3b1 = _0xed2439e2.Node(_0xa084e240, _0x1e70e435._0x7d5203ae(new byte[11] { 19, 55, 45, 45, 55, 49, 48, 29, 63, 44, 58 }, 94), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -1285f), new Vector2(1060f, 390f));
        _0xed2439e2.Plate(_0x45c6e3b1, _0x1e70e435._0x7d5203ae(new byte[10] { 214, 244, 231, 241, 198, 253, 244, 241, 250, 226 }, 149), Vector2.zero, Vector2.one, new Vector2(0f, -10f), Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.5f), null, false, 1f);
        _0xed2439e2.Plate(_0x45c6e3b1, _0x1e70e435._0x7d5203ae(new byte[8] { 17, 51, 32, 54, 23, 54, 53, 55 }, 82), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.95f), null, false, 1f);
        _0xed2439e2.Plate(_0x45c6e3b1, _0x1e70e435._0x7d5203ae(new byte[8] { 37, 7, 20, 2, 36, 9, 2, 31 }, 102), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.96f), null, false, 1f);
        _0xed2439e2.Plate(_0x45c6e3b1, _0x1e70e435._0x7d5203ae(new byte[9] { 77, 111, 124, 106, 93, 102, 107, 107, 96 }, 14), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0f, -60f), new Vector2(-24f, 110f), _0xda5d4a35.Fade(_0xda5d4a35._0x8a0e3d68, 0.12f), null, false, 1f);
        this._0x8a7f50cf = this.gameObject.AddComponent<_0x4bf4a866>();
        this._0x8a7f50cf._0x36fa9a8d(_0x45c6e3b1, this._0xa4b6748a, this._0xf01dc2d4);
    }

    private TextMeshProUGUI _0x34f700b6;
    public const float PlayHeight = 176f;
    private Image _0x7be9be59;
    public void _0xeb310a76(RectTransform _0x98463140, _0x6759e2cf _0x21e41829, _0x06bd04c5 _0x7adb183f, _0x13f6594a _0x12b575b2)
    {
        this._0xa4b6748a = _0x21e41829;
        this._0xf01dc2d4 = _0x7adb183f;
        this._0x96aa2b52 = _0x12b575b2;
        RectTransform _0x32e1c77f = _0xed2439e2.Stretch(_0x98463140, _0x1e70e435._0x7d5203ae(new byte[9] { 230, 197, 200, 200, 211, 252, 195, 207, 221 }, 170));
        this._0x83c7e9c4(_0x32e1c77f);
        this._0x8d073626(_0x32e1c77f);
        this._0xb06f39f8(_0x32e1c77f);
        this._0x78dfaec8(_0x32e1c77f);
        this._0xb39125bb(_0x32e1c77f);
        this._0xd6b49cc3(_0x32e1c77f);
        this._0xd2d13a9f(_0x32e1c77f);
        this._0x3ca9b54d();
    }

    private void _0xdee83694(float _0x3d4f4631)
    {
        if (this._0x544f11ff != null)
        {
            this._0x544f11ff.text = _0xed2439e2.Money((long)_0x3d4f4631);
        }
    }

    private TextMeshProUGUI _0x82717099;
    private RectTransform _0x6c04a6c1;
    private Image _0x9366ed10(RectTransform _0x201ee3f2, string _0xc1dd93a7, float _0x2e40b8bd, string _0xe019eeb8, int _0x9b3a2124)
    {
        TextMeshProUGUI _0xf5a25a80;
        Image _0x39ea4ad4;
        Button _0xfca7c0d8 = _0xed2439e2.Cta(_0x201ee3f2, _0xc1dd93a7, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(_0x2e40b8bd, 0f), new Vector2(340f, 150f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.96f), _0xda5d4a35._0x64f656bb, this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x533877f5 : null, _0xe019eeb8, 44f, out _0xf5a25a80, out _0x39ea4ad4);
        Image _0xffd7aadb = _0xed2439e2.Plate(_0xfca7c0d8.transform as RectTransform, _0x1e70e435._0x7d5203ae(new byte[5] { 142, 173, 168, 171, 169 }, 204), new Vector2(1f, 1f), new Vector2(1f, 1f), new Vector2(-26f, -22f), new Vector2(18f, 18f), _0xda5d4a35.Fade(_0xda5d4a35._0x87d061a4, 0.25f), null, false, 1f);
        int _0x59a0723e = _0x9b3a2124;
        _0xfca7c0d8.onClick.AddListener(() => this._0x1b0dabd8(_0x59a0723e, _0xfca7c0d8));
        return _0xffd7aadb;
    }

    public const float PlayWidth = 760f;
    private void _0xb06f39f8(RectTransform _0xf0a69d8a)
    {
        RectTransform _0xd8e8e46b = _0xed2439e2.Node(_0xf0a69d8a, _0x1e70e435._0x7d5203ae(new byte[11] { 99, 75, 68, 74, 67, 75, 100, 74, 73, 69, 77 }, 38), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -700f), new Vector2(680f, 560f));
        _0xed2439e2.Plate(_0xd8e8e46b, _0x1e70e435._0x7d5203ae(new byte[10] { 153, 177, 190, 176, 185, 177, 155, 176, 179, 171 }, 220), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(640f, 640f), _0xda5d4a35.Fade(_0xda5d4a35._0x41b9a3a1, 0.35f), this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x62eb50b4 : null, false, 1f);
        Image _0xe76667f1 = _0xed2439e2.Plate(_0xd8e8e46b, _0x1e70e435._0x7d5203ae(new byte[6] { 139, 163, 172, 162, 171, 163 }, 206), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(460f, 460f), Color.white, this._0xf01dc2d4 != null ? this._0xf01dc2d4._0xe07d1da7 : null, false, 1f);
        this._0x6c04a6c1 = _0xe76667f1.rectTransform;
        this._0x6c04a6c1.DORotate(new Vector3(0f, 0f, 2.5f), 2.6f).SetLoops(-1, LoopType.Yoyo).SetLink(this._0x6c04a6c1.gameObject);
        RectTransform _0x715c9ccd = _0xed2439e2.Node(_0xf0a69d8a, _0x1e70e435._0x7d5203ae(new byte[10] { 219, 230, 230, 228, 219, 224, 235, 235, 230, 231 }, 137), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -1010f), new Vector2(560f, 76f));
        _0xed2439e2.Plate(_0x715c9ccd, _0x1e70e435._0x7d5203ae(new byte[11] { 160, 155, 144, 144, 157, 156, 162, 158, 147, 134, 151 }, 242), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.25f), null, false, 1f);
        this._0x82717099 = _0xed2439e2.Label(_0x715c9ccd, _0x1e70e435._0x7d5203ae(new byte[10] { 172, 151, 156, 156, 145, 144, 170, 155, 134, 138 }, 254), this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x533877f5 : null, _0x1e70e435._0x7d5203ae(new byte[19] { 5, 24, 24, 26, 119, 102, 119, 122, 119, 7, 27, 2, 26, 119, 4, 22, 27, 24, 25 }, 87), 44f, _0xda5d4a35._0x872a7f7e, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
    }

    private _0x4bf4a866 _0x8a7f50cf;
    private void OnDestroy()
    {
        if (this._0x6c04a6c1 != null)
        {
            DOTween.Kill(this._0x6c04a6c1);
        }

        if (this._0xb81c81cc != null)
        {
            DOTween.Kill(this._0xb81c81cc);
        }
    }

    public const float NavCentreY = 560f;
    public const float PlayCentreY = 900f;
    private void _0xdddbf826(long _0xf5a84b69)
    {
        long _0xe92f73d6 = this._0x3e8ebb21;
        this._0x3e8ebb21 = _0xf5a84b69;
        DOTween.To(() => (float)_0xe92f73d6, _0x77eec657 => this._0xdee83694(_0x77eec657), _0xf5a84b69, 0.7f).SetLink(this.gameObject);
    }

    private TextMeshProUGUI _0xb10b4883;
    /// <summary>
    /// The drape art is drawn facing LEFT; the right-hand copy is mirrored on x, which is
    /// a deliberate flip of an asymmetric sprite (C.8).
    /// </summary>
    private Image _0x4af1cc3a(RectTransform _0xe57fe35b, string _0x0cd99b9b, Vector2 _0x2d0f9d72, Vector2 _0x8098338b, bool _0xcff8bfb1)
    {
        RectTransform _0x7650bad2 = _0xed2439e2.Node(_0xe57fe35b, _0x0cd99b9b, _0x2d0f9d72, _0x2d0f9d72, _0x8098338b, new Vector2(340f, 1900f));
        Image _0xbe985da8 = _0x7650bad2.gameObject.AddComponent<Image>();
        _0xbe985da8.sprite = this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x9bfff5f8 : null;
        // 9-slice: the drape is drawn far taller than its square source, so only the
        // middle band may stretch. preserveAspect would break the slicing.
        _0xbe985da8.type = Image.Type.Sliced;
        _0xbe985da8.pixelsPerUnitMultiplier = 1f;
        _0xbe985da8.preserveAspect = false;
        _0xbe985da8.raycastTarget = false;
        if (_0xcff8bfb1)
        {
            _0x7650bad2.localScale = new Vector3(-1f, 1f, 1f);
        }

        return _0xbe985da8;
    }

    private TextMeshProUGUI _0x6f2da0bd(RectTransform _0x67e0d4ff, string _0xf68f2fae, float _0x3ebd7521, string _0xf45ec6bf, Color _0x7532e449)
    {
        RectTransform _0x2fac5861 = _0xed2439e2.Node(_0x67e0d4ff, _0xf68f2fae, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(_0x3ebd7521, 0f), new Vector2(330f, 130f));
        _0xed2439e2.Plate(_0x2fac5861, _0x1e70e435._0x7d5203ae(new byte[8] { 128, 167, 178, 167, 150, 183, 180, 182 }, 211), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0x7532e449, 0.55f), null, false, 1f);
        _0xed2439e2.Plate(_0x2fac5861, _0x1e70e435._0x7d5203ae(new byte[8] { 173, 138, 159, 138, 188, 145, 154, 135 }, 254), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-5f, -5f), _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.92f), null, false, 1f);
        _0xed2439e2.Plate(_0x2fac5861, _0x1e70e435._0x7d5203ae(new byte[7] { 155, 188, 169, 188, 140, 167, 188 }, 200), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -16f), new Vector2(10f, 10f), _0x7532e449, null, false, 1f);
        TextMeshProUGUI _0xdd46d61a = _0xed2439e2.Label(_0x2fac5861, _0x1e70e435._0x7d5203ae(new byte[9] { 169, 142, 155, 142, 172, 155, 150, 143, 159 }, 250), this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x533877f5 : null, _0x1e70e435._0x7d5203ae(new byte[1] { 94 }, 110), 56f, _0x7532e449, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, 10f), new Vector2(290f, 60f));
        _0xed2439e2.Label(_0x2fac5861, _0x1e70e435._0x7d5203ae(new byte[11] { 125, 90, 79, 90, 109, 79, 94, 90, 71, 65, 64 }, 46), this._0xf01dc2d4 != null ? this._0xf01dc2d4._0x533877f5 : null, _0xf45ec6bf, 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -40f), new Vector2(290f, 40f));
        return _0xdd46d61a;
    }

    private void _0x1b0dabd8(int _0x685f1429, Button _0x0bef5bf3)
    {
        _0xed2439e2.Press(_0x0bef5bf3.transform as RectTransform);
        if (this._0x96aa2b52 != null)
        {
            this._0x96aa2b52._0x3e8282a5(_0x685f1429);
        }
    }

    private void _0x83c7e9c4(RectTransform _0xa1e25f43)
    {
        Image _0xac317800 = _0xed2439e2.Fill(_0xa1e25f43, _0x1e70e435._0x7d5203ae(new byte[8] { 73, 116, 116, 118, 76, 122, 104, 115 }, 27), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.42f));
        Image _0x985398bb = this._0x4af1cc3a(_0xa1e25f43, _0x1e70e435._0x7d5203ae(new byte[9] { 34, 20, 7, 22, 3, 42, 3, 0, 18 }, 102), new Vector2(0f, 1f), new Vector2(170f, -950f), false);
        Image _0xe6f2484f = this._0x4af1cc3a(_0xa1e25f43, _0x1e70e435._0x7d5203ae(new byte[10] { 141, 187, 168, 185, 172, 155, 160, 174, 161, 189 }, 201), new Vector2(1f, 1f), new Vector2(-170f, -950f), true);
        Image _0xa28b209d = _0xed2439e2.Plate(_0xa1e25f43, _0x1e70e435._0x7d5203ae(new byte[10] { 203, 231, 250, 230, 237, 250, 220, 250, 225, 229 }, 136), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0f, -8f), new Vector2(0f, 10f), _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.9f), null, false, 1f);
        this._0xdc2fe7da = this.gameObject.AddComponent<_0xf9f01863>();
        this._0xdc2fe7da._0x62bfb063(_0xac317800, _0x985398bb, _0xe6f2484f, _0xa28b209d);
    }

    private _0xf9f01863 _0xdc2fe7da;
}

internal static class _0x1e70e435
{
    internal static string _0x7d5203ae(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}