using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.003f, 0);
        if(transform.position.y < -4.8f) {
            transform.position = new Vector3 (0, 4.8f, 0);
        }
    }
}
