using System;
using TMPro;
using UnityEngine;

/// <summary>
/// Every sprite the game draws, wired in the scene by guid. Nothing is ever looked up
/// by name or loaded from Resources.
/// </summary>
[Serializable]
public sealed class _0x06bd04c5
{
    public Sprite _0x763ef5b3 => this._iconCheck;

    [SerializeField]
    private Sprite _symCherry;
    [SerializeField]
    private Sprite _symBell;
    [SerializeField]
    private Sprite _winBurst;
    [SerializeField]
    private TMP_FontAsset _font;
    /// <summary>Symbol art by <see cref = "ReelMath"/> symbol id, 0..9.</summary>
    public Sprite _0xe0c1eb60(int _0xd6500786)
    {
        switch (_0xd6500786)
        {
            case 0:
                return this._symCherry;
            case 1:
                return this._symLemon;
            case 2:
                return this._symPlum;
            case 3:
                return this._symWatermelon;
            case 4:
                return this._symGrapes;
            case 5:
                return this._symBell;
            case 6:
                return this._symCrown;
            case 7:
                return this._symSeven;
            case 8:
                return this._symCloverWild;
            default:
                return this._symCoinScatter;
        }
    }

    [SerializeField]
    private Sprite _symWatermelon;
    [SerializeField]
    private Sprite _spinButton;
    [SerializeField]
    private Sprite _reelBackplate;
    [SerializeField]
    private Sprite _curtainDrape;
    public TMP_FontAsset _0x533877f5 => this._font;

    [SerializeField]
    private Sprite _symLemon;
    public Sprite _0x9bfff5f8 => this._curtainDrape;

    [SerializeField]
    private Sprite _symPlum;
    public Sprite _0x62eb50b4 => this._winBurst;
    public Sprite _0xa84b870d => this._cornerOrnament;

    [SerializeField]
    private Sprite _symCloverWild;
    public Sprite _0xe07d1da7 => this._emblemClover;

    [SerializeField]
    private Sprite _iconCoin;
    public Sprite _0x75576c26 => this._iconBack;

    [SerializeField]
    private Sprite _iconCheck;
    public Sprite _0xfcd03d27 => this._iconClose;

    [SerializeField]
    private Sprite _symCoinScatter;
    [SerializeField]
    private Sprite _symGrapes;
    [SerializeField]
    private Sprite _iconBack;
    public Sprite _0xfef0941d => this._iconPause;
    public Sprite _0x8733093d => this._reelBackplate;

    [SerializeField]
    private Sprite _symCrown;
    [SerializeField]
    private Sprite _emblemClover;
    public Sprite _0xac38e132 => this._spinButton;

    [SerializeField]
    private Sprite _cornerOrnament;
    public Sprite _0xef40aae3 => this._iconCoin;

    [SerializeField]
    private Sprite _symSeven;
    [SerializeField]
    private Sprite _iconClose;
    [SerializeField]
    private Sprite _iconPause;
}