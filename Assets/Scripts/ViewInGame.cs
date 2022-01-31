using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ViewInGame : MonoBehaviour
{

   public  TMP_Text coinsLable;
    public TMP_Text scoreText;
    public TMP_Text highestScoreText;

    private static ViewInGame sharedInstance;

    public static ViewInGame GetInstance()
    {
        return sharedInstance;
    }
    private void Awake()
    {
        sharedInstance = this;
    }
    private void Start()
    {
        
    }
   public  void ShowHighestScore()
    {
        highestScoreText.text = PlayerControler.GetInstance().GetMaxScore().ToString();
    }
    void Update()
    {
        
        if (GameManager.GetInstance().currentGameState == GameState.Ingame)
        {
            
            scoreText.text = PlayerControler.GetInstance().GetDistance().ToString();
        }    
       
    
    }

    public void UpdateCoins()
    {
        coinsLable.text = GameManager.GetInstance().GetCollectedCoins().ToString();
    }
}
