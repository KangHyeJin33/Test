using System.Runtime.CompilerServices;
using UnityEngine;

namespace MyDefence
{
    //������ ��ü �帧�� �����ϴ� Ŭ����
    public class GameManager : MonoBehaviour
    {
        #region field
        private bool isCheat = false;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
           
        }
            
        

        private void FixedUpdate()
        {
            //Cheating
            if (Input.GetKeyDown(KeyCode.M))
            {
                ShowMeTheMoney();
            }

        }

            //Cheating
            //MŰ�� ������ 10�� ��� ����

        void ShowMeTheMoney()
        {
            if (isCheat == false)
                return;

            PlayerStats.AddMoney(1000000);
        }

        //���� �� ġ��
        /*void LevelUpcheat()
        {
            PlayerStats.LevelUp();

        }*/

        //...
    }
}

