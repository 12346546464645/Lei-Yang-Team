using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController Instance = null;
    public int Coinscore = 0;
    public Text Cointxt_score;

    public GameObject WinPanel;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCoin()
    {
        Coinscore += 1;

        Cointxt_score.text = Coinscore.ToString();

        if (Coinscore >= 4)
        {

            WinPanel.SetActive(true);

        }
    }

   public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

   public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

}
