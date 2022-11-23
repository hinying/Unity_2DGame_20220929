using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// �R������
    /// </summary>
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("�R���ɶ�"),Range(0, 3) ]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            //gameObject ���}�����C������
            //�R��(����, �R���ɶ�)
            Destroy(gameObject, destroyTime);
        }

        //�i���ƥ�G���V���� (Randerer) �X�{�b Scene �� Game �ɰ���@��
        private void OnBecameVisible()
        {
            
        }

        //���i���ƥ�G���V���� (Randerer) �����b Scene �� Game �ɰ���@��
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

    }
}

