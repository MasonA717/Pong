using UnityEngine;

public class SurfaceBounce : MonoBehaviour {
    public float bounceSpeed = 10f;
    public AudioClip bounceSound, bounceSound2;
    private AudioSource audioSource;
    
    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }
        
    private void OnCollisionEnter2D(Collision2D collision) {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        DemoPaddle paddle = collision.gameObject.GetComponent<DemoPaddle>();
        Debug.Log("paddle: " + paddle);

        if (ball != null) {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * bounceSpeed);
        }
        
        if (paddle != null && ball.rb.velocity.magnitude > 200f) {
            Debug.Log("Ball collided with DemoPaddle!");
            Debug.Log("Playing bounceSound2");
            audioSource.clip = bounceSound2;
            audioSource.Play();
        } else if (paddle != null) {
            Debug.Log("Ball collided with DemoPaddle!");
            Debug.Log("Playing bounceSound");
            audioSource.clip = bounceSound;
            audioSource.Play();
        }
        
        /*if (collision.gameObject.CompareTag("DemoPaddle")) {
            if (ball.rb.velocity.magnitude > 200f) {
                audioSource.PlayOneShot(bounceSound2);
            } else {
                audioSource.PlayOneShot(bounceSound);
            }
        }*/
    }
}

// This script was written with the assistance of ChatGPT.