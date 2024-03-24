using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPrefabs : MonoBehaviour
{
    public GameObject copPrefab; // Unity Editör üzerinden çöp prefab'ýný atayýn
    public Transform spawnPoint; // Çöplerin baþlangýç pozisyonu

    public float spawnSuresi = 2f; // Her çöp arasýndaki süre

    void Start()
    {
        // Çöpleri belirli aralýklarla oluþtur
        InvokeRepeating("CopOlustur", 0f, spawnSuresi);
    }

    void CopOlustur()
    {
        // Çöp prefab'ýný spawnPoint pozisyonunda oluþtur
        Instantiate(copPrefab, spawnPoint.position, Quaternion.identity);
    }
}
