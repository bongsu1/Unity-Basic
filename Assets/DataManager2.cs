using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager2 : MonoBehaviour
{
    [SerializeField] float chargedPower;
    public UnityAction<float> OnCharged;
    public float ChargedPower { get { return chargedPower; } set { chargedPower = value; OnCharged?.Invoke(value); } }
}
