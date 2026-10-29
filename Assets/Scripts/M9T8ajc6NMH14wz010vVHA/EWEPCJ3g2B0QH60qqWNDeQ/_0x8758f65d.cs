using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x20971818;

public class _0x8758f65d : MonoBehaviour
{
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x8758f65d>();
        this.RootGameObject = GameObject.FindWithTag(_0xaf8a5b24._0x26c52755(new byte[4] { 160, 157, 157, 134 }, 242));
        if (this._0x5e259754 == _0xb6bbf20c.SCENE_0)
            this._0xe518613b(true);
        else
            this._0xe518613b(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x5bbee064>(true).ToList();
    }

    public void _0xe518613b(bool _0x577fc0a7)
    {
        this._0x50331177 = _0x577fc0a7;
        this._0x452773d2(!this._0x50331177);
        Physics2D.simulationMode = this._0x50331177 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x5ff625a7(this.EnvironmentWithTweensToToggle);
    }

    public Transform EnvironmentWithTweensToToggle;
    public void _0xca700ec1()
    {
        foreach (_0x5bbee064 _0x1ddbcf12 in this.MoneyCountContainers)
            _0x1ddbcf12._0x93531612();
    }

    private void _0x452773d2(bool _0x54cff560)
    {
        Rigidbody2D[] _0xbe47f28e = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x79282180 in _0xbe47f28e)
            if (_0x54cff560)
                _0x79282180.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x79282180.constraints = RigidbodyConstraints2D.None;
    }

    public Button ShowResetTutorialButton;
    private static void MakeGrid(List<RectTransform> _0xbf446233, AspectRatioFitter _0x43a3acdd, float _0x070c32e8, int _0xc85c7dab, int _0x80793273)
    {
        _0x43a3acdd.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x43a3acdd.aspectRatio = _0x070c32e8;
        foreach (RectTransform _0x0d67e30d in _0xbf446233)
        {
            int _0x9a4d9f93 = _0x0d67e30d.transform.GetSiblingIndex();
            _0x0d67e30d.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x9a4d9f93 % _0xc85c7dab) * (1f / _0xc85c7dab), (_0x80793273 - (Mathf.FloorToInt((float)_0x9a4d9f93 / _0xc85c7dab) % _0x80793273 + 1f)) * (1f / _0x80793273));
            _0x0d67e30d.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x9a4d9f93 % _0xc85c7dab + 1f) * (1f / _0xc85c7dab), (_0x80793273 - Mathf.FloorToInt((float)_0x9a4d9f93 / _0xc85c7dab) % _0x80793273) * (1f / _0x80793273));
            _0x0d67e30d.offsetMin = Vector2.zero;
            _0x0d67e30d.offsetMax = Vector2.zero;
        }
    }

    private static _0x7abde01f _0x70bebd6c => _0x7abde01f.ALL_SCENES_SETTING_SINGLETONS[0];

    public Canvas MainCanvas;
    private void _0x0089fec4()
    {
        IsAfterLevelComplete = true;
        Instance._0x927dfea1(_0xb6bbf20c.SCENE_0);
    }

    public static bool IsAfterLevelComplete;
    private IEnumerator _0x66a32e4b(string _0x02875483)
    {
        _0xe7358e6f.Instance._0x4d3ae7c9(_0x9d65fd4d.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x9ba6ac4a = SceneManager.LoadSceneAsync(_0x02875483);
        while (!_0x9ba6ac4a.isDone)
            yield return null;
    }

    public static _0x8758f65d Instance;
    private IEnumerator _0x6b6198b3(int _0x2312c094)
    {
        _0xe7358e6f.Instance._0x4d3ae7c9(_0x9d65fd4d.SPLASH);
        AsyncOperation _0xbffc0c0c = SceneManager.LoadSceneAsync(_0x2312c094);
        while (!_0xbffc0c0c.isDone)
            yield return null;
    }

    private static _0x7abde01f GAME_INDEX_SETTINGS(int _0x7f97a09e)
    {
        return _0x7abde01f.ALL_SCENES_SETTING_SINGLETONS[_0x7f97a09e];
    }

    public bool _0x50331177 { get; private set; }

    [HideInInspector]
    public List<_0x5bbee064> MoneyCountContainers = new();
    private void _0x5ff625a7(Transform _0x51c8dd64)
    {
        Transform[] _0x5da28220 = _0x51c8dd64.GetComponentsInChildren<Transform>();
        foreach (Transform _0xe4c28fcf in _0x5da28220)
            if (_0xe4c28fcf != null && DOTween.IsTweening(_0xe4c28fcf))
            {
                if (this._0x50331177)
                    DOTween.Play(_0xe4c28fcf);
                else
                    DOTween.Pause(_0xe4c28fcf);
            }
    }

    public Button DeleteProgressDataButton;
    public Transform Environment;
    public void _0xd6e3696b()
    {
        this._0x927dfea1(SceneManager.GetActiveScene().buildIndex);
    }

    private void Start()
    {
        if (this._0x5e259754 != _0xb6bbf20c.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x927dfea1(_0xb6bbf20c.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x6efacafb._0xefbe9654 = false;
            _0x4c3ff0fb.Instance._0xb2dc89d6();
            _0xe7358e6f.Instance._0x4d3ae7c9(_0x9d65fd4d.TUTORIAL0);
        });
    }

    public void _0x927dfea1(int _0x76155dac)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x6b6198b3(_0x76155dac));
    }

    public void _0x653dcef7()
    {
        _0x6efacafb._0xefbe9654 = true;
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public static _0x7abde01f _0x6efacafb => _0x7abde01f.ALL_SCENES_SETTING_SINGLETONS[Instance._0x5e259754];
    public int _0x5e259754 => SceneManager.GetActiveScene().buildIndex;

    public static bool IsAfterLevelFailed = false;
}

internal static class _0xaf8a5b24
{
    internal static string _0x26c52755(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}