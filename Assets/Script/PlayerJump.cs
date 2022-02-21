using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace JumpControl.Core
{    
    public class PlayerJump : MonoBehaviour
    {
        [SerializeField] private Slider jumpSlider;
        [SerializeField] private float jumpForce;
        [SerializeField] private float xVelocity,yVelocity;

        private Rigidbody2D myRd;
        private Coroutine jumpManager=null;
        private bool isGround=false;

        private float jumpX=0,jumpY=0;

        // Start is called before the first frame update
        void Start()
        {
            myRd=GetComponent<Rigidbody2D>();               
        }       

        public void StopPlayerJump()
        {
            if (jumpManager!=null && isGround)
            {                
                isGround=false;
                myRd.velocity=new Vector2(jumpX,jumpY);
                jumpX=jumpY=0;                
                StopCoroutine(jumpManager);
                jumpManager=null;
                jumpSlider.value=0;            
            }
        }

        public void StartPlayerJump()
        {
            if (jumpManager==null)
            {                                                
                jumpManager=StartCoroutine(COR_jumpManager());
            }
        }        

        private IEnumerator COR_jumpManager()
        {
            while (true)
            {
                yield return new WaitForSecondsRealtime(Time.deltaTime);
                
                if (jumpSlider.value != jumpSlider.maxValue)
                {                    
                    jumpSlider.value += Time.deltaTime;
                    jumpX += xVelocity * Time.deltaTime;
                    jumpY += yVelocity * Time.deltaTime;
                }
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                isGround=true;
            }
        }
    }
}
