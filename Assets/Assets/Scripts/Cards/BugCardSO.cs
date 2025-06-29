using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Bug Cards")]
public class BugCardSO : ScriptableObject
{
    public Texture2D Icon;
    public int cost;
    public float cooldown;
}

