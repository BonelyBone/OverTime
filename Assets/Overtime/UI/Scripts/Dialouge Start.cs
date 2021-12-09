using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeStart : MonoBehaviour
{
    public GameObject DialougeStarter;
    // Start is called before the first frame update
    void Start()
    {
        DialougeStarter.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
