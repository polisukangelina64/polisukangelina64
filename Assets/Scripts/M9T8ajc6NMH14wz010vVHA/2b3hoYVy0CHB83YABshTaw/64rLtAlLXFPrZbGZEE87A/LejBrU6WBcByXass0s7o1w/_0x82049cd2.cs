using UnityEngine;
using UnityEngine.UI;

public class _0x82049cd2 : MonoBehaviour
{
    public Button NextTutorialButton;
    public int EndTutorialPanelIndex = 1;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xe7358e6f.Instance._0x4d3ae7c9(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x8758f65d.Instance._0x653dcef7());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xe7358e6f.Instance._0x4d3ae7c9(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xe7358e6f.Instance._0x4d3ae7c9(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x8758f65d.Instance._0x653dcef7());
        }
    }

    public bool IsTutorialEndPanel;
    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
}