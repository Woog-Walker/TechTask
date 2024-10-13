using System.Collections;
using UnityEngine;

namespace TechnicalTask.TimerMecha
{
    public class GameDataManager : MonoBehaviour
    {
        public int currentTime { get; set; }

        public GameDataManager(int incTime) => currentTime = incTime;

        public void CreateDataObject(int incTime) => StartCoroutine(DelayAndCreateDataObject(incTime));

        IEnumerator DelayAndCreateDataObject(int incTime)
        {
            yield return new WaitForSeconds(1);

            GameDataManager gameData = new GameDataManager(incTime);

            Debug.Log($"GAME TIME {gameData.currentTime}");
        }
    }
}