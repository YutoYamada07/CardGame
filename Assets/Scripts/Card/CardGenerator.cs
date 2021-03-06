using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    //Cardの生成：Prefabを生成
    [SerializeField] Card cardPrefab;

    public static CardGenerator instance;
    private void Awake()
    {
        instance = this;

    }

    
    public Card Spawn(int number)
    {
       
        Card card=Instantiate(cardPrefab);
        card.Init(number);

        return card;
    }
}
