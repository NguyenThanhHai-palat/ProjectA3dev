#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <time.h>
#include <conio.h>
void delay(int number_of_seconds)
{
    int milli_seconds = 100 * number_of_seconds;
    clock_t start_time = clock();
    while (clock() < start_time + milli_seconds);
}
int main(int argc, char *argv[]) {
   int x,i; double y;
   float a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, b1, tong, hk1,hk2,cn;
   char mode;
   char c1[] = "Hoc Sinh Gioi";
   char c2[] = "Hoc Sinh Kha";
   char c3[] = "Khong co danh hieu hoc sinh gioi và hoc sinh kha";
   char titleani[]=    "Phan Mem Tinh Diem \n";
   char verani[]=    "Phien Ban: 1.1.0.3.(OPEN SOURCE) - C Edition - EXTENDED EDITION";
    printf("");
    system("title Phan Mem Tinh Diem - EXTENDED EDITION");
    for(x=0; titleani[x]!='\0'; x++)
   {
     printf("%c",titleani[x]);
      for(y=0; y<=8888888; y++)
      {
      }
      delay(1);
   }
   system("title Phien Ban: 1.1.0.3.(OPEN SOURCE) - C Edition - EXTENDED EDITION");
   printf("");
   for(x=0; verani[x]!='\0'; x++)
   {
     printf("%c",verani[x]);
      for(y=0; y<=8888888; y++)
      {
      }
   }
    int lpi = 0;
  	delay(10);
  	while ( lpi < 1){
  		system("cls");
  		system("title PHAN MEM TINH DIEM - MENU - EXTENDED, C EDITION");
  		printf("\t\t\t|\t[1] TINH DIEM TRUNG BINH MON\t|\n"); 
        printf("\t\t\t|\t[2] TINH DIEM HOC KY\t\t|\n");
        printf("\t\t\t|\t[3] TINH DIEM CA NAM\t\t|\n");
        printf("\t\t\t|\t[4] THOAT\t\t\t|\n");
        printf("Nhap Tuy Chon Cua Ban: \n");
        scanf("%c", &mode);
        
        
        switch (mode)
        {
	        case '4':
	        	system("cls");
	        	printf("\n\n\n		(C)PALATDEV\n");
	       		return 0;
				break;	
			
			
			case '1':
				system("cls");
				system("title Phan Mem Tinh Diem-TINH DIEM TRUNG BINH MON");
				int slkt, i;
				float dktx[10], dgk, dck;
				tong=0;
			    printf("Nhap So Lan Kiem Tra\n");
			    scanf("%d",&slkt);
			    for(i = 0; i < slkt; i++){
			    	int sttkt = i + 1;
			    	printf("\nNhap So Diem Kiem Tra Thuong Xuyen ");
			    	printf("%d",sttkt);
			    	printf(": ");
			    	scanf("%f",&dktx[i]);
			    	tong = tong + dktx[i]; 
				};	         
				printf("Nhap So Lan Kiem Tra Giua Ky: ");
			    scanf("%f",&dgk);
				printf("Nhap So Lan Kiem Tra Cuoi Ky: ");
			    scanf("%f",&dck);
			    float tbm; 
				tbm = (tong + (dgk * 2) + (dck * 3))/(slkt + 5);
				printf("\nTBM La:");
				printf("%.2g",tbm);
				if (tbm > 10){
					printf("Co Phai So Qua Lon ?, Kiem Tra Lai Cac So Diem \n");
				}
			    getch();
			    break;
			
			case '2':
				system("cls");
				system("title Phan Mem Tinh Diem-TINH DIEM TRUNG BINH HOC KY");
				printf("Nhap Diem Cac Mon Sau:\n");
                printf( "TBM Toan: ");
                scanf("%f",&a1);
                printf("TBM Ngu Van: ");
                scanf("%f",&a2);
                printf("TBM Tieng Anh: ");
                scanf("%f",&a3);
                printf("TBM Dia Ly: ");
                scanf("%f",&a4);
                printf("TBM Lich Su: ");
                scanf("%f",&a5);
                printf("TBM Vat Ly: ");
                scanf("%f",&a6);
                printf("TBM Hoa Hoc: ");
                scanf("%f",&a7);
                printf("TBM Cong Nghe: ");
                scanf("%f",&a8);
                printf("TBM Sinh Hoc: ");
                scanf("%f",&a9);
                printf("TBM Tin Hoc: ");
                scanf("%f",&a10);
                printf("TBM GDCD: ");
                scanf("%f",&a11);
                b1 = (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11) / 11;
                if (((a1 >= 8) || (a2 >= 8) || (a3 >= 8)) && (a1 >= 6.5) && (a2 >= 6.5) && (a3 >= 6.5) && (a4 >= 6.5) && (a5 >= 6.5) && (a6 >= 6.5) && (a7 >= 6.5) && (a8 >= 6.5) && (a9 >= 6.5) && (a10 >= 6.5) && (a11 >= 6.5) && (b1 >= 8)) {
                    printf("Trung Binh Hoc Ky La: "); 
					printf("%.2g",b1);
                    printf("\nBan Duoc Danh Hieu Hoc Sinh: ");
                    printf("%s",c1);
                }
                else if (((a1 >= 6.5) || (a2 >= 6.5) || (a3 >= 6.5))&& (a1 >= 5) && (a2 >= 5) && (a3 >= 5) && (a4 >= 5) && (a5 >= 5) && (a6 >= 5) && (a7 >= 5) && (a8 >= 5) && (a9 >= 5) && (a10 >= 5) && (a11 >= 5) && (b1 >= 6.5)) {
                    printf("Trung Binh Hoc Ky La: "); 
					printf("%.2g",b1);
                    printf("\nBan Duoc Danh Hieu Hoc Sinh: ");
                    printf("%s",c2);
                }
                else {
                    printf("Trung Binh Hoc Ky La: "); 
					printf("%.2g",b1);
                    printf("\nBan Duoc Danh Hieu Hoc Sinh: ");
                    printf("%s",c3);
                }
                if (b1 > 10){
					printf("Co Phai So Qua Lon ?, Kiem Tra Lai Cac So Diem \n");
				}
                getch();
				break;
			case '3':
				system("cls");
				system("title Phan Mem Tinh Diem-TINH DIEM TRUNG BINH CA NAM");
				printf("Nhap Diem Trung Binh Hoc Ky 1: ");
                scanf("%f",&hk1);
                printf("\nNhap Diem Trung Binh Hoc Ky 2: ");
                scanf("%f",&hk2);
                cn = (hk1 + (hk2 * 2)) / 3;
                printf("\nDiem Trung Binh Ca Nam: ");
                printf("%.2g",cn);
                if (cn > 10){
					printf("Co Phai So Qua Lon ?, Kiem Tra Lai Cac So Diem \n");
				}
				getch();
				break;
			default:
				printf("");
			
		}
	  }
	
}
