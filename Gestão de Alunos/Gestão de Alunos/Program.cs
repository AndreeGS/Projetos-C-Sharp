using Gestão_de_Alunos.Model;

namespace Gestão_de_Alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int select;

            HashSet<Instructor> instructor = new HashSet<Instructor>();
            List<Course> courses = new List<Course>();



            Console.WriteLine("Gestor de Alunos");
            Console.WriteLine("O que deseja fazer?");

            do
            {
                Console.WriteLine("1 - Cadastrar Professor");
                Console.WriteLine("2 - Cadastrar curso");
                Console.WriteLine("3 - Visualizar Professores e seus cursos");
                Console.WriteLine("4 - Sair");

                select = int.Parse(Console.ReadLine());

                switch (select)
                {                   
                    case 1:
                        try
                        {
                            Console.WriteLine("Informe os dados");
                            Console.Write("Nome: ");
                            string name = Console.ReadLine();

                            Console.Write("ID: ");
                            int id = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ele possui algum curso? (S/N)");
                            string possuiCurso = Console.ReadLine().ToUpper();

                            if (possuiCurso == "S")
                            {
                                Console.WriteLine("Qual a quantidade de cursos?");
                                int quantidadeDeCursos = int.Parse(Console.ReadLine());

                                for (int i = 0; i < quantidadeDeCursos; i++)
                                {
                                    Console.Write("Nome do Curso:");
                                    string nameCourse = Console.ReadLine();

                                    Console.Write("ID do Curso: ");
                                    int idCourse = int.Parse(Console.ReadLine());

                                    courses.Add(new Course(idCourse, nameCourse));
                                }

                                try { 
                                    instructor.Add(new Instructor(id, name, courses));

                                    Console.WriteLine("Instrutor cadastrado com sucesso!");
                                }
                                catch(Exception e) { Console.WriteLine("O id do instrutor já está em uso: " + e.Message) ;}
                            }

                            else
                            {
                                try {
                                    instructor.Add(new Instructor(id, name));
                                    Console.WriteLine("Instrutor cadastrado com sucesso!");
                                }
                                catch(Exception e) { Console.WriteLine("o Id do isntrutor já está em uso: " + e.Message) ;}
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Error ao cadastrar o instrutor!" + e.Message);
                        }

                    break;
                    case 2:
                        Console.Write("Informe o ID do instrutor: ");
                        int idInstructor = int.Parse(Console.ReadLine());

                        Instructor ins = instructor.FirstOrDefault(ins => ins.id == idInstructor);
                 
                        if(ins == null)
                        {
                            Console.WriteLine("Instrutor não encontrado!");
                        }
                        else
                        {
                            Console.Write("Informe o id do curso: ");
                            int idCourse = int.Parse(Console.ReadLine());

                            Console.Write("Informe o nome do curso: ");
                            string nameCourse = Console.ReadLine();

                            ins.course.Add(new Course(idCourse, nameCourse));
                        }

                    break;
                    case 3:
                        Console.WriteLine("Professores e cursos: ");
                        foreach (Instructor instruc in instructor)
                        {
                            Console.WriteLine(instruc);
                        }
                    break;

                    default: 
                        Console.WriteLine("Opção inválida");
                    break;
                }
            } while (select != 4);
        }
    }
}