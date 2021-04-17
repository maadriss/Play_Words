using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public void PauseTime()
    {
        Time.timeScale = 0;
    }
    public void PlayTime()
    {
        Time.timeScale = 1;
    }
}
