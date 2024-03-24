using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void CikisButonu()
    {
        Application.Quit();
    }

   

    public GameObject LevelsPanel;
    public void PlayButtonFunction()
    {
        LevelsPanel.SetActive(true);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public GameObject settingsPanel; // Unity Edit�r'�nde panele ba�lamak i�in

    // Ayarlar butonuna t�kland���nda �a�r�lacak fonksiyon
    public void OpenSettingsPanel()
    {
        // Panelin g�r�n�rl���n� aktifle�tir
        settingsPanel.SetActive(true);
    }

    // Bu fonksiyon Ayarlar butonu i�in eklenmi�tir.
    public void SettingsButtonFunction()
    {
        OpenSettingsPanel();
    }


    public void MainGameScene()
    {
        SceneManager.LoadScene("MainGameScene"); // MainGameScene sahnesine ge�i� yap
    }


    public GameObject hidePanel; // Kapanacak olan panelin referans�

    public void HidePanel()
    {
        hidePanel.SetActive(!hidePanel.activeSelf); // Panelin aktif durumunu tersine �evir
    }

    public void MainGameScene1 ()
    {
        SceneManager.LoadScene("MainGameScene1"); // MainGameScene sahnesine ge�i� yap
    }
    public void AnaMenuFinal()
    {
        SceneManager.LoadScene("MenuScene"); 
    }

}




