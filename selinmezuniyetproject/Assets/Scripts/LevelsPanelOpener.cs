using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsPanelOpener : MonoBehaviour
{
    public GameObject levelsPanel; // A��lacak olan panelin referans�

    public void OpenPanel()
    {
        levelsPanel.SetActive(true); // Paneli aktif hale getir
    }
}
