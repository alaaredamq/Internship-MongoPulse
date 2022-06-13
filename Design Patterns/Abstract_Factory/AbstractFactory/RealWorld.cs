namespace Abstract_Factory.Abstract_Factory;

public class RealWorld {
    // public static void Main() {
    //     ContinentFactory africa = new AfricaFactory();
    //     AnimalWorld world = new AnimalWorld(africa);
    //     world.RunFoodChain();
    //
    //     Console.ReadKey();
    // }

    abstract class ContinentFactory {
        public abstract Plants CreatePlant();
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    class AfricaFactory : ContinentFactory {
        public override Plants CreatePlant() {
            return new Grass();
        }

        public override Herbivore CreateHerbivore() {
            return new Cow();
        }

        public override Carnivore CreateCarnivore() {
            return new Lion();
        }
    }

    abstract class Plants {
    }

    abstract class Herbivore {
        public abstract void Eat(Plants p);
    }

    abstract class Carnivore {
        public abstract void Eat(Herbivore h);
    }

    class Grass : Plants {
    }

    class Cow : Herbivore {
        public override void Eat(Plants p) {
            Console.WriteLine(this.GetType().Name +
                              " eats " + p.GetType().Name);
        }
    }

    class Lion : Carnivore {
        public override void Eat(Herbivore h) {
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }

    class AnimalWorld {
        private Plants _plants;
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory) {
            _plants = factory.CreatePlant();
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain() {
            _herbivore.Eat(_plants);
            _carnivore.Eat(_herbivore);
        }
    }
}