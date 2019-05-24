using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text scoreT;
    [SerializeField] private int score = 0, js = 1, p;
    [SerializeField] private AnimationController animCntrlr;
    
    public void JewelClick(Text scoreText)
    {
        score += js;
        scoreText.text = score.ToString();
        animCntrlr.JewelAnimationChange(1);
        animCntrlr.CoinAnimationChange(1);
        //Debug.Log("Completed !");
    }
    
    public void Back(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
    public void ExitGame()
    {
        Debug.Log("Game Closed!");
        Application.Quit();
    }
    public void BuyItem(int jewelPerSecond)
    {
        //if (score > jewelPerSecond)
        //{
        //    p += jewelPerSecond;
        //    score -= js;
        //    scoreT.text = score.ToString();
        //}
        p += jewelPerSecond;
    }
    public void DecreaseScore(int Price)
    {
        if (score > Price)
        {
            js += p;
            score -= Price;
            scoreT.text = score.ToString();
        }
    }
}
