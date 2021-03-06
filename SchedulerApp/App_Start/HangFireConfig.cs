﻿using Hangfire;
using Hangfire.SqlServer;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerApp.App_Start
{
    public static class HangfireConfig
    {
        public static void Configure(IAppBuilder app)
        {
            //GlobalConfiguration.Configuration
            //    .UseSqlServerStorage("hangfire-db", new SqlServerStorageOptions
            //    {
            //        CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
            //        SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
            //        QueuePollInterval = TimeSpan.Zero,
            //        UseRecommendedIsolationLevel = true,
            //        UsePageLocksOnDequeue = true,
            //        DisableGlobalLocks = true
            //    });

            GlobalConfiguration.Configuration
                .UseSqlServerStorage("hangfire-db");

            app.UseHangfireDashboard();
            app.UseHangfireServer();
            app.UseHangfireDashboard();
        }
    }
}
