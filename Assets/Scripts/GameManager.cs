using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/**1. menu 
 * 2. ingame
 * 3.gameover
 * 4.pause
 * 
 * */
enum DaysOfTheWeek{
    Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
}

public enum GameState
{
    Menu, Ingame, GameOver,Resume
}
public class GameManager : MonoBehaviour
{
    // Starts our game
    //DaysOfTheWeek currentDay = DaysOfTheWeek.Sunday;
    public GameState currentGameState = GameState.Menu;
    private static GameManager sharedInstance;
    public Canvas mainmenu;
    public Canvas gamemenu;
    public Canvas gameovermenu;
    int collectedCoins = 0;
    private void Awake()
    {
        sharedInstance = this;
    }
    public static GameManager GetInstance()
    {
        return sharedInstance;
    }
   public void StartGame()
    {
        LevelGenerator.sharedInstance.createInitialBlocks();
        PlayerControler.GetInstance().StartGame();
        ChangeGameState(GameState.Ingame);
        ViewInGame.GetInstance().ShowHighestScore();
    }
    public void Start()
    {
        //StartGame();
        currentGameState = GameState.Menu;
        mainmenu.enabled = true;
        gamemenu.enabled = false;
        gameovermenu.enabled = false;

    }
    private void Update()
    {
        if (currentGameState != GameState.Ingame && Input.GetButtonDown("s"))
        {
            ChangeGameState(GameState.Ingame);
            StartGame();

        }
    }
    // called when player dies
    public void GameOver()
    {
        LevelGenerator.sharedInstance.RemoveAllBlocks();
       
        ChangeGameState(GameState.GameOver);
        GameOverView.GetInstance().UpdateGui();
    }
    // called when the player decides to quit the game and go to main menu
    public void BackToMainMenu()
    {
        ChangeGameState(GameState.Menu);
    }
    void ChangeGameState(GameState newGameState)
    {
       

        switch (newGameState)
        {
            case GameState.Menu:
                mainmenu.enabled = true;
                gamemenu.enabled = false;
                gameovermenu.enabled = false;
                // load menu screen
                break;
            case GameState.Ingame:
                mainmenu.enabled = false;
                gamemenu.enabled = true;
                gameovermenu.enabled = false;
                // unity will show game
                break;
            case GameState.GameOver:
                mainmenu.enabled = false;
                gamemenu.enabled = false;
                gameovermenu.enabled = true;
                // load game over screen
                break;
            default:
                newGameState = GameState.Menu;
                break;
        }
        currentGameState = newGameState;

    }

   public void CollectCoins()
    {
        collectedCoins++;
        ViewInGame.GetInstance().UpdateCoins();
    }

    public int GetCollectedCoins()
    {
        return collectedCoins;
    }
}
