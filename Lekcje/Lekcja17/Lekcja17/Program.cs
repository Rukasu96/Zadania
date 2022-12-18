
using Lekcja17;

IBiomeFactory factory = new ForestFactory();

ITree tree = factory.CreateTree();
IEnemy enemy = factory.CreateEnemy();