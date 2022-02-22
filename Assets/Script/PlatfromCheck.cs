using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JumpControl.Core
{    
    public class PlatfromCheck : MonoBehaviour
    {
        public bool isStay=false;

        private void OnTriggerStay2D(Collider2D other)
        {
            // Debug.Log(transform.parent.name+"  -stay-  "+other.name);
            isStay=true;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            // Debug.Log(transform.parent.name+"  -exit-  "+other.name);
            isStay=false;
        }        
    }
}
