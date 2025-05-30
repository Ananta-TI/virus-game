using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float score;
    public Text scoreUI;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Virus"))
        {
            score += 100;
            scoreUI.text = "Score: " + score.ToString();
            Destroy(collision.collider.gameObject);
        }
        
    }
}
