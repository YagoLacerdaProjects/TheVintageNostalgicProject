using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowSpritesManager : MonoBehaviour
{
    public float destroyAfterSeconds;
    public float fadetime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, destroyAfterSeconds);
    }

    // Update is called once per frame
    void Update()
    {
        
        Color c = this.gameObject.GetComponent<SpriteRenderer>().material.color;

        float current = c.a;

        current = current - Time.deltaTime;

        c.a = current;

        this.gameObject.GetComponent<SpriteRenderer>().material.color = c;
          
    }
}