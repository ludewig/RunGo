using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RunGo.Repository;
using RunGo.Repository.Adapters;
using System.Configuration;
using System.Web.Http;

namespace RunGo.Server.Controllers
{
    /// <summary>
    /// API控制器基类
    /// </summary>
    public class BaseApiController:ApiController
    {

    }

    /// <summary>
    /// MVC控制器基类
    /// </summary>
    public class BaseMvcController:System.Web.Mvc.Controller
    {

    }

    public class MasterDbContext:DbContext
    {
        private readonly string connectString = ConfigurationManager.ConnectionStrings["master"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseConnectionString(connectString);
            //使用SQL Server数据库
            optionsBuilder.UseSqlAdapter(new SqlServerAdapter(System.Data.SqlClient.SqlClientFactory.Instance));
        }

        //如果不使用Poco可以不重写此方法
        protected override void OnEntitiesBuilding(EntitiesBuilder entityBuilder)
        {
            //属性名与表列名（列名）不一样，可在此映射别名
            //entityBuilder.Entity<Article>()
            //    .TableName("T_Article")
            //    .ColumnName(p => p.Id, "article_id");
        }
    }
}