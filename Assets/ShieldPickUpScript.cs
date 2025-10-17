using Unity.VisualScripting;
using UnityEngine;
[System.Serializable]
public class ShieldPickUpScript
{
    private bool shielded;
    [SerializeField]
    
    public GameObject ShieldPickup;
    [Range(0, 100)] public float dropchance;

    
}