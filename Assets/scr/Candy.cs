using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public Sprite[] candy;

    // Start is called before the first frame update

    private void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = candy[Random.Range(0,2)];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
