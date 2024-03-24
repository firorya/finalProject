using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopHareket : MonoBehaviour
{
    public float hiz = 5f; // Çöpün düþüþ hýzý

    void Update()
    {
        // Çöpü aþaðý doðru hareket ettir
        transform.Translate(Vector2.down * hiz * Time.deltaTime);

        // Eðer çöp ekran dýþýna çýkarsa, yok et
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
}
