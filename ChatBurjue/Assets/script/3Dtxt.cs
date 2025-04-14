using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txt3D : MonoBehaviour
{
    public float m = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m-= Time.deltaTime;
        if (m<0)
        {
            m = 3;
            this.gameObject.SetActive(false);
        }
    }
}
