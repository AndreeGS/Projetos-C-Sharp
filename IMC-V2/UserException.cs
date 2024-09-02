public class UserException : Exception
{
    
    public UserException() : base ("Operação inválida realizada!"){}

    public void UserDuplicate(){
        Console.WriteLine("Erro ao inserir um novo usuário na lista! ");
    }

    public void UserNotFound(){
        Console.WriteLine("Usuário não encontrado na lista!");
    }

    public void UserNotDeleted(){
        Console.WriteLine("Erro ao deletar usuário!");
    }

    
}