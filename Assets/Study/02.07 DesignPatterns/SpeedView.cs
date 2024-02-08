using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedView : MonoBehaviour
{
    public TMP_Text txt;

    private void OnEnable()
    {
        UpdateSpeed(Manager2.Data.ChargedPower);
        Manager2.Data.OnCharged += UpdateSpeed;
    }

    private void OnDisable()
    {
        Manager2.Data.OnCharged -= UpdateSpeed;
    }

    void UpdateSpeed(float value)
    {
        txt.text = value.ToString();
    }
}
