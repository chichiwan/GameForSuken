using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{

    public GameObject CirclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenRock", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void GenRock() {
        Instantiate(CirclePrefab, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    }
 }
