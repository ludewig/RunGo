// Copyright (c) RunGo. All rights reserved.
// 
// Author:  frank
// Email:   frank@mondol.info
// Created: 2017-01-22
// 
using System;

namespace RunGo.Repository
{
    /// <summary>
    ///     Represents the contract for the transaction.
    /// </summary>
    /// <remarks>
    ///     A PetaPoco helper to support transactions using the using syntax.
    /// </remarks>
    public interface ITransaction : IDisposable, IHideObjectMethods
    {
        /// <summary>
        ///     Completes the transaction. Not calling complete will cause the transaction to rollback on dispose.
        /// </summary>
        void Complete();
    }
}
