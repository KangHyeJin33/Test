using UnityEngine;
using TMPro;

namespace MyDefence
{
    //플레이 화면의 Money UI 그리기
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
            moneyText.text = PlayerStats.Money.ToString(); //text UI를 Money에 연결
        }
    }
}
