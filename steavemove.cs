using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steavemove : MonoBehaviour
{
    // Start is called before the first frame update
    Transform steve;
    void Start()
    {
        steve=GetComponent<Transform>();
    }

    // Update is called once per frame

    void Update()
    {
        
    }
    void OnMouseDown(){
        steve.Translate(2,2,2);
    }
}
