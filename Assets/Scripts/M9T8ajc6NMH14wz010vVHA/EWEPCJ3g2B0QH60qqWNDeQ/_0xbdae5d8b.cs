using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xbdae5d8b : MonoBehaviour
{
    private Touch? _0x2a791415()
    {
        if (!_0x8758f65d.Instance._0x50331177)
            return null;
        foreach (Touch _0xc37c1bba in Touch.activeTouches)
            if (!_0xc37c1bba.ended)
                if (this._0x8651b769(_0xc37c1bba))
                    return _0xc37c1bba;
        return null;
    }

    private Touch? _0x204e8193(Bounds _0x3a018989, TouchPhase _0xc9097b22)
    {
        if (!_0x8758f65d.Instance._0x50331177)
            return null;
        foreach (Touch _0xf008717b in Touch.activeTouches)
            if (_0xf008717b.phase == _0xc9097b22)
            {
                Vector3 _0x0c3b17b0 = Camera.main.ScreenToWorldPoint(_0xf008717b.screenPosition);
                Vector3 _0x67e23e22 = new(_0x0c3b17b0.x, _0x0c3b17b0.y, _0x3a018989.center.z);
                if (_0x3a018989.Contains(_0x67e23e22) && this._0x8651b769(_0xf008717b))
                    return _0xf008717b;
            }

        return null;
    }

    private bool _0x8651b769(Touch? _0x054d66bb)
    {
        if (!_0x054d66bb.HasValue)
            return false;
        Vector3 _0x82fcda97 = Camera.main.ScreenToWorldPoint(_0x054d66bb.Value.screenPosition);
        Vector3 _0xfed63932 = _0x82fcda97;
        _0xfed63932.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xfed63932))
            return true;
        _0x054d66bb = null;
        return false;
    }

    private static _0xbdae5d8b _0x0cd33e9b;
    private Touch? _0x76173a41()
    {
        if (!_0x8758f65d.Instance._0x50331177)
            return null;
        foreach (Touch _0x23697bc5 in Touch.activeTouches)
            if (_0x23697bc5.ended)
                if (this._0x8651b769(_0x23697bc5))
                    return _0x23697bc5;
        return null;
    }

    private Touch? _0x47785e71(Bounds _0x8c72ab6c)
    {
        if (!_0x8758f65d.Instance._0x50331177)
            return null;
        foreach (Touch _0xefa5072f in Touch.activeTouches)
            if (_0xefa5072f.ended)
            {
                Vector3 _0x79ea798c = Camera.main.ScreenToWorldPoint(_0xefa5072f.screenPosition);
                Vector3 _0x78ea49fe = new(_0x79ea798c.x, _0x79ea798c.y, _0x8c72ab6c.center.z);
                if (_0x8c72ab6c.Contains(_0x78ea49fe) && this._0x8651b769(_0xefa5072f))
                    return _0xefa5072f;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private bool _0x3295449a(Touch? _0x506c93e1, Bounds _0x1dae9e6f, TouchPhase _0x3cef07e9)
    {
        if (!_0x8758f65d.Instance._0x50331177)
        {
            _0x506c93e1 = null;
            return false;
        }

        if (_0x506c93e1 != null)
            if (_0x506c93e1.Value.phase == _0x3cef07e9)
            {
                Vector3 _0xb6c188d3 = Camera.main.ScreenToWorldPoint(_0x506c93e1.Value.screenPosition);
                Vector3 _0x53029fd1 = new(_0xb6c188d3.x, _0xb6c188d3.y, _0x1dae9e6f.center.z);
                if (_0x1dae9e6f.Contains(_0x53029fd1) && this._0x8651b769(_0x506c93e1.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0xfced93f4(Bounds _0xbbfec6c7)
    {
        if (!_0x8758f65d.Instance._0x50331177)
            return null;
        foreach (Touch _0xd1a59748 in Touch.activeTouches)
            if (!_0xd1a59748.ended)
            {
                Vector3 _0xe54c851e = Camera.main.ScreenToWorldPoint(_0xd1a59748.screenPosition);
                Vector3 _0xa70d4dfd = new(_0xe54c851e.x, _0xe54c851e.y, _0xbbfec6c7.center.z);
                if (_0xbbfec6c7.Contains(_0xa70d4dfd) && this._0x8651b769(_0xd1a59748))
                    return _0xd1a59748;
            }

        return null;
    }

    private void _0x386febf0(Touch? _0x63b11447)
    {
        if (!_0x8758f65d.Instance._0x50331177)
        {
            _0x63b11447 = null;
            return;
        }

        int _0xc6ae1633 = _0x63b11447.Value.touchId;
        _0x63b11447 = Touch.activeTouches.FirstOrDefault(_0xa12f6d0d => _0xa12f6d0d.touchId == _0xc6ae1633);
        if (!this._0x8651b769(_0x63b11447.Value))
            _0x63b11447 = null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x0cd33e9b = this.gameObject.GetComponent<_0xbdae5d8b>();
    }
}