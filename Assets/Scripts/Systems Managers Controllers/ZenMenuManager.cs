using TechnicalTask.Loading;
using TechnicalTask.UI;
using UnityEngine;
using Zenject;

namespace TechnicalTask.TimerMecha
{
    public class ZenMenuManager : MonoInstaller
    {
        [SerializeField] CanvasLoadingManager canvasLoadingManager;
        [SerializeField] LoadingManager loadingManager;

        public override void InstallBindings()
        {
            Container.Bind<CanvasLoadingManager>().FromInstance(canvasLoadingManager);
            Container.Bind<LoadingManager>().FromInstance(loadingManager);
        }
    }
}