using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Для простоты примера задам константные значения здесь.
    private const int STARTING_LEVEL = 0;
    private const int STARTING_HP = 100;
    private const int HP_CHANGE_STEP = 10;

    private int _level = STARTING_LEVEL;
    private int _HP = STARTING_HP;

    private GameplayMediator _mediator;
    private bool _isPlaying = true;

    public void Initialize(GameplayMediator gameplayMediator)
    {
        _mediator = gameplayMediator;
    }

    public void ResetStat()
    {
        _level = STARTING_LEVEL;
        _mediator.ChangeLevel(_level);
        _HP = STARTING_HP;
        _mediator.ChangeHP(_HP);
    }

    public void SetGameplayMode(bool isPlaying)
    {
        _isPlaying = isPlaying;
    }

    private void Update()
    {
        if (_isPlaying == true)
        {
            // increase level
            if (Input.GetKeyDown(KeyCode.A))
            {
                _level += 1;
                _mediator.ChangeLevel(_level);
            }

            // decrease HP
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (_HP - HP_CHANGE_STEP <= 0)
                {
                    _HP = 0;
                    _mediator.LevelDefeat();
                }
                else
                {
                    _HP -= HP_CHANGE_STEP;
                }
                _mediator.ChangeHP(_HP);
            }

            // increase HP
            if (Input.GetKeyDown(KeyCode.D))
            {
                _HP += HP_CHANGE_STEP;
                _mediator.ChangeHP(_HP);
            }
        }
    }
}
