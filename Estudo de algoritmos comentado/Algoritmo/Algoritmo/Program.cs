using System;

/* O algoritmo a seguir calcula a quantidade de notas de 100,50,10 e 1 deverão ser retornadas de acordo com o valor recebido de entrada.
Ele segue os seguintes passos:

Entrada de dados
1. Ler o valor de entrada e atribui a variável int valor. A variável deve ser int para realizar o truncamento posteriormente;

Processamento
2. O valor é divido por 100 (nota mais alta) e ocorrerá um truncamento no resultado. Ex: se int valor = 75 -> 75 / 100 = 0,75 sendo considerado 0;
3. Em seguida, valor receberá o mod da divisão anterior. Ex: se int valor = 75 -> 75 % 100 -> O resto será 75;
4. Da mesma forma que anteriormente, é feita a divisão do valor por 50. Ex: Se int valor = 75 -> 75 / 50 = 1,5, sendo considerado 1;
5. Então quando verificamos o mod teremos um novo valor. Ex: valor = 75 -> 75 % 50 = 25.
6. Sendo 25 o novo valor, vamos seguir com a próxima nota. Ex: valor = 25 -> 25 / 10 = 2,5, sendo considerado 2.
7. Da mesma forma vamos calcular o mod e atribuir à variável valor. Ex: valor = 25 -> 25 % 10 = 5.
8. Por fim, na última opção de notas disponível, a quantidade de notas de 1 será igual a quantidade da variável valor. valor = 5 -> 5 / 1 = 5.

Em seguida é feita a Saída de dados.

Espero ter sido claro na explicação :)
 */
class Program
{
    static void Main()
    {
        
        Console.WriteLine("Digite o valor para o qual deseja calcular as notas:");

        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            Console.WriteLine();
            int notas100 = valor / 100;
            Console.WriteLine(notas100);

            valor %= 100;
            Console.WriteLine(valor);

            Console.WriteLine();
            int notas50 = valor / 50;
            Console.WriteLine(notas50);

            valor %= 50;
            Console.WriteLine(valor);

            Console.WriteLine();
            int notas10 = valor / 10;
            Console.WriteLine(notas10);

            valor%= 10;
            Console.WriteLine(valor);

            Console.WriteLine();
            int notas1 = valor;
            Console.WriteLine(notas1);

            Console.WriteLine($"Notas de 100: {notas100}");
            Console.WriteLine($"Notas de 50: {notas50}");
            Console.WriteLine($"Notas de 10: {notas10}");
            Console.WriteLine($"Notas de 1: {notas1}");
        }
        else
        {
            Console.WriteLine("Por favor, digite um valor numérico válido.");
        }
    }
}
