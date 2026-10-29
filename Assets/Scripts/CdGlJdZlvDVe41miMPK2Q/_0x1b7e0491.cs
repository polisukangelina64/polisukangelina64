using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x1b7e0491 : MonoBehaviour
{
    private const float MinOutlineWidth = 0.01f;
    private static void Fix(TMP_Text _0xfd5c2828)
    {
        if (_0xfd5c2828 == null || !_0xfd5c2828.isActiveAndEnabled)
            return;
        Material _0x671bf9f2 = _0xfd5c2828.fontSharedMaterial;
        if (_0x671bf9f2 == null || !_0x671bf9f2.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x671bf9f2.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x671bf9f2.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x615dbfa3 = _0xfd5c2828.color;
        if (_0x615dbfa3.a <= 0f)
            return;
        Color _0xee8dee9d = _0x671bf9f2.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x615dbfa3, _0xee8dee9d) >= MinRatio)
            return;
        Color _0xfa814ca6 = Luminance(_0xee8dee9d) < 0.5f ? Color.white : Color.black;
        Color _0xb444072c;
        if (Ratio(_0xfa814ca6, _0xee8dee9d) < TargetRatio)
        {
            _0xb444072c = _0xfa814ca6;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xfb27ca6a = 0f;
            float _0xdc9dad53 = 1f;
            for (int _0x8e5fa874 = 0; _0x8e5fa874 < 20; _0x8e5fa874++)
            {
                float _0x09c04fcf = (_0xfb27ca6a + _0xdc9dad53) * 0.5f;
                if (Ratio(Color.Lerp(_0x615dbfa3, _0xfa814ca6, _0x09c04fcf), _0xee8dee9d) >= TargetRatio)
                    _0xdc9dad53 = _0x09c04fcf;
                else
                    _0xfb27ca6a = _0x09c04fcf;
            }

            _0xb444072c = Color.Lerp(_0x615dbfa3, _0xfa814ca6, _0xdc9dad53);
        }

        _0xb444072c.a = _0x615dbfa3.a;
        _0xfd5c2828.color = _0xb444072c;
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x4f7166a8;
    private readonly HashSet<TMP_Text> _0x852411cd = new HashSet<TMP_Text>();
    private static float Ratio(Color _0x8a6ecec1, Color _0xe81c8ff8)
    {
        float _0x933df396 = Luminance(_0x8a6ecec1);
        float _0xb0ac5f04 = Luminance(_0xe81c8ff8);
        return (Mathf.Max(_0x933df396, _0xb0ac5f04) + 0.05f) / (Mathf.Min(_0x933df396, _0xb0ac5f04) + 0.05f);
    }

    private void OnEnable()
    {
        if (this._0x4f7166a8 == null)
            this._0x4f7166a8 = _0x8ca18462 => this._0x1eca962d(_0x8ca18462);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x4f7166a8);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x1eca962d(Object _0xc47d50f3)
    {
        TMP_Text _0x54212898 = _0xc47d50f3 as TMP_Text;
        if (_0x54212898 != null)
            this._0x852411cd.Add(_0x54212898);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x558b4bcf)
    {
        return 0.2126f * Linear(_0x558b4bcf.r) + 0.7152f * Linear(_0x558b4bcf.g) + 0.0722f * Linear(_0x558b4bcf.b);
    }

    private readonly List<TMP_Text> _0xda3e588b = new List<TMP_Text>();
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xa9091925 != null)
            return;
        GameObject _0x5fc35eeb = new GameObject(_0xd6c66562._0x0eede28d(new byte[16] { 86, 111, 114, 65, 109, 108, 118, 112, 99, 113, 118, 69, 119, 99, 112, 102 }, 2));
        _0x5fc35eeb.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x5fc35eeb);
        _0xa9091925 = _0x5fc35eeb.AddComponent<_0x1b7e0491>();
    }

    private const float TargetRatio = 7f;
    private static _0x1b7e0491 _0xa9091925;
    private const float MinRatio = 4.5f;
    private void OnDisable()
    {
        if (this._0x4f7166a8 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x4f7166a8);
    }

    private static float Linear(float _0xd7c2e657)
    {
        _0xd7c2e657 = Mathf.Clamp01(_0xd7c2e657);
        return _0xd7c2e657 <= 0.03928f ? _0xd7c2e657 / 12.92f : Mathf.Pow((_0xd7c2e657 + 0.055f) / 1.055f, 2.4f);
    }

    private void LateUpdate()
    {
        if (this._0x852411cd.Count == 0)
            return;
        this._0xda3e588b.Clear();
        this._0xda3e588b.AddRange(this._0x852411cd);
        this._0x852411cd.Clear();
        for (int _0xb43fd7d7 = 0; _0xb43fd7d7 < this._0xda3e588b.Count; _0xb43fd7d7++)
            Fix(this._0xda3e588b[_0xb43fd7d7]);
    }
}

internal static class _0xd6c66562
{
    internal static string _0x0eede28d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}