using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarManager : MonoBehaviour
{
    public Transform pickObject;
    public LayerMask cordsLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 mouse = Input.mousePosition;
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);
            RaycastHit hit;

            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, cordsLayer))
            {
                pickObject.transform.position = hit.point;
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}