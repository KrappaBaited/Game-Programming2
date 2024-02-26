using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegendManager : MonoBehaviour
{
    public Legend[] legends;
    private string folderPath = "Legends"; // Folder name inside the Assets/Resources folder

    void Start()
    {
        legends = Resources.LoadAll<Legend>(folderPath);
    }
}
