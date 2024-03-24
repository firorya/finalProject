using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelToSceneButton : MonoBehaviour
{
   
    public string sceneName; // Sahne ismini buradan atanabilir.

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName); // Sahneyi yükleme iþlemi
    }

}
