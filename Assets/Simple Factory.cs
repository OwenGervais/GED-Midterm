using UnityEngine;

public class SimpleFactory : MonoBehaviour
{
    public abstract class MakeFruit
    {
        public abstract string Name { get; }

        public abstract void Process();
    }

    public class MakePeach : MakeFruit
    {
        public override string Name => "Peach";

        public override void Process()
        {
            Debug.Log("Peach");
        }
    }

    public class MakeBellpepper : MakeFruit
    {
        public override string Name => "Bellpepper";

        public override void Process()
        {
            Debug.Log("Bellpepper");
        }
    }

    public class AbilityFactory
    {
        public MakeFruit GetFruit(string fruitType)
        {
            switch (fruitType)
            {
                case "Peach":
                    return new MakePeach();
                case "Bellpepper":
                    return new MakeBellpepper();
                default:
                    return null;
            }
        }
    }
}
