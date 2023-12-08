using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeutralNPC : NPC, IReputationChecker
{
    public string ReputationReaction()
    {
        return "Unfortunatly I can`t sell you anything";
    }

    protected override string Reputation()
    {
        return ReputationReaction();
    }

    protected override string Bye()
    {
        return "Go do some quests!";
    }
}
