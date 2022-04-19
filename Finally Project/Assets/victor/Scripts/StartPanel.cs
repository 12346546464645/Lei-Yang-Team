using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPanel : MonoBehaviour
{


    public Button GameAgainButton;
    public Button GameQuitButton;

    // Use this for initialization
    void Start()
    {
        GameAgainButton.onClick.AddListener(GameAgainButtonClickListener);         
        GameQuitButton.onClick.AddListener(GameQuitButtonClickListener);             
    }


    void GameAgainButtonClickListener()
    {
        SceneManager.LoadScene("victorGame");
    }

    void GameQuitButtonClickListener()
    {

        SceneManager.LoadScene(0);

    }

}
