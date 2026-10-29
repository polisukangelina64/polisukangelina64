using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x810c1e21 : MonoBehaviour
{
    private AspectRatioFitter _0x77779091;
    private float _0xfc2b86ba = 0.6f;
    private float _0x21df1886 = 1.5f;
    private TMP_Text _0x0f5c0201;
    private float _0x6ab9dd4e = 4;
    private List<string> _0x1a7262a4 = new();
    private void Update()
    {
        int _0x351f24ff = 1;
        if (this._0x1a7262a4.Count > 0)
        {
            string _0x1a3a7c62 = this._0x0f5c0201.text;
            foreach (string _0x9c7617cf in this._0x1a7262a4)
                while (_0x1a3a7c62.Contains(_0x9c7617cf))
                    _0x1a3a7c62 = _0x1a3a7c62.Replace(_0x9c7617cf, "");
            _0x351f24ff = _0x1a3a7c62.Length;
        }
        else
        {
            _0x351f24ff = this._0x0f5c0201.text.Length;
        }

        float _0xb45d15d7 = Mathf.Clamp(this._0x58cc24c6 + this._0xfc2b86ba * _0x351f24ff, this._0x21df1886, this._0x6ab9dd4e);
        if (!Mathf.Approximately(this._0x77779091.aspectRatio, _0xb45d15d7))
            this._0x77779091.aspectRatio = _0xb45d15d7;
    }

    private float _0x58cc24c6;
}