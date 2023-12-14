using System;

namespace Otus.Generics.Demo
{

    enum E1
    {
        A = 1
    }


    enum E2
    {
        A = 1,
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Введение в Generic
            new GenericDemo().Show();

            // Наследование Generic
            new InheritanceDemo().Show();

            // Generic с несколькими типами
            new MultipleGenericDemo().Show();

            // Значения по умолчанию в Generic
            new DefaultDemo().Show();

            //Ограничения
            new ClassConstraintsDemo().Show();


            new ConstraintsDemo().Show();

            new CoContrVarDemo().Show();
        }

    }
}
