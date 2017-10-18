using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Directory类
{
    class Program
    {
        static void Main(string[] args)
        {
            #region --创建文件夹
            //File Path  FileStream  StreamReader StreamWriter
            //Directory 文件夹  目录
            //Directory.CreateDirectory(@"E:\a");//创建文件夹
            //Console.WriteLine("创建成功！");
            //Console.ReadKey();
            #endregion

            #region --删除文件夹
            //Directory.Delete(@"E:\a", true);//删除文件夹，无论文件夹内存不存在文件都删除
            //Console.WriteLine("删除成功！");
            //Console.ReadKey();
            #endregion

            #region --移动剪切文件夹
            //Directory.Move(@"E:\a",@"E:\b");//剪切文件。，移动文件；A为将要移动的文件，b为移动后a文件的根目录
            //Console.WriteLine("剪切成功");
            //Console.ReadKey();
            #endregion

            #region --获取文件夹下所有文件的全部路径
            //string[] path = Directory.GetFiles(@"E:\a","*.jpg");//获取a文件夹下所有" .jpg "的文件的全部路径
            //for (int i=0;i<path.Length;i++)
            //{
            //    Console.WriteLine(path[i]);
            //}
            //Console.ReadKey();
            #endregion

            #region --获取文件夹下所有文件夹的全部路径
            //string[] path =  Directory.GetDirectories(@"E:\");
            // for (int i = 0; i < path.Length; i++)
            // {
            //     Console.WriteLine(path[i]);
            // }
            // Console.ReadKey();
            #endregion

            #region --获取文件夹下所有文件夹的全部路径
           //bool isVisable =  Directory.Exists(@"E:\");
           // if(isVisable)
           // {
           //     for(int i =0;i<100;i++)
           //     {
           //         Directory.CreateDirectory(@"C:\a\b" + i);
           //     }
           // }
           // Console.WriteLine("OK");
           // Console.ReadKey();
            #endregion

        }
    }
}
