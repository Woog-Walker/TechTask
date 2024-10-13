using UnityEngine;

namespace TechnicalTask.SaveLoad
{
    public class SavingManager : MonoBehaviour
    {
        [SerializeField] int timerValue;

        private const string savePrefTimer = "prefTimer";

        public int LoadTimer() => PlayerPrefs.HasKey(savePrefTimer) ? PlayerPrefs.GetInt(savePrefTimer) : 0;

        public void SaveTimer(int incValue) => PlayerPrefs.SetInt(savePrefTimer, incValue);
    }
}

/*
 *         public int LoadTimer()
        {
            if (PlayerPrefs.HasKey(savePrefTimer))
                return timerValue = PlayerPrefs.GetInt(savePrefTimer);
            else return 0;
        }
 */