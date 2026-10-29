using UnityEngine;

/// <summary>
/// Mounts the reels into the game scene's DefaultPanel content. Anything the template
/// parented there belongs to a different game, so it is switched off first; this game
/// holds no reference to those objects.
/// </summary>
public sealed class _0xc8e0098b : MonoBehaviour
{
    private _0x6759e2cf _0x08ab1e25;
    private void Start()
    {
        this._0x08ab1e25 = new _0x6759e2cf()._0x2cbba19e();
        if (this._reelsHost == null)
        {
            return;
        }

        for (int _0x46e1eae8 = this._reelsHost.childCount - 1; _0x46e1eae8 >= 0; _0x46e1eae8--)
        {
            Transform _0xd824f26f = this._reelsHost.GetChild(_0x46e1eae8);
            if (_0xd824f26f != null)
            {
                _0xd824f26f.gameObject.SetActive(false);
            }
        }

        if (this._pops != null)
        {
            this._pops._0xb5787ed7(this._0x08ab1e25);
        }

        _0xc3ef787a _0xa694c9de = this.gameObject.AddComponent<_0xc3ef787a>();
        _0xa694c9de._0x3a93d952(this._reelsHost, this._0x08ab1e25, this._art, this._pops);
        {
#if B_LOGS
            {
                Debug.Log($"[reels] mounted session={this._0x08ab1e25._0x533c17db} bet={this._0x08ab1e25._0xfbdf25e9}");
            }
#endif
        }
    }

    [SerializeField]
    private _0x06bd04c5 _art;
    [SerializeField]
    private _0xc67ab774 _pops;
    [SerializeField]
    private RectTransform _reelsHost;
}