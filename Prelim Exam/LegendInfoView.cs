using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LegendInfoView : MonoBehaviour
{
    public Legend legend;

    [Header("UI Headers")]
    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI hpTMP;
    public TextMeshProUGUI typeTMP;
    public TextMeshProUGUI genderTMP;
    public Image image;

    public void OnEnable()
    {
        DisplayLegend(legend);
    }
    public void DisplayLegend(Legend legend)
    {
        nameTMP.text = "Name: " + legend.name;
        hpTMP.text = "HP: " + legend.hp.ToString();
        typeTMP.text = "Type: " + legend.type.ToString();
        genderTMP.text = "Gender: " + legend.gender.ToString();
        image.sprite = legend.image;
    }

    public void ClearView()
    {
        legend = null;
        nameTMP.text = null;
        hpTMP.text = null;
        typeTMP.text = null;
        genderTMP.text = null;
    }
    public void OnDisable()
    {
        ClearView();
    }
}
