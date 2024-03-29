﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Alunos.Model
{
    internal class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<int>? idStudents { get; set; }

        public Course(int id, string? name, List<int>? idStudents)
        {
            Id = id;
            Name = name;
            this.idStudents = idStudents;
        }

        public Course(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public List<int> getAlunos()
        {
            return idStudents;
        }
    }
}

