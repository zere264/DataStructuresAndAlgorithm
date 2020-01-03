using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace query
{
    class Program
    {
        static void Main(string[] args)
        {
            TestReadingFile("人工智能");

            Console.ReadLine();
        }

        static void TestReadingFile(string key)
        {
            var memoryBefore = GC.GetTotalMemory(true);
            StreamReader sr;
            try
            {
                sr = File.OpenText("c:\\tempFile.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(@"这个例子需要一个名为 tempFile.txt 的文件。");
                return;
            }
            var result = new List<string>();
            string errorChar = "。！";
            Regex regex = new Regex(string.Format("{0}[^{1}]*", key, key.Substring(0, 1) + errorChar));
            Console.WriteLine("--------------------------");
            Console.WriteLine(string.Format("“{0}”已找到{1}个结果：", key, regex.Matches(sr.ReadToEnd()).Count));
            Console.WriteLine("--------------------------");
            string lineString = "";
            int lineIndex = 0;
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (!string.IsNullOrEmpty((lineString = sr.ReadLine())))
            {
                lineIndex++;
                int searchIndex = 0;
                foreach (var item in regex.Matches(lineString))
                {
                    var regexResult = item.ToString();
                    searchIndex = lineString.IndexOf(key, searchIndex) + 1;
                    result.Add(regexResult);
                    Console.WriteLine("第" + lineIndex + "行，第" + searchIndex + "个字母开始：" + regexResult);

                }
            }
        }
    }
}
