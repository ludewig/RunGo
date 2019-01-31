// Copyright (c) RunGo. All rights reserved.
// 
// Author:  frank
// Email:   frank@mondol.info
// Created: 2017-01-22
// 
using RunGo.Repository.Adapters;

namespace RunGo.Repository.Internal
{
    public interface IDbContextServices
    {
        string ConnectionString { get; }
        ISqlAdapter SqlAdapter { get; }
        IEntityMapper EntityMapper { get; }
        ISqlGenerater SqlGenerater { get; }
    }
}
