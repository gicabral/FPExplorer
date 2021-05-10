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
    public int MinuteCount;
    public int SecondCount;
    public float MiliCount;
    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
        {
            GameOverMenuUI.SetActive(true);
        }
        TextContent();
    }

    void TextContent()
    {
        //race
        if (ModeSelect.RaceMode == 0)
        {
            finalText.text = "" + positionDisplay.GetComponent<Text>().text;
        }
        //score
        else if (ModeSelect.RaceMode == 1)
        {
            finalText.text = "Parabens! Pontos: " + ModeScore.CurrentScore.ToString();
        }
        //time
        else
        {
            MinuteCount = PlayerPrefs.GetInt("MinSave");
            SecondCount = PlayerPrefs.GetInt("SecSave");
            MiliCount = PlayerPrefs.GetFloat("MiliSave");
            finalText.text = "Parabens! Tempo:" + MinuteCount + ":" + SecondCount + "." + MiliCount;            
        }
        
    }

    public void LoadMenu()
    {
        GameOverMenuUI.SetActive(false);
        SceneManager.LoadScene(0);
        GameIsOver = false;
    }
}
