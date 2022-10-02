from logging import exception
import time
from turtle import clear
import os
os.system('cls')
os.system('title ')
title = "Phần Mềm Tính Điểm \n"
x = 0
c1 = "Học Sinh Giỏi"
c2 = "Học Sinh Khá"
c3 = "Không có danh hiệu học sinh giỏi và học sinh khá"
while title[x] != '\n':
    print(title[x],end='', flush=True)
    x+=1
    time.sleep(0.1)
print("\nPhiên Bản: 1.1 - Python Edition\n")
time.sleep(1)
os.system('cls')
while True:
    os.system('cls')
    titleapp = "Phan Mem Tinh Diem-1.1-Python Edition"
    os.system("title " + titleapp)
    print("[1] TÍNH ĐIỂM TRUNG BÌNH MÔN")
    print("[2] TÍNH ĐIỂM HỌC KỲ")
    print("[3] TÍNH ĐIỂM CẢ NĂM")
    print("[4] THOÁT")
    print("Nhập Tùy Chọn Của Bạn: \n")
    chose = input()
    if chose == "1":
        try:
            os.system('cls')
            diemkttx = []
            n = int(input("\nNhập Số Lần Kiểm Tra Thường Xuyên : "))
            tongdkttx = 0
            for i in range(0, n):
                    ti = i+1
                    print ("Nhập Số Điểm Tra Thường Xuyên ",ti, " : " )
                    ele = float(input())
                    diemkttx.append(ele) 
                    tongdkttx = tongdkttx + ele
            diemgk = float(input("Nhập Số Điểm Kiểm Tra Giữa Kỳ: "))
            diemck = float(input("Nhập Số Điểm Kiểm Tra Cuối Kỳ: "))
            tbm = (tongdkttx + diemgk*2 + diemck*3)/(n+5)
            print("Điểm Trung Bình Môn Là: ", round(tbm, 2))
            if (tbm >10) :
                print("Có Phải Số Quá Lớn ?, Kiểm Tra Lại Các Số Điểm")
            os.system('PAUSE >NUL')
        except:
            print("Đã Xảy Ra 1 Lỗi Nào Đó\n")
            os.system('PAUSE >NUL')
    elif chose == "2":
        try:
            os.system('cls')
            print("Nhập Số Điểm Các Môn Sau ")
            print("Nhập Số Điểm TBM Toán: ")
            a1 = float(input())
            print("Nhập Số Điểm TBM Ngữ Văn: ")
            a2 = float(input())
            print("Nhập Số Điểm TBM Anh Văn: ")
            a3 = float(input())
            print("Nhập Số Điểm TBM Vật Lý: ")
            a4 = float(input())
            print("Nhập Số Điểm TBM Sinh Học: ")
            a5 = float(input())
            print("Nhập Số Điểm TBM Địa Lý: ")
            a6 = float(input())
            print("Nhập Số Điểm TBM Lịch Sử: ")
            a7 = float(input())
            print("Nhập Số Điểm TBM Hóa Học: ")
            a8 = float(input())
            print("Nhập Số Điểm TBM Công Nghệ: ")
            a9 = float(input())
            print("Nhập Số Điểm TBM Tin Học: ")
            a10 = float(input())
            print("Nhập Số Điểm TBM GDCD: ")
            a11 = float(input())
            b1 = (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11) / 11
            print("Trung Bình Học Kỳ Là: " , round(b1, 2))
            try : 
                if ((a1 >= 8 or a2 >= 8 or a3 >= 8) and (a1 >= 6.5) and (a2 >= 6.5) and (a3 >= 6.5) and (a4 >= 6.5) and (a5 >= 6.5) and (a6 >= 6.5) and (a7 >= 6.5) and (a8 >= 6.5) and (a9 >= 6.5) and (a10 >= 6.5) and (a11 >= 6.5) and (b1 >= 8)): 
                    print("Bạn Được Danh Hiệu Học Sinh: " , c1)
                    os.system('PAUSE >NUL')
                elif ((a1 >= 6.5 or a2 >= 6.5 or a3 >= 6.5) and (a1 >= 5) and (a2 >= 5) and (a3 >= 5) and (a4 >= 5) and (a5 >= 5) and (a6 >= 5) and (a7 >= 5) and (a8 >= 5) and (a9 >= 5) and (a10 >= 5) and (a11 >= 5) and (b1 >= 6.5)): 
                    print("Bạn Được Danh Hiệu Học Sinh: " , c2)
                    os.system('PAUSE >NUL')
                            
                else:
                            
                    print("Trung Bình Học Kỳ Là: " , round(b1, 2))
                    print("Bạn Được Danh Hiệu Học Sinh: " , c3)
                    os.system('PAUSE >NUL')
            except :
                print(exception)
                        
            if (b1 >10) :
                print("Có Phải Số Quá Lớn ?, Kiểm Tra Lại Các Số Điểm")
                os.system('PAUSE >NUL')
            os.system('PAUSE >NUL')
        except:
            print("Đã Xảy Ra 1 Lỗi Nào Đó\n")
            os.system('PAUSE >NUL')
    elif chose == "3":
        try:
            os.system('cls')
            diemhk1 = float(input("Nhập Số Điểm Kiểm Tra Học Kỳ 1: "))
            diemhk2 = float(input("Nhập Số Điểm Kiểm Tra Học Kỳ 2: "))
            tbmhk = (diemhk1 + diemhk2*2)/3
            print("Điểm Trung Bình Cả Năm Là Là: ", round(tbmhk, 2))
            if (tbmhk >10) :
                print("Có Phải Số Quá Lớn ?, Kiểm Tra Lại Các Số Điểm")
            os.system('PAUSE >NUL')
        except:
            print("Đã Xảy Ra 1 Lỗi Nào Đó\n")
            os.system('PAUSE >NUL')
    elif chose == "4":
        os.system('cls')
        print("\n\n\n       (C)PALATDEV.NGTHHAI\n\n")
        exit()
    else:
        print("Mode:", chose, "\nSai Chế Độ ")
        os.system('PAUSE >NUL')

