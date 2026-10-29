using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xde0130c8 : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x8758f65d.Instance._0x927dfea1(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x8758f65d.Instance._0x927dfea1(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int LoadSceneId;
}