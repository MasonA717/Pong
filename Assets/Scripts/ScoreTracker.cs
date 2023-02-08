using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreTracker : MonoBehaviour {
    public Ball ball;
    public int P1Score, P2Score;
    public TextMeshPro P1ScoreText, P2ScoreText;

    public void P1Scores() {
        P1Score++;
        P1ScoreText.text = P1Score.ToString();
        
        ball.ResetPosition();
    }

    public void P2Scores() {
        P2Score++;
        P2ScoreText.text = P2Score.ToString();
        
        ball.ResetPosition();
    }
}
