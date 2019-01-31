// Copyright (c) RunGo. All rights reserved.
// 
// Author:  frank
// Email:   frank@mondol.info
// Created: 2017-01-22
// 
using System;
using System.Collections.Generic;
using System.Linq;
using RunGo.Repository.Metadata;

namespace RunGo.Repository
{
    public class EntitiesBuilder
    {
        private readonly Dictionary<Type, IEntityBuilder> _entityTypeBuilders = new Dictionary<Type, IEntityBuilder>();

        public virtual EntityBuilder<TEntity> Entity<TEntity>() where TEntity : class
        {
            var eType = typeof(TEntity);
            if (_entityTypeBuilders.ContainsKey(eType))
                throw new InvalidOperationException($"Entity {eType.FullName} already exists");

            var etBuilder = new EntityBuilder<TEntity>();
            _entityTypeBuilders.Add(eType, etBuilder);

            return etBuilder;
        }

        internal Entities Build()
        {
            var entityTypes = _entityTypeBuilders
                .Select(p => new KeyValuePair<Type, FluentEntityTableInfo>(p.Key, p.Value.Build()))
                .ToDictionary(p => p.Key.TypeHandle, p => p.Value);
            return new Entities(entityTypes);
        }
    }
}
