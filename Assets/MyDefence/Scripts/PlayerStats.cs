using Mono.Cecil.Cil;
using UnityEngine;

namespace MyDefence
{
    //플레이어의 속성들을 관리하는 클래스
    public class PlayerStats : MonoBehaviour
    {
        #region Field
        //소지금
        private static int money;

        //초기 소지금
        [SerializeField] private int startMoney = 4000;

        //Life
        private static int lives;
        //초기 생명 갯수
        [SerializeField] private int startlives = 10;
        #endregion

        #region Property
        //소지금 읽기 전용 속성
        public static int Money
        {
            get { return money; }
        }

        //생명 읽기 전용 속성
        public static int Lives
        {
            get { return lives; }
        }
        /// </summary>
        #endregion
                
        private void Start()
        {
            //초기화
            //초기 소지금 지급 4000
            money = startMoney;
            lives = startlives;
        }

        //벌기, 쓰기, 소지금 확인 함수 만들기
        public static void AddMoney(int amount)
        {
            money += amount;
        }

        public static bool UseMoney(int amount)
        {
            //소지금 체크
            if(money < amount)
            {
                Debug.Log("소지금이 부족합니다");
                return false;
            }

            money -= amount;
            return true;
        }
        
        public static bool HasMoney(int amount)
        {
            return money >= amount;
        }

        //Life 추가
        public static void AddLives(int amount)
        {
            lives += amount;
        }

        //Life 사용
        public static void UseLives(int amount)
        {
            lives -= amount;

            if (lives <= 0)
            {
                lives = 0;
                //게임 오버
                Debug.Log("Game Over !");
            }
        }
        

    }
   }

