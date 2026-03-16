using UnityEngine;
using UnityEngine.SceneManagement;

public class StageControl : MonoBehaviour
{
    public void PressPlay()
    {
        SceneManager.LoadScene(3);
    }
}
