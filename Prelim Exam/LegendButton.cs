using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LegendButton : MonoBehaviour
{
    public TextMeshProUGUI legendNameTxt;

    public void SetLegendData(Legend unit)
    {
        legendNameTxt.text = unit.name;
    }
}
