using UnityEngine;

namespace Sample
{

    public class InitialrizeTest : MonoBehaviour
    {
        //�ʵ� ����ο��� �ʱ�ȭ
        [SerializeField] private int number = 50;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //start �Լ����� �ʱ�ȭ
            //number = 20;

        }
        private void Update()
        {
            Debug.Log($"Number : {number}");

        }
    }
}
/*
//�ʵ� �ʱ�ȭ ���� ����

1. �ʵ� ����ο��� �ʱ�ȭ�� ���� �����ͼ� ����
2. �ν�����â�� �Էµ� ���� �����ͼ� ����
3. start �Լ����� �ʱ�ȭ�� ���� ������ ����
 */