using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace MyDefence
{
    //LaserTower�� �����ϴ� Ŭ����
    public class LaserTower : Tower
    {
        #region Field
        public LineRenderer lineRenderer; //���̹��� �׸���
        public ParticleSystem impectEffect; //������ ����Ʈ ȿ��
        public Light impectLight;

        //�ʴ� 30������ �ֱ�
        [SerializeField] private float laserDamage = 30f;
        //[SerializeField] private float moveSpeed = 30f; //1�ʿ� 30m����
        [SerializeField] private float slowRate = 0.4f;
        #endregion

        protected override void Update()
        {
            //Ÿ���� ������
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

            //Ÿ�� ����
            LockOn();

            //�������� �׸���
            Laser();
        }

        void Laser()
        {
            //������ ȿ�� �����ϱ�
            //dir * Time.deltaTime* moveSpeed; //1�ʿ� 30m����
            //�̹� �����ӿ� �ִ� ��������
            float damage = laserDamage * Time.deltaTime; //1�� ������ 30m ����
            //�� ������ ���� GetComponent<Enemy>();�� �ϰ� �ִ�. -> ���� ������(������ �����ؼ� �����ذ� - Tower���� Ȯ��)
            //Enemy enemy = target.GetComponent<Enemy>();
            if (targetEnmey != null)
            {
                targetEnmey.TakeDamage(damage); //1�ʾ� ���� 30
                targetEnmey.Slow(slowRate);


                if (lineRenderer.enabled == false)
                {
                    lineRenderer.enabled = true;
                    impectEffect.Play();
                    lineRenderer.enabled = true;
                }


                lineRenderer.SetPosition(0, firePoint.position);
                lineRenderer.SetPosition(1, target.position);

                //Ÿ�ٿ��� FirePoint�� �ٶ󺸴� ���� ���ϱ�
                Vector3 dir = firePoint.position - target.position;

                impectEffect.transform.position = target.position + dir.normalized / 2f; //dir.normalized(1) / 2 = 0.5��ŭ ����
                impectEffect.transform.rotation = Quaternion.LookRotation(dir);
            }
        }
    }
}