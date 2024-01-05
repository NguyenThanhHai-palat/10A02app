using System;
using System.Collections.Generic;
using System.Text;
using MVE;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace UpdateService
{
    internal class Program
    {

        static void Main(string[] args)

        {
            string version = "";
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("UPDATE APP 10A02");
            Console.WriteLine("ĐANG KIỂM TRA PHIÊN BẢN CẬP NHẬT");
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Encoding = UTF8Encoding.UTF8;
                    string content = client.DownloadString("https://10a02.palat001.cf/data/source/app/version.a");
                    string[] lines = content.Split('\n');
                    version = lines[0];
                }
            }
            catch
            {

            }
            Console.WriteLine("ĐÃ KIỂM TRA XONG");
            Console.WriteLine("ĐANG TẢI XUỐNG BẢN CẬP NHẬT MỚI NHẤT");
            try
            {
                PALATAPP pALATAPP  = new PALATAPP();
                pALATAPP.Download("https://10a02.palat001.cf/data/source/app/Packages/" + version+".pkg",version+".pkg");
            
            }
            catch(Exception ex) 
            {
                Console.WriteLine("ĐÃ XẢY RA LỖI\n"+ex.Message);
            }
            finally
            {
                Console.WriteLine("ĐÃ TẢI XONG - XIN ĐỪNG TẮT PHẦN MỀM CẬP NHẬT KHI ĐANG TIẾN HÀNH CẬP NHẬT");
                Console.WriteLine("ĐANG TIẾN HÀNH...");
                try
                {
                    System.IO.File.Delete("10A02app.exe");
                    System.IO.File.Move(version + ".pkg", "10A02app.exe");
                    Console.WriteLine("ĐÃ CẬP NHẬT XONG!");
                    Thread.Sleep(1000);
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine("CẬP NHẬT THẤT BẠI!" + version + ".pkg " +ex.Message);

                }
                

            }
        }
    }
}
