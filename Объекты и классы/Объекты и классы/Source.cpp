#include<iostream>
using namespace std;

class Point
{
protected:
	int x, y;

public:
	Point()
	{
		cout << "Вызвался конструктор по умолчанию - Point()" << endl;
		x = 0;
		y = 0;
	}
	Point(int _x, int _y)
	{
		cout << "Вызвался конструктор c параметрами - Point(int _x, int _y)" << endl;
		x = _x;
		y = _y;
	}
	Point(const Point& p)
	{
		cout << "Вызвался конструктор копирования - Point(const Point& p)" << endl;
		x = p.x;
		y = p.y;
	}
	~Point()
	{
		cout << "Вызвался деструктор ~Point()    " << "(" << x << "," << y << ")" << endl;
	}

	void Move(int dx, int dy)
	{
		x += dx;
		y += dy;
	}
	void Reset();

	void Set(int _x, int _y)
	{
		x = _x;
		y = _y;
	}
};

void Point::Reset()
{
	x = 0;
	y = 0;
}

class ColoredPoint: public Point
{
protected:
	int color;
public:
	ColoredPoint()
	{
		cout << "Вызвался конструктор по умолчанию - ColoredPoint()" << endl;
		x = 0;
		y = 0;
		color = 0;
	}
	ColoredPoint(int _x, int _y, int color) : Point(_x, _y)
	{
		cout << "Вызвался конструктор c параметрами - ColoredPoint(int _x, int _y, int color)" << endl;
		this->color = color;
	}
	ColoredPoint(const ColoredPoint& p)
	{
		cout << "Вызвался конструктор копирования - ColoredPoint(const ColoredPoint& p)" << endl;
		x = p.x;
		y = p.y;
		color = p.color;
	}
	~ColoredPoint()
	{
		cout << "Вызвался деструктор ~ColoredPoint()  " << "(" << x << "," << y << ") - " << color << endl;;
	}

	void ChangeColor(int color)
	{
		this->color = color;
	}
	
};


class Section
{
private:
	Point* p1;
	Point* p2;

public:
	Section()
	{
		cout << "Вызвался конструктор по умолчанию - Section()" << endl;
		p1 = new Point;
		p2 = new Point;
	}
	Section(int x1, int y1, int x2, int y2)
	{
		cout << "Вызвался конструктор c параметрами - Section(int x1, int y1, int x2, int y2)" << endl;
		p1 = new Point(x1, y1);
		p2 = new Point(x2, y2);
	}
	Section(const Section& s)
	{
		cout << "Вызвался конструктор копирования - Section(const Section& p)" << endl;
		p1 = new Point(*(s.p1));
		p2 = new Point(*(s.p2));
	}
	~Section()
	{
		cout << "Вызвался деструктор ~Section()" << endl;
		delete p1;
		delete p2;
	}
};

class Circle
{
protected:
	Point p;
	int r;
public:
	Circle()
	{
		cout << "Вызвался конструктор по умолчанию - Circle()" << endl;
		p.Set(0, 0);
		r = 0;
	}
	Circle(int x, int y, int r)
	{
		cout << "Вызвался конструктор c параметрами - Circle(int x, int y, int r)" << endl;
		p.Set(x, y);
		this->r = r;
	}
	Circle(const Circle& c)
	{
		cout << "Вызвался конструктор копирования - Circle(const Circle& c)" << endl;
		p = c.p;
		r = c.r;
	}
	~Circle()
	{
		cout << "Вызвался деструктор ~Circle()" << endl;
	}

	void GetRadius()
	{
		cout << "Радиус окружности = " << r;
	}
};

int main()
{
	setlocale(LC_ALL, "ru");
	// Статическое создание объектов
	cout << "Статическое создание объектов:" << endl;
	Point p1;
	Point p2(16, 23);
	Point p3(p2);
	
	cout << endl;

	// динамическое создание объектов
	cout << "Динамическое создание объектов:" << endl;
	Point* p4 = new Point;
	Point* p5 = new Point(45,34);
	Point* p6 = new Point(p3);
	Point* p7 = new Point(*p5);

	cout << endl;

	// использование методов
	p1.Move(12, 46);
	p2.Reset();
	p7->Move(34, 56);

	// Статическое создание объектов дочернего класса
	cout << "Статическое создание объектов дочернего класса:" << endl;
	ColoredPoint cp1;
	ColoredPoint cp2(1,6,8);
	ColoredPoint cp3(cp2);

	cout << endl;

	// динамическое создание объектов дочернего класса
	cout << "Динамическое создание объектов дочернего класса:" << endl;
	ColoredPoint* cp4 = new ColoredPoint;
	ColoredPoint* cp5 = new ColoredPoint(1,3,67);
	ColoredPoint* cp6 = new ColoredPoint(cp2);

	cp1.ChangeColor(56);
	cp5->ChangeColor(12);

	cout << endl;

	cout << "Композиция (когда хранится указатель на объект другого класса):" << endl;
	// статическое создание объектов класса с композицией
	cout << "Статическое создание объектов класса с композицией:" << endl;
	Section s1;
	Section s2(1, 2, 5, 6);
	Section s3(s2);

	cout << endl;
	// динамическое создание объектов класса с композицией
	cout << "Динамическое создание объектов класса с композицией:" << endl;
	Section* s4 = new Section;
	Section* s5 = new Section(4, 5, 7, 8);
	Section* s6 = new Section(s2);

	cout << endl;

	cout << "Композиция (когда хранится объект другого класса):" << endl;
	// статическое создание объектов класса с композицией
	cout << "Статическое создание объектов класса с композицией:" << endl;
	Circle c1;
	Circle c2(6, 7, 56);
	Circle c3(c2);

	cout << endl;

	// динамическое создание объектов класса с композицией
	cout << "Динамическое создание объектов класса с композицией:" << endl;
	Circle* c4 = new Circle;
	Circle* c5 = new Circle(1, 2, 7);
	Circle* c6 = new Circle(*c5);

	cout << endl;
	// удаление объектов базового класса
	cout << "Удаление объектов базового класса: " << endl;
	delete p4;
	delete p5;
	delete p6;
	delete p7;
	cout << endl;
	
	// удаление объектов дочернего класса
	cout << "Удаление объектов дочернего класса: " << endl;
	delete cp4;
	delete cp5;
	delete cp6;

	cout << endl;
	// удаление объектов класса с композицией
	cout << "Удаление объектов класса с композицией (с указателем на объект): " << endl;
	delete s4;
	delete s5; 
	delete s6;


	cout << endl;
	// удаление объектов класса с композицией
	cout << "Удаление объектов класса с композицией  (с объектом): " << endl;
	delete c4;
	delete c5;
	delete c6;
	cout << endl;


	
	return 0;
}