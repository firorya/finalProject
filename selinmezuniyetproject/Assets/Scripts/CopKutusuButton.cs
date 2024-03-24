using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopKutusuButton : MonoBehaviour
{
    public string kutuTuru; // Unity Edit�r �zerinden ��p kutusunun t�r�n� atay�n
    public GameObject cop; // Unity Edit�r �zerinden cam �i�e objesini atay�n
    public Text paraText; // Unity Edit�r �zerinden para textini atay�n
    public int paraMiktari = 5; // Her ��p yok oldu�unda eklenecek para miktar�
    public int maxPara = 40;
    public GameObject tamamPanel;
    private void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        // E�er ��p kutusuna t�klan�rsa, cam �i�eyi yok et
        Destroy(cop);

        // Para miktar�n� g�ncelle
        UpdateParaMiktari();
    }

    private void UpdateParaMiktari()
    {
        // Mevcut para miktar�n� al ve �zerine paraMiktari de�erini ekle
        int mevcutPara = int.Parse(paraText.text);
        mevcutPara += paraMiktari;

        // Maksimum uzunlu�u kontrol et
        if (mevcutPara >= maxPara)
        {
            mevcutPara = maxPara;
            // Paneli a�
            tamamPanel.SetActive(true);
        }

        // Yeni para miktar�n� g�ncelle
        paraText.text = mevcutPara.ToString();

    }
}



