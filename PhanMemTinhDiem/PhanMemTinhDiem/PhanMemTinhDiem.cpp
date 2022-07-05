#include <string>
#include <iostream>
#include <windows.h>
#include <limits>
#include <io.h>
#include <fstream>
using namespace std;
int main()
{
    int x = 0;
    string titlejoin = "Phan Mem Tinh Diem \n";
    string headtext1 = "Phien Ban: 1.0.0.8-C++ Edition";
    string appchose;
    string tmp;
    string appchosete;
    int n, i, a, b, c, d ,e ,f ,g ,h ,k ,j ,l ,m ,o ,p, q;
    float sochia[10], tong = 0, tb;
    int diemgk = 0;
    int diemck = 0;

    while (titlejoin[x] != '\0')
    {
        cout << titlejoin[x];
        Sleep(100);
        x++;
    };
    while (true)
    {
        system("cls");
        cout << "[1] TINH DIEM TRUNG BINH MON\n";
        cout << "[2] TINH DIEM HOC KY\n";
        cout << "[3] TINH DIEM CA NAM\n";
        cout << "Nhap Tuy Chon Cua Ban: \n";
        cin >> appchose;
        if (appchose == "1") {
            system("cls");
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

            tb = (tong + (diemgk * 2) + (diemck * 3)) / (n + 5);
            cout << "Trung Binh Mon: " << tb << endl;
            system("pause >nul");

        }
        else if (appchose == "2"){
            system("cls");
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon Toan: ";
            cin >> a;
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon Ngu Van: ";
            cin >> b;
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon Tieng Anh: ";
            cin >> c;
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon Sinh Hoc: ";
            cin >> d;
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon Hoa Hoc: ";
            cin >> e;
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon Vat Ly: ";
            cin >> f;
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon Cong Nghe: ";
            cin >> g;
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon GDCD: ";
            cin >> h;
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon Tin Hoc: ";
            cin >> k;
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon Dia Ly: ";
            cin >> j;
            cout << "Nhap So Diem Trung Binh Hoc Ky Mon Lich Su: ";
            cin >> l;
            m = (a + b + c + d + e + f + g + h + k + j + l) / 11;

            system("pause >nul");
        }
        else
        {
            cout << "Sai Cu Phap! ";
            system("pause >nul");
        }

    }
}


