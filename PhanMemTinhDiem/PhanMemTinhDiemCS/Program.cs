using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace PhanMemTinhDiemCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string c1, c2, c3;
            string titlejoin = "Phần Mềm Tính Điểm\n";
            string headtext1 = "\nPhiên Bản: 1.1 - C# Edition - Unicode\n";
            float a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, b1,set01;
            float[] sochia = new float[10];
            set01 = 6.5f;
            float tong = 0;
            float diemhk1, diemhk2;
            float a;
            double tb1;
            c1 = "Học Sinh Giỏi";
            c2 = "Học Sinh Khá";
            c3 = "Không có danh hiệu học sinh giỏi và học sinh khá";
            float diemck, diemgk;
            int x = 0;
            while (titlejoin[x] != '\n')
            {
                Console.Write(titlejoin[x]);
                Thread.Sleep(100);
                x++;

            };
            Console.WriteLine(headtext1);
            Thread.Sleep(1000);
            while (true) {
                Console.Clear();
                Console.Title = "Phan Mem Tinh Diem-1.1-C# Edition - Unicode";
                Console.WriteLine("[1] TÍNH ĐIỂM TRUNG BÌNH MÔN");
                Console.WriteLine("[2] TÍNH ĐIỂM HỌC KỲ");
                Console.WriteLine("[3] TÍNH ĐIỂM CẢ NĂM");
                Console.WriteLine("[4] THOÁT");
                Console.WriteLine("Nhập Tùy Chọn Của Bạn: \n");
                string modech = Console.ReadLine();
                Console.WriteLine("Mode:" + modech); 
                if (modech == "1") 
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Nhập Số Lần Kiểm Tra Thường Xuyên: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Nhập Số Điểm Kiểm Tra Thường Xuyên " + (i + 1) + " : ");
                            sochia[i] = float.Parse(Console.ReadLine());
                            tong += sochia[i];

                        }
                        Console.Write("Nhập Số Điểm Kiểm Tra Giữa Kỳ: ");
                        diemgk = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm Kiểm Tra Cuối Kỳ: ");
                        diemck = float.Parse(Console.ReadLine());
                        Console.Clear();
                        tb1 = (tong + (diemgk * 2) + (diemck * 3)) / (n + 5);
                        Console.WriteLine("Điểm Trung Bình Môn Là: " + Math.Round(tb1, 2));
                        if (tb1 > 10)
                        {
                            Console.WriteLine("Có Phải Số Quá Lớn ?, Hãy Thử Dấu ',' Hay Vì '.'  Và Kiểm Tra Lại Các Số Điểm");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Đã Xảy Ra 1 Lỗi Nào Đó");
                        Console.ReadKey();
                    }
                }
                else if (modech == "2")
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Nhập Số Điểm Các Môn Sau ", ConsoleColor.Blue);
                        Console.Write("Nhập Số Điểm TBM Toán: ");
                        a1 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm TBM Ngữ Văn: ");
                        a2 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm TBM Anh Văn: ");
                        a3 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm TBM Vật Lý: ");
                        a4 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm TBM Sinh Học: ");
                        a5 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm TBM Địa Lý: ");
                        a6 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm TBM Lịch Sử: ");
                        a7 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm TBM Hóa Học: ");
                        a8 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm TBM Công Nghệ: ");
                        a9 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm TBM Tin Học: ");
                        a10 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Số Điểm TBM GDCD: ");
                        a11 = float.Parse(Console.ReadLine());
                        b1 = (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11) / 11;
                        if (b1 > 10)
                        {
                            Console.WriteLine("Có Phải Số Quá Lớn ?, Hãy Thử Dấu ',' Hay Vì '.'  Và Kiểm Tra Lại Các Số Điểm");
                        }
                        if (((a1 >= 8f) || (a2 >= 8f) || (a3 >= 8f)) && (a1 >= 6.5f) && (a2 >= 6.5f) && (a3 >= 6.5f) && (a4 >= 6.5f) && (a5 >= 6.5f) && (a6 >= 6.5f) && (a7 >= 6.5f) && (a8 >= 6.5f) && (a9 >= 6.5f) && (a10 >= 6.5f) && (a11 >= 6.5f) && (b1 >= 8f)) {
                            Console.WriteLine("Trung Bình Học Kỳ Là: " + Math.Round(b1, 2));
                            Console.WriteLine("Bạn Được Danh Hiệu Học Sinh: " + c1);
                            Console.ReadKey();
                        }
                        else if (((a1 >= 6.5f) || (a2 >= 6.5f) || (a3 >= 6.5f)) && (a1 >= 5f) && (a2 >= 5f) && (a3 >= 5f) && (a4 >= 5f) && (a5 >= 5f) && (a6 >= 5f) && (a7 >= 5f) && (a8 >= 5f) && (a9 >= 5f) && (a10 >= 5f) && (a11 >= 5f) && (b1 >= 6.5f)) {
                            Console.WriteLine("Trung Bình Học Kỳ Là: " + Math.Round(b1, 2));
                            Console.WriteLine("Bạn Được Danh Hiệu Học Sinh: " + c2);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Trung Bình Học Kỳ Là: " + Math.Round(b1, 2));
                            Console.WriteLine("Bạn Được Danh Hiệu Học Sinh: " + c3);
                            Console.ReadKey();
                        } 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Đã Xảy Ra 1 Lỗi Nào Đó");
                        Console.ReadKey();
                    }
                }
                    
                   
                else if (modech == "3")
                {
                    try {
                        Console.Clear();
                        Console.Write("Nhập Điểm Trung Bình Học Kỳ 1: ");
                        diemhk1 = float.Parse(Console.ReadLine());
                        Console.Write("Nhập Điểm Trung Bình Học Kỳ 2: ");
                        diemhk2 = float.Parse(Console.ReadLine());
                        a = (diemhk1 + (diemhk2 * 2)) / 3;
                        Console.WriteLine("Điểm Trung Bình Cả Năm: " + a);

                        if (a > 10)
                        {
                            Console.WriteLine("Có Phải Số Quá Lớn ?, Hãy Thử Dấu ',' Hay Vì '.'  Và Kiểm Tra Lại Các Số Điểm");
                        }
                        Console.ReadKey(); 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Đã Xảy Ra 1 Lỗi Nào Đó"); Console.ReadKey();
                    }
                }
                else if ((modech =="4") || (modech =="exit"))
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n       (C)PALATDEV.NGTHHAI\n\n");
                    return;
                }
                else if ((modech == "console"))
                {
                    Process.Start("console.exe");
                }
                else
                {
                    Console.WriteLine("Sai Chế Độ");
                    Console.ReadLine(); 
                }
            }
            
        }
    }
}