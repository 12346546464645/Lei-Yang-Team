using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[AddComponentMenu("Game/GameManager")]
public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance = null;
    public int m_score = 0;
    public Text txt_score;

    // Use this for initialization
    void Start()
    {
        Instance = this;

    }

    void Update()
    {
   
    }

    public void SetScore(int score)
    {
        m_score += score;

        txt_score.text = m_score.ToString();

        if (m_score >= 5)
        {

            SceneManager.LoadScene("victorWin");

        }
    }

}