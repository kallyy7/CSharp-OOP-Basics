﻿namespace Sneaking
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int rowsCount = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rowsCount][];

            int[] samCoordinates = InitializeMatrix(matrix);

            string command = Console.ReadLine();

            foreach (var move in command)
            {
                UpdateEnemies(matrix);
                CheckEnemies(matrix);
                MoveSam(move, matrix, samCoordinates);
                ChekNikoladze(matrix);
            }
        }

        private static void ChekNikoladze(char[][] matrix)
        {
            for (var line = 0; line < matrix.Length; line++)
            {
                if (matrix[line].Contains('N') && matrix[line].Contains('S'))
                {
                    matrix[line][Array.IndexOf(matrix[line], 'N')] = 'X';
                    Console.WriteLine($"Nikoladze killed!");
                    PrintMatrix(matrix);
                }
            }
        }

        private static void MoveSam(char move, char[][] matrix, int[] coordinates)
        {
            switch (move)
            {
                case 'U':
                    matrix[coordinates[0]][coordinates[1]] = '.';
                    matrix[--coordinates[0]][coordinates[1]] = 'S';
                    break;
                case 'D':
                    matrix[coordinates[0]][coordinates[1]] = '.';
                    matrix[++coordinates[0]][coordinates[1]] = 'S';
                    break;
                case 'L':
                    matrix[coordinates[0]][coordinates[1]] = '.';
                    matrix[coordinates[0]][--coordinates[1]] = 'S';
                    break;
                case 'R':
                    matrix[coordinates[0]][coordinates[1]] = '.';
                    matrix[coordinates[0]][++coordinates[1]] = 'S';
                    break;
                default:
                    break;
            }
        }

        private static void CheckEnemies(char[][] matrix)
        {
            for (var line = 0; line < matrix.Length; line++)
            {
                if (matrix[line].Contains('b') && matrix[line].Contains('S'))
                {
                    if (Array.IndexOf(matrix[line], 'b') < Array.IndexOf(matrix[line], 'S'))
                    {
                        matrix[line][Array.IndexOf(matrix[line], 'S')] = 'X';
                        Console.WriteLine($"Sam died at {line}, {Array.IndexOf(matrix[line], 'X')}");
                        PrintMatrix(matrix);
                    }
                }
                else if (matrix[line].Contains('d') && matrix[line].Contains('S'))
                {
                    if (Array.IndexOf(matrix[line], 'd') > Array.IndexOf(matrix[line], 'S'))
                    {
                        matrix[line][Array.IndexOf(matrix[line], 'S')] = 'X';
                        Console.WriteLine($"Sam died at {line}, {Array.IndexOf(matrix[line], 'X')}");
                        PrintMatrix(matrix);
                    }
                }
            }
        }

        private static void PrintMatrix(char[][] matrix)
        {
            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join("", line));
            }

            Environment.Exit(0);
        }

        private static void UpdateEnemies(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'b')
                    {
                        if (col == matrix[row].Length - 1)
                        {
                            matrix[row][col] = 'd';
                        }
                        else
                        {
                            matrix[row][col] = '.';
                            matrix[row][++col] = 'b';
                        }
                    }
                    else if (matrix[row][col] == 'd')
                    {
                        if (col == 0)
                        {
                            matrix[row][col] = 'b';
                        }
                        else
                        {
                            matrix[row][col] = '.';
                            matrix[row][col - 1] = 'd';
                        }
                    }
                }
            }
        }

        private static int[] InitializeMatrix(char[][] matrix)
        {
            int[] coordinates = null;
            for (int i = 0; i < matrix.Length; i++)
            {
                string line = Console.ReadLine();

                matrix[i] = line.ToCharArray();

                if (matrix[i].Contains('S'))
                {
                    coordinates = new int[] { i, Array.IndexOf(matrix[i], 'S') };
                }
            }

            return coordinates;
        }
    }
}