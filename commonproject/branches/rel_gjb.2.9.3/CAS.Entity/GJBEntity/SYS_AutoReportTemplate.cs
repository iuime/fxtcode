﻿using CAS.Entity.BaseDAModels;

namespace CAS.Entity.GJBEntity
{
    public class SYS_AutoReportTemplate:DBEntity.SYSAutoReportTemplate
    {
        [SQLReadOnly]
        public string reporttypename{get;set;}
        [SQLReadOnly]
        public string businesstypename{get;set;}
        [SQLReadOnly]
        public string createusername { get; set; }
        [SQLReadOnly]
        public string wordguid { get; set; }
        [SQLReadOnly]
        public string excelguid { get; set; }
        [SQLReadOnly]
        public string RTPinYin { get; set; }
        [SQLReadOnly]
        public string subbusinesstypename { get; set; }
    }
}