using SistemaBancario.View;

namespace SistemaBancario.View
{
    internal class SwitchMenuDeAcesso
    {
        public void switchMenuDeAcesso()
        {
            int escolha = Convert.ToInt32(Console.ReadLine());

            switch(escolha)
            {
                case 1:
                    Console.WriteLine("Insira seus dados:");
                    break;

                case 2:
                    Console.WriteLine("Insira seus dados: ");

                    break;

            }
        }
    }
}
