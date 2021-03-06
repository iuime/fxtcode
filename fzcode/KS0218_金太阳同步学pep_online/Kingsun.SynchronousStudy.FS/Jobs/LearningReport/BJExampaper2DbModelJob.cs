﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using FluentScheduler;
using Kingsun.ExamPaper.BLL;
using Kingsun.IBS.BLL.IBSLearningReport;
using Kingsun.IBS.IBLL.IBSLearningReport;
using Kingsun.SynchronousStudy.FS;

namespace Kingsun.Fs.Jobs
{
    public class BJExampaper2DbModelJob: IJob
    {
        private static FsServiceBll fsBLL = new FsServiceBll();
        void IJob.Execute()
        {
            lock (TimedTask.ExamPaper2DBLock)
            {
                if (TimedTask._shuttingDown)
                {
                    return;
                }
                else
                {

                    Log4Net.LogHelper.Info("单元测试数据入库BJ开始");
                    fsBLL.ExecuteBJExampaper2DB();
                    Log4Net.LogHelper.Info("单元测试数据入库BJ结束");
                }
            }
        }
    }
}