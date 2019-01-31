// Copyright (c) RunGo. All rights reserved.
// 
// Author:  frank
// Email:   frank@mondol.info
// Created: 2017-01-22
// 
using System;
using RunGo.Repository.Adapters;

namespace RunGo.Repository
{
    public class DbContextOptions
    {
        public DbContextOptions(string connectionString, ISqlAdapter sqlAdapter)
        {
            ConnectionString = connectionString;
            SqlAdapter = sqlAdapter;
        }

        public string ConnectionString { get; }
        public ISqlAdapter SqlAdapter { get; }

        internal static IServiceProvider Services { get; set; }
    }
}
