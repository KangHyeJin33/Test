using System.Runtime.CompilerServices;
using UnityEngine;

namespace MyDefence
{
    //게임의 전체 흐름을 관리하는 클래스
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
            //M키를 누르면 10만 골드 지급

        void ShowMeTheMoney()
        {
            if (isCheat == false)
                return;

            PlayerStats.AddMoney(1000000);
        }

        //레벨 업 치팅
        /*void LevelUpcheat()
        {
            PlayerStats.LevelUp();

        }*/

        //...
    }
}

