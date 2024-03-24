using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KarakterKontrol : MonoBehaviour
{
    private Animator animator;
    public float donusHizi=100 ;
    private Rigidbody rb;

    

    public AudioSource copSesi; // Ses kayna��



    void Start()
    {
        // Rigidbody bile�enini al
        rb = GetComponent<Rigidbody>();

        // Animator bile�enini al
        animator = GetComponent<Animator>();
        
        
    }

    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Yuruyor", true);
            transform.Translate(new Vector3(0, 0, 4f) * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Yuruyor", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down*donusHizi* Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * donusHizi * Time.deltaTime);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // ��p kutusu ile temas etti mi kontrol edelim
        if (collision.gameObject.CompareTag("cop"))
        {
            // E�er ��p kutusu ile temas ettiyse, "oyunsahnesi2" sahnesini y�kle
            SceneManager.LoadScene("GameScene");
        }
        if (collision.gameObject.CompareTag("copler"))
        {
            Destroy(collision.gameObject);
            // Ses efekti �al
            if (copSesi != null)
            {
                copSesi.Play();
            }
        }
    }
}

