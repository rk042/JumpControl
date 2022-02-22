using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class learp : MonoBehaviour
{
    [Range(0,5)] [SerializeField] float learpTime;

    [SerializeField] float startScore=0f;
    [SerializeField] float currentScore=0f;

    Text uitext;


    void Start()
    {
        uitext=GetComponent<Text>();                
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentScore=startScore+100;
        }

        startScore=Mathf.Lerp(startScore, currentScore, learpTime * Time.deltaTime);
        uitext.text=startScore.ToString("000000");        
    }
}
