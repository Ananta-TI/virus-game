using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSpawn : MonoBehaviour
{
    public GameObject virus;
    public float waktuMin, waktuMax;
    public float posisiMin, posisiMax;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Virus"))
        {
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }

    IEnumerator MunculVirus()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(posisiMin, posisiMax) ,
            Quaternion.identity);
        yield return new WaitForSeconds(Random .Range(waktuMin, waktuMax));
        StartCoroutine(MunculVirus());
    }

    void Start()
    {
        StartCoroutine(MunculVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
