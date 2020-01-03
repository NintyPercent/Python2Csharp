using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2C
{
    public class Program
    {
         static void Main(string[] args)
        {
            //string debugPath = System.Environment.CurrentDirectory;           //此c#项目的debug文件夹路径
            string pyexePath = @"F:\Python2Csharp\dist\main.exe";
            //python文件所在路径，一般不使用绝对路径，此处仅作为例子，建议转移到debug文件夹下

            Process p = new Process();
            p.StartInfo.FileName = pyexePath;//需要执行的文件路径
            p.StartInfo.UseShellExecute = false; //必需
            p.StartInfo.RedirectStandardOutput = true;//输出参数设定
            p.StartInfo.RedirectStandardInput = true;//传入参数设定
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = "2 3";//参数以空格分隔，如果某个参数为空，可以传入””
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();//关键，等待外部程序退出后才能往下执行}
            //Console.Write(output);//输出
            p.Close();
            Debug.WriteLine(output);
        }
    }
}
