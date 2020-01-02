using System;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int width = 60;
            int height = 60;
            int padding = 10;

            int[][] pixelarray = Draw(width, height, padding);
            for(int i =0; i< height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    char placeHolder = ' ';
                    if (pixelarray[i][j] == 0) placeHolder = ' ';
                    else if (pixelarray[i][j] == 1) placeHolder = '-';
                    else placeHolder = '|';
                    Console.Write(placeHolder);
                }
                Console.WriteLine();
            }

            Console.ReadKey();


        }

        static int[][] Draw(int width, int height, int padding)
        {

            int[][] pixelArray = new int[height][];

            if (width < 20 || !(width % 2 == 0))
                return pixelArray;
            if (height < 20 || !(height % 2 == 0))
                return pixelArray;
            if (padding < 4 || !(padding % 2 == 0))
                return pixelArray;

            int actualPadding = (padding / 2) + 1;

            for (int i = 0; i < height; i++)
            {
                int row = i;
                if (row >= height / 2) row = height - row - 1;
                pixelArray[i] = new int[width];
                for (int j = 0; j < width; j++)
                {
                    int col = j;
                    if (col >= width / 2) col = width - col - 1;
                    if (row % actualPadding == 0 && row <= col) pixelArray[i][j] = 1;
                    else if (col % actualPadding == 0 && col <= row) pixelArray[i][j] = 2;
                    else pixelArray[i][j] = 0;

                }

            }

            return pixelArray;
        }


    }
}
