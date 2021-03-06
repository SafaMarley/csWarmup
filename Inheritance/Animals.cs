using System;

namespace Inheritance
{
    public class Animals:Living
    {
        public Animals()
        {
            base.BeFed();
            base.Excretion();
            base.Adaptation();
            base.Respiration();
        }
        public void Heterotrophs()
        {
            Console.WriteLine("All animals must consume living or dead organisms.");
        }

        public override void Responding()
        {
            base.Responding();
            Console.WriteLine("Animals do react.");
        }
    }

    public class Reptiles:Animals
    {
        public Reptiles()
        {
            base.Adaptation();
            base.Responding();

        }

        public void Movement()
        {
            Console.WriteLine("Reptiles move by crawling.");
        }
    }

    public class Birds:Animals
    {
        public Birds()
        {
            base.Adaptation();
            base.Responding();
        }

        public void Movement()
        {
            Console.WriteLine("Most birds are able to fly.");
        }
    }
}