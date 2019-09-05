﻿using Hello.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Domain.Entities
{
    public class Student : Entity
    {
        protected Student() { }
        public Student(Guid id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        //public Guid Id { get; private set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string Phone { get; private set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthDate { get; private set; }
        


    }
}
