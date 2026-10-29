using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the three template popups in this game's words and art. Every reference is
/// serialized in the scene, including the close cross sprite - an Image without one is
/// drawn as a solid white rectangle.
/// </summary>
public sealed class _0xc67ab774 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _loseBalanceCaption;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private RectTransform _winContainer;
    private RectTransform _0x1a90450d;
    [SerializeField]
    private TMP_Text _loseMetricCaption;
    private Button _0x8f2897ca;
    private _0xc3ef787a _0x5bb361b0;
    [SerializeField]
    private TMP_Text _loseLeftLabel;
    public void _0x2e82618c(_0x5de4a448 _0x1bd1ecd1, _0xc3ef787a _0x2c890f98)
    {
        this._0xed14aa8b = _0x1bd1ecd1;
        this._0x5bb361b0 = _0x2c890f98;
    }

    [SerializeField]
    private TMP_Text _pauseCloseLabel;
    [SerializeField]
    private TMP_Text _winHeader;
    [SerializeField]
    private RectTransform _pauseContainer;
    [SerializeField]
    private TMP_Text _winRightLabel;
    public void _0x6d1218f1(int _0x778a1af2, string _0x66cc5486, long _0x84c8dd0d)
    {
        this._0x2a1b6397(this._winMetricValue, _0xed2439e2.Money(_0x778a1af2), _0xda5d4a35._0x872a7f7e);
        this._0xc025a642(this._winExtra, _0x66cc5486, _0xda5d4a35._0x87d061a4, 44f);
        this._0xc025a642(this._winHeader, _0x778a1af2 >= _0x6759e2cf.StartingCoins ? _0xca3c81a0._0x4903a80d(new byte[8] { 56, 48, 50, 52, 85, 34, 60, 59 }, 117) : _0xca3c81a0._0x4903a80d(new byte[7] { 242, 249, 247, 144, 231, 249, 254 }, 176), _0xda5d4a35._0x872a7f7e, 96f);
        this._0xa35a5961 = true;
        _0xdc4de371 _0x6f3c810e = _0x4c3ff0fb.Instance._0x152cbfaf(_0x20971818._0xde5e3e30.WIN);
        if (_0x6f3c810e != null && this._0x1a90450d != null)
        {
            this._0x1a90450d.localScale = Vector3.one * 0.6f;
            this._0x1a90450d.DOScale(1f, 0.45f).SetEase(Ease.OutBack).SetLink(this._0x1a90450d.gameObject);
            this._0x1a90450d.DOLocalRotate(new Vector3(0f, 0f, -360f), 18f, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart).SetLink(this._0x1a90450d.gameObject);
        }

        _0x4c3ff0fb.Instance._0x77b1dff0(_0x20971818._0xde5e3e30.WIN);
        DOVirtual.DelayedCall(WinAutoRelease, () => this._0x207d7326()).SetLink(this.gameObject);
    }

    [SerializeField]
    private TMP_Text _pauseHeader;
    public void _0x04db1c3d(_0x6759e2cf _0x088f781e)
    {
        this._0xc025a642(this._pauseHeader, _0xca3c81a0._0x4903a80d(new byte[6] { 72, 89, 77, 75, 93, 92 }, 24), _0xda5d4a35._0x64f656bb, 96f);
        this._0xc025a642(this._pauseBody, _0x088f781e != null ? _0xca3c81a0._0x4903a80d(new byte[18] { 139, 158, 148, 154, 255, 158, 255, 157, 141, 154, 158, 139, 151, 213, 157, 154, 139, 255 }, 223) + _0xed2439e2.Money(_0x088f781e._0xfbdf25e9) : _0xca3c81a0._0x4903a80d(new byte[13] { 23, 2, 8, 6, 99, 2, 99, 1, 17, 6, 2, 23, 11 }, 67), _0xda5d4a35._0x87d061a4, 56f);
        this._0xa35a5961 = true;
        _0xdc4de371 _0xda118828 = _0x4c3ff0fb.Instance._0x152cbfaf(_0x20971818._0xde5e3e30.PAUSE);
        if (_0xda118828 != null)
        {
            _0xda118828.gameObject.SetActive(true);
        }

        _0x8758f65d.Instance._0xe518613b(false);
        _0x4c3ff0fb.Instance._0x77b1dff0(_0x20971818._0xde5e3e30.PAUSE);
    }

    [SerializeField]
    private TMP_Text _winBalanceCaption;
    [SerializeField]
    private TMP_Text _pauseLeftLabel;
    [SerializeField]
    private Button _pauseCloseButton;
    [SerializeField]
    private TMP_Text _winLeftLabel;
    [SerializeField]
    private TMP_Text _pauseRightLabel;
    private Button _0x1c6a3eb1;
    private Button _0x64069736(RectTransform _0xc4ef5f6c, string _0xe910fd17, string _0xd593402c, Color _0xddc58e8e)
    {
        TextMeshProUGUI _0x6d1b017c;
        Image _0x8f4981d2;
        Button _0xe32d7ac5 = _0xed2439e2.Cta(_0xc4ef5f6c, _0xe910fd17, new Vector2(0.06f, 0.15f), new Vector2(0.94f, 0.25f), Vector2.zero, Vector2.zero, null, _0xddc58e8e, _0xda5d4a35._0x64f656bb, this._font, _0xd593402c, 48f, out _0x6d1b017c, out _0x8f4981d2);
        return _0xe32d7ac5;
    }

    public void _0xb5787ed7(_0x6759e2cf _0x90c514dc)
    {
        this._0x1b9ca5f0 = _0x90c514dc;
        this._0xafb45462();
    }

    /// <summary>
    /// The template gives each pop ONE visible button and it is hard-wired to the lobby,
    /// so every real action - resume, spin again, refill - is a button of our own, placed
    /// below the template band so the two never overlap.
    /// </summary>
    private void _0x14278f84()
    {
        if (this._pauseContainer != null)
        {
            this._0x1c6a3eb1 = this._0x64069736(this._pauseContainer, _0xca3c81a0._0x4903a80d(new byte[9] { 137, 190, 168, 174, 182, 190, 152, 175, 186 }, 219), _0xca3c81a0._0x4903a80d(new byte[6] { 77, 90, 76, 74, 82, 90 }, 31), _0xda5d4a35._0x41b9a3a1);
            this._0x1c6a3eb1.onClick.AddListener(() => this._0xce331f4d());
        }

        if (this._winContainer != null)
        {
            this._0x1a402042 = this._0x64069736(this._winContainer, _0xca3c81a0._0x4903a80d(new byte[12] { 1, 34, 59, 60, 19, 53, 51, 59, 60, 17, 38, 51 }, 82), _0xca3c81a0._0x4903a80d(new byte[10] { 89, 90, 67, 68, 42, 75, 77, 75, 67, 68 }, 10), _0xda5d4a35._0x16aaa4b1);
            this._0x1a402042.onClick.AddListener(() => this._0x207d7326());
        }

        if (this._loseContainer != null)
        {
            this._0x8f2897ca = this._0x64069736(this._loseContainer, _0xca3c81a0._0x4903a80d(new byte[9] { 36, 19, 16, 31, 26, 26, 53, 2, 23 }, 118), _0xca3c81a0._0x4903a80d(new byte[17] { 186, 181, 184, 176, 180, 217, 191, 171, 188, 188, 217, 171, 188, 191, 176, 181, 181 }, 249), _0xda5d4a35._0x31eee6c9);
            this._0x8f2897ca.onClick.AddListener(() => this._0xebc791f1());
        }
    }

    [SerializeField]
    private TMP_Text _pauseBody;
    [SerializeField]
    private Sprite _closeIcon;
    public bool _0x4300da7d => this._0xa35a5961;

    [SerializeField]
    private RectTransform _loseContainer;
    [SerializeField]
    private Sprite _winBurst;
    private Button _0x1a402042;
    [SerializeField]
    private Image _pauseCloseIcon;
    private void _0x2a1b6397(TMP_Text _0x4d17d4bd, string _0x53f82661, Color _0x0199d973)
    {
        this._0xc025a642(_0x4d17d4bd, _0x53f82661, _0x0199d973, 72f);
    }

    [SerializeField]
    private TMP_Text _loseHeader;
    private _0x5de4a448 _0xed14aa8b;
    [SerializeField]
    private Sprite _coinIcon;
    [SerializeField]
    private TMP_Text _loseRightLabel;
    private void _0x207d7326()
    {
        if (!this._0xa35a5961)
        {
            return;
        }

        this._0xa35a5961 = false;
        if (this._0x1a90450d != null)
        {
            DOTween.Kill(this._0x1a90450d);
        }

        _0x4c3ff0fb.Instance._0xb2dc89d6();
        if (this._0xed14aa8b != null)
        {
            this._0xed14aa8b._0xfce5180e();
        }
    }

    private void _0xce331f4d()
    {
        this._0xa35a5961 = false;
        _0x4c3ff0fb.Instance._0xb2dc89d6();
        _0x8758f65d.Instance._0xe518613b(true);
        if (this._0xed14aa8b != null)
        {
            this._0xed14aa8b._0xfce5180e();
        }
    }

    private void _0xcba1caea()
    {
        if (this._winContainer != null)
        {
            RectTransform _0xbe4b6f06 = _0xed2439e2.Node(this._winContainer, _0xca3c81a0._0x4903a80d(new byte[11] { 46, 16, 23, 59, 12, 11, 10, 13, 56, 11, 13 }, 121), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, 120f), new Vector2(520f, 520f));
            _0xbe4b6f06.SetAsFirstSibling();
            Image _0x864d63d6 = _0xbe4b6f06.gameObject.AddComponent<Image>();
            _0x864d63d6.sprite = this._winBurst;
            _0x864d63d6.color = _0xda5d4a35.Fade(_0xda5d4a35._0x872a7f7e, 0.65f);
            _0x864d63d6.preserveAspect = true;
            _0x864d63d6.raycastTarget = false;
            this._0x1a90450d = _0xbe4b6f06;
        }

        if (this._loseContainer != null)
        {
            RectTransform _0x942f44f6 = _0xed2439e2.Node(this._loseContainer, _0xca3c81a0._0x4903a80d(new byte[11] { 152, 187, 167, 177, 151, 187, 189, 186, 149, 166, 160 }, 212), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, 130f), new Vector2(240f, 240f));
            _0x942f44f6.SetAsFirstSibling();
            Image _0xc68f1fa8 = _0x942f44f6.gameObject.AddComponent<Image>();
            _0xc68f1fa8.sprite = this._coinIcon;
            _0xc68f1fa8.color = _0xda5d4a35.Fade(_0xda5d4a35._0x87d061a4, 0.55f);
            _0xc68f1fa8.preserveAspect = true;
            _0xc68f1fa8.raycastTarget = false;
        }

        if (this._pauseContainer != null)
        {
            RectTransform _0xb3747e57 = _0xed2439e2.Node(this._pauseContainer, _0xca3c81a0._0x4903a80d(new byte[14] { 26, 43, 63, 57, 47, 15, 39, 40, 38, 47, 39, 11, 56, 62 }, 74), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, 130f), new Vector2(280f, 280f));
            _0xb3747e57.SetAsFirstSibling();
            Image _0xe6fbf893 = _0xb3747e57.gameObject.AddComponent<Image>();
            _0xe6fbf893.sprite = this._emblem;
            _0xe6fbf893.color = _0xda5d4a35.Fade(Color.white, 0.35f);
            _0xe6fbf893.preserveAspect = true;
            _0xe6fbf893.raycastTarget = false;
        }
    }

    [SerializeField]
    private TMP_Text _loseExtra;
    [SerializeField]
    private TMP_Text _winMetricCaption;
    [SerializeField]
    private TMP_Text _winExtra;
    private void OnDestroy()
    {
        if (this._0x1a90450d != null)
        {
            DOTween.Kill(this._0x1a90450d);
        }
    }

    private void _0xc025a642(TMP_Text _0xcf2bff07, string _0x0bc4f859, Color _0xfce7659a, float _0xb0b0a650)
    {
        if (_0xcf2bff07 == null)
        {
            return;
        }

        _0xcf2bff07.gameObject.SetActive(true);
        _0xcf2bff07.text = _0x0bc4f859;
        _0xcf2bff07.color = _0xfce7659a;
        _0xcf2bff07.enableWordWrapping = false;
        _0xcf2bff07.overflowMode = TextOverflowModes.Overflow;
        _0xcf2bff07.enableAutoSizing = true;
        _0xcf2bff07.fontSizeMin = _0xed2439e2.FontFloor;
        _0xcf2bff07.fontSizeMax = Mathf.Max(_0xb0b0a650, _0xed2439e2.FontFloor);
        _0x327dba82.ApplyOutline(_0xcf2bff07);
    }

    public const float WinAutoRelease = 6f;
    private void _0xebc791f1()
    {
        if (this._0x1b9ca5f0 != null)
        {
            this._0x1b9ca5f0._0x5476a7f6 = this._0x1b9ca5f0._0x5476a7f6 + _0x6759e2cf.RefillCoins;
        }

        this._0xa35a5961 = false;
        if (this._0x5bb361b0 != null)
        {
            this._0x5bb361b0._0x7d148cfa(this._0x1b9ca5f0 != null ? this._0x1b9ca5f0._0x5476a7f6 : 0L);
        }

        _0x4c3ff0fb.Instance._0xb2dc89d6();
        if (this._0xed14aa8b != null)
        {
            this._0xed14aa8b._0xfce5180e();
        }
    }

    [SerializeField]
    private TMP_Text _winMetricValue;
    public void _0xdf6ad50c(long _0x17f2577c)
    {
        this._0x2a1b6397(this._loseMetricValue, _0xca3c81a0._0x4903a80d(new byte[1] { 79 }, 100) + _0xed2439e2.Money(_0x6759e2cf.RefillCoins), _0xda5d4a35._0x048a938e);
        this._0xc025a642(this._loseExtra, _0xca3c81a0._0x4903a80d(new byte[5] { 10, 3, 20, 7, 98 }, 66) + _0xed2439e2.Money(_0x6759e2cf.RefillCoins) + _0xca3c81a0._0x4903a80d(new byte[17] { 67, 37, 49, 38, 38, 67, 32, 44, 42, 45, 48, 67, 44, 45, 67, 54, 48 }, 99), _0xda5d4a35._0x87d061a4, 44f);
        this._0xa35a5961 = true;
        _0xdc4de371 _0xf44751e3 = _0x4c3ff0fb.Instance._0x152cbfaf(_0x20971818._0xde5e3e30.LOSE);
        if (_0xf44751e3 != null)
        {
            _0xf44751e3.gameObject.SetActive(true);
        }

        _0x4c3ff0fb.Instance._0x77b1dff0(_0x20971818._0xde5e3e30.LOSE);
    }

    [SerializeField]
    private Sprite _emblem;
    private void _0xafb45462()
    {
        this._0xc025a642(this._pauseHeader, _0xca3c81a0._0x4903a80d(new byte[6] { 89, 72, 92, 90, 76, 77 }, 9), _0xda5d4a35._0x64f656bb, 96f);
        this._0xc025a642(this._pauseBody, _0xca3c81a0._0x4903a80d(new byte[13] { 122, 111, 101, 107, 14, 111, 14, 108, 124, 107, 111, 122, 102 }, 46), _0xda5d4a35._0x87d061a4, 56f);
        this._0xc025a642(this._pauseLeftLabel, _0xca3c81a0._0x4903a80d(new byte[5] { 92, 95, 82, 82, 73 }, 16), _0xda5d4a35._0x64f656bb, 44f);
        this._0xc025a642(this._pauseRightLabel, string.Empty, _0xda5d4a35._0x64f656bb, 44f);
        this._0xc025a642(this._pauseCloseLabel, string.Empty, _0xda5d4a35._0x64f656bb, 44f);
        this._0xc025a642(this._winHeader, _0xca3c81a0._0x4903a80d(new byte[7] { 141, 134, 136, 239, 152, 134, 129 }, 207), _0xda5d4a35._0x872a7f7e, 96f);
        this._0xc025a642(this._winLeftLabel, _0xca3c81a0._0x4903a80d(new byte[5] { 235, 232, 229, 229, 254 }, 167), _0xda5d4a35._0x64f656bb, 44f);
        this._0xc025a642(this._winRightLabel, string.Empty, _0xda5d4a35._0x64f656bb, 44f);
        this._0xc025a642(this._winMetricCaption, _0xca3c81a0._0x4903a80d(new byte[4] { 55, 41, 46, 90 }, 96), _0xda5d4a35._0x87d061a4, 44f);
        this._0xc025a642(this._winBalanceCaption, _0xca3c81a0._0x4903a80d(new byte[6] { 176, 188, 186, 189, 160, 201 }, 243), _0xda5d4a35._0x87d061a4, 44f);
        this._0xc025a642(this._winExtra, _0xca3c81a0._0x4903a80d(new byte[12] { 83, 65, 72, 71, 75, 73, 65, 36, 87, 84, 77, 74 }, 4), _0xda5d4a35._0x87d061a4, 44f);
        this._0xc025a642(this._loseHeader, _0xca3c81a0._0x4903a80d(new byte[12] { 75, 81, 80, 36, 75, 66, 36, 71, 75, 77, 74, 87 }, 4), _0xda5d4a35._0x16aaa4b1, 96f);
        this._0xc025a642(this._loseLeftLabel, _0xca3c81a0._0x4903a80d(new byte[5] { 213, 214, 219, 219, 192 }, 153), _0xda5d4a35._0x64f656bb, 44f);
        this._0xc025a642(this._loseRightLabel, string.Empty, _0xda5d4a35._0x64f656bb, 44f);
        this._0xc025a642(this._loseMetricCaption, _0xca3c81a0._0x4903a80d(new byte[7] { 33, 54, 53, 58, 63, 63, 73 }, 115), _0xda5d4a35._0x87d061a4, 44f);
        this._0xc025a642(this._loseBalanceCaption, _0xca3c81a0._0x4903a80d(new byte[6] { 209, 221, 219, 220, 193, 168 }, 146), _0xda5d4a35._0x87d061a4, 44f);
        this._0xc025a642(this._loseExtra, _0xca3c81a0._0x4903a80d(new byte[18] { 63, 35, 46, 75, 61, 42, 62, 39, 63, 75, 34, 56, 75, 46, 38, 59, 63, 50 }, 107), _0xda5d4a35._0x87d061a4, 44f);
        this._0x2a1b6397(this._loseMetricValue, _0xca3c81a0._0x4903a80d(new byte[1] { 139 }, 160) + _0xed2439e2.Money(_0x6759e2cf.RefillCoins), _0xda5d4a35._0x048a938e);
        this._0x2a1b6397(this._winMetricValue, _0xca3c81a0._0x4903a80d(new byte[1] { 127 }, 79), _0xda5d4a35._0x872a7f7e);
        if (this._pauseCloseIcon != null)
        {
            this._pauseCloseIcon.gameObject.SetActive(true);
            this._pauseCloseIcon.sprite = this._closeIcon;
            this._pauseCloseIcon.color = _0xda5d4a35._0x872a7f7e;
            this._pauseCloseIcon.preserveAspect = true;
            this._pauseCloseIcon.type = Image.Type.Simple;
        }

        if (this._pauseCloseButton != null)
        {
            this._pauseCloseButton.onClick.AddListener(() => this._0xce331f4d());
        }

        this._0xcba1caea();
        this._0x14278f84();
    }

    [SerializeField]
    private TMP_Text _loseMetricValue;
    private _0x6759e2cf _0x1b9ca5f0;
    private bool _0xa35a5961;
}

internal static class _0xca3c81a0
{
    internal static string _0x4903a80d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}