
using UnityEngine;


namespace Hsin
{
    /// <summary>
    /// 學習欄位 Feild
    /// </summary>
    public class LearnFeild : MonoBehaviour
    {
        // 欄位 Feild : 儲存資料
        // 語法 : 
        // 修飾詞 資料類型 欄位名稱 ;

        private int level;
        //定義了一筆資料，名稱是 level ，類型是整數

        // = 指定符號 : 將右邊的結果給左邊
        // 修飾詞 : 設定資料權限
        // 私人 : 僅允許此類別存取
        private int enemy = 7;
        //公開 : 允許所有類別存取
        public int hp = 100;

        //整數
        public int countProp = 7;

        //浮點數
        public float speed = 3.5f;
        public float jump = 7.7f;

        //字串
        public string namePlayer = "小騎士";
        public string content = "嗨，你好~";

        //布林值
        public bool isPass = true;
        public bool isDead = false;

        // 標題 : 直接顯示在上方
        [Header("武器數量")]
        public int weaponCount = 10;
        // 提示 : 滑鼠放上才出現
        [Tooltip("這是補充 100 滴 HP 的紅色藥水，一罐999元。")]
        public string propName = "紅色藥水";

        // 範圍 : 有滑感
        [Range(0, 100)]
        public int score = 60;
        [Range(1f, 10.5f)]
        public float walkSpeed = 3.7f;
        [Range(1, 7)]
        public string nameWeapon = "打火機";

        // 序列化欄位 : 原本是私人不會顯示的，顯示出來
        [SerializeField]
        private string password = "123456789";

        //可分開寫
        [Header("數字")]
        [Range(0, 100)]
        [SerializeField]
        private int number = 77;

        //可寫一起
        [SerializeField, Header("是否開門")]
        private bool isOpen = false;

    }
}

