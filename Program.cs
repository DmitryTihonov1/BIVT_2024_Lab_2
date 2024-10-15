using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        program.Task_3_11(1.5, 3, 4);
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double summ = 0;
        for (int i = 0; i <= 5; i++)
            summ += array[i];
        for (int i = 0; i <= 5; i++)
            array[i] = Math.Round(array[i] / summ, 2);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double summ = 0;
        double chet = 0;
        for (int i = 0; i <= 7; i++)
        {
            if (array[i] > 0)
            { 
            summ += array[i];
            chet++;
            }
        }
        summ = summ / chet;
        for (int i = 0; i <= 7; i++)
        {
            if (array[i] > 0)
                array[i] = Math.Round(summ, 2);
        }



            // end

            return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i <= 3; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
            // end

            return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double summ = 0;
        for (int i = 0; i <= 4; i++)
            summ += array[i];
        summ /= 5;
        for (int i = 0; i <= 4; i++)
            array[i] = Math.Round(array[i] - summ, 2);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i <= 3; i++)
        {
            product += vector1[i] * vector2[i];
        }
        product = Math.Round(product, 2);
        // end

            return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i <= 4; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        // end

            return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double summ = 0;
        for (int i = 0; i <= 6; i++)
            summ += array[i];
        summ /= 7;
        for (int i = 0; i <= 6; i++)
            if (array[i] > summ)
                array[i] = 0;
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i <= 5; i++)
        {
            if (array[i] < 0)
                count++;
        }

        // end

            return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double summ = 0;
        for (int i = 0; i <= 7; i++)
            summ += array[i];
        summ /= 8;
        for (int i = 0; i <= 7; i++)
        {
            if (array[i] > summ)
                count++;
        }

        // end

            return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            if ((array[i] > P) & (array[i] < Q))
                count++;
        }
        

        // end

            return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = new double[10];

        // code here
        int shet = 0;
        for (int i = 0; i <= 9; i++)
        {
            if (array[i] > 0)
            {
                output[shet] = array[i];
                shet++;
            }
        }

        // end

            return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 0; i <= 7; i++)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
            }


        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        for (int i = 0; i<= 4; i++)
        {
            even[i] = array[2 * i];
            odd[i] = array[2 * i+1];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int i = 0;
        int q = 0;
        while ((i <= 9) & (array[i] >= 0))
        {
            sum += array[i] * array[i];
            i++;
            q = 1;
        }
        if ((array[10] > 0) & (q == 1))
            sum += array[10] * array[10];

        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i <= 9; i++)
        {
            y[i] = Math.Round(Math.Log(x[i], Math.E) / 2, 2);
            if (y[i] == double.NegativeInfinity)
                y[i] = double.NaN;
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = double.MaxValue;
        int nom = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                nom = i;
            }
        }
        array[nom] *= 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        



        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double min = double.MaxValue;
        int nom = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                nom = i;
            }
        }
        for (int i = 0; i < nom; i++)
        {
            if (array[i] > 0)
                array[i] *= 2;
            else
                array[i] /= 2;
        }
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        double [] copy = new double[array.Length];
        copy = array;
        double min = double.MaxValue;
        double max = double.MinValue;
        int nom1 = 0;
        int nom2 = 0;
        int nom3 = 0;
        for (int i = 0; i < copy.Length; i++)
        {
            if (copy[i] < min)
            {
                min = copy[i];
                nom1 = i;
            }
            if (copy[i] > max)
            {
                max = copy[i];
                nom2 = i;
            }
        }
        if (nom1 > nom2)
        {
            nom1 = nom2 + nom1;
            nom2 = nom1 - nom2;
            nom1 = nom1 - nom2;
        }
        for (int i = nom1 + 1; i < nom2; i++)
        {
            if (copy[i] < 0)
            {
                array[nom3] = copy[i];
                nom3++;
            }
        }    
        // end

        return array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here
        double max = double.MinValue;
        int nom = 0;
        int nom1 = 0;
        int prov = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                nom = i;
            }
        }
        if (nom != array.Length - 1)
        {
            nom1 = nom + 1;
            prov = 1;
        }
        if (prov == 1)
        {
            if (array[nom1] > 0)
                array[nom1] *= 2;
            else
                array[nom1] /= 2;
        }

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double Task_2_9(double[] array)
    {
        double average = 0;

        // code here
        double[] copy = new double[array.Length];
        copy = array;
        double min = double.MaxValue;
        double max = double.MinValue;
        int nom1 = 0;
        int nom2 = 0;
        int nom3 = 0;
        for (int i = 0; i < copy.Length; i++)
        {
            if (copy[i] < min)
            {
                min = copy[i];
                nom1 = i;
            }
            if (copy[i] > max)
            {
                max = copy[i];
                nom2 = i;
            }
        }
        if (nom1 > nom2)
        {
            nom1 = nom2 + nom1;
            nom2 = nom1 - nom2;
            nom1 = nom1 - nom2;
        }
        for(int i = nom1 + 1;i < nom2; i++)
        {
            average += array[i];
        }
        if ((nom2 - nom1) != 1)
        average /= (nom2 - nom1 - 1);
        average = Math.Round(average, 2);
        // end

        return average;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here
        double [] array1 = new double[array.Length];
        int nom = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                nom = i;
        }
        array1 = array;
        if (nom != -1)
        {
            array1[nom + 1] = P;
            return array1;
        }
        else
            return array;

        // end
        
            
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        // code here
        int nom = 0;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i]  > max)
            {
                nom = i;
                max = array[i];
            }
        }
        array[nom] = nom;
        // end

        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        double[] output = new double [A.Length + B.Length];

        // code here
        if (k < A.Length)
        {
            for (int i = 0; i < k; i++)
            {
                output[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[k + i] = B[i];
            }
            for (int i = 0; i < A.Length - k; i++)
            {
                output[k + B.Length + i] = A[i + k];
            }
        }
        else
        {
            output = A;
        }
        // end

        return output;
    }
    public int[] Task_2_16(double[] array)
    {
        int[] output = null;

        // code here

        // end

        return output;
    }
    public double Task_2_17(double[] array)
    {
        double average = 0;

        // code here
        int nom1 = 0;
        int nom2 = 0;
        int nom3 = 0;
        double max = double.MinValue;
        double min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                nom1 = i;   
            }
            if (array[i] < min)
            {
                min = array[i];
                nom2 = i;
            }
        }
        if (nom1 < nom2)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    average += array[i];
                    nom3++;
                }
            }
            if (nom3 == 0)
                average = 0;
            else 
                average /= nom3;
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    average += array[i];
                    nom3++;
                }
            }
            if (nom3 == 0)
                average = 0;
            else
                average /= nom3;
        }
        average = Math.Round(average, 2);
        // end

        return average;
    }
    public double[] Task_2_18(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        // code here
        int nom = 0;
        double summ = 0;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                nom = i;
            }
            else
                summ += array[i];
        }
        if (array[nom] > 0)
            array[nom] *= 2;
        else
            array[nom] = 0;
        // end

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here

        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        double max = double.MinValue;
        double plus = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += plus;
                plus++;
            }
        }
            // end

            return array;
    }
    public double[] Task_3_3(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_4(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_5(double[] array)
    {
        // code here
        
        double min = double.MaxValue;
        int num = -1;
        double[] output = new double[array.Length];
        for (int i = 0; i < array.Length / 2; i += 1)
        {
            for (int j = 0; j < array.Length; j += 2)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    num = j;
                }
            }
            output[2 * i] = min;
            output[2 * i + 1] = array[2 * i + 1];
            array[num] = double.MaxValue;
            min = double.MaxValue;
            num = -1;

        }
        if (array.Length % 2 != 0)
        {
            output[array.Length - 1] = array[array.Length - 1];
        }

        array = output;

        // end

        return array;
    }
    public int Task_3_6(double[] array)
    {
        int count = 0;

        // code here

        // end

        return count;
    }
    public double[] Task_3_7(double[] array)
    {
        // code here
        
        // end

        return array;
    }
    public double[] Task_3_8(double[] array)
    {
        // code here
        double[] copy = new double[array.Length];
        double[] output = new double[array.Length];
        double min = double.MinValue;
        int nom = -1;
        for (int i = 0; i < array.Length; i++)
            copy[i] = array[i];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
                output[i] = array[i];
            else
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if ((copy[j] > min) & (copy[j] < 0))
                    {
                        min = copy[j];
                        nom = j;
                    }
                }
                output[i] = array[nom];
                
                copy[nom] = 3;

            }

            nom = -1;
            min = double.MinValue;

        }
        array = output;
        // end

        return array;
    }
    public int Task_3_9(double[] array)
    {
        int count = 0;

        // code here

        // end

        return count;
    }
    public double[] Task_3_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = new double[n];
        double[] Y = new double[n];
        double globalMax = 0, globalMin = 0;

        // code here
        double per = 0;
        int nom1 = -1;
        int nom2 = -1;
        double max = double.MinValue;
        double min = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            X[i] = Math.Round(a + i * (b - a) / (n - 1), 2);
            per = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            Y[i] = Math.Round(per, 2);
            
        }
        for (int i = 0; i < X.Length; i++)
        {
            if (Y[i] > max)
            { 
                max = Y[i];
            }
        }
        for (int i = 0; i < X.Length; i++)
        {
            if (Y[i] < min)
            {
                min = Y[i];
            }
        }



        globalMax = max;
        globalMin = min;
        for (int i = 0; i < X.Length; i += 1)
            Console.WriteLine(X[i]);
        for (int i = 0; i < Y.Length; i += 1)
            Console.WriteLine(Y[i]);
        Console.WriteLine(globalMax);
        Console.WriteLine(globalMin);


        // end

        return (X, Y, globalMax,globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_13(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = new double[array.Length];

        // code here
        double min = double.MaxValue;
        double max = double.MinValue;
        
        double k = 0;
        double shag = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                
            }
            if (array[i] > max)
            {
                max = array[i];
                
            }
        }
        k = min + (max - min) / 2;
        shag = 1 / (max - k);
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round((array[i] - k) * shag, 2); 
        }    

        // end

        return normalizedArray;
    }
    #endregion
}