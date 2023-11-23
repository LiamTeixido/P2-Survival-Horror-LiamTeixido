using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameJolt.UI;
using GameJolt.API;

public class ChangeScene : MonoBehaviour
{
    public void ChangeScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        if (SceneManager.GetActiveScene().name == "Trophies")
        {
            GameJoltUI.Instance.ShowTrophies();
        }
    }
}
