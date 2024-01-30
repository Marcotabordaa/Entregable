using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
    
{
    public float velocidad = 3f;
    public float velrotacion = 90f;
        // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical")*velocidad * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * velrotacion * Time.deltaTime, 0);
    }
}
