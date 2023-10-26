using SolidPrinciples.DIP;
using SolidPrinciples.Liskov;
using SolidPrinciples.OCP;

namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chef chef = new Chef();

            //MushedPotato potato = new MushedPotato();

            //chef.Cook(potato);

            //FrenchFries french = new FrenchFries();

            //chef.Cook(french);


            //FlyShow<Eagle> flyShow = new FlyShow<Eagle>();

            //flyShow.MakeShow();

            //Bird bird = new Eagle();

            //Bird bird2=new Penguin();

            //bird.Eat();
            //bird2.Eat();


            //Knife knife=new Knife();

            Scissor scissor = new Scissor();

            Pizza pizza = new Pizza(scissor);

            pizza.CutPizza();
        }
    }
}