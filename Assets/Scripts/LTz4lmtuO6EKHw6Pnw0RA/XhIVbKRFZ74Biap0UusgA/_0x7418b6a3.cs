using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x7418b6a3 : MonoBehaviour
{
    private Vector3 _0xb3d776fa { get; set; }
    private Vector3 _0x6458c2e3 { get; set; }
    private Vector3 _0x9fb2e7c9 { get; set; }
    private Vector3 _0xb348c59d { get; set; }

    private void Awake()
    {
        this._0x6c47444a = this.GetComponent<Camera>();
        _0x21607505 = this;
        this._0x7ce96990();
    }

    private Vector3 _0xc6482e72 { get; set; }

    public enum _0x1b4f07d3
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xb1d26abf { get; set; }

    private _0x1b4f07d3 _0xfef1d50e = _0x1b4f07d3.Portrait;
    private void _0x7ce96990()
    {
        float _0xc09087bd, _0x5a3b010f, _0xcbf4042d, _0x6a14d85d;
        if (this._0xfef1d50e == _0x1b4f07d3.Landscape)
            this._0x6c47444a.orthographicSize = 1f / this._0x6c47444a.aspect * this._0xd6049f3d / 2f;
        else
            this._0x6c47444a.orthographicSize = this._0xd6049f3d / 2f;
        this._0xa3274605 = 2f * this._0x6c47444a.orthographicSize;
        this._0x769f39ed = this._0xa3274605 * this._0x6c47444a.aspect;
        float _0xa906c23b = this._0x6c47444a.transform.position.x;
        float _0x4c7bffff = this._0x6c47444a.transform.position.y;
        _0xc09087bd = _0xa906c23b - this._0x769f39ed / 2;
        _0x5a3b010f = _0xa906c23b + this._0x769f39ed / 2;
        _0xcbf4042d = _0x4c7bffff + this._0xa3274605 / 2;
        _0x6a14d85d = _0x4c7bffff - this._0xa3274605 / 2;
        this._0x6b6fd773 = new Vector3(_0xc09087bd, _0x6a14d85d, 0);
        this._0xea50cb78 = new Vector3(_0xa906c23b, _0x6a14d85d, 0);
        this._0xc6482e72 = new Vector3(_0x5a3b010f, _0x6a14d85d, 0);
        this._0xb348c59d = new Vector3(_0xc09087bd, _0x4c7bffff, 0);
        this._0xb3d776fa = new Vector3(_0xa906c23b, _0x4c7bffff, 0);
        this._0x9fb2e7c9 = new Vector3(_0x5a3b010f, _0x4c7bffff, 0);
        this._0x6458c2e3 = new Vector3(_0xc09087bd, _0xcbf4042d, 0);
        this._0xdde4e902 = new Vector3(_0xa906c23b, _0xcbf4042d, 0);
        this._0xb1d26abf = new Vector3(_0x5a3b010f, _0xcbf4042d, 0);
    }

    private static _0x7418b6a3 _0x21607505;
    private Color _0xf321a664 = Color.white;
    private Vector3 _0x6b6fd773 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xf321a664;
        Matrix4x4 _0xdc7d7281 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x6c47444a.orthographic)
        {
            float _0xdaf2cb92 = this._0x6c47444a.farClipPlane - this._0x6c47444a.nearClipPlane;
            float _0x9613b906 = (this._0x6c47444a.farClipPlane + this._0x6c47444a.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x9613b906), new Vector3(this._0x6c47444a.orthographicSize * 2 * this._0x6c47444a.aspect, this._0x6c47444a.orthographicSize * 2, _0xdaf2cb92));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x6c47444a.fieldOfView, this._0x6c47444a.farClipPlane, this._0x6c47444a.nearClipPlane, this._0x6c47444a.aspect);
        }

        Gizmos.matrix = _0xdc7d7281;
    }

    private new Camera _0x6c47444a;
    private float _0xa3274605 { get; set; }
    private Vector3 _0xea50cb78 { get; set; }
    //public bool executeInUpdate;
    private float _0x769f39ed { get; set; }

    private float _0xd6049f3d = 1;
    private Vector3 _0xdde4e902 { get; set; }
}