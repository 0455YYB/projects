using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace globalValue
{
    public class ModelSet
    {
        /// <summary>
        /// Dll名字
        /// </summary>
        public string modelDllName = string.Empty;

        /// <summary>
        /// 初始化类名
        /// </summary>
        public string modelClassName = string.Empty;

        /// <summary>
        /// 初始化对象显示方法
        /// </summary>
        public string modelMethodName = string.Empty;

        /// <summary>
        /// 父类窗体ID 0表示顶级菜单
        /// </summary>
        public int modelParents;

        /// <summary>
        /// 模块使用标记，0表示可用，1表示停用
        /// </summary>
        public int modelStatus;
    }
}
