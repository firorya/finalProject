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

    public GameObject settingsPanel; // Unity Editör'ünde panele baðlamak için

    // Ayarlar butonuna týklandýðýnda çaðrýlacak fonksiyon
    public void OpenSettingsPanel()
    {
        // Panelin görünürlüðünü aktifleþtir
        settingsPanel.SetActive(true);
    }

    // Bu fonksiyon Ayarlar butonu için eklenmiþtir.
    public void SettingsButtonFunction()
    {
        OpenSettingsPanel();
    }


    public void MainGameScene()
    {
        SceneManager.LoadScene("MainGameScene"); // MainGameScene sahnesine geçiþ yap
    }


    public GameObject hidePanel; // Kapanacak olan panelin referansý

    public void HidePanel()
    {
        hidePanel.SetActive(!hidePanel.activeSelf); // Panelin aktif durumunu tersine çevir
    }

    public void MainGameScene1 ()
    {
        SceneManager.LoadScene("MainGameScene1"); // MainGameScene sahnesine geçiþ yap
    }
    public void AnaMenuFinal()
    {
        SceneManager.LoadScene("MenuScene"); 
    }

}




