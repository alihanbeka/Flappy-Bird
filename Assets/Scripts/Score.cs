using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    
    void Start()
    {
        score = 0; 
    }

   
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = score.ToString();
        
    }
}
