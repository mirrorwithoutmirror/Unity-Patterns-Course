using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int reputaion = 0;
    [SerializeField] private TextMeshProUGUI reputaionText; 

    public void AddReputaion()
    {
        reputaion++;
        reputaionText.text = reputaion.ToString();
    }

    public void DecreaseReputaion()
    {
        reputaion--;
        reputaionText.text = reputaion.ToString();
    }
}
