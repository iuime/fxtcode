﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAS.Entity.DBEntity;
using FxtCenterService.DataAccess;
using System.Data;
using System.Collections;
using CAS.Common;

namespace FxtCenterService.Logic
{
    public class SysCodePriceBL
    {
        /// <summary>
        /// 获取指定CODE影响价格的百分比
        /// </summary>
        /// <param name="cityid">城市ID</param>
        /// <param name="purposecode">用途Code（普通住宅：1002001）</param>
        /// <param name="code">直接指定CODE</param>
        /// <returns></returns>
        public static List<SysCodePrice> GetCodePriceList(int cityid, int purposecode, int[] code)
        {
            return SysCodePriceDA.GetCodePriceList(cityid, purposecode, code);
        }

        /// <summary>
        /// 获取指定修正类型影响价格的百分比
        /// </summary>
        /// <param name="cityid">城市ID</param>
        /// <param name="purposecode">用途Code（普通住宅：1002001）</param>
        /// <param name="typecode">直接指定类型</param>
        /// <returns></returns>
        public static List<SysCodePrice> GetCodePriceList(int cityid, int purposecode, int typecode)
        {
            return SysCodePriceDA.GetCodePriceList(cityid, purposecode, typecode);
        }

        /// <summary>
        /// 获取(楼层、装修)修正系数
        /// 修改人:曾智磊,2014-08-04
        /// </summary>
        /// <param name="cityid">城市ID</param>
        /// <param name="purposecode">用途Code（普通住宅：1002001）</param>
        /// <param name="totalfloor">总楼层</param>
        /// <param name="floornumber">实际楼层</param>
        /// <param name="lv">装修档次</param>
        /// <param name="decorationprobabilit">装修成新率</param>
        /// <param name="sightCode">景观</param>
        /// <param name="frontCode">朝向</param>
        /// <returns></returns>
        public static List<SysCodePrice> GetCodePriceList(int cityid, int purposecode, int totalfloor, int floornumber, int lv, int decorationprobabilit, int sightCode = 0, int frontCode=0,int buildingareatype=0 )
        {
            List<int> code = new List<int>();
            if(sightCode > 0)
            {
                code.Add(sightCode);
            }
            if(frontCode > 0)
            {
                code.Add(frontCode);
            }
            if(buildingareatype > 0)
            {
                code.Add(buildingareatype);
            }
            
            return SysCodePriceDA.GetCodePriceList(cityid,code.ToArray(), purposecode, totalfloor, floornumber, lv, decorationprobabilit);
        }
    }
}
