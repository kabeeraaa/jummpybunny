using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameOverView : MonoBehaviour
{
    public TMP_Text coinsLable;
    public TMP_Text scoreText;

    private static GameOverView sharedInstance;

    public static GameOverView GetInstance()
    {
        return sharedInstance;
    }
    private void Awake()
    {
        sharedInstance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateGui()
    {
        if(GameManager.GetInstance().currentGameState == GameState.GameOver)
        {
            coinsLable.text = GameManager.GetInstance().GetCollectedCoins().ToString();
            scoreText.text = PlayerControler.GetInstance().GetDistance().ToString();
        }
        
    }
}
