using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace globalValue
{
    class MmployeeInfo
    {
        /// <summary>
        /// 员工ID，后台唯一标识，code可用重复使用，ID不行
        /// </summary>
        public string employeeID = string.Empty;

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string employeeName = string.Empty;

        /// <summary>
        /// 员工编号
        /// </summary>
        public string employeeCode = string.Empty;

        /// <summary>
        /// 员工身份证
        /// </summary>
        public string employeeIdCard = string.Empty;

        /// <summary>
        /// 年龄
        /// </summary>
        public string employeeAge = string.Empty;

        /// <summary>
        /// 性别
        /// </summary>
        public string employeeSex = string.Empty;

        /// <summary>
        /// 家庭地址
        /// </summary>
        public string employeeHomeAddress = string.Empty;

        /// <summary>
        /// 家庭电话
        /// </summary>
        public string employeeHomePhone = string.Empty;

        /// <summary>
        /// 个人电话
        /// </summary>
        public string employeePhone = string.Empty;

        /// <summary>
        /// 学历
        /// </summary>
        public string education = string.Empty;

        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime entryDate;

        /// <summary>
        /// 员工状态
        /// </summary>
        public int status=0;

        /// <summary>
        /// 员工职称
        /// </summary>
        public string employeePositional = string.Empty;

        /// <summary>
        /// 类型（在职，退休，合同）
        /// </summary>
        public string employeeType=string.Empty;

        /// <summary>
        /// 员工部门
        /// </summary>
        public string employeeDepartment = string.Empty;

        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime registerDate;

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime modifyDate;

        /// <summary>
        /// 员工id自动补0至7位数
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public string GetEmployeeID(string employeeID)
        {
            if (employeeID is null)
            {
                return "员工ID为空，请联系管理员";
            }
            else
            {
                employeeID = string.Format("{0,d7}", employeeID);
            }
            return employeeID;
        }

        
    }
}
