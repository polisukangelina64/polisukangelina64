using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The five fixed paylines drawn as thin segments over the reel window, lit only while a
/// win is being presented.
/// </summary>
public sealed class _0x16323ba0 : MonoBehaviour
{
    private readonly Image[][] _0x3548bcd0 = new Image[_0xc19b7c1c.LineCount][];
    public void _0xeb5d11c2()
    {
        for (int _0xf56153a4 = 0; _0xf56153a4 < _0xc19b7c1c.LineCount; _0xf56153a4++)
        {
            if (this._0x3548bcd0[_0xf56153a4] == null)
            {
                continue;
            }

            for (int _0x212bdbf5 = 0; _0x212bdbf5 < this._0x3548bcd0[_0xf56153a4].Length; _0x212bdbf5++)
            {
                Image _0x0380b424 = this._0x3548bcd0[_0xf56153a4][_0x212bdbf5];
                if (_0x0380b424 == null)
                {
                    continue;
                }

                DOTween.Kill(_0x0380b424, false);
                _0x0380b424.color = _0xda5d4a35.Fade(_0xda5d4a35._0x8a0e3d68, 0f);
            }
        }
    }

    private _0x6759e2cf _0x9f35b50f;
    private void OnDestroy()
    {
        this._0xeb5d11c2();
    }

    public void _0xda854e7f(RectTransform _0x4f9ce304, _0xc19b7c1c _0xe85ee421, _0x6759e2cf _0xae90c04d, float[] _0x622c9971, float[] _0x013cae98, float _0xf9f407c3)
    {
        this._0x9f35b50f = _0xae90c04d;
        RectTransform _0x1140e0cd = _0xed2439e2.Node(_0x4f9ce304, _0x696cd758._0xda5f590a(new byte[12] { 29, 44, 52, 33, 36, 35, 40, 1, 44, 52, 40, 63 }, 77), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1200f, 900f));
        for (int _0x55f5ad4e = 0; _0x55f5ad4e < _0xc19b7c1c.LineCount; _0x55f5ad4e++)
        {
            int[] _0xbd66b006 = _0xe85ee421._0x385c953f(_0x55f5ad4e);
            this._0x3548bcd0[_0x55f5ad4e] = new Image[_0xc19b7c1c.Reels - 1];
            for (int _0xdbaea988 = 0; _0xdbaea988 < _0xc19b7c1c.Reels - 1; _0xdbaea988++)
            {
                Vector2 _0xf952d0d9 = new Vector2(_0x622c9971[_0xdbaea988], _0x013cae98[_0xbd66b006[_0xdbaea988]]);
                Vector2 _0xdd0f7e7b = new Vector2(_0x622c9971[_0xdbaea988 + 1], _0x013cae98[_0xbd66b006[_0xdbaea988 + 1]]);
                Vector2 _0xdb3ba02a = (_0xf952d0d9 + _0xdd0f7e7b) * 0.5f;
                Vector2 _0xb7cc08d5 = _0xdd0f7e7b - _0xf952d0d9;
                float _0x600b2b94 = _0xb7cc08d5.magnitude;
                float _0xa6169a8a = Mathf.Atan2(_0xb7cc08d5.y, _0xb7cc08d5.x) * Mathf.Rad2Deg;
                Image _0xd8880688 = _0xed2439e2.Plate(_0x1140e0cd, _0x696cd758._0xda5f590a(new byte[4] { 211, 246, 241, 250 }, 159) + _0x55f5ad4e.ToString() + _0x696cd758._0xda5f590a(new byte[3] { 133, 179, 177 }, 214) + _0xdbaea988.ToString(), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), _0xdb3ba02a, new Vector2(_0x600b2b94, _0xf9f407c3), _0xda5d4a35.Fade(_0xda5d4a35._0x41b9a3a1, 0f), null, false, 1f);
                _0xd8880688.rectTransform.localEulerAngles = new Vector3(0f, 0f, _0xa6169a8a);
                this._0x3548bcd0[_0x55f5ad4e][_0xdbaea988] = _0xd8880688;
            }
        }
    }

    public void _0x0411ec3f(int _0xa530752e)
    {
        if (_0xa530752e < 0 || _0xa530752e >= _0xc19b7c1c.LineCount || this._0x3548bcd0[_0xa530752e] == null)
        {
            return;
        }

        float _0xc8bd86ba = this._0x9f35b50f != null && this._0x9f35b50f._0x8b476d41 ? 0.3f : 0.8f;
        for (int _0x8c71aff9 = 0; _0x8c71aff9 < this._0x3548bcd0[_0xa530752e].Length; _0x8c71aff9++)
        {
            Image _0x21484107 = this._0x3548bcd0[_0xa530752e][_0x8c71aff9];
            if (_0x21484107 == null)
            {
                continue;
            }

            _0x21484107.color = _0xda5d4a35.Fade(_0xda5d4a35._0x8a0e3d68, 0f);
            _0x21484107.DOFade(_0xc8bd86ba, 0.22f).SetDelay(_0x8c71aff9 * 0.08f).SetLoops(2, LoopType.Yoyo).SetLink(_0x21484107.gameObject);
        }
    }
}

internal static class _0x696cd758
{
    internal static string _0xda5f590a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}