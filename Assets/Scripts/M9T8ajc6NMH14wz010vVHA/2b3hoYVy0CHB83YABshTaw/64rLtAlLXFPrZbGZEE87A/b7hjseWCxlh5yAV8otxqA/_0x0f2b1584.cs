using UnityEngine;
using UnityEngine.UI;

public class _0x0f2b1584 : MonoBehaviour
{
    private Button _0xbfdbca9b;
    private bool _0xabcef0a1;
    private void Awake()
    {
        if (this._0xbfdbca9b == null)
            if (!this.TryGetComponent(out this._0xbfdbca9b))
                this._0xbfdbca9b = this.GetComponentInChildren<Button>();
    }

    private int _0x54f88574;
    private void Start()
    {
        if (this._0xabcef0a1)
            this._0xbfdbca9b.onClick.AddListener(() => _0xe7358e6f.Instance._0xdb294552());
        else
            this._0xbfdbca9b.onClick.AddListener(() => _0xe7358e6f.Instance._0x4d3ae7c9(this._0x54f88574));
    }
}