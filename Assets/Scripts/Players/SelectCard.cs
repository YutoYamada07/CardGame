using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCard : MonoBehaviour
{

    //playerが選択したカードを所定の場所（SelectCardの位置）におく

    public void SetCard(Card card)
    {
        //カードの親を自分にする
        card.transform.SetParent(this.transform);
        card.transform.localPosition = Vector3.zero;
    }
}
