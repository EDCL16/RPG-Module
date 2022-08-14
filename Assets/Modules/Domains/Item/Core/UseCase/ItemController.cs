#region

using rStar.RPGModules.Item.Infrastructure;
using rStarUtility.Generic.Infrastructure;
using Zenject;

#endregion

namespace rStar.RPGModules.Item.UseCase
{
    public class ItemController : IItemController
    {
    #region Private Variables

        [Inject]
        private CreateItemUseCase createItemUseCase;

        private readonly CreateItemInput createItemInput  = new CreateItemInput();
        private readonly Result          createItemOutput = new Result();

        [Inject]
        private ChangeOwnerUseCase changeOwnerUseCase;

        private readonly ChangeOwnerInput changeOwnerInput  = new ChangeOwnerInput();
        private readonly Result           changeOwnerOutput = new Result();

    #endregion

    #region Public Methods

        public void ChangeOwner(string id , string ownerId)
        {
            changeOwnerInput.id      = id;
            changeOwnerInput.ownerId = ownerId;
            changeOwnerUseCase.Execute(changeOwnerInput , changeOwnerOutput);
        }

        public string CreateItem(string ownerId , string dataId , bool stackable)
        {
            createItemInput.ownerId   = ownerId;
            createItemInput.dataId    = dataId;
            createItemInput.stackable = stackable;
            createItemUseCase.Execute(createItemInput , createItemOutput);
            return createItemOutput.GetId();
        }

    #endregion
    }
}