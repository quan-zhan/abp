﻿using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace MyCompanyName.MyProjectName.MongoDB;

[DependsOn(
    typeof(MyProjectNameTestBaseModule),
    typeof(MyProjectNameMongoDbModule)
    )]
public class MyProjectNameMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
