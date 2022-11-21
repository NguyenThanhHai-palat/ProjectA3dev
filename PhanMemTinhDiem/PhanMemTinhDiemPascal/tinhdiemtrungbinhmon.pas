Program AVX;
Uses Crt, Dos;
var tddgtx, ddggk, ddgck, ddgtx : real;
	b,c,d,e,g,h,k,l,m,o,p,q,r,t,u,v,w,x,y,z,s : real;
	a:array[1..7] of real;
	exitapp : real;
	f : text;
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
	write('Nhap So Lan Kiem Tra Thuong Xuyen: ');textcolor(11);readln(n);textcolor(15);
	begin
		for i:=1 to n do
		begin
			write('Nhap diem thuong xuyen ',i,':');
			textcolor(11);
			readln(a[i]);
			textcolor(15);
		end;
		write('Diem Giua Ky: ');textcolor(11);readln(b);textcolor(15);
		write('Diem Cuoi Ky: ');textcolor(11);readln(c);textcolor(15);
		clrscr;
		begin
		cursoroff;
		writeln('Xin Cho Dang Tinh Toan.');
		for i:=1 to n do
		begin
			g:=g+a[i];
		end;
		delay(500);
		clrscr;
		writeln('Xin Cho Dang Tinh Toan..');
		delay(500);
		e:=(g+(b*2)+(c*3))/(n+3+2);
		clrscr;
		writeln('Xin Cho Dang Tinh Toan...');
		delay(500);
		clrscr;
		cursoron;
		end;
		clrscr;
		writeln('Diem Thuong Xuyen La:');for i:= 1 to n do writeln(a[i]:9:2);
		writeln('Diem Giua Ky La:',b:9:2);
		writeln('Diem Cuoi Ky La:',c:9:2);
		textcolor(9);write('DIEM TRUNG BINH MON LA:');textcolor(14);writeln(e:10:2);textcolor(15);
                if (e > 10) then
                        writeln('Co Phai So Qua Lon?, Kiem Tra Lai Cac So Diem');
		begin
		assign(f,'sav.og');
			rewrite (f);
			writeln(f,e:9:2);
			close(f);
		end;
		readln();
	end;
	clrscr;

	exit
End.
