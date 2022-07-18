#region

using rStar.Modules.Skill.Core;
using rStarUtility.DDD.Implement.Core;
using Zenject;

#endregion

namespace rStar.Modules.Skill.Example1
{
    public class SkillExample1Installer : MonoInstaller
    {
    #region Public Methods

        public override void InstallBindings()
        {
            DDDInstaller.Install(Container);
            SkillInstaller.Install(Container);
            Container.Bind<SkillEventHandler>().AsSingle().NonLazy();
            Container.BindInterfacesTo<SkillExamplePresenter>().AsSingle();
            Container.UnbindInterfacesTo<SkillTicker>();
        }

    #endregion
    }
}