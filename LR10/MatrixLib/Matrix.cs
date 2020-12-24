using System;
using System.IO;

namespace MatrixLib
{
    public class Matrix
    {
        private float[,] MX;
        int m, n;

        public void GenerateMatrix(int M, int N)
        {
            m = M; n = N;

            Random r = new Random(DateTime.Now.Millisecond);

            MX = new float[M, N];

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    MX[i, j] = (float)r.Next(1000);
        }

        public void SaveMatrix(string pFileName)
        {
            if (MX.Length > 0)
            {
                if (File.Exists(pFileName))
                    File.Delete(pFileName);
                FileInfo f = new FileInfo(pFileName);
                TextWriter tw = f.CreateText();

                tw.WriteLine(m.ToString());
                tw.WriteLine(n.ToString());

                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        tw.WriteLine(i.ToString() + " " + j.ToString() + " " + MX[i, j].ToString("E10"));
                tw.Close();
            }
        }

        public Boolean LoadMatrix(string pFileName)
        {
            if (File.Exists(pFileName))
            {
                try
                {
                    TextReader tr = File.OpenText(pFileName);
                    m = Convert.ToInt32(tr.ReadLine());
                    n = Convert.ToInt32(tr.ReadLine());

                    MX = new float[m, n];
                    string line;
                    string[] substring;

                    for (int i = 0; i < m; i++)
                        for (int j = 0; j < n; j++)
                        {
                            line = tr.ReadLine();
                            substring = line.Split(new char[] { ' ' }, 3);
                            MX[i, j] = Convert.ToSingle(substring[2]);
                        }
                    tr.Close();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public void PrintMatrix()
        {
            if (MX.Length > 0)
            {
                Console.WriteLine("\n");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(MX[i, j].ToString("E3") + " ");
                    }
                    Console.WriteLine();
                }

            }
        }

        public float GetSumOfEven
        {
            get
            {
                float SumOfEven = 0;
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if ((i + j) % 2 == 0)
                            SumOfEven += MX[i, j];
                    }
                return SumOfEven;
            }
        }
    }
}