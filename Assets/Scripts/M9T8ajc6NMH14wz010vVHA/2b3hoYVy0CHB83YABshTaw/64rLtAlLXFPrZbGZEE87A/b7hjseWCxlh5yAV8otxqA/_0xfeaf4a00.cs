using UnityEngine;
using UnityEngine.UI;

public class _0xfeaf4a00 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x8758f65d.Instance._0xe518613b(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}