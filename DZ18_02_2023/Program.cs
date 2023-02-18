// See https://aka.ms/new-console-template for more information
using DZ18_02_2023.Model;
using DZ18_02_2023.Model.Entity;

Console.WriteLine("Hello, World!");
// Необходимо реализовать метод разворота связного списка (двухсвязного или односвязного на выбор).

NodeList nodeList = new NodeList();
nodeList.addNodeFirst(9);
nodeList.addNodeFirst(8);
nodeList.addNodeFirst(7);
nodeList.addNodeFirst(6);
nodeList.addNodeFirst(5);
nodeList.addNodeFirst(4);
nodeList.addNodeFirst(3);
nodeList.addNodeFirst(2);
nodeList.addNodeFirst(1);

Console.WriteLine(nodeList.head);
Console.WriteLine(nodeList.tail);
Console.WriteLine("____________________________");

Node node = nodeList.head;

print(node);


Console.WriteLine("_________");

node = nodeList.tail;
nodeList.unrollNode(node);

node = nodeList.head;

print(node);

void print(Node node)
{
    while (node != null)
    {
        Console.WriteLine(node.value);
        node = node.prev;
    }
}