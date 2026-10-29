using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xb617615f : MonoBehaviour
{
    private int _0x1d025120 => this.ScoreCurrent;

    private void _0x1c4b3135()
    {
        this.IsGameEnd = true;
        _0x8758f65d.IsAfterLevelComplete = true;
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xef2d4e2f;
        this.CurrentGameIndex = _0x8758f65d.Instance._0x5e259754;
        foreach (Button _0x2944dd58 in this.HomeButtons)
            _0x2944dd58.onClick.AddListener(() =>
            {
                this._0x003719a6();
            });
        foreach (Button _0xa65f6053 in this.PauseButtons)
            _0xa65f6053.onClick.AddListener(() =>
            {
                _0x8758f65d.Instance._0xe518613b(false);
                _0x4c3ff0fb.Instance._0x77b1dff0(_0x20971818._0xde5e3e30.PAUSE);
            });
        this._0xd6dc3465();
        this.LevelNumberText.ForEach(_0x10c735b3 => _0x10c735b3.text = $"LVL {_0x8758f65d._0x6efacafb._0x899e1e81 + 1}");
        if (_0xa4af037f.Instance.IsTimerEnabled)
        {
            this._0x20de86a5();
            this.StartCoroutine(this._0x0d86a978());
        }
    }

    private void Awake()
    {
        _0xa121ac3f = this.gameObject.GetComponent<_0xb617615f>();
    }

    public void _0x003719a6()
    {
        _0x8758f65d.Instance._0xe518613b(true);
        _0x8758f65d.Instance._0x927dfea1(_0x20971818._0xb6bbf20c.SCENE_0);
    }

    private static _0xb617615f _0xa121ac3f;
    public void _0xe498d8f7()
    {
        if (!this.IsGameEnd)
        {
            this._0x1c4b3135();
            _0x8758f65d.IsAfterLevelComplete = true;
            _0x8758f65d.IsAfterLevelFailed = false;
            _0xdc4de371 _0xa02ed601 = _0x4c3ff0fb.Instance._0x152cbfaf(_0x20971818._0xde5e3e30.WIN).GetComponent<_0xdc4de371>();
            if (_0xa4af037f.Instance.IsCheckScoreEnabled)
                _0xa02ed601.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xd65781e6}";
            else
                _0xa02ed601.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xa4af037f.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x20971818._0x30583839._0xf4c009a3)
                    _0x20971818._0x30583839._0xf4c009a3 = this.ScoreCurrent;
                _0xa02ed601.ContentAdditionalText.text = $"{_0x20971818._0x30583839._0xf4c009a3}";
            }
            else
            {
                _0xa02ed601.ContentAdditionalText.text = $"{this._0x1d025120}";
                _0x20971818._0x30583839._0xf4c009a3 += this._0x1d025120;
            }

            if (_0xa4af037f.Instance.IsLevelIncrementOnWin)
                ++_0x8758f65d._0x6efacafb._0x899e1e81;
            _0x4c3ff0fb.Instance._0x77b1dff0(_0x20971818._0xde5e3e30.WIN);
        }
    }

    private void _0x9760b145()
    {
        if (this.ScoreCurrent > _0x8758f65d._0x6efacafb._0xca10d2a4)
            _0x8758f65d._0x6efacafb._0xca10d2a4 = this.ScoreCurrent;
        if (_0xa4af037f.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xd65781e6)
                this._0xe498d8f7();
    }

    public void _0x31083aff()
    {
        if (_0xa4af037f.Instance.IsOnlyWinGameEndEnabled)
            this._0xe498d8f7();
        if (!this.IsGameEnd)
        {
            this._0x1c4b3135();
            _0x8758f65d.IsAfterLevelComplete = false;
            _0x8758f65d.IsAfterLevelFailed = true;
            _0xdc4de371 _0x7de58044 = _0x4c3ff0fb.Instance._0x152cbfaf(_0x20971818._0xde5e3e30.LOSE).GetComponent<_0xdc4de371>();
            if (_0xa4af037f.Instance.IsCheckScoreEnabled)
                _0x7de58044.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xd65781e6}";
            else
                _0x7de58044.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x7de58044.ContentAdditionalText.text = $"{0}";
            _0x20971818._0x30583839._0xf4c009a3 += 0;
            _0x4c3ff0fb.Instance._0x77b1dff0(_0x20971818._0xde5e3e30.LOSE);
        }
    }

    public List<TMP_Text> TimerText = new();
    private void _0xd6dc3465()
    {
        if (_0xa4af037f.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x10c735b3 => _0x10c735b3.text = $"{this.ScoreCurrent}/{this._0xd65781e6}");
        else
            this.ScoreText.ForEach(_0x10c735b3 => _0x10c735b3.text = $"{this.ScoreCurrent}");
    }

    public void _0xb8fff766(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xd6dc3465();
            this._0x9760b145();
        }
    }

    public List<TMP_Text> SubtitleText = new();
    private void _0xda63a6c0()
    {
        if (this.ScoreCurrent >= this._0xd65781e6)
            this._0xe498d8f7();
        else
            this._0x31083aff();
    }

    private void _0x20de86a5()
    {
        this.TimerText.ForEach(_0x10c735b3 => _0x10c735b3.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xf086a1da._0x33274531(new byte[6] { 45, 45, 28, 122, 51, 51 }, 64)));
    }

    public int CustomTargetScore = 10;
    [HideInInspector]
    public bool IsGameEnd;
    private IEnumerator _0x0d86a978()
    {
        this._0x20de86a5();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x8758f65d.Instance._0x5e259754 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x8758f65d.Instance._0x50331177)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x20de86a5();
            }
        }

        if (!this.IsGameEnd)
            this._0x31083aff();
    }

    private int _0xd65781e6 => this.CustomTargetScore + _0x8758f65d._0x6efacafb._0x899e1e81 * 10;

    [HideInInspector]
    public int TimeLeft;
    public List<TMP_Text> ScoreText = new();
    public List<TMP_Text> LevelNumberText = new();
    public List<Button> HomeButtons = new();
    public int CustomTimeInitial = 30;
    public List<Button> PauseButtons = new();
    private int _0xef2d4e2f => this.CustomTimeInitial + _0x8758f65d._0x6efacafb._0x899e1e81 * 10;

    [HideInInspector]
    public int CurrentGameIndex;
    [HideInInspector]
    public int ScoreCurrent;
}

internal static class _0xf086a1da
{
    internal static string _0x33274531(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}