using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCard : MonoBehaviour
{

    //player���I�������J�[�h������̏ꏊ�iSelectCard�̈ʒu�j�ɂ���

    public void SetCard(Card card)
    {
        //�J�[�h�̐e�������ɂ���
        card.transform.SetParent(this.transform);
        card.transform.localPosition = Vector3.zero;
    }
}
