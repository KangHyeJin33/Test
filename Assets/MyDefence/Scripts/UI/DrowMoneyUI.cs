using UnityEngine;
using TMPro;

namespace MyDefence
{
    //�÷��� ȭ���� Money UI �׸���
    public class DrowMoneyUI : MonoBehaviour
    {
        public TextMeshProUGUI moneyText;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
         
        }

        // Update is called once per frame
        void Update()
        {
            moneyText.text = PlayerStats.Money.ToString(); //text UI�� Money�� ����
        }
    }
}
