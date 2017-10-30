using UnityEngine;
using Zenject;

namespace DI.Exam03
{
    public class TouchGameInstaller : MonoInstaller<TouchGameInstaller>
    {
        public override void InstallBindings()
        {
            //���� �ٸ� �ν��Ͻ��� ������
            //Container.Bind<IHandleInput>().To<TouchInputHandler>().AsCached();
            //Container.Bind<ITickable>().To<TouchInputHandler>().AsCached();

            //�ش� Ÿ���� ��ӹ��� �������̽��� ��� ���ε�
            Container.BindInterfacesTo<TouchInputHandler>().AsCached();
            Container.Bind<GameStateReadyToStart>().AsTransient().NonLazy();

        }
    }
}