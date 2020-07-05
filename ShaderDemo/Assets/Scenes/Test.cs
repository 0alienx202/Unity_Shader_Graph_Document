using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var lerp = Mathf.Lerp(1, 10, 0.5f);
        Debug.Log(lerp);
        Debug.Log(Mathf.InverseLerp(1, 10, 15));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
