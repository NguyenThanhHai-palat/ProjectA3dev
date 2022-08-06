import javax.swing.*;
import java.awt.HeadlessException;
import java.util.Scanner;
import java.util.*;
import java.lang.*;
public class Phanmemtinhdiemjava {
  public static void main(String[] args) {
    int n; 
    double tong = 0;
    Scanner sc=new Scanner(System.in);  
    Scanner sc1=new Scanner(System.in);  
    Scanner sc2=new Scanner(System.in);  
    System.out.print("Nhap So Lan Kiem Tra Thuong Xuyen: ");  
    n=sc.nextInt();  
    double[] array = new double[10];  
    for(int i=0; i<n; i++)  
    {  
         System.out.println("Nhap Diem Thuong Xuyen " + i + " :");  
         array[i]=sc.nextDouble();  
         tong += array[i];
    }   
    System.out.print("Nhap Diem Giua Ky: ");  
    double gk=sc1.nextDouble();
    System.out.print("Nhap Diem Cuoi Ky: ");  
    double ck=sc2.nextDouble();
    double tbm = (tong + (gk*2) + (ck*3))/(n+5); 
    System.out.println("Diem Trung Binh Mon : "+ Math.round(tbm*100.0)/100.0);  
    JFrame fillscreen = new JFrame();
    fillscreen.setSize(200, 200);
    fillscreen.setLayout(null);
    fillscreen.setVisible(true);
    JLabel a = new JLabel("Điểm Trung Bình Môn: " + Math.round(tbm*100.0)/100.0);
    JLabel b = new JLabel("Điểm Giữa Kỳ: " + gk);
    JLabel c = new JLabel("Điểm Cuối Kỳ: " + ck);
    a.setBounds(1, -15, 1200, 200);
    b.setBounds(1, 1, 1200, 200);
    c.setBounds(1, 16, 1100, 200);
    fillscreen.add(a);
    fillscreen.add(b);
    fillscreen.add(c);
  }
}
