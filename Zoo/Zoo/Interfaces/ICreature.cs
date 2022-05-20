namespace Zoo.AbstractAnimals
{
    internal interface ICreature
    {
        public string Colour { get; }
        public int Limbs { get; }
        public string Name { get; }

        /// <summary>
        /// I can eat.
        /// </summary>
        /// <param name="food">I need food to it.</param>
        public void Eat(string food);

        /// <summary>
        /// I can move.
        /// </summary>
        /// <param name="limbs">I need limbs to move.</param>
        public void Move(int limbs);

        /// <summary>
        /// I can scream.
        /// </summary>
        public void Scream();
    }
}