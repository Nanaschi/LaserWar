using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillCost : MonoBehaviour
{
    //[SerializeField] int skillCost = 1;
    TextMeshProUGUI pointsText;
    // Start is called before the first frame update
    void Start()
    {
        pointsText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay(0);
    }
    public void UpdateDisplay(int skillCost)
    {
        
        pointsText.text = skillCost.ToString();
    }
}