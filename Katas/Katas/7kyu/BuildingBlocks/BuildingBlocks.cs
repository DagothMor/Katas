using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Katas.Katas._7katas.BuildingBlocks
{
    public static class BuildingBlocks
    {
        public static void Start()
        {




        }

        public class Block
        {
            public int Width { get; set; }
            public int Length { get; set; }
            public int Height { get; set; }

            public int[] Array = new[] {3};

            public Block(int[] array)
            {
                Array = array;
                Width = Array[0];
                Length = Array[1];
                Height = Array[2];
            }

            public int GetLength()
            {
                return Length;
            }
            public int GetWidth()
            {
                return Width;
            }
            public int GetHeight()
            {
                return Height;
            }
            public int GetVolume()
            { 
                var Volume=Length*Height*Width;

                return Volume;
            }
            public int GetSurfaceArea()
            {
                var SurfaceArea = 2*(Length*Width+Width*Height+Length*Height);

                return SurfaceArea;
            }
        }
    }
}
