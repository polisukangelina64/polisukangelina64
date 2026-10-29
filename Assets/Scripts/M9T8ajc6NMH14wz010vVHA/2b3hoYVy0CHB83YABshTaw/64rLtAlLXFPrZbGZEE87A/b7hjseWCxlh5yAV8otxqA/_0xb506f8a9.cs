using UnityEngine;
using UnityEngine.UI;

public class _0xb506f8a9 : MonoBehaviour
{
    public int PopToShowIndex;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x4c3ff0fb.Instance._0x53ea034e();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x4c3ff0fb.Instance._0xb2dc89d6());
        else
            this.Button.onClick.AddListener(() => _0x4c3ff0fb.Instance._0x77b1dff0(this.PopToShowIndex));
    }

    public bool IsHideAllPops;
    public bool IsShowLastPop;
}