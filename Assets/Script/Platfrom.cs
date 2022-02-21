using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfrom : MonoBehaviour
{        
    PlatfromGenerator platfromGenerator=null;
    private void Start()
    {
        platfromGenerator=FindObjectOfType<PlatfromGenerator>();
    }

    private void OnCollisionExit2D(Collision2D other)
    {        
        Debug.Log(other.gameObject.name);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        platfromGenerator.GeneratePlatfrom(this.transform.position);        
    }
}
