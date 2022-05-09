using try_github;
var fest = int.Parse(Console.ReadLine());
var second = int.Parse(Console.ReadLine());

Add super = new Add();
Sub sub = new Sub();

var tasi =super.add(fest,second);
var hiki =sub.CalculationSub(fest,second);
Console.WriteLine(tasi);
Console.WriteLine(hiki);

