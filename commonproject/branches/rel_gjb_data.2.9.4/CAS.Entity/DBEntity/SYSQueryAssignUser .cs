﻿using System;
using CAS.Entity.BaseDAModels;

namespace CAS.Entity.DBEntity
{
    [Serializable]
    [TableAttribute("dbo.SYS_QueryAssignUser")]
    public class SYSQueryAssignUser : BaseTO
    {
        private int _id;
        [SQLField("id", EnumDBFieldUsage.PrimaryKey, true)]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _subcompanyid;
        /// <summary>
        /// 分支机构
        /// </summary>
        public int subcompanyid
        {
            get { return _subcompanyid; }
            set { _subcompanyid = value; }
        }
        private int _entrusttypecode;
        /// <summary>
        /// 类型(对公/个人)
        /// </summary>
        public int entrusttypecode
        {
            get { return _entrusttypecode; }
            set { _entrusttypecode = value; }
        }
        private string _querytypecode;
        /// <summary>
        /// 询价类别
        /// </summary>
        public string querytypecode
        {
            get { return _querytypecode; }
            set { _querytypecode = value; }
        }
        private string _queryassignuserids;
        /// <summary>
        /// 询价分配人Id
        /// </summary>
        public string queryassignuserids
        {
            get { return _queryassignuserids; }
            set { _queryassignuserids = value; }
        }
        private string _queryassignusername;
        /// <summary>
        /// 询价分配人名称
        /// </summary>
        public string queryassignusername
        {
            get { return _queryassignusername; }
            set { _queryassignusername = value; }
        }
        private int _createuserid;
        /// <summary>
        /// 创建人
        /// </summary>
        public int createuserid
        {
            get { return _createuserid; }
            set { _createuserid = value; }
        }
        private DateTime _createtime;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createtime
        {
            get { return _createtime; }
            set { _createtime = value; }
        }
        private int? _querybusiness;
        /// <summary>
        /// 询价业务
        /// </summary>
        public int? querybusiness
        {
            get { return _querybusiness; }
            set { _querybusiness = value; }
        }
        private string _businesstypename;
        /// <summary>
        /// 技术团队名--20150615 潘锦发
        /// </summary>
        public string businesstypename
        {
            get { return _businesstypename; }
            set { _businesstypename = value; }
        }
        private string _businesstypeid;
        /// <summary>
        /// 技术团队id--20150615 潘锦发
        /// </summary>
        public string businesstypeid
        {
            get { return _businesstypeid; }
            set { _businesstypeid = value; }
        }
        private bool? _valid = true;
        /// <summary>
        /// 是否有效，用作删除标记
        /// </summary>
        public bool? valid
        {
            get { return _valid; }
            set { _valid = value; }
        }
    }
}