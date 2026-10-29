using TMPro;
using UnityEngine;
using static _0x20971818;

public class _0x5bbee064 : MonoBehaviour
{
    public void _0x93531612()
    {
        this.MoneyCountText.text = _0x30583839._0xf4c009a3.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xac0eac0e;
            if (this.gameObject.TryGetComponent(out _0xac0eac0e))
                this.MoneyCountText = _0xac0eac0e;
        }

        this._0x93531612();
    }

    public TMP_Text MoneyCountText;
}