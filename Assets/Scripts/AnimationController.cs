using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator jewelAnim, coinAnim;
    public void JewelAnimationChange(int status)
    {
        if (status == 0) jewelAnim.SetBool("JewelClicked", false);
        else jewelAnim.SetBool("JewelClicked", true);
        Debug.Log("Jewel Animation Change !");
    }
    public void CoinAnimationChange(int status)
    {
        if (status == 0) coinAnim.SetBool("CoinClicked", false);
        else coinAnim.SetBool("CoinClicked", true);
        Debug.Log("CoinAnimationChange !");
    }
}
