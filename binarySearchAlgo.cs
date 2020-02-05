using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace binarySearchAlgo
{
    public class Program
    {
        public void Main(string[] args)
        {
            
            int[] dataarray = { 2, 3, 7, 9, 10, 14, 19, 21, 22, 25, 28, 30, 32, 36, 39, 42, 45, 48, 50 };

            for (int i = 0; i < dataarray.Length; i++)
            {
                Console.WriteLine(i + ">" + dataarray[i] + " : ");
            }

            int downpoint = 0;
            int uppoint = dataarray.Length - 1;
            //int finddata = 39;
            //Boolean datavalidity = false;
            //string status = "";
            //int midpoint;


            while (downpoint <= uppoint)
            {
                int midpoint = downpoint + (uppoint - downpoint) / 2;

                if (dataarray[midpoint] == 39)
                {
                    Console.WriteLine(midpoint);
                    //datavalidity = true;
                }
                if (dataarray[midpoint] < 39)
                {
                    downpoint = midpoint + 1;
                }
                else
                {
                    uppoint = midpoint - 1;
                }
            }
            //Console.WriteLine(status);
            //Console.WriteLine("The Data been found @ : " + midPoint);
            //if (dataArray[midpoint] == findData)
            //{
            //    Console.WriteLine("The Data been found @ : " + midPoint);
            //}
            //else if (dataArray[midpoint] < findData)
            //{
            //    downPoint = midPoint + 1;
            //}
            //else
            //{
            //    upPoint = midPoint - 1;
            //}
            //Console.WriteLine(dataArray[midPoint]);
        }
    }
}
