using UnityEngine;

public class DemoPaddle : MonoBehaviour {
    public float unitsPerSecond = 6f;
    
    protected Rigidbody2D rb;
    
    private void Awake () {
        rb = GetComponent<Rigidbody2D>();
    }
}