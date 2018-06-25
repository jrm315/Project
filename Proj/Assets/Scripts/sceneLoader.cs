using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour {

    public void loadScene(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void loadLevel(int level)
    {
        Application.LoadLevel(level);
    }
}
