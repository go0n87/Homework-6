using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class StartParameters : MonoBehaviour
{
    [SerializeField] private Text difficultLevel;
    [SerializeField] private Text difficultLevelName;

    // Start is called before the first frame update
    void Start()
    {
        difficultLevel.text     = "30";
        difficultLevelName.text = "Средний";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
