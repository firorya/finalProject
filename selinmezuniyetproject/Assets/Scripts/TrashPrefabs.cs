using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPrefabs : MonoBehaviour
{
    public GameObject copPrefab; // Unity Edit�r �zerinden ��p prefab'�n� atay�n
    public Transform spawnPoint; // ��plerin ba�lang�� pozisyonu

    public float spawnSuresi = 2f; // Her ��p aras�ndaki s�re

    void Start()
    {
        // ��pleri belirli aral�klarla olu�tur
        InvokeRepeating("CopOlustur", 0f, spawnSuresi);
    }

    void CopOlustur()
    {
        // ��p prefab'�n� spawnPoint pozisyonunda olu�tur
        Instantiate(copPrefab, spawnPoint.position, Quaternion.identity);
    }
}
