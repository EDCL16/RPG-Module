#region

using System.Collections.Generic;
using rStar.Modules.Stat.Infrastructure;

#endregion

namespace rStar.Modules.Stat.Entity
{
    public interface IStat : IStatReadModel
    {
    #region Public Methods

        /// <summary>
        ///     command method
        /// </summary>
        /// <param name="amount"></param>
        void AddBaseAmount(int amount);

        void AddModifiers(List<string> modifierIds , List<ModifierType> modifierTypes , List<int> amounts);

        void RemoveModifiers(List<string> modifierIds);

        void SetBaseAmount(int amount);

    #endregion
    }
}