using System;

namespace Graph_Definition
{
    class Graph
    {
        public int[,] g = new int[10, 10];
        public int n;
        public Graph(int x)
        {
            n = x;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    g[i, j] = 0;
                }
            }
        }

        // Function to update the adjacency (Add edge)

        public void addEdge(int x, int y)
        {
            if ((x < 0) || (x > n))
            {
                Console.WriteLine("This vertex does not exist!" + x);
            }

            else if ((y < 0) || (y > n))
            {
                Console.WriteLine("This vertex does not exist!" + y);
            }

            else if ((x == y))
            {
                Console.WriteLine("Entered the same vertices!");
            }

            else

            {
                g[y, x] = 1;
                g[x, y] = 1;
            }
        }

        public void removeEdge(int x, int y)
        {
            if ((x < 0) || (x > n))
            {
                Console.WriteLine("This vertex does not exist!" + x);
            }

            else if ((y < 0) || (y > n))
            {
                Console.WriteLine("This vertex does not exist!" + y);
            }

            else if ((x == y))
            {
                Console.WriteLine("Entered the same vertices!");
            }

            else

            {
                g[y, x] = 0;
                g[x, y] = 0;
            }
        }

        public void displayMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write(g[i, j] + " ");
                }
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Graph num = new Graph(6);

            num.addEdge(0, 1);
            num.addEdge(0, 2);
            num.addEdge(0, 3);
            num.addEdge(0, 4);
            num.addEdge(1, 2);
            num.addEdge(2, 3);
            num.addEdge(2, 4);
            num.addEdge(2, 5);
            num.addEdge(3, 5);

            Console.WriteLine("Adjacency matrix after insertion:\n ");
            num.displayMatrix();


            num.removeEdge(2, 3);
            num.removeEdge(3, 5);

            Console.WriteLine("\nAdjacency matrix after deletion: ");
            num.displayMatrix();

            Console.ReadKey();
        }


    }
}
