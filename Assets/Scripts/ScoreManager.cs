using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    private int score = 0;
    private int oldScore = 0;
    public TextMeshProUGUI scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GameObject.Find("scoreTXT").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] Blocks = GameObject.FindGameObjectsWithTag("DraggableBlock");
        float BestY = 0;
        foreach(GameObject block in Blocks)
        {
            if (block.transform.position.y > BestY)
            {
                BestY = block.transform.position.y;
            }
        }
        oldScore = score;
        if (BestY > 0)
        {
            score = ((int) BestY+1);
        } else
        {
            score = 0;   
        }


        scoreTxt.text = "Score: " + score;
        
    }
}
