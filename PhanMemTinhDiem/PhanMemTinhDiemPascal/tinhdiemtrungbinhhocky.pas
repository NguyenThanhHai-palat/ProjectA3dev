Program AVX;
Uses Crt, Dos;
var tddgtx, ddggk, ddgck, ddgtx : real;
	a,b,c,d,e,g,h,k,l,m,o,p,q,r,t,u,v,w,x,y,z : real;
	exitapp : real;
	f : text;
	s : string;
	i,n:integer;
Begin
	textbackground(15);
	cursoroff;
	//APP
	clrscr;
	textbackground(0);
	clrscr;
	textcolor(15);
	clrscr;
	textcolor(12);
	cursoron;
	clrscr;
	writeln('Luu Y : Tat Unikey truoc khi su dung. So Lan Kiem Tra Chi Duoc Nhap 1 lan !');
	textcolor(15);
	write('Nhap Diem Trung Binh Mon Toan: ');textcolor(11);readln(a);textcolor(15);
	write('Nhap Diem Trung Binh Mon Ngu Van: ');textcolor(11);readln(b);textcolor(15);
	write('Nhap Diem Trung Binh Mon Tieng Anh: ');textcolor(11);readln(c);textcolor(15);
	write('Nhap Diem Trung Binh Mon Sinh Hoc: ');textcolor(11);readln(d);textcolor(15);
	write('Nhap Diem Trung Binh Mon Dia Ly: ');textcolor(11);readln(e);textcolor(15);
	write('Nhap Diem Trung Binh Mon Lich Su: ');textcolor(11);readln(g);textcolor(15);
	write('Nhap Diem Trung Binh Mon GDCD: ');textcolor(11);readln(h);textcolor(15);
	write('Nhap Diem Trung Binh Mon Tin Hoc: ');textcolor(11);readln(k);textcolor(15);
	write('Nhap Diem Trung Binh Mon Vat Ly: ');textcolor(11);readln(m);textcolor(15);
	write('Nhap Diem Trung Binh Mon Hoa Hoc: ');textcolor(11);readln(l);textcolor(15);
	write('Nhap Diem Trung Binh Mon Cong Nghe: ');textcolor(11);readln(o);textcolor(15);
	begin
		begin
			clrscr;
			delay(10);
		end;
		begin
			clrscr;
			cursoroff;
			writeln('Xin Cho Dang Tinh Toan.');
		end;
		delay(500);
		clrscr;
		writeln('Xin Cho Dang Tinh Toan..');
		delay(500);
		z:=(a+b+c+d+e+g+h+k+m+l+o)/11;
		clrscr;
		writeln('Xin Cho Dang Tinh Toan...');
		delay(500);
		clrscr;
		cursoron;
		q := (a+b+c);
		p := (d+e+g+h+k+m+l+o)/9;
		end;
		clrscr;
		if ((q >= 22) and (z >=8) and ((a >= 8) or (b >= 8) or (c >=8)) and (p >= 6.5) and (d >= 6.5) and (e >= 6.5) and (g >= 6.5) and (h >= 6.5) and (k >= 6.5) and (m >= 6.5) and (l >= 6.5) and (o >= 6.5) and (a >= 6.5) and (b >= 6.5) and (c >=6.5)) then
			s:= 'hoc sinh gioi'
		else if ((z >=6.5) and ((a >= 6.5) or (b >= 6.5) or (c >=6.5)) and (p >= 5) and (d >= 5) and (e >= 5) and (g >= 5) and (h >= 5) and (k >= 5) and (m >= 5) and (l >= 5) and (o >= 5) and (a >= 5) and (b >= 5) and (c >=5)) then
			s:= 'hoc sinh kha'
		else
			s:= 'khong co danh hieu hoc sinh kha va hoc sinh gioi';
		textcolor(9);write('Diem Trung Binh Hoc Ky La:');textcolor(14);writeln(z:10:2);textcolor(15);
		textcolor(9);write('Ban Duoc: ');textcolor(14);writeln(s);
		if (z > 10) then
			writeln('Co Phai So Qua Lon ?, Kiem Tra Lai Cac So diem');
		begin
			assign(f,'sav.og');
				rewrite (f);
				writeln(f,e:9:2);
				close(f);
		end;
		readln();
	clrscr;

	exit
End.
