#include <iostream>
#include <string>

using namespace std;

//BaseDesc
class Base {
protected:
	string name;
public:
	// конструктор по умолчанию
	Base() {
		name = "";
		printf("#%d Base() name=\"%s\" \n", int(this) % 1000, name.c_str());
	}
	// конструктор с параметром
	Base(string str) {
		name = str;
		printf("%d Base(string str) name=\"%s\"\n", int(this) % 1000, name.c_str());
	}
	// конструктор копирования
	Base(const Base& obj) {
		this->name = obj.name;
		printf("%d Base(const Base& obj) name=\"%s\" from object #%d\n", int(this) % 1000, name.c_str(), (int)&obj % 1000);
	};
	// конструктор с параметром-указателем для копирования 
	Base(Base* obj) {
		this->name = obj->name;
		printf("%d Base(Base* obj) name=\"%s\" from object #%d\n", int(this) % 1000, name.c_str(), (int)obj % 1000);
	};
	void PrintName() {
		printf("I'm a Base!\n");
	}
	virtual ~Base() {
		printf("#%d ~Base() name=\"%s\"\n", (int)this % 1000, name.c_str());
	}
};

//С помощью конструктора копирования создается локальная копия внутри функции и после выхода из функции она удаляется.
void in1(Base obj) {
	printf("Inside func1\n");
};
void in2(Base* obj) {
	printf("Inside func2\n");

};
void in3(Base& obj) {
	printf("Inside func3\n");
};

//Создает локальный объект внутри и он копируется;
Base out1() {
	Base o("out1()");
	return o;
}
//Утечка памяти. Созданный внутри функции динамический объект не удаляется.
Base out2() {
	Base* o = new Base("out2()");
	return *o;
}
//Обращение к чужой памяти. Перед выходом из функции локальный объект удаляется и в main возвращается удаленный объект
Base* out3() {
	Base o("out3()");
	return &o;
}
//Созданный внутри дин-ий объект и его адрес из функции возвращаются в main и помещаются в перменную
Base* out4() {
	Base* o = new Base("out4()");
	return o;
}
//Тест unique_ptr
unique_ptr<Base> out44() {
	return make_unique<Base>("out44");
}
//Локальный объект удаляет перед выходом из функции
Base& out5() {
	Base o("out5()");
	return o;
}
//Проблема с удалением объекта, ссылки не удаляют объекты, на которые указывают
Base& out6() {
	Base* o = new Base("out6()");
	return *o;
}

int main() {
	//TEST in1,2,3
	/*Base o("o");
	Base* po = new Base("po");
	cout << "\nBefore in1(o)\n";
	in1(o);
	cout << "After in1(o)\n";
	cout << "\nBefore in2(&o)\n";
	in2(&o);
	cout << "After in2(&o)\n";
	cout << "\nBefore in3(o)\n";
	in3(o);
	cout << "After in3(o)\n";
	cout << "\nBefore in1(*po)\n";
	in1(*po);
	cout << "After in1(*po)\n";
	cout << "\nBefore in2(po)\n";
	in2(po);
	cout << "After in2(po)\n";
	cout << "\nBefore in3(*po)\n";
	in3(*po);
	cout << "After in3(*po)\n";
	delete po;	*/

	/*printf("Before out1 first way\n");
	Base o1 = out1();
	printf("After out1 first way\n");*/

	/*Base o1_2;
	printf("Before out1 second way\n");
	o1_2 = out1();
	printf("After out1 second way\n");*/

	//First way of out2 => утечка памяти. Динамический объект созданный внутри out2 не удаляется после выхода из функции.
	/*printf("Before out2 first way\n");
	Base o2 = out2();
	printf("After out2 first way\n");*/

	//Также утечка памяти
	/*Base o2_2;
	printf("Before out2 second way\n");
	o2_2 = out2();
	printf("After out2 second way\n");*/

	//Объект удаляется внутри функции, и в main возвращается уже удаленный объект
	/*printf("Before out3\n");
	Base* o3 = out3();
	printf("After out3\n");
	cout << "Work with deleted object:\n"<< "Print number of object - " << (int)o3%1000 << "\nTrying to use method - ";
	o3->PrintName();*/

	//Мы теперь отвественны за удаление указателя
	printf("Before out4\n");
	Base* o4 = out4();
	printf("After out4\n");

	//unique_ptr<Base>o44 = out44();

	//Объект также как в out3 удаляется внутри фукнции, и в main присваивается пустое значение
	/*printf("Before out5\n");
	Base& o5 = out5();
	printf("After out5\n");
	cout << "Work with deleted object:\n" << "Print number of object - " << (int)&o5 % 1000 << "\nTrying to use method - ";
	o5.PrintName();*/

	//Ответственность за удаление указателя
	/*printf("Before out6\n");
	Base& o6 = out6();
	printf("After out6\n");*/	
}