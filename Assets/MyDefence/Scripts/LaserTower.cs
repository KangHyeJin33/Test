using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace MyDefence
{
    //LaserTower를 관리하는 클래스
    public class LaserTower : Tower
    {
        #region Field
        public LineRenderer lineRenderer; //레이버빔 그리기
        public ParticleSystem impectEffect; //레이저 임팩트 효과
        public Light impectLight;

        //초당 30데미지 주기
        [SerializeField] private float laserDamage = 30f;
        //[SerializeField] private float moveSpeed = 30f; //1초에 30m가기
        [SerializeField] private float slowRate = 0.4f;
        #endregion

        protected override void Update()
        {
            //타겟이 없으면
            if (target == null)
            {
                if (lineRenderer.enabled)
                {
                    lineRenderer.enabled = false;
                    impectEffect.Stop();
                    //impectLight.enabled = false;
                }
                return;
            }

            //타겟 조준
            LockOn();

            //레이저빔 그리기
            Laser();
        }

        void Laser()
        {
            //레이저 효과 연산하기
            //dir * Time.deltaTime* moveSpeed; //1초에 30m가기
            //이번 프레임에 주는 데미지량
            float damage = laserDamage * Time.deltaTime; //1초 지나면 30m 가기
            //매 프레임 마다 GetComponent<Enemy>();를 하고 있다. -> 성능 문제됨(변수에 저장해서 문제해결 - Tower가서 확인)
            //Enemy enemy = target.GetComponent<Enemy>();
            if (targetEnmey != null)
            {
                targetEnmey.TakeDamage(damage); //1초씩 누적 30
                targetEnmey.Slow(slowRate);


                if (lineRenderer.enabled == false)
                {
                    lineRenderer.enabled = true;
                    impectEffect.Play();
                    lineRenderer.enabled = true;
                }


                lineRenderer.SetPosition(0, firePoint.position);
                lineRenderer.SetPosition(1, target.position);

                //타겟에서 FirePoint를 바라보는 방향 구하기
                Vector3 dir = firePoint.position - target.position;

                impectEffect.transform.position = target.position + dir.normalized / 2f; //dir.normalized(1) / 2 = 0.5만큼 생성
                impectEffect.transform.rotation = Quaternion.LookRotation(dir);
            }
        }
    }
}