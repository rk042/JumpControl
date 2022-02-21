using System.Collections.Generic;
using UnityEngine;

public class PlatfromGenerator : MonoBehaviour
{
    [SerializeField] GameObject platformObject;
    [SerializeField] float offset=15f;
    [SerializeField] float maxRange= -5f,minRange= -5f;
    
    private float increseXposition=0;

    private void Start()
    {
        increseXposition=offset;    
    }
    public void GeneratePlatfrom(Vector3 lastPos)
    {
        Instantiate(platformObject,new Vector3(lastPos.x+offset,Random.Range(minRange,maxRange)),Quaternion.identity);        
    }
    
}
