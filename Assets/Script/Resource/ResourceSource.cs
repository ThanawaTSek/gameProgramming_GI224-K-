using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum ResourceType
{
    Food,
    Wood,
    Gold,
    Stone
}

public class ResourceSource : MonoBehaviour
{
    [SerializeField] private string rsrcName;
    public string RsrcName { get { return rsrcName; } }

    [SerializeField] private Sprite rsrcPic;
    public Sprite RsrcPic { get { return rsrcPic; } }

    [SerializeField] private ResourceType rsrcType;
    public ResourceType RsrcType { get { return rsrcType; } }

    [SerializeField] private int quantity;
    public int Quantity { get { return quantity; } set { quantity = value; } }

    [SerializeField] private int maxQuantity;

    [SerializeField] private GameObject selectionVisual;
    public GameObject SelectionVisual { get { return selectionVisual; } } 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
