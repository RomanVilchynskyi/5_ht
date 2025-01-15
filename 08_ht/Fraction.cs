using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ht
{
    struct Vector3d
    {
        private int[,,] arr;
        private int xSize, ySize, zSize;

        public Vector3d(int xSize, int ySize, int zSize)
        {
            this.xSize = xSize;
            this.ySize = ySize;
            this.zSize = zSize;
            arr = new int[xSize, ySize, zSize];
        }

        public void FillArray(Func<int, int, int, int> tmp)
        {
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    for (int z = 0; z < zSize; z++)
                    {
                        arr[x, y, z] = tmp(x, y, z);
                    }
                }
            }
        }

        public Vector3d MultByNum(int num)
        {
            Vector3d res = new Vector3d(xSize, ySize, zSize);
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    for (int z = 0; z < zSize; z++)
                    {
                        res.arr[x, y, z] = arr[x, y, z] * num;
                    }
                }
            }
            return res;
        }

        public Vector3d Add(Vector3d other)
        {
            if (xSize != other.xSize || ySize != other.ySize || zSize != other.zSize)
            {
                throw new ArgumentException("Arrays must be equal");
            }

            Vector3d res = new Vector3d(xSize, ySize, zSize);
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    for (int z = 0; z < zSize; z++)
                    {
                        res.arr[x, y, z] = arr[x, y, z] + other.arr[x, y, z];
                    }
                }
            }
            return res;
        }

        public Vector3d Sub(Vector3d other)
        {
            if (xSize != other.xSize || ySize != other.ySize || zSize != other.zSize)
            {
                throw new ArgumentException("Arrays must be equal");
            }

            Vector3d result = new Vector3d(xSize, ySize, zSize);
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    for (int z = 0; z < zSize; z++)
                    {
                        result.arr[x, y, z] = arr[x, y, z] - other.arr[x, y, z];
                    }
                }
            }
            return result;
        }

        public void Print()
        {
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    for (int z = 0; z < zSize; z++)
                    {
                        Console.Write(arr[x, y, z] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
