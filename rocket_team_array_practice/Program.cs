namespace rocket_team_array_practice;

class Program
{
    static void Main(string[] args)
    {
        // 利用一維陣列求10個數字的計算平均值。
        //double[] arrayForTen = new double[10];
        //for(int i = 0; i < arrayForTen.Length; i++)
        //{
        //    Console.WriteLine($"請輸入第{i+1}個數字");
        //    arrayForTen[i] = Convert.ToDouble(Console.ReadLine());
        //}
        //double sum = 0;
        //foreach(int i in arrayForTen)
        //{
        //    sum += i;
        //}
        //sum /= arrayForTen.Length;
        //Console.WriteLine($"10個數字的平均值為{sum}");
        //Console.ReadKey();

        // 利用一維陣列求10個數字的最大值。
        //double [] arrayForTen = new double[10];
        //for (int i = 0; i < arrayForTen.Length; i++)
        //{
        //    Console.WriteLine($"請輸入第{i + 1}個數字");
        //    arrayForTen[i] = Convert.ToDouble(Console.ReadLine());
        //}
        //double Max = double.MinValue;
        //foreach(double i in arrayForTen)
        //{
        //    if (i >= Max)
        //    {
        //        Max = i;
        //    }
        //}
        //Console.WriteLine($"10個數字的最大值為{Max}");
        //Console.ReadKey();


        // 搜尋問題：輸入10個數字至A[ ]，再輸入x，判斷x是否存在於A陣列中，
        // 如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在。
        //int[] arrayForTen = new int[10];
        //for(int i = 0; i < arrayForTen.Length; i++)
        //{
        //    Console.WriteLine($"請輸入第{i+1}個整數");
        //    arrayForTen[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine("請輸入整數x");
        //int x = Convert.ToInt32(Console.ReadLine());
        //for(int i = 0; i < arrayForTen.Length; i++)
        //{
        //    if (x == arrayForTen[i])
        //    {
        //        Console.WriteLine($"x存在於陣列的第{i+1}位");
        //        break;
        //    }
        //    if (i == arrayForTen.Length - 1)
        //    {
        //        Console.WriteLine("x不存在於陣列中");
        //    }
        //}
        //Console.ReadKey();


        // 兩個二維矩陣相加。
        // 以陣列模擬矩陣，求兩個2乘3的二維矩陣相加之結果，
        // 第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，最後將C矩陣內容顯示出來。
        //int[,] matrixA = new int[2, 3];
        //int[,] matrixB = new int[2, 3];
        //int[,] matrixC = new int[2, 3];
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.WriteLine($"請輸入matrixA的第{i + 1}列第{j + 1}行數字");
        //        matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.WriteLine($"請輸入matrixB的第{i + 1}列第{j + 1}行數字");
        //        matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
        //    }
        //}
        //Console.WriteLine("matrixC的結果為");
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        if (j == 2)
        //        {
        //            Console.WriteLine(matrixC[i, j]);
        //        }
        //        else
        //        {
        //            Console.Write($"{matrixC[i, j]}\t");
        //        }
        //    }
        //}
        //Console.ReadKey();


        // 兩個矩陣相乘。
        // 求2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來。
        //int[,] matrixA = new int[2, 3];
        //int[,] matrixB = new int[3, 1];
        //int[,] matrixC = new int[2, 1];
        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.WriteLine($"請輸入matrixA的第{i + 1}列第{j + 1}列數字");
        //        matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 1; j++)
        //    {
        //        Console.WriteLine($"請輸入matrixB的第{i + 1}列第{j + 1}列數字");
        //        matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        //for(int i = 0; i < 2; i++)
        //{
        //    for(int j = 0; j < 1; j++)
        //    {
        //        for(int k = 0; k < 3; k++)
        //        {
        //            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
        //        }
        //    }
        //}
        //foreach(int i in matrixC)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.ReadKey();


        // 5-1.寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，
        // 如A[i] > 5，則令A[i] = A[i] - 5，否則A[i] = A[i] + 5。
        //int[] arrayA = new int[10];
        //for(int i = 0; i < arrayA.Length; i++)
        //{
        //    Console.WriteLine($"請輸入arrayA的第{i+1}個數字");
        //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //for(int i = 0; i < arrayA.Length; i++)
        //{
        //    if (arrayA[i] > 5)
        //    {
        //        arrayA[i] -= 5;
        //    }
        //    else
        //    {
        //        arrayA[i] += 5;
        //    }
        //}
        //Console.Write("arrayA為");
        //foreach(int i in arrayA)
        //{
        //    Console.Write($"{i}\t");
        //}
        //Console.ReadKey();


        // 5-2.寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i]=A[i]+i。
        //int[] arrayA = new int[10];
        //for (int i = 0; i < arrayA.Length; i++)
        //{
        //    Console.WriteLine($"請輸入arrayA的第{i + 1}個數字");
        //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //for(int i = 0; i < arrayA.Length; i++)
        //{
        //    arrayA[i] += i;
        //}
        //Console.Write("arrayA為");
        //foreach (int i in arrayA)
        //{
        //    Console.Write($"{i}\t");
        //}
        //Console.ReadKey();


        //5-3.寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]≥0，令B[i]=1，否則令B[i]=0。
        //int[] arrayA = new int[10];
        //for (int i = 0; i < arrayA.Length; i++)
        //{
        //    Console.WriteLine($"請輸入arrayA的第{i + 1}個數字");
        //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //int[] arrayB = new int[10];
        //for (int i = 0; i < arrayB.Length; i++)
        //{
        //    if (arrayA[i] >= 0)
        //    {
        //        arrayB[i] = 1;
        //    }
        //    else
        //    {
        //        arrayB[i] = 0;
        //    }
        //}
        //Console.Write("arrayB為");
        //foreach (int i in arrayB)
        //{
        //    Console.Write($"{i}\t");
        //}
        //Console.ReadKey();


        // 5-4.寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和。
        //int[,] matrixA = new int[3, 5];
        //for(int i = 0; i < 3; i++)
        //{
        //    for(int j = 0; j < 5; j++)
        //    {
        //        Console.WriteLine($"請輸入matrixA的第{i+1}列第{j+1}行個數字");
        //        matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        //for(int i = 0; i < 3; i++)
        //{
        //    int tem = 0;
        //    for(int j = 0; j < 5; j++)
        //    {
        //        tem += matrixA[i, j];
        //    }
        //    Console.WriteLine($"第{i+1}列數字和為{tem}");
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    int tem = 0;
        //    for (int j = 0; j < 3; j++)
        //    {
        //        tem += matrixA[j, i];
        //    }
        //    Console.WriteLine($"第{i + 1}行數字和為{tem}");
        //}
        //Console.ReadKey();


        // 5-5.寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值。
        //int[,] matrixA = new int[3, 5];
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        Console.WriteLine($"請輸入matrixA的第{i + 1}列第{j + 1}行個數字");
        //        matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        //for(int i = 0; i < 3; i++)
        //{
        //    int min = int.MaxValue;
        //    for(int j = 0; j < 5; j++)
        //    {
        //        if (matrixA[i, j] < min)
        //        {
        //            min = matrixA[i, j];
        //        }
        //    }
        //    Console.WriteLine($"第{i+1}列的最小值為{min}");
        //}
        //for(int i = 0; i < 5; i++)
        //{
        //    int min = int.MaxValue;
        //    for(int j = 0; j < 3; j++)
        //    {
        //        if (matrixA[j, i] < min)
        //        {
        //            min = matrixA[j, i];
        //        }
        //    }
        //    Console.WriteLine($"第{i + 1}行的最小值為{min}");
        //}
        //Console.ReadKey();


        // 5-6.寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai+bi，i=1到i=5。
        //int[] arrayA = new int[5];
        //int[] arrayB = new int[5];
        //for(int i = 0; i < arrayA.Length; i++)
        //{
        //    Console.WriteLine($"請輸入a{i+1}");
        //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //for (int i = 0; i < arrayA.Length; i++)
        //{
        //    Console.WriteLine($"請輸入b{i + 1}");
        //    arrayB[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //for (int i= 0; i < arrayA.Length; i++)
        //{
        //    Console.WriteLine($"a{i+1}+b{i+1}={arrayA[i] + arrayB[i]}");
        //}
        //Console.ReadKey();


        // 5-7.寫一程式，輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。
        // 令x為a中的最大值，令y為b中的最大值，求x與y中較小者。
        //int[] arrayA = new int[5];
        //int[] arrayB = new int[5];
        //for (int i = 0; i < arrayA.Length; i++)
        //{
        //    Console.WriteLine($"請輸入a{i + 1}");
        //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //for (int i = 0; i < arrayA.Length; i++)
        //{
        //    Console.WriteLine($"請輸入b{i + 1}");
        //    arrayB[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //int x = int.MinValue;
        //foreach(int i in arrayA)
        //{
        //    if (i > x)
        //    {
        //        x = i;
        //    }
        //}
        //int y = int.MinValue;
        //foreach (int i in arrayB)
        //{
        //    if (i > y)
        //    {
        //        y = i;
        //    }
        //}
        //if (x == y)
        //{
        //    Console.WriteLine($"x={x}, y={y}, x,y相等");
        //}
        //else if (x > y)
        //{
        //    Console.WriteLine($"x={x}, y={y}, 較小者為y");
        //}
        //else
        //{
        //    Console.WriteLine($"x={x}, y={y}, 較小者為x");
        //}
        //Console.ReadKey();
    }
}

