using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsPanelOpener : MonoBehaviour
{
    public GameObject levelsPanel; // Açýlacak olan panelin referansý

    public void OpenPanel()
    {
        levelsPanel.SetActive(true); // Paneli aktif hale getir
    }
}
