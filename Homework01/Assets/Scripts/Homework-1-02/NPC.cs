using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class NPC
{
    public IEnumerator InteractRoutine(TextMeshProUGUI text)
    {
        text.text = "Hello, adventure!";
        yield return new WaitForSeconds(2f);
        text.text = Reputation();
        yield return new WaitForSeconds(2f);
        text.text = Bye();
        yield return new WaitForSeconds(2f);
        text.text = "...";
    }

    protected abstract string Reputation();

    protected abstract string Bye();
}
