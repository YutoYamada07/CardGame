using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //カードをクリックしたら中央におく
    //決定を押したらGmaemasterに通知する

    [SerializeField] PlayerHand hand;
    [SerializeField] SelectCard selectCard;


    void SetupHand()
    {
        List<Card> cards = new List<Card>();
        for (int i = 0; i < 8; i++)
        {
            Card card = CardGenerator.instance.Spawn(i);

            //Card.clickactionの中身を生成する
            card.ClickAction = SelectCard;
            cards.Add(card);

        }
        hand.SetHandCards(cards);
    }
    public void SelectCard(Card card)
    {
        Debug.Log("SelectCard"+card.number);
        selectCard.SetCard(card);
    
    }

    public void SubmitCard()
    { 
    
    
    }
    // Start is called before the first frame update
    void Start()
    {
        SetupHand();
    }

    
}
