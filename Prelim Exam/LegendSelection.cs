using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LegendSelection : MonoBehaviour
{
    public LegendManager legendManager;
    public Transform parentPos;
    public GameObject legendButtonPrefab;
    public LegendInfoView legendInfoView;

    void Start()
    {
        Debug.Log(legendManager.legends.Count());
        foreach (Legend l in legendManager.legends)
        {
            GameObject buttonPrefab = Instantiate(legendButtonPrefab,parentPos);
            LegendButton legendButton = buttonPrefab.GetComponent<LegendButton>();
            legendButton.SetLegendData(l);
            
            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => legendInfoView.DisplayLegend(l));
        }

    }
}
