#include <iostream>
#include <conio.h>
using namespace std;

class Point {
protected:
	int x;
	int y;
public:
	Point() {
		printf("Point()\n");
		x = 0;
		y = 0;
	}
	Point(int x, int y) {
		printf("Point(int x, int y)\n");
		this->x = x;
		this->y = y;
	}
	Point(const Point &p) {
		printf("Point(const Point &p)\n");
		x = p.x;
		y = p.y;
	}
	~Point() {
		printf("%d, %d\n", x, y);
		printf("~Point()\n");
	}
	void move(int dx, int dy) {
		x = x + dx;
		y = y + dx;
		printf("Point coord: (%d, %d)\n", x, y);
	}
	void reset();		
};

void Point::reset() {
	x = 0;
	y = 0;
}

class ColoredPoint : public Point {
protected:
	int color;
public:
	ColoredPoint() : Point() {
		printf("ColoredPoint()\n");		
		color = 0;
	}
	ColoredPoint(int x, int y, int color) : Point(x, y) {
		printf("ColoredPoint(int x, int y)\n");		
		this->color = color;
	}
	ColoredPoint(const ColoredPoint &c) {
		printf("ColoredPoint(ColoredPoint &c)\n");
		x = c.x;
		y = c.y;
		color = c.color;
	}
	~ColoredPoint() {
		printf("%d, %d color = %d\n", x, y, color);
		printf("~ColoredPoint()\n");
	}
};

class Section {
protected:
	Point* p1;
	Point* p2;
public:
	Section() {
		printf("Section()\n");
		p1 = new Point;
		p2 = new Point;
	}
	Section(int x1, int y1, int x2, int y2) {
		printf("Section(int x1, int y1, int x2, int y2)\n");
		p1 = new Point(x1, y1);
		p2 = new Point(x2, y2);
	}
	Section(const Section &s) {
		printf("Section(Section &s)\n");
		p1 = new Point(*(s.p1));
		p2 = new Point(*(s.p2));
	}
	~Section() {
		delete p1;
		delete p2;
		printf("~Section()\n");
	}
};

class Triangle {
protected:
	Point p1;
	Point p2;
	Point p3;	
public:
	Triangle() {
		printf("Triangle()\n");
	}
	Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : p1(x1, y1), p2(x2, y2), p3(x3, y3) {
		printf("Triangle(int x1, int y1, int x2, int y2, int x3, int y3)\n");
	}
	Triangle(const Triangle &t) : p1(t.p1), p2(t.p2), p3(t.p3) {
		printf("Triangle(Triangle &t)\n");
	}
	~Triangle() {
		printf("~Triangle()\n");
	}
};

int main() {
	Point *p = new ColoredPoint();
	delete p;

	cout << endl << "_________ColoredPoint_________" << endl;
	ColoredPoint *cp = new ColoredPoint(1, 2, 25);
	cp->move(10, 10);	
	cp->reset();
	delete cp;

	cout << endl << "_________Section_________" << endl;
	Section *s1 = new Section(1, 2, 3, 4);
	Section *s2 = new Section(*s1);
	delete s1;
	delete s2;

	cout  << "_________Triangle_________" << endl;
	{		
		Triangle tr1(1, 2, 3, 4, 5, 6);
		Triangle tr2(tr1);
	}
	_getch();	
}