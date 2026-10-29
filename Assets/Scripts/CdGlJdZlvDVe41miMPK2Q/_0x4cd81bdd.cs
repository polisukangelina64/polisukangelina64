using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the template splash: a dark scrim so it can never read as the lobby, the
/// abstract clover medallion (no title anywhere) and a readable loading bar.
/// </summary>
public sealed class _0x4cd81bdd : MonoBehaviour
{
    private void _0x533e8da0()
    {
        if (this._sliderRoot != null)
        {
            this._sliderRoot.sizeDelta = new Vector2(760f, 64f);
        }

        // The prefab shrinks Fill Area by 30 units, which collapses a short bar to nothing.
        if (this._fillArea != null)
        {
            this._fillArea.anchorMin = Vector2.zero;
            this._fillArea.anchorMax = Vector2.one;
            this._fillArea.offsetMin = new Vector2(24f, 14f);
            this._fillArea.offsetMax = new Vector2(-24f, -14f);
        }

        // Slider.UpdateVisuals owns Fill's anchors every frame; only the insets are ours.
        RectTransform _0x0d894b26 = this._fillRect;
        if (_0x0d894b26 != null)
        {
            _0x0d894b26.offsetMin = Vector2.zero;
            _0x0d894b26.offsetMax = Vector2.zero;
        }

        if (this._fillImage != null)
        {
            this._fillImage.color = _0xda5d4a35._0x16aaa4b1;
        }

        if (this._trackImage != null)
        {
            this._trackImage.color = _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.85f);
        }
    }

    private void _0xae9dfc03()
    {
        if (this._splashContent == null)
        {
            return;
        }

        RectTransform _0xd48fbf40 = _0xed2439e2.Stretch(this._splashContent, _0xb40d77b0._0xb18bf7b5(new byte[11] { 218, 249, 229, 232, 250, 225, 205, 236, 234, 230, 251 }, 137));
        _0xd48fbf40.SetAsFirstSibling();
        _0xed2439e2.Fill(_0xd48fbf40, _0xb40d77b0._0xb18bf7b5(new byte[5] { 251, 203, 218, 193, 197 }, 168), _0xda5d4a35.Fade(_0xda5d4a35._0xd4e968dd, 0.62f));
        _0xed2439e2.Fill(_0xd48fbf40, _0xb40d77b0._0xb18bf7b5(new byte[8] { 157, 161, 184, 160, 154, 172, 190, 165 }, 205), _0xda5d4a35.Fade(_0xda5d4a35._0x66b7573e, 0.35f));
        this._0x63023c14 = _0xed2439e2.Plate(_0xd48fbf40, _0xb40d77b0._0xb18bf7b5(new byte[4] { 191, 150, 155, 152 }, 247), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, 180f), new Vector2(760f, 760f), _0xda5d4a35.Fade(_0xda5d4a35._0x8a0e3d68, 0.25f), this._art != null ? this._art._0x62eb50b4 : null, false, 1f);
        Image _0xcf4acd8f = _0xed2439e2.Plate(_0xd48fbf40, _0xb40d77b0._0xb18bf7b5(new byte[9] { 253, 213, 212, 209, 220, 220, 217, 223, 222 }, 176), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, 180f), new Vector2(520f, 520f), Color.white, this._art != null ? this._art._0xe07d1da7 : null, false, 1f);
        this._0x12e1c37a = _0xcf4acd8f.rectTransform;
        _0xed2439e2.Plate(_0xd48fbf40, _0xb40d77b0._0xb18bf7b5(new byte[8] { 130, 170, 169, 161, 151, 176, 169, 160 }, 197), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -400f), new Vector2(420f, 4f), _0xda5d4a35.Fade(_0xda5d4a35._0x5484003b, 0.8f), null, false, 1f);
        TextMeshProUGUI _0xcb05b323 = _0xed2439e2.Label(_0xd48fbf40, _0xb40d77b0._0xb18bf7b5(new byte[14] { 231, 196, 202, 207, 194, 197, 204, 232, 202, 219, 223, 194, 196, 197 }, 171), this._art != null ? this._art._0x533877f5 : null, _0xb40d77b0._0xb18bf7b5(new byte[7] { 131, 128, 142, 139, 134, 129, 136 }, 207), 44f, _0xda5d4a35._0x87d061a4, TextAlignmentOptions.Center, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0f, -520f), new Vector2(900f, 70f));
        _0xcb05b323.characterSpacing = 6f;
        this._0x12e1c37a.localScale = Vector3.one * 0.8f;
        this._0x12e1c37a.DOScale(1f, 0.55f).SetEase(Ease.OutBack).SetLink(this._0x12e1c37a.gameObject);
        this._0x12e1c37a.DOScale(1.035f, 2.2f).SetDelay(0.6f).SetLoops(-1, LoopType.Yoyo).SetLink(this._0x12e1c37a.gameObject);
        this._0x63023c14.DOFade(0.45f, 1.8f).SetLoops(-1, LoopType.Yoyo).SetLink(this._0x63023c14.gameObject);
    }

    private RectTransform _0x12e1c37a;
    [SerializeField]
    private _0x06bd04c5 _art;
    [SerializeField]
    private RectTransform _fillRect;
    [SerializeField]
    private RectTransform _fillArea;
    private void OnDestroy()
    {
        if (this._0x12e1c37a != null)
        {
            DOTween.Kill(this._0x12e1c37a);
        }

        if (this._0x63023c14 != null)
        {
            DOTween.Kill(this._0x63023c14);
        }
    }

    private void Start()
    {
        this._0x533e8da0();
        this._0xae9dfc03();
    }

    [SerializeField]
    private RectTransform _splashContent;
    [SerializeField]
    private Image _trackImage;
    [SerializeField]
    private Image _fillImage;
    [SerializeField]
    private RectTransform _sliderRoot;
    private Image _0x63023c14;
}

internal static class _0xb40d77b0
{
    internal static string _0xb18bf7b5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}