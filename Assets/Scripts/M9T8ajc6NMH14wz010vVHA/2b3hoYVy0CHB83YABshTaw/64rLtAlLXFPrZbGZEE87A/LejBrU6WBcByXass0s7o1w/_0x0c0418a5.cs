using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x0c0418a5 : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x20971818._0xb6bbf20c.SCENE_0 && !_0x52b320fb)
        {
            this._0xcb40b3e9();
        }
        else
        {
            this._0x610cf79d();
        }
    }

    public float FirstAnimationTime = 10.0f;
    private static bool _0x52b320fb = false;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x0c0418a5>();
    }

    public float DefaultAnimationTime = 0.4f;
    public Slider AnimationSlider;
    public void _0x56481bb2()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x210bd7da?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x52b320fb = false;
    }

    public void _0x5dd8a9f4()
    {
        this._0x210bd7da?.Kill();
        this.AnimationSlider.value = _0x52b320fb ? this.SecondPassSliderValue : 0.05f;
    }

    private void _0xcb40b3e9()
    {
        this.AnimationSlider.value = 0.05f;
        _0x52b320fb = !_0x52b320fb;
        this._0x210bd7da = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x77eec657 => this.AnimationSlider.value = _0x77eec657, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x049ebdfd._0x048cc6fe?._0x15b2aac3();
        });
    }

    public static _0x0c0418a5 Instance;
    public GameObject Background;
    public void _0x610cf79d()
    {
        this._0x5dd8a9f4();
        bool _0xaa7116f6 = _0x52b320fb;
        this._0x210bd7da = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x77eec657 => this.AnimationSlider.value = _0x77eec657, _0xaa7116f6 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x52b320fb = !_0x52b320fb;
    }

    private Sequence _0x210bd7da;
    public void _0x109efdcd()
    {
        this._0x210bd7da?.Pause();
    }

    public void _0x1b301219()
    {
        this._0x210bd7da?.Play();
    }

    public float SecondPassSliderValue = 0.5f;
    public GameObject Error;
    public GameObject Content;
}