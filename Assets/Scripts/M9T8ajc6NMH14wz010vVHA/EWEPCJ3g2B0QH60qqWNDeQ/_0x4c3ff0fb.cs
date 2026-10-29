using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x20971818;

public class _0x4c3ff0fb : MonoBehaviour
{
    public List<GameObject> GameObjectsToHide;
    public static _0x4c3ff0fb Instance;
    public List<_0xdc4de371> Pops;
    private void _0xad43d21d()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public int CurrentPopIndex;
    public float ScaleDuration = 0.4f;
    public void _0x53ea034e()
    {
        this.LastPopIndexes.RemoveAll(_0x61a5848c => _0x61a5848c == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xb2dc89d6();
        else
            this._0x77b1dff0(this.LastPopIndexes.Last());
    }

    private void _0xad009c7d(bool _0x437557c1 = false)
    {
        for (int _0x66e04674 = 0; _0x66e04674 < this.Pops.Count; ++_0x66e04674)
            if (this.Pops[_0x66e04674] != null && !(_0x66e04674 == this.CurrentPopIndex && _0x437557c1))
                this.Pops[_0x66e04674]._0x3755b0d0();
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public GameObject BlurBackground;
    public _0xdc4de371 _0x152cbfaf(int _0xe0ca9407)
    {
        return this.Pops[_0xe0ca9407];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x4c3ff0fb>();
    }

    public List<int> LastPopIndexes = new();
    private void _0x5364cfa9()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public void _0xb2dc89d6()
    {
        this.LastPopIndexes.Clear();
        this._0xad009c7d();
        foreach (GameObject _0xd7ba639d in this.GameObjectsToHide)
            if (_0xd7ba639d != null)
                _0xd7ba639d.SetActive(true);
        this._0x5364cfa9();
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xdc4de371 _0x928761f5 in this.Pops)
            if (_0x928761f5 != null)
                _0x928761f5.gameObject.SetActive(true);
    }

    public void _0x77b1dff0(int _0x2471b959)
    {
        this.CurrentPopIndex = _0x2471b959;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xad009c7d(true);
        this._0xad43d21d();
        this.Pops[_0x2471b959].Show();
        foreach (GameObject _0x5a1fc3b1 in this.GameObjectsToHide)
            _0x5a1fc3b1.SetActive(false);
    }
}