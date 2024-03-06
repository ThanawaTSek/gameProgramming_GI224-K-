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
    
    private void Awake()
    {
        instance = this;
        cg = GetComponent<CanvasGroup>();
    }
    
    private void HideCreateUnitButtons()
    {
        for (int i = 0; i < unitBtns.Length; i++)
            unitBtns[i].gameObject.SetActive(false);
    }
    
    private void HideCreateBuildingButtons()
    {
        for (int i = 0; i < buildingBtns.Length; i++)
            buildingBtns[i].gameObject.SetActive(false);
    }
    
    public void ClearAllInfo()
    {
        HideCreateUnitButtons();
        HideCreateBuildingButtons();
    }
    
    


}
