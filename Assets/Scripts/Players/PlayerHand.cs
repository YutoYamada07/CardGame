using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    
    //��D��ێ�����i���X�g�j
    //�J�[�h�I�������Ă����J�[�h����D�ɖ߂�悤�ɂ���
    //�J�[�h��I�������Ƃ���hand��card����D����Ȃ��Ȃ�悤�ɂ���

    [SerializeField]List<Card> cards = new List<Card>();
    //�ŏ���Player�����D���󂯎��

    public void SetHandCards(List<Card> cards)
    {
        this.cards = cards;

        
        RefreshHand();
    }

    //���[�ǂ��^����ꂽ���D�𐮗񂷂�
    void RefreshHand()
    {
        
        for (int i = 0; i < cards.Count; i++)
        {
            Card card = cards[i];
            //�J�[�h�������̎q�v�f�ɂ���
            card.transform.SetParent(this.transform);

            //�|�W�V������ݒ肷��
            float x = i - cards.Count / 2f;
            card.transform.localPosition = new Vector3(x*1.2f,0,0);
        }


    }
}
