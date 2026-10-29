using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8babfc51 : MonoBehaviour
{
    private TMP_Text _0xe5f75b51;
    private void _0xc1962df5()
    {
        if (this._0xd84163aa.canvasRenderer.GetColor() != this._0xe5f75b51.canvasRenderer.GetColor())
            this._0xe5f75b51.canvasRenderer.SetColor(this._0xd84163aa.canvasRenderer.GetColor());
    }

    private Image _0xd84163aa;
    private void Update()
    {
        this._0xc1962df5();
    }
}