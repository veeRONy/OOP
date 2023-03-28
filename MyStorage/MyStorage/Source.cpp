#include<iostream>
#include <chrono>
using namespace std;

class MyStorage
{
public:
	MyStorage()
	{
		size = 0;
		arr = nullptr;
	}
	MyStorage(int size)
	{
		this->size = size;
		arr = new MyStorage*[size];
	}
	void pushBack(MyStorage* obj)
	{
		MyStorage** newArr = new MyStorage*[size + 1];
		for (int i = 0; i < size; i++)
			newArr[i] = arr[i];
		
		newArr[size] = obj;
		size++;
		delete[] arr;
		arr = newArr;
	}
	void pushFront(MyStorage* obj)
	{
		MyStorage** newArr = new MyStorage*[size + 1];
		for (int i = 0; i < size; i++)
			newArr[i+1] = arr[i];
		
		newArr[0] = obj;
		size++;
		delete[] arr;
		arr = newArr;
	}
	void popBack()
	{
		size--;
		MyStorage** newArr = new MyStorage*[size];
		for (int i = 0; i < size; i++)
			newArr[i] = arr[i];
		
		delete[] arr;
		arr = newArr;
	}
	void popFront()
	{
		size--;
		MyStorage** newArr = new MyStorage*[size];
		for (int i = 0; i < size; i++)
			newArr[i] = arr[i + 1];
		
		delete[] arr;
		arr = newArr;
	}
	void insert(int index, MyStorage*obj)
	{
		if (index >= size){
			cout << "Array out of bounds!" << endl;
			return;
		}
		MyStorage** newArr = new MyStorage * [size+1];
		for (int i = 0; i < index; i++)
			newArr[i] = arr[i];
		
		newArr[index] = obj;
		size++;

		for (int i = index+1; i < size; i++)
			newArr[i] = arr[i-1];
		
		delete[] arr;
		arr = newArr;
	}
	void erase(int index)
	{
		if (index >= size){
			cout << "Array out of bounds!" << endl;
			return;
		}
		MyStorage** newArr = new MyStorage * [size-1];
		for (int i = 0; i < index; i++)
			newArr[i] = arr[i];
		
		for (int i = index+1; i < size; i++)
			newArr[i-1] = arr[i];
		
		size--;
		delete[] arr;
		arr = newArr;
	}
	MyStorage* getObject(int index)
	{
		if (index<size)
			return arr[index];
	}
	void setObject(int index, MyStorage* obj)
	{
		if (index<size)
		    arr[index] = obj;
	}
	int getSize()
	{
		return size;
	}
	virtual void printInfo() {}

private:
	int size;
	MyStorage** arr;
};

class SomeObject : public MyStorage
{
public:
	SomeObject()
	{
		x = 0;
	}
	SomeObject(int _x)
	{
		x = _x;
	}
	void printInfo()
	{
		cout << x << " ";
	}
private:
	int x;
};

class SomeObject2 :public MyStorage
{
public:
	SomeObject2()
	{
		str = "Привет!";
	}
	SomeObject2(string s)
	{
		str = s;
	}
	void printInfo()
	{
		cout << str << "  ";
	}
private:
	string str;
};

void print(MyStorage& st)
{
	for (int i = 0; i < st.getSize(); i++)
		(st.getObject(i))->printInfo();
	cout << endl;
}

int main()
{
	time_t start=0, end=0;

	setlocale(LC_ALL, "ru");
	srand(time(NULL));

	MyStorage storage(10);
	for (int i = 0; i < storage.getSize(); i++)
		storage.setObject(i, new SomeObject(rand()%10));
	cout << "Начальный массив:\t\t";
	print(storage);

	// присваивание значения по индексу
	cout << "Присваивание значения по индексу 2:\t";
	storage.setObject(2, new SomeObject2("Hello!"));
	print(storage);

	// получение объекта по индексу
	cout << "Получение объекта по индексу 6: ";
	(storage.getObject(6))->printInfo();
	cout << endl;

	// добавление в конец
	cout << "Добавление в конец:\t\t";
	storage.pushBack(new SomeObject(123));
	print(storage);

	// добавление в начало
	cout << "Добавление в начало:\t\t";
	storage.pushFront(new SomeObject2("world"));
	print(storage);

	// удаление из начала
	cout << "Удаление из начала:\t\t";
	storage.popFront();
	print(storage);

	// удаление с конца
	cout << "Удаление с конца:\t\t";
	storage.popBack();
	print(storage);

	// вставка по индексу
	cout << "Вставка значения по индексу 3:\t";
	storage.insert(3, new SomeObject2());
	print(storage);

	// удаление по индексу
	cout << "Удаление по индексу 5:\t\t";
	storage.erase(5);
	print(storage);

	double a[3]{};
	cout << endl << endl;
	
	int k = 100;
	for (int j = 0; j < 3; j++)
	{
		auto begin = std::chrono::steady_clock::now();
		for (int i = 0; i < k; i++)
		{
			int r = rand() % 7;
			switch (r)
			{
				case 0: 
					storage.pushBack(new SomeObject()); 
					break;
				case 1: 
					if (storage.getSize() != 0)
						storage.popBack(); 
					break;
				case 2: 
					if (storage.getSize() != 0)
						storage.popFront(); 
					break;
				case 3: 
					storage.pushFront(new SomeObject(rand()%10)); 
					break;
				case 4: 
					if (storage.getSize() != 1 && storage.getSize() != 0)
						storage.insert(rand()%(storage.getSize()), new SomeObject(rand() % 10));
					else
						storage.insert(0, new SomeObject()); 
					break;
				case 5:
					if (storage.getSize() != 1 && storage.getSize() != 0)
						storage.erase(rand() % (storage.getSize()));
					else
						storage.erase(0);
					break;
				case 6:
					if (storage.getSize() != 1 && storage.getSize() != 0)
						storage.getObject(rand() % (storage.getSize()))->printInfo();
					//else
						//storage.getObject(0)->printInfo();
					break;
				case 7: 
					if (storage.getSize() != 1 && storage.getSize() != 0)
						storage.setObject(rand() % (storage.getSize()), new SomeObject(rand() % 10));
					else
						storage.setObject(0, new SomeObject(rand() % 10));
					break;
			}
		}
		auto end = std::chrono::steady_clock::now();
		auto elapsed_ms = std::chrono::duration_cast<std::chrono::milliseconds>(end - begin);
		a[j] = elapsed_ms.count();
		cout << "\n\nПри " << k << " итерациях время = " << elapsed_ms.count() <<" миллисек." << "\n\n";
		k *= 10;
		cout << "Размер = " << storage.getSize() << endl << endl;
	}
	
	return 0;
}