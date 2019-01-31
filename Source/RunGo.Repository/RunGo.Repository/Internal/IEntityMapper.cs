// Copyright (c) RunGo. All rights reserved.
// 
// Author:  frank
// Email:   frank@mondol.info
// Created: 2017-01-22
// 
using System;
using RunGo.Repository.Metadata;

namespace RunGo.Repository.Internal
{
    public interface IEntityMapper
    {
        EntityTableInfo GetEntityTableInfo(Type entityType);
    }
}
