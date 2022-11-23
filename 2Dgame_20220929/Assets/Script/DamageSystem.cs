using UnityEngine;

namespace Hsin
{
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;
        [Header("受傷與爆炸音效")]
        [SerializeField]        
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        // 碰撞開始時執行一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);

            // 如果碰撞的物件名稱 包含 nameTarget 就爆炸並刪除
            if (collision.gameObject.name.Contains(nameTarget))
            {
                // 生成爆炸預製物 座標與角度 跟此物件相同
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManager.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));

                // 刪除 Destroy
                // 刪除 gameObject
                Destroy(gameObject);
            }

        }

        // 碰撞離開時執行一次
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        // 碰撞時持續執行
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }

}
