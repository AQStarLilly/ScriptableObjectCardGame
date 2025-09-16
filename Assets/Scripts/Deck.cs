using UnityEngine;

[CreateAssetMenu(fileName = "NewDeck", menuName = "Cards/Deck")]
public class Deck : ScriptableObject
{
    public Card[] cards;
}
