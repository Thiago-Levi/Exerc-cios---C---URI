

            Console.WriteLine("URI 1001");
            Console.WriteLine("Digite o valor de A e B");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;
            Console.WriteLine($"O resultado da soma é: {soma}");

            Console.WriteLine("URI 1002");

            Console.WriteLine("Digite o valor do raio da circunferência");

            const double PI = 3.14159;
            double raio = double.Parse(Console.ReadLine());

            double area = PI * Math.Pow(raio, 2);

            Console.WriteLine($"O valor da área da circunferência é --> {area.ToString("F4")} ");


            Console.WriteLine("URI 1005");

            Console.WriteLine("Digite o valor de A e B ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = ((a * 3.5) + (b * 7.5)) / 11;


            Console.WriteLine($"É média final é --> {media.ToString("F5", CultureInfo.InvariantCulture)}");


            Console.WriteLine("URI 1008");
            Console.WriteLine("Digite o número de um funcionário, número de horas trabalhadas e o valor que recebe por hora");

            int nFuncionario = int.Parse(Console.ReadLine());
            int nHoras = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = nHoras * valorHora;

            Console.WriteLine($"Number --> {nFuncionario}\nSalary --> U$ {salario.ToString("f2")}");


            Console.WriteLine("URI 1014");
            Console.WriteLine("Digite a distância total percorrida (em Km) e o total de combustível gasto (em litros).");

            int distanciaTotal = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalCombustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = distanciaTotal / totalCombustivel;

            Console.WriteLine($"O consumo médio é de  --> {consumo.ToString("F2")} km/l");

            Console.ReadLine();


            Console.WriteLine("URI 1011");
            Console.WriteLine("Digite o valor da raio da circunferência).");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double volume = (4.0 / 3.0) * 3.14159 * Math.Pow(raio, 3);

            Console.WriteLine($"O volume é  --> {volume.ToString("F3", CultureInfo.InvariantCulture)}");


            Console.WriteLine("URI 1012");
            Console.WriteLine("Digite o valor da A, B e C.");

            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaTriangulo = (A * C) / 2;
            double areaCirculo = 3.14159 * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = Math.Pow(B, 2);
            double areaRetangulo = A * B;

            Console.WriteLine($"a) --> {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"b) --> {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"c) --> {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"d) --> {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"e) --> {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");

            Console.WriteLine("URI 1013");
            Console.WriteLine("Digite o valor da A, B e C.");

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;
            int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine($"{maiorABC} eh maior");


            Console.ReadLine();

            Console.WriteLine("URI 1015");
            
            Console.WriteLine("Digite o valores para x1, y1");
            double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Digite o valores para x2, y2");
            double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            Console.WriteLine($"A distância é --> {distancia.ToString("F4", CultureInfo.InvariantCulture)}");


            int n = 0;
            int m = 0;
            
            Console.WriteLine("Informe M e N");
            
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[m, n];
            
            for (int i = 0; i < m; i++)
            {
              for (int j = 0; j < n; j++)
              {
                matrix[i, j] = int.Parse(Console.ReadLine());
              }
            }
            
            for (int i = 0; i < m; i++)
            {
              if (i == m - 1) Console.WriteLine();
              for (int j = 0; j < n; j++)
              {
                Console.Write($"{matrix[i, j]} ");
              }
            }
            Console.ReadLine();
            string permission = "Admin|Manager";
            int level = 55;
            string message;
            
            if (permission.Contains("Admin"))
            {
            
              if (level > 55)
              {
                Console.WriteLine("Welcome, Super Admin user.");
              }
              else
              {
                Console.WriteLine("Welcome, Admin user.");
              }
            
            
            }
            else if (permission.Contains("Manager"))
            {
              if (level >= 20)
              {
                Console.WriteLine("Contact an Admin for access.");
              }
              else
              {
                Console.WriteLine("You do not have sufficient privileges.");
              }
            }
            else
            {
              Console.WriteLine("You do not have sufficient privileges.");
            }
