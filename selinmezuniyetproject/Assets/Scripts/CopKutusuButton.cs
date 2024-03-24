using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopKutusuButton : MonoBehaviour
{
    public string kutuTuru; // Unity Editör üzerinden çöp kutusunun türünü atayýn
    public GameObject cop; // Unity Editör üzerinden cam þiþe objesini atayýn
    public Text paraText; // Unity Editör üzerinden para textini atayýn
    public int paraMiktari = 5; // Her çöp yok olduðunda eklenecek para miktarý
    public int maxPara = 40;
    public GameObject tamamPanel;
    private void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        // Eðer çöp kutusuna týklanýrsa, cam þiþeyi yok et
        Destroy(cop);

        // Para miktarýný güncelle
        UpdateParaMiktari();
    }

    private void UpdateParaMiktari()
    {
        // Mevcut para miktarýný al ve üzerine paraMiktari deðerini ekle
        int mevcutPara = int.Parse(paraText.text);
        mevcutPara += paraMiktari;

        // Maksimum uzunluðu kontrol et
        if (mevcutPara >= maxPara)
        {
            mevcutPara = maxPara;
            // Paneli aç
            tamamPanel.SetActive(true);
        }

        // Yeni para miktarýný güncelle
        paraText.text = mevcutPara.ToString();

    }
}



