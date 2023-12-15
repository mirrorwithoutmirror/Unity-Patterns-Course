using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _HP;
    [SerializeField] private TextMeshProUGUI _level;

    private GameplayMediator _mediator;

    public void Initialize(GameplayMediator gameplayMediator)
    {
        _mediator = gameplayMediator;
    }

    public void UpdateHP(int HP)
    {
        _HP.text = HP.ToString();
    }

    public void UpdateLevel(int level)
    {
        _level.text = level.ToString();
    }
}
