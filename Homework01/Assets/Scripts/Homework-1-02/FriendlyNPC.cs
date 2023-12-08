using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyNPC : NPC, IReputationChecker
{
    public string ReputationReaction()
    {
        return "Do you want to buy some fruits?";
    }

    protected override string Reputation()
    {
        return ReputationReaction();
    }

    protected override string Bye()
    {
        return "I will sell you more when you save the princess.";
    }
}
