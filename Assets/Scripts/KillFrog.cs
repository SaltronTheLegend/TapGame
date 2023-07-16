using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    GameObject SmokeEffect;

    [SerializeField]
    GameObject WaterEffect;
    public int TotalScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        // this object was clicked
        TotalScore = PlayerPrefs.GetInt("Score ", 0);
        TotalScore++;

        PlayerPrefs.SetInt("Score ", TotalScore);
        PlayerPrefs.Save();

        // Debug.Log("Score " +  TotalScore.ToString());

        Destroy(gameObject);
        Instantiate(SmokeEffect, transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lake")
        {
            Destroy(gameObject);
            Instantiate(WaterEffect, transform.position, Quaternion.identity);
        }
    }
}
