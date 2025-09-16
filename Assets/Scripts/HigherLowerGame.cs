using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HigherLowerGame : MonoBehaviour
{
    public Deck deck;

    [Header("UI")]
    public Image cardImage;
    public TextMeshProUGUI cardNameText;
    public TextMeshProUGUI resultText;

    private Card currentCard;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DrawStartingCard();
    }

    void DrawStartingCard()
    {
        currentCard = deck.cards[Random.Range(0, deck.cards.Length)];
        ShowCard(currentCard);
        resultText.text = "Guess Higher or Lower!";
    }

    void ShowCard(Card card)
    {
        cardImage.sprite = card.artwork;
        cardNameText.text = card.cardName;
    }

    public void OnGuessingHigher()
    {
        DrawNextCard(true);
    }

    public void OnGuessingLower()
    {
        DrawNextCard(false);
    }

    void DrawNextCard(bool guessedHigher)
    {
        Card nextCard = deck.cards[Random.Range(0, deck.cards.Length)];
        ShowCard(nextCard);

        if((guessedHigher && nextCard.value > currentCard.value) || (!guessedHigher && nextCard.value < currentCard.value))
        {
            resultText.text = "Correct!";
        }
        else if(nextCard.value == currentCard.value)
        {
            resultText.text = "It's a Tie.";
        }
        else
        {
            resultText.text = "Wrong!";
        }
        currentCard = nextCard;
    }
}
