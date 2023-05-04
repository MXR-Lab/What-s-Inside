using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    //public GameObject Spawner;
    [SerializeField] private Saber saberL1;
    [SerializeField] private Saber saberL2;
    [SerializeField] private Saber saberR1;
    [SerializeField] private Saber saberR2;
    // Start is called before the first frame update
    private int strikes;
    private int score;

    public TMP_Text scoreBox;
    public TMP_Text strikeBox;

    void Start()
    {
        //Spawner.enabled = false;
        strikes = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseStrike(int s)
    {
        strikes += s;
        strikeBox.text =  "Strikes: " + strikes;
        if (strikes >= 3)
        {
            //Lose
        }
    }   
    
    public void increaseScore(int s)
    {
        score += s;
        scoreBox.text = "Score: " + score;
    }
}
