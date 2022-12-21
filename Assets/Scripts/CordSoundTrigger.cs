using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CordSoundTrigger : MonoBehaviour
{
    public Animator chordAnimator;
    public AudioSource audioSource;
    public AudioClip soundToProduce;

    public GameObject[] glowSprites;

    public Heat heatManager;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GameObject.FindWithTag("Guitar").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Pick")
        {
            chordAnimator.SetTrigger("CordHit");
            audioSource.clip = soundToProduce;
            audioSource.Play();
            triggerGlow(2f);
            
            heatManager.celsius = Random.Range(20f, 90f);
        }
    }

    void triggerGlow(float glowTime)
    {
        int currentSprite = Random.Range(0, glowSprites.Length);
        //glowSprites[currentSprite].SetActive(true);
        Instantiate(glowSprites[currentSprite], transform.position, transform.rotation);
    }
}