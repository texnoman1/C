/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
C[i,j] = a*C[i,j] + b*Sum(A[i,k]*B[k,j]);

for(i = 0; i < m; i++)   m num of string  = a.GetLength(1)
    for(j = 0; j < q; j++)  a.GetLength(0)
    {
        C[i][j] = 0;
        for(k = 0; k < n; k++)
            C[i][j] += A[i][k] * B[k][j];
    }
    */

int[,] a = new int[2,2];
a[0,0] = 2;
a[0,1] = 4;
a[1,0] = 3;
a[1,1] = 2;

int[,] b = new int[2,2];
b[0,0] = 3;
b[0,1] = 4;
b[1,0] = 3;
b[1,1] = 3;


//if (a.GetLength(1) == b.GetLength(0))
//MultAB( a, b);
int[,] multAB = MultAB( a, b);
//foreach (double i in multAB) { Console.Write("{0} ", i); }
//Console.Write(multAB);


int[,] MultAB (int[,] a, int[,] b )
{
 int[,] c = new int[a.GetLength(0), b.GetLength(1)];
 
    {
        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
            {
                c[i, j] = 0;
                

                for (int n = 0; n < a.GetLength(0) ; n++)
                {
                    c[i, j] += a[i, n] * b[n, j];
                    //c[i, j] += a[i, n] * b[n, j];
                    //Console.Write(c[i, j]);
                }
                
               Console.Write($"{c[i, j]}  ");
            }
            
            Console.WriteLine();
        }
    }
    return c;
}