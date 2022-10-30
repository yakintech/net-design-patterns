

using StrategyPattern.Models;

var context = new Context(new BusStrategy());
var context2 = new Context(new WalkStrategy());


context.ContextInterface();
context2.ContextInterface();

int x = 3;