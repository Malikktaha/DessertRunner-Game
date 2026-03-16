using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRun : MonoBehaviour
{
    [SerializeField] GameObject fadeOut;

    public void Start()
    {
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
