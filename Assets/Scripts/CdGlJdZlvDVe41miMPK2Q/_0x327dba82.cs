using TMPro;
using UnityEngine;

/// <summary>
/// Runtime labels never reach the file-based contrast pass, so every label this game
/// creates gets its own material instance with an outline that contrasts with the face.
/// </summary>
public static class _0x327dba82
{
    public static void ApplyOutline(TMP_Text _0xc98df5fa)
    {
        if (_0xc98df5fa == null)
        {
            return;
        }

        Material _0x317f0235 = _0xc98df5fa.fontMaterial;
        if (_0x317f0235 == null)
        {
            return;
        }

        Color _0xd4bd6425 = _0xc98df5fa.color;
        float _0xbf521ffc = (0.299f * _0xd4bd6425.r) + (0.587f * _0xd4bd6425.g) + (0.114f * _0xd4bd6425.b);
        _0x317f0235.SetColor(ShaderUtilities.ID_OutlineColor, _0xbf521ffc < 0.5f ? _0xda5d4a35._0x64f656bb : _0xda5d4a35._0xd4e968dd);
        _0x317f0235.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
        _0x317f0235.SetFloat(ShaderUtilities.ID_FaceDilate, 0.14f);
    }
}