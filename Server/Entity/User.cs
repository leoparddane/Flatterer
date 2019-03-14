//-----------------------------------------------------------------------
// <copyright file=" users.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: users.cs
// * history : Created by T4 03/14/2019 18:48:26
// </copyright>
//-----------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    /// <summary>
    /// users Entity Model
    /// </summary>   
    public class User: EitityBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }
   
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
   
        /// <summary>
        /// 
        /// </summary>
        public string password { get; set; }
   
        /// <summary>
        /// 0:禁用 1:启用
        /// </summary>
        public int state { get; set; }
    }
}
