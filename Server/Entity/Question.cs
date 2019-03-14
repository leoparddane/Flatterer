//-----------------------------------------------------------------------
// <copyright file=" questions.cs" company="xxxx Enterprises">
// * Copyright (C) 2019 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: questions.cs
// * history : Created by T4 03/14/2019 18:48:26
// </copyright>
//-----------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    /// <summary>
    /// questions Entity Model
    /// </summary>   
    public class Question: EitityBase
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// 问题
        /// </summary>
        public string question { get; set; }

        /// <summary>
        /// 答案
        /// </summary>
        public string answer { get; set; }

        /// <summary>
        /// 权重
        /// </summary>
        public double score { get; set; }
    }
}
