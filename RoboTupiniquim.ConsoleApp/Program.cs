namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Robô Tupiniquim --------");
            Console.WriteLine();

            // Entrada da área X e Y
            Console.Write(">> Digite o tamanho da área X e Y: ");
            string[] area = Console.ReadLine().Split(' ');
            string xInput = area[0];
            string yInput = area[1];

            // Conversor do X e Y para Int
            int xInputInt = Convert.ToInt32(xInput);
            int yInputInt = Convert.ToInt32(yInput);

            // Array X e Y
            string[] x = new string[xInputInt];
            string[] y = new string[yInputInt];

            int contadorX1 = 0;
            int contadorY1 = 0;
            int contadorX2 = 0;
            int contadorY2 = 0;
            
            // Entrada de início robô 1
            Console.WriteLine();
            Console.WriteLine(">> Digite a posição inicial X, Y e a direção em qual o primeiro robô iniciará");
            Console.WriteLine(">> Use números inteiros e as direções \"N, S, L ou O\"");
            Console.Write(">> ");
            string[] posicaoInicial1 = Console.ReadLine().ToUpper().Split(' ');
            string xInicial1 = posicaoInicial1[0];
            string yInicial1 = posicaoInicial1[1];
            string direcaoRoboStr1 = posicaoInicial1[2];

            char direcaoRobo1 = Convert.ToChar(direcaoRoboStr1);

            // Validação robô 1
            if (direcaoRobo1 != 'N' && direcaoRobo1 != 'S' && direcaoRobo1 != 'L' && direcaoRobo1 != 'O')
            {
                Console.WriteLine("Direção inválida");
            }

            contadorX1 = Convert.ToInt32(xInicial1);
            contadorY1 = Convert.ToInt32(yInicial1);

            // Entrada de movimentos robô 1
            Console.WriteLine();
            Console.WriteLine(">> Digite a lista de comandos de movimento do primeiro robô");
            Console.WriteLine(">> Use \"D\" para virar 90° graus à direita, ou \"E\" para virar 90° graus à esquerda ");
            Console.WriteLine(">> Use \"M\" para movimentar o robô para frente");
            Console.Write(">> ");
            string movimento1 = Console.ReadLine().ToUpper();

            // Entrada de dados robô 2
            Console.WriteLine();
            Console.WriteLine(">> Digite a posição inicial X, Y e a direção em qual o segundo robô iniciará");
            Console.WriteLine(">> Use números inteiros e as direções \"N, S, L ou O\"");
            Console.Write(">> ");
            string[] posicaoInicial2 = Console.ReadLine().ToUpper().Split(' ');
            string xInicial2 = posicaoInicial2[0];
            string yInicial2 = posicaoInicial2[1];
            string direcaoRoboStr2 = posicaoInicial2[2];

            char direcaoRobo2 = Convert.ToChar(direcaoRoboStr2);

            // Validação robô 2
            if (direcaoRobo2 != 'N' && direcaoRobo2 != 'S' && direcaoRobo2 != 'L' && direcaoRobo2 != 'O')
            {
                Console.WriteLine("Direção inválida");
            }

            contadorX2 = Convert.ToInt32(xInicial2);
            contadorY2 = Convert.ToInt32(yInicial2);

            // Entrada de movimentos robô 2
            Console.WriteLine();
            Console.WriteLine(">> Digite a lista de comandos de movimento do primeiro robô");
            Console.WriteLine(">> Use \"D\" para virar 90° graus à direita, ou \"E\" para virar 90° graus à esquerda ");
            Console.WriteLine(">> Use \"M\" para movimentar o robô para frente");
            Console.Write(">> ");
            string movimento2 = Console.ReadLine().ToUpper();

            // Processamento robô 1
            foreach (char mov1 in movimento1)
            {
                if (mov1 == 'E')
                {
                    switch (direcaoRobo1)
                    {
                        case 'L': direcaoRobo1 = 'N';
                            break;
                        case 'N': direcaoRobo1 = 'O';
                            break;
                        case 'O': direcaoRobo1 = 'S';
                            break;
                        case 'S': direcaoRobo1 = 'L';
                            break;
                    }
                }
                
                else if (mov1 == 'D')
                {
                    switch (direcaoRobo1)
                    {
                        case 'N': direcaoRobo1 = 'L';
                            break;
                        case 'L': direcaoRobo1 = 'S';
                            break;
                        case 'S': direcaoRobo1 = 'O';
                            break;
                        case 'O': direcaoRobo1 = 'N';
                            break;
                    }
                }
                
                else if (mov1 == 'M')
                {
                    switch (direcaoRobo1)
                    {
                        case 'N': if (contadorY1 < xInputInt) contadorY1++; break;
                        case 'L': if (contadorX1 < xInputInt) contadorX1++; break;
                        case 'S': if (contadorY1 > 0) contadorY1--; break;
                        case 'O': if (contadorX1 > 0) contadorX1--; break;
                    }
                }
            }

            // Processamento robô 2
            foreach (char mov2 in movimento2)
            {
                if (mov2 == 'E')
                {
                    switch (direcaoRobo2)
                    {
                        case 'L':
                            direcaoRobo2 = 'N';
                            break;
                        case 'N':
                            direcaoRobo2 = 'O';
                            break;
                        case 'O':
                            direcaoRobo2 = 'S';
                            break;
                        case 'S':
                            direcaoRobo2 = 'L';
                            break;
                    }
                }

                else if (mov2 == 'D')
                {
                    switch (direcaoRobo2)
                    {
                        case 'N':
                            direcaoRobo2 = 'L';
                            break;
                        case 'L':
                            direcaoRobo2 = 'S';
                            break;
                        case 'S':
                            direcaoRobo2 = 'O';
                            break;
                        case 'O':
                            direcaoRobo2 = 'N';
                            break;
                    }
                }

                else if (mov2 == 'M')
                {
                    switch (direcaoRobo2)
                    {
                        case 'N': if (contadorY2 < xInputInt) contadorY2++; break;
                        case 'L': if (contadorX2 < xInputInt) contadorX2++; break;
                        case 'S': if (contadorY2 > 0) contadorY2--; break;
                        case 'O': if (contadorX2 > 0) contadorX2--; break;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($">> {contadorX1} {contadorY1} {direcaoRobo1}");
            Console.WriteLine($">> {contadorX2} {contadorY2} {direcaoRobo2}");
            Console.ReadKey();
        }
    }
}