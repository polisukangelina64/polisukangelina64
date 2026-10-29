using UnityEngine;

/// <summary>
/// Mounts the lobby and the three-tab sheet into the template's DefaultPanel content.
/// Set-up runs in Start, never Awake: the template builds its singletons in Awake.
/// </summary>
public sealed class _0x612afb1b : MonoBehaviour
{
    [SerializeField]
    private RectTransform _lobbyHost;
    private _0x6759e2cf _0x8ee7d811;
    [SerializeField]
    private _0x06bd04c5 _art;
    private void Start()
    {
        this._0x8ee7d811 = new _0x6759e2cf()._0x2cbba19e();
        if (this._lobbyHost == null)
        {
            return;
        }

        _0x6e321f0b _0x584d61c2 = this.gameObject.AddComponent<_0x6e321f0b>();
        _0x13f6594a _0x21de0731 = this.gameObject.AddComponent<_0x13f6594a>();
        _0x584d61c2._0xeb310a76(this._lobbyHost, this._0x8ee7d811, this._art, _0x21de0731);
        _0x21de0731._0x20d43166(this._lobbyHost, this._0x8ee7d811, this._art, _0x584d61c2);
        {
#if B_LOGS
            {
                Debug.Log($"[lobby] session={this._0x8ee7d811._0x533c17db} coins={this._0x8ee7d811._0x5476a7f6}");
            }
#endif
        }
    }
}