using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Main_1_02 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Player player;
    private NPC npc;

    private void Awake()
    {
        text.text = "...";
        npc = new NeutralNPC();
    }

    private void Update()
    {
        switch (player.reputaion)
        {
            case var expression when player.reputaion < 0:
                npc = new AngryNPC();
                break;
            case var expression when (player.reputaion >= 0 && player.reputaion < 2):
                npc = new NeutralNPC();
                break;
            case var expression when (player.reputaion > 2 && player.reputaion < 5):
                npc = new FriendlyNPC();
                break;
            case var expression when (player.reputaion > 5):
                npc = new BestFriendlyNPC();
                break;
        }
    }

    public void Interact()
    {
        StartCoroutine(npc.InteractRoutine(text));
    }
}
