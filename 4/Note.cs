﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
   
	public class Note<T> : ICloneable, IComparable

    {
        private int[] birthday = new int[3];
        public string UserName { get; private set; }
        public T Number { get; private set; }
        public int[] Birthday { get; private set; }


        public Note(string username, T number, int[] birthday)
        {
            UserName = username;
            Number = number;
            Birthday = birthday;
        }

        public object Clone()
        {
            return new Note<T>(UserName = this.UserName, Number = this.Number,
                                Birthday = this.Birthday);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Note<T> note)
            {
                return string.Compare(this.UserName, note?.UserName);
            }
            else
                throw new Exception("Невозможно сравнить");


        }

        public override string? ToString()
        {
            

            return $"Имя: {UserName} Number: {Number} " +
                $"Birthday: {string.Join("|", Birthday)}";
        }

    }
}

