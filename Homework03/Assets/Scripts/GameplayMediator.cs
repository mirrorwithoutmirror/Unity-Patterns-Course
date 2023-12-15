using UnityEngine;

public class GameplayMediator : MonoBehaviour
{
    [SerializeField] private DefeatPanel _defeatPanel;
    [SerializeField] private UIPanel _UIPanel;
    [SerializeField] private Player _player;

    private Level _level;

    public void Initialize(Level level)
    {
        _level = level;
    }

    public void LevelDefeat()
    {
        _defeatPanel.Show();
        _player.SetGameplayMode(false);
    }

    public void RestartLevel()
    {
        _defeatPanel.Hide();
        _level.Restart();
        _player.ResetStat();
        _player.SetGameplayMode(true);
    }

    public void ChangeHP(int HP)
    {
        _UIPanel.UpdateHP(HP);
    }

    public void ChangeLevel(int level)
    {
        _UIPanel.UpdateLevel(level);
    }
}
