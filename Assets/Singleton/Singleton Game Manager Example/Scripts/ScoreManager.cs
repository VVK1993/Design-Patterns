using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance = null; //Static instance of GameManager which allows it to be accessed by any other script.
    private int gameScore = 0;                 //Current game score

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }
        //If instance already exists and it's not this:
        else if (instance != this)
        {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }


    void OnGUI()
    {
        //display current game score
        GUILayout.Label("Your Score: " + gameScore);
    }

    // increase score each time player pressed the button
    public void IncreaseScore()
    {
        gameScore += 10;
    }

    // load new level
    public void LoadNewScene()
    {
        Application.LoadLevel("ScoreManagerSecondScene");
    }
}
