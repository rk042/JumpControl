using System;
using System.Collections.Generic;
using UnityEngine;

namespace JumpControl.Core
{    
    public class PlatfromGenerator : MonoBehaviour
    {
        public static event Action ScoreIncrese;
        [SerializeField] GameObject platformObject;
        [SerializeField] float offset=15f;
        [SerializeField] float maxRange= -5f,minRange= -5f;
        
        [SerializeField] List<Sprite> spriteList=new List<Sprite>();        

        private float increseXposition=0;

        private void Start()
        {            
            increseXposition=offset;    
        }
        public void GeneratePlatfrom(Vector3 lastPos)
        {
            if (!FindObjectOfType<PlatfromCheck>().isStay)
            {                
                ScoreIncrese?.Invoke();
                GameObject temp = Instantiate(platformObject, new Vector3(lastPos.x + UnityEngine.Random.Range(8, offset), UnityEngine.Random.Range(minRange, maxRange)), Quaternion.identity);
                temp.GetComponent<SpriteRenderer>().sprite = spriteList[UnityEngine.Random.Range(0, spriteList.Count)];
            }
        }
    }
}
