using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The reels screen. Geometry is derived from the board width rather than eyeballed:
/// five columns, four gutters and two frame insets add up to the housing exactly.
/// </summary>
public sealed class _0xc3ef787a : MonoBehaviour
{
    public const float BoardWidth = 1118f;
    public void _0x3a93d952(RectTransform _0xd14767c3, _0x6759e2cf _0xc803ae85, _0x06bd04c5 _0x2af377a0, _0xc67ab774 _0xb2ad3cab)
    {
        this._0xf6c75ec0 = _0xc803ae85;
        this._0xb5317d50 = _0x2af377a0;
        this._0xc3737823 = _0xb2ad3cab;
        this._0x66b4a511 = new _0xc19b7c1c()._0xf1b18ae5((_0xc803ae85._0x533c17db * 7919) ^ 104729);
        float _0xb0f5f11f = CellHeight + Gutter;
        for (int _0x13e91d9f = 0; _0x13e91d9f < _0xc19b7c1c.Reels; _0x13e91d9f++)
        {
            this._0xa3eaf963[_0x13e91d9f] = -(BoardWidth * 0.5f) + Frame + (CellWidth * 0.5f) + (_0x13e91d9f * (CellWidth + Gutter));
        }

        for (int _0xcdbd4c51 = 0; _0xcdbd4c51 < _0xc19b7c1c.Rows; _0xcdbd4c51++)
        {
            this._0x97a4f923[_0xcdbd4c51] = (1 - _0xcdbd4c51) * _0xb0f5f11f;
        }

        RectTransform _0x1e5e7799 = _0xed2439e2.Stretch(_0xd14767c3, _0xaae1c97c._0x8d1f2a59(new byte[9] { 139, 188, 188, 181, 170, 143, 176, 188, 174 }, 217));
        _0xed2439e2.Fill(_0x1e5e7799, _0xaae1c97c._0x8d1f2a59(new byte[8] { 189, 155, 151, 159, 173, 155, 137, 146 }, 250), _0xda5d4a35.Fade(_0xda5d4a35._0x95ae19d8, 0.45f));
        this._0x1add31df(_0x1e5e7799);
        this._0x3098ec5e(_0x1e5e7799);
        this._0x761b269e(_0x1e5e7799);
        this._0x1cd3a045(_0x1e5e7799);
        this._0x2d67c037(_0x1e5e7799);
        this._0x055909e1(_0x1e5e7799);
        this._0xffeec679(_0x1e5e7799);
        this._0x8ab236d9(_0x1e5e7799);
        _0xed2439e2.Label(_0x1e5e7799, _0xaae1c97c._0x8d1f2a59(new byte[9] { 0, 55, 55, 62, 33, 26, 59, 60, 38 }, 82), _0x2af377a0 != null ? _0x2af377a0._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[48] { 120, 109, 124, 12, 127, 124, 101, 98, 12, 1, 12, 106, 101, 122, 105, 12, 106, 101, 116, 105, 104, 12, 96, 101, 98, 105, 127, 12, 1, 12, 106, 126, 105, 105, 12, 122, 101, 126, 120, 121, 109, 96, 12, 111, 99, 101, 98, 127 }, 44), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, 150f), new Vector2(1100f, 46f));
        this._0x0794fd54 = this.gameObject.AddComponent<_0x2ea6a731>();
        this._0x0794fd54._0x9fcd27d9(_0xd14767c3, this._0x66b4a511, _0x2af377a0);
        this._0xb0b3c7f1 = this.gameObject.AddComponent<_0x5de4a448>();
        this._0xb0b3c7f1._0x4ccb2d1d(this, this._0x0439e27d, this._0x66b4a511, _0xc803ae85, this._0xba40f927, _0xb2ad3cab);
        if (_0xb2ad3cab != null)
        {
            _0xb2ad3cab._0x2e82618c(this._0xb0b3c7f1, this);
        }

        this._0x7d148cfa(_0xc803ae85._0x5476a7f6);
        this._0x34cfb619(_0xc803ae85._0xfbdf25e9);
        this._0x0afdf0a3(_0xc803ae85);
        this._0x3dce6d09(_0xaae1c97c._0x8d1f2a59(new byte[26] { 157, 136, 153, 233, 154, 153, 128, 135, 233, 157, 134, 233, 153, 133, 136, 144, 233, 228, 233, 252, 233, 133, 128, 135, 140, 154 }, 201), _0xda5d4a35._0x87d061a4, 44f);
        this._0xee1aa78e(0);
    }

    private void _0x055909e1(RectTransform _0x2978c721)
    {
        RectTransform _0xbadcaab8 = _0xed2439e2.Node(_0x2978c721, _0xaae1c97c._0x8d1f2a59(new byte[13] { 57, 20, 6, 1, 38, 5, 28, 27, 38, 1, 7, 28, 5 }, 117), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -1790f), new Vector2(900f, 96f));
        _0xed2439e2.Plate(_0xbadcaab8, _0xaae1c97c._0x8d1f2a59(new byte[9] { 37, 8, 26, 29, 57, 5, 8, 29, 12 }, 105), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.55f), null, false, 1f);
        this._0x1ab3ee57 = _0xed2439e2.Label(_0xbadcaab8, _0xaae1c97c._0x8d1f2a59(new byte[8] { 71, 106, 120, 127, 95, 110, 115, 127 }, 11), this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[12] { 174, 163, 177, 182, 194, 177, 178, 171, 172, 194, 194, 207 }, 226), 44f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
    }

    public const float BackX = -470f;
    private Image _0x3f492796;
    public const float SpinCentreY = 320f;
    public void _0x3dce6d09(string _0x8a53a160, Color _0xf94c448b, float _0x729a8ddd)
    {
        if (this._0xedee67b7 == null)
        {
            return;
        }

        this._0xedee67b7.text = _0x8a53a160;
        this._0xedee67b7.color = _0xf94c448b;
        this._0xedee67b7.fontSizeMax = Mathf.Max(_0x729a8ddd, _0xed2439e2.FontFloor);
        _0x327dba82.ApplyOutline(this._0xedee67b7);
    }

    public void _0x0afdf0a3(_0x6759e2cf _0x61b47013)
    {
        if (this._0x5013a63e == null || _0x61b47013 == null)
        {
            return;
        }

        for (int _0x9081c7ba = 0; _0x9081c7ba < _0x6759e2cf.MissionCount; _0x9081c7ba++)
        {
            int _0x469a225c = _0x61b47013._0x20b3c391(_0x9081c7ba);
            int _0x13a7f697 = _0x61b47013._0x626f4d0c(_0x9081c7ba);
            if (_0x469a225c < _0x13a7f697)
            {
                this._0x5013a63e.text = _0x61b47013._0x6d01ec7a(_0x9081c7ba) + _0xaae1c97c._0x8d1f2a59(new byte[2] { 54, 54 }, 22) + _0x469a225c.ToString() + _0xaae1c97c._0x8d1f2a59(new byte[1] { 246 }, 217) + _0x13a7f697.ToString();
                return;
            }
        }

        this._0x5013a63e.text = _0xaae1c97c._0x8d1f2a59(new byte[33] { 71, 74, 74, 38, 75, 79, 85, 85, 79, 73, 72, 85, 38, 66, 73, 72, 67, 38, 43, 38, 77, 67, 67, 86, 38, 85, 86, 79, 72, 72, 79, 72, 65 }, 6);
    }

    private void _0xefec9f20(int _0x6ddf01ce)
    {
        if (this._0xb0b3c7f1 != null)
        {
            this._0xb0b3c7f1._0xa17abe06(_0x6ddf01ce);
        }
    }

    private RectTransform _0x1af25f71;
    private readonly float[] _0x97a4f923 = new float[_0xc19b7c1c.Rows];
    private TextMeshProUGUI _0xedee67b7;
    public const float PauseX = 470f;
    public const float CellHeight = 260f;
    private void _0xffeec679(RectTransform _0x79f30ab0)
    {
        RectTransform _0x7e6e0485 = _0xed2439e2.Node(_0x79f30ab0, _0xaae1c97c._0x8d1f2a59(new byte[6] { 81, 118, 103, 65, 124, 100 }, 19), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, BetCentreY), new Vector2(1000f, 130f));
        TextMeshProUGUI _0x81785de0;
        Image _0x374a5af5;
        Button _0xb7ac18ab = _0xed2439e2.Cta(_0x7e6e0485, _0xaae1c97c._0x8d1f2a59(new byte[8] { 127, 88, 73, 112, 84, 83, 72, 78 }, 61), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(-300f, 0f), new Vector2(120f, 120f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), _0xda5d4a35._0x64f656bb, this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[1] { 89 }, 116), 64f, out _0x81785de0, out _0x374a5af5);
        _0xb7ac18ab.onClick.AddListener(() => this._0xefec9f20(-1));
        this._0x4835a4e3 = _0xed2439e2.Node(_0x7e6e0485, _0xaae1c97c._0x8d1f2a59(new byte[8] { 50, 21, 4, 32, 28, 17, 4, 21 }, 112), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(420f, 120f));
        _0xed2439e2.Plate(this._0x4835a4e3, _0xaae1c97c._0x8d1f2a59(new byte[7] { 243, 212, 197, 244, 213, 214, 212 }, 177), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.8f), null, false, 1f);
        this._0x2ef3e23a = _0xed2439e2.Plate(this._0x4835a4e3, _0xaae1c97c._0x8d1f2a59(new byte[7] { 249, 222, 207, 249, 212, 223, 194 }, 187), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-6f, -6f), _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), null, false, 1f);
        this._0xfc073db7 = _0xed2439e2.Label(this._0x4835a4e3, _0xaae1c97c._0x8d1f2a59(new byte[7] { 147, 180, 165, 133, 180, 169, 165 }, 209), this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[6] { 25, 30, 15, 123, 110, 107 }, 91), 56f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
        TextMeshProUGUI _0x87f7e824;
        Image _0x02f489e2;
        Button _0x69a3fa57 = _0xed2439e2.Cta(_0x7e6e0485, _0xaae1c97c._0x8d1f2a59(new byte[7] { 85, 114, 99, 71, 123, 98, 100 }, 23), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(300f, 0f), new Vector2(120f, 120f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), _0xda5d4a35._0x64f656bb, this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[1] { 131 }, 168), 64f, out _0x87f7e824, out _0x02f489e2);
        _0x69a3fa57.onClick.AddListener(() => this._0xefec9f20(1));
    }

    public void _0x0c7e1272(bool _0x9f331aae)
    {
        if (this._0xf4b90b1c != null)
        {
            this._0xf4b90b1c.interactable = !_0x9f331aae;
        }

        if (this._0x36de88a7 != null)
        {
            this._0x36de88a7.text = _0x9f331aae ? _0xaae1c97c._0x8d1f2a59(new byte[8] { 111, 108, 117, 114, 114, 117, 114, 123 }, 60) : _0xaae1c97c._0x8d1f2a59(new byte[4] { 138, 137, 144, 151 }, 217);
            this._0x36de88a7.color = _0x9f331aae ? _0xda5d4a35._0x87d061a4 : _0xda5d4a35._0x64f656bb;
        }

        if (this._0x3f492796 != null)
        {
            this._0x3f492796.color = _0x9f331aae ? _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.75f) : Color.white;
        }
    }

    public void _0x203085ad()
    {
        if (this._0x1af25f71 == null)
        {
            return;
        }

        this._0x1af25f71.localScale = Vector3.one;
        this._0x1af25f71.DOPunchScale(new Vector3(0.07f, 0.07f, 0f), 0.5f, 1, 0.5f).SetLink(this._0x1af25f71.gameObject);
    }

    public const float TopRowY = 420f;
    private void _0xc19e69b4()
    {
        _0xed2439e2.Press(this._0xf4b90b1c.transform as RectTransform);
        if (this._0xb0b3c7f1 != null)
        {
            this._0xb0b3c7f1._0x58f3aa17();
        }
    }

    private RectTransform _0x4835a4e3;
    private void _0xe98af6a9(Button _0xac61099f)
    {
        _0xed2439e2.Press(_0xac61099f.transform as RectTransform);
        if (this._0xb0b3c7f1 != null)
        {
            this._0xb0b3c7f1._0xfce5180e();
        }

        if (this._0x0794fd54 != null)
        {
            this._0x0794fd54.Show();
        }
    }

    private TextMeshProUGUI _0x36de88a7;
    private RectTransform _0xc39f3978;
    private void _0x1add31df(RectTransform _0x0e405259)
    {
        RectTransform _0x628ac00b = _0xed2439e2.Node(_0x0e405259, _0xaae1c97c._0x8d1f2a59(new byte[8] { 138, 183, 166, 145, 182, 176, 171, 178 }, 194), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0f, -HudCentreY), new Vector2(0f, 140f));
        _0xed2439e2.Plate(_0x628ac00b, _0xaae1c97c._0x8d1f2a59(new byte[8] { 1, 60, 45, 25, 37, 40, 61, 44 }, 73), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.82f), null, false, 1f);
        _0xed2439e2.Plate(_0x628ac00b, _0xaae1c97c._0x8d1f2a59(new byte[9] { 174, 147, 130, 164, 137, 148, 130, 131, 148 }, 230), new Vector2(0f, 0f), new Vector2(1f, 0f), Vector2.zero, new Vector2(0f, 5f), _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.9f), null, false, 1f);
        _0xed2439e2.Icon(_0x628ac00b, _0xaae1c97c._0x8d1f2a59(new byte[7] { 197, 248, 233, 206, 226, 228, 227 }, 141), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(-180f, 0f), 60f, this._0xb5317d50 != null ? this._0xb5317d50._0xef40aae3 : null, Color.white);
        this._0xf55dc2ee = _0xed2439e2.Label(_0x628ac00b, _0xaae1c97c._0x8d1f2a59(new byte[10] { 78, 115, 98, 68, 103, 106, 103, 104, 101, 99 }, 6), this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[1] { 67 }, 115), 72f, _0xda5d4a35._0x872a7f7e, TextAlignmentOptions.Left, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(60f, 0f), new Vector2(380f, 80f));
        TextMeshProUGUI _0x7a76bbf6;
        Image _0x8460e381;
        Button _0xadce042e = _0xed2439e2.Cta(_0x628ac00b, _0xaae1c97c._0x8d1f2a59(new byte[10] { 160, 131, 129, 137, 160, 151, 150, 150, 141, 140 }, 226), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(BackX, 0f), new Vector2(120f, 120f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), _0xda5d4a35._0x64f656bb, this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, string.Empty, 36f, out _0x7a76bbf6, out _0x8460e381);
        _0x7a76bbf6.gameObject.SetActive(false);
        _0xed2439e2.Icon(_0xadce042e.transform as RectTransform, _0xaae1c97c._0x8d1f2a59(new byte[8] { 204, 239, 237, 229, 199, 237, 225, 224 }, 142), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, 64f, this._0xb5317d50 != null ? this._0xb5317d50._0x75576c26 : null, _0xda5d4a35._0x872a7f7e);
        _0xadce042e.onClick.AddListener(() => this._0xf596aad1(_0xadce042e));
        TextMeshProUGUI _0xee175eab;
        Image _0x4e0242dd;
        Button _0x881a6d5c = _0xed2439e2.Cta(_0x628ac00b, _0xaae1c97c._0x8d1f2a59(new byte[11] { 24, 41, 61, 59, 45, 10, 61, 60, 60, 39, 38 }, 72), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(PauseX, 0f), new Vector2(120f, 120f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), _0xda5d4a35._0x64f656bb, this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, string.Empty, 36f, out _0xee175eab, out _0x4e0242dd);
        _0xee175eab.gameObject.SetActive(false);
        _0xed2439e2.Icon(_0x881a6d5c.transform as RectTransform, _0xaae1c97c._0x8d1f2a59(new byte[9] { 251, 202, 222, 216, 206, 226, 200, 196, 197 }, 171), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, 60f, this._0xb5317d50 != null ? this._0xb5317d50._0xfef0941d : null, _0xda5d4a35._0x872a7f7e);
        _0x881a6d5c.onClick.AddListener(() => this._0x9a9d04ef(_0x881a6d5c));
    }

    private void _0xf596aad1(Button _0xfdc62b96)
    {
        _0xed2439e2.Press(_0xfdc62b96.transform as RectTransform);
        _0x8758f65d.Instance._0x927dfea1(_0x20971818._0xb6bbf20c.SCENE_0);
    }

    private void _0x8ab236d9(RectTransform _0x06a89fc5)
    {
        TextMeshProUGUI _0xda4e446c;
        Image _0x42018167;
        this._0xf4b90b1c = _0xed2439e2.Cta(_0x06a89fc5, _0xaae1c97c._0x8d1f2a59(new byte[10] { 174, 141, 148, 147, 191, 136, 137, 137, 146, 147 }, 253), new Vector2(0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, SpinCentreY), new Vector2(520f, 180f), this._0xb5317d50 != null ? this._0xb5317d50._0xac38e132 : null, Color.white, _0xda5d4a35._0x64f656bb, this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[4] { 23, 20, 13, 10 }, 68), 72f, out _0xda4e446c, out _0x42018167);
        this._0x36de88a7 = _0xda4e446c;
        this._0x3f492796 = _0x42018167;
        if (_0x42018167 != null && _0x42018167.sprite == null)
        {
            _0x42018167.color = _0xda5d4a35._0x16aaa4b1;
        }

        this._0xf4b90b1c.onClick.AddListener(() => this._0xc19e69b4());
    }

    public void _0xc8d35df5()
    {
        if (this._0xc39f3978 == null)
        {
            return;
        }

        this._0xc39f3978.gameObject.SetActive(true);
        this._0xc39f3978.localScale = Vector3.one;
        this._0xc39f3978.DOPunchScale(new Vector3(0.08f, 0.08f, 0f), 0.5f, 1, 0.5f).SetLink(this._0xc39f3978.gameObject);
        DOVirtual.DelayedCall(1.2f, () => this._0x59cef4ee()).SetLink(this.gameObject);
    }

    private Image _0x2ef3e23a;
    private void _0xea880582(RectTransform _0x7be1d9d2, string _0x884ce055, float _0x8cb91c3b, float _0xc5877e88, float _0xed289947, float _0xe49e1db7)
    {
        Image _0xfc9e38b5 = _0xed2439e2.Icon(_0x7be1d9d2, _0x884ce055, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(_0x8cb91c3b, _0xc5877e88), 96f, this._0xb5317d50 != null ? this._0xb5317d50._0xa84b870d : null, _0xda5d4a35._0x872a7f7e);
        _0xfc9e38b5.rectTransform.localScale = new Vector3(_0xed289947, _0xe49e1db7, 1f);
    }

    private _0x16323ba0 _0xba40f927;
    private _0x5de4a448 _0xb0b3c7f1;
    private _0x6759e2cf _0xf6c75ec0;
    private _0x2ea6a731 _0x0794fd54;
    private _0xc19b7c1c _0x66b4a511;
    private void OnDestroy()
    {
        if (this._0x1af25f71 != null)
        {
            DOTween.Kill(this._0x1af25f71);
        }

        if (this._0x2ef3e23a != null)
        {
            DOTween.Kill(this._0x2ef3e23a);
        }
    }

    private TextMeshProUGUI _0xfc073db7;
    private readonly _0x2da42efb[] _0x0439e27d = new _0x2da42efb[_0xc19b7c1c.Reels];
    private TextMeshProUGUI _0x1ab3ee57;
    private _0x06bd04c5 _0xb5317d50;
    private void _0x761b269e(RectTransform _0x218f7cab)
    {
        float _0xc3ffe420 = (_0xc19b7c1c.Rows * CellHeight) + ((_0xc19b7c1c.Rows - 1) * Gutter);
        float _0x7d19f722 = _0xc3ffe420 + (2f * Frame);
        RectTransform _0xe9409005 = _0xed2439e2.Node(_0x218f7cab, _0xaae1c97c._0x8d1f2a59(new byte[11] { 163, 148, 148, 157, 185, 158, 132, 130, 152, 159, 150 }, 241), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -HousingCentreY), new Vector2(BoardWidth, _0x7d19f722));
        _0xed2439e2.Plate(_0xe9409005, _0xaae1c97c._0x8d1f2a59(new byte[10] { 112, 71, 71, 78, 113, 74, 67, 70, 77, 85 }, 34), Vector2.zero, Vector2.one, new Vector2(0f, -14f), new Vector2(16f, 10f), _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.5f), null, false, 1f);
        Image _0xfb66d24f = _0xed2439e2.Plate(_0xe9409005, _0xaae1c97c._0x8d1f2a59(new byte[13] { 254, 201, 201, 192, 238, 205, 207, 199, 220, 192, 205, 216, 201 }, 172), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, Color.white, this._0xb5317d50 != null ? this._0xb5317d50._0x8733093d : null, true, 1f);
        if (_0xfb66d24f.sprite == null)
        {
            _0xfb66d24f.color = _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.98f);
        }

        for (int _0xc970bdcc = 0; _0xc970bdcc < _0xc19b7c1c.Reels; _0xc970bdcc++)
        {
            _0x2da42efb _0xebedda75 = this.gameObject.AddComponent<_0x2da42efb>();
            _0xebedda75._0x0bdfc8cd(_0xe9409005, this._0x66b4a511, this._0xb5317d50, _0xc970bdcc, this._0xa3eaf963[_0xc970bdcc], CellWidth, CellHeight, Gutter);
            this._0x0439e27d[_0xc970bdcc] = _0xebedda75;
        }

        for (int _0x8fb814b6 = 0; _0x8fb814b6 < _0xc19b7c1c.Reels - 1; _0x8fb814b6++)
        {
            float _0xc3ac85cf = this._0xa3eaf963[_0x8fb814b6] + (CellWidth * 0.5f) + (Gutter * 0.5f);
            _0xed2439e2.Plate(_0xe9409005, _0xaae1c97c._0x8d1f2a59(new byte[7] { 218, 252, 231, 227, 204, 239, 252 }, 142) + _0x8fb814b6.ToString(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(_0xc3ac85cf, 0f), new Vector2(Gutter, _0xc3ffe420), _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.9f), null, false, 1f);
        }

        float _0x4b609c18 = (BoardWidth * 0.5f) - 22f;
        float _0x61c8cb1d = (_0x7d19f722 * 0.5f) - 22f;
        this._0xea880582(_0xe9409005, _0xaae1c97c._0x8d1f2a59(new byte[10] { 237, 208, 204, 195, 207, 199, 204, 214, 246, 238 }, 162), -_0x4b609c18, _0x61c8cb1d, 1f, 1f);
        this._0xea880582(_0xe9409005, _0xaae1c97c._0x8d1f2a59(new byte[10] { 99, 94, 66, 77, 65, 73, 66, 88, 120, 126 }, 44), _0x4b609c18, _0x61c8cb1d, -1f, 1f);
        this._0xea880582(_0xe9409005, _0xaae1c97c._0x8d1f2a59(new byte[10] { 211, 238, 242, 253, 241, 249, 242, 232, 222, 208 }, 156), -_0x4b609c18, -_0x61c8cb1d, 1f, -1f);
        this._0xea880582(_0xe9409005, _0xaae1c97c._0x8d1f2a59(new byte[10] { 92, 97, 125, 114, 126, 118, 125, 103, 81, 65 }, 19), _0x4b609c18, -_0x61c8cb1d, -1f, -1f);
        this._0xba40f927 = this.gameObject.AddComponent<_0x16323ba0>();
        this._0xba40f927._0xda854e7f(_0xe9409005, this._0x66b4a511, this._0xf6c75ec0, this._0xa3eaf963, this._0x97a4f923, 7f);
    }

    public const float HudCentreY = 246f;
    private TextMeshProUGUI _0xf55dc2ee;
    public const float BetCentreY = 640f;
    private TextMeshProUGUI _0x5013a63e;
    public const float Frame = 40f;
    public void _0x7d148cfa(long _0x2abe4a86)
    {
        if (this._0xf55dc2ee != null)
        {
            this._0xf55dc2ee.text = _0xed2439e2.Money(_0x2abe4a86);
        }
    }

    private void _0x2d67c037(RectTransform _0x3b24e5dd)
    {
        RectTransform _0xe7064b66 = _0xed2439e2.Node(_0x3b24e5dd, _0xaae1c97c._0x8d1f2a59(new byte[10] { 104, 77, 74, 65, 104, 65, 67, 65, 74, 64 }, 36), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -1660f), new Vector2(1060f, 110f));
        string[] _0x9de6fc92 =
        {
            _0xaae1c97c._0x8d1f2a59(new byte[5] { 157, 128, 152, 239, 254 }, 207),
            _0xaae1c97c._0x8d1f2a59(new byte[5] { 79, 82, 74, 61, 47 }, 29),
            _0xaae1c97c._0x8d1f2a59(new byte[5] { 245, 232, 240, 135, 148 }, 167),
            _0xaae1c97c._0x8d1f2a59(new byte[6] { 143, 249, 149, 144, 151, 156 }, 217),
            _0xaae1c97c._0x8d1f2a59(new byte[6] { 72, 41, 69, 64, 71, 76 }, 9)
        };
        for (int _0x0b4dcd2b = 0; _0x0b4dcd2b < _0xc19b7c1c.LineCount; _0x0b4dcd2b++)
        {
            RectTransform _0x21998a1d = _0xed2439e2.Node(_0xe7064b66, _0xaae1c97c._0x8d1f2a59(new byte[8] { 232, 205, 202, 193, 231, 204, 205, 212 }, 164) + _0x0b4dcd2b.ToString(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2((_0x0b4dcd2b - 2) * 206f, 0f), new Vector2(196f, 84f));
            _0xed2439e2.Plate(_0x21998a1d, _0xaae1c97c._0x8d1f2a59(new byte[8] { 143, 164, 165, 188, 137, 168, 171, 169 }, 204), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x41b9a3a1, 0.55f), null, false, 1f);
            _0xed2439e2.Plate(_0x21998a1d, _0xaae1c97c._0x8d1f2a59(new byte[8] { 116, 95, 94, 71, 117, 88, 83, 78 }, 55), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-5f, -5f), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.9f), null, false, 1f);
            _0xed2439e2.Label(_0x21998a1d, _0xaae1c97c._0x8d1f2a59(new byte[8] { 27, 48, 49, 40, 12, 61, 32, 44 }, 88), this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0x9de6fc92[_0x0b4dcd2b], 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
        }
    }

    private void _0x1cd3a045(RectTransform _0x95997768)
    {
        this._0x1af25f71 = _0xed2439e2.Node(_0x95997768, _0xaae1c97c._0x8d1f2a59(new byte[9] { 138, 180, 179, 159, 188, 179, 179, 184, 175 }, 221), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, -1500f), new Vector2(900f, 120f));
        _0xed2439e2.Plate(this._0x1af25f71, _0xaae1c97c._0x8d1f2a59(new byte[11] { 115, 80, 95, 95, 84, 67, 97, 93, 80, 69, 84 }, 49), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.55f), null, false, 1f);
        _0xed2439e2.Plate(this._0x1af25f71, _0xaae1c97c._0x8d1f2a59(new byte[10] { 252, 223, 208, 208, 219, 204, 236, 203, 210, 219 }, 190), new Vector2(0f, 0f), new Vector2(1f, 0f), Vector2.zero, new Vector2(-40f, 4f), _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.8f), null, false, 1f);
        this._0xedee67b7 = _0xed2439e2.Label(this._0x1af25f71, _0xaae1c97c._0x8d1f2a59(new byte[10] { 53, 22, 25, 25, 18, 5, 35, 18, 15, 3 }, 119), this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[26] { 60, 41, 56, 72, 59, 56, 33, 38, 72, 60, 39, 72, 56, 36, 41, 49, 72, 69, 72, 93, 72, 36, 33, 38, 45, 59 }, 104), 72f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
    }

    public void _0x34cfb619(int _0x48db5e14)
    {
        if (this._0xfc073db7 != null)
        {
            this._0xfc073db7.text = _0xaae1c97c._0x8d1f2a59(new byte[4] { 195, 196, 213, 161 }, 129) + _0xed2439e2.Money(_0x48db5e14);
        }

        if (this._0x4835a4e3 != null)
        {
            _0xed2439e2.Press(this._0x4835a4e3);
        }

        if (this._0x2ef3e23a != null)
        {
            DOTween.Kill(this._0x2ef3e23a, false);
            this._0x2ef3e23a.color = _0xda5d4a35._0x16aaa4b1;
            this._0x2ef3e23a.DOColor(_0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), 0.3f).SetDelay(0.3f).SetLink(this._0x2ef3e23a.gameObject);
        }
    }

    private void _0x9a9d04ef(Button _0x9a54c114)
    {
        _0xed2439e2.Press(_0x9a54c114.transform as RectTransform);
        if (this._0xc3737823 != null)
        {
            this._0xc3737823._0x04db1c3d(this._0xf6c75ec0);
        }
    }

    public const float Gutter = 12f;
    public const float CellWidth = 198f;
    private void _0x3098ec5e(RectTransform _0x242742a5)
    {
        RectTransform _0x3459c072 = _0xed2439e2.Node(_0x242742a5, _0xaae1c97c._0x8d1f2a59(new byte[12] { 192, 228, 254, 254, 228, 226, 227, 222, 249, 255, 228, 253 }, 141), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(-270f, -TopRowY), new Vector2(640f, 92f));
        _0xed2439e2.Plate(_0x3459c072, _0xaae1c97c._0x8d1f2a59(new byte[10] { 136, 175, 169, 178, 171, 139, 183, 186, 175, 190 }, 219), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.6f), null, false, 1f);
        this._0x5013a63e = _0xed2439e2.Label(_0x3459c072, _0xaae1c97c._0x8d1f2a59(new byte[9] { 85, 114, 116, 111, 118, 82, 99, 126, 114 }, 6), this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[7] { 34, 38, 60, 60, 38, 32, 33 }, 111), 36f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
        this._0xc39f3978 = _0xed2439e2.Node(_0x242742a5, _0xaae1c97c._0x8d1f2a59(new byte[12] { 126, 90, 64, 64, 90, 92, 93, 103, 92, 82, 64, 71 }, 51), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(-270f, -TopRowY), new Vector2(640f, 92f));
        _0xed2439e2.Plate(this._0xc39f3978, _0xaae1c97c._0x8d1f2a59(new byte[10] { 24, 35, 45, 63, 56, 28, 32, 45, 56, 41 }, 76), Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero, _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.95f), null, false, 1f);
        _0xed2439e2.Label(this._0xc39f3978, _0xaae1c97c._0x8d1f2a59(new byte[9] { 232, 211, 221, 207, 200, 232, 217, 196, 200 }, 188), this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[21] { 43, 47, 53, 53, 47, 41, 40, 70, 37, 41, 43, 54, 42, 35, 50, 35, 70, 77, 84, 83, 86 }, 102), 44f, _0xda5d4a35._0x64f656bb, TextAlignmentOptions.Center, Vector2.zero, Vector2.one, Vector2.zero, Vector2.zero);
        this._0xc39f3978.gameObject.SetActive(false);
        TextMeshProUGUI _0x97f2c119;
        Image _0x1ddfec71;
        Button _0x2eaa9040 = _0xed2439e2.Cta(_0x242742a5, _0xaae1c97c._0x8d1f2a59(new byte[14] { 111, 94, 70, 75, 94, 93, 83, 90, 125, 74, 75, 75, 80, 81 }, 63), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(470f, -TopRowY), new Vector2(108f, 108f), null, _0xda5d4a35.Fade(_0xda5d4a35._0xfff4ad6c, 0.95f), _0xda5d4a35._0x872a7f7e, this._0xb5317d50 != null ? this._0xb5317d50._0x533877f5 : null, _0xaae1c97c._0x8d1f2a59(new byte[4] { 96, 113, 105, 99 }, 48), 36f, out _0x97f2c119, out _0x1ddfec71);
        _0x2eaa9040.onClick.AddListener(() => this._0xe98af6a9(_0x2eaa9040));
    }

    private _0xc67ab774 _0xc3737823;
    public void _0xee1aa78e(int _0xb8663f99)
    {
        if (this._0x1ab3ee57 != null)
        {
            this._0x1ab3ee57.text = _0xb8663f99 > 0 ? _0xaae1c97c._0x8d1f2a59(new byte[12] { 49, 60, 46, 41, 93, 46, 45, 52, 51, 93, 93, 86 }, 125) + _0xed2439e2.Money(_0xb8663f99) : _0xaae1c97c._0x8d1f2a59(new byte[12] { 195, 206, 220, 219, 175, 220, 223, 198, 193, 175, 175, 162 }, 143);
            this._0x1ab3ee57.color = _0xb8663f99 > 0 ? _0xda5d4a35._0x872a7f7e : _0xda5d4a35._0x87d061a4;
        }
    }

    private void _0x59cef4ee()
    {
        if (this._0xc39f3978 != null)
        {
            this._0xc39f3978.gameObject.SetActive(false);
        }
    }

    private readonly float[] _0xa3eaf963 = new float[_0xc19b7c1c.Reels];
    public const float HousingCentreY = 950f;
    private Button _0xf4b90b1c;
}

internal static class _0xaae1c97c
{
    internal static string _0x8d1f2a59(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}