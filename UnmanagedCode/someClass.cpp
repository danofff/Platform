#include "someClass.h"
#include <cmath>



someClass::someClass()
{
}

double someClass::calculateDustanceIn3D(double xOne, double yOne, double zOne, double xTwo, double yTwo, double zTwo) {

	return sqrt(pow(xTwo - xOne, 2) + pow(yTwo - yOne, 2) + pow(zTwo - zOne, 2));
}