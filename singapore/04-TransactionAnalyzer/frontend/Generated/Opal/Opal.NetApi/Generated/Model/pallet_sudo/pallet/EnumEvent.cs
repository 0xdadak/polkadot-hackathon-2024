//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Opal.NetApi.Generated.Model.pallet_sudo.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Sudid
        /// A sudo call just took place.
        /// </summary>
        Sudid = 0,
        
        /// <summary>
        /// >> KeyChanged
        /// The sudo key has been updated.
        /// </summary>
        KeyChanged = 1,
        
        /// <summary>
        /// >> SudoAsDone
        /// A [sudo_as](Pallet::sudo_as) call just took place.
        /// </summary>
        SudoAsDone = 2,
    }
    
    /// <summary>
    /// >> 42 - Variant[pallet_sudo.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Opal.NetApi.Generated.Types.Base.EnumResult, Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Opal.NetApi.Generated.Types.Base.EnumResult>
    {
    }
}