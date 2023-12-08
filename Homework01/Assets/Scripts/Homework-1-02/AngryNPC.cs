using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryNPC : NPC, IReputationChecker
{
    public string ReputationReaction()
    {
        return "Om my god, that is you! Go away or I will call quards!";
    }

    protected override string Reputation()
    {
        return ReputationReaction();
    }

    protected override string Bye()
    {
        return "GUARDS, CATCH THIS BASTARD!";
    }
}
