using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScoreller : MonoBehaviour
{
    public float beatTempo;

    public bool hasStarted;

    
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
         
        }
        else
        {
            transform.position -= new Vector3 (0f, beatTempo * Time.deltaTime,0f );
        }
    }
}
