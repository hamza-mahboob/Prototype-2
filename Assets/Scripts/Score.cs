using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static int score = 0;
    static int star = 0;
    Text scoreUI, starUI;

    // Start is called before the first frame update
    void Start()
    {
        scoreUI = GameObject.Find("ScoreCount").GetComponent<Text>();
        starUI = GameObject.Find("StarCount").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (score == 0)
        {
            star++;
            score += 3;
        }
        else if(other.name == "Animal_Chick(Clone)")    //bonus animal
        {
            score += 20;
        }
        else
        {
            star++;
            score += 5;
        }

        Debug.Log(score);
        scoreUI.text = score.ToString();
        starUI.text = star.ToString();

        Destroy(this.gameObject);
        Destroy(other.gameObject);
    }
}
