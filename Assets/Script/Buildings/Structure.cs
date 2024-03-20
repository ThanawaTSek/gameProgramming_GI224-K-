using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct StructTureCost
{
    public int food;
    public int wood;
    public int glod;
    public int stone;
}

public abstract class Structure : MonoBehaviour
{
    [SerializeField]
    protected string structureName;
    public string StructureName { get { return structureName; } }

    [SerializeField] protected Sprite structurePic;
    public Sprite StructurePic { get { return structurePic; } }

    [SerializeField]
    protected int curHP;
    public int CurHP { get { return curHP; } set { curHP = value; } }

    [SerializeField]
    protected int maxHP;
    public int MaxHP { get { return maxHP; } set {  maxHP = value; } }

    [SerializeField]
    protected Faction faction;
    public Faction Faction { get { return faction; } set { faction = value; } }
    
    [SerializeField]
    protected GameObject selectionVisual;
    public GameObject SelectionVisual { get { return selectionVisual; } }

    [SerializeField] 
    private Structure structureCost;
    public StructTureCost StruetureCost { get { return structureCost } set { structureCost = value; } }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
    
    
}
