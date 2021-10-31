using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //�J�[�h���N���b�N�����璆���ɂ���
    //�������������Gmaemaster�ɒʒm����

    [SerializeField] PlayerHand hand;
    [SerializeField] SelectCard selectCard;


    void SetupHand()
    {
        List<Card> cards = new List<Card>();
        for (int i = 0; i < 8; i++)
        {
            Card card = CardGenerator.instance.Spawn(i);

            //Card.clickaction�̒��g�𐶐�����
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
