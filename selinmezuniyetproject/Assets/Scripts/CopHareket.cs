using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopHareket : MonoBehaviour
{
    public float hiz = 5f; // ��p�n d���� h�z�

    void Update()
    {
        // ��p� a�a�� do�ru hareket ettir
        transform.Translate(Vector2.down * hiz * Time.deltaTime);

        // E�er ��p ekran d���na ��karsa, yok et
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
}
