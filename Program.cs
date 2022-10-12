using GenericsProgram;


MaximumInteger integer = new MaximumInteger();
int value1 = integer.MaximumThreeInteger(65, 55, 96);
Console.WriteLine("The Maximum Number Is: " + value1);

MaximumFloats maximumFloat = new MaximumFloats();
float value2 = maximumFloat.MaximumFloat1Integer(25.12f, 53.12f, 11.5f);
Console.WriteLine("The Maximum Float Number Is: " + value2);

MaximumStrings strings = new MaximumStrings();
string value3 = strings.MaximumStringInteger("Apple", "Peach", "Banana");
Console.WriteLine("The Maximum String Value is: " + value3);

MaximumParameter parameter= new MaximumParameter();
int value4 = parameter.MaximumInteger(23, 33, 43, 53);
Console.WriteLine("The Maximum Integer Is: " + value4);


GenericsMaximumParameter genericsMaximum = new GenericsMaximumParameter();
int maximumParameter = genericsMaximum.GenericsMaximumParameterIs(89, 45, 23, 65);
Console.WriteLine("The Maximum Integer Is: " + maximumParameter);


GenericsMaximumThree genericsMaximumThreeInt = new GenericsMaximumThree();
int Value = genericsMaximumThreeInt.GenericsMaximumThreeIs(98, 45, 23);
Console.WriteLine("The Maximum Integer Is: " + Value);


GenericsMaximumVariable <int>genericsMaximumVariable = new GenericsMaximumVariable<int>(42, 52, 12);
int variable = genericsMaximumVariable.GenericsMaximumInteger(42, 52, 12);
Console.WriteLine("Maximum Integer Is: " + variable);
   




