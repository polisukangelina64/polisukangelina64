using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x20971818;

public class _0xe7358e6f : MonoBehaviour
{
    public bool IsShowSplashOnStart = true;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xe7358e6f>();
    }

    public static _0xe7358e6f Instance;
    private void _0xec233c95(int _0x2bbf1d28)
    {
        this._0x69cedd59(_0x2bbf1d28);
        this._0x0a6bce78(_0x2bbf1d28);
        this.CurrentPanelIndex = _0x2bbf1d28;
        this.Panels[_0x2bbf1d28]._0x357ff583();
    }

    public void _0x4a47e359(int _0x9c1d9985)
    {
        if (_0x9c1d9985 == _0x9d65fd4d.SPLASH && _0x8758f65d.Instance._0x5e259754 != _0xb6bbf20c.SCENE_0)
            _0x0c0418a5.Instance._0x610cf79d();
        if (_0x8758f65d.Instance._0x5e259754 != _0xb6bbf20c.SCENE_0)
        {
            if (_0x9c1d9985 == _0x9d65fd4d.SPLASH || _0x9c1d9985 == _0x9d65fd4d.TUTORIAL0)
                _0x8758f65d.Instance._0xe518613b(false);
            else if (_0x9c1d9985 == _0x9d65fd4d.DEFAULT)
                _0x8758f65d.Instance._0xe518613b(true);
        }
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private _0xf5f79030 _0xf71c6718(int _0xe359e272)
    {
        return this.Panels[_0xe359e272];
    }

    private void _0xaa65cf6d()
    {
        this._0xec233c95(_0x9d65fd4d.SPLASH);
        if (_0x8758f65d.Instance._0x5e259754 == _0xb6bbf20c.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x0c0418a5.Instance.DefaultAnimationTime);
        }
    }

    public void _0x4d3ae7c9(int _0xc619b521)
    {
        this._0x69cedd59(_0xc619b521);
        this._0x0a6bce78(_0xc619b521);
        this.CurrentPanelIndex = _0xc619b521;
        this.Panels[_0xc619b521].Show();
    }

    public int CurrentPanelIndex;
    public float ScaleDuration = 0.4f;
    public List<_0xf5f79030> Panels;
    private void Start()
    {
        this._0xaa65cf6d();
    }

    private void SwitchSplash()
    {
        if (_0xa4af037f.Instance.IsTutorialEnabled && !_0x8758f65d._0x6efacafb._0xefbe9654)
            this._0x4d3ae7c9(_0x9d65fd4d.TUTORIAL0);
        else
            this._0x4d3ae7c9(_0x9d65fd4d.DEFAULT);
    }

    private void _0x69cedd59(int _0x090e2f39)
    {
        this.LastPanelIndexes.Add(_0x090e2f39);
        this.CurrentPanelIndex = _0x090e2f39;
        for (int _0x7699b85a = 0; _0x7699b85a < this.Panels.Count; _0x7699b85a++)
            if (_0x7699b85a != _0x090e2f39 && this.Panels[_0x7699b85a] != null)
                this.Panels[_0x7699b85a]._0xcb328ee9();
    }

    private void _0x0a6bce78(int _0xe8aa222c)
    {
        if (_0xe8aa222c == _0x9d65fd4d.SPLASH)
            _0x0c0418a5.Instance._0x5dd8a9f4();
        if (_0x8758f65d.Instance._0x5e259754 == _0xb6bbf20c.SCENE_0)
        {
        }
    }

    public float StaticBlurMaterialInitialValue;
    private void _0xf01e9e97(int _0x68b83901)
    {
        this.LastPanelIndexes.Add(_0x68b83901);
        this.CurrentPanelIndex = _0x68b83901;
        for (int _0xbcb8c0e4 = 0; _0xbcb8c0e4 < this.Panels.Count; _0xbcb8c0e4++)
            if (_0xbcb8c0e4 != _0x68b83901 && this.Panels[_0xbcb8c0e4] != null)
                this.Panels[_0xbcb8c0e4]._0xcb328ee9();
    }

    public void _0xdb294552()
    {
        this.LastPanelIndexes.RemoveAll(_0x61a5848c => _0x61a5848c == this.CurrentPanelIndex);
        int _0xd159fb12 = this.LastPanelIndexes.Last();
        this._0x0a6bce78(_0xd159fb12);
        this._0xf01e9e97(_0xd159fb12);
        this.CurrentPanelIndex = _0xd159fb12;
        this.Panels[_0xd159fb12].Show();
    }
}