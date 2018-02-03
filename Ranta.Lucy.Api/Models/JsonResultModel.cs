using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ranta.Lucy.Models.Api
{
    /// <summary>
    /// 通用js返回对象
    /// </summary>
    public class JsonResultModel
    {
        /// <summary>
        /// 标识操作的结果
        /// 0 - 失败
        /// 1 - 成功
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 返回提示信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 返回结果对象
        /// </summary>
        public object Data { get; set; }
    }
}