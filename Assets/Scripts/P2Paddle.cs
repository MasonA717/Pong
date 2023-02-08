using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Paddle : DemoPaddle {
    public Rigidbody2D ball;
    private void FixedUpdate() {
        if (ball.velocity.x > 0f) {
            if (ball.position.y > GetComponent<Rigidbody2D>().position.y) {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * unitsPerSecond);
            } else if (ball.position.y < GetComponent<Rigidbody2D>().position.y) {
                GetComponent<Rigidbody2D>().AddForce(Vector2.down * unitsPerSecond);
            }
        } else {
            if (GetComponent<Rigidbody2D>().position.y > 0f) {
                GetComponent<Rigidbody2D>().AddForce(Vector2.down * unitsPerSecond);
            } else if (GetComponent<Rigidbody2D>().position.y < 0f) {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * unitsPerSecond);
            }
        }
    }
}
