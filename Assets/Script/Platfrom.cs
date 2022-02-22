using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JumpControl.Core
{    
    public class Platfrom : MonoBehaviour
    {        
        PlatfromGenerator platfromGenerator=null;        

        [SerializeField] private float offset;

        private void Start()
        {
            platfromGenerator=FindObjectOfType<PlatfromGenerator>();            
            // Debug.Log("start"+name);
        }
        private void OnCollisionEnter2D(Collision2D other)
        {                                     
            platfromGenerator.GeneratePlatfrom(this.transform.position);                    
        }

        private void Update()
        {
            if (transform.position.x+offset < Camera.main.transform.position.x)
            {
                Destroy(gameObject);
            }
        }
    }
}
