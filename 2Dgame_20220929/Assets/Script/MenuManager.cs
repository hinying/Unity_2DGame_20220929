using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Hsin
{
    /// <summary>
    /// ���޲z��
    /// </summary>
    public class MenuManager : MonoBehaviour
    {
        /// <summary>
        /// �}�l�C��
        /// </summary>
        private Button btnPlay;

        private void Awake()
        {
            btnPlay = GameObject.Find("�}�l�C��").GetComponent<Button>();
            btnPlay.onClick.AddListener(StartGame);
        }

        /// <summary>
        /// �}�l�C��
        /// </summary>
        private void StartGame()
        {
            SceneManager.LoadScene("�C������");
        }
    }

}
