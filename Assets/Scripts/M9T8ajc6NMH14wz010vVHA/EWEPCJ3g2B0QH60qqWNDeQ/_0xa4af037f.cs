using UnityEngine;

public class _0xa4af037f : MonoBehaviour
{
    public bool IsTimerEnabled;
    public bool IsLevelIncrementOnWin;
    private void _0xef9b8a88()
    {
    }

    public bool IsBestScoreEnabled;
    public static _0xa4af037f Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xa4af037f>();
            DontDestroyOnLoad(this.gameObject);
            this._0xacb60a1a();
        }
        else
        {
            this._0xef9b8a88();
            Destroy(this.gameObject);
        }
    }

    private void _0xacb60a1a()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsSkipSplashEnabled;
    public bool IsStoryEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsTutorialEnabled;
    public bool IsLevelSelectorEnabled;
}