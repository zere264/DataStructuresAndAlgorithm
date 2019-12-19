using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var KeyString = "人工智能";
            Console.WriteLine(KeyString);
            TestReadingFile(KeyString);

            Console.ReadKey();
        }

        /// <summary>
        /// 不使用自定义的迭代子检索指定的文本文件中，包含指定字符串的个数的方法
        /// </summary>
        /// <param name="keyString"></param>
        public static void TestReadingFile(string keyString)
        {
            var memoryBefore = GC.GetTotalMemory(true);
            StreamReader sr= File.OpenText("F:\\tempFile.txt");//读取文本文件
            var fileContents = new List<string>(); // 将文本内容添加到一个 List<string> 变量
            while (!sr.EndOfStream)
            {
                fileContents.Add(sr.ReadLine());
            }

            // 检索目标文本（字符串）
            for(int i=0;i<7;i++)
            {
                Console.WriteLine(fileContents[i]);
            }
      

        

        }


    }

}
