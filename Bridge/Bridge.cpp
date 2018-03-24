#include <C:\Users\Вершковд\Documents\visual studio 2015\Projects\Platform\UnmanagedCode\someClass.h>
#include <C:\Users\Вершковд\Documents\visual studio 2015\Projects\Platform\UnmanagedCode\someClass.cpp>

extern "C" __declspec(dllexport)
double calculateDustanceIn3D(double xOne, double yOne, double zOne, double xTwo, double yTwo, double zTwo) {
	someClass * ll3d = new someClass();
	double result = ll3d->calculateDustanceIn3D(xOne, yOne, zOne, xTwo, yTwo, zTwo);
	return result;
}

extern "C" __declspec(dllexport)
int* GetPointerToInt() {
	int* d;
	int value = 10;
	d = &value;
	return d;
}

extern "C" __declspec(dllexport)
double* GetPointerToDouble() {
	double* d;
	double value = 110.001;
	d = &value;
	return d;
}
