using System;
using CAS.Entity.BaseDAModels;

namespace CAS.Entity.DBEntity
{
    [Serializable]
    [TableAttribute("dbo.SYS_BusinessTableFieldsSetup")]
    public class SYSBusinessTableFieldsSetup : BaseTO
    {
        private int _btfsid;
        [SQLField("btfsid", EnumDBFieldUsage.PrimaryKey, true)]
        public int btfsid
        {
            get { return _btfsid; }
            set { _btfsid = value; }
        }
        private int _btsid = 2018004;
        /// <summary>
        /// 业务类型，询价、查勘、初评、报告
        /// </summary>
        public int btsid
        {
            get { return _btsid; }
            set { _btsid = value; }
        }
        private string _fieldname;
        /// <summary>
        /// 业务系统字段名称
        /// </summary>
        public string fieldname
        {
            get { return _fieldname; }
            set { _fieldname = value; }
        }
        private string _showname;
        /// <summary>
        /// 字段显示名称
        /// </summary>
        public string showname
        {
            get { return _showname; }
            set { _showname = value; }
        }
        private bool _issystemfield = false;
        /// <summary>
        /// 是否系统字段
        /// </summary>
        public bool issystemfield
        {
            get { return _issystemfield; }
            set { _issystemfield = value; }
        }
        private int _fieldtype = 20010101;
        /// <summary>
        /// 字段类型（文本、下拉，手机用）
        /// </summary>
        public int fieldtype
        {
            get { return _fieldtype; }
            set { _fieldtype = value; }
        }
        private int _codeid = 0;
        /// <summary>
        /// 关联的字典CODE ID
        /// </summary>
        public int codeid
        {
            get { return _codeid; }
            set { _codeid = value; }
        }
        private bool _iscodevalue = false;
        /// <summary>
        /// 1为CODE值，0为文本值
        /// </summary>
        public bool iscodevalue
        {
            get { return _iscodevalue; }
            set { _iscodevalue = value; }
        }
        private string _fieldvalues;
        /// <summary>
        /// 字段可选值
        /// </summary>
        public string fieldvalues
        {
            get { return _fieldvalues; }
            set { _fieldvalues = value; }
        }
        private string _unit;
        /// <summary>
        /// 单位（要自适应元/万元）
        /// </summary>
        public string unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        private bool _isshow = false;
        /// <summary>
        /// 是否显示
        /// </summary>
        public bool isshow
        {
            get { return _isshow; }
            set { _isshow = value; }
        }
        private bool _issystemmust = false;
        /// <summary>
        /// 是否系统必填
        /// </summary>
        public bool issystemmust
        {
            get { return _issystemmust; }
            set { _issystemmust = value; }
        }
        private bool _ismust = false;
        /// <summary>
        /// 是否必填
        /// </summary>
        public bool ismust
        {
            get { return _ismust; }
            set { _ismust = value; }
        }
        private int _orderid = 0;
        /// <summary>
        /// 排序ID
        /// </summary>
        public int orderid
        {
            get { return _orderid; }
            set { _orderid = value; }
        }
        private bool _isreadonly = false;
        /// <summary>
        /// 是否只读
        /// </summary>
        public bool isreadonly
        {
            get { return _isreadonly; }
            set { _isreadonly = value; }
        }
        private int _width = 0;
        /// <summary>
        /// 宽度
        /// </summary>
        public int width
        {
            get { return _width; }
            set { _width = value; }
        }
        private int _height = 0;
        /// <summary>
        /// 高度
        /// </summary>
        public int height
        {
            get { return _height; }
            set { _height = value; }
        }
        private int _dot = 0;
        /// <summary>
        /// 小数点
        /// </summary>
        public int dot
        {
            get { return _dot; }
            set { _dot = value; }
        }
        private bool _isafy = false;
        /// <summary>
        /// 是否千分位显示
        /// </summary>
        public bool isafy
        {
            get { return _isafy; }
            set { _isafy = value; }
        }

        private bool _issystemreadonly = false;
        /// <summary>
        /// 是否系统只读
        /// </summary>
        public bool issystemreadonly
        {
            get { return _issystemreadonly; }
            set { _issystemreadonly = value; }
        }
        /// <summary>
        /// 最大长度
        /// </summary>
        public int maxlength { get; set; }


        [SQLReadOnly]
        /// <summary>
        /// 业务子类型（委估对象类型、报告类型）
        /// </summary>
        public int subtypecode { get; set; }
        [SQLReadOnly]
        /// <summary>
        /// 各表单的字段分组类型
        /// </summary>
        public int fieldgrouptype { get; set; }

        private string _defaultvalue ;
        /// <summary>
        ///默认值
        /// </summary>
        public string defaultvalue
        {
            get { return _defaultvalue; }
            set { _defaultvalue = value; }
        }

    }
}