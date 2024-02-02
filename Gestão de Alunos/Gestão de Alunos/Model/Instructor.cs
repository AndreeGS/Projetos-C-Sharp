using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Alunos.Model
{
    internal class Instructor 
    {
        public int id {  get; set; }
        public string name { get; set; }

        public List <Course>? course { get; set; }

        public Instructor (int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Instructor(int id, string name, List<Course> course)
        {
            this.id = id;
            this.name = name;
            this.course = course;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Instructor)) 
            {  
                return false; 
            }
            
            Instructor other = obj as Instructor;


            return id.Equals(other.id);
        }

        public override string ToString()
        {
            string coursesString = (course != null && course.Count > 0)
           ? string.Join(", ", course.Select(c => c.Name))
           : "Nenhum curso";

            return "Name: " 
                + name
                + "\nid: "
                + id
                + "\nCursos: "
                + coursesString;
        }

    }
}
