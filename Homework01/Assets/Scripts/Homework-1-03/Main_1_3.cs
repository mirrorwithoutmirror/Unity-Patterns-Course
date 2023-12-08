using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using static UnityEngine.GraphicsBuffer;

public enum ColorType
{
    Red,
    White,
    Green
}

public class Main_1_3 : MonoBehaviour
{
    public List<GameObject> balls;
    public List<GameObject> choosedBalls = new();
    public GameObject selectedBall;
    public bool isPlaying = false;

    [SerializeField] private GameObject _buttonGameType1;
    [SerializeField] private GameObject _buttonGameType2;
    private bool _isFirstGameType = true;
    private iGameType _gameType;

    void Awake()
    {
        Ball.ballClicked += DeleteBall;
    }

    public void ButtonGameType1Action()
    {
        _gameType = new GameType1();
        isPlaying = true;
        DisableButtons();
    }

    public void ButtonGameType2Action()
    {
        _gameType = new GameType2();
        isPlaying = true;
        DisableButtons();
    }

    private void DeleteBall(Ball ball)
    {
        if (isPlaying)
        {
            selectedBall = ball.gameObject;
            balls.Remove(selectedBall);
            selectedBall.GetComponent<MeshRenderer>().enabled = false;
            _gameType.CheckWinCondition(this);            
        }
    }

    private void DisableButtons()
    {
        _buttonGameType1.active = false;
        _buttonGameType2.active = false;
    }
}
