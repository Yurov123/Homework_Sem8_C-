// Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива

Console.Clear();

         
            int[][] jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[3];
            jagged[2] = new int[5];
 
            // Заполняем массив случайными числами
            Random random = new Random();
            for (int i = 0; i < jagged[0].Length; i++)
                jagged[0][i] = random.Next(-10, 10);
            for (int i = 0; i < jagged[1].Length; i++)
                jagged[1][i] = random.Next(-10, 10);
            for (int i = 0; i < jagged[2].Length; i++)
                jagged[2][i] = random.Next(-10, 10);
 
            // Исходное содержимое массива
            Console.WriteLine("Initial contents of the array");
            for (int i = 0; i < jagged[0].Length; i++)
                Console.Write(jagged[0][i] + " ");
            Console.WriteLine();
            for (int i = 0; i < jagged[1].Length; i++)
                Console.Write(jagged[1][i] + " ");
            Console.WriteLine();
            for (int i = 0; i < jagged[2].Length; i++)
                Console.Write(jagged[2][i] + " ");
            Console.WriteLine();
 
            // Сортировка массива
            for (int i = 0; i < jagged[0].Length; i++)
                Array.Sort(jagged[0]);
            for (int i = 0; i < jagged[1].Length; i++)
                Array.Sort(jagged[1]);
            for (int i = 0; i < jagged[2].Length; i++)
                Array.Sort(jagged[2]);
 
            // Отсортированное содержимое массива
            Console.WriteLine("\nSorted array contents");
            for (int i = 0; i < jagged[0].Length; i++)
                Console.Write(jagged[0][i] + " ");
            Console.WriteLine();
            for (int i = 0; i < jagged[1].Length; i++)
                Console.Write(jagged[1][i] + " ");
            Console.WriteLine();
            for (int i = 0; i < jagged[2].Length; i++)
                Console.Write(jagged[2][i] + " ");
 
            
        
    










