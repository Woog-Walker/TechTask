using UnityEngine;

namespace TechnicalTask.TimerMecha
{
    public class GameDataManager : MonoBehaviour
    {
        public int currentTime { get; set; }

        public GameDataManager(int incTime) => currentTime = incTime;

        public void CreateDataObject(int incTime)
        {
            GameDataManager gameData = new GameDataManager(incTime);

            // LOAD VALUE FROM DATA OBJECT
            Debug.Log(gameData.currentTime);
        }
    }
}