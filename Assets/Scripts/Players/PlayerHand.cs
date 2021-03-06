using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    
    //手札を保持する（リスト）
    //カード選択をしていたカードが手札に戻るようにする
    //カードを選択したときにhandのcardが手札からなくなるようにする

    [SerializeField]List<Card> cards = new List<Card>();
    //最初にPlayerから手札を受け取る

    public void SetHandCards(List<Card> cards)
    {
        this.cards = cards;

        
        RefreshHand();
    }

    //かーどが与えられたら手札を整列する
    void RefreshHand()
    {
        
        for (int i = 0; i < cards.Count; i++)
        {
            Card card = cards[i];
            //カードを自分の子要素にする
            card.transform.SetParent(this.transform);

            //ポジションを設定する
            float x = i - cards.Count / 2f;
            card.transform.localPosition = new Vector3(x*1.2f,0,0);
        }


    }
}
