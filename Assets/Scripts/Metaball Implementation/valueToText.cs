using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valueToText : MonoBehaviour
{
	public float temperature {get; set;}
	Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
		temperature = 20.0f;
		textComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
		textComponent.text = "Degrees Celsius: " + Mathf.Round(temperature * 100f) / 100f;;
    }
}
