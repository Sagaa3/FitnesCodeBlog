﻿using System;
using System.Security.Cryptography.X509Certificates;


namespace CodeBlogFitnes.CMD.Model
{
    [Serializable]
    internal class Gender
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создать новый пол
        /// </summary>
        /// <param name="name">Имя пола</param>
        public Gender(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или null ", nameof(name));
            }
            Name = name;

            
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
