using Gestão_de_Alunos.Model;

namespace Gestão_de_Alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int select;

            HashSet<Instructor> instructor = new HashSet<Instructor>();
            

            Console.WriteLine("Gestor de Alunos");
            Console.WriteLine("O que deseja fazer?");

            do
            {
                Console.WriteLine("1 - Cadastrar Professor");

                select = int.Parse(Console.ReadLine());

                switch (select)
                {                   
                    case 1:
                        Console.WriteLine("Informe os dados");
                        Console.Write("Nome: ");
                        string name = Console.ReadLine();

                        Console.Write("ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ele possui algum curso? (S/N)");
                        string possuiCurso = Console.ReadLine().ToUpper();

                        if (possuiCurso == "S")
                        {
                            List<Course> courses = new List<Course>();
                            Console.WriteLine("Qual a quantidade de cursos?");
                            int quantidadeDeCursos = int.Parse(Console.ReadLine());

                            for (int i = 0; i < quantidadeDeCursos; i++) {
                                Console.Write("Nome do Curso:");
                                string nameCourse = Console.ReadLine();

                                Console.Write("ID do Curso: ");
                                int idCourse = int.Parse(Console.ReadLine());

                                courses.Add(new Course(idCourse, nameCourse));
                            }
                            instructor.Add(new Instructor(id, name, courses));

                            Console.WriteLine("Instrutor cadastrado com sucesso!");
                        }

                        else
                        {
                            instructor.Add(new Instructor(id, name));
                            Console.WriteLine("Instrutor cadastrado com sucesso!");
                        }


                        Console.WriteLine("Instructors: ");

                        foreach(Instructor instruc in instructor)
                        {
                            Console.WriteLine(instruc);
                        }

                        break;

                       
                }
            } while (select != 4);
        }
    }
}