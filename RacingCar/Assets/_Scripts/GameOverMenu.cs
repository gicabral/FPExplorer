using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public bool GameIsOver = false;
    public GameObject GameOverMenuUI;
    public Text finalText;
    public GameObject positionDisplay;
    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
        {
            GameOverMenuUI.SetActive(true);
        }
    }

    void TextContent()
    {
        //score
        if (ModeSelect.RaceMode == 0)
        {
            finalText.text = "Parabens! Pontos: " + ModeScore.CurrentScore.ToString();
        }
        //time
        else if (ModeSelect.RaceMode == 1)
        {
            finalText.text = "Parabens! " + positionDisplay.GetComponent<Text>();
        }
        //race
        else
        {
            finalText.text = "Oi! " ;
        }
        
    }

    public void LoadMenu()
    {
        GameOverMenuUI.SetActive(false);
        SceneManager.LoadScene(0);
        GameIsOver = false;
    }
}
