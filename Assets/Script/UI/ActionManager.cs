using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionManager : MonoBehaviour
{
    [SerializeField] private Button[] unitBtns;
    [SerializeField] private Button[] buildingBtns;
    
    private CanvasGroup cg;
    
    public static ActionManager instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void Awake()
    {
        instance = this;
    }
}
