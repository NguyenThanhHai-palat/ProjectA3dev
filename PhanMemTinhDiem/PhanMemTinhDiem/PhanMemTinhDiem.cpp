#include <string>
#include <iostream>
#include <math.h>
#include <windows.h>
#include <limits>
#include <io.h>
#include <fstream>
#include <fcntl.h>
using namespace std;
int main()
{
    system("title Phần Mem Tinh Diem");
    system("title Phan Mem Tinh Diem-bootapps");
    int x = 0;
    string titlejoin = "Phan Mem Tinh Diem \n";
    string headtext1 = "Phien Ban: 1.1 - C++ Edition";
    string appchose, c1, c2, c3, c4, c5;
    string tmp;
    string appchosete, hoten, ngaythangnamsinh, truong, lop, hovaten;
    float a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, b1;
    float sochia[10], tong = 0;
    float diemhk1;
    float n;
    int i;
    float a;
    double tb1;
    float diemhk2;
    float diemck, diemgk;
    c1 = "Hoc Sinh Gioi";
    c2 = "Hoc Sinh Kha";
    c3 = "Khong co danh hieu hoc sinh gioi và hoc sinh kha";
    while (titlejoin[x] != '\0')
    {
        cout << titlejoin[x];
        Sleep(100);
        x++;

    };
    cout << headtext1;
    Sleep(1000);
    system("cls");
    while (true)
    {
        system("title Phan Mem Tinh Diem-MENU");
        system("cls");
        cout << "[1] TINH DIEM TRUNG BINH MON\n";
        cout << "[2] TINH DIEM HOC KY\n";
        cout << "[3] TINH DIEM CA NAM\n";
        cout << "[4] THOAT\n";
        cout << "Nhap Tuy Chon Cua Ban: \n";
        cin >> appchose;
        if ((appchose == "1") or (appchose == "tinh diem trung binh mon") or (appchose == "tdtbm")) {
            try {
                system("cls");
                system("title Phan Mem Tinh Diem-TINH DIEM TRUNG BINH MON");
                cout << "Nhap So Lan Kiem Tra Thuong Xuyen: ";
                cin >> n;

                for (i = 0; i < n; ++i)
                {
                    cout << "Nhap So Diem Kiem Tra Thuong Xuyen " << i + 1 << ": ";
                    cin >> sochia[i];
                    tong += sochia[i];
                }
                cout << "Nhap So Diem Kiem tra giua ky: ";
                cin >> diemgk;
                cout << "Nhap So Diem Kiem tra cuoi ky: ";
                cin >> diemck;

                tb1 = (tong + (diemgk * 2) + (diemck * 3)) / (n + 5);
                cout << "Trung Binh Mon La: " << round(tb1 * 100) / 100 << "\n" << endl;
                if (tb1 > 10) {
                    cout << "Co Phai So Qua Lon ?, Kiem Tra Lai Cac So Diem \n";
                }
            }
            catch (string errorcode){
                cout << "Da Xay Ra 1 Loi Nao Do: \n "<< errorcode;
            };
            
            system("pause >nul");

        }
        else if ((appchose == "2") or (appchose == "tinh diem trung binh hoc ky") or (appchose == "tdtbhk")) {
            try {
                system("cls");
                system("title Phan Mem Tinh Diem-TINH DIEM TRUNG BINH HOC KY");
                cout << "Nhap Diem Cac Mon Sau:\n";
                cout << "TBM Toan: ";
                cin >> a1;
                cout << "TBM Ngu Van: ";
                cin >> a2;
                cout << "TBM Tieng Anh: ";
                cin >> a3;
                cout << "TBM Dia Ly: ";
                cin >> a4;
                cout << "TBM Lich Su: ";
                cin >> a5;
                cout << "TBM Vat Ly: ";
                cin >> a6;
                cout << "TBM Hoa Hoc: ";
                cin >> a7;
                cout << "TBM Cong Nghe: ";
                cin >> a8;
                cout << "TBM Sinh Hoc: ";
                cin >> a9;
                cout << "TBM Tin Hoc: ";
                cin >> a10;
                cout << "TBM GDCD: ";
                cin >> a11;
                b1 = (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11) / 11;
                if (((a1 >= 8) or (a2 >= 8) or (a3 >= 8)) and (a1 >= 6.5) and (a2 >= 6.5) and (a3 >= 6.5) and (a4 >= 6.5) and (a5 >= 6.5) and (a6 >= 6.5) and (a7 >= 6.5) and (a8 >= 6.5) and (a9 >= 6.5) and (a10 >= 6.5) and (a11 >= 6.5) and (b1 >= 8)) {
                    cout << "Trung Binh Hoc Ky La: " << round(b1 * 100) / 100 << "\n";
                    cout << "Ban Duoc Danh Hieu Hoc Sinh: " << c1;
                }
                else if (((a1 >= 6.5) or (a2 >= 6.5) or (a3 >= 6.5)) and (a1 >= 5) and (a2 >= 5) and (a3 >= 5) and (a4 >= 5) and (a5 >= 5) and (a6 >= 5) and (a7 >= 5) and (a8 >= 5) and (a9 >= 5) and (a10 >= 5) and (a11 >= 5) and (b1 >= 6.5)) {
                    cout << "Trung Binh Hoc Ky La: " << round(b1 * 100) / 100 << "\n";
                    cout << "Ban Duoc Danh Hieu Hoc Sinh: " << c2;
                }
                else {
                    cout << "Trung Binh Hoc Ky La: " << round(b1 * 100) / 100 << "\n";
                    cout << "Ban Duoc Danh Hieu Hoc Sinh: " << c3;
                }
                if (b1 > 10) {
                    cout << "\nCo Phai So Qua Lon ?, Kiem Tra Lai Cac So Diem \n";
                }
            }
            catch (string errorcode) {
                cout << "Da Xay Ra 1 Loi Nao Do: \n " << errorcode;
            };
            system("pause >nul");

        }
        else if ((appchose == "3") or (appchose == "tinh diem trung binh ca nam") or (appchose == "tdtbcn")) {
            try {


                system("cls");
                system("title Phan Mem Tinh Diem-TINH DIEM TRUNG BINH CA NAM");
                cout << "Nhap Diem Trung Binh Hoc Ky 1: " << endl;
                cin >> diemhk1;
                cout << "Nhap Diem Trung Binh Hoc Ky 2: " << endl;
                cin >> diemhk2;
                a = (diemhk1 + (diemhk2 * 2)) / 3;
                std::cout << "Diem Trung Binh Ca Nam: " << round(a * 100) / 100 << endl;
                if (a > 10) {
                    cout << "\nCo Phai So Qua Lon ?, Kiem Tra Lai Cac So Diem \n";
                }
                system("pause >nul");
            }
            catch (string errorcode) {
                cout << "Da Xay Ra 1 Loi Nao Do: \n " << errorcode;
            };
        }
        else if ((appchose == "4")) {
            system("cls");
            return 0;

        }
        else if ((appchose == "console")) {
            system("Start ""PalatAppConsoleMin/console.exe");

        }
        else
        {
            cout << "Sai Cu Phap! ";
            system("pause >nul");
        }

    }
}


