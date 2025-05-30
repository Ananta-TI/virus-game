using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanPlayer : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    Animator nta;

    public Transform playerPutaran;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        nta = GetComponent<Animator>();
    }

    void Bergerak()
    {
        float gerak = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * gerak * speed;
        nta.SetFloat("Kecepatan", Mathf.Abs(gerak), 0.1f, Time.deltaTime);
        playerPutaran.localEulerAngles = new Vector3 (0, gerak * 90, 0);
    }

    void FixedUpdate()
    {
        Bergerak();
    }
    void OnCollisionEnter(Collision collision)
{
    if (collision.collider.CompareTag("Virus"))
    {
        Time.timeScale = 0;
        Destroy(collision.collider.gameObject); 
    }
}

}
