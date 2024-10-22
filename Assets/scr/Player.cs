using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public ScoreManager scoreManager;
    public float movementForce = 10f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) 
        {
            rb.AddForce(Vector2.left * movementForce, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector2.right * movementForce, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Candy"))
        {
            scoreManager.UpdateScore(10);
            Destroy(col.gameObject);
        }
        if (col.CompareTag("Poison"))
        {
            scoreManager.UpdateScore(-10);
            Destroy(col.gameObject);
        }
    }
}
