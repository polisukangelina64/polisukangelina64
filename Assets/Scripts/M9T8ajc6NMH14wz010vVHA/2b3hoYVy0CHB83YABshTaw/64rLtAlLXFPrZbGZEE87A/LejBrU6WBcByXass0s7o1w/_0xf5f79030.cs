using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xf5f79030 : MonoBehaviour
{
    public bool IsScaledDownOnAwake = true;
    public TMP_Text MainText;
    public GameObject OuterBackground;
    private void _0x4371a953()
    {
        if (this.OuterBackground != null)
        {
            Image _0x29a838d5 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x29a838d5, true);
            _0x29a838d5.DOFade(1f, 0f);
        }
    }

    private void _0x28bff449()
    {
        if (this.OuterBackground != null)
        {
            Image _0xfe76e118 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xfe76e118, true);
            _0xfe76e118.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public float ScaleDuration = 0.4f;
    private void _0xf5a34ce4()
    {
        if (this.OuterBackground != null)
        {
            Image _0xa01637e5 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xa01637e5, true);
            _0xa01637e5.DOFade(0f, this.ScaleDuration);
        }
    }

    public void _0x357ff583()
    {
        this._0x4371a953();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xe7358e6f.Instance._0x4a47e359(_0xe7358e6f.Instance.CurrentPanelIndex);
    }

    private bool _0x1f851524 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public GameObject Content;
    public Ease Ease = Ease.OutSine;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xe26f4601();
    }

    public void Show()
    {
        this._0x28bff449();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xe7358e6f.Instance._0x4a47e359(_0xe7358e6f.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0xe26f4601()
    {
        if (this.OuterBackground != null)
        {
            Image _0x9b0107e1 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x9b0107e1, true);
            _0x9b0107e1.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public TMP_Text HeaderText;
    public void _0xcb328ee9()
    {
        this._0xf5a34ce4();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }
}