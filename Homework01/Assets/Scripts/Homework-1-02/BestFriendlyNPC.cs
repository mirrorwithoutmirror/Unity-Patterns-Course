using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestFriendlyNPC : NPC, IReputationChecker
{
    public string ReputationReaction()
    {
        return "I`ve got good armor for you with a discount, friend!";
    }

    protected override string Reputation()
    {
        return ReputationReaction();
    }

    protected override string Bye()
    {
        return "By the way, let`s go to tavern this evening!";
    }
}
