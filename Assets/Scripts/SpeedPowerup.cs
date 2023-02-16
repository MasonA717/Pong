using UnityEngine;
using System.Collections;

public class SpeedPowerup : MonoBehaviour {
    public float duration = 10f;
    public float speedMultiplier = 4f;
    
    private void OnTriggerEnter2D(Collider2D collision) {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null) {
            ball.StartCoroutine(DoubleSpeedForDuration(ball));
            Destroy(gameObject);
        }
    }

    private IEnumerator DoubleSpeedForDuration(Ball ball) {
        float originalSpeed = ball.unitsPerSecond;
        ball.unitsPerSecond *= speedMultiplier;
        yield return new WaitForSeconds(duration);
        ball.unitsPerSecond = originalSpeed;
    }
}
// This script was written with the assistance of ChatGPT.