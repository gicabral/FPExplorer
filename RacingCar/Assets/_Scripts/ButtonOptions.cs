using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
    // public void PlayGame(){
    //     SceneManager.LoadScene(2);
    // }

    public void PlayGame(){
        SceneManager.LoadScene(1);
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }

    // Aqui são os botões para selecionar as pistas

    public void Track01(){
        SceneManager.LoadScene(2);
    }

    public void Track02(){
        SceneManager.LoadScene(3);
    }

    public void Credits(){
        SceneManager.LoadScene(4);
    }
}
