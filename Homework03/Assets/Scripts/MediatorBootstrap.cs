using UnityEngine;

public class MediatorBootstrap : MonoBehaviour
{
    [SerializeField] private GameplayMediator _gameplayMediator;
    [SerializeField] private DefeatPanel _defeatPanel;
    [SerializeField] private UIPanel _UIPanel;
    [SerializeField] private Player _player;

    private Level _level;

    private void Awake()
    {
        _level = new Level();

        _gameplayMediator.Initialize(_level);
        _defeatPanel.Initialize(_gameplayMediator);
        _UIPanel.Initialize(_gameplayMediator);
        _player.Initialize(_gameplayMediator);
        _level.Start();
    }
}
