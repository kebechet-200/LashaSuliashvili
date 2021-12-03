using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check for int");
            IMathOperation<int> ckeckInt = new IntMathOperation();
            Console.WriteLine(ckeckInt.Add(5,8));
            Console.WriteLine(ckeckInt.Substract(5,8));
            Console.WriteLine(ckeckInt.Multiply(5,8));
            Console.WriteLine("---------------");

            Console.WriteLine();
            Console.WriteLine("Check for Vector");

            Vector v1 = new Vector(5, 6, 7);
            Vector v2 = new Vector(4, 5, 6);
            IMathOperation<Vector> checkVectors = new VectorMathOperation();
            var vAdd = checkVectors.Add(v1, v2);
            var vsubstract = checkVectors.Substract(v1, v2);
            var vMultiply = checkVectors.Multiply(v1, v2);
            Console.WriteLine($"added vector : {vAdd.X} , {vAdd.Y} , {vAdd.Z}");
            Console.WriteLine($"substracted vector : {vsubstract.X} , {vsubstract.Y} , {vsubstract.Z}");
            Console.WriteLine($"Multiplied vector : {vMultiply.X} , {vMultiply.Y} , {vMultiply.Z}");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            Console.WriteLine("Check for matrix");

            Matrix m1 = new Matrix(2, 3, 4, 5);
            Matrix m2 = new Matrix(1, 2, 3, 4);

            IMathOperation<Matrix> checkMatrix = new MatrixMathOperation();
            Console.WriteLine($"Added matrix : {checkMatrix.Add(m1, m2)}");
            Console.WriteLine($"Substracted matrix : {checkMatrix.Substract(m1, m2)}");
            Console.WriteLine($"Multiplied matrix : {checkMatrix.Multiply(m1,m2)}");
            


        }
    }
}
