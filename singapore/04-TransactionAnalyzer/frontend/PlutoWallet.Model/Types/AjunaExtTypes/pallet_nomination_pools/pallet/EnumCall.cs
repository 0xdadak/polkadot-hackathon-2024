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


namespace Substrate.NetApi.Generated.Model.pallet_nomination_pools.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> join
        /// See [`Pallet::join`].
        /// </summary>
        join = 0,
        
        /// <summary>
        /// >> bond_extra
        /// See [`Pallet::bond_extra`].
        /// </summary>
        bond_extra = 1,
        
        /// <summary>
        /// >> claim_payout
        /// See [`Pallet::claim_payout`].
        /// </summary>
        claim_payout = 2,
        
        /// <summary>
        /// >> unbond
        /// See [`Pallet::unbond`].
        /// </summary>
        unbond = 3,
        
        /// <summary>
        /// >> pool_withdraw_unbonded
        /// See [`Pallet::pool_withdraw_unbonded`].
        /// </summary>
        pool_withdraw_unbonded = 4,
        
        /// <summary>
        /// >> withdraw_unbonded
        /// See [`Pallet::withdraw_unbonded`].
        /// </summary>
        withdraw_unbonded = 5,
        
        /// <summary>
        /// >> create
        /// See [`Pallet::create`].
        /// </summary>
        create = 6,
        
        /// <summary>
        /// >> create_with_pool_id
        /// See [`Pallet::create_with_pool_id`].
        /// </summary>
        create_with_pool_id = 7,
        
        /// <summary>
        /// >> nominate
        /// See [`Pallet::nominate`].
        /// </summary>
        nominate = 8,
        
        /// <summary>
        /// >> set_state
        /// See [`Pallet::set_state`].
        /// </summary>
        set_state = 9,
        
        /// <summary>
        /// >> set_metadata
        /// See [`Pallet::set_metadata`].
        /// </summary>
        set_metadata = 10,
        
        /// <summary>
        /// >> set_configs
        /// See [`Pallet::set_configs`].
        /// </summary>
        set_configs = 11,
        
        /// <summary>
        /// >> update_roles
        /// See [`Pallet::update_roles`].
        /// </summary>
        update_roles = 12,
        
        /// <summary>
        /// >> chill
        /// See [`Pallet::chill`].
        /// </summary>
        chill = 13,
        
        /// <summary>
        /// >> bond_extra_other
        /// See [`Pallet::bond_extra_other`].
        /// </summary>
        bond_extra_other = 14,
        
        /// <summary>
        /// >> set_claim_permission
        /// See [`Pallet::set_claim_permission`].
        /// </summary>
        set_claim_permission = 15,
        
        /// <summary>
        /// >> claim_payout_other
        /// See [`Pallet::claim_payout_other`].
        /// </summary>
        claim_payout_other = 16,
        
        /// <summary>
        /// >> set_commission
        /// See [`Pallet::set_commission`].
        /// </summary>
        set_commission = 17,
        
        /// <summary>
        /// >> set_commission_max
        /// See [`Pallet::set_commission_max`].
        /// </summary>
        set_commission_max = 18,
        
        /// <summary>
        /// >> set_commission_change_rate
        /// See [`Pallet::set_commission_change_rate`].
        /// </summary>
        set_commission_change_rate = 19,
        
        /// <summary>
        /// >> claim_commission
        /// See [`Pallet::claim_commission`].
        /// </summary>
        claim_commission = 20,
        
        /// <summary>
        /// >> adjust_pool_deposit
        /// See [`Pallet::adjust_pool_deposit`].
        /// </summary>
        adjust_pool_deposit = 21,
        
        /// <summary>
        /// >> set_commission_claim_permission
        /// See [`Pallet::set_commission_claim_permission`].
        /// </summary>
        set_commission_claim_permission = 22,
    }
    
    /// <summary>
    /// >> 306 - Variant[pallet_nomination_pools.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumBondExtra, BaseVoid, BaseTuple<Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumPoolState>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, BaseTuple<Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumConfigOp, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumConfigOp, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumConfigOp, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumConfigOp, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumConfigOp, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumConfigOp>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumConfigOp, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumConfigOp, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumConfigOp>, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumBondExtra>, Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumClaimPermission, Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill, Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32>>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Generated.Model.pallet_nomination_pools.CommissionChangeRate>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Generated.Model.pallet_nomination_pools.EnumCommissionClaimPermission>>>
    {
    }
}