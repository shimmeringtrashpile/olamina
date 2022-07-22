using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        this.transform.Rotate(Vector3.right * 90);
    }
}
