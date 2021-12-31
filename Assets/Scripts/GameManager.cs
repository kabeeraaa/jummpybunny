using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    private void Awake()
    {
        sharedInstance = this;
    }
    public static GameManager GetInstance()
    {
        return sharedInstance;
    }
    void StartGame()
    {
        LevelGenerator.sharedInstance.createInitialBlocks();
        PlayerControler.GetInstance().StartGame();
        ChangeGameState(GameState.Ingame);
    }
    private void Start()
    {
        //StartGame();
        currentGameState = GameState.Menu;

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
    }
    // called when the player decides to quit the game and go to main menu
    public void BackToMainMenu()
    {
        ChangeGameState(GameState.Menu);
    }
    void ChangeGameState(GameState newGameState)
    {
       /* if(newGameState == GameState.Menu)
        {
            // load menu screen
        }else if(newGameState == GameState.Ingame)
        {
            // unity will show game
        }else if(newGameState == GameState.GameOver)
        {
            // load game over screen
        }*/

        switch (newGameState)
        {
            case GameState.Menu:
                // load menu screen
                break;
            case GameState.Ingame:
                // unity will show game
                break;
            case GameState.GameOver:
                // load game over screen
                break;
            default:
                newGameState = GameState.Menu;
                break;
        }
        currentGameState = newGameState;

    }
}
