using Zenject;
using UnityEngine;
using TechnicalTask.UI;
using TechnicalTask.SaveLoad;

namespace TechnicalTask.TimerMecha
{
    public class ZenInitManager : MonoInstaller
    {
        [SerializeField] TimerManager timerManager;
        [SerializeField] CanvasManager canvasManager;
        [SerializeField] SavingManager savingManager;
        [SerializeField] GameDataManager gameDataManager;

        public override void InstallBindings()
        {
            Container.Bind<TimerManager>().FromInstance(timerManager);
            Container.Bind<CanvasManager>().FromInstance(canvasManager);
            Container.Bind<SavingManager>().FromInstance(savingManager);
            Container.Bind<GameDataManager>().FromInstance(gameDataManager);
        }
    }
}