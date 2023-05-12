using UnityEngine;

namespace HSIN
{
    /// <summary>
    /// 刪除物件
    /// </summary>
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"),Range(0, 3) ]
        private float destroyTime = 0.5f;

        [SerializeField, Header("碰到會刪除的名稱")]
        private string nameToDestroy;

        private void Awake()
        {
            //gameObject 此腳本的遊戲物件
            //刪除(物件, 刪除時間)
            Destroy(gameObject, destroyTime);
        }

        //可見事件：當渲染元件 (Randerer) 出現在 Scene 或 Game 時執行一次
        private void OnBecameVisible()
        {
            
        }

        //不可見事件：當渲染元件 (Randerer) 消失在 Scene 或 Game 時執行一次
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // 如果 碰到物件的名稱 包含 (碰到會刪除的名稱) 就 刪除物件
            if (collision.gameObject.name.Contains(nameToDestroy))
            {
                Destroy(gameObject);
            }
        }

    }
}

