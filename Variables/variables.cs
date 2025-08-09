// <data type> <name of variable>
//single per line
int number = 1;
var name = "rhex";
// multiple
int m1, m2, m3;

// declaration variable 

short shortA = 1;
int intA = 1;
long longA = 1;

intA = shortA;// stores shortA to intA to expand capacity and range
longA = intA; // stores intA to longA to expand capacity and range

bool trueVal = true;
bool falseVal = false;

char charA = "A";
string nullString;
string stringWithValue = "Hello world";

float floatA = 1.2F;// handles numeric value with decimal places
double doubleA = 1.2D;// used for measurement and weight and number with decimal places except for money

decimal decimalA = 1.2M; // used for when data is money or currency 

//----------------------

//Locale variables
//explicit - you tell it. It includes the  <data type> <name of variable>
int numberA = 1;
//implicit - C# guesses (but still type-safe). It only knows the data type when you put the value
var numberB = 1;