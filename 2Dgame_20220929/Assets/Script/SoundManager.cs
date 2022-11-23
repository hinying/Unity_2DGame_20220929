using UnityEngine;

namespace Hsin
{
    /// <summary>
    /// ���ĺ޲z��
    /// </summary>
    /// �M�ε{���ɰ���G�n�D����(����(����)) - �Ĥ@���M�θ}��������ɷ|�K�[����
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;

        private AudioSource aud;

        private void Awake()
        {
            // this �����O
            instance = this;

            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// ���񭵮�
        /// </summary>
        /// <param name="sound">����</param>
        /// <param name="rangeVolume">���q�d��</param>
        public void PlaySound(AudioClip sound, Vector2 rangeVolume)
        {
            float volume = Random.Range(rangeVolume.x, rangeVolume.y);
            aud.PlayOneShot(sound, volume);
        }
    }
}

